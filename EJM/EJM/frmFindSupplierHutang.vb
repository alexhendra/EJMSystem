﻿Public Class frmFindSupplierHutang
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _listResult As List(Of String)

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFind.Focus()
        GetDataAll()
    End Sub

    Private Sub GetDataAll()
        Try
            Me.DaFindSupplierHutang.Fill(Me.DsTrans.dtFindSupplierHutang)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtFindSupplierHutang.Rows.Count > 0 Then AddcboFind()
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("Kode Supplier")    '0
        cboFind.Items.Add("Nama Supplier")    '1
        cboFind.Items.Add("Alamat Supplier")  '2        
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtFindSupplierHutangBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "Kode_Supplier like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "Nama_Supplier like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "Alamat_Supplier like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgv.SelectedRows.Count > 0 Then
                With dgv
                    _listResult = New List(Of String)
                    _listResult.Add(.SelectedRows(0).Cells("cKodeSupplier").Value.ToString)
                    _listResult.Add(.SelectedRows(0).Cells("cNamaSupplier").Value.ToString)

                    Me.Close()
                End With
            End If
        End If
    End Sub

    Public Function getResult() As List(Of String)
        Return _listResult
    End Function
End Class