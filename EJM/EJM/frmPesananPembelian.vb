Public Class frmPesananPembelian
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim modeParent As String = String.Empty
    Dim modeChild As String = String.Empty

    Private Sub frmPesananPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        clearInputDetail()
        clearInputHeader()
        createBtnHeader()
        createBtnItemBarang("")
        txtNoPesan.Focus()
    End Sub

    Private Sub txtJumlahPesan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahPesan.KeyPress, txtHarga.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoPesan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoPesan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            GetHeaderPesanan(txtNoPesan.Text.Trim)
        End If
    End Sub

    Private Sub GetHeaderPesanan(ByVal noPesanan As String)
        Dim dt As DataTable
        Dim _sudahTerima As Boolean = False

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spPesanan_GetHeaderPesanan"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pNoPesanan", noPesanan.Trim)
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                txtKodeSupplier.Text = drow("Kode_Supplier").ToString
                lblNamaSupplier.Text = drow("Nama_Supplier").ToString
                dtpTglPesan.Value = CDate(drow("Tgl_Pesanan"))

                If Not IsDBNull(drow("Nama_Supplier")) Then
                    _sudahTerima = drow("sudahTerima")
                End If
            Next
            GetDataPesananTabel(noPesanan.Trim)
            If _sudahTerima Then
                MessageBox.Show("No. Pesanan sudah dilakukan proses penerimaan !!", "Pencarian data pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            modeParent = "update"
            activeBtnDetail(True)
            createBtnHeader()
            txtNoPesan.Enabled = False
        Else
            MessageBox.Show("Data pesanan tidak ditemukan", "Pencarian data pesanan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub findDataSupplierByKode(ByVal kode As String)
        Dim dt As New DataTable
        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandText = "spPesanan_GetDataSupplierByKode"
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 120
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeSupplier", kode.Trim)
            End With
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        clearInputHeader()
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                txtKodeSupplier.Text = kode.Trim
                lblNamaSupplier.Text = dr("Nama_Supplier").ToString
            Next
        Else
            MessageBox.Show("Data supplier tidak ditemukan !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub findDataBarangByKode(ByVal kode As String)
        Dim dt As New DataTable
        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandText = "spPesanan_GetDataBarangByKode"
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 120
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeBarang", kode.Trim)
            End With
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        clearInputDetail()
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                txtKodeBarang.Text = kode.Trim
                lblNamaBarang.Text = dr("Nama_Barang").ToString
                lblUOM.Text = dr("uomName").ToString
            Next
        Else
            MessageBox.Show("Data barang tidak ditemukan !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Membatalkan perubahan yang ada di data table-nya data set
        Me.DsTrans.dtPesananPembelian.RejectChanges()

        clearInputDetail()
        activeInputDetail(False)
        clearInputHeader()
        activeInputHeader(False)
        modeParent = ""
        modeChild = ""
        createBtnHeader()
        createBtnItemBarang("")
        activeBtnDetail(False)
        DsTrans.dtPesananPembelian.Rows.Clear()
        txtNoPesan.Enabled = True
        txtNoPesan.Focus()
        frmMain.tlStrpLblStatus.Text = "Ready"
    End Sub

    Private Sub GetDataPesananTabel(ByVal _noPesanan As String)
        Me.DaPesananPembelian.Fill(Me.DsTrans.dtPesananPembelian, _noPesanan.Trim)
    End Sub

    Private Sub clearDataPesananTabel()
        Me.DsTrans.dtPesananPembelian.Rows.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        modeChild = "new"
        createBtnItemBarang("new")
        clearInputDetail()
        activeInputDetail(True)
        txtKodeBarang.Focus()
    End Sub

    Private Sub clearInputDetail()
        txtKodeBarang.Clear()
        lblNamaBarang.Text = String.Empty
        lblUOM.Text = String.Empty
        txtJumlahPesan.Clear()
        txtHarga.Clear()
    End Sub

    Private Sub clearInputHeader()
        txtNoPesan.Clear()
        txtKodeSupplier.Clear()
        lblNamaSupplier.Text = String.Empty
        dtpTglPesan.Value = Now.Date
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvPesanan_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPesanan.CellMouseDoubleClick
        With dgvPesanan
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    activeInputDetail(False)
                    txtKodeBarang.Text = .SelectedRows(0).Cells("cKodeBarang").Value
                    findDataBarangByKode(txtKodeBarang.Text)
                    txtKodeSupplier.Text = .SelectedRows(0).Cells("cKodeSupplier").Value
                    findDataSupplierByKode(txtKodeSupplier.Text)
                    txtJumlahPesan.Text = .SelectedRows(0).Cells("cJumlah").Value
                    If .SelectedRows(0).Cells("cJumlah").Value IsNot Nothing Then
                        txtHarga.Text = Format(.SelectedRows(0).Cells("cHarga").Value, "###0")
                    End If
                    modeChild = "edit"
                    createBtnItemBarang("edit")
                End If
            End If
        End With
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
        txtKodeSupplier.Enabled = _isActive
        dtpTglPesan.Enabled = _isActive
        btnFindSupplier.Enabled = _isActive
    End Sub

    Private Sub activeInputDetail(ByVal _isActive As Boolean)
        txtKodeBarang.Enabled = _isActive
        btnFindBarang.Enabled = _isActive
        txtJumlahPesan.Enabled = _isActive
        txtHarga.Enabled = _isActive
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

        If String.IsNullOrEmpty(txtNoPesan.Text) Then
            drow = DsTrans.dtPesananPembelian.FindByNo_PesananKode_Barang("new", txtKodeBarang.Text)
        Else
            drow = DsTrans.dtPesananPembelian.FindByNo_PesananKode_Barang(txtNoPesan.Text, txtKodeBarang.Text)
        End If

        If drow IsNot Nothing Then
            drow.Delete()
            If String.IsNullOrEmpty(txtNoPesan.Text) Then
                drow = DsTrans.dtPesananPembelian.FindByNo_PesananKode_Barang("new", txtKodeBarang.Text)
            Else
                drow = DsTrans.dtPesananPembelian.FindByNo_PesananKode_Barang(txtNoPesan.Text, txtKodeBarang.Text)
            End If

            If drow Is Nothing Then
                modeChild = "delete"
                createBtnItemBarang("")
                clearInputDetail()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtKodeSupplier.Text) Then
            MessageBox.Show("Kode Supplier harus diisi !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If modeParent = "new" Then
            If DsTrans.dtPesananPembelian.Rows.Count < 1 Then
                MessageBox.Show("Silahkan masukkan item barang pesanan terlebih dahulu !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        dgvPesanan.EndEdit()    ' memberhentikan edit data di gridview pesanan
        DtPesananPembelianBindingSource.EndEdit() ' memberhentikan edit data di databinding pesanan

        If con.State = ConnectionState.Closed Then con.Open()
        Dim trans As SqlTransaction = con.BeginTransaction
        Dim _returnValue As String = String.Empty

        Try
            ' --- Proses simpan data pesanan pembelian header ---
            Using cmd As New SqlCommand
                With cmd
                    .Connection = con
                    .CommandTimeout = 120
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "spPesanan_SaveHeader"
                    .Parameters.Clear()
                    If String.IsNullOrEmpty(txtNoPesan.Text) Then
                        .Parameters.AddWithValue("@pNoPesanan", "new")
                    Else
                        .Parameters.AddWithValue("@pNoPesanan", txtNoPesan.Text.Trim)
                    End If
                    .Parameters.AddWithValue("@pTglPesanan", dtpTglPesan.Value)
                    .Parameters.AddWithValue("@pKodeSupplier", txtKodeSupplier.Text.Trim)
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
                Me.DsTrans.dtPesananPembelian.RejectChanges()
                If Not String.IsNullOrEmpty(_returnValue) Then
                    MessageBox.Show(_returnValue, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            If Me.DsTrans.dtPesananPembelian.GetChanges() Is Nothing Then
                trans.Commit()
                modeParent = ""
                clearInputDetail()
                clearInputHeader()
                clearDataPesananTabel()
                createBtnItemBarang("")
                createBtnHeader()
                txtNoPesan.Enabled = True
                txtNoPesan.Focus()
                MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' --- Proses penyimpanan pesanan pembelian detail ---
            Dim cmdSave As New SqlCommand
            With cmdSave
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPesanan_SaveDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pNoPesanan", _returnValue.Trim)
                .Parameters.AddWithValue("@pTglPesanan", dtpTglPesan.Value)
                .Parameters.Add("@pKodeSupplier", SqlDbType.VarChar, 10, "Kode_Supplier")
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
                .Parameters.Add("@pJumlah", SqlDbType.Int, 10, "Jumlah")
                .Parameters.Add("@pHarga", SqlDbType.Money, 10, "Harga")
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
                .CommandText = "spPesanan_DeleteDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pNoPesanan", _returnValue.Trim)
                .Parameters.AddWithValue("@pTglPesanan", dtpTglPesan.Value)
                .Parameters.Add("@pKodeSupplier", SqlDbType.VarChar, 10, "Kode_Supplier")
                .Parameters.Add("@pKodeBarang", SqlDbType.VarChar, 10, "Kode_Barang")
                .Parameters.Add("@pJumlah", SqlDbType.Int, 10, "Jumlah")
                .Parameters.Add("@pHarga", SqlDbType.Money, 10, "Harga")
                .Parameters.Add("@pModeChild", SqlDbType.VarChar, 10, "pMode")
                .Parameters.AddWithValue("@pModeParent", modeParent.Trim)
                .Parameters.Add("@pReturn", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Using da As New SqlDataAdapter
                da.InsertCommand = cmdSave
                da.UpdateCommand = cmdSave
                da.DeleteCommand = cmdDelete

                da.Update(Me.DsTrans.dtPesananPembelian)
                'Dim type As VariantType = VarType(.Parameters("@pReturn").Value)
                'MsgBox(type.ToString)
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
                Me.DsTrans.dtPesananPembelian.RejectChanges()
                If Not String.IsNullOrEmpty(_returnValue) Then
                    MessageBox.Show(_returnValue, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            trans.Commit()
            DsTrans.dtPesananPembelian.AcceptChanges()
            modeParent = ""
            modeChild = ""
            clearInputDetail()
            activeInputDetail(False)
            clearInputHeader()
            activeInputHeader(False)
            clearDataPesananTabel()
            createBtnItemBarang("")
            activeBtnDetail(False)
            createBtnHeader()
            txtNoPesan.Enabled = True
            txtNoPesan.Focus()
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
        If isLockData() Then
            MessageBox.Show("Data sedang di-LOCK !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If isClosing(dtpTglPesan.Value.Date) Then
            MessageBox.Show("Tanggal ini sudah dilakukan closing !!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeSupplier.Text) Then
            MessageBox.Show("Kode Supplier harus diisi !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeBarang.Text) Then
            MessageBox.Show("Kode Barang harus diisi !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtJumlahPesan.Text) Then
            MessageBox.Show("Jumlah pesanan harus diisi !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not IsNumeric(txtJumlahPesan.Text) Then
            MessageBox.Show("Jumlah pesanan harus diisi dengan angka !!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtHarga.Text) Then
            MessageBox.Show("Harga barang harus diisi !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not IsNumeric(txtHarga.Text) Then
            MessageBox.Show("Harga barang harus angka !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' --- Untuk melakukan validasi dari No.Pesanan, Kode Barang, Kode Supplier yang diinput oleh User ---
        Dim dt As New DataTable
        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandText = "spPesanan_CheckDataValid"
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 120
                .Parameters.Clear()
                If String.IsNullOrEmpty(txtNoPesan.Text) Then
                    .Parameters.AddWithValue("@pNoPesanan", "new")
                Else
                    .Parameters.AddWithValue("@pNoPesanan", txtNoPesan.Text.Trim)
                End If
                .Parameters.AddWithValue("@pKodeBarang", txtKodeBarang.Text.Trim)
                .Parameters.AddWithValue("@pKodeSupplier", txtKodeSupplier.Text.Trim)
            End With
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        If dt.Rows.Count > 0 Then
            ' Apabila nilai kembalian tidak sama dengan 1 maka munculkan pesan error
            If dt.Rows(0)(0).ToString <> "1" Then
                MessageBox.Show(dt.Rows(0)(0).ToString, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim drow As DataRow
        If modeChild = "new" Then
            drow = Me.DsTrans.dtPesananPembelian.NewRow
        Else
            If String.IsNullOrEmpty(txtNoPesan.Text) Then
                drow = DsTrans.dtPesananPembelian.FindByNo_PesananKode_Barang("new", txtKodeBarang.Text)
            Else
                drow = DsTrans.dtPesananPembelian.FindByNo_PesananKode_Barang(txtNoPesan.Text, txtKodeBarang.Text)
            End If
        End If

        ' Proses mencegah ada barang yang sama diinput lebih dari 1 kali ke tabel pesanan      
        Dim drowArr As DataRow() = DsTrans.dtPesananPembelian.Select("Kode_Barang='" & txtKodeBarang.Text & "' and Kode_Supplier='" & txtKodeSupplier.Text & "'")
        If drowArr.Count > 0 And modeChild = "new" Then
            MessageBox.Show("Item barang pesanan ini sudah ada di tabel !!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If modeChild <> "new" Then drow.BeginEdit()

        If String.IsNullOrEmpty(txtNoPesan.Text) Then
            drow("No_Pesanan") = "new"
        Else
            drow("No_Pesanan") = txtNoPesan.Text
        End If

        drow("Kode_Barang") = txtKodeBarang.Text.Trim
        drow("Nama_Barang") = lblNamaBarang.Text.Trim
        drow("UomName") = lblUOM.Text.Trim
        drow("Jumlah") = txtJumlahPesan.Text.Trim
        drow("Harga") = txtHarga.Text
        If IsNumeric(txtJumlahPesan.Text.Trim) And IsNumeric(txtHarga.Text) Then
            drow("Total") = CDbl(txtJumlahPesan.Text.Trim) * CDbl(txtHarga.Text)
        Else
            drow("Total") = 0
        End If

        drow("Kode_Supplier") = txtKodeSupplier.Text.Trim

        ' Mode parentnya = new, mode childnya harus new jgn ikut berubah, karena data header baru pasti data detailnya juga baru
        ' Kecuali klo mode parent != new, berarti data header sudah ada sebelumnya, dan data detailnya mungkin baru ditambahkan atau diupdate
        ' atau didelete dari database
        If modeParent = "new" Then
            drow("pMode") = "new"
        Else
            'drow("pMode") = modeChild.Trim

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
            Me.DsTrans.dtPesananPembelian.Rows.Add(drow)
        Else
            drow.EndEdit()
        End If

        clearInputDetail()
        createBtnItemBarang("")
        activeInputDetail(False)
        activeInputHeader(False)

        If DsTrans.dtPesananPembelian.GetChanges IsNot Nothing Then
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
        clearInputDetail()
        createBtnHeader()
        activeInputHeader(True)
        activeBtnDetail(True)
        createBtnItemBarang("")
        clearDataPesananTabel()
        txtNoPesan.Enabled = False
        txtKodeSupplier.Focus()
    End Sub

    Private Sub dgvPesanan_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvPesanan.RowsAdded
        If DsTrans.dtPesananPembelian.GetChanges IsNot Nothing Then
            dgvPesanan.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub dgvPesanan_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvPesanan.RowsRemoved
        If DsTrans.dtPesananPembelian.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub btnFindSupplier_Click(sender As Object, e As EventArgs) Handles btnFindSupplier.Click
        Dim _frmFindSupplier As New frmFindSupplier
        _frmFindSupplier.ShowDialog()
        Dim _result As String = _frmFindSupplier.getResult
        If Not String.IsNullOrEmpty(_result) Then
            txtKodeSupplier.Text = _result.Trim
            findDataSupplierByKode(_result)
        End If
        _frmFindSupplier = Nothing
    End Sub

    Private Sub btnFindBarang_Click(sender As Object, e As EventArgs) Handles btnFindBarang.Click
        Dim _frmFindBarang As New frmFindBarang
        _frmFindBarang.ShowDialog()
        Dim _result As String = _frmFindBarang.getResult
        If Not String.IsNullOrEmpty(_result) Then
            txtKodeBarang.Text = _result.Trim
            findDataBarangByKode(_result)
        End If
        _frmFindBarang = Nothing
    End Sub

    Private Sub txtKodeSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeSupplier.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeSupplier.Text) Then
                findDataSupplierByKode(txtKodeSupplier.Text)
            End If
        End If
    End Sub

    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeBarang.Text) Then
                findDataBarangByKode(txtKodeBarang.Text)
            End If
        End If
    End Sub
End Class