Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRptRetur
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim _dsReport As New dsLaporan

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Try
            btnTampilkan.Text = "Ditunggu..."

            GetDataAll()
            Dim cr As New LapReturPembelian
            cr.SetDataSource(_dsReport)

            Me.CrystalReportViewer1.ReportSource = cr
            btnTampilkan.Text = "Tampilkan"
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetDataAll()
        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = "spLap_ReturPembelian"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pFromDate", dtpFrom.Value)
                .Parameters.AddWithValue("@pToDate", dtpTo.Value)
            End With
            Using da As New SqlDataAdapter(cmd)
                _dsReport.dtLap_ReturPembelian.Rows.Clear()
                da.Fill(_dsReport.dtLap_ReturPembelian)
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class