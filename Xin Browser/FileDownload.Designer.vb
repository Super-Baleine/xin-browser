<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileDownload
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileDownload))
        Me.IconPic = New System.Windows.Forms.PictureBox()
        Me.FilenameLbl = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.UrlLbl = New System.Windows.Forms.Label()
        Me.ProgressLbl = New System.Windows.Forms.Label()
        Me.DownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.FolderplaceBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.StartBtn = New System.Windows.Forms.Button()
        CType(Me.IconPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconPic
        '
        Me.IconPic.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IconPic.Location = New System.Drawing.Point(9, 14)
        Me.IconPic.Name = "IconPic"
        Me.IconPic.Size = New System.Drawing.Size(40, 40)
        Me.IconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconPic.TabIndex = 0
        Me.IconPic.TabStop = False
        '
        'FilenameLbl
        '
        Me.FilenameLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilenameLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.FilenameLbl.Location = New System.Drawing.Point(55, 4)
        Me.FilenameLbl.Name = "FilenameLbl"
        Me.FilenameLbl.Size = New System.Drawing.Size(299, 17)
        Me.FilenameLbl.TabIndex = 1
        Me.FilenameLbl.Text = "DownloadFileName"
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Image = CType(resources.GetObject("CancelBtn.Image"), System.Drawing.Image)
        Me.CancelBtn.Location = New System.Drawing.Point(360, 3)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(35, 23)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'UrlLbl
        '
        Me.UrlLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UrlLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UrlLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlLbl.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UrlLbl.Location = New System.Drawing.Point(55, 21)
        Me.UrlLbl.Name = "UrlLbl"
        Me.UrlLbl.Size = New System.Drawing.Size(299, 17)
        Me.UrlLbl.TabIndex = 3
        Me.UrlLbl.Text = "FileDownloadUri"
        '
        'ProgressLbl
        '
        Me.ProgressLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressLbl.AutoSize = True
        Me.ProgressLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.ProgressLbl.Location = New System.Drawing.Point(55, 47)
        Me.ProgressLbl.Name = "ProgressLbl"
        Me.ProgressLbl.Size = New System.Drawing.Size(21, 18)
        Me.ProgressLbl.TabIndex = 4
        Me.ProgressLbl.Text = "0%"
        '
        'DownloadProgressBar
        '
        Me.DownloadProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadProgressBar.Location = New System.Drawing.Point(89, 48)
        Me.DownloadProgressBar.Name = "DownloadProgressBar"
        Me.DownloadProgressBar.Size = New System.Drawing.Size(291, 16)
        Me.DownloadProgressBar.TabIndex = 5
        '
        'FolderplaceBtn
        '
        Me.FolderplaceBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FolderplaceBtn.FlatAppearance.BorderSize = 0
        Me.FolderplaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FolderplaceBtn.Image = CType(resources.GetObject("FolderplaceBtn.Image"), System.Drawing.Image)
        Me.FolderplaceBtn.Location = New System.Drawing.Point(360, 44)
        Me.FolderplaceBtn.Name = "FolderplaceBtn"
        Me.FolderplaceBtn.Size = New System.Drawing.Size(35, 23)
        Me.FolderplaceBtn.TabIndex = 6
        Me.FolderplaceBtn.UseVisualStyleBackColor = True
        Me.FolderplaceBtn.Visible = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Image = CType(resources.GetObject("DeleteBtn.Image"), System.Drawing.Image)
        Me.DeleteBtn.Location = New System.Drawing.Point(325, 44)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(35, 23)
        Me.DeleteBtn.TabIndex = 7
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Image = CType(resources.GetObject("StartBtn.Image"), System.Drawing.Image)
        Me.StartBtn.Location = New System.Drawing.Point(290, 44)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(35, 23)
        Me.StartBtn.TabIndex = 8
        Me.StartBtn.UseVisualStyleBackColor = True
        Me.StartBtn.Visible = False
        '
        'FileDownload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.FolderplaceBtn)
        Me.Controls.Add(Me.DownloadProgressBar)
        Me.Controls.Add(Me.ProgressLbl)
        Me.Controls.Add(Me.UrlLbl)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.FilenameLbl)
        Me.Controls.Add(Me.IconPic)
        Me.Name = "FileDownload"
        Me.Size = New System.Drawing.Size(398, 70)
        CType(Me.IconPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconPic As System.Windows.Forms.PictureBox
    Friend WithEvents FilenameLbl As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents UrlLbl As System.Windows.Forms.Label
    Friend WithEvents ProgressLbl As System.Windows.Forms.Label
    Friend WithEvents DownloadProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents FolderplaceBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents StartBtn As System.Windows.Forms.Button

End Class
