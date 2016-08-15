<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClosing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClosing))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTrans = New System.Windows.Forms.DateTimePicker()
        Me.btnClosing = New System.Windows.Forms.Button()
        Me.btnUnclosing = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cTanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStokAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPenerimaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStokAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtPreviewStokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.DaPreviewStok = New EJM.dsTransTableAdapters.daPreviewStok()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTglLastClosing = New System.Windows.Forms.Label()
        Me.lblStatusClosing = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnlButton.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtPreviewStokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tgl. Closing / Unclosing"
        '
        'dtpTrans
        '
        Me.dtpTrans.CustomFormat = "MM/dd/yyyy"
        Me.dtpTrans.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTrans.Location = New System.Drawing.Point(142, 86)
        Me.dtpTrans.Name = "dtpTrans"
        Me.dtpTrans.Size = New System.Drawing.Size(109, 20)
        Me.dtpTrans.TabIndex = 3
        Me.dtpTrans.Value = New Date(2016, 7, 23, 0, 0, 0, 0)
        '
        'btnClosing
        '
        Me.btnClosing.Location = New System.Drawing.Point(413, 131)
        Me.btnClosing.Name = "btnClosing"
        Me.btnClosing.Size = New System.Drawing.Size(75, 29)
        Me.btnClosing.TabIndex = 6
        Me.btnClosing.Text = "Closing"
        Me.btnClosing.UseVisualStyleBackColor = True
        Me.btnClosing.Visible = False
        '
        'btnUnclosing
        '
        Me.btnUnclosing.Location = New System.Drawing.Point(494, 131)
        Me.btnUnclosing.Name = "btnUnclosing"
        Me.btnUnclosing.Size = New System.Drawing.Size(75, 29)
        Me.btnUnclosing.TabIndex = 7
        Me.btnUnclosing.Text = "Unclosing"
        Me.btnUnclosing.UseVisualStyleBackColor = True
        Me.btnUnclosing.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(575, 131)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 29)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'pnlButton
        '
        Me.pnlButton.Controls.Add(Me.btnPreview)
        Me.pnlButton.Location = New System.Drawing.Point(7, 131)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(396, 37)
        Me.pnlButton.TabIndex = 40
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTanggal, Me.cKodeBarang, Me.cNamaBarang, Me.cUOM, Me.cStokAwal, Me.cPenerimaan, Me.cPenjualan, Me.cStokAkhir})
        Me.dgv.DataSource = Me.DtPreviewStokBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(7, 179)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1034, 289)
        Me.dgv.TabIndex = 42
        '
        'cTanggal
        '
        Me.cTanggal.DataPropertyName = "Tanggal"
        Me.cTanggal.HeaderText = "Tanggal"
        Me.cTanggal.Name = "cTanggal"
        Me.cTanggal.ReadOnly = True
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
        'cUOM
        '
        Me.cUOM.DataPropertyName = "UomName"
        Me.cUOM.HeaderText = "UOM"
        Me.cUOM.Name = "cUOM"
        Me.cUOM.ReadOnly = True
        '
        'cStokAwal
        '
        Me.cStokAwal.DataPropertyName = "StokAwal"
        Me.cStokAwal.HeaderText = "Stok Awal"
        Me.cStokAwal.Name = "cStokAwal"
        Me.cStokAwal.ReadOnly = True
        '
        'cPenerimaan
        '
        Me.cPenerimaan.DataPropertyName = "Penerimaan"
        Me.cPenerimaan.HeaderText = "Penerimaan"
        Me.cPenerimaan.Name = "cPenerimaan"
        Me.cPenerimaan.ReadOnly = True
        '
        'cPenjualan
        '
        Me.cPenjualan.DataPropertyName = "Penjualan"
        Me.cPenjualan.HeaderText = "Penjualan"
        Me.cPenjualan.Name = "cPenjualan"
        Me.cPenjualan.ReadOnly = True
        '
        'cStokAkhir
        '
        Me.cStokAkhir.DataPropertyName = "StokAkhir"
        Me.cStokAkhir.HeaderText = "Stok Akhir"
        Me.cStokAkhir.Name = "cStokAkhir"
        Me.cStokAkhir.ReadOnly = True
        '
        'DtPreviewStokBindingSource
        '
        Me.DtPreviewStokBindingSource.DataMember = "dtPreviewStok"
        Me.DtPreviewStokBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DaPreviewStok
        '
        Me.DaPreviewStok.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Tgl. Closing Terakhir"
        '
        'lblTglLastClosing
        '
        Me.lblTglLastClosing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTglLastClosing.Location = New System.Drawing.Point(491, 80)
        Me.lblTglLastClosing.Name = "lblTglLastClosing"
        Me.lblTglLastClosing.Size = New System.Drawing.Size(163, 24)
        Me.lblTglLastClosing.TabIndex = 44
        Me.lblTglLastClosing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatusClosing
        '
        Me.lblStatusClosing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusClosing.AutoSize = True
        Me.lblStatusClosing.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatusClosing.ForeColor = System.Drawing.Color.Red
        Me.lblStatusClosing.Location = New System.Drawing.Point(571, 19)
        Me.lblStatusClosing.Name = "lblStatusClosing"
        Me.lblStatusClosing.Size = New System.Drawing.Size(0, 19)
        Me.lblStatusClosing.TabIndex = 90
        Me.lblStatusClosing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblStatusClosing)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 62)
        Me.Panel1.TabIndex = 91
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(12, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Closing / Unclosing Stok"
        '
        'frmClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1047, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTglLastClosing)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.pnlButton)
        Me.Controls.Add(Me.dtpTrans)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUnclosing)
        Me.Controls.Add(Me.btnClosing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmClosing"
        Me.Text = "Closing / Unclosing Stok"
        Me.pnlButton.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtPreviewStokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTrans As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClosing As System.Windows.Forms.Button
    Friend WithEvents btnUnclosing As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlButton As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents cTanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStokAwal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPenerimaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPenjualan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStokAkhir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtPreviewStokBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaPreviewStok As EJM.dsTransTableAdapters.daPreviewStok
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTglLastClosing As System.Windows.Forms.Label
    Friend WithEvents lblStatusClosing As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
