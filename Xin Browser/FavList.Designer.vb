<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FavList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FavList))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OuvrirLeLienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerDeLhistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopierLeLienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(704, 572)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Titre de la page"
        Me.ColumnHeader1.Width = 163
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Adresse web (url)"
        Me.ColumnHeader2.Width = 535
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirLeLienToolStripMenuItem, Me.SupprimerDeLhistoriqueToolStripMenuItem, Me.ToolStripSeparator1, Me.CopierLeLienToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(227, 76)
        '
        'OuvrirLeLienToolStripMenuItem
        '
        Me.OuvrirLeLienToolStripMenuItem.Name = "OuvrirLeLienToolStripMenuItem"
        Me.OuvrirLeLienToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirLeLienToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.OuvrirLeLienToolStripMenuItem.Text = "Ouvrir le lien"
        '
        'SupprimerDeLhistoriqueToolStripMenuItem
        '
        Me.SupprimerDeLhistoriqueToolStripMenuItem.Name = "SupprimerDeLhistoriqueToolStripMenuItem"
        Me.SupprimerDeLhistoriqueToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.SupprimerDeLhistoriqueToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.SupprimerDeLhistoriqueToolStripMenuItem.Text = "Supprimer des favoris"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(223, 6)
        '
        'CopierLeLienToolStripMenuItem
        '
        Me.CopierLeLienToolStripMenuItem.Name = "CopierLeLienToolStripMenuItem"
        Me.CopierLeLienToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopierLeLienToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.CopierLeLienToolStripMenuItem.Text = "Copier le lien"
        '
        'FavList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 572)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FavList"
        Me.Text = "Favoris - Xin Browser"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OuvrirLeLienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerDeLhistoriqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopierLeLienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
