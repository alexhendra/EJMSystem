Public Class frmReturPembelian
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim modeParent As String = String.Empty
    Dim modeChild As String = String.Empty

    Private Sub frmPesananPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        clearInputDetail()
        clearInputHeader()
        clearInfoPembelian()
        createBtnHeader()
        createBtnItemBarang("")
        txtKodeRetur.Focus()
    End Sub

    Private Sub txtJumlahPesan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahRetur.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtKodePembelian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePenerimaan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodePenerimaan.Text) Then
                clearInfoPembelian()
                findInfoDetail(txtKodePenerimaan.Text.Trim)
            End If
        End If
    End Sub

    Private Sub getDataHeader(ByVal _kodeRetur As String)
        Dim dt As New DataTable
        Dim _sdhDigunakan As Boolean = False

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandText = "spRetur_GetReturHeader"
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 120
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeRetur", _kodeRetur.Trim)
            End With
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                txtKodePenerimaan.Text = dr("Kode_Penerimaan").ToString
                dtpTglRetur.Value = dr("Tgl_Retur")
                _sdhDigunakan = dr("sudahDigunakan")
            Next
            findInfoDetail(txtKodePenerimaan.Text)
            getDataBarangReturTabel(txtKodeRetur.Text)

            If _sdhDigunakan Then
                lblWarning.Text = "Kode Retur ini sudah digunakan di proses Penerimaan tidak bisa di-update kembali !"
                Exit Sub
            End If

            activeInputHeader(False)
            modeParent = "update"
            createBtnHeader()
            activeBtnDetail(True)
        Else
            MessageBox.Show("Data tidak ditemukan !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub findInfoDetail(ByVal kodePenerimaan As String)
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spRetur_GetInfoDetailPenerimaan"
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
                lblNoPesanan.Text = drow("No_Pesanan").ToString
                lblTglPesanan.Text = Format(drow("Tgl_Pesanan"), "MM/dd/yyyy")
                lblKodeSupplier.Text = drow("Kode_Supplier").ToString
                lblNamaSupplier.Text = drow("Nama_Supplier").ToString
            Next
        Else
            MessageBox.Show("Data tidak ditemukan !", "Pencarian data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub findDetailBarangPenerimaanByKode(ByVal kodePenerimaan As String, ByVal kodeBarang As String)
        Dim dt As New DataTable
        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandText = "spRetur_GetFindBarangPenerimaanByKode"
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 120
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePenerimaan", kodePenerimaan.Trim)
                .Parameters.AddWithValue("@pKodeBarang", kodeBarang.Trim)
            End With
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        clearInputDetail()
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                lblNamaBarang.Text = dr("Nama_Barang").ToString
                lblUOM.Text = dr("uomName").ToString
            Next
        Else
            MessageBox.Show("Data tidak ditemukan !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Membatalkan perubahan yang ada di data table-nya data set
        Me.DsTrans.dtDataBarangRetur.RejectChanges()

        clearInputDetail()
        activeInputDetail(False)
        clearInputHeader()
        activeInputHeader(False)
        clearInfoPembelian()
        modeParent = ""
        modeChild = ""
        createBtnHeader()
        createBtnItemBarang("")
        activeBtnDetail(False)
        DsTrans.dtDataBarangRetur.Rows.Clear()

        txtKodeRetur.Enabled = True
        frmMain.tlStrpLblStatus.Text = "Ready"
        lblWarning.Text = String.Empty
    End Sub

    Private Sub getDataBarangReturTabel(ByVal _kodeRetur As String)
        Me.DaDataBarangRetur.Fill(Me.DsTrans.dtDataBarangRetur, _kodeRetur.Trim)
    End Sub

    Private Sub clearDataPesananTabel()
        Me.DsTrans.dtDataBarangRetur.Rows.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        modeChild = "new"
        createBtnItemBarang("new")
        clearInputDetail()
        activeInputDetail(True)
        txtKodeBarang.Focus()
    End Sub

    Private Sub clearInfoPembelian()
        lblNoPesanan.Text = String.Empty
        lblTglPesanan.Text = String.Empty
        lblKodeSupplier.Text = String.Empty
        lblNamaSupplier.Text = String.Empty
    End Sub

    Private Sub clearInputDetail()
        txtKodeBarang.Clear()
        lblNamaBarang.Text = String.Empty
        lblUOM.Text = String.Empty
        txtJumlahRetur.Clear()
        rtxAlasanRetur.Clear()
    End Sub

    Private Sub clearInputHeader()
        txtKodeRetur.Text = String.Empty
        txtKodePenerimaan.Text = String.Empty
        lblNamaSupplier.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodePenerimaan.Text) And Not String.IsNullOrEmpty(txtKodeBarang.Text) Then
                findDetailBarangPenerimaanByKode(txtKodePenerimaan.Text, txtKodeBarang.Text)
            End If
        End If

    End Sub


    Private Sub createBtnItemBarang(ByVal _mode As String)
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
            'pnlBtnDetail.Controls.Add(btnCancelItem)
        End If

        If pnlBtnDetail.Controls.Count > 0 Then
            For Each item As Control In pnlBtnDetail.Controls
                item.Visible = True
            Next
        End If
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

    Private Sub activeInputHeader(ByVal _isActive As Boolean)
        txtKodePenerimaan.Enabled = _isActive
        dtpTglRetur.Enabled = _isActive
        btnFindPenerimaan.Enabled = _isActive
    End Sub

    Private Sub activeInputDetail(ByVal _isActive As Boolean)
        txtKodeBarang.Enabled = _isActive
        txtJumlahRetur.Enabled = _isActive
        rtxAlasanRetur.Enabled = _isActive
        btnFindBarang.Enabled = _isActive
    End Sub

    Private Sub activeBtnDetail(ByVal _isActive As Boolean)
        pnlBtnDetail.Enabled = _isActive
    End Sub

    Private Sub btnCancelItem_Click(sender As Object, e As EventArgs) Handles btnCancelItem.Click
        modeChild = ""
        clearInputDetail()
        createBtnItemBarang("")
        activeInputDetail(False)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim drow As DataRow

        If String.IsNullOrEmpty(txtKodePenerimaan.Text) Then
            lblWarning.Text = "Isi Kode Penerimaan terlebih dahulu !"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeBarang.Text) Then
            lblWarning.Text = "Isi Kode Barang terlebih dahulu !"
            Exit Sub
        End If

        drow = DsTrans.dtDataBarangRetur.FindByKode_Barang(txtKodeBarang.Text.Trim)

        If drow IsNot Nothing Then
            drow.Delete()
            drow.EndEdit()

            drow = DsTrans.dtDataBarangRetur.FindByKode_Barang(txtKodeBarang.Text.Trim)

            If drow Is Nothing Then
                modeChild = "delete"
                createBtnItemBarang("")
                clearInputDetail()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTglRetur.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodePenerimaan.Text) Then
            lblWarning.Text = "Kode Supplier harus diisi !!!"
            Exit Sub
        End If

        If DsTrans.dtDataBarangRetur.Rows.Count < 1 Then
            lblWarning.Text = "Silahkan masukkan item barang yang akan diretur ke dalam tabel !!!"
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        dgv.EndEdit()    ' memberhentikan edit data di gridview retur
        DtDataBarangReturBindingSource.EndEdit() ' memberhentikan edit data di databinding retur

        If con.State = ConnectionState.Closed Then con.Open()
        Dim trans As SqlTransaction = con.BeginTransaction
        Dim _returnValue As String = String.Empty

        Try
            ' --- Proses simpan data retur header ---
            Using cmd As New SqlCommand
                With cmd
                    .Connection = con
                    .CommandTimeout = 120
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "spRetur_SaveHeader"
                    .Parameters.Clear()
                    If String.IsNullOrEmpty(txtKodeRetur.Text) Then
                        .Parameters.AddWithValue("@pKodeRetur", "new")
                    Else
                        .Parameters.AddWithValue("@pKodeRetur", txtKodeRetur.Text.Trim)
                    End If
                    .Parameters.AddWithValue("@pNoPesanan", lblNoPesanan.Text.Trim)
                    .Parameters.AddWithValue("@pKodePenerimaan", txtKodePenerimaan.Text.Trim)
                    .Parameters.AddWithValue("@pTglRetur", dtpTglRetur.Value)
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
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 14 (kembalikan Kode_Retur)
            If _returnValue.Length <> 14 Then
                trans.Rollback()
                con.Close()
                Me.DsTrans.dtDataBarangRetur.RejectChanges()
                Me.DsTrans.dtDataBarangRetur.Clear()
                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            If Me.DsTrans.dtDataBarangRetur.GetChanges() Is Nothing Then
                trans.Commit()
                modeParent = "new"
                clearInputDetail()
                clearInputHeader()
                clearInfoPembelian()
                clearDataPesananTabel()
                createBtnItemBarang("")
                txtKodeRetur.Enabled = True
                frmMain.tlStrpLblStatus.Text = "Ready"
                MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' --- Proses penyimpanan data retur detail ---
            Dim cmdSave As New SqlCommand
            With cmdSave
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spRetur_SaveDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeRetur", _returnValue.Trim)
                .Parameters.AddWithValue("@pKodePenerimaan", txtKodePenerimaan.Text.Trim)
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
                .Parameters.Add("@pJumlahRetur", SqlDbType.Int, 10, "JumlahRetur")
                .Parameters.Add("@pAlasanRetur", SqlDbType.Text, -1, "Alasan_Retur")
                .Parameters.Add("@pModeChild", SqlDbType.VarChar, 10, "pMode")
                .Parameters.AddWithValue("@pModeParent", modeParent.Trim)
                .Parameters.Add("@pReturn", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Dim cmdDelete As New SqlCommand
            With cmdDelete
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spRetur_DeleteDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeRetur", _returnValue.Trim)
                .Parameters.AddWithValue("@pKodePenerimaan", txtKodePenerimaan.Text.Trim)
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
                .Parameters.Add("@pReturn", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Using da As New SqlDataAdapter
                da.InsertCommand = cmdSave
                da.UpdateCommand = cmdSave
                da.DeleteCommand = cmdDelete

                da.Update(Me.DsTrans.dtDataBarangRetur)

                _returnValue = String.Empty
                If cmdDelete.Parameters("@pReturn").Value IsNot Nothing Then
                    If TypeOf cmdDelete.Parameters("@pReturn").Value Is String Then
                        _returnValue = cmdDelete.Parameters("@pReturn").Value.ToString
                    End If
                Else
                    If TypeOf cmdSave.Parameters("@pReturn").Value Is String Then
                        _returnValue = cmdSave.Parameters("@pReturn").Value.ToString
                    End If
                End If
            End Using

            ' Apabila nilai yang dikembalikan dr database nilai stringnya tdk sama dgn 1
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 1
            If _returnValue.Length <> "1" Then
                trans.Rollback()
                con.Close()
                Me.DsTrans.dtDataBarangRetur.RejectChanges()
                Me.DsTrans.dtDataBarangRetur.Clear()

                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue.Trim
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            trans.Commit()
            DsTrans.dtDataBarangRetur.AcceptChanges()
            modeParent = ""
            modeChild = ""
            clearInputDetail()
            activeInputDetail(False)
            clearInputHeader()
            clearInfoPembelian()
            activeInputHeader(False)
            clearDataPesananTabel()
            createBtnItemBarang("")
            activeBtnDetail(False)
            createBtnHeader()
            txtKodeRetur.Enabled = True
            frmMain.tlStrpLblStatus.Text = "Ready"
            MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            trans.Rollback()
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTglRetur.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodePenerimaan.Text) Then
            lblWarning.Text = "Kode Pembelian harus diisi !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeBarang.Text) Then
            lblWarning.Text = "Kode Barang harus diisi !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtJumlahRetur.Text) Then
            lblWarning.Text = "Jumlah pesanan harus diisi !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(rtxAlasanRetur.Text) Then
            lblWarning.Text = "Alasan retur harus diisi !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(lblNamaBarang.Text) Then
            lblWarning.Text = "Kode Barang tidak benar !!!"
            Exit Sub
        End If


        Dim drow As DataRow
        If modeChild = "new" Then
            drow = Me.DsTrans.dtDataBarangRetur.NewRow
        Else
            drow = DsTrans.dtDataBarangRetur.FindByKode_Barang(txtKodeBarang.Text.Trim)
        End If

        ' Proses mencegah ada barang yang sama diinput lebih dari 1 kali ke tabel pesanan
        Dim drowArr As DataRow() = DsTrans.dtDataBarangRetur.Select("Kode_Barang='" & txtKodeBarang.Text.Trim & "'")
        If drowArr.Count > 1 Then
            lblWarning.Text = "Item barang ini sudah ada di tabel !!!"
            Exit Sub
        End If

        If modeChild <> "new" Then drow.BeginEdit()

        drow("Kode_Barang") = txtKodeBarang.Text.Trim
        drow("Nama_Barang") = lblNamaBarang.Text.Trim
        drow("UomName") = lblUOM.Text.Trim
        drow("JumlahRetur") = txtJumlahRetur.Text.Trim
        drow("Alasan_Retur") = rtxAlasanRetur.Text.Trim

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
            Me.DsTrans.dtDataBarangRetur.Rows.Add(drow)
        Else
            drow.EndEdit()
        End If

        clearInputDetail()
        createBtnItemBarang("")
        activeInputDetail(False)
        txtKodePenerimaan.Enabled = False

        If DsTrans.dtDataBarangRetur.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        modeChild = "update"
        activeInputDetail(True)
        createBtnItemBarang("update")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        modeParent = "new"
        clearInputHeader()
        clearInfoPembelian()
        clearInputDetail()
        createBtnHeader()
        activeInputHeader(True)
        activeBtnDetail(True)
        txtKodePenerimaan.Focus()

        txtKodeRetur.Enabled = False
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        With dgv
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    txtKodeBarang.Text = .SelectedRows(0).Cells("cKodeBarang").Value
                    lblNamaBarang.Text = .SelectedRows(0).Cells("cNamaBarang").Value
                    lblUOM.Text = .SelectedRows(0).Cells("cUOMName").Value
                    txtJumlahRetur.Text = .SelectedRows(0).Cells("cJumlahRetur").Value
                    rtxAlasanRetur.Text = .SelectedRows(0).Cells("cAlasanRetur").Value
                    modeChild = "edit"
                    createBtnItemBarang("edit")
                    activeBtnDetail(True)
                    activeInputDetail(False)
                End If
            End If
        End With
    End Sub

    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        If DsTrans.dtDataBarangRetur.GetChanges IsNot Nothing Then
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub dgv_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        If DsTrans.dtDataBarangRetur.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub btnFindBarang_Click(sender As Object, e As EventArgs) Handles btnFindBarang.Click
        Dim _frmFindPenerimaanBarang As New frmFindPenerimaanBarang(txtKodePenerimaan.Text.Trim)
        _frmFindPenerimaanBarang.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindPenerimaanBarang.getResult
        If _returnList IsNot Nothing Then
            If _returnList(0) IsNot Nothing Then
                txtKodeBarang.Text = _returnList(0).Trim
            End If
            If _returnList(1) IsNot Nothing Then
                lblNamaBarang.Text = _returnList(1).Trim
            End If
            If _returnList(2) IsNot Nothing Then
                lblUOM.Text = _returnList(2).Trim
            End If
        End If
        _frmFindPenerimaanBarang = Nothing
    End Sub

    Private Sub btnFindPenerimaan_Click(sender As Object, e As EventArgs) Handles btnFindPenerimaan.Click
        Dim _frmFindPenerimaanAll As New frmFindPenerimaanAll
        _frmFindPenerimaanAll.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindPenerimaanAll.getResult
        If _returnList IsNot Nothing Then
            txtKodePenerimaan.Text = _returnList(0)
            lblNoPesanan.Text = _returnList(1)
            lblTglPesanan.Text = _returnList(2)
            lblKodeSupplier.Text = _returnList(3)
            lblNamaSupplier.Text = _returnList(4)
        End If
        _frmFindPenerimaanAll = Nothing
    End Sub

    Private Sub txtKodeRetur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeRetur.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeRetur.Text) Then getDataHeader(txtKodeRetur.Text)
        End If
    End Sub
End Class