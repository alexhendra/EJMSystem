Public Class frmPenerimaan
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim modeParent As String = String.Empty
    Dim modeChild As String = String.Empty

    Private Sub frmPenerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        createBtnHeader()
    End Sub

    Private Sub ResetGroupInformation()
        lblTglRetur.Text = String.Empty
        lblTglPesanan.Text = String.Empty
        lblKodeSupplier.Text = String.Empty
        lblNamaSupplier.Text = String.Empty
    End Sub

    Private Sub ResetInputHeader()
        txtKodePenerimaan.Clear()
        rdbPesanan.Checked = True
        dtpTglTerima.Value = Now.Date
        txtNoPesanan.Clear()
        txtKodeRetur.Clear()
    End Sub

    Private Sub ResetInputDetail()
        txtKodeBarang.Clear()
        txtJumlahTerima.Clear()
        lblNamaBarang.Text = ""
        lblUom.Text = ""
        lblJumlahPesanan.Text = ""
        lblJumlahRetur.Text = ""
    End Sub

    Private Sub activeInputHeader(ByVal _isActive As Boolean)
        grpBarang.Enabled = _isActive
        dtpTglTerima.Enabled = _isActive
        txtNoPesanan.Enabled = _isActive
        btnFindPesanan.Enabled = _isActive
    End Sub

    Private Sub activeBtnDetail(ByVal _isActive As Boolean)
        pnlBtnDetail.Enabled = _isActive
    End Sub

    Private Sub activeInputDetail(ByVal _isActive As Boolean)
        txtKodeBarang.Enabled = _isActive
        txtJumlahTerima.Enabled = _isActive
        btnFindBarang.Enabled = _isActive
    End Sub

    Private Sub createBtnHeader()
        pnlBtnHeader.Controls.Clear()
        If modeParent = "new" Then
            pnlBtnHeader.Controls.Add(btnSave)
            pnlBtnHeader.Controls.Add(btnCancel)
            pnlBtnHeader.Controls.Add(btnExit)
        ElseIf modeParent = "update" Then
            pnlBtnHeader.Controls.Add(btnSave)
            pnlBtnHeader.Controls.Add(btnCancel)
            pnlBtnHeader.Controls.Add(btnExit)
        Else
            pnlBtnHeader.Controls.Add(btnNew)
            pnlBtnHeader.Controls.Add(btnExit)
        End If

        If pnlBtnHeader.Controls.Count > 0 Then
            For Each item As Control In pnlBtnHeader.Controls
                item.Visible = True
            Next
        End If
    End Sub

    Private Sub createBtnItemDetail(ByVal _mode As String)
        pnlBtnDetail.Controls.Clear()
        If _mode = "new" Then
            pnlBtnDetail.Controls.Add(btnSaveItem)
            pnlBtnDetail.Controls.Add(btnCancelItem)
        ElseIf _mode = "edit" Then
            pnlBtnDetail.Controls.Add(btnEdit)
            pnlBtnDetail.Controls.Add(btnDelete)
            pnlBtnDetail.Controls.Add(btnCancelItem)
        ElseIf _mode = "update" Then
            pnlBtnDetail.Controls.Add(btnSaveItem)
            pnlBtnDetail.Controls.Add(btnCancelItem)
        Else
            pnlBtnDetail.Controls.Add(btnAdd)
        End If

        If pnlBtnDetail.Controls.Count > 0 Then
            For Each item As Control In pnlBtnDetail.Controls
                item.Visible = True
            Next
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ResetInputHeader()
        txtKodePenerimaan.Enabled = False
        modeParent = "new"
        activeInputHeader(True)
        createBtnHeader()
        activeBtnDetail(True)
        ResetInputDetail()
        ResetGroupInformation()
        createBtnItemDetail("")
        clearDataBarangPenerimaanTabel()

        lblWarning.Text = String.Empty
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Membatalkan perubahan yang ada di data table-nya
        Me.DsTrans.dtDetailBarangTerima.RejectChanges()

        ResetGroupInformation()
        ResetInputHeader()
        activeInputHeader(False)
        modeParent = ""
        createBtnHeader()
        createBtnItemDetail("")
        activeBtnDetail(False)
        ResetInputDetail()
        activeInputDetail(False)
        DsTrans.dtDetailBarangTerima.Rows.Clear()
        txtKodePenerimaan.Enabled = True

        frmMain.tlStrpLblStatus.Text = "Ready"
        lblWarning.Text = String.Empty
    End Sub

    Private Function FindNoPesananByKodeRetur(ByVal kodeRetur As String) As String
        Dim _result As String = String.Empty
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "select No_Pesanan from tReturPembelian_Header where Kode_Retur=@pKodeRetur"
                .CommandType = CommandType.Text
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeRetur", kodeRetur.Trim)
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0)("No_Pesanan")) Then
                _result = dt.Rows(0)("No_Pesanan").ToString.Trim
            End If
        Else
            lblWarning.Text = "Data detail retur tidak ditemukan !"
        End If

        Return _result
    End Function

    Private Sub GetDataHeader(ByVal kodePenerimaan As String)
        Dim dt As DataTable
        Dim _sdhDigunakan As Boolean = False

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spPenerimaan_GetDataHeader"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePenerimaan", kodePenerimaan.Trim)
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                txtNoPesanan.Text = drow("No_Pesanan").ToString
                If Not IsDBNull(drow("isRetur")) Then
                    If drow("isRetur").ToString = "1" Then
                        rdbRetur.Checked = True
                    End If
                End If
                dtpTglTerima.Value = CDate(drow("Tgl_Penerimaan"))
                If Not IsDBNull(drow("Kode_Retur")) Then txtKodeRetur.Text = drow("Kode_Retur").ToString
                If Not IsDBNull(drow("Tgl_Retur")) Then txtKodeRetur.Text = drow("Tgl_Retur").ToString
                lblTglPesanan.Text = Format(drow("Tgl_Pesanan"), "MM/dd/yyyy")
                lblKodeSupplier.Text = drow("Kode_Supplier").ToString
                lblNamaSupplier.Text = drow("Nama_Supplier").ToString
                _sdhDigunakan = drow("sudahDigunakan")
            Next
            GetTabelBarangPenerimaan(txtKodePenerimaan.Text)
            If _sdhDigunakan Then
                lblWarning.Text = "Kode Penerimaan ini sudah digunakan di proses lain (retur atau pembelian) !"
                Exit Sub
            End If
            modeParent = "update"
            createBtnHeader()
            txtKodePenerimaan.Enabled = False
            activeBtnDetail(True)
        Else
            lblWarning.Text = "Data tidak ditemukan !"
        End If
    End Sub

    Private Sub GetDataInformation(ByVal noPesanan As String)
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spPenerimaan_GetInformationDetail"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pNoPesanan", noPesanan.Trim)
                If rdbRetur.Checked Then
                    .Parameters.AddWithValue("@pJenisPenerimaan", "retur")
                Else
                    .Parameters.AddWithValue("@pJenisPenerimaan", "pesanan")
                End If
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                txtNoPesanan.Text = drow("No_Pesanan").ToString.Trim
                lblTglPesanan.Text = Format(drow("Tgl_Pesanan"), "MM/dd/yyyy")
                If Not IsDBNull(drow("Kode_Retur")) Then txtKodeRetur.Text = drow("Kode_Retur").ToString
                If Not IsDBNull(drow("Tgl_Retur")) Then lblTglRetur.Text = Format(drow("Tgl_Retur"), "MM/dd/yyyy")
                lblKodeSupplier.Text = drow("Kode_Supplier").ToString
                lblNamaSupplier.Text = drow("Nama_Supplier").ToString
            Next
        Else
            lblWarning.Text = "Data tidak ditemukan !"
        End If
    End Sub

    Private Sub clearDataBarangPenerimaanTabel()
        Me.DsTrans.dtDetailBarangTerima.Rows.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTglTerima.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If rdbPesanan.Checked Then
            If String.IsNullOrEmpty(txtNoPesanan.Text) Then
                lblWarning.Text = "No. Pesanan harus diisi !!!"
                Exit Sub
            End If
        End If

        If rdbRetur.Checked Then
            If String.IsNullOrEmpty(txtKodeRetur.Text) Then
                lblWarning.Text = "Kode Retur harus diisi !!!"
                Exit Sub
            End If
        End If

        If DsTrans.dtDetailBarangTerima.Rows.Count < 1 Then
            lblWarning.Text = "Silahkan masukkan item penerimaan terlebih dahulu !!!"
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        '' -- Melakukan validasi inputan user --
        'Dim dtValidasi As DataTable
        'Using cmd As New SqlCommand

        '    With cmd
        '        .Connection = con
        '        .CommandTimeout = 120
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "spPenerimaan_CheckDataValid"
        '        .Parameters.Clear()
        '        .Parameters.AddWithValue("@pKodePenerimaan", txtKodePenerimaan.Text.Trim)
        '        .Parameters.AddWithValue("@pKodePembelian", txtNoPesanan.Text.Trim)
        '        .Parameters.AddWithValue("@pKodeRetur", txtKodeRetur.Text.Trim)
        '        .Parameters.AddWithValue("@pMode", modeParent.Trim)
        '        If rdbRetur.Checked Then
        '            .Parameters.AddWithValue("@pJenisPenerimaan", "retur")
        '        Else
        '            .Parameters.AddWithValue("@pJenisPenerimaan", "pembelian")
        '        End If
        '    End With
        '    Using da As New SqlDataAdapter(cmd)
        '        dtValidasi = New DataTable
        '        da.Fill(dtValidasi)
        '    End Using
        'End Using
        'If dtValidasi.Rows.Count > 0 Then
        '    If dtValidasi.Rows(0)(0).ToString <> "1" Then
        '        lblWarning.Text = dtValidasi.Rows(0)(0).ToString
        '        Exit Sub
        '    End If
        'End If
        '' ------------------

        dgv.EndEdit()    ' memberhentikan edit data di gridview
        DtDetailBarangTerimaBindingSource.EndEdit() ' memberhentikan edit data di databinding

        If con.State = ConnectionState.Closed Then con.Open()
        Dim trans As SqlTransaction = con.BeginTransaction
        Dim _returnValue As String = String.Empty

        Try
            ' --- Proses simpan data penerimaan header ---
            Using cmd As New SqlCommand
                With cmd
                    .Connection = con
                    .CommandTimeout = 120
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "spPenerimaan_SaveHeader"
                    .Parameters.Clear()
                    If String.IsNullOrEmpty(txtKodePenerimaan.Text) Then
                        .Parameters.AddWithValue("@pKodePenerimaan", "new")
                    Else
                        .Parameters.AddWithValue("@pKodePenerimaan", txtKodePenerimaan.Text.Trim)
                    End If
                    .Parameters.AddWithValue("@pNoPesanan", txtNoPesanan.Text.Trim)
                    If String.IsNullOrEmpty(txtKodeRetur.Text) Then
                        .Parameters.AddWithValue("@pKodeRetur", DBNull.Value)
                    Else
                        .Parameters.AddWithValue("@pKodeRetur", txtKodeRetur.Text.Trim)
                    End If

                    .Parameters.AddWithValue("@pTglPenerimaan", dtpTglTerima.Value)
                    .Parameters.AddWithValue("@pKodeSupplier", lblKodeSupplier.Text.Trim)
                    If rdbRetur.Checked Then
                        .Parameters.AddWithValue("@pJenisPenerimaan", "retur")
                    Else
                        .Parameters.AddWithValue("@pJenisPenerimaan", "pembelian")
                    End If

                    .Parameters.AddWithValue("@pMode", modeParent.Trim)

                    .Parameters.Add("@pReturn", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output
                    .Transaction = trans
                    .ExecuteNonQuery()

                    If TypeOf .Parameters("@pReturn").Value Is String Then
                        _returnValue = .Parameters("@pReturn").Value.ToString
                    End If
                End With
            End Using

            ' Apabila nilai yang dikembalikan dr database panjang stringnya tdk 14
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 14 (kembalikan No_Pesanan)
            If _returnValue.Length <> 14 Then
                trans.Rollback()
                con.Close()
                Me.DsTrans.dtDetailBarangTerima.RejectChanges()
                Me.DsTrans.dtDetailBarangTerima.Rows.Clear()

                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            If Me.DsTrans.dtDetailBarangTerima.GetChanges() Is Nothing Then
                trans.Commit()
                modeParent = ""
                ResetInputHeader()
                ResetGroupInformation()
                activeInputHeader(False)
                txtKodePenerimaan.Enabled = True
                createBtnHeader()
                clearDataBarangPenerimaanTabel()
                activeBtnDetail(False)

                If con.State = ConnectionState.Open Then con.Close()

                frmMain.tlStrpLblStatus.Text = "Ready"
                MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' --- Proses penyimpanan data penerimaan detail ---
            Dim cmdSave As New SqlCommand
            With cmdSave
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPenerimaan_SaveDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePenerimaan", _returnValue.Trim)
                .Parameters.AddWithValue("@pNoPesanan", txtNoPesanan.Text.Trim)
                .Parameters.AddWithValue("@pKodeRetur", txtKodeRetur.Text.Trim)
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
                .Parameters.Add("@pJumlahPenerimaan", SqlDbType.Int, 20, "JumlahTerima")
                .Parameters.Add("@pModeChild", SqlDbType.VarChar, 10, "pMode")
                .Parameters.AddWithValue("@pModeParent", modeParent)
                If rdbRetur.Checked Then
                    .Parameters.AddWithValue("@pJenisPenerimaan", "retur")
                Else
                    .Parameters.AddWithValue("@pJenisPenerimaan", "pesanan")
                End If
                .Parameters.Add("@pReturn", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Using da As New SqlDataAdapter
                da.InsertCommand = cmdSave
                da.UpdateCommand = cmdSave

                da.Update(Me.DsTrans.dtDetailBarangTerima)

                _returnValue = String.Empty

                If TypeOf cmdSave.Parameters("@pReturn").Value Is String Then
                    _returnValue = cmdSave.Parameters("@pReturn").Value.ToString
                End If
            End Using

            ' Apabila nilai yang dikembalikan dr database nilai stringnya tdk sama dgn 1
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 1
            If _returnValue.Length <> "1" Then
                Me.DsTrans.dtDetailBarangTerima.RejectChanges()
                Me.DsTrans.dtDetailBarangTerima.Rows.Clear()

                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                    trans.Rollback()
                Else
                    Throw New Exception("Terjadi error pada saat penyimpanan data !")
                    'MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            trans.Commit()
            DsTrans.dtDetailBarangTerima.AcceptChanges()
            modeParent = ""
            ResetInputHeader()
            ResetGroupInformation()
            activeInputHeader(False)
            txtKodePenerimaan.Enabled = True
            activeBtnDetail(False)
            createBtnHeader()
            clearDataBarangPenerimaanTabel()

            frmMain.tlStrpLblStatus.Text = "Ready"
            MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            trans.Rollback()
            Me.DsTrans.dtDetailBarangTerima.RejectChanges()
            Me.DsTrans.dtDetailBarangTerima.Rows.Clear()
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub GetTabelBarangPenerimaan(ByVal _kodePenerimaan As String)
        Me.DsTrans.dtDetailBarangTerima.Clear()
        Me.DaDetailBarangTerima.Fill(Me.DsTrans.dtDetailBarangTerima, _kodePenerimaan.Trim)
    End Sub

    Private Sub txtKodePenerimaan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePenerimaan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            GetDataHeader(txtKodePenerimaan.Text)
        End If
    End Sub

    Private Sub txtNoPesanan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoPesanan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtNoPesanan.Text) Then
                ResetGroupInformation()
                GetDataInformation(txtNoPesanan.Text)
            End If
        End If
    End Sub

    Private Sub txtKodeRetur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeRetur.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeRetur.Text) Then
                ResetGroupInformation()
                txtNoPesanan.Clear()

                Dim _result As String = FindNoPesananByKodeRetur(txtKodeRetur.Text.Trim)
                If Not String.IsNullOrEmpty(_result) Then
                    txtNoPesanan.Text = _result
                    GetDataInformation(_result)
                End If
            End If
        End If
    End Sub

    Private Sub rdbRetur_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRetur.CheckedChanged, rdbPesanan.CheckedChanged
        txtNoPesanan.Clear()
        txtKodeRetur.Clear()
        ResetGroupInformation()

        If rdbRetur.Enabled Then
            txtKodeRetur.Enabled = rdbRetur.Checked
            btnFindRetur.Enabled = rdbRetur.Checked
            txtKodeRetur.Focus()
        End If

        If rdbPesanan.Enabled Then
            txtNoPesanan.Enabled = rdbPesanan.Checked
            btnFindPesanan.Enabled = rdbPesanan.Checked
            txtNoPesanan.Focus()
        End If
    End Sub

    Private Sub btnFindPesanan_Click(sender As Object, e As EventArgs) Handles btnFindPesanan.Click
        ResetGroupInformation()

        Dim _frmFindPesananAll As New frmFindPesananAll
        _frmFindPesananAll.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindPesananAll.getResult
        If _returnList IsNot Nothing Then
            txtNoPesanan.Text = _returnList(0)
            lblTglPesanan.Text = _returnList(1)
            lblKodeSupplier.Text = _returnList(2)
            lblNamaSupplier.Text = _returnList(3)
        End If
        _frmFindPesananAll = Nothing
    End Sub

    Private Sub btnFindRetur_Click(sender As Object, e As EventArgs) Handles btnFindRetur.Click
        ResetGroupInformation()

        Dim _frmFindReturAll As New frmFindReturAll
        _frmFindReturAll.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindReturAll.getResult
        If _returnList IsNot Nothing Then
            txtKodeRetur.Text = _returnList(0)
            lblTglRetur.Text = _returnList(1)
            lblKodeSupplier.Text = _returnList(2)
            lblNamaSupplier.Text = _returnList(3)
        End If
        _frmFindReturAll = Nothing
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        modeChild = "new"
        createBtnItemDetail("new")
        ResetInputDetail()
        activeInputDetail(True)
        txtKodeBarang.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        modeChild = "update"
        activeInputDetail(True)
        createBtnItemDetail("update")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        lblWarning.Text = String.Empty

        Dim drow As DataRow

        If String.IsNullOrEmpty(txtKodeBarang.Text) Then
            lblWarning.Text = "Silahkan pilih data yang akan dihapus dari tabel terlebih dahulu !!"
            Exit Sub
        Else
            drow = DsTrans.dtDetailBarangTerima.FindByKode_Barang(txtKodeBarang.Text)
        End If

        If drow IsNot Nothing Then
            drow.Delete()
            drow.AcceptChanges()
            drow = DsTrans.dtDetailBarangTerima.FindByKode_Barang(txtKodeBarang.Text)

            If drow Is Nothing Then
                modeChild = "delete"
                ResetInputDetail()
                createBtnItemDetail("")
                activeInputDetail(False)
            End If
        End If
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTglTerima.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeBarang.Text) Then
            lblWarning.Text = "Input Kode Barang terlebih dahulu !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtJumlahTerima.Text) Then
            lblWarning.Text = "Jumlah barang yang diterima harus diisi !!"
            Exit Sub
        End If

        If Not IsNumeric(txtJumlahTerima.Text) Then
            lblWarning.Text = "Jumlah barang yang diterima harus diisi dengan angka !!"
            Exit Sub
        End If

        Dim drowArr As DataRow() = DsTrans.dtDetailBarangTerima.Select("Kode_Barang='" & txtKodeBarang.Text.Trim & "'")
        If drowArr.Count > 0 And modeChild = "new" Then
            lblWarning.Text = "Item barang ini sudah ada di tabel !!"
            Exit Sub
        End If

        Dim drow As DataRow
        If modeChild = "new" Then
            drow = Me.DsTrans.dtDetailBarangTerima.NewRow
        Else
            drow = DsTrans.dtDetailBarangTerima.FindByKode_Barang(txtKodeBarang.Text.Trim)
        End If

        drow.BeginEdit()

        drow("Kode_Barang") = txtKodeBarang.Text.Trim
        drow("Nama_Barang") = lblNamaBarang.Text.Trim
        drow("UomName") = lblUom.Text.Trim
        drow("JumlahPesan") = lblJumlahPesanan.Text.Trim
        drow("JumlahRetur") = lblJumlahRetur.Text.Trim
        drow("JumlahTerima") = txtJumlahTerima.Text.Trim

        ' Mode parentnya = new, mode childnya harus new jgn ikut berubah, karena data header baru pasti data detailnya juga baru
        ' Kecuali klo mode parent != new, berarti data header sudah ada sebelumnya, dan data detailnya mungkin baru ditambahkan atau diupdate
        ' atau didelete dari database
        If modeParent = "new" Then
            drow("pMode") = "new"
        Else
            If drow("pMode") IsNot Nothing Then
                If drow("pMode").ToString = "new" Then
                    drow("pMode") = "new"
                Else
                    drow("pMode") = modeChild.Trim
                End If
            End If
        End If

        ' ini beda arti dari penggunaannya, ini menganggap klo data mode child = new brarti data detail baru
        ' tanpa memandang status dari mode parentnya
        ' kalau item detail = baru, maka buatkan row baru di datatablenya.
        If modeChild = "new" Then
            Me.DsTrans.dtDetailBarangTerima.Rows.Add(drow)
        End If
        drow.EndEdit()

        ResetInputDetail()
        createBtnItemDetail("")
        activeInputDetail(False)

        If DsTrans.dtDetailBarangTerima.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub btnCancelItem_Click(sender As Object, e As EventArgs) Handles btnCancelItem.Click
        modeChild = ""
        ResetInputDetail()
        createBtnItemDetail("")
        activeInputDetail(False)
    End Sub

    Private Sub btnFindBarang_Click(sender As Object, e As EventArgs) Handles btnFindBarang.Click
        If rdbPesanan.Checked Then
            Dim _frmFindBarangPesanan As New frmFindBarangPesanan(txtNoPesanan.Text.Trim)
            _frmFindBarangPesanan.ShowDialog()
            Dim _returnList As List(Of String) = _frmFindBarangPesanan.getResult
            If _returnList IsNot Nothing Then
                txtKodeBarang.Text = _returnList(0)
                lblNamaBarang.Text = _returnList(1)
                lblUom.Text = _returnList(2)
                lblJumlahPesanan.Text = _returnList(3)
                lblJumlahRetur.Text = _returnList(4)
            End If
            _frmFindBarangPesanan = Nothing
        Else
            Dim _frmFindBarangRetur As New frmFindBarangRetur(txtKodeRetur.Text.Trim)
            _frmFindBarangRetur.ShowDialog()
            Dim _returnList As List(Of String) = _frmFindBarangRetur.getResult
            If _returnList IsNot Nothing Then
                txtKodeBarang.Text = _returnList(0)
                lblNamaBarang.Text = _returnList(1)
                lblUom.Text = _returnList(2)
                lblJumlahPesanan.Text = _returnList(3)
                lblJumlahRetur.Text = _returnList(4)
            End If
            _frmFindBarangRetur = Nothing
        End If
        
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        With dgv
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then

                    txtKodeBarang.Text = .SelectedRows(0).Cells("cKodeBarang").Value
                    lblNamaBarang.Text = .SelectedRows(0).Cells("cNamaBarang").Value
                    lblUom.Text = .SelectedRows(0).Cells("cUOM").Value
                    lblJumlahPesanan.Text = .SelectedRows(0).Cells("cJumlahPesan").Value
                    If .SelectedRows(0).Cells("cJumlahRetur").Value IsNot Nothing Then
                        If Not IsDBNull(.SelectedRows(0).Cells("cJumlahRetur").Value) Then
                            lblJumlahRetur.Text = .SelectedRows(0).Cells("cJumlahRetur").Value
                        End If
                    End If

                    txtJumlahTerima.Text = .SelectedRows(0).Cells("cJumlahTerima").Value

                    activeInputDetail(False)
                    modeChild = "edit"
                    createBtnItemDetail("edit")
                End If
            End If
        End With
    End Sub

    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        If DsTrans.dtDetailBarangTerima.GetChanges IsNot Nothing Then
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub dgv_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        If DsTrans.dtDetailBarangTerima.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeBarang.Text) Then
                GetInfoBarang(txtKodeBarang.Text.Trim)
            End If
        End If
    End Sub

    Private Sub txtJumlahTerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahTerima.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GetInfoBarang(ByVal kodeBarang As String)
        ResetInputDetail()

        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spPenerimaan_FindBarangByKode"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeBarang", kodeBarang.Trim)
                If rdbRetur.Checked Then
                    .Parameters.AddWithValue("@pJenisPenerimaan", "retur")
                    .Parameters.AddWithValue("@pKodeJenis", txtKodeRetur.Text.Trim)
                Else
                    .Parameters.AddWithValue("@pJenisPenerimaan", "pesanan")
                    .Parameters.AddWithValue("@pKodeJenis", txtNoPesanan.Text.Trim)
                End If

                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                txtKodeBarang.Text = drow("Kode_Barang").ToString.Trim
                lblNamaBarang.Text = drow("Nama_Barang").ToString
                lblUom.Text = drow("UomName").ToString
                lblJumlahPesanan.Text = drow("JumlahPesan").ToString
                lblJumlahRetur.Text = drow("JumlahRetur").ToString
            Next
        Else
            lblWarning.Text = "Data Barang tidak ditemukan !"
        End If
    End Sub
End Class