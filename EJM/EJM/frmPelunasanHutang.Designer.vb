<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPelunasanHutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPelunasanHutang))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtKodePelunasan = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFindSupplier = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNamaSupplier = New System.Windows.Forms.Label()
        Me.txtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTglPelunasan = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.btnCancelItem = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlBtnDetail = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTotalHutang = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTglJatuhTempo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTglBeli = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFindPembelian = New System.Windows.Forms.Button()
        Me.txtKodePembelian = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cKodePembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTglPembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTglJatuhTempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalHutang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalDibayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtItemPelunasanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlBtnHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DaItemPelunasan = New EJM.dsTransTableAdapters.daItemPelunasan()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlBtnDetail.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtItemPelunasanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(32, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Kode Pelunasan Hutang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblWarning)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 62)
        Me.Panel1.TabIndex = 63
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(304, 16)
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
        Me.Label14.Size = New System.Drawing.Size(124, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Pelunasan Hutang"
        '
        'txtKodePelunasan
        '
        Me.txtKodePelunasan.Location = New System.Drawing.Point(174, 73)
        Me.txtKodePelunasan.MaxLength = 14
        Me.txtKodePelunasan.Name = "txtKodePelunasan"
        Me.txtKodePelunasan.Size = New System.Drawing.Size(172, 20)
        Me.txtKodePelunasan.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFindSupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblNamaSupplier)
        Me.GroupBox1.Controls.Add(Me.txtKodeSupplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(993, 57)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Supplier"
        '
        'btnFindSupplier
        '
        Me.btnFindSupplier.Enabled = False
        Me.btnFindSupplier.Image = CType(resources.GetObject("btnFindSupplier.Image"), System.Drawing.Image)
        Me.btnFindSupplier.Location = New System.Drawing.Point(288, 25)
        Me.btnFindSupplier.Name = "btnFindSupplier"
        Me.btnFindSupplier.Size = New System.Drawing.Size(43, 23)
        Me.btnFindSupplier.TabIndex = 1
        Me.btnFindSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindSupplier.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightCyan
        Me.Label4.Location = New System.Drawing.Point(400, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Nama Supplier"
        '
        'lblNamaSupplier
        '
        Me.lblNamaSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaSupplier.Location = New System.Drawing.Point(499, 23)
        Me.lblNamaSupplier.Name = "lblNamaSupplier"
        Me.lblNamaSupplier.Size = New System.Drawing.Size(336, 25)
        Me.lblNamaSupplier.TabIndex = 68
        Me.lblNamaSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKodeSupplier
        '
        Me.txtKodeSupplier.Enabled = False
        Me.txtKodeSupplier.Location = New System.Drawing.Point(139, 26)
        Me.txtKodeSupplier.MaxLength = 10
        Me.txtKodeSupplier.Name = "txtKodeSupplier"
        Me.txtKodeSupplier.Size = New System.Drawing.Size(143, 20)
        Me.txtKodeSupplier.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(25, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Kode Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightCyan
        Me.Label5.Location = New System.Drawing.Point(449, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Tgl. Pelunasan"
        '
        'dtpTglPelunasan
        '
        Me.dtpTglPelunasan.CustomFormat = "MM/dd/yyyy"
        Me.dtpTglPelunasan.Enabled = False
        Me.dtpTglPelunasan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglPelunasan.Location = New System.Drawing.Point(550, 73)
        Me.dtpTglPelunasan.Name = "dtpTglPelunasan"
        Me.dtpTglPelunasan.Size = New System.Drawing.Size(116, 20)
        Me.dtpTglPelunasan.TabIndex = 2
        Me.dtpTglPelunasan.Value = New Date(2016, 7, 11, 8, 59, 56, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveItem)
        Me.GroupBox2.Controls.Add(Me.btnCancelItem)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.pnlBtnDetail)
        Me.GroupBox2.Controls.Add(Me.lblTotalHutang)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblTglJatuhTempo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblTglBeli)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnFindPembelian)
        Me.GroupBox2.Controls.Add(Me.txtKodePembelian)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(993, 330)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Pelunasan"
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Image = CType(resources.GetObject("btnSaveItem.Image"), System.Drawing.Image)
        Me.btnSaveItem.Location = New System.Drawing.Point(578, 90)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(75, 31)
        Me.btnSaveItem.TabIndex = 4
        Me.btnSaveItem.Text = "Simpan"
        Me.btnSaveItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveItem.UseVisualStyleBackColor = True
        Me.btnSaveItem.Visible = False
        '
        'btnCancelItem
        '
        Me.btnCancelItem.Image = CType(resources.GetObject("btnCancelItem.Image"), System.Drawing.Image)
        Me.btnCancelItem.Location = New System.Drawing.Point(497, 91)
        Me.btnCancelItem.Name = "btnCancelItem"
        Me.btnCancelItem.Size = New System.Drawing.Size(75, 31)
        Me.btnCancelItem.TabIndex = 7
        Me.btnCancelItem.Text = "Batal"
        Me.btnCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelItem.UseVisualStyleBackColor = True
        Me.btnCancelItem.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(659, 91)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 31)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(416, 91)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 31)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'pnlBtnDetail
        '
        Me.pnlBtnDetail.AutoSize = True
        Me.pnlBtnDetail.Controls.Add(Me.btnAdd)
        Me.pnlBtnDetail.Enabled = False
        Me.pnlBtnDetail.Location = New System.Drawing.Point(28, 88)
        Me.pnlBtnDetail.Name = "pnlBtnDetail"
        Me.pnlBtnDetail.Size = New System.Drawing.Size(376, 38)
        Me.pnlBtnDetail.TabIndex = 98
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTotalHutang
        '
        Me.lblTotalHutang.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalHutang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalHutang.Location = New System.Drawing.Point(499, 55)
        Me.lblTotalHutang.Name = "lblTotalHutang"
        Me.lblTotalHutang.Size = New System.Drawing.Size(153, 25)
        Me.lblTotalHutang.TabIndex = 97
        Me.lblTotalHutang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightCyan
        Me.Label11.Location = New System.Drawing.Point(400, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Total Hutang"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Enabled = False
        Me.txtTotalBayar.Location = New System.Drawing.Point(139, 52)
        Me.txtTotalBayar.MaxLength = 10
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(143, 20)
        Me.txtTotalBayar.TabIndex = 3
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightCyan
        Me.Label10.Location = New System.Drawing.Point(25, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Total Bayar"
        '
        'lblTglJatuhTempo
        '
        Me.lblTglJatuhTempo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTglJatuhTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTglJatuhTempo.Location = New System.Drawing.Point(805, 20)
        Me.lblTglJatuhTempo.Name = "lblTglJatuhTempo"
        Me.lblTglJatuhTempo.Size = New System.Drawing.Size(153, 25)
        Me.lblTglJatuhTempo.TabIndex = 93
        Me.lblTglJatuhTempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightCyan
        Me.Label9.Location = New System.Drawing.Point(689, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Tgl. Jatuh Tempo"
        '
        'lblTglBeli
        '
        Me.lblTglBeli.BackColor = System.Drawing.SystemColors.Control
        Me.lblTglBeli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTglBeli.Location = New System.Drawing.Point(499, 23)
        Me.lblTglBeli.Name = "lblTglBeli"
        Me.lblTglBeli.Size = New System.Drawing.Size(153, 25)
        Me.lblTglBeli.TabIndex = 91
        Me.lblTglBeli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(400, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Tgl. Pembelian"
        '
        'btnFindPembelian
        '
        Me.btnFindPembelian.Enabled = False
        Me.btnFindPembelian.Image = CType(resources.GetObject("btnFindPembelian.Image"), System.Drawing.Image)
        Me.btnFindPembelian.Location = New System.Drawing.Point(316, 23)
        Me.btnFindPembelian.Name = "btnFindPembelian"
        Me.btnFindPembelian.Size = New System.Drawing.Size(43, 23)
        Me.btnFindPembelian.TabIndex = 2
        Me.btnFindPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindPembelian.UseVisualStyleBackColor = True
        '
        'txtKodePembelian
        '
        Me.txtKodePembelian.Enabled = False
        Me.txtKodePembelian.Location = New System.Drawing.Point(139, 25)
        Me.txtKodePembelian.MaxLength = 14
        Me.txtKodePembelian.Name = "txtKodePembelian"
        Me.txtKodePembelian.Size = New System.Drawing.Size(172, 20)
        Me.txtKodePembelian.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightCyan
        Me.Label8.Location = New System.Drawing.Point(25, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Kode Pembelian"
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodePembelian, Me.cTglPembelian, Me.cTglJatuhTempo, Me.cTotalHutang, Me.cTotalDibayar, Me.cPMode})
        Me.dgv.DataSource = Me.DtItemPelunasanBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(9, 132)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(978, 190)
        Me.dgv.TabIndex = 92
        '
        'cKodePembelian
        '
        Me.cKodePembelian.DataPropertyName = "Kode_Pembelian"
        Me.cKodePembelian.HeaderText = "Kode Pembelian"
        Me.cKodePembelian.Name = "cKodePembelian"
        Me.cKodePembelian.ReadOnly = True
        '
        'cTglPembelian
        '
        Me.cTglPembelian.DataPropertyName = "Tgl_Beli"
        Me.cTglPembelian.HeaderText = "Tgl. Pembelian"
        Me.cTglPembelian.Name = "cTglPembelian"
        Me.cTglPembelian.ReadOnly = True
        '
        'cTglJatuhTempo
        '
        Me.cTglJatuhTempo.DataPropertyName = "Tgl_Jatuh_Tempo"
        Me.cTglJatuhTempo.HeaderText = "Tgl. Jatuh Tempo"
        Me.cTglJatuhTempo.Name = "cTglJatuhTempo"
        Me.cTglJatuhTempo.ReadOnly = True
        '
        'cTotalHutang
        '
        Me.cTotalHutang.DataPropertyName = "TotalHutang"
        Me.cTotalHutang.HeaderText = "Total Hutang"
        Me.cTotalHutang.Name = "cTotalHutang"
        Me.cTotalHutang.ReadOnly = True
        '
        'cTotalDibayar
        '
        Me.cTotalDibayar.DataPropertyName = "Total_Bayar"
        Me.cTotalDibayar.HeaderText = "Total Bayar"
        Me.cTotalDibayar.Name = "cTotalDibayar"
        Me.cTotalDibayar.ReadOnly = True
        '
        'cPMode
        '
        Me.cPMode.DataPropertyName = "pMode"
        Me.cPMode.HeaderText = "pMode"
        Me.cPMode.Name = "cPMode"
        Me.cPMode.ReadOnly = True
        '
        'DtItemPelunasanBindingSource
        '
        Me.DtItemPelunasanBindingSource.DataMember = "dtItemPelunasan"
        Me.DtItemPelunasanBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(427, 504)
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
        Me.pnlBtnHeader.Location = New System.Drawing.Point(17, 505)
        Me.pnlBtnHeader.Name = "pnlBtnHeader"
        Me.pnlBtnHeader.Size = New System.Drawing.Size(397, 49)
        Me.pnlBtnHeader.TabIndex = 97
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(582, 504)
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
        Me.btnSave.Location = New System.Drawing.Point(506, 504)
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
        Me.btnExit.Location = New System.Drawing.Point(663, 505)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'DaItemPelunasan
        '
        Me.DaItemPelunasan.ClearBeforeFill = True
        '
        'frmPelunasanHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1012, 616)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.pnlBtnHeader)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpTglPelunasan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtKodePelunasan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPelunasanHutang"
        Me.Text = "Pelunasan Hutang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlBtnDetail.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtItemPelunasanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtKodePelunasan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKodeSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTglPelunasan As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFindSupplier As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFindPembelian As System.Windows.Forms.Button
    Friend WithEvents txtKodePembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnlBtnHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DtItemPelunasanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaItemPelunasan As EJM.dsTransTableAdapters.daItemPelunasan
    Friend WithEvents lblTglJatuhTempo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTglBeli As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalHutang As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cKodePembelian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTglPembelian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTglJatuhTempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalHutang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalDibayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPMode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlBtnDetail As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents btnCancelItem As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
