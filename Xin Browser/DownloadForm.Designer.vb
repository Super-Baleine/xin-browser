<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadForm))
        Me.CmdsContainer = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DownloadsContainer = New System.Windows.Forms.Panel()
        Me.CmdsContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdsContainer
        '
        Me.CmdsContainer.Controls.Add(Me.Button1)
        Me.CmdsContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CmdsContainer.Location = New System.Drawing.Point(0, 332)
        Me.CmdsContainer.Name = "CmdsContainer"
        Me.CmdsContainer.Size = New System.Drawing.Size(484, 30)
        Me.CmdsContainer.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Vider la liste des téléchargements"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DownloadsContainer
        '
        Me.DownloadsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownloadsContainer.Location = New System.Drawing.Point(0, 0)
        Me.DownloadsContainer.Name = "DownloadsContainer"
        Me.DownloadsContainer.Size = New System.Drawing.Size(484, 332)
        Me.DownloadsContainer.TabIndex = 1
        '
        'DownloadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.DownloadsContainer)
        Me.Controls.Add(Me.CmdsContainer)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "DownloadForm"
        Me.Text = "Téléchargements"
        Me.CmdsContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdsContainer As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DownloadsContainer As System.Windows.Forms.Panel
End Class
