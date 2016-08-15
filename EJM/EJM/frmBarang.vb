Public Class frmBarang
    Dim mode As String = String.Empty

    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeButton()
        GetDataBarangAll()
    End Sub

    Private Sub GetDataBarangAll()
        Try
            Me.DaBarang.Fill(Me.DsTrans.dtBarang)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data Barang", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtBarang.Rows.Count > 0 Then AddcboFind()
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("Kode Barang")    '0
        cboFind.Items.Add("Nama Barang")    '1
        cboFind.Items.Add("Harga")          '2
        cboFind.Items.Add("UOM")            '3
        cboFind.Items.Add("Sisa Stok")      '4
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtBarangBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "Kode_Barang like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "Nama_Barang like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    If String.IsNullOrEmpty(txtFind.Text.Trim) Then
                        .Filter = "Harga=0"
                    Else
                        .Filter = "Harga =" & txtFind.Text.Trim
                    End If
                Case 3
                    .Filter = "Satuan like '%" & txtFind.Text.Trim & "%'"
                Case 4
                    If String.IsNullOrEmpty(txtFind.Text.Trim) Then
                        .Filter = "Sisa_Stok=0"
                    Else
                        .Filter = "Sisa_Stok =" & txtFind.Text.Trim
                    End If
            End Select
        End With
    End Sub

    Private Sub GetUOM()


        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select uomId,uomName from tBase_UOM where Active=1"
        cmd.Parameters.Clear()

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        da.Fill(dt)

        cmd.Dispose()
        da.Dispose()

        cboUOM.DataSource = dt
        cboUOM.ValueMember = "uomId"
        cboUOM.DisplayMember = "uomName"

        If cboUOM.Items.Count > 0 Then cboUOM.SelectedIndex = 0
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

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        mode = "new"
        activeButton()
        clearInput()
        isActiveInput(True)
        GetUOM()
        lblKodeBarang.Text = mode
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

    Private Sub isActiveInput(ByVal _active As Boolean)
        txtNamaBarang.Enabled = _active
        cboUOM.Enabled = _active
        chkActive.Enabled = _active
    End Sub

    Private Sub clearInput()
        lblKodeBarang.Text = String.Empty
        txtNamaBarang.Text = String.Empty
        If cboUOM.Items.Count > 0 Then cboUOM.SelectedIndex = 0
        chkActive.Checked = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtNamaBarang.Text) Then
            MessageBox.Show("Nama barang harus diisi !!!", "Simpan Data Barang", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(cboUOM.SelectedValue.ToString) Then
            MessageBox.Show("Pilih UOM !!!", "Simpan Data Barang", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If


        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "spBarang_Save"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@pKodeBarang", lblKodeBarang.Text.Trim)
            cmd.Parameters.AddWithValue("@pNamaBarang", txtNamaBarang.Text.Trim)
            cmd.Parameters.AddWithValue("@pUOM", cboUOM.SelectedValue.ToString.Trim)
            cmd.Parameters.AddWithValue("@pActive", chkActive.Checked)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            dt = New DataTable
            da.Fill(dt)

            da.Dispose()
            cmd.Dispose()

            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0).ToString.Length <> 10 Then
                    MessageBox.Show(dt.Rows(0)(0).ToString, "Simpan Data Barang", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    mode = ""
                    isActiveInput(False)
                    activeButton()
                    GetDataBarangAll()
                    clearInput()
                    MessageBox.Show("Data berhasil disimpan.", "Simpan Data Barang", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data Barang", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub dgvBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBarang.CellMouseClick
        GetUOM()
        With dgvBarang
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    lblKodeBarang.Text = .SelectedRows(0).Cells("cKodeBarang").Value
                    txtNamaBarang.Text = .SelectedRows(0).Cells("cNamaBarang").Value
                    cboUOM.Text = .SelectedRows(0).Cells("cSatuan").Value
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

    Private Sub dgvBarang_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBarang.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvBarang.SelectedRows.Count > 0 Then
                mode = "update"
                activeButton()
                isActiveInput(True)
            End If
        End If
    End Sub

    Private Sub dgvBarang_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvBarang.CellPainting
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvBarang.Rows(e.RowIndex).Cells("cActive").Value = False Then
                e.CellStyle.ForeColor = Color.DimGray
            End If
        End If
    End Sub

End Class