Public Class frmFindBarang
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _result As String = String.Empty

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataBarangAll()
    End Sub

    Private Sub GetDataBarangAll()
        Try
            Me.DaBarang.Fill(Me.DsTrans.dtBarang)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    .Filter = "UOM like '%" & txtFind.Text.Trim & "%'"
                Case 4
                    If String.IsNullOrEmpty(txtFind.Text.Trim) Then
                        .Filter = "Sisa_Stok=0"
                    Else
                        .Filter = "Sisa_Stok =" & txtFind.Text.Trim
                    End If
            End Select
        End With
    End Sub

    'Private Sub dgvBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBarang.CellMouseClick
    '    With dgvBarang
    '        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
    '            If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
    '            If .SelectedRows.Count > 0 Then
    '                lblKodeBarang.Text = .SelectedRows(0).Cells("cKodeBarang").Value
    '                txtNamaBarang.Text = .SelectedRows(0).Cells("cNamaBarang").Value
    '                txtHarga.Text = Format(.SelectedRows(0).Cells("cHarga").Value, "###")
    '                cboUOM.Text = .SelectedRows(0).Cells("cSatuan").Value
    '                txtSisaStok.Text = .SelectedRows(0).Cells("cSisaStok").Value
    '                If .SelectedRows(0).Cells("cActive").Value = True Then
    '                    chkActive.Checked = True
    '                Else
    '                    chkActive.Checked = False
    '                End If

    '                mode = "edit"
    '                activeButton()
    '                isActiveInput(False)
    '            End If
    '        End If
    '    End With
    'End Sub

    Private Sub dgvBarang_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBarang.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvBarang.SelectedRows.Count > 0 Then
                With dgvBarang
                    If .SelectedRows(0).Cells("cActive").Value = True Then
                        _result = .SelectedRows(0).Cells("cKodeBarang").Value.ToString
                    Else
                        MessageBox.Show("Data barang yang tidak aktif tidak bisa digunakan", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Me.Close()
                End With
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

    Public Function getResult() As String
        Return _result
    End Function
End Class