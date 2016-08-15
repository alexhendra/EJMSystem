Public Class frmFindBarangPesanan
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _listResult As List(Of String)
    Private _noPesanan As String = ""

    Public Sub New(ByVal noPesanan As String)

        ' This call is required by the designer.
        InitializeComponent()

        _noPesanan = noPesanan

    End Sub

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataAll()
    End Sub

    Private Sub GetDataAll()
        Try
            Me.DaFindBarangPesanan.Fill(Me.DsTrans.dtFindBarangPesanan, _noPesanan)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtFindBarangPesanan.Rows.Count > 0 Then AddcboFind()
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()     
        cboFind.Items.Add("No. Pesanan")        '0       
        cboFind.Items.Add("Kode Barang")        '1
        cboFind.Items.Add("Nama Barang")        '2
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtFindBarangPesananBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "No_Pesanan like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "Kode_Barang like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "Nama_Barang like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgv.SelectedRows.Count > 0 Then
                With dgv
                    _listResult = New List(Of String)
                    If .SelectedRows(0).Cells("cKodeBarang").Value IsNot Nothing Then
                        _listResult.Add(.SelectedRows(0).Cells("cKodeBarang").Value.ToString)
                    End If
                    If .SelectedRows(0).Cells("cNamaBarang").Value IsNot Nothing Then
                        _listResult.Add(.SelectedRows(0).Cells("cNamaBarang").Value.ToString)
                    End If
                    If .SelectedRows(0).Cells("cUOM").Value IsNot Nothing Then
                        _listResult.Add(.SelectedRows(0).Cells("cUOM").Value.ToString)
                    End If
                    If .SelectedRows(0).Cells("cJumlahPesan").Value IsNot Nothing Then
                        _listResult.Add(.SelectedRows(0).Cells("cJumlahPesan").Value.ToString)
                    End If
                    If .SelectedRows(0).Cells("cJumlahRetur").Value IsNot Nothing Then
                        _listResult.Add(.SelectedRows(0).Cells("cJumlahRetur").Value.ToString)
                    End If

                    Me.Close()
                End With
            End If
        End If
    End Sub

    Public Function getResult() As List(Of String)
        Return _listResult
    End Function

    
End Class