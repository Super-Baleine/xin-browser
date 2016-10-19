Public Class Principal
    Private myArgs As String

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TabControl1.TabPages.Remove(TabControl1.TabPages.SelectedTab)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        myArgs = My.Application.CommandLineArgs(0)
        On Error Resume Next
        If myArgs = Nothing Then
            'Pas d'ouverture depuis un fichier dans l'explorateur windows (SHELL)
            Dim newtab As New Onglet
            newtab.WebControl1.Source = New Uri(My.Settings.homepage)
            TabControl1.TabPages.Add(newtab)
        Else
            'Ouverture depuis le SHELL Windows (ou explorateur)
            Dim newtab As New Onglet
            newtab.WebControl1.Source = New Uri(myArgs)
            TabControl1.TabPages.Add(newtab)
        End If
        DownloadForm.Hide()
    End Sub

    Private Sub TabControl1_SelectedTabChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedTabChanged
        If TabControl1.TabPages.Count = 1 Then
            TabControl1.TabCloseButtonVisible = False
        Else
            TabControl1.TabCloseButtonVisible = True
        End If
    End Sub
End Class
