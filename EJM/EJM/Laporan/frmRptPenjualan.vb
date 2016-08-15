Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRptPenjualan
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim _dsReport As New dsLaporan

    Private Sub frmRptPenjualan_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddCboJenisLaporan()
    End Sub

    Private Sub AddCboJenisLaporan()
        cboJenisLaporan.Items.Clear()
        cboJenisLaporan.Items.Add("Penjualan")              '0
        cboJenisLaporan.Items.Add("Penjualan per Product")  '1
        cboJenisLaporan.Items.Add("Penjualan per Customer") '2        
        cboJenisLaporan.SelectedIndex = 0
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Try
            btnTampilkan.Text = "Ditunggu..."

            Dim cr As New ReportClass

            Select Case cboJenisLaporan.SelectedIndex
                Case 0
                    GetDataAll("spLap_Penjualan", _dsReport.dtLap_Penjualan)

                    cr = Nothing
                    cr = New LapPenjualan
                    cr.SetDataSource(_dsReport)
                Case 1
                    GetDataAll("spLap_PenjualanProd_Customer", _dsReport.dtLap_PenjualanProd)

                    cr = Nothing
                    cr = New LapPenjualan_Produk
                    cr.SetDataSource(_dsReport)
                Case 2
                    GetDataAll("spLap_PenjualanProd_Customer", _dsReport.dtLap_PenjualanCust)

                    cr = Nothing
                    cr = New LapPenjualan_Cust
                    cr.SetDataSource(_dsReport)
            End Select

            Me.CrystalReportViewer1.ReportSource = cr
            btnTampilkan.Text = "Tampilkan"
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetDataAll(ByVal _namaSP As String, ByVal _dtReport As DataTable)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandText = _namaSP
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pFromDate", dtpFrom.Value)
        cmd.Parameters.AddWithValue("@pToDate", dtpTo.Value)

        Dim da As New SqlDataAdapter(cmd)
        _dtReport.Rows.Clear()
        da.Fill(_dtReport)

        da.Dispose()
        cmd.Dispose()
        
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class