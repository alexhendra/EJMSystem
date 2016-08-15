Public Class frmFindBarangStok
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _listResult As List(Of String)
    Private tglTrans As Date

    Private Sub frmFindCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataBarangAll(tglTrans)
    End Sub

    Private Sub GetDataBarangAll(ByVal _tglTrans As Date)
        Try
            Me.DaFindStokBarang.Fill(Me.DsTrans.dtFindStokBarang, _tglTrans)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtFindStokBarang.Rows.Count > 0 Then AddcboFind()
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("Kode")    '0
        cboFind.Items.Add("Nama")    '1        

        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtFindStokBarangBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "KodeBarang like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "NamaBarang like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgv.SelectedRows.Count > 0 Then
                With dgv
                    If .SelectedRows(0).Cells("cStok").Value IsNot Nothing Then
                        If CInt(.SelectedRows(0).Cells("cStok").Value) > 0 Then
                            _listResult = New List(Of String)
                            _listResult.Add(.SelectedRows(0).Cells("cKodeBarang").Value.ToString)
                            _listResult.Add(.SelectedRows(0).Cells("cNamaBarang").Value.ToString)
                            _listResult.Add(.SelectedRows(0).Cells("cUOM").Value.ToString)
                        Else
                            MessageBox.Show("Barang yang stoknya <= 0 tidak bisa digunakan", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                    Me.Close()
                End With
            End If
        End If
    End Sub

    Private Sub dgvBarang_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv.CellPainting
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgv.Rows(e.RowIndex).Cells("cStok").Value IsNot Nothing Then
                If CInt(dgv.Rows(e.RowIndex).Cells("cStok").Value) < 1 Then
                    e.CellStyle.ForeColor = Color.DimGray
                End If
            End If
        End If
    End Sub

    Public Function getResult() As List(Of String)
        Return _listResult
    End Function

    Public Sub New(ByVal _tglTrans As Date)

        ' This call is required by the designer.
        InitializeComponent()
        tglTrans = _tglTrans
    End Sub
End Class