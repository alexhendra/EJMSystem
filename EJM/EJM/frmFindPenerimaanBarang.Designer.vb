<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindPenerimaanBarang
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.DsTrans = New EJM.dsTrans()
        Me.DtFindBarangPenerimaanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaFindBarangPenerimaan = New EJM.dsTransTableAdapters.daFindBarangPenerimaan()
        Me.cKodeTerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNoPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlahTerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFindBarangPenerimaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeTerima, Me.cNoPesanan, Me.cKodeBarang, Me.cNamaBarang, Me.cUOM, Me.cJumlahPesanan, Me.cJumlahTerima})
        Me.dgv.DataSource = Me.DtFindBarangPenerimaanBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(2, 46)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1069, 399)
        Me.dgv.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(4, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Filter berdasarkan"
        '
        'cboFind
        '
        Me.cboFind.BackColor = System.Drawing.Color.White
        Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFind.Location = New System.Drawing.Point(104, 12)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.Color.LightYellow
        Me.txtFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(222, 12)
        Me.txtFind.MaxLength = 10
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(114, 20)
        Me.txtFind.TabIndex = 45
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtFindBarangPenerimaanBindingSource
        '
        Me.DtFindBarangPenerimaanBindingSource.DataMember = "dtFindBarangPenerimaan"
        Me.DtFindBarangPenerimaanBindingSource.DataSource = Me.DsTrans
        '
        'DaFindBarangPenerimaan
        '
        Me.DaFindBarangPenerimaan.ClearBeforeFill = True
        '
        'cKodeTerima
        '
        Me.cKodeTerima.DataPropertyName = "Kode_Penerimaan"
        Me.cKodeTerima.HeaderText = "Kode Penerimaan"
        Me.cKodeTerima.Name = "cKodeTerima"
        Me.cKodeTerima.ReadOnly = True
        '
        'cNoPesanan
        '
        Me.cNoPesanan.DataPropertyName = "No_Pesanan"
        Me.cNoPesanan.HeaderText = "No. Pesanan"
        Me.cNoPesanan.Name = "cNoPesanan"
        Me.cNoPesanan.ReadOnly = True
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
        'cUOM
        '
        Me.cUOM.DataPropertyName = "UomName"
        Me.cUOM.HeaderText = "UOM"
        Me.cUOM.Name = "cUOM"
        Me.cUOM.ReadOnly = True
        '
        'cJumlahPesanan
        '
        Me.cJumlahPesanan.DataPropertyName = "JumlahPesanan"
        Me.cJumlahPesanan.HeaderText = "Jlh. Pesanan"
        Me.cJumlahPesanan.Name = "cJumlahPesanan"
        Me.cJumlahPesanan.ReadOnly = True
        '
        'cJumlahTerima
        '
        Me.cJumlahTerima.DataPropertyName = "JumlahTerima"
        Me.cJumlahTerima.HeaderText = "Jlh. Terima"
        Me.cJumlahTerima.Name = "cJumlahTerima"
        Me.cJumlahTerima.ReadOnly = True
        '
        'frmFindPenerimaanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1072, 442)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboFind)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindPenerimaanBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Barang"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFindBarangPenerimaanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboFind As System.Windows.Forms.ComboBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents cKodePenerimaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeTerima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNoPesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahPesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJumlahTerima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtFindBarangPenerimaanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaFindBarangPenerimaan As EJM.dsTransTableAdapters.daFindBarangPenerimaan
End Class
