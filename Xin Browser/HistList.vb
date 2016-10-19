Public Class HistList

    Private Sub HistList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each i As String In My.Settings.histlist
                Dim a As Array = i.Split("|")
                Dim lst As New ListViewItem
                lst.Text = a(0)
                lst.SubItems.Add(a(1))
                lst.SubItems.Add(a(2))
                lst.Tag = a(1)
                ListView1.Items.Add(lst)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OuvrirLeLienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLeLienToolStripMenuItem.Click
        Try
            Dim lstview As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
            For Each item In lstview
                Dim wid As New Onglet
                wid.WebControl1.Source = New Uri(item.Tag)
                Principal.TabControl1.TabPages.Add(wid)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SupprimerDeLhistoriqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerDeLhistoriqueToolStripMenuItem.Click
        Try
            Dim lstview As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
            For Each item In lstview
                My.Settings.histlist.Remove(item.Text & "|" & item.SubItems(1).Text & "|" & item.SubItems(2).Text)
                My.Settings.Save()
                ListView1.Items.Remove(item)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopierLeLienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLeLienToolStripMenuItem.Click
        Try
            Dim lstview As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
            For Each item In lstview
                Clipboard.SetText(item.Tag)
                MsgBox("Copié dans le presse-papiers:" & vbNewLine & item.Tag, MsgBoxStyle.Information)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViderToutMonHistoriqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViderToutMonHistoriqueToolStripMenuItem.Click
        Dim result As MsgBoxResult = MsgBox("Etes-vous sûr(e) de vouloir vider tout votre historique ? Une fois l'opération effectuée, vous ne pourrez pas récupérer ces données.", MsgBoxStyle.YesNoCancel, "Vider l'historique ?")
        If result = MsgBoxResult.Yes Then
            My.Settings.histlist.Clear()
            My.Settings.Save()
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                Dim lstview As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
                For Each item In lstview
                    Dim dlg As New Onglet
                    dlg.WebControl1.Source = New Uri(item.SubItems(1).Text)
                    Principal.TabControl1.TabPages.Add(dlg)
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class