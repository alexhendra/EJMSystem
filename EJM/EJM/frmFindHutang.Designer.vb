<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindHutang
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.DsTrans = New EJM.dsTrans()
        Me.DtFindPembelianHutangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaFindPembelianHutang = New EJM.dsTransTableAdapters.daFindPembelianHutang()
        Me.cKodePembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTglBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTglJatuhTempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalHutang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFindPembelianHutangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodePembelian, Me.cKodeSupplier, Me.cNamaSupplier, Me.cTglBeli, Me.cTglJatuhTempo, Me.cTotalHutang, Me.cTotalBayar})
        Me.dgv.DataSource = Me.DtFindPembelianHutangBindingSource
        Me.dgv.GridColor = System.Drawing.Color.LightGray
        Me.dgv.Location = New System.Drawing.Point(2, 46)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1069, 399)
        Me.dgv.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.cboFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFind.BackColor = System.Drawing.Color.White
        Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFind.Location = New System.Drawing.Point(104, 12)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'DtFindPembelianHutangBindingSource
        '
        Me.DtFindPembelianHutangBindingSource.DataMember = "dtFindPembelianHutang"
        Me.DtFindPembelianHutangBindingSource.DataSource = Me.DsTrans
        '
        'DaFindPembelianHutang
        '
        Me.DaFindPembelianHutang.ClearBeforeFill = True
        '
        'cKodePembelian
        '
        Me.cKodePembelian.DataPropertyName = "Kode_Pembelian"
        Me.cKodePembelian.HeaderText = "Kode Pembelian"
        Me.cKodePembelian.Name = "cKodePembelian"
        Me.cKodePembelian.ReadOnly = True
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
        'cTglBeli
        '
        Me.cTglBeli.DataPropertyName = "Tgl_Beli"
        DataGridViewCellStyle1.Format = "MM/dd/yyyy"
        Me.cTglBeli.DefaultCellStyle = DataGridViewCellStyle1
        Me.cTglBeli.HeaderText = "Tgl. Pembelian"
        Me.cTglBeli.Name = "cTglBeli"
        Me.cTglBeli.ReadOnly = True
        '
        'cTglJatuhTempo
        '
        Me.cTglJatuhTempo.DataPropertyName = "Tgl_Jatuh_Tempo"
        DataGridViewCellStyle2.Format = "MM/dd/yyyy"
        Me.cTglJatuhTempo.DefaultCellStyle = DataGridViewCellStyle2
        Me.cTglJatuhTempo.HeaderText = "Tgl. Jatuh Tempo"
        Me.cTglJatuhTempo.Name = "cTglJatuhTempo"
        Me.cTglJatuhTempo.ReadOnly = True
        '
        'cTotalHutang
        '
        Me.cTotalHutang.DataPropertyName = "TotalHutang"
        DataGridViewCellStyle3.Format = "###0"
        Me.cTotalHutang.DefaultCellStyle = DataGridViewCellStyle3
        Me.cTotalHutang.HeaderText = "Total Hutang"
        Me.cTotalHutang.Name = "cTotalHutang"
        Me.cTotalHutang.ReadOnly = True
        '
        'cTotalBayar
        '
        Me.cTotalBayar.DataPropertyName = "TotalBayar"
        DataGridViewCellStyle4.Format = "###0"
        Me.cTotalBayar.DefaultCellStyle = DataGridViewCellStyle4
        Me.cTotalBayar.HeaderText = "Total Bayar"
        Me.cTotalBayar.Name = "cTotalBayar"
        Me.cTotalBayar.ReadOnly = True
        '
        'frmFindHutang
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
        Me.Name = "frmFindHutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Pembelian"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFindPembelianHutangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboFind As System.Windows.Forms.ComboBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents cKodePembelian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTglBeli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTglJatuhTempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalHutang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalBayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtFindPembelianHutangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DaFindPembelianHutang As EJM.dsTransTableAdapters.daFindPembelianHutang
End Class
