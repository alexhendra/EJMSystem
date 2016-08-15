Public Class frmStokSekarang
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Private _result As String = String.Empty

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        GetDataBarangAll()
    End Sub

    Private Sub GetDataBarangAll()
        Try
            Me.DaStokSekarang.Fill(Me.DsTrans.dtStokSekarang)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Menampilkan semua data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtStokSekarang.Rows.Count > 0 Then
            AddcboFind()
            frmMain.tlStrpLblStatus.Text = "Total Data = " & DsTrans.dtStokSekarang.Rows.Count & " item"
        End If
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("Kode Barang")    '0
        cboFind.Items.Add("Nama Barang")    '1
        cboFind.Items.Add("UOM")            '2
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtStokSekarangBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "KodeBarang like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "NamaBarang like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "UomName like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class