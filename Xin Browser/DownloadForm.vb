Public Class DownloadForm

    Private Sub DownloadForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadsContainer.Controls.Clear()
        My.Settings.downlist.Clear()
        My.Settings.Save()
    End Sub

    Private Sub DownloadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each i As String In My.Settings.downlist
                Dim a As Array = i.Split("|")
                Dim nd As New FileDownload
                nd.DownloadURL = New Uri(a(1))
                nd.DownloadPath = a(0)
                nd.SetInfos()
                nd.Dock = DockStyle.Top
                nd.ProgressLbl.Visible = False
                nd.DownloadProgressBar.Visible = False
                nd.CancelBtn.Visible = False
                nd.DeleteBtn.Visible = True
                nd.FolderplaceBtn.Visible = True
                nd.StartBtn.Visible = True
                DownloadsContainer.Controls.Add(nd)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class