Public Class frmFindCustomer
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _listResult As List(Of String)

    Private Sub frmFindCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataBarangAll()
    End Sub

    Private Sub GetDataBarangAll()
        Try
            Me.DaCustomer.Fill(Me.DsTrans.dtCustomer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgv.SelectedRows.Count > 0 Then
                With dgv
                    If .SelectedRows(0).Cells("cActive").Value = True Then
                        _listResult = New List(Of String)
                        _listResult.Add(.SelectedRows(0).Cells("cKodeCustomer").Value.ToString)
                        _listResult.Add(.SelectedRows(0).Cells("cNamaCustomer").Value.ToString)
                        _listResult.Add(.SelectedRows(0).Cells("cAlamatCustomer").Value.ToString)
                    Else
                        MessageBox.Show("Data customer yang tidak aktif tidak bisa digunakan", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Me.Close()
                End With
            End If
        End If
    End Sub

    Private Sub dgvBarang_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv.CellPainting
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgv.Rows(e.RowIndex).Cells("cActive").Value = False Then
                e.CellStyle.ForeColor = Color.DimGray
            End If
        End If
    End Sub

    Public Function getResult() As List(Of String)
        Return _listResult
    End Function
End Class