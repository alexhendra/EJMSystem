<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInisialisasiStokAwal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInisialisasiStokAwal))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStokAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtInisialisasiStokAwalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.pnlButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DaInisialisasiStokAwal = New EJM.dsTransTableAdapters.daInisialisasiStokAwal()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtInisialisasiStokAwalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeBarang, Me.cNamaBarang, Me.cUOMName, Me.cStokAwal, Me.cUOMId})
        Me.dgv.DataSource = Me.DtInisialisasiStokAwalBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(2, 153)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(907, 286)
        Me.dgv.TabIndex = 41
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
        Me.cUOMName.DataPropertyName = "uomName"
        Me.cUOMName.HeaderText = "UOM"
        Me.cUOMName.Name = "cUOMName"
        Me.cUOMName.ReadOnly = True
        '
        'cStokAwal
        '
        Me.cStokAwal.DataPropertyName = "SisaStok"
        Me.cStokAwal.HeaderText = "Stok Awal"
        Me.cStokAwal.Name = "cStokAwal"
        Me.cStokAwal.ReadOnly = True
        '
        'cUOMId
        '
        Me.cUOMId.DataPropertyName = "UOM"
        Me.cUOMId.HeaderText = "UOM"
        Me.cUOMId.Name = "cUOMId"
        Me.cUOMId.ReadOnly = True
        Me.cUOMId.Visible = False
        '
        'DtInisialisasiStokAwalBindingSource
        '
        Me.DtInisialisasiStokAwalBindingSource.DataMember = "dtInisialisasiStokAwal"
        Me.DtInisialisasiStokAwalBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlButton
        '
        Me.pnlButton.Controls.Add(Me.btnPreview)
        Me.pnlButton.Location = New System.Drawing.Point(12, 74)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(396, 38)
        Me.pnlButton.TabIndex = 44
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
        Me.btnExit.Location = New System.Drawing.Point(499, 74)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 29)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "* Klik pada kolom Stok Awal dan tekan F2 pada keyboard untuk menginput data"
        '
        'DaInisialisasiStokAwal
        '
        Me.DaInisialisasiStokAwal.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(420, 74)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 29)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(910, 62)
        Me.Panel1.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(623, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(276, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Digunakan untuk menginput stok awal pada barang baru"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(756, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Inisialisasi Stok Awal"
        '
        'frmInisialisasiStokAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(910, 442)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlButton)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInisialisasiStokAwal"
        Me.Text = "Inisialisai Stok Awal"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtInisialisasiStokAwalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents cHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSisaStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlButton As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DtInisialisasiStokAwalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaInisialisasiStokAwal As EJM.dsTransTableAdapters.daInisialisasiStokAwal
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStokAwal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
