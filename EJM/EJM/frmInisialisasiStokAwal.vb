Public Class frmInisialisasiStokAwal
    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        createButton("new")
        LockGrid(True)
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Me.DaInisialisasiStokAwal.Fill(Me.DsTrans.dtInisialisasiStokAwal)

        If Me.DsTrans.dtInisialisasiStokAwal.Rows.Count > 0 Then
            createButton("edit")
            LockGrid(False)

            frmMain.tlStrpLblStatus.Text = "Total data = " & Me.DsTrans.dtInisialisasiStokAwal.Rows.Count & " item"
        Else
            MessageBox.Show("Tidak ditemukan barang yang perlu dilakukan inisialisasi stok awal.", "Preview Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                dgv.Columns("cStokAwal").ReadOnly = False
        End Select
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
        frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If CekValidasi() = False Then
            MessageBox.Show("Stok awal per barang harus diisi !!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        dgv.EndEdit()    ' memberhentikan edit data di gridview
        DtInisialisasiStokAwalBindingSource.EndEdit() ' memberhentikan edit data di databinding

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
                .CommandText = "spStok_InisialisasiInsert"
                .Parameters.Clear()
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
                .Parameters.Add("@pUOMId", SqlDbType.VarChar, 3, "UOM")
                .Parameters.Add("@pStokAwal", SqlDbType.Int, 10, "SisaStok")
                .Parameters.Add("@pReturn", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Using da As New SqlDataAdapter
                da.UpdateCommand = cmdUpdate

                da.Update(Me.DsTrans.dtInisialisasiStokAwal)

                _returnValue = String.Empty

                If TypeOf cmdUpdate.Parameters("@pReturn").Value Is String Then
                    _returnValue = cmdUpdate.Parameters("@pReturn").Value.ToString
                End If
            End Using

            ' Apabila nilai yang dikembalikan dr database nilai stringnya tdk sama dgn 1
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 1
            If _returnValue.Length <> "1" Then
                Me.DsTrans.dtInisialisasiStokAwal.RejectChanges()
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
            DsTrans.dtInisialisasiStokAwal.AcceptChanges()
            DsTrans.dtInisialisasiStokAwal.Rows.Clear()
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

        If DsTrans.dtInisialisasiStokAwal.Rows.Count > 0 Then
            For Each drow As DataRow In DsTrans.dtInisialisasiStokAwal.Rows
                If drow("SisaStok") IsNot Nothing Then
                    If (Not IsDBNull(drow("SisaStok"))) Or (Not drow("SisaStok").ToString = "") Then
                        result = True
                    Else
                        result = False
                    End If

                End If
            Next
        End If
        Return result
    End Function
End Class