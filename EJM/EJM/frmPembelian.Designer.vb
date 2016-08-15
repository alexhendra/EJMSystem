<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPembelian))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNoPesanan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTglPesanan = New System.Windows.Forms.Label()
        Me.btnFindPesanan = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalTagihanPesanan = New System.Windows.Forms.Label()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.btnCancelItem = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pnlBtnDetail = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblNamaSupplier = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTglBeli = New System.Windows.Forms.DateTimePicker()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlBtnHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtKodePembelian = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rdbTunai = New System.Windows.Forms.RadioButton()
        Me.rdbKredit = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpTglJatuhTempo = New System.Windows.Forms.DateTimePicker()
        Me.txtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.btnFindSupplier = New System.Windows.Forms.Button()
        Me.DsTrans = New EJM.dsTrans()
        Me.DtItemPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaItemPembelian = New EJM.dsTransTableAdapters.daItemPembelian()
        Me.cNoPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTglPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalUangPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBtnDetail.SuspendLayout()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtItemPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoPesanan
        '
        Me.txtNoPesanan.Enabled = False
        Me.txtNoPesanan.Location = New System.Drawing.Point(143, 25)
        Me.txtNoPesanan.MaxLength = 14
        Me.txtNoPesanan.Name = "txtNoPesanan"
        Me.txtNoPesanan.Size = New System.Drawing.Size(169, 20)
        Me.txtNoPesanan.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "No. Pesanan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblWarning)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1266, 62)
        Me.Panel1.TabIndex = 62
        '
        'lblWarning
        '
        Me.lblWarning.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarning.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(558, 16)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(554, 30)
        Me.lblWarning.TabIndex = 89
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(11, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Transaksi Pembelian"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTglPesanan)
        Me.GroupBox1.Controls.Add(Me.btnFindPesanan)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblTotalTagihanPesanan)
        Me.GroupBox1.Controls.Add(Me.btnSaveItem)
        Me.GroupBox1.Controls.Add(Me.btnCancelItem)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.txtNoPesanan)
        Me.GroupBox1.Controls.Add(Me.pnlBtnDetail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1248, 230)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Item Pembelian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightCyan
        Me.Label5.Location = New System.Drawing.Point(9, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Tgl. Pesanan"
        '
        'lblTglPesanan
        '
        Me.lblTglPesanan.BackColor = System.Drawing.SystemColors.Control
        Me.lblTglPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTglPesanan.Location = New System.Drawing.Point(143, 54)
        Me.lblTglPesanan.Name = "lblTglPesanan"
        Me.lblTglPesanan.Size = New System.Drawing.Size(127, 23)
        Me.lblTglPesanan.TabIndex = 99
        Me.lblTglPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFindPesanan
        '
        Me.btnFindPesanan.Enabled = False
        Me.btnFindPesanan.Image = CType(resources.GetObject("btnFindPesanan.Image"), System.Drawing.Image)
        Me.btnFindPesanan.Location = New System.Drawing.Point(318, 23)
        Me.btnFindPesanan.Name = "btnFindPesanan"
        Me.btnFindPesanan.Size = New System.Drawing.Size(43, 23)
        Me.btnFindPesanan.TabIndex = 98
        Me.btnFindPesanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindPesanan.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.LightCyan
        Me.Label12.Location = New System.Drawing.Point(9, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Total Tagihan Pesanan"
        '
        'lblTotalTagihanPesanan
        '
        Me.lblTotalTagihanPesanan.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalTagihanPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTagihanPesanan.Location = New System.Drawing.Point(143, 85)
        Me.lblTotalTagihanPesanan.Name = "lblTotalTagihanPesanan"
        Me.lblTotalTagihanPesanan.Size = New System.Drawing.Size(149, 23)
        Me.lblTotalTagihanPesanan.TabIndex = 89
        Me.lblTotalTagihanPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Image = CType(resources.GetObject("btnSaveItem.Image"), System.Drawing.Image)
        Me.btnSaveItem.Location = New System.Drawing.Point(12, 186)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(73, 28)
        Me.btnSaveItem.TabIndex = 7
        Me.btnSaveItem.Text = "Simpan"
        Me.btnSaveItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveItem.UseVisualStyleBackColor = True
        Me.btnSaveItem.Visible = False
        '
        'btnCancelItem
        '
        Me.btnCancelItem.Image = CType(resources.GetObject("btnCancelItem.Image"), System.Drawing.Image)
        Me.btnCancelItem.Location = New System.Drawing.Point(266, 186)
        Me.btnCancelItem.Name = "btnCancelItem"
        Me.btnCancelItem.Size = New System.Drawing.Size(75, 29)
        Me.btnCancelItem.TabIndex = 10
        Me.btnCancelItem.Text = "Batal"
        Me.btnCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelItem.UseVisualStyleBackColor = True
        Me.btnCancelItem.Visible = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNoPesanan, Me.cTglPesanan, Me.cKodeSupplier, Me.cNamaSupplier, Me.cTotalUangPesanan, Me.cPMode})
        Me.dgv.DataSource = Me.DtItemPembelianBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(377, 27)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(865, 195)
        Me.dgv.TabIndex = 67
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(185, 186)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 29)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'pnlBtnDetail
        '
        Me.pnlBtnDetail.Controls.Add(Me.btnAdd)
        Me.pnlBtnDetail.Enabled = False
        Me.pnlBtnDetail.Location = New System.Drawing.Point(2, 136)
        Me.pnlBtnDetail.Name = "pnlBtnDetail"
        Me.pnlBtnDetail.Size = New System.Drawing.Size(368, 38)
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
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(93, 186)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 28)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'lblNamaSupplier
        '
        Me.lblNamaSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaSupplier.Location = New System.Drawing.Point(468, 160)
        Me.lblNamaSupplier.Name = "lblNamaSupplier"
        Me.lblNamaSupplier.Size = New System.Drawing.Size(252, 23)
        Me.lblNamaSupplier.TabIndex = 88
        Me.lblNamaSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(11, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Kode Supplier"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightCyan
        Me.Label11.Location = New System.Drawing.Point(362, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Nama Supplier"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(499, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 39)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(423, 439)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 39)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(580, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(11, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Tgl. Beli"
        '
        'dtpTglBeli
        '
        Me.dtpTglBeli.CustomFormat = ""
        Me.dtpTglBeli.Enabled = False
        Me.dtpTglBeli.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglBeli.Location = New System.Drawing.Point(121, 101)
        Me.dtpTglBeli.Name = "dtpTglBeli"
        Me.dtpTglBeli.Size = New System.Drawing.Size(112, 20)
        Me.dtpTglBeli.TabIndex = 2
        Me.dtpTglBeli.Value = New Date(2016, 7, 22, 0, 0, 0, 0)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(344, 439)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 39)
        Me.btnNew.TabIndex = 86
        Me.btnNew.Text = "Baru"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'pnlBtnHeader
        '
        Me.pnlBtnHeader.Location = New System.Drawing.Point(8, 436)
        Me.pnlBtnHeader.Name = "pnlBtnHeader"
        Me.pnlBtnHeader.Size = New System.Drawing.Size(330, 53)
        Me.pnlBtnHeader.TabIndex = 87
        '
        'txtKodePembelian
        '
        Me.txtKodePembelian.Location = New System.Drawing.Point(120, 70)
        Me.txtKodePembelian.MaxLength = 14
        Me.txtKodePembelian.Name = "txtKodePembelian"
        Me.txtKodePembelian.Size = New System.Drawing.Size(176, 20)
        Me.txtKodePembelian.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(11, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Kode Pembelian"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightCyan
        Me.Label15.Location = New System.Drawing.Point(11, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Jenis Pembayaran"
        '
        'rdbTunai
        '
        Me.rdbTunai.AutoSize = True
        Me.rdbTunai.Enabled = False
        Me.rdbTunai.Location = New System.Drawing.Point(121, 133)
        Me.rdbTunai.Name = "rdbTunai"
        Me.rdbTunai.Size = New System.Drawing.Size(52, 17)
        Me.rdbTunai.TabIndex = 3
        Me.rdbTunai.TabStop = True
        Me.rdbTunai.Text = "Tunai"
        Me.rdbTunai.UseVisualStyleBackColor = True
        '
        'rdbKredit
        '
        Me.rdbKredit.AutoSize = True
        Me.rdbKredit.Enabled = False
        Me.rdbKredit.Location = New System.Drawing.Point(194, 133)
        Me.rdbKredit.Name = "rdbKredit"
        Me.rdbKredit.Size = New System.Drawing.Size(52, 17)
        Me.rdbKredit.TabIndex = 4
        Me.rdbKredit.TabStop = True
        Me.rdbKredit.Text = "Kredit"
        Me.rdbKredit.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.LightCyan
        Me.Label17.Location = New System.Drawing.Point(362, 133)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "Tgl. Jatuh Tempo"
        '
        'dtpTglJatuhTempo
        '
        Me.dtpTglJatuhTempo.CustomFormat = ""
        Me.dtpTglJatuhTempo.Enabled = False
        Me.dtpTglJatuhTempo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglJatuhTempo.Location = New System.Drawing.Point(468, 130)
        Me.dtpTglJatuhTempo.Name = "dtpTglJatuhTempo"
        Me.dtpTglJatuhTempo.Size = New System.Drawing.Size(112, 20)
        Me.dtpTglJatuhTempo.TabIndex = 5
        Me.dtpTglJatuhTempo.Value = New Date(2016, 6, 17, 0, 0, 0, 0)
        '
        'txtKodeSupplier
        '
        Me.txtKodeSupplier.Enabled = False
        Me.txtKodeSupplier.Location = New System.Drawing.Point(120, 163)
        Me.txtKodeSupplier.MaxLength = 10
        Me.txtKodeSupplier.Name = "txtKodeSupplier"
        Me.txtKodeSupplier.Size = New System.Drawing.Size(142, 20)
        Me.txtKodeSupplier.TabIndex = 96
        '
        'btnFindSupplier
        '
        Me.btnFindSupplier.Enabled = False
        Me.btnFindSupplier.Image = CType(resources.GetObject("btnFindSupplier.Image"), System.Drawing.Image)
        Me.btnFindSupplier.Location = New System.Drawing.Point(268, 161)
        Me.btnFindSupplier.Name = "btnFindSupplier"
        Me.btnFindSupplier.Size = New System.Drawing.Size(43, 23)
        Me.btnFindSupplier.TabIndex = 97
        Me.btnFindSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindSupplier.UseVisualStyleBackColor = True
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtItemPembelianBindingSource
        '
        Me.DtItemPembelianBindingSource.DataMember = "dtItemPembelian"
        Me.DtItemPembelianBindingSource.DataSource = Me.DsTrans
        '
        'DaItemPembelian
        '
        Me.DaItemPembelian.ClearBeforeFill = True
        '
        'cNoPesanan
        '
        Me.cNoPesanan.DataPropertyName = "No_Pesanan"
        Me.cNoPesanan.HeaderText = "No. Pesanan"
        Me.cNoPesanan.Name = "cNoPesanan"
        Me.cNoPesanan.ReadOnly = True
        '
        'cTglPesanan
        '
        Me.cTglPesanan.DataPropertyName = "Tgl_Pesanan"
        DataGridViewCellStyle4.Format = "MM/dd/yyyy"
        Me.cTglPesanan.DefaultCellStyle = DataGridViewCellStyle4
        Me.cTglPesanan.HeaderText = "Tgl. Pesanan"
        Me.cTglPesanan.Name = "cTglPesanan"
        Me.cTglPesanan.ReadOnly = True
        '
        'cKodeSupplier
        '
        Me.cKodeSupplier.DataPropertyName = "Kode_Supplier"
        Me.cKodeSupplier.HeaderText = "Kode Supplier"
        Me.cKodeSupplier.Name = "cKodeSupplier"
        Me.cKodeSupplier.ReadOnly = True
        '
        'cNamaSupplier
        '
        Me.cNamaSupplier.DataPropertyName = "Nama_Supplier"
        Me.cNamaSupplier.HeaderText = "Nama Supplier"
        Me.cNamaSupplier.Name = "cNamaSupplier"
        Me.cNamaSupplier.ReadOnly = True
        '
        'cTotalUangPesanan
        '
        Me.cTotalUangPesanan.DataPropertyName = "Total_UangPesanan"
        DataGridViewCellStyle5.Format = "###0"
        Me.cTotalUangPesanan.DefaultCellStyle = DataGridViewCellStyle5
        Me.cTotalUangPesanan.HeaderText = "Total Tagihan Pesanan"
        Me.cTotalUangPesanan.Name = "cTotalUangPesanan"
        Me.cTotalUangPesanan.ReadOnly = True
        '
        'cPMode
        '
        Me.cPMode.DataPropertyName = "pMode"
        Me.cPMode.HeaderText = "pMode"
        Me.cPMode.Name = "cPMode"
        Me.cPMode.ReadOnly = True
        '
        'frmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1266, 505)
        Me.Controls.Add(Me.btnFindSupplier)
        Me.Controls.Add(Me.txtKodeSupplier)
        Me.Controls.Add(Me.dtpTglJatuhTempo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.rdbKredit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNamaSupplier)
        Me.Controls.Add(Me.rdbTunai)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKodePembelian)
        Me.Controls.Add(Me.dtpTglBeli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlBtnHeader)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmPembelian"
        Me.Text = "Transaksi Pembelian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBtnDetail.ResumeLayout(False)
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtItemPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoPesanan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancelItem As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents pnlBtnDetail As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTglBeli As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnlBtnHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtKodePembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTagihanPesanan As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents rdbTunai As System.Windows.Forms.RadioButton
    Friend WithEvents rdbKredit As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpTglJatuhTempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKodeSupplier As System.Windows.Forms.TextBox
    Friend WithEvents btnFindPesanan As System.Windows.Forms.Button
    Friend WithEvents btnFindSupplier As System.Windows.Forms.Button
    Friend WithEvents cKodePembelian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUangPembayaran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTglPesanan As System.Windows.Forms.Label
    Friend WithEvents DtItemPembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaItemPembelian As EJM.dsTransTableAdapters.daItemPembelian
    Friend WithEvents cNoPesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTglPesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalUangPesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPMode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
