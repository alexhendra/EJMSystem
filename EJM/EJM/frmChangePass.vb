Public Class frmChangePass
    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtPassOld.Text) Then
            MessageBox.Show("Password lama harus diisi !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPassNew.Text) Then
            MessageBox.Show("Password baru harus diisi !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPassNewAgain.Text) Then
            MessageBox.Show("Input ulang password pada textbox Ulangi Password Baru !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtPassNew.Text <> txtPassNewAgain.Text Then
            MessageBox.Show("Password baru yang diinput di textbox Ulangi Password Baru tidak sama dengan password pada textbox Password Baru !!!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            Using cmd As New SqlCommand()
                With cmd
                    .Connection = con
                    .CommandTimeout = 120
                    .CommandType = CommandType.Text
                    .CommandText = "update tBase_user set userPass=@pNewPass where userId=@pUserId"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@pUserId", _userIdGlobal.Trim)
                    .Parameters.AddWithValue("@pNewPass", txtPassNew.Text.Trim)
                    .ExecuteNonQuery()
                End With
            End Using
            MessageBox.Show("Password berhasil diubah", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInput()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub ClearInput()
        txtPassOld.Clear()
        txtPassNew.Clear()
        txtPassNewAgain.Clear()
    End Sub
End Class