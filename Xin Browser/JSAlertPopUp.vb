Public Class JSAlertPopUp
    Private Const CS_DROPSHADOW As Integer = 131072

    ' Override the CreateParams property
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub ChromeButton1_Click(sender As Object, e As EventArgs) Handles ChromeButton1.Click
        Me.Close()
    End Sub

    Private Sub ChromeButton2_Click(sender As Object, e As EventArgs) Handles ChromeButton2.Click
        If Not Principal.TabControl1.TabPages.Count = 1 Then
            Principal.TabControl1.TabPages.Remove(Principal.TabControl1.SelectedForm)
        Else
            Principal.Close()
            Me.Close()
        End If
    End Sub
End Class