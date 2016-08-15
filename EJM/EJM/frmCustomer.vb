Public Class frmCustomer
    Dim mode As String = String.Empty
    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        activeButton()
        GetDataCustomerAll()
    End Sub

    Private Sub GetDataCustomerAll()
        Try
            Me.DaCustomer.Fill(Me.DsTrans.dtCustomer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Tampilkan data di tabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtCustomer.Rows.Count > 0 Then AddcboFind()
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
        With DtCustomerBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "Kode_Customer like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "Nama_Customer like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "Alamat_Customer like '%" & txtFind.Text.Trim & "%'"
                Case 3
                    .Filter = "Telp_Customer like '%" & txtFind.Text.Trim & "%'"
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
        txtNamaCustomer.Enabled = _active
        txtAlamatCustomer.Enabled = _active
        txtTlp.Enabled = _active
        chkActive.Enabled = _active
    End Sub

    Private Sub clearInput()
        lblKodeCustomer.Text = String.Empty
        txtNamaCustomer.Text = String.Empty
        txtAlamatCustomer.Text = String.Empty
        txtTlp.Text = String.Empty
        chkActive.Checked = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        mode = "new"
        activeButton()
        clearInput()
        isActiveInput(True)
        lblKodeCustomer.Text = mode
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        mode = "update"
        activeButton()
        isActiveInput(True)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        mode = ""
        activeButton()
        clearInput()
        isActiveInput(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtNamaCustomer.Text) Then
            MessageBox.Show("Nama Customer harus diisi !!!", "Simpan Data Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtAlamatCustomer.Text) Then
            MessageBox.Show("Alamat Customer harus diisi !!!", "Simpan Data Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtTlp.Text) Then
            MessageBox.Show("No.Telp Customer harus diisi !!!", "Simpan Data Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "spCustomer_Save"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@pKodeCustomer", lblKodeCustomer.Text.Trim)
            cmd.Parameters.AddWithValue("@pNamaCustomer", txtNamaCustomer.Text.Trim)
            cmd.Parameters.AddWithValue("@pAlamatCustomer", txtAlamatCustomer.Text.Trim)
            cmd.Parameters.AddWithValue("@pTelpCustomer", txtTlp.Text.Trim)
            cmd.Parameters.AddWithValue("@pActive", chkActive.Checked)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            dt = New DataTable
            da.Fill(dt)

            da.Dispose()
            cmd.Dispose()


            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0).ToString.Length <> 10 Then
                    MessageBox.Show(dt.Rows(0)(0).ToString, "Simpan Data Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    mode = ""
                    isActiveInput(False)
                    activeButton()
                    GetDataCustomerAll()
                    clearInput()
                    MessageBox.Show("Data berhasil disimpan.", "Simpan Data Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
       
    End Sub

    Private Sub dgvCustomer_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomer.CellMouseClick
        With dgvCustomer
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    lblKodeCustomer.Text = .SelectedRows(0).Cells("cKodeCustomer").Value
                    txtNamaCustomer.Text = .SelectedRows(0).Cells("cNamaCustomer").Value
                    txtAlamatCustomer.Text = .SelectedRows(0).Cells("cAlamatCustomer").Value
                    txtTlp.Text = .SelectedRows(0).Cells("cTelpCustomer").Value
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

    Private Sub dgvCustomer_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomer.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvCustomer.SelectedRows.Count > 0 Then
                mode = "update"
                activeButton()
                isActiveInput(True)
            End If
        End If
    End Sub

    Private Sub dgvCustomer_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvCustomer.CellPainting
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvCustomer.Rows(e.RowIndex).Cells("cActive").Value = False Then
                e.CellStyle.ForeColor = Color.DimGray
            End If
        End If
    End Sub
End Class