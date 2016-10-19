Public Class FileDownload
    Private WithEvents DownloadFrame As Net.WebClient
    Public DownloadURL As Uri
    Public DownloadPath As String

    Public Function GetFileNameFromURL(ByVal URL As String) As String
        Try
            Return URL.Substring(URL.LastIndexOf("/") + 1)
        Catch ex As Exception
            Return URL
        End Try
    End Function

    Public Function IconFromFilePath(ByVal filepath As String) As Icon
        Dim result As Icon = Nothing
        Try
            result = Icon.ExtractAssociatedIcon(filepath)
        Catch
        End Try
        Return result
    End Function

    Public Sub SetInfos()
        Try
            IconPic.Image = IconFromFilePath(DownloadPath).ToBitmap
        Catch ex As Exception
            IconPic.Image = Principal.Icon.ToBitmap
        End Try
        FilenameLbl.Text = GetFileNameFromURL(DownloadURL.ToString)
        UrlLbl.Text = DownloadURL.ToString
    End Sub

    Public Sub StartDownload()
        DownloadFrame = New Net.WebClient
        Try
            DownloadFrame.DownloadFileAsync(DownloadURL, DownloadPath)
        Catch ex As Exception
            MsgBox("Erreur lors du téléchargement de " & GetFileNameFromURL(DownloadPath) & ": " & ex.Message, MsgBoxStyle.Critical)
            Me.Hide()
        End Try
    End Sub

    Private Sub DownloadFrame_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles DownloadFrame.DownloadFileCompleted
        ProgressLbl.Visible = False
        DownloadProgressBar.Visible = False
        CancelBtn.Visible = False
        DeleteBtn.Visible = True
        FolderplaceBtn.Visible = True
        StartBtn.Visible = True
        'Ajoute à la liste des téléchargements terminés
        My.Settings.downlist.Add(DownloadPath & "|" & DownloadURL.ToString)
        My.Settings.Save()
    End Sub

    Private Sub DownloadFrame_DownloadProgressChanged(sender As Object, e As Net.DownloadProgressChangedEventArgs) Handles DownloadFrame.DownloadProgressChanged
        DownloadProgressBar.Value = e.ProgressPercentage
        ProgressLbl.Text = e.ProgressPercentage.ToString & "%"
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        DownloadFrame.CancelAsync()
        Me.Hide()
    End Sub

    Private Sub FolderplaceBtn_Click(sender As Object, e As EventArgs) Handles FolderplaceBtn.Click
        Process.Start("explorer.exe", "/select," & DownloadPath)
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            IO.File.Delete(DownloadPath)
            Me.Hide()
        Catch ex As Exception
            MsgBox("Erreur lors de la suppression du fichier: " & ex.Message, MsgBoxStyle.Critical)
            Me.Hide()
        End Try
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        If IO.File.Exists(DownloadPath) Then
            Process.Start(DownloadPath)
        Else
            MsgBox("Erreur: le fichier demandé n'existe pas", MsgBoxStyle.Critical)
            Me.Hide()
        End If
    End Sub

    Private Sub UrlLbl_Click(sender As Object, e As EventArgs) Handles UrlLbl.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri(UrlLbl.Text)
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub
End Class