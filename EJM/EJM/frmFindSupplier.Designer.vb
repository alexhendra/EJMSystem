<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindSupplier
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.cKodeSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAlamatSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTelpSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DtSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.DaSupplier = New EJM.dsTransTableAdapters.daSupplier()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(12, 25)
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
        Me.cboFind.Location = New System.Drawing.Point(109, 22)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.BackColor = System.Drawing.Color.LightYellow
        Me.txtFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(227, 22)
        Me.txtFind.MaxLength = 10
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(114, 20)
        Me.txtFind.TabIndex = 45
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSupplier.AutoGenerateColumns = False
        Me.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSupplier.BackgroundColor = System.Drawing.Color.White
        Me.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeSupplier, Me.cNamaSupplier, Me.cAlamatSupplier, Me.cTelpSupplier, Me.cActive})
        Me.dgvSupplier.DataSource = Me.DtSupplierBindingSource
        Me.dgvSupplier.GridColor = System.Drawing.Color.LightGray
        Me.dgvSupplier.Location = New System.Drawing.Point(3, 53)
        Me.dgvSupplier.MultiSelect = False
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSupplier.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplier.Size = New System.Drawing.Size(916, 351)
        Me.dgvSupplier.TabIndex = 45
        '
        'cKodeSupplier
        '
        Me.cKodeSupplier.DataPropertyName = "Kode_Supplier"
        Me.cKodeSupplier.HeaderText = "#"
        Me.cKodeSupplier.Name = "cKodeSupplier"
        Me.cKodeSupplier.ReadOnly = True
        '
        'cNamaSupplier
        '
        Me.cNamaSupplier.DataPropertyName = "Nama_Supplier"
        Me.cNamaSupplier.HeaderText = "Nama"
        Me.cNamaSupplier.Name = "cNamaSupplier"
        Me.cNamaSupplier.ReadOnly = True
        '
        'cAlamatSupplier
        '
        Me.cAlamatSupplier.DataPropertyName = "Alamat_Supplier"
        Me.cAlamatSupplier.HeaderText = "Alamat"
        Me.cAlamatSupplier.Name = "cAlamatSupplier"
        Me.cAlamatSupplier.ReadOnly = True
        '
        'cTelpSupplier
        '
        Me.cTelpSupplier.DataPropertyName = "Telp_Supplier"
        Me.cTelpSupplier.HeaderText = "Telp"
        Me.cTelpSupplier.Name = "cTelpSupplier"
        Me.cTelpSupplier.ReadOnly = True
        '
        'cActive
        '
        Me.cActive.DataPropertyName = "Active"
        Me.cActive.HeaderText = "Active"
        Me.cActive.Name = "cActive"
        Me.cActive.ReadOnly = True
        '
        'DtSupplierBindingSource
        '
        Me.DtSupplierBindingSource.DataMember = "dtSupplier"
        Me.DtSupplierBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DaSupplier
        '
        Me.DaSupplier.ClearBeforeFill = True
        '
        'frmFindSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(922, 406)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Controls.Add(Me.cboFind)
        Me.Controls.Add(Me.txtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFindSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Supplier"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboFind As System.Windows.Forms.ComboBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents dgvSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DtSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaSupplier As EJM.dsTransTableAdapters.daSupplier
    Friend WithEvents cKodeSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAlamatSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTelpSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cActive As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
