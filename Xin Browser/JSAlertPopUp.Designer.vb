<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JSAlertPopUp
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JSAlertPopUp))
        Me.ChromeThemeContainer1 = New Xin_Browser.ChromeThemeContainer()
        Me.MsgBody = New System.Windows.Forms.Label()
        Me.ChromeButton1 = New Xin_Browser.ChromeButton()
        Me.ChromeButton2 = New Xin_Browser.ChromeButton()
        Me.ChromeThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChromeThemeContainer1
        '
        Me.ChromeThemeContainer1.BackColor = System.Drawing.Color.Gainsboro
        Me.ChromeThemeContainer1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ChromeThemeContainer1.Controls.Add(Me.ChromeButton2)
        Me.ChromeThemeContainer1.Controls.Add(Me.MsgBody)
        Me.ChromeThemeContainer1.Controls.Add(Me.ChromeButton1)
        Me.ChromeThemeContainer1.Customization = "AAAA/1paWv9ycnL/"
        Me.ChromeThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromeThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChromeThemeContainer1.Image = Nothing
        Me.ChromeThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ChromeThemeContainer1.Movable = True
        Me.ChromeThemeContainer1.Name = "ChromeThemeContainer1"
        Me.ChromeThemeContainer1.NoRounding = False
        Me.ChromeThemeContainer1.Sizable = True
        Me.ChromeThemeContainer1.Size = New System.Drawing.Size(379, 174)
        Me.ChromeThemeContainer1.SmartBounds = True
        Me.ChromeThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ChromeThemeContainer1.TabIndex = 0
        Me.ChromeThemeContainer1.Text = "Alerte Javascript"
        Me.ChromeThemeContainer1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.Transparent = False
        '
        'MsgBody
        '
        Me.MsgBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MsgBody.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MsgBody.Location = New System.Drawing.Point(8, 41)
        Me.MsgBody.Name = "MsgBody"
        Me.MsgBody.Size = New System.Drawing.Size(359, 81)
        Me.MsgBody.TabIndex = 1
        '
        'ChromeButton1
        '
        Me.ChromeButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton1.Image = Nothing
        Me.ChromeButton1.Location = New System.Drawing.Point(292, 131)
        Me.ChromeButton1.Name = "ChromeButton1"
        Me.ChromeButton1.NoRounding = False
        Me.ChromeButton1.Size = New System.Drawing.Size(75, 31)
        Me.ChromeButton1.TabIndex = 0
        Me.ChromeButton1.Text = "OK"
        Me.ChromeButton1.Transparent = False
        '
        'ChromeButton2
        '
        Me.ChromeButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChromeButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton2.Image = Nothing
        Me.ChromeButton2.Location = New System.Drawing.Point(11, 131)
        Me.ChromeButton2.Name = "ChromeButton2"
        Me.ChromeButton2.NoRounding = False
        Me.ChromeButton2.Size = New System.Drawing.Size(100, 31)
        Me.ChromeButton2.TabIndex = 2
        Me.ChromeButton2.Text = "Fermer l'onglet"
        Me.ChromeButton2.Transparent = False
        '
        'JSAlertPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 174)
        Me.Controls.Add(Me.ChromeThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "JSAlertPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alerte Javascript"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChromeThemeContainer1 As Xin_Browser.ChromeThemeContainer
    Friend WithEvents ChromeButton1 As Xin_Browser.ChromeButton
    Friend WithEvents MsgBody As System.Windows.Forms.Label
    Friend WithEvents ChromeButton2 As Xin_Browser.ChromeButton
End Class
