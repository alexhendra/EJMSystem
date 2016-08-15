Imports System.Windows.Forms.RibbonForm

Public Class frmMain
    Inherits RibbonForm

    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub obExit_Click(sender As Object, e As EventArgs) Handles obExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        If frmLogin IsNot Nothing Then
            frmLogin.Dispose()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _isHasBeenLogin Then tlStrpLblUserName.Text = _userNameGlobal.Trim
        GetLastClosing()
    End Sub

    ' Sub rutin yang digunakan untuk menampilkan tgl terakhir closing
    ' Ditampilkan di Title Main Form
    Friend Sub GetLastClosing()
        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select top 1 Convert(varchar(9),TglStok,6) as TglStok from tLog_Closing where isClosing=1 order by TglStok desc"
        cmd.Parameters.Clear()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        da.Dispose()
        cmd.Dispose()

        If dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0)("TglStok")) Then
                tlStrpLblLastClosing.Text = "Last Closing (" & dt.Rows(0)("TglStok").ToString & ")"
            End If
        Else
            tlStrpLblLastClosing.Text = ""
        End If

    End Sub

    Private Sub rbCustomer_Click(sender As Object, e As EventArgs) Handles rbCustomer.Click
        frmCustomer.MdiParent = Me
        frmCustomer.WindowState = FormWindowState.Maximized
        frmCustomer.Show()
    End Sub

    Private Sub rbSupplier_Click(sender As Object, e As EventArgs) Handles rbSupplier.Click
        frmSupplier.MdiParent = Me
        frmSupplier.WindowState = FormWindowState.Maximized
        frmSupplier.Show()
    End Sub

    Private Sub rbBarang_Click(sender As Object, e As EventArgs) Handles rbBarang.Click
        frmBarang.MdiParent = Me
        frmBarang.WindowState = FormWindowState.Maximized
        frmBarang.Show()
    End Sub

    Private Sub rbPesanan_Click(sender As Object, e As EventArgs) Handles rbPesanan.Click
        frmPesananPembelian.MdiParent = Me
        frmPesananPembelian.WindowState = FormWindowState.Maximized
        frmPesananPembelian.Show()
    End Sub

    Private Sub miKelolaUser_Click(sender As Object, e As EventArgs) Handles miKelolaUser.Click
        frmUserMaintain.MdiParent = Me
        frmUserMaintain.WindowState = FormWindowState.Maximized
        frmUserMaintain.Show()
    End Sub

    Private Sub miChangePass_Click(sender As Object, e As EventArgs) Handles miChangePass.Click
        frmChangePass.ShowDialog()
    End Sub

    Private Sub obLogOut_Click(sender As Object, e As EventArgs) Handles obLogOut.Click
        _userNameGlobal = String.Empty
        _userIdGlobal = String.Empty
        _isHasBeenLogin = False
        Me.Dispose()
        frmLogin.Show()
    End Sub

    Private Sub rbTransBeli_Click(sender As Object, e As EventArgs) Handles rbTransBeli.Click
        frmPembelian.MdiParent = Me
        frmPembelian.WindowState = FormWindowState.Maximized
        frmPembelian.Show()
    End Sub

    Private Sub rbPenerimaan_Click(sender As Object, e As EventArgs) Handles rbPenerimaan.Click
        frmPenerimaan.MdiParent = Me
        frmPenerimaan.WindowState = FormWindowState.Maximized
        frmPenerimaan.Show()
    End Sub

    Private Sub rbRetur_Click(sender As Object, e As EventArgs) Handles rbRetur.Click
        frmReturPembelian.MdiParent = Me
        frmReturPembelian.WindowState = FormWindowState.Maximized
        frmReturPembelian.Show()
    End Sub

    Private Sub rbReportBarang_Click(sender As Object, e As EventArgs) Handles rbReportBarang.Click
        frmRptBarang.MdiParent = Me
        frmRptBarang.WindowState = FormWindowState.Maximized
        frmRptBarang.Show()
    End Sub

    Private Sub rbReportCustomer_Click(sender As Object, e As EventArgs) Handles rbReportCustomer.Click
        frmRptCustomer.MdiParent = Me
        frmRptCustomer.WindowState = FormWindowState.Maximized
        frmRptCustomer.Show()
    End Sub

    Private Sub rbReportSupplier_Click(sender As Object, e As EventArgs) Handles rbReportSupplier.Click
        frmRptSupplier.MdiParent = Me
        frmRptSupplier.WindowState = FormWindowState.Maximized
        frmRptSupplier.Show()
    End Sub

    Private Sub rbRptPembelian_Click(sender As Object, e As EventArgs) Handles rbRptPembelian.Click
        frmRptPembelian.MdiParent = Me
        frmRptPembelian.WindowState = FormWindowState.Maximized
        frmRptPembelian.Show()
    End Sub

    Private Sub rbRptReturBeli_Click(sender As Object, e As EventArgs) Handles rbRptReturBeli.Click
        frmRptRetur.MdiParent = Me
        frmRptRetur.WindowState = FormWindowState.Maximized
        frmRptRetur.Show()
    End Sub

    Private Sub rbTransJual_Click(sender As Object, e As EventArgs) Handles rbTransJual.Click
        frmPenjualan.MdiParent = Me
        frmPenjualan.WindowState = FormWindowState.Maximized
        frmPenjualan.Show()
    End Sub

    Private Sub rbHutang_Click(sender As Object, e As EventArgs) Handles rbHutang.Click
        frmPelunasanHutang.MdiParent = Me
        frmPelunasanHutang.WindowState = FormWindowState.Maximized
        frmPelunasanHutang.Show()
    End Sub

    Private Sub rbClosing_Click(sender As Object, e As EventArgs) Handles rbClosing.Click
        frmClosing.MdiParent = Me
        frmClosing.WindowState = FormWindowState.Maximized
        frmClosing.Show()
    End Sub

    Private Sub rbRptPenjualan_Click(sender As Object, e As EventArgs) Handles rbRptPenjualan.Click
        frmRptPenjualan.MdiParent = Me
        frmRptPenjualan.WindowState = FormWindowState.Maximized
        frmRptPenjualan.Show()
    End Sub

    Private Sub rbInisialisasi_Click(sender As Object, e As EventArgs) Handles rbInisialisasi.Click
        frmInisialisasiStokAwal.MdiParent = Me
        frmInisialisasiStokAwal.WindowState = FormWindowState.Maximized
        frmInisialisasiStokAwal.Show()
    End Sub

    Private Sub rbStokSekarang_Click(sender As Object, e As EventArgs) Handles rbStokSekarang.Click
        frmStokSekarang.MdiParent = Me
        frmStokSekarang.WindowState = FormWindowState.Maximized
        frmStokSekarang.Show()
    End Sub

    Private Sub rbPenyesuaianStok_Click(sender As Object, e As EventArgs) Handles rbPenyesuaianStok.Click
        frmPenyesuaianStok.MdiParent = Me
        frmPenyesuaianStok.WindowState = FormWindowState.Maximized
        frmPenyesuaianStok.Show()
    End Sub
End Class