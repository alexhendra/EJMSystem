<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenerimaan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPenerimaan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodePenerimaan = New System.Windows.Forms.TextBox()
        Me.txtNoPesanan = New System.Windows.Forms.TextBox()
        Me.grpBarang = New System.Windows.Forms.GroupBox()
        Me.rdbRetur = New System.Windows.Forms.RadioButton()
        Me.rdbPesanan = New System.Windows.Forms.RadioButton()
        Me.txtKodeRetur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTglTerima = New System.Windows.Forms.DateTimePicker()
        Me.lblTglPesanan = New System.Windows.Forms.Label()
        Me.lblKodeSupplier = New System.Windows.Forms.Label()
        Me.lblNamaSupplier = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTglRetur = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahPesan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahRetur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahTerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtDetailBarangTerimaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlBtnHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnFindPesanan = New System.Windows.Forms.Button()
        Me.btnFindRetur = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.btnCancelItem = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlBtnDetail = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtJumlahTerima = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblJumlahRetur = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblJumlahPesanan = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblUom = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnFindBarang = New System.Windows.Forms.Button()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DaDetailBarangTerima = New EJM.dsTransTableAdapters.daDetailBarangTerima()
        Me.grpBarang.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDetailBarangTerimaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBtnHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlBtnDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Penerimaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Pesanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Retur"
        '
        'txtKodePenerimaan
        '
        Me.txtKodePenerimaan.Location = New System.Drawing.Point(116, 77)
        Me.txtKodePenerimaan.MaxLength = 14
        Me.txtKodePenerimaan.Name = "txtKodePenerimaan"
        Me.txtKodePenerimaan.Size = New System.Drawing.Size(170, 20)
        Me.txtKodePenerimaan.TabIndex = 4
        '
        'txtNoPesanan
        '
        Me.txtNoPesanan.Enabled = False
        Me.txtNoPesanan.Location = New System.Drawing.Point(116, 187)
        Me.txtNoPesanan.MaxLength = 14
        Me.txtNoPesanan.Name = "txtNoPesanan"
        Me.txtNoPesanan.Size = New System.Drawing.Size(145, 20)
        Me.txtNoPesanan.TabIndex = 5
        '
        'grpBarang
        '
        Me.grpBarang.Controls.Add(Me.rdbRetur)
        Me.grpBarang.Controls.Add(Me.rdbPesanan)
        Me.grpBarang.Enabled = False
        Me.grpBarang.Location = New System.Drawing.Point(13, 105)
        Me.grpBarang.Name = "grpBarang"
        Me.grpBarang.Size = New System.Drawing.Size(211, 49)
        Me.grpBarang.TabIndex = 6
        Me.grpBarang.TabStop = False
        Me.grpBarang.Text = "Asal Kedatangan Barang"
        '
        'rdbRetur
        '
        Me.rdbRetur.AutoSize = True
        Me.rdbRetur.Location = New System.Drawing.Point(114, 22)
        Me.rdbRetur.Name = "rdbRetur"
        Me.rdbRetur.Size = New System.Drawing.Size(51, 17)
        Me.rdbRetur.TabIndex = 1
        Me.rdbRetur.Text = "Retur"
        Me.rdbRetur.UseVisualStyleBackColor = True
        '
        'rdbPesanan
        '
        Me.rdbPesanan.AutoSize = True
        Me.rdbPesanan.Checked = True
        Me.rdbPesanan.Location = New System.Drawing.Point(21, 23)
        Me.rdbPesanan.Name = "rdbPesanan"
        Me.rdbPesanan.Size = New System.Drawing.Size(67, 17)
        Me.rdbPesanan.TabIndex = 0
        Me.rdbPesanan.TabStop = True
        Me.rdbPesanan.Text = "Pesanan"
        Me.rdbPesanan.UseVisualStyleBackColor = True
        '
        'txtKodeRetur
        '
        Me.txtKodeRetur.Enabled = False
        Me.txtKodeRetur.Location = New System.Drawing.Point(116, 216)
        Me.txtKodeRetur.MaxLength = 14
        Me.txtKodeRetur.Name = "txtKodeRetur"
        Me.txtKodeRetur.Size = New System.Drawing.Size(145, 20)
        Me.txtKodeRetur.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tgl. Penerimaan"
        '
        'dtpTglTerima
        '
        Me.dtpTglTerima.CustomFormat = "MM/dd/yyyy"
        Me.dtpTglTerima.Enabled = False
        Me.dtpTglTerima.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglTerima.Location = New System.Drawing.Point(116, 158)
        Me.dtpTglTerima.Name = "dtpTglTerima"
        Me.dtpTglTerima.Size = New System.Drawing.Size(113, 20)
        Me.dtpTglTerima.TabIndex = 9
        Me.dtpTglTerima.Value = New Date(2016, 7, 1, 14, 15, 23, 0)
        '
        'lblTglPesanan
        '
        Me.lblTglPesanan.BackColor = System.Drawing.SystemColors.Control
        Me.lblTglPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTglPesanan.Location = New System.Drawing.Point(98, 19)
        Me.lblTglPesanan.Name = "lblTglPesanan"
        Me.lblTglPesanan.Size = New System.Drawing.Size(155, 23)
        Me.lblTglPesanan.TabIndex = 101
        Me.lblTglPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKodeSupplier
        '
        Me.lblKodeSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.lblKodeSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKodeSupplier.Location = New System.Drawing.Point(98, 56)
        Me.lblKodeSupplier.Name = "lblKodeSupplier"
        Me.lblKodeSupplier.Size = New System.Drawing.Size(181, 23)
        Me.lblKodeSupplier.TabIndex = 98
        Me.lblKodeSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNamaSupplier
        '
        Me.lblNamaSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaSupplier.Location = New System.Drawing.Point(448, 54)
        Me.lblNamaSupplier.Name = "lblNamaSupplier"
        Me.lblNamaSupplier.Size = New System.Drawing.Size(318, 23)
        Me.lblNamaSupplier.TabIndex = 97
        Me.lblNamaSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightCyan
        Me.Label11.Location = New System.Drawing.Point(356, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Nama Supplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(9, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Kode Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightCyan
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Tgl. Pesanan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(356, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Tgl. Retur"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNamaSupplier)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblTglRetur)
        Me.GroupBox2.Controls.Add(Me.lblTglPesanan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblKodeSupplier)
        Me.GroupBox2.Location = New System.Drawing.Point(346, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 95)
        Me.GroupBox2.TabIndex = 103
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informasi"
        '
        'lblTglRetur
        '
        Me.lblTglRetur.BackColor = System.Drawing.SystemColors.Control
        Me.lblTglRetur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTglRetur.Location = New System.Drawing.Point(448, 19)
        Me.lblTglRetur.Name = "lblTglRetur"
        Me.lblTglRetur.Size = New System.Drawing.Size(155, 23)
        Me.lblTglRetur.TabIndex = 103
        Me.lblTglRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeBarang, Me.cNamaBarang, Me.cUom, Me.cJumlahPesan, Me.cJumlahRetur, Me.cJumlahTerima, Me.PModeDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.DtDetailBarangTerimaBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(11, 116)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(981, 149)
        Me.dgv.TabIndex = 104
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
        'cUom
        '
        Me.cUom.DataPropertyName = "uomName"
        Me.cUom.HeaderText = "UOM"
        Me.cUom.Name = "cUom"
        Me.cUom.ReadOnly = True
        '
        'cJumlahPesan
        '
        Me.cJumlahPesan.DataPropertyName = "JumlahPesan"
        Me.cJumlahPesan.HeaderText = "Jlh. Pesan"
        Me.cJumlahPesan.Name = "cJumlahPesan"
        Me.cJumlahPesan.ReadOnly = True
        '
        'cJumlahRetur
        '
        Me.cJumlahRetur.DataPropertyName = "JumlahRetur"
        Me.cJumlahRetur.HeaderText = "Jlh. Retur"
        Me.cJumlahRetur.Name = "cJumlahRetur"
        Me.cJumlahRetur.ReadOnly = True
        '
        'cJumlahTerima
        '
        Me.cJumlahTerima.DataPropertyName = "JumlahTerima"
        Me.cJumlahTerima.HeaderText = "Jlh. Terima"
        Me.cJumlahTerima.Name = "cJumlahTerima"
        Me.cJumlahTerima.ReadOnly = True
        '
        'PModeDataGridViewTextBoxColumn
        '
        Me.PModeDataGridViewTextBoxColumn.DataPropertyName = "pMode"
        Me.PModeDataGridViewTextBoxColumn.HeaderText = "pMode"
        Me.PModeDataGridViewTextBoxColumn.Name = "PModeDataGridViewTextBoxColumn"
        Me.PModeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DtDetailBarangTerimaBindingSource
        '
        Me.DtDetailBarangTerimaBindingSource.DataMember = "dtDetailBarangTerima"
        Me.DtDetailBarangTerimaBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(3, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(79, 39)
        Me.btnNew.TabIndex = 108
        Me.btnNew.Text = "Baru"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(395, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 39)
        Me.btnCancel.TabIndex = 106
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'pnlBtnHeader
        '
        Me.pnlBtnHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBtnHeader.AutoSize = True
        Me.pnlBtnHeader.Controls.Add(Me.btnNew)
        Me.pnlBtnHeader.Location = New System.Drawing.Point(16, 515)
        Me.pnlBtnHeader.Name = "pnlBtnHeader"
        Me.pnlBtnHeader.Size = New System.Drawing.Size(288, 45)
        Me.pnlBtnHeader.TabIndex = 109
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(310, 521)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 39)
        Me.btnSave.TabIndex = 105
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(480, 521)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 39)
        Me.btnExit.TabIndex = 107
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblWarning)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 62)
        Me.Panel1.TabIndex = 110
        '
        'lblWarning
        '
        Me.lblWarning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(440, 19)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(0, 19)
        Me.lblWarning.TabIndex = 89
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(11, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Transaksi Penerimaan"
        '
        'btnFindPesanan
        '
        Me.btnFindPesanan.Enabled = False
        Me.btnFindPesanan.Image = CType(resources.GetObject("btnFindPesanan.Image"), System.Drawing.Image)
        Me.btnFindPesanan.Location = New System.Drawing.Point(267, 185)
        Me.btnFindPesanan.Name = "btnFindPesanan"
        Me.btnFindPesanan.Size = New System.Drawing.Size(43, 23)
        Me.btnFindPesanan.TabIndex = 111
        Me.btnFindPesanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindPesanan.UseVisualStyleBackColor = True
        '
        'btnFindRetur
        '
        Me.btnFindRetur.Enabled = False
        Me.btnFindRetur.Image = CType(resources.GetObject("btnFindRetur.Image"), System.Drawing.Image)
        Me.btnFindRetur.Location = New System.Drawing.Point(267, 215)
        Me.btnFindRetur.Name = "btnFindRetur"
        Me.btnFindRetur.Size = New System.Drawing.Size(43, 23)
        Me.btnFindRetur.TabIndex = 112
        Me.btnFindRetur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindRetur.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSaveItem)
        Me.GroupBox1.Controls.Add(Me.btnCancelItem)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.pnlBtnDetail)
        Me.GroupBox1.Controls.Add(Me.txtJumlahTerima)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.lblJumlahRetur)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblJumlahPesanan)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lblUom)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblNamaBarang)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btnFindBarang)
        Me.GroupBox1.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 270)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Image = CType(resources.GetObject("btnSaveItem.Image"), System.Drawing.Image)
        Me.btnSaveItem.Location = New System.Drawing.Point(395, 77)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(73, 31)
        Me.btnSaveItem.TabIndex = 124
        Me.btnSaveItem.Text = "Simpan"
        Me.btnSaveItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveItem.UseVisualStyleBackColor = True
        Me.btnSaveItem.Visible = False
        '
        'btnCancelItem
        '
        Me.btnCancelItem.Image = CType(resources.GetObject("btnCancelItem.Image"), System.Drawing.Image)
        Me.btnCancelItem.Location = New System.Drawing.Point(637, 77)
        Me.btnCancelItem.Name = "btnCancelItem"
        Me.btnCancelItem.Size = New System.Drawing.Size(75, 29)
        Me.btnCancelItem.TabIndex = 127
        Me.btnCancelItem.Text = "Batal"
        Me.btnCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelItem.UseVisualStyleBackColor = True
        Me.btnCancelItem.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(474, 77)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 29)
        Me.btnEdit.TabIndex = 125
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(555, 77)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(76, 28)
        Me.btnDelete.TabIndex = 126
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'pnlBtnDetail
        '
        Me.pnlBtnDetail.Controls.Add(Me.btnAdd)
        Me.pnlBtnDetail.Enabled = False
        Me.pnlBtnDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlBtnDetail.Location = New System.Drawing.Point(10, 75)
        Me.pnlBtnDetail.Name = "pnlBtnDetail"
        Me.pnlBtnDetail.Size = New System.Drawing.Size(373, 38)
        Me.pnlBtnDetail.TabIndex = 123
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
        'txtJumlahTerima
        '
        Me.txtJumlahTerima.Enabled = False
        Me.txtJumlahTerima.Location = New System.Drawing.Point(110, 47)
        Me.txtJumlahTerima.Name = "txtJumlahTerima"
        Me.txtJumlahTerima.Size = New System.Drawing.Size(108, 20)
        Me.txtJumlahTerima.TabIndex = 122
        Me.txtJumlahTerima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 121
        Me.Label22.Text = "Jumlah Terima"
        '
        'lblJumlahRetur
        '
        Me.lblJumlahRetur.BackColor = System.Drawing.SystemColors.Control
        Me.lblJumlahRetur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJumlahRetur.Location = New System.Drawing.Point(845, 46)
        Me.lblJumlahRetur.Name = "lblJumlahRetur"
        Me.lblJumlahRetur.Size = New System.Drawing.Size(127, 23)
        Me.lblJumlahRetur.TabIndex = 119
        Me.lblJumlahRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(764, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 120
        Me.Label21.Text = "Jumlah Retur"
        '
        'lblJumlahPesanan
        '
        Me.lblJumlahPesanan.BackColor = System.Drawing.SystemColors.Control
        Me.lblJumlahPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJumlahPesanan.Location = New System.Drawing.Point(438, 45)
        Me.lblJumlahPesanan.Name = "lblJumlahPesanan"
        Me.lblJumlahPesanan.Size = New System.Drawing.Size(127, 23)
        Me.lblJumlahPesanan.TabIndex = 117
        Me.lblJumlahPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(326, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 13)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "Jumlah Pesanan"
        '
        'lblUom
        '
        Me.lblUom.BackColor = System.Drawing.SystemColors.Control
        Me.lblUom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUom.Location = New System.Drawing.Point(845, 16)
        Me.lblUom.Name = "lblUom"
        Me.lblUom.Size = New System.Drawing.Size(124, 23)
        Me.lblUom.TabIndex = 108
        Me.lblUom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(764, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "UOM"
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaBarang.Location = New System.Drawing.Point(438, 16)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(296, 23)
        Me.lblNamaBarang.TabIndex = 108
        Me.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(327, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Nama Barang"
        '
        'btnFindBarang
        '
        Me.btnFindBarang.Enabled = False
        Me.btnFindBarang.Image = CType(resources.GetObject("btnFindBarang.Image"), System.Drawing.Image)
        Me.btnFindBarang.Location = New System.Drawing.Point(261, 19)
        Me.btnFindBarang.Name = "btnFindBarang"
        Me.btnFindBarang.Size = New System.Drawing.Size(43, 23)
        Me.btnFindBarang.TabIndex = 114
        Me.btnFindBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindBarang.UseVisualStyleBackColor = True
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Enabled = False
        Me.txtKodeBarang.Location = New System.Drawing.Point(110, 19)
        Me.txtKodeBarang.MaxLength = 10
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(145, 20)
        Me.txtKodeBarang.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Kode Barang"
        '
        'DaDetailBarangTerima
        '
        Me.DaDetailBarangTerima.ClearBeforeFill = True
        '
        'frmPenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1184, 565)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFindRetur)
        Me.Controls.Add(Me.btnFindPesanan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpTglTerima)
        Me.Controls.Add(Me.pnlBtnHeader)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtKodeRetur)
        Me.Controls.Add(Me.grpBarang)
        Me.Controls.Add(Me.txtNoPesanan)
        Me.Controls.Add(Me.txtKodePenerimaan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPenerimaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penerimaan Barang"
        Me.grpBarang.ResumeLayout(False)
        Me.grpBarang.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDetailBarangTerimaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBtnHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlBtnDetail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodePenerimaan As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPesanan As System.Windows.Forms.TextBox
    Friend WithEvents grpBarang As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRetur As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPesanan As System.Windows.Forms.RadioButton
    Friend WithEvents txtKodeRetur As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTglTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTglPesanan As System.Windows.Forms.Label
    Friend WithEvents lblKodeSupplier As System.Windows.Forms.Label
    Friend WithEvents lblNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTglRetur As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlBtnHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnFindPesanan As System.Windows.Forms.Button
    Friend WithEvents btnFindRetur As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahTerima As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahRetur As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahPesanan As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblUom As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblNamaBarang As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnFindBarang As System.Windows.Forms.Button
    Friend WithEvents pnlBtnDetail As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents btnCancelItem As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahPesan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahRetur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahTerima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtDetailBarangTerimaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaDetailBarangTerima As EJM.dsTransTableAdapters.daDetailBarangTerima
End Class
