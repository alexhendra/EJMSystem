Public Class frmFindSupplier
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _result As String = String.Empty

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub GetDataSupplierAll()
        Try
            Me.DaSupplier.Fill(Me.DsTrans.dtSupplier)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtSupplier.Rows.Count > 0 Then AddcboFind()
    End Sub

    'Private Sub dgvSupplier_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplier.CellMouseClick
    '    With dgvSupplier
    '        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
    '            If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
    '            If .SelectedRows.Count > 0 Then
    '                'lblKodeSupplier.Text = .SelectedRows(0).Cells("cKodeSupplier").Value
    '                'txtNamaSupplier.Text = .SelectedRows(0).Cells("cNamaSupplier").Value
    '                'txtAlamatSupplier.Text = .SelectedRows(0).Cells("cAlamatSupplier").Value
    '                'txtTelp.Text = .SelectedRows(0).Cells("cTelpSupplier").Value
    '                'If .SelectedRows(0).Cells("cActive").Value = True Then
    '                '    chkActive.Checked = True
    '                'Else
    '                '    chkActive.Checked = False
    '                'End If

    '                'mode = "edit"
    '                'activeButton()
    '                'isActiveInput(False)
    '            End If
    '        End If
    '    End With
    'End Sub

    Private Sub dgvSupplier_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplier.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvSupplier.SelectedRows.Count > 0 Then
                With dgvSupplier
                    If .SelectedRows(0).Cells("cActive").Value = False Then
                        MessageBox.Show("Data supplier yang tidak aktif tidak bisa digunakan", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        _result = .SelectedRows(0).Cells("cKodeSupplier").Value.ToString
                    End If
                    Me.Close()
                End With
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

    Public Function getResult() As String
        Return _result
    End Function
End Class