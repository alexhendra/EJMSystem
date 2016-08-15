Public Class frmPenjualan
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim modeParent As String = String.Empty
    Dim modeChild As String = String.Empty

    Private Sub frmPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearInputDetail()
        clearInputHeader()
        createBtnHeader()
        createBtnItemBarang("")
        frmMain.tlStrpLblStatus.Text = "Ready"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        modeParent = "new"
        clearInputHeader()
        clearInputDetail()
        createBtnHeader()
        activeInputHeader(True)
        activeBtnDetail(True)
        txtNoPenjualan.Enabled = False
    End Sub

    Private Sub clearInputHeader()
        txtNoPenjualan.Clear()
        dtpTransJual.Value = Now.Date
        txtKodeCustomer.Clear()
        lblNamaCustomer.Text = String.Empty
        rtbAlamat.Clear()
    End Sub

    Private Sub clearInputDetail()
        txtKodeBarang.Clear()
        txtJumlahPesan.Clear()
        lblNamaBarang.Text = String.Empty
        lblUOM.Text = String.Empty
        txtHarga.Clear()
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

    Private Sub clearTabelBarangJual()
        Me.DsTrans.dtBarangJual.Rows.Clear()
    End Sub

    Private Sub activeInputHeader(ByVal _isActive As Boolean)
        dtpTransJual.Enabled = _isActive
        txtKodeCustomer.Enabled = _isActive
        rtbAlamat.Enabled = _isActive
        btnFindCustomer.Enabled = _isActive
    End Sub

    Private Sub activeInputDetail(ByVal _isActive As Boolean)
        txtKodeBarang.Enabled = _isActive
        txtJumlahPesan.Enabled = _isActive
        txtHarga.Enabled = _isActive
        btnFindBarang.Enabled = _isActive
    End Sub

    Private Sub activeBtnDetail(ByVal _isActive As Boolean)
        pnlBtnDetail.Enabled = _isActive
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
        End If

        If pnlBtnDetail.Controls.Count > 0 Then
            For Each item As Control In pnlBtnDetail.Controls
                item.Visible = True
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Membatalkan perubahan yang ada di data table-nya data set
        Me.DsTrans.dtBarangJual.RejectChanges()

        clearInputDetail()
        activeInputDetail(False)
        clearInputHeader()
        activeInputHeader(False)
        modeParent = ""
        modeChild = ""
        createBtnHeader()
        createBtnItemBarang("")
        activeBtnDetail(False)
        DsTrans.dtBarangJual.Rows.Clear()
        txtNoPenjualan.Enabled = True
        txtNoPenjualan.Focus()
        frmMain.tlStrpLblStatus.Text = "Ready"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        modeChild = "new"
        createBtnItemBarang("new")
        clearInputDetail()
        activeInputDetail(True)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        modeChild = "update"
        activeInputDetail(True)
        createBtnItemBarang("update")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not String.IsNullOrEmpty(txtKodeBarang.Text) Then
            Dim drow As DataRow

            drow = DsTrans.dtBarangJual.FindByKode_Barang(txtKodeBarang.Text.Trim)

            If drow IsNot Nothing Then
                drow.Delete()
                drow.EndEdit()

                drow = DsTrans.dtBarangJual.FindByKode_Barang(txtKodeBarang.Text.Trim)

                If drow Is Nothing Then
                    modeChild = "delete"
                    createBtnItemBarang("")
                    clearInputDetail()
                End If
            End If
        Else
            lblWarning.Text = "Silahkan pilih barang terlebih dahulu !"
        End If
    End Sub

    Private Sub btnCancelItem_Click(sender As Object, e As EventArgs) Handles btnCancelItem.Click
        modeChild = ""
        clearInputDetail()
        createBtnItemBarang("")
        activeInputDetail(False)
        lblWarning.Text = String.Empty
    End Sub

    Private Sub txtNoPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoPenjualan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtNoPenjualan.Text) Then
                GetHeaderPenjualan(txtNoPenjualan.Text.Trim)
            End If
        End If
    End Sub

    Private Sub txtKodeCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeCustomer.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeCustomer.Text) Then
                GetDataCustomer(txtKodeCustomer.Text)
            End If
        End If
    End Sub

    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs) Handles btnFindCustomer.Click
        Dim _frmFindCustomer As New frmFindCustomer
        _frmFindCustomer.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindCustomer.getResult
        If _returnList IsNot Nothing Then
            txtKodeCustomer.Text = _returnList(0)
            lblNamaCustomer.Text = _returnList(1)
            rtbAlamat.Text = _returnList(2)
        End If
        _frmFindCustomer = Nothing
    End Sub

    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeBarang.Text) Then
                GetDetailBarang(txtKodeBarang.Text)
            End If
        End If
    End Sub

    Private Sub btnFindBarang_Click(sender As Object, e As EventArgs) Handles btnFindBarang.Click
        Dim _frmFindBarangStok As New frmFindBarangStok(dtpTransJual.Value)
        _frmFindBarangStok.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindBarangStok.getResult
        If _returnList IsNot Nothing Then
            txtKodeBarang.Text = _returnList(0)
            lblNamaBarang.Text = _returnList(1)
            lblUOM.Text = _returnList(2)
        End If
        _frmFindBarangStok = Nothing
    End Sub

    Private Sub GetHeaderPenjualan(ByVal noPenjualan As String)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select No_Penjualan, Tgl_Jual, Kode_Customer from tPenjualan_Header where No_Penjualan=@pNoPenjualan"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pNoPenjualan", noPenjualan.Trim)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        da.Dispose()
        cmd.Dispose()

        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                If Not IsDBNull(dr("Tgl_Jual")) Then dtpTransJual.Value = dr("Tgl_Jual")
                If Not IsDBNull(dr("Kode_Customer")) Then txtKodeCustomer.Text = dr("Kode_Customer").ToString.Trim
            Next

            ' Jika txtKodeCustomer tidak kosong setelah di query di atas, maka tampilkan data customer
            If Not String.IsNullOrEmpty(txtKodeCustomer.Text) Then
                GetDataCustomer(txtKodeCustomer.Text)
            End If

            ' Tampilkan data barang ke table
            GetDataTabelBarangJual(txtNoPenjualan.Text)
            modeParent = "update"
            createBtnHeader()
            activeBtnDetail(True)
        Else
            lblWarning.Text = "Data penjualan tidak ditemukan !"
        End If
    End Sub

    Private Sub GetDataCustomer(ByVal kodeCustomer As String)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Kode_Customer, Nama_Customer, Alamat_Customer from tBase_Customer where Kode_Customer=@pKodeCustomer"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pKodeCustomer", kodeCustomer.Trim)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        da.Dispose()
        cmd.Dispose()

        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                If Not IsDBNull(dr("Nama_Customer")) Then lblNamaCustomer.Text = dr("Nama_Customer").ToString.Trim
                If Not IsDBNull(dr("Alamat_Customer")) Then rtbAlamat.Text = dr("Alamat_Customer").ToString.Trim
            Next
        Else
            lblWarning.Text = "Data customer tidak ditemukan !"
        End If
    End Sub

    Private Sub GetDataTabelBarangJual(ByVal _noPenjualan As String)
        Me.DsTrans.dtBarangJual.Clear()
        Me.DaBarangJual.Fill(Me.DsTrans.dtBarangJual, _noPenjualan.Trim)
    End Sub

    Private Sub GetDetailBarang(ByVal KodeBarang As String)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spPenjualan_FindDataBarang"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pFromDate", dtpTransJual.Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        Dim drow As DataRow() = dt.Select("KodeBarang='" & KodeBarang.Trim & "' and SisaStok > 0")

        If drow.Length > 0 Then
            If Not IsDBNull(drow(0)("NamaBarang")) Then lblNamaBarang.Text = drow(0)("NamaBarang")
            If Not IsDBNull(drow(0)("UomName")) Then lblUOM.Text = drow(0)("UomName")
        Else
            lblWarning.Text = "Data stok barang tidak ditemukan !!"
        End If
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTransJual.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeBarang.Text) Then
            lblWarning.Text = "Kode Barang harus diisi !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtJumlahPesan.Text) Then
            lblWarning.Text = "Jumlah Pesanan harus diisi !!!"
            Exit Sub
        End If

        If Not IsNumeric(txtJumlahPesan.Text) Then
            lblWarning.Text = "Jumlah Pesanan harus diisi dengan angka !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtHarga.Text) Then
            lblWarning.Text = "Harga jual harus diisi !!!"
            Exit Sub
        End If

        If Not IsNumeric(txtHarga.Text) Then
            lblWarning.Text = "Harga jual harus diisi dengan angka !!!"
            Exit Sub
        End If

        Dim drow As DataRow
        If modeChild = "new" Then
            drow = Me.DsTrans.dtBarangJual.NewRow
        Else
            drow = DsTrans.dtBarangJual.FindByKode_Barang(txtKodeBarang.Text.Trim)
        End If

        ' Proses mencegah ada barang yang sama diinput lebih dari 1 kali ke tabel pesanan
        If DsTrans.dtBarangJual.Rows.Count > 0 Then
            Dim drowArr As DataRow() = DsTrans.dtBarangJual.Select("Kode_Barang='" & txtKodeBarang.Text.Trim & "'")
            If drowArr.Count > 1 Then
                lblWarning.Text = "Item barang ini sudah ada di tabel !!!"
                Exit Sub
            End If
        End If

        If modeChild <> "new" Then drow.BeginEdit()

        drow("Kode_Barang") = txtKodeBarang.Text
        drow("Nama_Barang") = lblNamaBarang.Text
        drow("UomName") = lblUOM.Text
        drow("Jumlah") = txtJumlahPesan.Text
        drow("Harga") = txtHarga.Text
        drow("SubTotal") = CInt(txtJumlahPesan.Text) * CInt(txtHarga.Text)

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
            Me.DsTrans.dtBarangJual.Rows.Add(drow)
        Else
            drow.EndEdit()
        End If

        clearInputDetail()
        createBtnItemBarang("")
        activeInputDetail(False)
        txtNoPenjualan.Enabled = False

        If DsTrans.dtBarangJual.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub txtKodeBarang_LostFocus(sender As Object, e As EventArgs) Handles txtKodeBarang.LostFocus
        If Not String.IsNullOrEmpty(txtKodeBarang.Text) Then
            GetDetailBarang(txtKodeBarang.Text)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTransJual.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeCustomer.Text) Then
            lblWarning.Text = "Kode Customer harus diisi !!!"
            Exit Sub
        End If

        If DsTrans.dtBarangJual.Rows.Count < 1 Then
            lblWarning.Text = "Silahkan masukkan item barang yang akan dijual ke dalam tabel !!!"
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        dgv.EndEdit()    ' memberhentikan edit data di gridview
        DtBarangJualBindingSource.EndEdit() ' memberhentikan edit data di databinding

        If con.State = ConnectionState.Closed Then con.Open()
        Dim trans As SqlTransaction = con.BeginTransaction
        Dim _returnValue As String = String.Empty

        Try
            ' --- Proses simpan data retur header ---
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandTimeout = 120
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "spPenjualan_SaveHeader"
            cmd.Parameters.Clear()
            If String.IsNullOrEmpty(txtNoPenjualan.Text) Then
                cmd.Parameters.AddWithValue("@pNoPenjualan", "new")
            Else
                cmd.Parameters.AddWithValue("@pNoPenjualan", txtNoPenjualan.Text.Trim)
            End If
            cmd.Parameters.AddWithValue("@pTglJual", dtpTransJual.Value)
            cmd.Parameters.AddWithValue("@pKodeCustomer", txtKodeCustomer.Text.Trim)
            cmd.Parameters.Add("@pReturn", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
            cmd.Transaction = trans
            cmd.ExecuteNonQuery()

            If TypeOf cmd.Parameters("@pReturn").Value Is String Then
                _returnValue = cmd.Parameters("@pReturn").Value.ToString
            End If

            ' Apabila nilai yang dikembalikan dr database panjang stringnya tdk 14
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 14 (kembalikan Kode_Retur)
            If _returnValue.Length <> 14 Then
                trans.Rollback()
                con.Close()
                Me.DsTrans.dtBarangJual.RejectChanges()
                Me.DsTrans.dtBarangJual.Clear()

                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            If Me.DsTrans.dtBarangJual.GetChanges() Is Nothing Then
                trans.Commit()
                modeParent = "new"
                clearInputDetail()
                clearInputHeader()
                clearTabelBarangJual()
                createBtnItemBarang("")
                txtNoPenjualan.Enabled = True
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
                .CommandText = "spPenjualan_SaveDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pNoPenjualan", _returnValue.Trim)
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
                .Parameters.Add("@pJumlahJual", SqlDbType.Int, 10, "Jumlah")
                .Parameters.Add("@pHargaJual", SqlDbType.Money, 10, "Harga")
                .Parameters.Add("@pSubTotal", SqlDbType.Money, -1, "Subtotal")
                .Parameters.AddWithValue("@pTglJual", dtpTransJual.Value)
                .Parameters.Add("@pModeChild", SqlDbType.VarChar, 10, "pMode")
                .Parameters.AddWithValue("@pModeParent", modeParent.Trim)
                .Parameters.Add("@pReturn", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            'Dim cmdDelete As New SqlCommand
            'With cmdDelete
            '    .Connection = con
            '    .CommandTimeout = 120
            '    .CommandType = CommandType.StoredProcedure
            '    .CommandText = "spRetur_DeleteDetail"
            '    .Parameters.Clear()
            '    .Parameters.AddWithValue("@pKodeRetur", _returnValue.Trim)
            '    .Parameters.Add("@pKodePembelian", SqlDbType.VarChar, 14, "Kode_Pembelian")
            '    .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
            '    .Parameters.Add("@pReturn", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output
            '    .Transaction = trans
            'End With

            Dim da As New SqlDataAdapter
            da.InsertCommand = cmdSave
            da.UpdateCommand = cmdSave
            'da.DeleteCommand = cmdDelete

            da.Update(Me.DsTrans.dtBarangJual)

            _returnValue = String.Empty
            'If cmdDelete.Parameters("@pReturn").Value IsNot Nothing Then
            '    If TypeOf cmdDelete.Parameters("@pReturn").Value Is String Then
            '        _returnValue = cmdDelete.Parameters("@pReturn").Value.ToString
            '    End If
            'Else
            If TypeOf cmdSave.Parameters("@pReturn").Value Is String Then
                _returnValue = cmdSave.Parameters("@pReturn").Value.ToString
            End If
            'End If


            ' Apabila nilai yang dikembalikan dr database nilai stringnya tdk sama dgn 1
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 1
            If _returnValue.Length <> "1" Then
                trans.Rollback()
                con.Close()
                Me.DsTrans.dtBarangJual.RejectChanges()
                Me.DsTrans.dtBarangJual.Clear()

                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue.Trim
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            trans.Commit()
            DsTrans.dtBarangJual.AcceptChanges()
            modeParent = ""
            modeChild = ""
            clearInputDetail()
            activeInputDetail(False)
            clearInputHeader()
            activeInputHeader(False)
            clearTabelBarangJual()
            createBtnItemBarang("")
            activeBtnDetail(False)
            createBtnHeader()
            txtNoPenjualan.Enabled = True
            frmMain.tlStrpLblStatus.Text = "Ready"
            MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            trans.Rollback()
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        With dgv
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    txtKodeBarang.Text = .SelectedRows(0).Cells("cKodeBarang").Value
                    lblNamaBarang.Text = .SelectedRows(0).Cells("cNamaBarang").Value
                    lblUOM.Text = .SelectedRows(0).Cells("cUomName").Value
                    txtJumlahPesan.Text = .SelectedRows(0).Cells("cJumlah").Value
                    If .SelectedRows(0).Cells("cHarga").Value IsNot Nothing Then
                        txtHarga.Text = Format(.SelectedRows(0).Cells("cHarga").Value, "###0")
                    End If

                    If modeParent = "new" And .SelectedRows(0).Cells("cPMode").Value.ToString = "new" Then
                        modeChild = "edit"
                        createBtnItemBarang("edit")
                    ElseIf modeParent <> "new" And .SelectedRows(0).Cells("cPMode").Value.ToString = "new" Then
                        modeChild = "edit"
                        createBtnItemBarang("edit")
                    End If
                    activeInputDetail(False)
                End If
            End If
        End With
    End Sub

    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        If DsTrans.dtBarangJual.GetChanges IsNot Nothing Then
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

End Class