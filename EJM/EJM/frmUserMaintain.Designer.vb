<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserMaintain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserMaintain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.DtRoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrans = New EJM.dsTrans()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pictUser = New System.Windows.Forms.PictureBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.DtUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.DaUser = New EJM.dsTransTableAdapters.daUser()
        Me.DaRole = New EJM.dsTransTableAdapters.daRole()
        Me.cUserId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cRoleDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAktif = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cRoleId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUserPass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtRoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID User"
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(125, 43)
        Me.txtUserName.MaxLength = 50
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(282, 20)
        Me.txtUserName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboFind)
        Me.Panel1.Controls.Add(Me.txtFind)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 62)
        Me.Panel1.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(578, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Filter berdasarkan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Data User"
        '
        'cboFind
        '
        Me.cboFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFind.BackColor = System.Drawing.Color.White
        Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFind.Location = New System.Drawing.Point(678, 21)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(112, 21)
        Me.cboFind.TabIndex = 44
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.BackColor = System.Drawing.Color.LightYellow
        Me.txtFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(796, 21)
        Me.txtFind.MaxLength = 10
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(114, 20)
        Me.txtFind.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboRole)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.pictUser)
        Me.GroupBox1.Controls.Add(Me.txtUserId)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.chkActive)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 321)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'cboRole
        '
        Me.cboRole.DataSource = Me.DtRoleBindingSource
        Me.cboRole.DisplayMember = "RoleDesc"
        Me.cboRole.Enabled = False
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(125, 69)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(186, 21)
        Me.cboRole.TabIndex = 3
        Me.cboRole.ValueMember = "RoleId"
        '
        'DtRoleBindingSource
        '
        Me.DtRoleBindingSource.DataMember = "dtRole"
        Me.DtRoleBindingSource.DataSource = Me.DsTrans
        '
        'DsTrans
        '
        Me.DsTrans.DataSetName = "dsTrans"
        Me.DsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightCyan
        Me.Label9.Location = New System.Drawing.Point(6, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Role"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightCyan
        Me.Label8.Location = New System.Drawing.Point(8, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Foto"
        '
        'pictUser
        '
        Me.pictUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictUser.Location = New System.Drawing.Point(126, 123)
        Me.pictUser.Name = "pictUser"
        Me.pictUser.Size = New System.Drawing.Size(169, 150)
        Me.pictUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictUser.TabIndex = 58
        Me.pictUser.TabStop = False
        '
        'txtUserId
        '
        Me.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserId.Enabled = False
        Me.txtUserId.Location = New System.Drawing.Point(125, 17)
        Me.txtUserId.MaxLength = 10
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(169, 20)
        Me.txtUserId.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(125, 96)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(169, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Enabled = False
        Me.chkActive.Location = New System.Drawing.Point(13, 290)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 55
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUser.AutoGenerateColumns = False
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.Color.White
        Me.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cUserId, Me.cUserName, Me.cRoleDesc, Me.cAktif, Me.cRoleId, Me.cUserPass})
        Me.dgvUser.DataSource = Me.DtUserBindingSource
        Me.dgvUser.GridColor = System.Drawing.Color.LightGray
        Me.dgvUser.Location = New System.Drawing.Point(447, 68)
        Me.dgvUser.MultiSelect = False
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUser.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.Size = New System.Drawing.Size(471, 529)
        Me.dgvUser.TabIndex = 45
        '
        'DtUserBindingSource
        '
        Me.DtUserBindingSource.DataMember = "dtUser"
        Me.DtUserBindingSource.DataSource = Me.DsTrans
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(320, 441)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'pnlButton
        '
        Me.pnlButton.Location = New System.Drawing.Point(4, 390)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(437, 47)
        Me.pnlButton.TabIndex = 54
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(161, 441)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 29)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(237, 441)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 29)
        Me.btnExit.TabIndex = 50
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(82, 441)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 29)
        Me.btnEdit.TabIndex = 53
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(4, 441)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 29)
        Me.btnNew.TabIndex = 52
        Me.btnNew.Text = "Baru"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'DaUser
        '
        Me.DaUser.ClearBeforeFill = True
        '
        'DaRole
        '
        Me.DaRole.ClearBeforeFill = True
        '
        'cUserId
        '
        Me.cUserId.DataPropertyName = "UserId"
        Me.cUserId.HeaderText = "User ID"
        Me.cUserId.Name = "cUserId"
        Me.cUserId.ReadOnly = True
        '
        'cUserName
        '
        Me.cUserName.DataPropertyName = "UserName"
        Me.cUserName.HeaderText = "User Name"
        Me.cUserName.Name = "cUserName"
        Me.cUserName.ReadOnly = True
        '
        'cRoleDesc
        '
        Me.cRoleDesc.DataPropertyName = "RoleDesc"
        Me.cRoleDesc.HeaderText = "Role"
        Me.cRoleDesc.Name = "cRoleDesc"
        Me.cRoleDesc.ReadOnly = True
        '
        'cAktif
        '
        Me.cAktif.DataPropertyName = "active"
        Me.cAktif.HeaderText = "Active"
        Me.cAktif.Name = "cAktif"
        Me.cAktif.ReadOnly = True
        '
        'cRoleId
        '
        Me.cRoleId.DataPropertyName = "RoleId"
        Me.cRoleId.HeaderText = "RoleId"
        Me.cRoleId.Name = "cRoleId"
        Me.cRoleId.ReadOnly = True
        Me.cRoleId.Visible = False
        '
        'cUserPass
        '
        Me.cUserPass.DataPropertyName = "UserPass"
        Me.cUserPass.HeaderText = "UserPass"
        Me.cUserPass.Name = "cUserPass"
        Me.cUserPass.ReadOnly = True
        Me.cUserPass.Visible = False
        '
        'frmUserMaintain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(922, 605)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlButton)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUserMaintain"
        Me.Text = "Data Supplier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtRoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboFind As System.Windows.Forms.ComboBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlButton As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pictUser As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DsTrans As EJM.dsTrans
    Friend WithEvents DtUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaUser As EJM.dsTransTableAdapters.daUser
    Friend WithEvents cActive As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtRoleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaRole As EJM.dsTransTableAdapters.daRole
    Friend WithEvents cUserId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRoleDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAktif As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cRoleId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUserPass As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
