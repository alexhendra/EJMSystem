Imports System.IO

Public Class frmUserMaintain
    Dim mode As String = String.Empty
    Dim con As New SqlConnection(My.Settings.EJMConString)
    Dim isChangedFoto As Boolean = False
    Dim _oldByteImage As Byte()

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeButton()
        GetDataUserAll()
        GetDataRole()
    End Sub

    Private Sub AddcboFind()
        cboFind.Items.Clear()
        cboFind.Items.Add("ID")    '0
        cboFind.Items.Add("Nama")    '1        
        cboFind.Items.Add("Role")    '2     
        cboFind.SelectedIndex = 0
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        With DtUserBindingSource
            Select Case cboFind.SelectedIndex
                Case 0
                    .Filter = "userId like '%" & txtFind.Text.Trim & "%'"
                Case 1
                    .Filter = "userName like '%" & txtFind.Text.Trim & "%'"
                Case 2
                    .Filter = "RoleDesc like '%" & txtFind.Text.Trim & "%'"
            End Select
        End With
    End Sub

    Private Sub activeButton()
        pnlButton.Controls.Clear()
        If mode = "new" Then
            pnlButton.Controls.Add(btnSave)
            pnlButton.Controls.Add(btnCancel)
            pnlButton.Controls.Add(btnExit)
        ElseIf mode = "edit" Then
            pnlButton.Controls.Add(btnEdit)
            pnlButton.Controls.Add(btnCancel)
            pnlButton.Controls.Add(btnExit)
        ElseIf mode = "update" Then
            pnlButton.Controls.Add(btnSave)
            pnlButton.Controls.Add(btnCancel)
            pnlButton.Controls.Add(btnExit)
        Else
            pnlButton.Controls.Add(btnNew)
            pnlButton.Controls.Add(btnExit)
        End If

        If pnlButton.Controls.Count > 0 Then
            For Each item As Control In pnlButton.Controls
                item.Visible = True
            Next
        End If
    End Sub

    Private Sub isActiveInput(ByVal _active As Boolean)
        txtUserId.Enabled = _active
        txtUserName.Enabled = _active
        cboRole.Enabled = _active
        txtPassword.Enabled = _active
        pictUser.Enabled = _active
        chkActive.Enabled = _active
    End Sub

    Private Sub clearInput()
        txtUserId.Text = String.Empty
        txtUserName.Text = String.Empty
        txtPassword.Text = String.Empty
        pictUser.Image = Nothing
        chkActive.Checked = True
    End Sub

    Private Sub GetDataUserAll()
        Try
            Me.DaUser.Fill(Me.DsTrans.dtUser)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Tampilkan data di tabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If DsTrans.dtUser.Rows.Count > 0 Then AddcboFind()
    End Sub

    Private Sub GetDataRole()
        Try
            Me.DaRole.Fill(Me.DsTrans.dtRole)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Tampilkan Role", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        mode = "new"
        activeButton()
        clearInput()
        isActiveInput(True)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        mode = "update"
        activeButton()
        isActiveInput(True)
        txtUserId.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        mode = ""
        activeButton()
        clearInput()
        isActiveInput(False)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
       
        If String.IsNullOrEmpty(txtUserId.Text) Then
            MessageBox.Show("ID user harus diisi !!!", "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtUserName.Text) Then
            MessageBox.Show("Nama user harus diisi !!!", "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Password user harus diisi !!!", "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'If pictUser.Image.Size.IsEmpty Then
        '    MessageBox.Show("No.Telp supplier harus diisi !!!", "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'If String.IsNullOrEmpty(txtPasswordNew.Text) Then
        '    MessageBox.Show("No.Telp supplier harus diisi !!!", "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        If Not MessageBox.Show("Anda yakin ingin menyimpan data ini ?", "Simpan Data User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        Dim dt As New DataTable
        Try
            Using cmd As New SqlCommand
                With cmd
                    .Connection = con
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "spUser_Save"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@pUserId", txtUserId.Text.Trim)
                    .Parameters.AddWithValue("@pUserName", txtUserName.Text.Trim)
                    .Parameters.AddWithValue("@pRoleId", cboRole.SelectedValue.ToString.Trim)
                    .Parameters.AddWithValue("@pUserPass", txtPassword.Text.Trim)
                    If isChangedFoto Then
                        Using ms As New MemoryStream()
                            Me.pictUser.Image.Save(ms, Me.pictUser.Image.RawFormat)
                            Dim data As Byte() = ms.GetBuffer()
                            .Parameters.Add(New SqlParameter() With {.ParameterName = "@pUserPicture", .DbType = DbType.Binary, .Value = data})
                        End Using

                        '.Parameters.AddWithValue("@pUserPicture", New ImageConverter().ConvertTo(Me.pictUser.Image, GetType(Byte())))
                    Else
                        .Parameters.AddWithValue("@pUserPicture", _oldByteImage)
                    End If
                    .Parameters.AddWithValue("@pActive", chkActive.Checked)
                    .Parameters.AddWithValue("@pMode", mode)
                End With
                Using da As New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(0).ToString.Trim <> "1" Then
                MessageBox.Show(dt.Rows(0)(0).ToString, "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                mode = ""
                isActiveInput(False)
                activeButton()
                GetDataUserAll()
                clearInput()
                MessageBox.Show("Data berhasil disimpan.", "Simpan Data User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvUser_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUser.CellMouseClick
        With dgvUser
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If e.Button = Windows.Forms.MouseButtons.Right Then .Rows(e.RowIndex).Selected = True
                If .SelectedRows.Count > 0 Then
                    txtUserId.Text = .SelectedRows(0).Cells("cUserId").Value
                    txtUserName.Text = .SelectedRows(0).Cells("cUserName").Value
                    cboRole.Text = .SelectedRows(0).Cells("cRoleDesc").Value
                    txtPassword.Text = .SelectedRows(0).Cells("cUserPass").Value
                    If .SelectedRows(0).Cells("cAktif").Value = True Then
                        chkActive.Checked = True
                    Else
                        chkActive.Checked = False
                    End If


                    Dim dtFoto As DataTable
                    Using cmd As New SqlCommand
                        With cmd
                            .Connection = con
                            .CommandText = "Select userFoto From tBase_User Where UserID = @pUserId"
                            .Parameters.Clear()
                            .Parameters.AddWithValue("@pUserId", dgvUser.SelectedRows(0).Cells("cUserId").Value)
                        End With
                        Using da As New SqlDataAdapter(cmd)
                            dtFoto = New DataTable
                            da.Fill(dtFoto)
                        End Using
                        If dtFoto.Rows.Count > 0 Then
                            If Not IsDBNull(dtFoto.Rows(0)("userFoto")) Then
                                Dim _objByte As Byte() = DirectCast(dtFoto.Rows(0)("userFoto"), Byte())

                                If Not _objByte Is Nothing Then
                                    Using ms As New MemoryStream(_objByte, 0, _objByte.Length)
                                        ms.Write(_objByte, 0, _objByte.Length)
                                        pictUser.Image = Image.FromStream(ms, True)
                                        _oldByteImage = _objByte
                                    End Using
                                End If
                            End If
                        End If
                    End Using


                    mode = "edit"
                    activeButton()
                    isActiveInput(False)
                End If
            End If
        End With
    End Sub

    Private Sub dgvUser_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUser.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvUser.SelectedRows.Count > 0 Then
                mode = "update"
                activeButton()
                isActiveInput(True)
                txtUserId.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvUser_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvUser.CellPainting
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If dgvUser.Rows(e.RowIndex).Cells("cAktif").Value = False Then
                e.CellStyle.ForeColor = Color.DimGray
            End If
        End If
    End Sub

    Private Sub pictUser_Click(sender As Object, e As EventArgs) Handles pictUser.Click
        Using ofd As New OpenFileDialog()
            With ofd
                .Title = "Pilih Foto"
                .Filter = "JPeg File (*.jpg)|*.jpg"
                .CheckPathExists = True
                .CheckFileExists = True
                .Multiselect = False
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                .FileName = String.Empty
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    If .FileName <> String.Empty Then
                        Dim _size As Double = New System.IO.FileInfo(.FileName).Length
                        If _size > 1048576 Then
                            MessageBox.Show("Ukuran file tidak boleh lebih dari 1 MB !!!", "Ukuran File", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            isChangedFoto = False
                            Exit Sub
                        End If
                        Me.pictUser.Image = Image.FromFile(.FileName)
                        isChangedFoto = True
                    End If
                End If
            End With
        End Using
    End Sub
End Class