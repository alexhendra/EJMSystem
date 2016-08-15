Public Class frmSupplier
    Dim mode As String = String.Empty
    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeButton()
        GetDataSupplierAll()
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("Kode")    '0
        cboFind.Items.Add("Nama")    '1
        cboFind.Items.Add("Alamat")  '2
        cboFind.Items.Add("Telp")    '3
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtSupplierBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "Kode_Supplier like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "Nama_Supplier like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "Alamat_Supplier like '%" & txtFind.Text.Trim & "%'"
                Case 3
                    .Filter = "Telp_Supplier like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub activeButton()
        pnlButton.Controls.Clear()
        If mode = "new" Then
            pnlButton.Controls.Add(btnSave)
            pnlButton.Controls.Add(btnCancel)
            pnlButton.Controls.Add(btnExit)
        ElseIf mode = "edit" Then
            pnlButton.Controls.Add(btnEdit)
            pnlButton.Controls.Add(btnCancel)
            pnlButton.Controls.Add(btnExit)
        ElseIf mode = "update" Then
            pnlButton.Controls.Add(btnSave)
            pnlButton.Controls.Add(btnCancel)
            pnlButton.Controls.Add(btnExit)
        Else
            pnlButton.Controls.Add(btnNew)
            pnlButton.Controls.Add(btnExit)
        End If

        If pnlButton.Controls.Count > 0 Then
            For Each item As Control In pnlButton.Controls
                item.Visible = True
            Next
        End If
    End Sub

    Private Sub isActiveInput(ByVal _active As Boolean)
        txtNamaSupplier.Enabled = _active
        txtAlamatSupplier.Enabled = _active
        txtTelp.Enabled = _active
        chkActive.Enabled = _active
    End Sub

    Private Sub clearInput()
        lblKodeSupplier.Text = String.Empty
        txtNamaSupplier.Text = String.Empty
        txtTelp.Text = String.Empty
        txtAlamatSupplier.Text = String.Empty
        chkActive.Checked = True
    End Sub

    Private Sub GetDataSupplierAll()
        Try
            Me.DaSupplier.Fill(Me.DsTrans.dtSupplier)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Tampilkan data di tabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtSupplier.Rows.Count > 0 Then AddcboFind()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        mode = "new"
        activeButton()
        clearInput()
        isActiveInput(True)
        lblKodeSupplier.Text = mode
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        mode = "update"
        activeButton()
        isActiveInput(True)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        mode = ""
        activeButton()
        clearInput()
        isActiveInput(False)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtNamaSupplier.Text) Then
            MessageBox.Show("Nama supplier harus diisi !!!", "Simpan Data Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtAlamatSupplier.Text) Then
            MessageBox.Show("Alamat supplier harus diisi !!!", "Simpan Data Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtTelp.Text) Then
            MessageBox.Show("No.Telp supplier harus diisi !!!", "Simpan Data Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If


        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "spSupplier_Save"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@pKodeSupplier", lblKodeSupplier.Text.Trim)
            cmd.Parameters.AddWithValue("@pNamaSupplier", txtNamaSupplier.Text.Trim)
            cmd.Parameters.AddWithValue("@pAlamatSupplier", txtAlamatSupplier.Text.Trim)
            cmd.Parameters.AddWithValue("@pTelpSupplier", txtTelp.Text.Trim)
            cmd.Parameters.AddWithValue("@pActive", chkActive.Checked)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            dt = New DataTable
            da.Fill(dt)

            da.Dispose()
            cmd.Dispose()

            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0).ToString.Length <> 10 Then
                    MessageBox.Show(dt.Rows(0)(0).ToString, "Simpan Data Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    mode = ""
                    isActiveInput(False)
                    activeButton()
                    GetDataSupplierAll()
                    clearInput()
                    MessageBox.Show("Data berhasil disimpan.", "Simpan Data Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub dgvSupplier_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplier.CellMouseClick
        With dgvSupplier
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    lblKodeSupplier.Text = .SelectedRows(0).Cells("cKodeSupplier").Value
                    txtNamaSupplier.Text = .SelectedRows(0).Cells("cNamaSupplier").Value
                    txtAlamatSupplier.Text = .SelectedRows(0).Cells("cAlamatSupplier").Value
                    txtTelp.Text = .SelectedRows(0).Cells("cTelpSupplier").Value
                    If .SelectedRows(0).Cells("cActive").Value = True Then
                        chkActive.Checked = True
                    Else
                        chkActive.Checked = False
                    End If

                    mode = "edit"
                    activeButton()
                    isActiveInput(False)
                End If
            End If
        End With
    End Sub

    Private Sub dgvSupplier_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplier.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvSupplier.SelectedRows.Count > 0 Then
                mode = "update"
                activeButton()
                isActiveInput(True)
            End If
        End If
    End Sub

    Private Sub dgvSupplier_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvSupplier.CellPainting
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvSupplier.Rows(e.RowIndex).Cells("cActive").Value = False Then
                e.CellStyle.ForeColor = Color.DimGray
            End If
        End If
    End Sub
End Class