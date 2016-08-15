Public Class frmPelunasanHutang
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim modeParent As String = String.Empty
    Dim modeChild As String = ""

    Private Sub frmPelunasanHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        createBtnHeader()
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ResetInputHeader()
        txtKodePelunasan.Enabled = False
        modeParent = "new"
        activeInputHeader(True)
        createBtnHeader()
        activeBtnItem(True)
        dtpTglPelunasan.Focus()

        lblWarning.Text = String.Empty
    End Sub

    Private Sub ResetInputHeader()
        txtKodePelunasan.Clear()
        txtKodePembelian.Clear()
        txtKodeSupplier.Clear()
        dtpTglPelunasan.Value = Now.Date
        lblNamaSupplier.Text = String.Empty
    End Sub

    Private Sub activeInputHeader(ByVal _isActive As Boolean)
        dtpTglPelunasan.Enabled = _isActive
        txtKodeSupplier.Enabled = _isActive
        btnFindSupplier.Enabled = _isActive
    End Sub

    Private Sub activeInputDetail(ByVal _isActive As Boolean)
        txtKodePembelian.Enabled = _isActive
        btnFindPembelian.Enabled = _isActive
        txtTotalBayar.Enabled = _isActive
    End Sub

    Private Sub ResetInputDetail()
        txtKodePembelian.Clear()
        lblTglBeli.Text = ""
        lblTglJatuhTempo.Text = ""
        lblTotalHutang.Text = ""
        txtTotalBayar.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Membatalkan perubahan yang ada di data table-nya
        Me.DsTrans.dtItemPelunasan.RejectChanges()

        ResetInputHeader()
        activeInputHeader(False)

        modeParent = ""
        createBtnHeader()
        clearTabelHutang()
        ResetInputDetail()
        activeInputDetail(False)
        createBtnItemDetail("")
        activeBtnItem(False)
        txtKodePelunasan.Enabled = True

        frmMain.tlStrpLblStatus.Text = "Ready"
        lblWarning.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFindSupplier_Click(sender As Object, e As EventArgs) Handles btnFindSupplier.Click
        Dim _frmFindSupplierHutang As New frmFindSupplierHutang
        _frmFindSupplierHutang.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindSupplierHutang.getResult
        If _returnList IsNot Nothing Then
            txtKodeSupplier.Text = _returnList(0)
            lblNamaSupplier.Text = _returnList(1)
        End If
        _frmFindSupplierHutang = Nothing
    End Sub

    Private Sub btnFindPembelian_Click(sender As Object, e As EventArgs) Handles btnFindPembelian.Click
        Dim _frmFindHutang As New frmFindHutang(txtKodeSupplier.Text)
        _frmFindHutang.ShowDialog()
        Dim _returnList As List(Of String) = _frmFindHutang.getResult
        If _returnList IsNot Nothing Then
            txtKodePembelian.Text = _returnList(0)
            lblTglBeli.Text = _returnList(1)
            lblTglJatuhTempo.Text = _returnList(2)
            lblTotalHutang.Text = _returnList(3)
        End If
        _frmFindHutang = Nothing
    End Sub

    Private Sub GetItemPelunasan(ByVal _kodePelunasan As String)
        Me.DsTrans.dtItemPelunasan.Clear()
        Me.DaItemPelunasan.Fill(Me.DsTrans.dtItemPelunasan, _kodePelunasan.Trim)
    End Sub

    Private Sub clearTabelHutang()
        Me.DsTrans.dtItemPelunasan.Rows.Clear()
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
        frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTglPelunasan.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeSupplier.Text) Then
            lblWarning.Text = "Kode supplier harus diisi !!!"
            Exit Sub
        End If

        If DsTrans.dtItemPelunasan.Rows.Count < 1 Then
            lblWarning.Text = "Silahkan masukkan item pembelian terlebih dahulu !!!"
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        dgv.EndEdit()    ' memberhentikan edit data di gridview
        DtItemPelunasanBindingSource.EndEdit() ' memberhentikan edit data di databinding

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
                    .CommandText = "spPelunasanHutang_SaveHeader"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@pKodePelunasan", txtKodePelunasan.Text.Trim)
                    .Parameters.AddWithValue("@pKodeSupplier", txtKodeSupplier.Text.Trim)
                    .Parameters.AddWithValue("@pTglPelunasan", dtpTglPelunasan.Value)
                    .Parameters.AddWithValue("@pMode", modeParent.Trim)
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
                Me.DsTrans.dtItemPelunasan.RejectChanges()
                Me.DsTrans.dtItemPelunasan.Rows.Clear()

                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                Else
                    MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            ' Apabila tidak ada perubahan dengan item yang ada di tabel
            If Me.DsTrans.dtItemPelunasan.GetChanges() Is Nothing Then
                trans.Commit()
                modeParent = ""
                ResetInputHeader()
                activeInputHeader(False)
                txtKodePelunasan.Enabled = True
                createBtnHeader()
                clearTabelHutang()
                activeBtnItem(False)

                If con.State = ConnectionState.Open Then con.Close()

                frmMain.tlStrpLblStatus.Text = "Ready"
                MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' --- Proses penyimpanan data penerimaan detail ---
            Dim cmdUpdate As New SqlCommand
            With cmdUpdate
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPelunasanHutang_SaveDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePelunasan", _returnValue.Trim)
                .Parameters.Add("@pKodePembelian", SqlDbType.VarChar, 14, "Kode_Pembelian")
                .Parameters.AddWithValue("@pKodeSupplier", txtKodeSupplier.Text.Trim)
                .Parameters.Add("@pTotBayar", SqlDbType.Money, 10, "Total_Bayar")
                .Parameters.Add("@pModeChild", SqlDbType.VarChar, 10, "pMode")
                .Parameters.AddWithValue("@pModeParent", modeParent)
                .Parameters.Add("@pReturn", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Dim cmdDelete As New SqlCommand
            With cmdDelete
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPelunasanHutang_DeleteDetail"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePelunasan", _returnValue.Trim)
                .Parameters.Add("@pKodePembelian", SqlDbType.VarChar, 14, "Kode_Pembelian")
                .Parameters.Add("@pReturn", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                .Transaction = trans
            End With

            Using da As New SqlDataAdapter
                da.UpdateCommand = cmdUpdate
                da.InsertCommand = cmdUpdate
                da.DeleteCommand = cmdDelete

                da.Update(Me.DsTrans.dtItemPelunasan)

                _returnValue = String.Empty

                If TypeOf cmdUpdate.Parameters("@pReturn").Value Is String Then
                    _returnValue = cmdUpdate.Parameters("@pReturn").Value.ToString
                End If
            End Using

            ' Apabila nilai yang dikembalikan dr database nilai stringnya tdk sama dgn 1
            ' Maka data di rollback atau dibatalkan di database
            ' di Storeprocedure, apabila data bisa disimpan maka kembalikan nilai = 1
            If _returnValue.Length <> "1" Then
                Me.DsTrans.dtItemPelunasan.RejectChanges()
                Me.DsTrans.dtItemPelunasan.Rows.Clear()

                If Not String.IsNullOrEmpty(_returnValue) Then
                    lblWarning.Text = _returnValue
                    trans.Rollback()
                    con.Close()
                Else
                    Throw New Exception("Terjadi error pada saat penyimpanan data !")
                    'MessageBox.Show("Terjadi error pada saat penyimpanan data !", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If

            trans.Commit()
            DsTrans.dtItemPelunasan.AcceptChanges()
            modeParent = ""
            ResetInputHeader()
            activeInputHeader(False)
            txtKodePelunasan.Enabled = True
            createBtnHeader()
            clearTabelHutang()
            activeBtnItem(False)

            frmMain.tlStrpLblStatus.Text = "Ready"
            MessageBox.Show("Data sudah disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            trans.Rollback()
            Me.DsTrans.dtItemPelunasan.RejectChanges()
            Me.DsTrans.dtItemPelunasan.Rows.Clear()
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub GetDataHeader(ByVal kodePelunasan As String)
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spPelunasanHutang_GetDataHeader"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pKodePelunasan", kodePelunasan.Trim)
            End With
            Using da As New SqlDataAdapter(cmd)
                dt = New DataTable()
                da.Fill(dt)
            End Using
        End Using

        If dt.Rows.Count > 0 Then
            For Each item As DataRow In dt.Rows
                txtKodeSupplier.Text = item("Kode_Supplier").ToString.Trim
                lblNamaSupplier.Text = item("Nama_Supplier").ToString
                dtpTglPelunasan.Value = item("Tgl_Pelunasan")
            Next

            GetItemPelunasan(kodePelunasan)
            modeParent = "update"
            createBtnHeader()
            txtKodePelunasan.Enabled = False
            dtpTglPelunasan.Enabled = True
            activeBtnItem(True)
        Else
            lblWarning.Text = "Data tidak ditemukan !!"
        End If
    End Sub

    Private Sub txtKodePelunasan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePelunasan.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodePelunasan.Text) Then
                GetDataHeader(txtKodePelunasan.Text)
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        modeChild = "new"
        createBtnItemDetail("new")
        ResetInputDetail()
        activeInputDetail(True)
        txtKodePembelian.Focus()
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

    Private Sub activeBtnItem(ByVal _isActive As Boolean)
        pnlBtnDetail.Enabled = _isActive
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        modeChild = "update"
        activeInputDetail(True)
        createBtnItemDetail("update")
    End Sub

    Private Sub btnCancelItem_Click(sender As Object, e As EventArgs) Handles btnCancelItem.Click
        modeChild = ""
        ResetInputDetail()
        createBtnItemDetail("")
        activeInputDetail(False)
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        lblWarning.Text = String.Empty

        If isLockData() Then
            lblWarning.Text = "Data sedang di-LOCK !!!"
            Exit Sub
        End If

        If isClosing(dtpTglPelunasan.Value.Date) Then
            lblWarning.Text = "Tanggal ini sudah dilakukan closing !!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodeSupplier.Text) Then
            lblWarning.Text = "Kode Supplier harus diisi !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(lblNamaSupplier.Text) Then
            lblWarning.Text = "Kode Supplier tidak valid !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtKodePembelian.Text) Then
            lblWarning.Text = "Kode Pembelian harus diisi !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(lblTglBeli.Text) Then
            lblWarning.Text = "Kode Pembelian tidak valid !!!"
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtTotalBayar.Text) Then
            lblWarning.Text = "Total Bayar harus diisi !!!"
            Exit Sub
        End If

        If Not IsNumeric(txtTotalBayar.Text) Then
            lblWarning.Text = "Total Bayar harus diisi angka !!!"
            Exit Sub
        End If

        Dim drow As DataRow
        If modeChild = "new" Then
            drow = Me.DsTrans.dtItemPelunasan.NewRow
        Else
            drow = DsTrans.dtItemPelunasan.FindByKode_Pembelian(txtKodePembelian.Text.Trim)
        End If

        ' Proses mencegah ada item yang sama diinput lebih dari 1 kali ke tabel
        If DsTrans.dtItemPelunasan.Rows.Count > 0 Then
            Dim drowArr As DataRow() = DsTrans.dtItemPelunasan.Select("Kode_Pembelian='" & txtKodePembelian.Text.Trim & "'")
            If drowArr.Count > 1 Then
                lblWarning.Text = "Item ini sudah ada di tabel !!!"
                Exit Sub
            End If
        End If

        If modeChild <> "new" Then drow.BeginEdit()

        drow("Kode_Pembelian") = txtKodePembelian.Text
        drow("Tgl_Beli") = lblTglBeli.Text.Trim
        drow("Tgl_Jatuh_Tempo") = lblTglJatuhTempo.Text.Trim
        drow("TotalHutang") = lblTotalHutang.Text.Trim
        drow("Total_Bayar") = txtTotalBayar.Text.Trim

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
            Me.DsTrans.dtItemPelunasan.Rows.Add(drow)
        Else
            drow.EndEdit()
        End If

        ResetInputDetail()
        createBtnItemDetail("")
        activeInputDetail(False)

        If DsTrans.dtItemPelunasan.GetChanges IsNot Nothing Then
            frmMain.tlStrpLblStatus.Text = "* Tekan simpan untuk menyimpan perubahan data"
        End If
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        With dgv
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    txtKodePembelian.Text = .SelectedRows(0).Cells("cKodePembelian").Value.ToString
                    lblTglBeli.Text = Format(.SelectedRows(0).Cells("cTglPembelian").Value, "MM/dd/yyyy")
                    lblTglJatuhTempo.Text = Format(.SelectedRows(0).Cells("cTglJatuhTempo").Value, "MM/dd/yyyy")
                    lblTotalHutang.Text = Format(.SelectedRows(0).Cells("cTotalHutang").Value, "###0")
                    txtTotalBayar.Text = Format(.SelectedRows(0).Cells("cTotalDibayar").Value, "###0")

                    modeChild = "edit"
                    createBtnItemDetail("edit")
                    activeBtnItem(True)
                    activeInputDetail(False)
                End If
            End If
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim drow As DataRow

        If String.IsNullOrEmpty(txtKodePembelian.Text) Then
            lblWarning.Text = "Isi Kode Pembelian terlebih dahulu !"
            Exit Sub
        End If


        drow = DsTrans.dtItemPelunasan.FindByKode_Pembelian(txtKodePembelian.Text.Trim)

        If drow IsNot Nothing Then
            drow.Delete()
            drow.AcceptChanges()
            drow = DsTrans.dtItemPelunasan.FindByKode_Pembelian(txtKodePembelian.Text.Trim)

            If drow Is Nothing Then
                modeChild = "delete"
                createBtnItemDetail("")
                ResetInputDetail()
            End If
        End If
    End Sub

    Private Sub txtKodeSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeSupplier.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodeSupplier.Text) Then
                FindSupplierByKode(txtKodeSupplier.Text)
            End If
        End If
    End Sub

    Private Sub FindSupplierByKode(ByVal kodeSupplier As String)
        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spPelunasanHutang_FindSupplierByKode"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pKodeSupplier", kodeSupplier.Trim)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                txtKodeSupplier.Text = drow("Kode_Supplier").ToString.Trim
                lblNamaSupplier.Text = drow("Nama_Supplier").ToString.Trim
            Next
        Else
            lblWarning.Text = "Data Supplier tidak ditemukan !!"
        End If
    End Sub

    Private Sub txtKodePembelian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePembelian.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If Not String.IsNullOrEmpty(txtKodePembelian.Text) Then
                FindPembelianByKode(txtKodePembelian.Text, txtKodeSupplier.Text)
            End If
        End If
    End Sub

    Private Sub FindPembelianByKode(ByVal kodePembelian As String, ByVal kodeSupplier As String)
        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spPelunasanHutang_FindPembelianByKode"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pKodePembelian", kodePembelian.Trim)
        cmd.Parameters.AddWithValue("@pKodeSupplier", kodeSupplier.Trim)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                txtKodePembelian.Text = drow("Kode_Pembelian").ToString.Trim
                lblTglBeli.Text = Format(drow("Tgl_Beli"), "MM/dd/yyyy")
                lblTglJatuhTempo.Text = Format(drow("Tgl_Jatuh_Tempo"), "MM/dd/yyyy")
                lblTotalHutang.Text = Format(drow("TotalHutang"), "###0")
            Next
        Else
            lblWarning.Text = "Data Pembelian tidak ditemukan !!"
        End If
    End Sub
End Class