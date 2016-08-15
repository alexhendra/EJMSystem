<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.miKelolaUser = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.miChangePass = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.obExit = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.obLogOut = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.rbCustomer = New System.Windows.Forms.RibbonButton()
        Me.rbSupplier = New System.Windows.Forms.RibbonButton()
        Me.rbBarang = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.rbPesanan = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton()
        Me.rbTransBeli = New System.Windows.Forms.RibbonButton()
        Me.rbRetur = New System.Windows.Forms.RibbonButton()
        Me.rbHutang = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel9 = New System.Windows.Forms.RibbonPanel()
        Me.rbPenerimaan = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.rbTransJual = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel7 = New System.Windows.Forms.RibbonPanel()
        Me.rbClosing = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel8 = New System.Windows.Forms.RibbonPanel()
        Me.rbInisialisasi = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel11 = New System.Windows.Forms.RibbonPanel()
        Me.rbPenyesuaianStok = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab5 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel()
        Me.rbReportBarang = New System.Windows.Forms.RibbonButton()
        Me.rbReportCustomer = New System.Windows.Forms.RibbonButton()
        Me.rbReportSupplier = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel6 = New System.Windows.Forms.RibbonPanel()
        Me.rbRptPembelian = New System.Windows.Forms.RibbonButton()
        Me.rbRptReturBeli = New System.Windows.Forms.RibbonButton()
        Me.rbRptPenjualan = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel10 = New System.Windows.Forms.RibbonPanel()
        Me.rbStokSekarang = New System.Windows.Forms.RibbonButton()
        Me.RibbonOrbMenuItem1 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem2 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.strpMain = New System.Windows.Forms.StatusStrip()
        Me.tlStrpLblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlStrpLblLastClosing = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlStrpLblUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.miPassword = New System.Windows.Forms.RibbonDescriptionMenuItem()
        Me.RibbonOrbMenuItem4 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.miUser = New System.Windows.Forms.RibbonDescriptionMenuItem()
        Me.RibbonButton4 = New System.Windows.Forms.RibbonButton()
        Me.strpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.miKelolaUser)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.miChangePass)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.OptionItems.Add(Me.obExit)
        Me.Ribbon1.OrbDropDown.OptionItems.Add(Me.obLogOut)
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 160)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Nothing
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010
        Me.Ribbon1.OrbText = "Konfig"
        '
        '
        '
        Me.Ribbon1.QuickAcessToolbar.Visible = False
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(726, 138)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab5)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "File"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'miKelolaUser
        '
        Me.miKelolaUser.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.miKelolaUser.Image = CType(resources.GetObject("miKelolaUser.Image"), System.Drawing.Image)
        Me.miKelolaUser.SmallImage = CType(resources.GetObject("miKelolaUser.SmallImage"), System.Drawing.Image)
        Me.miKelolaUser.Text = "Manage User"
        '
        'miChangePass
        '
        Me.miChangePass.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.miChangePass.Image = CType(resources.GetObject("miChangePass.Image"), System.Drawing.Image)
        Me.miChangePass.SmallImage = CType(resources.GetObject("miChangePass.SmallImage"), System.Drawing.Image)
        Me.miChangePass.Text = "Change Password"
        '
        'obExit
        '
        Me.obExit.Image = CType(resources.GetObject("obExit.Image"), System.Drawing.Image)
        Me.obExit.SmallImage = CType(resources.GetObject("obExit.SmallImage"), System.Drawing.Image)
        Me.obExit.Text = "Keluar"
        '
        'obLogOut
        '
        Me.obLogOut.Image = CType(resources.GetObject("obLogOut.Image"), System.Drawing.Image)
        Me.obLogOut.SmallImage = CType(resources.GetObject("obLogOut.SmallImage"), System.Drawing.Image)
        Me.obLogOut.Text = "Log Out"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Text = "Base Data"
        Me.RibbonTab1.ToolTip = ""
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ButtonMoreVisible = False
        Me.RibbonPanel1.Items.Add(Me.rbCustomer)
        Me.RibbonPanel1.Items.Add(Me.rbSupplier)
        Me.RibbonPanel1.Items.Add(Me.rbBarang)
        Me.RibbonPanel1.Text = "Base Data"
        '
        'rbCustomer
        '
        Me.rbCustomer.Image = CType(resources.GetObject("rbCustomer.Image"), System.Drawing.Image)
        Me.rbCustomer.SmallImage = CType(resources.GetObject("rbCustomer.SmallImage"), System.Drawing.Image)
        Me.rbCustomer.Text = "Customer"
        '
        'rbSupplier
        '
        Me.rbSupplier.Image = CType(resources.GetObject("rbSupplier.Image"), System.Drawing.Image)
        Me.rbSupplier.SmallImage = CType(resources.GetObject("rbSupplier.SmallImage"), System.Drawing.Image)
        Me.rbSupplier.Text = "Supplier"
        '
        'rbBarang
        '
        Me.rbBarang.Image = CType(resources.GetObject("rbBarang.Image"), System.Drawing.Image)
        Me.rbBarang.SmallImage = CType(resources.GetObject("rbBarang.SmallImage"), System.Drawing.Image)
        Me.rbBarang.Text = "Barang"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel9)
        Me.RibbonTab2.Text = "Pembelian"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ButtonMoreVisible = False
        Me.RibbonPanel2.Items.Add(Me.rbPesanan)
        Me.RibbonPanel2.Items.Add(Me.rbTransBeli)
        Me.RibbonPanel2.Items.Add(Me.rbRetur)
        Me.RibbonPanel2.Items.Add(Me.rbHutang)
        Me.RibbonPanel2.Text = ""
        '
        'rbPesanan
        '
        Me.rbPesanan.DropDownItems.Add(Me.RibbonButton1)
        Me.rbPesanan.DropDownItems.Add(Me.RibbonButton2)
        Me.rbPesanan.DropDownItems.Add(Me.RibbonButton3)
        Me.rbPesanan.Image = CType(resources.GetObject("rbPesanan.Image"), System.Drawing.Image)
        Me.rbPesanan.SmallImage = CType(resources.GetObject("rbPesanan.SmallImage"), System.Drawing.Image)
        Me.rbPesanan.Text = "Pesanan"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'RibbonButton2
        '
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = "RibbonButton2"
        '
        'RibbonButton3
        '
        Me.RibbonButton3.Image = CType(resources.GetObject("RibbonButton3.Image"), System.Drawing.Image)
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "RibbonButton3"
        '
        'rbTransBeli
        '
        Me.rbTransBeli.Image = CType(resources.GetObject("rbTransBeli.Image"), System.Drawing.Image)
        Me.rbTransBeli.SmallImage = CType(resources.GetObject("rbTransBeli.SmallImage"), System.Drawing.Image)
        Me.rbTransBeli.Text = "Pembelian"
        '
        'rbRetur
        '
        Me.rbRetur.Image = CType(resources.GetObject("rbRetur.Image"), System.Drawing.Image)
        Me.rbRetur.SmallImage = CType(resources.GetObject("rbRetur.SmallImage"), System.Drawing.Image)
        Me.rbRetur.Text = "Retur"
        '
        'rbHutang
        '
        Me.rbHutang.Image = CType(resources.GetObject("rbHutang.Image"), System.Drawing.Image)
        Me.rbHutang.SmallImage = CType(resources.GetObject("rbHutang.SmallImage"), System.Drawing.Image)
        Me.rbHutang.Text = "Hutang"
        '
        'RibbonPanel9
        '
        Me.RibbonPanel9.ButtonMoreEnabled = False
        Me.RibbonPanel9.ButtonMoreVisible = False
        Me.RibbonPanel9.Items.Add(Me.rbPenerimaan)
        Me.RibbonPanel9.Text = ""
        '
        'rbPenerimaan
        '
        Me.rbPenerimaan.Image = CType(resources.GetObject("rbPenerimaan.Image"), System.Drawing.Image)
        Me.rbPenerimaan.SmallImage = CType(resources.GetObject("rbPenerimaan.SmallImage"), System.Drawing.Image)
        Me.rbPenerimaan.Text = "Penerimaan"
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel7)
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel8)
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel11)
        Me.RibbonTab3.Text = "Penjualan"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ButtonMoreVisible = False
        Me.RibbonPanel3.Items.Add(Me.rbTransJual)
        Me.RibbonPanel3.Text = ""
        '
        'rbTransJual
        '
        Me.rbTransJual.Image = CType(resources.GetObject("rbTransJual.Image"), System.Drawing.Image)
        Me.rbTransJual.SmallImage = CType(resources.GetObject("rbTransJual.SmallImage"), System.Drawing.Image)
        Me.rbTransJual.Text = "Penjualan"
        '
        'RibbonPanel7
        '
        Me.RibbonPanel7.ButtonMoreEnabled = False
        Me.RibbonPanel7.ButtonMoreVisible = False
        Me.RibbonPanel7.Items.Add(Me.rbClosing)
        Me.RibbonPanel7.Text = ""
        '
        'rbClosing
        '
        Me.rbClosing.Image = CType(resources.GetObject("rbClosing.Image"), System.Drawing.Image)
        Me.rbClosing.MinimumSize = New System.Drawing.Size(120, 0)
        Me.rbClosing.SmallImage = CType(resources.GetObject("rbClosing.SmallImage"), System.Drawing.Image)
        Me.rbClosing.Text = "Closing / Unclosing"
        '
        'RibbonPanel8
        '
        Me.RibbonPanel8.ButtonMoreEnabled = False
        Me.RibbonPanel8.ButtonMoreVisible = False
        Me.RibbonPanel8.Items.Add(Me.rbInisialisasi)
        Me.RibbonPanel8.Text = ""
        '
        'rbInisialisasi
        '
        Me.rbInisialisasi.Image = CType(resources.GetObject("rbInisialisasi.Image"), System.Drawing.Image)
        Me.rbInisialisasi.MinimumSize = New System.Drawing.Size(100, 0)
        Me.rbInisialisasi.SmallImage = CType(resources.GetObject("rbInisialisasi.SmallImage"), System.Drawing.Image)
        Me.rbInisialisasi.Text = "Inisialisasi Stok"
        '
        'RibbonPanel11
        '
        Me.RibbonPanel11.ButtonMoreEnabled = False
        Me.RibbonPanel11.ButtonMoreVisible = False
        Me.RibbonPanel11.Items.Add(Me.rbPenyesuaianStok)
        Me.RibbonPanel11.Text = ""
        '
        'rbPenyesuaianStok
        '
        Me.rbPenyesuaianStok.Image = CType(resources.GetObject("rbPenyesuaianStok.Image"), System.Drawing.Image)
        Me.rbPenyesuaianStok.MinimumSize = New System.Drawing.Size(120, 0)
        Me.rbPenyesuaianStok.SmallImage = CType(resources.GetObject("rbPenyesuaianStok.SmallImage"), System.Drawing.Image)
        Me.rbPenyesuaianStok.Text = "Penyesuaian Stok"
        Me.rbPenyesuaianStok.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibbonTab5
        '
        Me.RibbonTab5.Panels.Add(Me.RibbonPanel5)
        Me.RibbonTab5.Panels.Add(Me.RibbonPanel6)
        Me.RibbonTab5.Panels.Add(Me.RibbonPanel10)
        Me.RibbonTab5.Text = "Report"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.ButtonMoreEnabled = False
        Me.RibbonPanel5.ButtonMoreVisible = False
        Me.RibbonPanel5.Items.Add(Me.rbReportBarang)
        Me.RibbonPanel5.Items.Add(Me.rbReportCustomer)
        Me.RibbonPanel5.Items.Add(Me.rbReportSupplier)
        Me.RibbonPanel5.Text = "Master Data"
        '
        'rbReportBarang
        '
        Me.rbReportBarang.Image = CType(resources.GetObject("rbReportBarang.Image"), System.Drawing.Image)
        Me.rbReportBarang.SmallImage = CType(resources.GetObject("rbReportBarang.SmallImage"), System.Drawing.Image)
        Me.rbReportBarang.Text = "Barang"
        '
        'rbReportCustomer
        '
        Me.rbReportCustomer.Image = CType(resources.GetObject("rbReportCustomer.Image"), System.Drawing.Image)
        Me.rbReportCustomer.SmallImage = CType(resources.GetObject("rbReportCustomer.SmallImage"), System.Drawing.Image)
        Me.rbReportCustomer.Text = "Customer"
        '
        'rbReportSupplier
        '
        Me.rbReportSupplier.Image = CType(resources.GetObject("rbReportSupplier.Image"), System.Drawing.Image)
        Me.rbReportSupplier.SmallImage = CType(resources.GetObject("rbReportSupplier.SmallImage"), System.Drawing.Image)
        Me.rbReportSupplier.Text = "Supplier"
        '
        'RibbonPanel6
        '
        Me.RibbonPanel6.ButtonMoreEnabled = False
        Me.RibbonPanel6.ButtonMoreVisible = False
        Me.RibbonPanel6.Items.Add(Me.rbRptPembelian)
        Me.RibbonPanel6.Items.Add(Me.rbRptReturBeli)
        Me.RibbonPanel6.Items.Add(Me.rbRptPenjualan)
        Me.RibbonPanel6.Text = "Transaksi"
        '
        'rbRptPembelian
        '
        Me.rbRptPembelian.Image = CType(resources.GetObject("rbRptPembelian.Image"), System.Drawing.Image)
        Me.rbRptPembelian.SmallImage = CType(resources.GetObject("rbRptPembelian.SmallImage"), System.Drawing.Image)
        Me.rbRptPembelian.Text = "Pembelian"
        '
        'rbRptReturBeli
        '
        Me.rbRptReturBeli.Image = CType(resources.GetObject("rbRptReturBeli.Image"), System.Drawing.Image)
        Me.rbRptReturBeli.MinimumSize = New System.Drawing.Size(110, 0)
        Me.rbRptReturBeli.SmallImage = CType(resources.GetObject("rbRptReturBeli.SmallImage"), System.Drawing.Image)
        Me.rbRptReturBeli.Text = "Retur Pembelian"
        '
        'rbRptPenjualan
        '
        Me.rbRptPenjualan.Image = CType(resources.GetObject("rbRptPenjualan.Image"), System.Drawing.Image)
        Me.rbRptPenjualan.SmallImage = CType(resources.GetObject("rbRptPenjualan.SmallImage"), System.Drawing.Image)
        Me.rbRptPenjualan.Text = "Penjualan"
        '
        'RibbonPanel10
        '
        Me.RibbonPanel10.ButtonMoreEnabled = False
        Me.RibbonPanel10.ButtonMoreVisible = False
        Me.RibbonPanel10.Items.Add(Me.rbStokSekarang)
        Me.RibbonPanel10.Text = ""
        '
        'rbStokSekarang
        '
        Me.rbStokSekarang.Image = CType(resources.GetObject("rbStokSekarang.Image"), System.Drawing.Image)
        Me.rbStokSekarang.MinimumSize = New System.Drawing.Size(100, 0)
        Me.rbStokSekarang.SmallImage = CType(resources.GetObject("rbStokSekarang.SmallImage"), System.Drawing.Image)
        Me.rbStokSekarang.Text = "Stok Sekarang"
        '
        'RibbonOrbMenuItem1
        '
        Me.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem1.Image = CType(resources.GetObject("RibbonOrbMenuItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Text = "Data Master"
        '
        'RibbonOrbMenuItem2
        '
        Me.RibbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem2.Image = CType(resources.GetObject("RibbonOrbMenuItem2.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem2.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem2.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem2.Text = "Password"
        '
        'strpMain
        '
        Me.strpMain.AutoSize = False
        Me.strpMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlStrpLblStatus, Me.ToolStripStatusLabel1, Me.tlStrpLblLastClosing, Me.ToolStripStatusLabel3, Me.tlStrpLblUserName})
        Me.strpMain.Location = New System.Drawing.Point(0, 383)
        Me.strpMain.Name = "strpMain"
        Me.strpMain.Size = New System.Drawing.Size(726, 27)
        Me.strpMain.TabIndex = 2
        Me.strpMain.Text = "StatusStrip1"
        '
        'tlStrpLblStatus
        '
        Me.tlStrpLblStatus.Margin = New System.Windows.Forms.Padding(0, 3, 10, 2)
        Me.tlStrpLblStatus.Name = "tlStrpLblStatus"
        Me.tlStrpLblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tlStrpLblStatus.Size = New System.Drawing.Size(39, 22)
        Me.tlStrpLblStatus.Text = "Ready"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(298, 22)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'tlStrpLblLastClosing
        '
        Me.tlStrpLblLastClosing.Name = "tlStrpLblLastClosing"
        Me.tlStrpLblLastClosing.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(298, 22)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'tlStrpLblUserName
        '
        Me.tlStrpLblUserName.Image = CType(resources.GetObject("tlStrpLblUserName.Image"), System.Drawing.Image)
        Me.tlStrpLblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tlStrpLblUserName.Name = "tlStrpLblUserName"
        Me.tlStrpLblUserName.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.tlStrpLblUserName.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.tlStrpLblUserName.Size = New System.Drawing.Size(66, 22)
        Me.tlStrpLblUserName.Text = "User"
        Me.tlStrpLblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'miPassword
        '
        Me.miPassword.Description = "Ubah password"
        Me.miPassword.DescriptionBounds = New System.Drawing.Rectangle(46, 78, 293, 28)
        Me.miPassword.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.miPassword.Image = CType(resources.GetObject("miPassword.Image"), System.Drawing.Image)
        Me.miPassword.SmallImage = CType(resources.GetObject("miPassword.SmallImage"), System.Drawing.Image)
        Me.miPassword.Text = "Password"
        '
        'RibbonOrbMenuItem4
        '
        Me.RibbonOrbMenuItem4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem4.DropDownItems.Add(Me.miPassword)
        Me.RibbonOrbMenuItem4.Image = CType(resources.GetObject("RibbonOrbMenuItem4.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem4.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem4.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem4.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.RibbonOrbMenuItem4.Text = "Pengelolaan User"
        '
        'miUser
        '
        Me.miUser.Description = "Tambah atau ubah user"
        Me.miUser.DescriptionBounds = New System.Drawing.Rectangle(46, 25, 293, 28)
        Me.miUser.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.miUser.Image = CType(resources.GetObject("miUser.Image"), System.Drawing.Image)
        Me.miUser.SmallImage = CType(resources.GetObject("miUser.SmallImage"), System.Drawing.Image)
        Me.miUser.Text = "User"
        '
        'RibbonButton4
        '
        Me.RibbonButton4.Image = CType(resources.GetObject("RibbonButton4.Image"), System.Drawing.Image)
        Me.RibbonButton4.SmallImage = CType(resources.GetObject("RibbonButton4.SmallImage"), System.Drawing.Image)
        Me.RibbonButton4.Text = "Penerimaan"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 410)
        Me.Controls.Add(Me.strpMain)
        Me.Controls.Add(Me.Ribbon1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Exa Jaya Motor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.strpMain.ResumeLayout(False)
        Me.strpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents RibbonTab1 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbCustomer As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonTab2 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonTab3 As System.Windows.Forms.RibbonTab
    Friend WithEvents rbSupplier As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel2 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbPesanan As System.Windows.Forms.RibbonButton
    Friend WithEvents rbBarang As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel3 As System.Windows.Forms.RibbonPanel
    Friend WithEvents RibbonOrbMenuItem1 As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem2 As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents obExit As System.Windows.Forms.RibbonOrbOptionButton
    Friend WithEvents obLogOut As System.Windows.Forms.RibbonOrbOptionButton
    Friend WithEvents RibbonButton1 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton2 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton3 As System.Windows.Forms.RibbonButton
    Friend WithEvents rbTransBeli As System.Windows.Forms.RibbonButton
    Friend WithEvents rbRetur As System.Windows.Forms.RibbonButton
    Friend WithEvents rbHutang As System.Windows.Forms.RibbonButton
    Friend WithEvents rbTransJual As System.Windows.Forms.RibbonButton
    Friend WithEvents strpMain As System.Windows.Forms.StatusStrip
    Friend WithEvents tlStrpLblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlStrpLblUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents miPassword As System.Windows.Forms.RibbonDescriptionMenuItem
    Friend WithEvents RibbonOrbMenuItem4 As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents miUser As System.Windows.Forms.RibbonDescriptionMenuItem
    Friend WithEvents miKelolaUser As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents miChangePass As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents RibbonTab5 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel5 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbReportBarang As System.Windows.Forms.RibbonButton
    Friend WithEvents rbReportCustomer As System.Windows.Forms.RibbonButton
    Friend WithEvents rbReportSupplier As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel6 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbRptPembelian As System.Windows.Forms.RibbonButton
    Friend WithEvents rbRptReturBeli As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel7 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbClosing As System.Windows.Forms.RibbonButton
    Friend WithEvents rbRptPenjualan As System.Windows.Forms.RibbonButton
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlStrpLblLastClosing As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RibbonPanel8 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbInisialisasi As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton4 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel9 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbPenerimaan As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel10 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbStokSekarang As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel11 As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbPenyesuaianStok As System.Windows.Forms.RibbonButton
End Class
