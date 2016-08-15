<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindPenerimaanAll
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
        Me.dgvFind = New System.Windows.Forms.DataGridView()
        Me.cKodeTerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNoPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTglPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKodeSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtFindPenerimaanAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.DaFindPenerimaanAll = New EJM.dsTransTableAdapters.daFindPenerimaanAll()
        CType(Me.dgvFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFindPenerimaanAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFind
        '
        Me.dgvFind.AllowUserToAddRows = False
        Me.dgvFind.AllowUserToDeleteRows = False
        Me.dgvFind.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFind.AutoGenerateColumns = False
        Me.dgvFind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFind.BackgroundColor = System.Drawing.Color.White
        Me.dgvFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFind.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeTerima, Me.cNoPesanan, Me.cTglPesanan, Me.cKodeSupplier, Me.cNamaSupplier})
        Me.dgvFind.DataSource = Me.DtFindPenerimaanAllBindingSource
        Me.dgvFind.GridColor = System.Drawing.Color.LightGray
        Me.dgvFind.Location = New System.Drawing.Point(2, 46)
        Me.dgvFind.MultiSelect = False
        Me.dgvFind.Name = "dgvFind"
        Me.dgvFind.ReadOnly = True
        Me.dgvFind.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFind.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFind.Size = New System.Drawing.Size(1066, 399)
        Me.dgvFind.TabIndex = 41
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
        'cTglPesanan
        '
        Me.cTglPesanan.DataPropertyName = "Tgl_Pesanan"
        Me.cTglPesanan.HeaderText = "Tgl. Pesanan"
        Me.cTglPesanan.Name = "cTglPesanan"
        Me.cTglPesanan.ReadOnly = True
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
        'DtFindPenerimaanAllBindingSource
        '
        Me.DtFindPenerimaanAllBindingSource.DataMember = "dtFindPenerimaanAll"
        Me.DtFindPenerimaanAllBindingSource.DataSource = Me.DsTrans
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
        Me.Label7.Location = New System.Drawing.Point(10, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Filter berdasarkan"
        '
        'cboFind
        '
        Me.cboFind.BackColor = System.Drawing.Color.White
        Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFind.Location = New System.Drawing.Point(110, 13)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.Color.LightYellow
        Me.txtFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(228, 13)
        Me.txtFind.MaxLength = 10
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(114, 20)
        Me.txtFind.TabIndex = 45
        '
        'DaFindPenerimaanAll
        '
        Me.DaFindPenerimaanAll.ClearBeforeFill = True
        '
        'frmFindPenerimaanAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1069, 442)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboFind)
        Me.Controls.Add(Me.dgvFind)
        Me.Controls.Add(Me.txtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindPenerimaanAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Penerimaan"
        CType(Me.dgvFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFindPenerimaanAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvFind As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboFind As System.Windows.Forms.ComboBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents cHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSisaStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodePenerimaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DtFindPenerimaanAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaFindPenerimaanAll As EJM.dsTransTableAdapters.daFindPenerimaanAll
    Friend WithEvents cKodeTerima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNoPesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTglPesanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKodeSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahReturDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
