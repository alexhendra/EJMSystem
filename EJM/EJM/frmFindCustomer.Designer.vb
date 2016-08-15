<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindCustomer
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
        Me.cKodeCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNamaCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAlamatCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTelpCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DtCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.DaCustomer = New EJM.dsTransTableAdapters.daCustomer()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKodeCustomer, Me.cNamaCustomer, Me.cAlamatCustomer, Me.cTelpCustomer, Me.cActive})
        Me.dgv.DataSource = Me.DtCustomerBindingSource
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
        Me.dgv.Size = New System.Drawing.Size(847, 399)
        Me.dgv.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Filter berdasarkan"
        '
        'cboFind
        '
        Me.cboFind.BackColor = System.Drawing.Color.White
        Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFind.Location = New System.Drawing.Point(106, 13)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.Color.LightYellow
        Me.txtFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(224, 13)
        Me.txtFind.MaxLength = 10
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(114, 20)
        Me.txtFind.TabIndex = 45
        '
        'cKodeCustomer
        '
        Me.cKodeCustomer.DataPropertyName = "Kode_Customer"
        Me.cKodeCustomer.HeaderText = "Kode"
        Me.cKodeCustomer.Name = "cKodeCustomer"
        Me.cKodeCustomer.ReadOnly = True
        '
        'cNamaCustomer
        '
        Me.cNamaCustomer.DataPropertyName = "Nama_Customer"
        Me.cNamaCustomer.HeaderText = "Nama"
        Me.cNamaCustomer.Name = "cNamaCustomer"
        Me.cNamaCustomer.ReadOnly = True
        '
        'cAlamatCustomer
        '
        Me.cAlamatCustomer.DataPropertyName = "Alamat_Customer"
        Me.cAlamatCustomer.HeaderText = "Alamat"
        Me.cAlamatCustomer.Name = "cAlamatCustomer"
        Me.cAlamatCustomer.ReadOnly = True
        '
        'cTelpCustomer
        '
        Me.cTelpCustomer.DataPropertyName = "Telp_Customer"
        Me.cTelpCustomer.HeaderText = "Telp."
        Me.cTelpCustomer.Name = "cTelpCustomer"
        Me.cTelpCustomer.ReadOnly = True
        '
        'cActive
        '
        Me.cActive.DataPropertyName = "Active"
        Me.cActive.HeaderText = "Active"
        Me.cActive.Name = "cActive"
        Me.cActive.ReadOnly = True
        '
        'DtCustomerBindingSource
        '
        Me.DtCustomerBindingSource.DataMember = "dtCustomer"
        Me.DtCustomerBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DaCustomer
        '
        Me.DaCustomer.ClearBeforeFill = True
        '
        'frmFindCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(850, 442)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboFind)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Customer"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DtCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaCustomer As EJM.dsTransTableAdapters.daCustomer
    Friend WithEvents cKodeCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNamaCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAlamatCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTelpCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cActive As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
