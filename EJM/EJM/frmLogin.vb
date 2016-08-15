Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If String.IsNullOrEmpty(txtUserId.Text) Then
            MessageBox.Show("Masukkan User ID !!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPass.Text) Then
            MessageBox.Show("Masukkan Password !!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        _userNameGlobal = GetUserName(txtUserId.Text, txtPass.Text)
        If String.IsNullOrEmpty(_userNameGlobal) Then
            MessageBox.Show("User ID atau Password tidak benar !!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        _isHasBeenLogin = True
        _userIdGlobal = txtUserId.Text.Trim
        txtUserId.Focus()
        txtUserId.Clear()
        txtPass.Clear()
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function GetUserName(ByVal _userId As String, ByVal _pass As String) As String
        Dim _result As String = String.Empty
        Dim dt As DataTable

        Using cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandTimeout = 120
                .CommandType = CommandType.Text
                .CommandText = "select UserName from tBase_User where UserId=@pUserId and UserPass=@pUserPass"
                .Parameters.Clear()
                .Parameters.AddWithValue("@pUserId", _userId.Trim)
                .Parameters.AddWithValue("@pUserPass", _pass.Trim)
            End With
            Using da As New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
            End Using
        End Using

        If dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0)("UserName")) Then
                _result = dt.Rows(0)("UserName").ToString.Trim
            End If
        End If

        Return _result
    End Function

End Class
