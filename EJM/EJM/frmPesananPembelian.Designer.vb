<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesananPembelian
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesananPembelian))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNoPesan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.btnCancelItem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFindBarang = New System.Windows.Forms.Button()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.pnlBtnDetail = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtJumlahPesan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvPesanan = New System.Windows.Forms.DataGridView()
        Me.cKodePesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtPesananPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFindSupplier = New System.Windows.Forms.Button()
        Me.lblNamaSupplier = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTglPesan = New System.Windows.Forms.DateTimePicker()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlBtnHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.DaPesananPembelian = New EJM.dsTransTableAdapters.daPesananPembelian()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlBtnDetail.SuspendLayout()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtPesananPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNoPesan
        '
        Me.txtNoPesan.Location = New System.Drawing.Point(104, 70)
        Me.txtNoPesan.MaxLength = 14
        Me.txtNoPesan.Name = "txtNoPesan"
        Me.txtNoPesan.Size = New System.Drawing.Size(203, 20)
        Me.txtNoPesan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(14, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "No. Pesanan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 62)
        Me.Panel1.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(837, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Input transaksi pesanan pembelian"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(872, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Pesanan Pembelian"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.btnSaveItem)
        Me.GroupBox1.Controls.Add(Me.btnCancelItem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnFindBarang)
        Me.GroupBox1.Controls.Add(Me.lblUOM)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.lblNamaBarang)
        Me.GroupBox1.Controls.Add(Me.pnlBtnDetail)
        Me.GroupBox1.Controls.Add(Me.txtJumlahPesan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(906, 129)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'txtHarga
        '
        Me.txtHarga.Enabled = False
        Me.txtHarga.Location = New System.Drawing.Point(565, 48)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(113, 20)
        Me.txtHarga.TabIndex = 5
        Me.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Image = CType(resources.GetObject("btnSaveItem.Image"), System.Drawing.Image)
        Me.btnSaveItem.Location = New System.Drawing.Point(424, 83)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(73, 31)
        Me.btnSaveItem.TabIndex = 6
        Me.btnSaveItem.Text = "Simpan"
        Me.btnSaveItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveItem.UseVisualStyleBackColor = True
        Me.btnSaveItem.Visible = False
        '
        'btnCancelItem
        '
        Me.btnCancelItem.Image = CType(resources.GetObject("btnCancelItem.Image"), System.Drawing.Image)
        Me.btnCancelItem.Location = New System.Drawing.Point(676, 84)
        Me.btnCancelItem.Name = "btnCancelItem"
        Me.btnCancelItem.Size = New System.Drawing.Size(75, 29)
        Me.btnCancelItem.TabIndex = 9
        Me.btnCancelItem.Text = "Batal"
        Me.btnCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelItem.UseVisualStyleBackColor = True
        Me.btnCancelItem.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightCyan
        Me.Label4.Location = New System.Drawing.Point(516, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Harga"
        '
        'btnFindBarang
        '
        Me.btnFindBarang.Enabled = False
        Me.btnFindBarang.Image = CType(resources.GetObject("btnFindBarang.Image"), System.Drawing.Image)
        Me.btnFindBarang.Location = New System.Drawing.Point(270, 14)
        Me.btnFindBarang.Name = "btnFindBarang"
        Me.btnFindBarang.Size = New System.Drawing.Size(43, 23)
        Me.btnFindBarang.TabIndex = 3
        Me.btnFindBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindBarang.UseVisualStyleBackColor = True
        '
        'lblUOM
        '
        Me.lblUOM.BackColor = System.Drawing.SystemColors.Control
        Me.lblUOM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUOM.Location = New System.Drawing.Point(416, 48)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(66, 23)
        Me.lblUOM.TabIndex = 81
        Me.lblUOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(503, 83)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 29)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaBarang.Location = New System.Drawing.Point(416, 12)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(351, 23)
        Me.lblNamaBarang.TabIndex = 80
        Me.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBtnDetail
        '
        Me.pnlBtnDetail.Controls.Add(Me.btnAdd)
        Me.pnlBtnDetail.Enabled = False
        Me.pnlBtnDetail.Location = New System.Drawing.Point(12, 81)
        Me.pnlBtnDetail.Name = "pnlBtnDetail"
        Me.pnlBtnDetail.Size = New System.Drawing.Size(397, 38)
        Me.pnlBtnDetail.TabIndex = 70
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 28)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtJumlahPesan
        '
        Me.txtJumlahPesan.Enabled = False
        Me.txtJumlahPesan.Location = New System.Drawing.Point(98, 48)
        Me.txtJumlahPesan.Name = "txtJumlahPesan"
        Me.txtJumlahPesan.Size = New System.Drawing.Size(169, 20)
        Me.txtJumlahPesan.TabIndex = 4
        Me.txtJumlahPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightCyan
        Me.Label10.Location = New System.Drawing.Point(7, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Jumlah Pesanan"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(584, 84)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 28)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightCyan
        Me.Label9.Location = New System.Drawing.Point(325, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "UOM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(325, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Nama Barang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Enabled = False
        Me.txtKodeBarang.Location = New System.Drawing.Point(98, 15)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(169, 20)
        Me.txtKodeBarang.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightCyan
        Me.Label8.Location = New System.Drawing.Point(7, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Kode Barang"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(571, 461)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 39)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(495, 461)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(652, 462)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'dgvPesanan
        '
        Me.dgvPesanan.AllowUserToAddRows = False
        Me.dgvPesanan.AllowUserToDeleteRows = False
        Me.dgvPesanan.AutoGenerateColumns = False
        Me.dgvPesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPesanan.BackgroundColor = System.Drawing.Color.White
        Me.dgvPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodePesanan, Me.cKodeBarang, Me.cNamaBarang, Me.cUOMName, Me.cJumlah, Me.cHarga, Me.cTotal, Me.cKodeSupplier, Me.cPMode})
        Me.dgvPesanan.DataSource = Me.DtPesananPembelianBindingSource
        Me.dgvPesanan.GridColor = System.Drawing.Color.LightGray
        Me.dgvPesanan.Location = New System.Drawing.Point(6, 309)
        Me.dgvPesanan.MultiSelect = False
        Me.dgvPesanan.Name = "dgvPesanan"
        Me.dgvPesanan.ReadOnly = True
        Me.dgvPesanan.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPesanan.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPesanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPesanan.Size = New System.Drawing.Size(934, 146)
        Me.dgvPesanan.TabIndex = 67
        '
        'cKodePesanan
        '
        Me.cKodePesanan.DataPropertyName = "No_Pesanan"
        Me.cKodePesanan.HeaderText = "No. Pesanan"
        Me.cKodePesanan.Name = "cKodePesanan"
        Me.cKodePesanan.ReadOnly = True
        '
        'cKodeBarang
        '
        Me.cKodeBarang.DataPropertyName = "Kode_Barang"
        Me.cKodeBarang.HeaderText = "Kode Barang"
        Me.cKodeBarang.Name = "cKodeBarang"
        Me.cKodeBarang.ReadOnly = True
        '
        'cNamaBarang
        '
        Me.cNamaBarang.DataPropertyName = "Nama_Barang"
        Me.cNamaBarang.HeaderText = "Nama Barang"
        Me.cNamaBarang.Name = "cNamaBarang"
        Me.cNamaBarang.ReadOnly = True
        '
        'cUOMName
        '
        Me.cUOMName.DataPropertyName = "UomName"
        Me.cUOMName.HeaderText = "UOM"
        Me.cUOMName.Name = "cUOMName"
        Me.cUOMName.ReadOnly = True
        '
        'cJumlah
        '
        Me.cJumlah.DataPropertyName = "Jumlah"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cJumlah.DefaultCellStyle = DataGridViewCellStyle1
        Me.cJumlah.HeaderText = "Jumlah"
        Me.cJumlah.Name = "cJumlah"
        Me.cJumlah.ReadOnly = True
        '
        'cHarga
        '
        Me.cHarga.DataPropertyName = "Harga"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "##0"
        Me.cHarga.DefaultCellStyle = DataGridViewCellStyle2
        Me.cHarga.HeaderText = "Harga"
        Me.cHarga.Name = "cHarga"
        Me.cHarga.ReadOnly = True
        '
        'cTotal
        '
        Me.cTotal.DataPropertyName = "Total"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "##0"
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        '
        'cKodeSupplier
        '
        Me.cKodeSupplier.DataPropertyName = "Kode_Supplier"
        Me.cKodeSupplier.HeaderText = "Kode_Supplier"
        Me.cKodeSupplier.Name = "cKodeSupplier"
        Me.cKodeSupplier.ReadOnly = True
        Me.cKodeSupplier.Visible = False
        '
        'cPMode
        '
        Me.cPMode.DataPropertyName = "pMode"
        Me.cPMode.HeaderText = "pMode"
        Me.cPMode.Name = "cPMode"
        Me.cPMode.ReadOnly = True
        Me.cPMode.Visible = False
        '
        'DtPesananPembelianBindingSource
        '
        Me.DtPesananPembelianBindingSource.DataMember = "dtPesananPembelian"
        Me.DtPesananPembelianBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFindSupplier)
        Me.GroupBox2.Controls.Add(Me.lblNamaSupplier)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtKodeSupplier)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpTglPesan)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(906, 78)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        '
        'btnFindSupplier
        '
        Me.btnFindSupplier.Enabled = False
        Me.btnFindSupplier.Image = CType(resources.GetObject("btnFindSupplier.Image"), System.Drawing.Image)
        Me.btnFindSupplier.Location = New System.Drawing.Point(271, 15)
        Me.btnFindSupplier.Name = "btnFindSupplier"
        Me.btnFindSupplier.Size = New System.Drawing.Size(43, 23)
        Me.btnFindSupplier.TabIndex = 3
        Me.btnFindSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindSupplier.UseVisualStyleBackColor = True
        '
        'lblNamaSupplier
        '
        Me.lblNamaSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaSupplier.Location = New System.Drawing.Point(416, 13)
        Me.lblNamaSupplier.Name = "lblNamaSupplier"
        Me.lblNamaSupplier.Size = New System.Drawing.Size(233, 23)
        Me.lblNamaSupplier.TabIndex = 88
        Me.lblNamaSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightCyan
        Me.Label11.Location = New System.Drawing.Point(325, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Nama Supplier"
        '
        'txtKodeSupplier
        '
        Me.txtKodeSupplier.Enabled = False
        Me.txtKodeSupplier.Location = New System.Drawing.Point(98, 15)
        Me.txtKodeSupplier.Name = "txtKodeSupplier"
        Me.txtKodeSupplier.Size = New System.Drawing.Size(169, 20)
        Me.txtKodeSupplier.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(7, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Kode Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(5, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Tgl. Pesanan"
        '
        'dtpTglPesan
        '
        Me.dtpTglPesan.CustomFormat = "MM/dd/yyyy"
        Me.dtpTglPesan.Enabled = False
        Me.dtpTglPesan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglPesan.Location = New System.Drawing.Point(98, 47)
        Me.dtpTglPesan.Name = "dtpTglPesan"
        Me.dtpTglPesan.Size = New System.Drawing.Size(112, 20)
        Me.dtpTglPesan.TabIndex = 4
        Me.dtpTglPesan.Value = New Date(2016, 6, 17, 0, 0, 0, 0)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(416, 461)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 39)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "Baru"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'pnlBtnHeader
        '
        Me.pnlBtnHeader.Location = New System.Drawing.Point(6, 462)
        Me.pnlBtnHeader.Name = "pnlBtnHeader"
        Me.pnlBtnHeader.Size = New System.Drawing.Size(397, 53)
        Me.pnlBtnHeader.TabIndex = 87
        '
        'DaPesananPembelian
        '
        Me.DaPesananPembelian.ClearBeforeFill = True
        '
        'frmPesananPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1017, 527)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.pnlBtnHeader)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvPesanan)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNoPesan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPesananPembelian"
        Me.Text = "Pesanan Pembelian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlBtnDetail.ResumeLayout(False)
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtPesananPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoPesan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents lblNamaBarang As System.Windows.Forms.Label
    Friend WithEvents txtJumlahPesan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnFindBarang As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgvPesanan As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DtPesananPembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaPesananPembelian As EJM.dsTransTableAdapters.daPesananPembelian
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancelItem As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents pnlBtnDetail As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFindSupplier As System.Windows.Forms.Button
    Friend WithEvents lblNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTglPesan As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnlBtnHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents cKodePesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPMode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
