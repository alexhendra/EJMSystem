<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStokSekarang
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStokSekarang))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cTglStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStokLama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahTerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahRetur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahJual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStokAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtStokSekarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.DaStokSekarang = New EJM.dsTransTableAdapters.daStokSekarang()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtStokSekarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTglStok, Me.cKodeBarang, Me.cNamaBarang, Me.cUOMId, Me.cUOMName, Me.cStokLama, Me.cJumlahTerima, Me.cJumlahRetur, Me.cJumlahJual, Me.cStokAkhir})
        Me.dgv.DataSource = Me.DtStokSekarangBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(2, 122)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(928, 323)
        Me.dgv.TabIndex = 41
        '
        'cTglStok
        '
        Me.cTglStok.DataPropertyName = "TglStok"
        Me.cTglStok.HeaderText = "Tgl. Stok"
        Me.cTglStok.Name = "cTglStok"
        Me.cTglStok.ReadOnly = True
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
        'cStokLama
        '
        Me.cStokLama.DataPropertyName = "StokLama"
        Me.cStokLama.HeaderText = "Stok Awal"
        Me.cStokLama.Name = "cStokLama"
        Me.cStokLama.ReadOnly = True
        '
        'cJumlahTerima
        '
        Me.cJumlahTerima.DataPropertyName = "JumlahTerima"
        Me.cJumlahTerima.HeaderText = "Jlh. Penerimaan"
        Me.cJumlahTerima.Name = "cJumlahTerima"
        Me.cJumlahTerima.ReadOnly = True
        '
        'cJumlahRetur
        '
        Me.cJumlahRetur.DataPropertyName = "JumlahRetur"
        Me.cJumlahRetur.HeaderText = "Jlh. Retur"
        Me.cJumlahRetur.Name = "cJumlahRetur"
        Me.cJumlahRetur.ReadOnly = True
        '
        'cJumlahJual
        '
        Me.cJumlahJual.DataPropertyName = "JumlahJual"
        Me.cJumlahJual.HeaderText = "Jlh. Penjualan"
        Me.cJumlahJual.Name = "cJumlahJual"
        Me.cJumlahJual.ReadOnly = True
        '
        'cStokAkhir
        '
        Me.cStokAkhir.DataPropertyName = "SisaStok"
        Me.cStokAkhir.HeaderText = "Stok Akhir"
        Me.cStokAkhir.Name = "cStokAkhir"
        Me.cStokAkhir.ReadOnly = True
        '
        'DtStokSekarangBindingSource
        '
        Me.DtStokSekarangBindingSource.DataMember = "dtStokSekarang"
        Me.DtStokSekarangBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(7, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Filter berdasarkan"
        '
        'cboFind
        '
        Me.cboFind.BackColor = System.Drawing.Color.White
        Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFind.Location = New System.Drawing.Point(107, 85)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.Color.LightYellow
        Me.txtFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(225, 85)
        Me.txtFind.MaxLength = 10
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(188, 20)
        Me.txtFind.TabIndex = 45
        '
        'DaStokSekarang
        '
        Me.DaStokSekarang.ClearBeforeFill = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(456, 78)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 30)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 62)
        Me.Panel1.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(751, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "List stok barang yang ada sekarang"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(787, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Stok Barang Saat Ini"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmStokSekarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(931, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboFind)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmStokSekarang"
        Me.Text = "Daftar Stok Barang"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtStokSekarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DtStokSekarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaStokSekarang As EJM.dsTransTableAdapters.daStokSekarang
    Friend WithEvents cTglStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStokLama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahTerima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahRetur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahJual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStokAkhir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
