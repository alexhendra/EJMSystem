Public Class frmRptCustomer
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim _dsReport As New dsLaporan

    Private Sub frmReport1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GetDataAll()
            Dim cr As New LapCustomer
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
                .CommandText = "select Kode_Customer,Nama_Customer,Alamat_Customer,Telp_Customer from tBase_Customer"
                .CommandType = CommandType.Text
                .Parameters.Clear()
            End With
            Using da As New SqlDataAdapter(cmd)
                _dsReport.dtLap_Customer.Rows.Clear()
                da.Fill(_dsReport.dtLap_Customer)
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class