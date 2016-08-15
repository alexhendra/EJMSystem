Public Class frmPembelian
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim modeParent As String = String.Empty
    Dim modeChild As String = String.Empty

    Private Sub frmPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        txtKodePembelian.Focus()
        clearInputDetail()
        clearInputHeader()
        createBtnHeader()
        createBtnItemDetail("")
        txtKodePembelian.Focus()
    End Sub

    'Private Sub txtJumlahPesan_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtNoPesan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoPesanan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeSupplier.Text) And Not String.IsNullOrEmpty(txtNoPesanan.Text) Then

            End If
        End If
    End Sub

    Private Sub txtKodeSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeSupplier.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeSupplier.Text) Then

            End If
        End If
    End Sub

    Private Sub FindSupplierByKode(ByVal kodeSupplier As String)
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spPembelian_FindSupplierByKode"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodeSupplier", kodeSupplier.Trim)
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                lblNamaSupplier.Text = drow("Nama_Supplier").ToString
            Next
        Else
            lblWarning.Text = "Data supplier tidak ditemukan !"
        End If
    End Sub

    Private Sub GetItemPesanan(ByVal noPesanan As String, ByVal kodeSupplier As String)
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spPembelian_FindTagihanPesananByKode"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pNoPesanan", noPesanan.Trim)
                .Parameters.AddWithValue("@pKodeSupplier", kodeSupplier.Trim)
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                lblTglPesanan.Text = Format(drow("Tgl_Pesanan"), "MM/dd/yyyy")
                lblTotalTagihanPesanan.Text = drow("TotalTagihanPesanan").ToString
            Next
        Else
            lblWarning.Text = "Data pesanan tidak ditemukan !"
        End If
    End Sub

    Private Sub GetHeaderPembelian(ByVal kodePembelian As String)
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spPembelian_GetDataHeader"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePembelian", kodePembelian.Trim)
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End With
        End Using

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                txtKodePembelian.Text = drow("Kode_Pembelian").ToString
                dtpTglBeli.Value = CDate(drow("Tgl_Beli"))
                If Not IsDBNull(drow("Tgl_Jatuh_Tempo")) Then dtpTglJatuhTempo.Value = CDate(drow("Tgl_Jatuh_Tempo"))
                If Not IsDBNull(drow("Jenis_Pembayaran")) Then
                    Select Case drow("Jenis_Pembayaran").ToString
                        Case "0"
                            rdbTunai.Checked = True
                        Case "1"
                            rdbKredit.Checked = True
                    End Select
                End If
                txtKodeSupplier.Text = drow("Kode_Supplier").ToString
                lblNamaSupplier.Text = drow("Nama_Supplier").ToString
            Next
            GetDataPembelianTabel(kodePembelian.Trim)
            modeParent = "update"
            activeBtnDetail(True)
            createBtnHeader()
            txtKodePembelian.Enabled = False
            rdbKredit.Enabled = True
            rdbTunai.Enabled = True
            If rdbKredit.Checked Then dtpTglJatuhTempo.Enabled = True
        Else
            lblWarning.Text = "Data tidak ditemukan !"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Membatalkan perubahan yang ada di data table-nya
        Me.DsTrans.dtItemPembelian.RejectChanges()

        clearInputDetail()
        activeInputDetail(False)
        clearInputHeader()
        activeInputHeader(False)
        modeParent = ""
        modeChild = ""
        createBtnHeader()
        createBtnItemDetail("")
        activeBtnDetail(False)
        DsTrans.dtItemPembelian.Rows.Clear()

        frmMain.tlStrpLblStatus.Text = "Ready"
        lblWarning.Text = String.Empty
    End Sub

    Private Sub GetDataPembelianTabel(ByVal _kodePembelian As String)
        Me.DsTrans.dtItemPembelian.Clear()
        Me.DaItemPembelian.Fill(Me.DsTrans.dtItemPembelian, _kodePembelian.Trim)
    End Sub

    Private Sub clearDataPembelianTabel()
        Me.DsTrans.dtItemPembelian.Rows.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        modeChild = "new"
        createBtnItemDetail("new")
        clearInputDetail()
        activeInputDetail(True)
        txtNoPesanan.Focus()
    End Sub

    Private Sub clearInputDetail()
        txtNoPesanan.Clear()
        lblTotalTagihanPesanan.Text = String.Empty
        lblTglPesanan.Text = ""
    End Sub

    Private Sub clearInputHeader()
        txtKodePembelian.Clear()
        rdbTunai.Checked = True
        dtpTglBeli.Value = Now.Date
        dtpTglJatuhTempo.Value = Now.Date
        txtNoPesanan.Clear()
        txtKodeSupplier.Clear()
        lblNamaSupplier.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvPesanan_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        With dgv
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    txtNoPesanan.Text = .SelectedRows(0).Cells("cNoPesanan").Value
                    lblTotalTagihanPesanan.Text = .SelectedRows(0).Cells("cTotalUangPesanan").Value

                    If IsDate(.SelectedRows(0).Cells("cTglPesanan").Value) Then
                        lblTglPesanan.Text = Format(.SelectedRows(0).Cells("cTglPesanan").Value, "MM/dd/yyyy")
                    End If
                    modeChild = "edit"
                    createBtnItemDetail("edit")
                    activeInputDetail(False)
                End If
            End If
        End With
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
        txtKodePembelian.Enabled = Not _isActive
        rdbTunai.Enabled = _isActive
        rdbKredit.Enabled = _isActive
        dtpTglBeli.Enabled = _isActive
        dtpTglJatuhTempo.Enabled = _isActive
        txtKodeSupplier.Enabled = _isActive
        btnFindSupplier.Enabled = _isActive
    End Sub

    Private Sub activeInputDetail(ByVal _isActive As Boolean)
        txtNoPesanan.Enabled = _isActive
        btnFindPesanan.Enabled = _isActive
    End Sub

    Private Sub activeBtnDetail(ByVal _isActive As Boolean)
        pnlBtnDetail.Enabled = _isActive
    End Sub

    Private Sub btnCancelItem_Click(sender As Object, e As EventArgs) Handles btnCancelItem.Click
        modeChild = ""
        clearInputDetail()
        createBtnItemDetail("")
        activeInputDetail(False)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        lblWarning.Text = String.Empty

        Dim drow As DataRow

        If String.IsNullOrEmpty(txtNoPesanan.Text) Then
            lblWarning.Text = "Silahkan pilih data yang akan dihapus dari tabel terlebih dahulu !!"
            Exit Sub
        Else
            drow = DsTrans.dtItemPembelian.FindByNo_Pesanan(txtNoPesanan.Text.Trim)
        End If

        If drow IsNot Nothing Then
            drow.Delete()
            drow.AcceptChanges()

            drow = DsTrans.dtItemPembelian.FindByNo_Pesanan(txtNoPesanan.Text.Trim)

            If drow Is Nothing Then
                modeChild = "delete"
                clearInputDetail()
                createBtnItemDetail("")
                activeInputDetail(False)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTglBeli.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeSupplier.Text) Then
            lblWarning.Text = "Kode Supplier harus diisi !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(lblNamaSupplier.Text) Then
            lblWarning.Text = "Kode Supplier tidak valid !!"
            Exit Sub
        End If

        If rdbKredit.Checked Then
            If dtpTglJatuhTempo.Value = Now.Date Then
                lblWarning.Text = "Tanggal Jatuh Tempo tidak boleh sama dengan tanggal saat ini !!!"
                Exit Sub
            End If
        End If

        'If modeParent = "new" Then
        If DsTrans.dtItemPembelian.Rows.Count < 1 Then
            lblWarning.Text = "Silahkan masukkan item pembelian terlebih dahulu !!!"
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        dgv.EndEdit()    ' memberhentikan edit data di gridview
        DtItemPembelianBindingSource.EndEdit() ' memberhentikan edit data di databinding

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
                    .CommandText = "spPembelian_SaveHeader"
                    .Parameters.Clear()
                    If String.IsNullOrEmpty(txtKodePembelian.Text) Then
                        .Parameters.AddWithValue("@pKodePembelian", "new")
                    Else
                        .Parameters.AddWithValue("@pKodePembelian", txtKodePembelian.Text.Trim)
                    End If

                    If rdbTunai.Checked Then
                        .Parameters.AddWithValue("@pJenisPembayaran", 0)
                    Else
                        .Parameters.AddWithValue("@pJenisPembayaran", 1)
                    End If

                    .Parameters.AddWithValue("@pTglBeli", dtpTglBeli.Value)
                    If rdbKredit.Checked Then
                        .Parameters.AddWithValue("@pTglJatuhTempo", dtpTglJatuhTempo.Value)
                    Else
                        .Parameters.AddWithValue("@pTglJatuhTempo", DBNull.Value)
                    End If
                    .Parameters.AddWithValue("@pKodeSupplier", txtKodeSupplier.Text.Trim)
                    .Parameters.Add("@pReturn", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
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
                Me.DsTrans.dtItemPembelian.Reset()
                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            If Me.DsTrans.dtItemPembelian.GetChanges() Is Nothing Then
                trans.Commit()
                modeParent = ""
                clearInputDetail()
                clearInputHeader()
                activeInputDetail(False)
                activeInputHeader(False)
                clearDataPembelianTabel()
                createBtnItemDetail("")
                activeBtnDetail(False)
                createBtnHeader()
                txtKodePembelian.Focus()
                frmMain.tlStrpLblStatus.Text = "Ready"
                MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' --- Proses penyimpanan pesanan pembelian detail ---
            Dim cmdSave As New SqlCommand
            With cmdSave
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPembelian_SaveDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePembelian", _returnValue.Trim)
                .Parameters.Add("@pNoPesanan", SqlDbType.VarChar, 14, "No_Pesanan")
                .Parameters.Add("@pTotalUangPesanan", SqlDbType.Money, 10, "Total_UangPesanan")
                .Parameters.AddWithValue("@pKodeSupplier", txtKodeSupplier.Text.Trim)
                .Parameters.Add("@pModeChild", SqlDbType.VarChar, 10, "pMode")
                .Parameters.AddWithValue("@pModeParent", modeParent.Trim)
                .Parameters.Add("@pReturn", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Dim cmdDelete As New SqlCommand
            With cmdDelete
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPembelian_DeleteDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePembelian", _returnValue.Trim)
                .Parameters.Add("@pNoPesanan", SqlDbType.VarChar, 14, "No_Pesanan")
                .Parameters.Add("@pReturn", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Using da As New SqlDataAdapter
                da.UpdateCommand = cmdSave
                da.InsertCommand = cmdSave
                da.DeleteCommand = cmdDelete

                da.Update(Me.DsTrans.dtItemPembelian)

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
                Me.DsTrans.dtItemPembelian.Reset()
                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            trans.Commit()
            DsTrans.dtItemPembelian.AcceptChanges()
            modeParent = ""
            modeChild = ""
            clearInputDetail()
            activeInputDetail(False)
            clearInputHeader()
            activeInputHeader(False)
            clearDataPembelianTabel()
            createBtnItemDetail("")
            activeBtnDetail(False)
            createBtnHeader()
            txtKodePembelian.Focus()

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

        If isClosing(dtpTglBeli.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeSupplier.Text) Then
            lblWarning.Text = "Kode Supplier harus diisi !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(lblNamaSupplier.Text) Then
            lblWarning.Text = "Kode Supplier tidak valid !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtNoPesanan.Text) Then
            lblWarning.Text = "No. Pesanan tidak valid !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(lblTglPesanan.Text) Then
            lblWarning.Text = "No. Pesanan tidak valid !!"
            Exit Sub
        End If


        '' --- Untuk melakukan validasi dari No.Pesanan, Kode Barang, Kode Supplier yang diinput oleh User ---
        'Dim dt As New DataTable
        'Using cmd As New SqlCommand
        '    With cmd
        '        .Connection = con
        '        .CommandText = "spPembelian_CheckDataValid"
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandTimeout = 120
        '        .Parameters.Clear()
        '        .Parameters.AddWithValue("@pNoPesanan", txtNoPesanan.Text.Trim)
        '        '.Parameters.AddWithValue("@pKodeBarang", txtKodeBarang.Text.Trim)
        '        .Parameters.AddWithValue("@pMode", modeChild.Trim)
        '    End With
        '    Using da As New SqlDataAdapter(cmd)
        '        da.Fill(dt)
        '    End Using
        'End Using

        'If dt.Rows.Count > 0 Then
        '    ' Apabila nilai kembalian tidak sama dengan 1 maka munculkan pesan error
        '    If dt.Rows(0)(0).ToString <> "1" Then
        '        lblWarning.Text = dt.Rows(0)(0).ToString
        '        Exit Sub
        '    End If
        'End If

        Dim drowArr As DataRow() = DsTrans.dtItemPembelian.Select("No_Pesanan='" & txtNoPesanan.Text.Trim & "'")
        If drowArr.Count > 0 And modeChild = "new" Then
            lblWarning.Text = "No. Pesanan ini sudah ada di tabel !!"
            Exit Sub
        End If

        Dim drow As DataRow
        If modeChild = "new" Then
            drow = Me.DsTrans.dtItemPembelian.NewRow
        Else
            drow = DsTrans.dtItemPembelian.FindByNo_Pesanan(txtNoPesanan.Text.Trim)
        End If

        drow.BeginEdit()

        drow("No_Pesanan") = txtNoPesanan.Text.Trim
        drow("Tgl_Pesanan") = lblTglPesanan.Text
        drow("Kode_Supplier") = txtKodeSupplier.Text.Trim
        drow("Nama_Supplier") = lblNamaSupplier.Text.Trim
        drow("Total_UangPesanan") = lblTotalTagihanPesanan.Text.Trim
        
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
            Me.DsTrans.dtItemPembelian.Rows.Add(drow)
        End If
        drow.EndEdit()

        clearInputDetail()
        createBtnItemDetail("")
        activeInputDetail(False)

        If DsTrans.dtItemPembelian.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        modeChild = "update"
        activeInputDetail(True)
        createBtnItemDetail("update")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        modeParent = "new"
        clearInputHeader()
        clearInputDetail()
        createBtnHeader()
        activeInputHeader(True)
        activeBtnDetail(True)
        dtpTglJatuhTempo.Enabled = False
    End Sub

    Private Sub dgvPesanan_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        If DsTrans.dtItemPembelian.GetChanges IsNot Nothing Then
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub dgvPesanan_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        If DsTrans.dtItemPembelian.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub txtKodePembelian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePembelian.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            GetHeaderPembelian(txtKodePembelian.Text)
        End If
    End Sub

    Private Sub rdbKredit_CheckedChanged(sender As Object, e As EventArgs) Handles rdbKredit.CheckedChanged
        If rdbKredit.Enabled Then dtpTglJatuhTempo.Enabled = rdbKredit.Checked
    End Sub

    Private Sub btnFindSupplier_Click(sender As Object, e As EventArgs) Handles btnFindSupplier.Click
        Dim _frmFindSupplierPembelian As New frmFindSupplierPembelian
        _frmFindSupplierPembelian.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindSupplierPembelian.getResult
        If _returnList IsNot Nothing Then
            txtKodeSupplier.Text = _returnList(0)
            lblNamaSupplier.Text = _returnList(1)
        End If
        _frmFindSupplierPembelian = Nothing
    End Sub

    Private Sub btnFindPesanan_Click(sender As Object, e As EventArgs) Handles btnFindPesanan.Click
        Dim _frmFindTagihanPesanan As New frmFindTagihanPesanan(txtKodeSupplier.Text)
        _frmFindTagihanPesanan.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindTagihanPesanan.getResult
        If _returnList IsNot Nothing Then
            txtNoPesanan.Text = _returnList(0)
            lblTglPesanan.Text = _returnList(1)
            lblTotalTagihanPesanan.Text = _returnList(2)
        End If
        _frmFindTagihanPesanan = Nothing
    End Sub

    
End Class