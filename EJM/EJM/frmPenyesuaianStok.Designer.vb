<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenyesuaianStok
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPenyesuaianStok))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cTglTrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStokSekarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPenyesuaian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtDataPenyesuaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTrans = New System.Windows.Forms.DateTimePicker()
        Me.DaDataPenyesuaian = New EJM.dsTransTableAdapters.daDataPenyesuaian()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnPrintForm = New System.Windows.Forms.Button()
        Me.lblStatusLock = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDataPenyesuaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTglTrans, Me.cKodeBarang, Me.cNamaBarang, Me.cUOMId, Me.cUOMName, Me.cStokSekarang, Me.cPenyesuaian})
        Me.dgv.DataSource = Me.DtDataPenyesuaianBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(2, 199)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1002, 246)
        Me.dgv.TabIndex = 41
        '
        'cTglTrans
        '
        Me.cTglTrans.DataPropertyName = "TglTrans"
        Me.cTglTrans.HeaderText = "Tgl. Transaksi"
        Me.cTglTrans.Name = "cTglTrans"
        Me.cTglTrans.ReadOnly = True
        '
        'cKodeBarang
        '
        Me.cKodeBarang.DataPropertyName = "KodeBarang"
        Me.cKodeBarang.HeaderText = "Kode Barang"
        Me.cKodeBarang.Name = "cKodeBarang"
        Me.cKodeBarang.ReadOnly = True
        '
        'cNamaBarang
        '
        Me.cNamaBarang.DataPropertyName = "NamaBarang"
        Me.cNamaBarang.HeaderText = "Nama Barang"
        Me.cNamaBarang.Name = "cNamaBarang"
        Me.cNamaBarang.ReadOnly = True
        '
        'cUOMId
        '
        Me.cUOMId.DataPropertyName = "UomID"
        Me.cUOMId.HeaderText = "UomID"
        Me.cUOMId.Name = "cUOMId"
        Me.cUOMId.ReadOnly = True
        Me.cUOMId.Visible = False
        '
        'cUOMName
        '
        Me.cUOMName.DataPropertyName = "UomName"
        Me.cUOMName.HeaderText = "UOM"
        Me.cUOMName.Name = "cUOMName"
        Me.cUOMName.ReadOnly = True
        '
        'cStokSekarang
        '
        Me.cStokSekarang.DataPropertyName = "StokSekarang"
        Me.cStokSekarang.HeaderText = "Stok Actual"
        Me.cStokSekarang.Name = "cStokSekarang"
        Me.cStokSekarang.ReadOnly = True
        '
        'cPenyesuaian
        '
        Me.cPenyesuaian.DataPropertyName = "Penyesuaian"
        Me.cPenyesuaian.HeaderText = "Penyesuaian"
        Me.cPenyesuaian.Name = "cPenyesuaian"
        Me.cPenyesuaian.ReadOnly = True
        '
        'DtDataPenyesuaianBindingSource
        '
        Me.DtDataPenyesuaianBindingSource.DataMember = "dtDataPenyesuaian"
        Me.DtDataPenyesuaianBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(592, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Filter berdasarkan"
        '
        'cboFind
        '
        Me.cboFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFind.BackColor = System.Drawing.Color.White
        Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFind.Location = New System.Drawing.Point(692, 171)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.BackColor = System.Drawing.Color.LightYellow
        Me.txtFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(810, 171)
        Me.txtFind.MaxLength = 10
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(188, 20)
        Me.txtFind.TabIndex = 45
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(358, 113)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 29)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'pnlButton
        '
        Me.pnlButton.Controls.Add(Me.btnPreview)
        Me.pnlButton.Location = New System.Drawing.Point(13, 113)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(338, 38)
        Me.pnlButton.TabIndex = 48
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(3, 3)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 29)
        Me.btnPreview.TabIndex = 41
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        Me.btnPreview.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(437, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 29)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "* Klik pada kolom Penyesuaian dan tekan F2 pada keyboard untuk menginput data"
        '
        'dtpTrans
        '
        Me.dtpTrans.CustomFormat = "MM/dd/yyyy"
        Me.dtpTrans.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTrans.Location = New System.Drawing.Point(93, 73)
        Me.dtpTrans.Name = "dtpTrans"
        Me.dtpTrans.Size = New System.Drawing.Size(108, 20)
        Me.dtpTrans.TabIndex = 51
        '
        'DaDataPenyesuaian
        '
        Me.DaDataPenyesuaian.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Tgl. Transaksi"
        '
        'btnLock
        '
        Me.btnLock.Location = New System.Drawing.Point(231, 67)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(75, 29)
        Me.btnLock.TabIndex = 53
        Me.btnLock.Tag = "lock"
        Me.btnLock.Text = "Lock Data"
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'btnPrintForm
        '
        Me.btnPrintForm.Location = New System.Drawing.Point(327, 67)
        Me.btnPrintForm.Name = "btnPrintForm"
        Me.btnPrintForm.Size = New System.Drawing.Size(152, 29)
        Me.btnPrintForm.TabIndex = 54
        Me.btnPrintForm.Text = "Print Form Stok Opname"
        Me.btnPrintForm.UseVisualStyleBackColor = True
        '
        'lblStatusLock
        '
        Me.lblStatusLock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusLock.AutoSize = True
        Me.lblStatusLock.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatusLock.ForeColor = System.Drawing.Color.Red
        Me.lblStatusLock.Location = New System.Drawing.Point(569, 19)
        Me.lblStatusLock.Name = "lblStatusLock"
        Me.lblStatusLock.Size = New System.Drawing.Size(0, 19)
        Me.lblStatusLock.TabIndex = 91
        Me.lblStatusLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblStatusLock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 62)
        Me.Panel1.TabIndex = 92
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(13, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Penyesuaian Stok"
        '
        'frmPenyesuaianStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1005, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPrintForm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.dtpTrans)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlButton)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboFind)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPenyesuaianStok"
        Me.Text = "Penyesuaian Stok"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDataPenyesuaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboFind As System.Windows.Forms.ComboBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents cHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSisaStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pnlButton As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTrans As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtDataPenyesuaianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaDataPenyesuaian As EJM.dsTransTableAdapters.daDataPenyesuaian
    Friend WithEvents cTglTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStokSekarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPenyesuaian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnPrintForm As System.Windows.Forms.Button
    Friend WithEvents lblStatusLock As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
