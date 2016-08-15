Public Class frmPenyesuaianStok
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _result As String = String.Empty

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        createButton("new")
        LockGrid(True)
        dtpTrans.MaxDate = Now.Date

        If isLockData() Then
            btnLock.Tag = "unlock"
            btnLock.Text = "Unlock Data"
            SetLabelStatus("lock")
        Else
            btnLock.Tag = "lock"
            btnLock.Text = "Lock Data"
            SetLabelStatus("unlock")
        End If
    End Sub

    Private Sub SetLabelStatus(ByVal mode As String)
        If mode = "lock" Then
            lblStatusLock.Text = "Data sudah di-LOCK"
            lblStatusLock.ForeColor = Color.Red
        Else
            lblStatusLock.Text = "Data belum di-LOCK"
            lblStatusLock.ForeColor = Color.Green
        End If
    End Sub

    Private Sub createButton(ByVal _mode As String)
        pnlButton.Controls.Clear()
        If _mode = "new" Then
            pnlButton.Controls.Add(btnPreview)
            pnlButton.Controls.Add(btnExit)
        ElseIf _mode = "edit" Then
            pnlButton.Controls.Add(btnSave)
            pnlButton.Controls.Add(btnExit)
        End If

        If pnlButton.Controls.Count > 0 Then
            For Each item As Control In pnlButton.Controls
                item.Visible = True
            Next
        End If
    End Sub

    Private Sub LockGrid(ByVal _isLock As Boolean)
        Select Case _isLock
            Case True
                dgv.ReadOnly = True
            Case False
                dgv.ReadOnly = False
                dgv.Columns("cKodeBarang").ReadOnly = True
                dgv.Columns("cNamaBarang").ReadOnly = True
                dgv.Columns("cUOMName").ReadOnly = True
                dgv.Columns("cUOMId").ReadOnly = True
                dgv.Columns("cStokSekarang").ReadOnly = True
                dgv.Columns("cPenyesuaian").ReadOnly = False
        End Select
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("Kode Barang")    '0
        cboFind.Items.Add("Nama Barang")    '1
        cboFind.Items.Add("UOM")            '2
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtDataPenyesuaianBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "KodeBarang like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "NamaBarang like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "UomName like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Try
            Me.DaDataPenyesuaian.Fill(Me.DsTrans.dtDataPenyesuaian, dtpTrans.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtDataPenyesuaian.Rows.Count > 0 Then
            AddcboFind()
            createButton("edit")
            LockGrid(False)
            frmMain.tlStrpLblStatus.Text = "Total Data = " & DsTrans.dtDataPenyesuaian.Rows.Count & " item"
        End If

        If CheckTelahPenyesuaian() Then
            LockGrid(True)
            createButton("new")
            MessageBox.Show("Tanggal ini sudah dilakukan penyesuaian !!", "Preview Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isLockData() = False Then
            MessageBox.Show("Lakukan Lock Data terlebih dahulu !!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CheckTelahPenyesuaian() Then
            MessageBox.Show("Tanggal ini sudah dilakukan penyesuaian !!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If isClosing(dtpTrans.Value.Date) Then
            MessageBox.Show("Tanggal ini sudah dilakukan closing !!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If dtpTrans.Value.Date > Now.Date Then
            MessageBox.Show("Tanggal transaksi tidak boleh melewati tanggal saat ini !!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CekValidasi() = False Then
            MessageBox.Show("Nilai Penyesuaian harus diisi !!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        dgv.EndEdit()    ' memberhentikan edit data di gridview
        DtDataPenyesuaianBindingSource.EndEdit() ' memberhentikan edit data di databinding

        If con.State = ConnectionState.Closed Then con.Open()
        Dim trans As SqlTransaction = con.BeginTransaction
        Dim _returnValue As String = String.Empty

        Try

            ' --- Proses penyimpanan data ---
            Dim cmdUpdate As New SqlCommand
            With cmdUpdate
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPenyesuaian_InsertData"
                .Parameters.Clear()
                .Parameters.Add("@pTglTrans", SqlDbType.Date, 10, "TglTrans")
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "KodeBarang")
                .Parameters.Add("@pNamaBarang", SqlDbType.VarChar, 50, "NamaBarang")
                .Parameters.Add("@pUomID", SqlDbType.VarChar, 3, "UomID")
                .Parameters.Add("@pStokActual", SqlDbType.Int, 10, "StokSekarang")
                .Parameters.Add("@pStokBaru", SqlDbType.Int, 10, "Penyesuaian")
                .Parameters.Add("@pReturn", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Using da As New SqlDataAdapter
                da.UpdateCommand = cmdUpdate

                da.Update(Me.DsTrans.dtDataPenyesuaian)

                _returnValue = String.Empty

                If TypeOf cmdUpdate.Parameters("@pReturn").Value Is String Then
                    _returnValue = cmdUpdate.Parameters("@pReturn").Value.ToString
                End If
            End Using

            ' Apabila nilai yang dikembalikan dr database nilai stringnya tdk sama dgn 1
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 1
            If _returnValue.Length <> "1" Then
                'Me.DsTrans.dtDataPenyesuaian.RejectChanges()
                If Not String.IsNullOrEmpty(_returnValue) Then
                    MessageBox.Show(_returnValue, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    trans.Rollback()
                    con.Close()
                Else
                    Throw New Exception("Terjadi error pada saat penyimpanan data !")
                End If
                Exit Sub
            End If

            trans.Commit()
            DsTrans.dtDataPenyesuaian.AcceptChanges()
            DsTrans.dtDataPenyesuaian.Rows.Clear()
            createButton("new")

            frmMain.tlStrpLblStatus.Text = "Ready"
            MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            trans.Rollback()
            frmMain.tlStrpLblStatus.Text = "Terjadi error !"
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Function CekValidasi() As Boolean
        Dim result As Boolean = False

        If DsTrans.dtDataPenyesuaian.Rows.Count > 0 Then
            For Each drow As DataRow In DsTrans.dtDataPenyesuaian.Rows
                If drow("Penyesuaian") IsNot Nothing Then
                    If (Not IsDBNull(drow("Penyesuaian"))) Or (Not drow("Penyesuaian").ToString = "") Then
                        result = True
                    Else
                        result = False
                    End If
                End If
            Next
        End If
        Return result
    End Function

    Private Function CheckTelahPenyesuaian() As Boolean
        Dim result As Boolean = False

        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select distinct TglTrans from tPenyesuaianStok where TglTrans=@pTglTrans"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pTglTrans", dtpTrans.Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        ' Jika datanya dapat, berarti tanggal itu sudah dilakukan penyesuaian
        If dt.Rows.Count > 0 Then
            result = True
        End If

        Return result
    End Function

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        Dim _msgKonfirmasi As String = ""

        If btnLock.Tag = "lock" Then
            _msgKonfirmasi = "Anda yakin ingin melakukan LOCK data ?"
        ElseIf btnLock.Tag = "unlock" Then
            _msgKonfirmasi = "Anda yakin ingin melakukan UNLOCK data ?"
        End If

        If Not MessageBox.Show(_msgKonfirmasi, "Konfirmasi LOCK / UNLOCK data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spLock_Save"
        cmd.Parameters.Clear()
        If btnLock.Tag = "lock" Then
            cmd.Parameters.AddWithValue("@pIsLock", True)
        ElseIf btnLock.Tag = "unlock" Then
            cmd.Parameters.AddWithValue("@pIsLock", False)
        End If

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(0).ToString = "1" Then
                If btnLock.Tag = "lock" Then
                    btnLock.Tag = "unlock"
                    btnLock.Text = "Unlock Data"
                    SetLabelStatus("lock")
                    MessageBox.Show("Data sudah di-LOCK", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf btnLock.Tag = "unlock" Then
                    btnLock.Tag = "lock"
                    btnLock.Text = "Lock Data"
                    SetLabelStatus("unlock")
                    MessageBox.Show("Data sudah di-UNLOCK", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(dt.Rows(0)(0).ToString, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class