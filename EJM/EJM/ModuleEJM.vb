Module ModuleEJM
    Private con As New SqlConnection(My.Settings.EJMConString)

    Public _userNameGlobal As String = String.Empty
    Public _userIdGlobal As String = String.Empty
    Public _isHasBeenLogin As Boolean = False

    Public Function isLockData() As Boolean
        Dim result As Boolean = False

        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select isLock from tLockData where isLock=1"
        cmd.Parameters.Clear()

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        ' Jika datanya dapat, berarti tanggal itu sudah dilakukan lock data
        If dt.Rows.Count > 0 Then
            result = True
        End If

        Return result
    End Function

    Public Function isClosing(ByVal tglTrans As Date) As Boolean
        Dim _result As Boolean = False

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select TglStok from tLog_Closing where isClosing=1 and TglStok=@pTglStok"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pTglStok", tglTrans.Date)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        da.Dispose()
        cmd.Dispose()

        If dt.Rows.Count > 0 Then
            _result = True
        Else
            _result = False
        End If

        Return _result
    End Function
End Module
