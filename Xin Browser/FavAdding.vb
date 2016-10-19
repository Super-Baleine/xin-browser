Public Class FavAdding

    Dim myfavbar As ToolStrip

    Public Sub SetInfos(ByVal wurl As Uri, ByVal wtitle As String, ByVal wfavbar As ToolStrip)
        TextBox1.Text = wtitle
        TextBox2.Text = wurl.ToString
        myfavbar = wfavbar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.favlist.Add(TextBox1.Text & "|" & TextBox2.Text)
        My.Settings.Save()

        Dim favbutton As New ToolStripButton
        Dim a1 As Array = TextBox2.Text.ToString.Split("/")
        Try
            Dim iconURL As String = "http://" & a1(2) & "/favicon.ico"
            Dim web As New Net.WebClient
            Dim ms As New IO.MemoryStream(web.DownloadData(iconURL))
            Dim icon As New Icon(ms)
            favbutton.Image = icon.ToBitmap
            If icon Is Nothing Then
                favbutton.Image = Principal.Icon.ToBitmap
            End If
        Catch ex As Exception
            favbutton.Image = Principal.Icon.ToBitmap
        End Try
        favbutton.Text = TextBox1.Text
        favbutton.Tag = TextBox2.Text
        favbutton.ForeColor = Color.White
        myfavbar.Items.Add(favbutton)

        Me.Close()
    End Sub

    Private Sub FavAdding_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class