Public Class frmClosing
    Dim con As New SqlConnection(My.Settings.EJMConString)

    Private Sub frmClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.tlStrpLblStatus.Text = "Ready"
        lblTglLastClosing.Text = GetClosingTerakhir()
        dtpTrans.Value = Now.Date
        createButton("new")
    End Sub

    Private Function GetClosingTerakhir() As String
        Dim _result As String = String.Empty

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select TglStok from tLog_Closing where isClosing=1 order by TglStok desc"
        cmd.Parameters.Clear()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        da.Dispose()
        cmd.Dispose()

        If dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0)("TglStok")) Then _result = Format(dt.Rows(0)("TglStok"), "MM/dd/yyyy")
        End If

        Return _result
    End Function

    Private Sub btnClosing_Click(sender As Object, e As EventArgs) Handles btnClosing.Click
        If isLockData() Then
            MessageBox.Show("Data sedang di-LOCK !", "Closing Stok", MessageBoxButtons.OK, MessageBoxIcon.Error)
            createButton("new")
            lblStatusClosing.Text = ""
            Exit Sub
        End If

        If dtpTrans.Value.Date > Now.Date Then
            MessageBox.Show("Tanggal closing harus <= Tanggal saat ini !", "Closing Stok", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin melakukan closing ?", "Closing Stok", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spStok_Closing"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pTglTrans", dtpTrans.Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        da.Dispose()
        cmd.Dispose()

        If dt.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(dt.Rows(0)(0)) Then
                If dt.Rows(0)(0).ToString = "1" Then
                    GetClosingTerakhir()
                    frmMain.GetLastClosing()
                    SetLabelClosing()
                    createButton("new")
                    DsTrans.dtPreviewStok.Rows.Clear()
                    MessageBox.Show("Closing stok berhasil dilakukan.", "Closing Stok", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(dt.Rows(0)(0).ToString, "Closing Stok", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUnclosing_Click(sender As Object, e As EventArgs) Handles btnUnclosing.Click
        If isLockData() Then
            MessageBox.Show("Data sedang di-LOCK !", "Closing Stok", MessageBoxButtons.OK, MessageBoxIcon.Error)
            createButton("new")
            lblStatusClosing.Text = ""
            Exit Sub
        End If

        If dtpTrans.Value.Date > Now.Date Then
            MessageBox.Show("Tanggal unclosing tidak boleh melebihi Tanggal saat ini !", "Unclosing Stok", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not MessageBox.Show("Anda yakin ingin melakukan Unclosing ?", "Unclosing Stok", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandTimeout = 120
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spStok_Unclosing"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@pTglTrans", dtpTrans.Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        da.Dispose()
        cmd.Dispose()

        If dt.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(dt.Rows(0)(0)) Then
                If dt.Rows(0)(0).ToString = "1" Then
                    GetClosingTerakhir()
                    frmMain.GetLastClosing()
                    SetLabelClosing()
                    createButton("new")
                    DsTrans.dtPreviewStok.Rows.Clear()
                    MessageBox.Show("Unclosing stok berhasil dilakukan.", "Unclosing Stok", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(dt.Rows(0)(0).ToString, "Unlosing Stok", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PreviewData(dtpTrans.Value)
    End Sub

    Private Sub PreviewData(ByVal _tglTrans As Date)
        lblStatusClosing.Text = ""

        Me.DaPreviewStok.Fill(Me.DsTrans.dtPreviewStok, _tglTrans)

        If Me.DsTrans.dtPreviewStok.Rows.Count < 1 Then
            MessageBox.Show("Data tidak ditemukan !", "Preview Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SetLabelClosing()
            frmMain.tlStrpLblStatus.Text = "Total data = " & Me.DsTrans.dtPreviewStok.Rows.Count & " item"

            If isLockData() Then
                createButton("new")
                lblStatusClosing.Text = "Data sedang di-LOCK !"
                Exit Sub
            End If
        End If
    End Sub

    Private Sub SetLabelClosing()
        ' Apabila tanggal yang dipilih sudah closing
        If isClosing(dtpTrans.Value.Date) Then
            createButton("unclosing")
            lblStatusClosing.Text = "Transaksi sudah di-closing"
            lblStatusClosing.ForeColor = Color.Green
        Else
            createButton("closing")
            lblStatusClosing.Text = "Transaksi belum di-closing"
            lblStatusClosing.ForeColor = Color.Red
        End If
    End Sub

    Private Sub createButton(ByVal _mode As String)
        pnlButton.Controls.Clear()
        If _mode = "new" Then
            pnlButton.Controls.Add(btnPreview)
            pnlButton.Controls.Add(btnExit)
        ElseIf _mode = "closing" Then
            pnlButton.Controls.Add(btnClosing)
            pnlButton.Controls.Add(btnExit)
        ElseIf _mode = "unclosing" Then
            pnlButton.Controls.Add(btnUnclosing)
            pnlButton.Controls.Add(btnExit)
        End If

        If pnlButton.Controls.Count > 0 Then
            For Each item As Control In pnlButton.Controls
                item.Visible = True
            Next
        End If
    End Sub

    

End Class