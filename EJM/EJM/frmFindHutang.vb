Public Class frmFindHutang
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _listResult As List(Of String)
    Private _kodeSupplier As String = String.Empty

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFind.Focus()
        GetDataAll()
    End Sub

    Private Sub GetDataAll()
        Try
            Me.DaFindPembelianHutang.Fill(Me.DsTrans.dtFindPembelianHutang, _kodeSupplier)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtFindPembelianHutang.Rows.Count > 0 Then AddcboFind()
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("Kode Pembelian")    '0
        cboFind.Items.Add("Kode Supplier")     '1
        cboFind.Items.Add("Nama Supplier")     '2
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtFindPembelianHutangBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "Kode_Pembelian like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "Kode_Supplier like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "Nama_Supplier like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgv.SelectedRows.Count > 0 Then
                With dgv
                    _listResult = New List(Of String)
                    _listResult.Add(.SelectedRows(0).Cells("cKodePembelian").Value.ToString)
                    If .SelectedRows(0).Cells("cTglBeli").Value IsNot Nothing Then
                        _listResult.Add(Format(.SelectedRows(0).Cells("cTglBeli").Value, "MM/dd/yyyy"))
                    End If
                    If .SelectedRows(0).Cells("cTglJatuhTempo").Value IsNot Nothing Then
                        _listResult.Add(Format(.SelectedRows(0).Cells("cTglJatuhTempo").Value, "MM/dd/yyyy"))
                    End If
                    If .SelectedRows(0).Cells("cTotalHutang").Value IsNot Nothing Then
                        _listResult.Add(Format(.SelectedRows(0).Cells("cTotalHutang").Value, "###0"))
                    End If
                    Me.Close()
                End With
            End If
        End If
    End Sub

    Public Function getResult() As List(Of String)
        Return _listResult
    End Function

    Public Sub New(ByVal kodeSupplier As String)
        ' This call is required by the designer.
        InitializeComponent()

        _kodeSupplier = kodeSupplier
    End Sub
End Class