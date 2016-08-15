<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPenjualan))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWarning = New System.Windows.Forms.Label()
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DtBarangJualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoPenjualan = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFindCustomer = New System.Windows.Forms.Button()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNamaCustomer = New System.Windows.Forms.Label()
        Me.txtKodeCustomer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTransJual = New System.Windows.Forms.DateTimePicker()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlBtnHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DaBarangJual = New EJM.dsTransTableAdapters.daBarangJual()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUomId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlBtnDetail.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtBarangJualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblWarning)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 55)
        Me.Panel1.TabIndex = 63
        '
        'lblWarning
        '
        Me.lblWarning.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarning.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(279, 11)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(554, 30)
        Me.lblWarning.TabIndex = 89
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(11, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Transaksi Penjualan"
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(906, 131)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'txtHarga
        '
        Me.txtHarga.Enabled = False
        Me.txtHarga.Location = New System.Drawing.Point(652, 50)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(113, 20)
        Me.txtHarga.TabIndex = 4
        Me.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Image = CType(resources.GetObject("btnSaveItem.Image"), System.Drawing.Image)
        Me.btnSaveItem.Location = New System.Drawing.Point(424, 85)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(73, 31)
        Me.btnSaveItem.TabIndex = 5
        Me.btnSaveItem.Text = "Simpan"
        Me.btnSaveItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveItem.UseVisualStyleBackColor = True
        Me.btnSaveItem.Visible = False
        '
        'btnCancelItem
        '
        Me.btnCancelItem.Image = CType(resources.GetObject("btnCancelItem.Image"), System.Drawing.Image)
        Me.btnCancelItem.Location = New System.Drawing.Point(663, 85)
        Me.btnCancelItem.Name = "btnCancelItem"
        Me.btnCancelItem.Size = New System.Drawing.Size(75, 31)
        Me.btnCancelItem.TabIndex = 8
        Me.btnCancelItem.Text = "Batal"
        Me.btnCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelItem.UseVisualStyleBackColor = True
        Me.btnCancelItem.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightCyan
        Me.Label4.Location = New System.Drawing.Point(603, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Harga"
        '
        'btnFindBarang
        '
        Me.btnFindBarang.Enabled = False
        Me.btnFindBarang.Image = CType(resources.GetObject("btnFindBarang.Image"), System.Drawing.Image)
        Me.btnFindBarang.Location = New System.Drawing.Point(240, 19)
        Me.btnFindBarang.Name = "btnFindBarang"
        Me.btnFindBarang.Size = New System.Drawing.Size(43, 23)
        Me.btnFindBarang.TabIndex = 2
        Me.btnFindBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindBarang.UseVisualStyleBackColor = True
        '
        'lblUOM
        '
        Me.lblUOM.BackColor = System.Drawing.SystemColors.Control
        Me.lblUOM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUOM.Location = New System.Drawing.Point(503, 50)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(66, 23)
        Me.lblUOM.TabIndex = 81
        Me.lblUOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(503, 85)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 31)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaBarang.Location = New System.Drawing.Point(503, 19)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(351, 23)
        Me.lblNamaBarang.TabIndex = 80
        Me.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBtnDetail
        '
        Me.pnlBtnDetail.Controls.Add(Me.btnAdd)
        Me.pnlBtnDetail.Enabled = False
        Me.pnlBtnDetail.Location = New System.Drawing.Point(12, 83)
        Me.pnlBtnDetail.Name = "pnlBtnDetail"
        Me.pnlBtnDetail.Size = New System.Drawing.Size(397, 38)
        Me.pnlBtnDetail.TabIndex = 70
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtJumlahPesan
        '
        Me.txtJumlahPesan.Enabled = False
        Me.txtJumlahPesan.Location = New System.Drawing.Point(98, 49)
        Me.txtJumlahPesan.Name = "txtJumlahPesan"
        Me.txtJumlahPesan.Size = New System.Drawing.Size(169, 20)
        Me.txtJumlahPesan.TabIndex = 3
        Me.txtJumlahPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightCyan
        Me.Label10.Location = New System.Drawing.Point(7, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Jumlah Pesanan"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(584, 86)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightCyan
        Me.Label9.Location = New System.Drawing.Point(446, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "UOM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(446, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Nama"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Enabled = False
        Me.txtKodeBarang.Location = New System.Drawing.Point(98, 21)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(136, 20)
        Me.txtKodeBarang.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightCyan
        Me.Label8.Location = New System.Drawing.Point(7, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Kode Barang"
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeBarang, Me.cNamaBarang, Me.cUomId, Me.cUomName, Me.cJumlah, Me.cHarga, Me.cSubTotal, Me.cPMode})
        Me.dgv.DataSource = Me.DtBarangJualBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(7, 342)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(951, 158)
        Me.dgv.TabIndex = 68
        '
        'DtBarangJualBindingSource
        '
        Me.DtBarangJualBindingSource.DataMember = "dtBarangJual"
        Me.DtBarangJualBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "No. Penjualan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(411, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Tgl. Transaksi"
        '
        'txtNoPenjualan
        '
        Me.txtNoPenjualan.Location = New System.Drawing.Point(105, 63)
        Me.txtNoPenjualan.MaxLength = 14
        Me.txtNoPenjualan.Name = "txtNoPenjualan"
        Me.txtNoPenjualan.Size = New System.Drawing.Size(159, 20)
        Me.txtNoPenjualan.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFindCustomer)
        Me.GroupBox2.Controls.Add(Me.rtbAlamat)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblNamaCustomer)
        Me.GroupBox2.Controls.Add(Me.txtKodeCustomer)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(906, 100)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Customer"
        '
        'btnFindCustomer
        '
        Me.btnFindCustomer.Enabled = False
        Me.btnFindCustomer.Image = CType(resources.GetObject("btnFindCustomer.Image"), System.Drawing.Image)
        Me.btnFindCustomer.Location = New System.Drawing.Point(240, 22)
        Me.btnFindCustomer.Name = "btnFindCustomer"
        Me.btnFindCustomer.Size = New System.Drawing.Size(43, 23)
        Me.btnFindCustomer.TabIndex = 1
        Me.btnFindCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindCustomer.UseVisualStyleBackColor = True
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Enabled = False
        Me.rtbAlamat.Location = New System.Drawing.Point(503, 18)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.ReadOnly = True
        Me.rtbAlamat.Size = New System.Drawing.Size(351, 74)
        Me.rtbAlamat.TabIndex = 5
        Me.rtbAlamat.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(446, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Alamat"
        '
        'lblNamaCustomer
        '
        Me.lblNamaCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaCustomer.Location = New System.Drawing.Point(98, 52)
        Me.lblNamaCustomer.Name = "lblNamaCustomer"
        Me.lblNamaCustomer.Size = New System.Drawing.Size(299, 23)
        Me.lblNamaCustomer.TabIndex = 3
        '
        'txtKodeCustomer
        '
        Me.txtKodeCustomer.Enabled = False
        Me.txtKodeCustomer.Location = New System.Drawing.Point(98, 24)
        Me.txtKodeCustomer.MaxLength = 10
        Me.txtKodeCustomer.Name = "txtKodeCustomer"
        Me.txtKodeCustomer.Size = New System.Drawing.Size(136, 20)
        Me.txtKodeCustomer.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Customer"
        '
        'dtpTransJual
        '
        Me.dtpTransJual.CustomFormat = "MM/dd/yyyy"
        Me.dtpTransJual.Enabled = False
        Me.dtpTransJual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransJual.Location = New System.Drawing.Point(510, 63)
        Me.dtpTransJual.Name = "dtpTransJual"
        Me.dtpTransJual.Size = New System.Drawing.Size(110, 20)
        Me.dtpTransJual.TabIndex = 2
        Me.dtpTransJual.Value = New Date(2016, 7, 17, 16, 19, 57, 0)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(417, 505)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 39)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Baru"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'pnlBtnHeader
        '
        Me.pnlBtnHeader.AutoSize = True
        Me.pnlBtnHeader.Location = New System.Drawing.Point(7, 506)
        Me.pnlBtnHeader.Name = "pnlBtnHeader"
        Me.pnlBtnHeader.Size = New System.Drawing.Size(397, 49)
        Me.pnlBtnHeader.TabIndex = 92
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(572, 505)
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
        Me.btnSave.Location = New System.Drawing.Point(496, 505)
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
        Me.btnExit.Location = New System.Drawing.Point(653, 506)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'DaBarangJual
        '
        Me.DaBarangJual.ClearBeforeFill = True
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
        'cUomId
        '
        Me.cUomId.DataPropertyName = "UOM"
        Me.cUomId.HeaderText = "UOM"
        Me.cUomId.Name = "cUomId"
        Me.cUomId.ReadOnly = True
        Me.cUomId.Visible = False
        '
        'cUomName
        '
        Me.cUomName.DataPropertyName = "uomName"
        Me.cUomName.HeaderText = "UOM"
        Me.cUomName.Name = "cUomName"
        Me.cUomName.ReadOnly = True
        '
        'cJumlah
        '
        Me.cJumlah.DataPropertyName = "Jumlah"
        Me.cJumlah.HeaderText = "Jumlah Pesanan"
        Me.cJumlah.Name = "cJumlah"
        Me.cJumlah.ReadOnly = True
        '
        'cHarga
        '
        Me.cHarga.DataPropertyName = "Harga"
        Me.cHarga.HeaderText = "Harga"
        Me.cHarga.Name = "cHarga"
        Me.cHarga.ReadOnly = True
        '
        'cSubTotal
        '
        Me.cSubTotal.DataPropertyName = "Subtotal"
        Me.cSubTotal.HeaderText = "Sub Total"
        Me.cSubTotal.Name = "cSubTotal"
        Me.cSubTotal.ReadOnly = True
        '
        'cPMode
        '
        Me.cPMode.DataPropertyName = "pMode"
        Me.cPMode.HeaderText = "pMode"
        Me.cPMode.Name = "cPMode"
        Me.cPMode.ReadOnly = True
        Me.cPMode.Visible = False
        '
        'frmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(987, 560)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.pnlBtnHeader)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dtpTransJual)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtNoPenjualan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPenjualan"
        Me.Text = "Transaksi Penjualan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlBtnDetail.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtBarangJualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents btnCancelItem As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFindBarang As System.Windows.Forms.Button
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblNamaBarang As System.Windows.Forms.Label
    Friend WithEvents pnlBtnDetail As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtJumlahPesan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoPenjualan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFindCustomer As System.Windows.Forms.Button
    Friend WithEvents rtbAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNamaCustomer As System.Windows.Forms.Label
    Friend WithEvents txtKodeCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTransJual As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnlBtnHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DtBarangJualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaBarangJual As EJM.dsTransTableAdapters.daBarangJual
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUomId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUomName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPMode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
