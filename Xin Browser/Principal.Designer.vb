<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackHighColor = System.Drawing.SystemColors.ControlDark
        Me.TabControl1.BackLowColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.ControlButtonBackHighColor = System.Drawing.Color.Aqua
        Me.TabControl1.ControlButtonBackLowColor = System.Drawing.Color.Turquoise
        Me.TabControl1.ControlButtonBorderColor = System.Drawing.Color.DarkTurquoise
        Me.TabControl1.ControlButtonForeColor = System.Drawing.SystemColors.Control
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(804, 622)
        Me.TabControl1.TabBackHighColor = System.Drawing.SystemColors.ControlDark
        Me.TabControl1.TabBackHighColorDisabled = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.TabBackLowColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.TabBackLowColorDisabled = System.Drawing.SystemColors.ButtonShadow
        Me.TabControl1.TabBorderEnhanced = True
        Me.TabControl1.TabCloseButtonBackHighColor = System.Drawing.SystemColors.ButtonShadow
        Me.TabControl1.TabCloseButtonBackHighColorDisabled = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.TabCloseButtonBackHighColorHot = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabControl1.TabCloseButtonBackLowColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.TabCloseButtonBackLowColorDisabled = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.TabCloseButtonBackLowColorHot = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabControl1.TabCloseButtonBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.TabCloseButtonBorderColorDisabled = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.TabCloseButtonBorderColorHot = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.TopSeparator = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(804, 622)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(820, 660)
        Me.Name = "Principal"
        Me.Text = "Xin Browser"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As MdiTabControl.TabControl

End Class
