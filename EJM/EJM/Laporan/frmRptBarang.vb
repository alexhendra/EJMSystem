Public Class frmRptBarang
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim _dsReport As New dsLaporan

    Private Sub frmReport1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GetDataAll()
            Dim cr As New LapBarang
            cr.SetDataSource(_dsReport)
            Me.CrystalReportViewer1.ReportSource = cr
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetDataAll()

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spLap_BarangAll"
                .Parameters.Clear()
            End With
            Using da As New SqlDataAdapter(cmd)
                'dtBarang = New DataTable
                _dsReport.dtLap_Barang.Rows.Clear()
                da.Fill(_dsReport.dtLap_Barang)
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class