<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturPembelian))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtKodePenerimaan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.btnFindBarang = New System.Windows.Forms.Button()
        Me.rtxAlasanRetur = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.btnCancelItem = New System.Windows.Forms.Button()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.pnlBtnDetail = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtJumlahRetur = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahRetur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAlasanRetur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtDataBarangReturBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTglPesanan = New System.Windows.Forms.Label()
        Me.lblNoPesanan = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblKodeSupplier = New System.Windows.Forms.Label()
        Me.lblNamaSupplier = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlBtnHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnFindPenerimaan = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpTglRetur = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtKodeRetur = New System.Windows.Forms.TextBox()
        Me.DaDataBarangRetur = New EJM.dsTransTableAdapters.daDataBarangRetur()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlBtnDetail.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDataBarangReturBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.pnlBtnHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKodePenerimaan
        '
        Me.txtKodePenerimaan.Enabled = False
        Me.txtKodePenerimaan.Location = New System.Drawing.Point(435, 69)
        Me.txtKodePenerimaan.MaxLength = 14
        Me.txtKodePenerimaan.Name = "txtKodePenerimaan"
        Me.txtKodePenerimaan.Size = New System.Drawing.Size(157, 20)
        Me.txtKodePenerimaan.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(333, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Kode Penerimaan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblWarning)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1310, 62)
        Me.Panel1.TabIndex = 62
        '
        'lblWarning
        '
        Me.lblWarning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(516, 19)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(0, 19)
        Me.lblWarning.TabIndex = 88
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(14, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Retur Pembelian"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox1.Controls.Add(Me.btnFindBarang)
        Me.GroupBox1.Controls.Add(Me.rtxAlasanRetur)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSaveItem)
        Me.GroupBox1.Controls.Add(Me.btnCancelItem)
        Me.GroupBox1.Controls.Add(Me.lblUOM)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.lblNamaBarang)
        Me.GroupBox1.Controls.Add(Me.pnlBtnDetail)
        Me.GroupBox1.Controls.Add(Me.txtJumlahRetur)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1295, 154)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info Barang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Enabled = False
        Me.txtKodeBarang.Location = New System.Drawing.Point(161, 18)
        Me.txtKodeBarang.MaxLength = 10
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(157, 20)
        Me.txtKodeBarang.TabIndex = 1
        '
        'btnFindBarang
        '
        Me.btnFindBarang.Enabled = False
        Me.btnFindBarang.Image = CType(resources.GetObject("btnFindBarang.Image"), System.Drawing.Image)
        Me.btnFindBarang.Location = New System.Drawing.Point(326, 16)
        Me.btnFindBarang.Name = "btnFindBarang"
        Me.btnFindBarang.Size = New System.Drawing.Size(43, 23)
        Me.btnFindBarang.TabIndex = 2
        Me.btnFindBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindBarang.UseVisualStyleBackColor = True
        '
        'rtxAlasanRetur
        '
        Me.rtxAlasanRetur.Enabled = False
        Me.rtxAlasanRetur.Location = New System.Drawing.Point(559, 45)
        Me.rtxAlasanRetur.Name = "rtxAlasanRetur"
        Me.rtxAlasanRetur.Size = New System.Drawing.Size(389, 85)
        Me.rtxAlasanRetur.TabIndex = 4
        Me.rtxAlasanRetur.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(437, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Alasan Retur"
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Image = CType(resources.GetObject("btnSaveItem.Image"), System.Drawing.Image)
        Me.btnSaveItem.Location = New System.Drawing.Point(210, 117)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(75, 31)
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
        Me.btnCancelItem.Location = New System.Drawing.Point(129, 118)
        Me.btnCancelItem.Name = "btnCancelItem"
        Me.btnCancelItem.Size = New System.Drawing.Size(75, 31)
        Me.btnCancelItem.TabIndex = 8
        Me.btnCancelItem.Text = "Batal"
        Me.btnCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelItem.UseVisualStyleBackColor = True
        Me.btnCancelItem.Visible = False
        '
        'lblUOM
        '
        Me.lblUOM.BackColor = System.Drawing.SystemColors.Control
        Me.lblUOM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUOM.Location = New System.Drawing.Point(966, 14)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(89, 23)
        Me.lblUOM.TabIndex = 81
        Me.lblUOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(291, 118)
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
        Me.lblNamaBarang.Location = New System.Drawing.Point(559, 15)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(233, 23)
        Me.lblNamaBarang.TabIndex = 80
        Me.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBtnDetail
        '
        Me.pnlBtnDetail.AutoSize = True
        Me.pnlBtnDetail.Controls.Add(Me.btnAdd)
        Me.pnlBtnDetail.Enabled = False
        Me.pnlBtnDetail.Location = New System.Drawing.Point(9, 78)
        Me.pnlBtnDetail.Name = "pnlBtnDetail"
        Me.pnlBtnDetail.Size = New System.Drawing.Size(376, 38)
        Me.pnlBtnDetail.TabIndex = 70
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
        'txtJumlahRetur
        '
        Me.txtJumlahRetur.Enabled = False
        Me.txtJumlahRetur.Location = New System.Drawing.Point(161, 45)
        Me.txtJumlahRetur.Name = "txtJumlahRetur"
        Me.txtJumlahRetur.Size = New System.Drawing.Size(112, 20)
        Me.txtJumlahRetur.TabIndex = 3
        Me.txtJumlahRetur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightCyan
        Me.Label10.Location = New System.Drawing.Point(32, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Jumlah Retur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(437, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Nama Barang"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(48, 118)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 31)
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
        Me.Label9.Location = New System.Drawing.Point(839, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "UOM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightCyan
        Me.Label8.Location = New System.Drawing.Point(32, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Kode Barang"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(1215, 451)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 39)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1212, 406)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 39)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1215, 495)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 39)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeBarang, Me.cNamaBarang, Me.cUOMName, Me.cJumlahRetur, Me.cAlasanRetur, Me.cPMode})
        Me.dgv.DataSource = Me.DtDataBarangReturBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(6, 335)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1197, 222)
        Me.dgv.TabIndex = 67
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
        'cJumlahRetur
        '
        Me.cJumlahRetur.DataPropertyName = "JumlahRetur"
        Me.cJumlahRetur.HeaderText = "Jumlah Retur"
        Me.cJumlahRetur.Name = "cJumlahRetur"
        Me.cJumlahRetur.ReadOnly = True
        '
        'cAlasanRetur
        '
        Me.cAlasanRetur.DataPropertyName = "Alasan_Retur"
        Me.cAlasanRetur.HeaderText = "Alasan Retur"
        Me.cAlasanRetur.Name = "cAlasanRetur"
        Me.cAlasanRetur.ReadOnly = True
        '
        'cPMode
        '
        Me.cPMode.DataPropertyName = "pMode"
        Me.cPMode.HeaderText = "pMode"
        Me.cPMode.Name = "cPMode"
        Me.cPMode.ReadOnly = True
        '
        'DtDataBarangReturBindingSource
        '
        Me.DtDataBarangReturBindingSource.DataMember = "dtDataBarangRetur"
        Me.DtDataBarangReturBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTglPesanan)
        Me.GroupBox2.Controls.Add(Me.lblNoPesanan)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblKodeSupplier)
        Me.GroupBox2.Controls.Add(Me.lblNamaSupplier)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1295, 76)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Detail"
        '
        'lblTglPesanan
        '
        Me.lblTglPesanan.BackColor = System.Drawing.SystemColors.Control
        Me.lblTglPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTglPesanan.Location = New System.Drawing.Point(559, 15)
        Me.lblTglPesanan.Name = "lblTglPesanan"
        Me.lblTglPesanan.Size = New System.Drawing.Size(146, 23)
        Me.lblTglPesanan.TabIndex = 93
        Me.lblTglPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoPesanan
        '
        Me.lblNoPesanan.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoPesanan.Location = New System.Drawing.Point(161, 18)
        Me.lblNoPesanan.Name = "lblNoPesanan"
        Me.lblNoPesanan.Size = New System.Drawing.Size(181, 23)
        Me.lblNoPesanan.TabIndex = 91
        Me.lblNoPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.LightCyan
        Me.Label12.Location = New System.Drawing.Point(31, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "No. Pesanan"
        '
        'lblKodeSupplier
        '
        Me.lblKodeSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.lblKodeSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKodeSupplier.Location = New System.Drawing.Point(161, 46)
        Me.lblKodeSupplier.Name = "lblKodeSupplier"
        Me.lblKodeSupplier.Size = New System.Drawing.Size(181, 23)
        Me.lblKodeSupplier.TabIndex = 89
        Me.lblKodeSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNamaSupplier
        '
        Me.lblNamaSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaSupplier.Location = New System.Drawing.Point(559, 45)
        Me.lblNamaSupplier.Name = "lblNamaSupplier"
        Me.lblNamaSupplier.Size = New System.Drawing.Size(318, 23)
        Me.lblNamaSupplier.TabIndex = 88
        Me.lblNamaSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightCyan
        Me.Label11.Location = New System.Drawing.Point(437, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(437, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Tgl. Pesanan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightCyan
        Me.Label6.Location = New System.Drawing.Point(31, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Kode Supplier"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(3, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(73, 39)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Baru"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'pnlBtnHeader
        '
        Me.pnlBtnHeader.AutoSize = True
        Me.pnlBtnHeader.Controls.Add(Me.btnNew)
        Me.pnlBtnHeader.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlBtnHeader.Location = New System.Drawing.Point(1212, 351)
        Me.pnlBtnHeader.Name = "pnlBtnHeader"
        Me.pnlBtnHeader.Size = New System.Drawing.Size(86, 53)
        Me.pnlBtnHeader.TabIndex = 87
        '
        'btnFindPenerimaan
        '
        Me.btnFindPenerimaan.Enabled = False
        Me.btnFindPenerimaan.Image = CType(resources.GetObject("btnFindPenerimaan.Image"), System.Drawing.Image)
        Me.btnFindPenerimaan.Location = New System.Drawing.Point(600, 67)
        Me.btnFindPenerimaan.Name = "btnFindPenerimaan"
        Me.btnFindPenerimaan.Size = New System.Drawing.Size(43, 23)
        Me.btnFindPenerimaan.TabIndex = 3
        Me.btnFindPenerimaan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindPenerimaan.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.LightCyan
        Me.Label24.Location = New System.Drawing.Point(681, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 13)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "Tgl. Retur"
        '
        'dtpTglRetur
        '
        Me.dtpTglRetur.CustomFormat = "MM/dd/yyyy"
        Me.dtpTglRetur.Enabled = False
        Me.dtpTglRetur.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglRetur.Location = New System.Drawing.Point(746, 69)
        Me.dtpTglRetur.Name = "dtpTglRetur"
        Me.dtpTglRetur.Size = New System.Drawing.Size(112, 20)
        Me.dtpTglRetur.TabIndex = 4
        Me.dtpTglRetur.Value = New Date(2016, 7, 21, 0, 0, 0, 0)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.LightCyan
        Me.Label25.Location = New System.Drawing.Point(39, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 93
        Me.Label25.Text = "Kode Retur"
        '
        'txtKodeRetur
        '
        Me.txtKodeRetur.Location = New System.Drawing.Point(124, 69)
        Me.txtKodeRetur.MaxLength = 14
        Me.txtKodeRetur.Name = "txtKodeRetur"
        Me.txtKodeRetur.Size = New System.Drawing.Size(157, 20)
        Me.txtKodeRetur.TabIndex = 1
        '
        'DaDataBarangRetur
        '
        Me.DaDataBarangRetur.ClearBeforeFill = True
        '
        'frmReturPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1310, 566)
        Me.Controls.Add(Me.txtKodeRetur)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.dtpTglRetur)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnFindPenerimaan)
        Me.Controls.Add(Me.pnlBtnHeader)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtKodePenerimaan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReturPembelian"
        Me.Text = "Pesanan Pembelian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlBtnDetail.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDataBarangReturBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlBtnHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKodePenerimaan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents lblNamaBarang As System.Windows.Forms.Label
    Friend WithEvents txtJumlahRetur As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancelItem As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents pnlBtnDetail As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnlBtnHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents btnFindPenerimaan As System.Windows.Forms.Button
    Friend WithEvents lblTglPesanan As System.Windows.Forms.Label
    Friend WithEvents lblNoPesanan As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblKodeSupplier As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtpTglRetur As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtKodeRetur As System.Windows.Forms.TextBox
    Friend WithEvents btnFindBarang As System.Windows.Forms.Button
    Friend WithEvents rtxAlasanRetur As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents DtDataBarangReturBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaDataBarangRetur As EJM.dsTransTableAdapters.daDataBarangRetur
    Friend WithEvents cKodePembelian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahRetur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAlasanRetur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPMode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
