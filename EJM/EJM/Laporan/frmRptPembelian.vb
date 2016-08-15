Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRptPembelian
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim _dsReport As New dsLaporan

    Private Sub frmRptPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddCboJenisLaporan()
    End Sub

    Private Sub AddCboJenisLaporan()
        cboJenisLaporan.Items.Clear()
        cboJenisLaporan.Items.Add("Pembelian")              '0
        cboJenisLaporan.Items.Add("Pembelian per Product")  '1
        cboJenisLaporan.Items.Add("Pembelian per Supplier") '2        
        cboJenisLaporan.SelectedIndex = 0
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Try
            btnTampilkan.Text = "Ditunggu..."

            Dim cr As New ReportClass

            Select Case cboJenisLaporan.SelectedIndex
                Case 0
                    GetDataAll("spLap_Pembelian", _dsReport.dtLap_Pembelian)

                    cr = Nothing
                    cr = New LapPembelian
                    cr.SetDataSource(_dsReport)
                Case 1
                    GetDataAll("spLap_PembelianProd_Supp", _dsReport.dtLap_PembelianProd)

                    cr = Nothing
                    cr = New LapPembelian_Produk
                    cr.SetDataSource(_dsReport)
                Case 2
                    GetDataAll("spLap_PembelianProd_Supp", _dsReport.dtLap_PembelianSupp)

                    cr = Nothing
                    cr = New LapPembelian_Supp
                    cr.SetDataSource(_dsReport)
            End Select

            Me.CrystalReportViewer1.ReportSource = cr
            btnTampilkan.Text = "Tampilkan"
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetDataAll(ByVal _namaSP As String, ByVal _dtReport As DataTable)
        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandText = _namaSP
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@pFromDate", dtpFrom.Value)
                .Parameters.AddWithValue("@pToDate", dtpTo.Value)
            End With
            Using da As New SqlDataAdapter(cmd)
                _dtReport.Rows.Clear()
                da.Fill(_dtReport)
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class