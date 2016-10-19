<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Onglet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Onglet))
        Dim WebPreferences1 As Awesomium.Core.WebPreferences = New Awesomium.Core.WebPreferences(True)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BarreDeMenusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarreDeNavigationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarreDesFavorisToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarreDétatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadenasSecurity = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrivateNavigation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ZoomLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuBar = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelOngletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleFenêtreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OuvrirUneUrlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirUnePageWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimerLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésDeLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FermerCetOngletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerEtAllerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SélectionnerToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RechercherDansLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffichageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarreDeMenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarreDeNavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarreDesFavorisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarreDétatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModePleinÉcranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavorisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLesFavorisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLhistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjouterAuxFavorisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavorisToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TéléchargementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageDaccueilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierLaPageDaccueilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodeSourceDeLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisesÀJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProduitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XinBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavBar = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FavBar = New System.Windows.Forms.ToolStrip()
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OuvrirLeLienDansUnNouvelOngletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerLeLienSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierLadresseDuLienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerLimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierLimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierLurlDeLimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirLimageDansUnNouvelOngletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrécédentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuivantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RafraîchirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeSourceDeLaPageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationsDeLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExaminerLélémentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebControlContextMenu1 = New Awesomium.Windows.Forms.WebControlContextMenu(Me.components)
        Me.HtmlSourcePanel = New System.Windows.Forms.Panel()
        Me.HTMLRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SearchTextBoxHTML = New System.Windows.Forms.TextBox()
        Me.ToolBarHTML = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.MediaPlayerPanel = New System.Windows.Forms.Panel()
        Me.PdfViewerPanel = New System.Windows.Forms.Panel()
        Me.AxPDFViewer = New AxAcroPDFLib.AxAcroPDF()
        Me.AxWMPTitleLbl = New System.Windows.Forms.Label()
        Me.ChromeButton2 = New Xin_Browser.ChromeButton()
        Me.ChromeButton1 = New Xin_Browser.ChromeButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.WebSessionProvider1 = New Awesomium.Windows.Forms.WebSessionProvider(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MnuBar.SuspendLayout()
        Me.NavBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.HtmlSourcePanel.SuspendLayout()
        Me.ToolBarHTML.SuspendLayout()
        Me.MediaPlayerPanel.SuspendLayout()
        Me.PdfViewerPanel.SuspendLayout()
        CType(Me.AxPDFViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.StatusStrip1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadenasSecurity, Me.PrivateNavigation, Me.ToolStripStatusLabel2, Me.ZoomLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 556)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(730, 24)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarreDeMenusToolStripMenuItem1, Me.BarreDeNavigationToolStripMenuItem1, Me.BarreDesFavorisToolStripMenuItem1, Me.BarreDétatToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 92)
        '
        'BarreDeMenusToolStripMenuItem1
        '
        Me.BarreDeMenusToolStripMenuItem1.Checked = True
        Me.BarreDeMenusToolStripMenuItem1.CheckOnClick = True
        Me.BarreDeMenusToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDeMenusToolStripMenuItem1.Name = "BarreDeMenusToolStripMenuItem1"
        Me.BarreDeMenusToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.BarreDeMenusToolStripMenuItem1.Text = "Barre de menus"
        '
        'BarreDeNavigationToolStripMenuItem1
        '
        Me.BarreDeNavigationToolStripMenuItem1.Checked = True
        Me.BarreDeNavigationToolStripMenuItem1.CheckOnClick = True
        Me.BarreDeNavigationToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDeNavigationToolStripMenuItem1.Name = "BarreDeNavigationToolStripMenuItem1"
        Me.BarreDeNavigationToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.BarreDeNavigationToolStripMenuItem1.Text = "Barre de navigation"
        '
        'BarreDesFavorisToolStripMenuItem1
        '
        Me.BarreDesFavorisToolStripMenuItem1.Checked = True
        Me.BarreDesFavorisToolStripMenuItem1.CheckOnClick = True
        Me.BarreDesFavorisToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDesFavorisToolStripMenuItem1.Name = "BarreDesFavorisToolStripMenuItem1"
        Me.BarreDesFavorisToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.BarreDesFavorisToolStripMenuItem1.Text = "Barre des favoris"
        '
        'BarreDétatToolStripMenuItem1
        '
        Me.BarreDétatToolStripMenuItem1.Checked = True
        Me.BarreDétatToolStripMenuItem1.CheckOnClick = True
        Me.BarreDétatToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDétatToolStripMenuItem1.Name = "BarreDétatToolStripMenuItem1"
        Me.BarreDétatToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.BarreDétatToolStripMenuItem1.Text = "Barre d'état"
        '
        'CadenasSecurity
        '
        Me.CadenasSecurity.Image = CType(resources.GetObject("CadenasSecurity.Image"), System.Drawing.Image)
        Me.CadenasSecurity.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.CadenasSecurity.Name = "CadenasSecurity"
        Me.CadenasSecurity.Size = New System.Drawing.Size(16, 19)
        '
        'PrivateNavigation
        '
        Me.PrivateNavigation.Image = CType(resources.GetObject("PrivateNavigation.Image"), System.Drawing.Image)
        Me.PrivateNavigation.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.PrivateNavigation.Name = "PrivateNavigation"
        Me.PrivateNavigation.Size = New System.Drawing.Size(16, 19)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(597, 19)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ZoomLbl
        '
        Me.ZoomLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ZoomLbl.ForeColor = System.Drawing.Color.White
        Me.ZoomLbl.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ZoomLbl.Name = "ZoomLbl"
        Me.ZoomLbl.Size = New System.Drawing.Size(77, 19)
        Me.ZoomLbl.Text = "Zoom: 100%"
        '
        'MnuBar
        '
        Me.MnuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MnuBar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MnuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem, Me.AffichageToolStripMenuItem, Me.FavorisToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.ToolStripMenuItem1, Me.XinBrowserToolStripMenuItem})
        Me.MnuBar.Location = New System.Drawing.Point(0, 0)
        Me.MnuBar.Name = "MnuBar"
        Me.MnuBar.Size = New System.Drawing.Size(730, 24)
        Me.MnuBar.TabIndex = 0
        Me.MnuBar.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelOngletToolStripMenuItem, Me.NouvelleFenêtreToolStripMenuItem, Me.NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem, Me.ToolStripSeparator1, Me.OuvrirUneUrlToolStripMenuItem, Me.OuvrirUnePageWebToolStripMenuItem, Me.EnregistrerLaPageToolStripMenuItem, Me.ToolStripSeparator2, Me.ImprimerLaPageToolStripMenuItem, Me.PropriétésDeLaPageToolStripMenuItem, Me.ToolStripSeparator3, Me.FermerCetOngletToolStripMenuItem, Me.ParamètresToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'NouvelOngletToolStripMenuItem
        '
        Me.NouvelOngletToolStripMenuItem.Image = CType(resources.GetObject("NouvelOngletToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouvelOngletToolStripMenuItem.Name = "NouvelOngletToolStripMenuItem"
        Me.NouvelOngletToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.NouvelOngletToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.NouvelOngletToolStripMenuItem.Text = "Nouvel Onglet"
        '
        'NouvelleFenêtreToolStripMenuItem
        '
        Me.NouvelleFenêtreToolStripMenuItem.Image = CType(resources.GetObject("NouvelleFenêtreToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouvelleFenêtreToolStripMenuItem.Name = "NouvelleFenêtreToolStripMenuItem"
        Me.NouvelleFenêtreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouvelleFenêtreToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.NouvelleFenêtreToolStripMenuItem.Text = "Nouvelle fenêtre"
        '
        'NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem
        '
        Me.NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem.Image = CType(resources.GetObject("NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem.Name = "NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem"
        Me.NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem.Text = "Nouvelle fenêtre en navigation privée"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(339, 6)
        '
        'OuvrirUneUrlToolStripMenuItem
        '
        Me.OuvrirUneUrlToolStripMenuItem.Image = CType(resources.GetObject("OuvrirUneUrlToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OuvrirUneUrlToolStripMenuItem.Name = "OuvrirUneUrlToolStripMenuItem"
        Me.OuvrirUneUrlToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirUneUrlToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.OuvrirUneUrlToolStripMenuItem.Text = "Ouvrir une url..."
        '
        'OuvrirUnePageWebToolStripMenuItem
        '
        Me.OuvrirUnePageWebToolStripMenuItem.Image = CType(resources.GetObject("OuvrirUnePageWebToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OuvrirUnePageWebToolStripMenuItem.Name = "OuvrirUnePageWebToolStripMenuItem"
        Me.OuvrirUnePageWebToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirUnePageWebToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.OuvrirUnePageWebToolStripMenuItem.Text = "Ouvrir une page web..."
        '
        'EnregistrerLaPageToolStripMenuItem
        '
        Me.EnregistrerLaPageToolStripMenuItem.Image = CType(resources.GetObject("EnregistrerLaPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnregistrerLaPageToolStripMenuItem.Name = "EnregistrerLaPageToolStripMenuItem"
        Me.EnregistrerLaPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerLaPageToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.EnregistrerLaPageToolStripMenuItem.Text = "Enregistrer la page"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(339, 6)
        '
        'ImprimerLaPageToolStripMenuItem
        '
        Me.ImprimerLaPageToolStripMenuItem.Image = CType(resources.GetObject("ImprimerLaPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimerLaPageToolStripMenuItem.Name = "ImprimerLaPageToolStripMenuItem"
        Me.ImprimerLaPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimerLaPageToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.ImprimerLaPageToolStripMenuItem.Text = "Imprimer la page"
        '
        'PropriétésDeLaPageToolStripMenuItem
        '
        Me.PropriétésDeLaPageToolStripMenuItem.Image = CType(resources.GetObject("PropriétésDeLaPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PropriétésDeLaPageToolStripMenuItem.Name = "PropriétésDeLaPageToolStripMenuItem"
        Me.PropriétésDeLaPageToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.PropriétésDeLaPageToolStripMenuItem.Text = "Propriétés de la page"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(339, 6)
        '
        'FermerCetOngletToolStripMenuItem
        '
        Me.FermerCetOngletToolStripMenuItem.Image = CType(resources.GetObject("FermerCetOngletToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FermerCetOngletToolStripMenuItem.Name = "FermerCetOngletToolStripMenuItem"
        Me.FermerCetOngletToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.FermerCetOngletToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.FermerCetOngletToolStripMenuItem.Text = "Fermer cet onglet"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = CType(resources.GetObject("ParamètresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = CType(resources.GetObject("QuitterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouperToolStripMenuItem, Me.CopierToolStripMenuItem, Me.CollerToolStripMenuItem, Me.CollerEtAllerToolStripMenuItem, Me.ToolStripSeparator4, Me.SélectionnerToutToolStripMenuItem, Me.ToolStripSeparator5, Me.RechercherDansLaPageToolStripMenuItem})
        Me.EditionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Image = CType(resources.GetObject("CouperToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CouperToolStripMenuItem.Text = "Couper"
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Image = CType(resources.GetObject("CopierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CopierToolStripMenuItem.Text = "Copier"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Image = CType(resources.GetObject("CollerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CollerToolStripMenuItem.Text = "Coller"
        '
        'CollerEtAllerToolStripMenuItem
        '
        Me.CollerEtAllerToolStripMenuItem.Image = CType(resources.GetObject("CollerEtAllerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CollerEtAllerToolStripMenuItem.Name = "CollerEtAllerToolStripMenuItem"
        Me.CollerEtAllerToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.CollerEtAllerToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CollerEtAllerToolStripMenuItem.Text = "Coller et aller"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(248, 6)
        '
        'SélectionnerToutToolStripMenuItem
        '
        Me.SélectionnerToutToolStripMenuItem.Image = CType(resources.GetObject("SélectionnerToutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SélectionnerToutToolStripMenuItem.Name = "SélectionnerToutToolStripMenuItem"
        Me.SélectionnerToutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SélectionnerToutToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.SélectionnerToutToolStripMenuItem.Text = "Sélectionner tout"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(248, 6)
        '
        'RechercherDansLaPageToolStripMenuItem
        '
        Me.RechercherDansLaPageToolStripMenuItem.Image = CType(resources.GetObject("RechercherDansLaPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RechercherDansLaPageToolStripMenuItem.Name = "RechercherDansLaPageToolStripMenuItem"
        Me.RechercherDansLaPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.RechercherDansLaPageToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.RechercherDansLaPageToolStripMenuItem.Text = "Rechercher dans la page..."
        '
        'AffichageToolStripMenuItem
        '
        Me.AffichageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarreDeMenusToolStripMenuItem, Me.BarreDeNavigationToolStripMenuItem, Me.BarreDesFavorisToolStripMenuItem, Me.BarreDétatToolStripMenuItem, Me.ToolStripSeparator6, Me.ModePleinÉcranToolStripMenuItem})
        Me.AffichageToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AffichageToolStripMenuItem.Name = "AffichageToolStripMenuItem"
        Me.AffichageToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AffichageToolStripMenuItem.Text = "Affichage"
        '
        'BarreDeMenusToolStripMenuItem
        '
        Me.BarreDeMenusToolStripMenuItem.Checked = True
        Me.BarreDeMenusToolStripMenuItem.CheckOnClick = True
        Me.BarreDeMenusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDeMenusToolStripMenuItem.Name = "BarreDeMenusToolStripMenuItem"
        Me.BarreDeMenusToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.BarreDeMenusToolStripMenuItem.Text = "Barre de menus"
        '
        'BarreDeNavigationToolStripMenuItem
        '
        Me.BarreDeNavigationToolStripMenuItem.Checked = True
        Me.BarreDeNavigationToolStripMenuItem.CheckOnClick = True
        Me.BarreDeNavigationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDeNavigationToolStripMenuItem.Name = "BarreDeNavigationToolStripMenuItem"
        Me.BarreDeNavigationToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.BarreDeNavigationToolStripMenuItem.Text = "Barre de navigation"
        '
        'BarreDesFavorisToolStripMenuItem
        '
        Me.BarreDesFavorisToolStripMenuItem.Checked = True
        Me.BarreDesFavorisToolStripMenuItem.CheckOnClick = True
        Me.BarreDesFavorisToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDesFavorisToolStripMenuItem.Name = "BarreDesFavorisToolStripMenuItem"
        Me.BarreDesFavorisToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.BarreDesFavorisToolStripMenuItem.Text = "Barre des favoris"
        '
        'BarreDétatToolStripMenuItem
        '
        Me.BarreDétatToolStripMenuItem.Checked = True
        Me.BarreDétatToolStripMenuItem.CheckOnClick = True
        Me.BarreDétatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarreDétatToolStripMenuItem.Name = "BarreDétatToolStripMenuItem"
        Me.BarreDétatToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.BarreDétatToolStripMenuItem.Text = "Barre d'état"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(188, 6)
        '
        'ModePleinÉcranToolStripMenuItem
        '
        Me.ModePleinÉcranToolStripMenuItem.Name = "ModePleinÉcranToolStripMenuItem"
        Me.ModePleinÉcranToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.ModePleinÉcranToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ModePleinÉcranToolStripMenuItem.Text = "Mode plein écran"
        '
        'FavorisToolStripMenuItem
        '
        Me.FavorisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherLesFavorisToolStripMenuItem, Me.AfficherLhistoriqueToolStripMenuItem, Me.ToolStripSeparator7, Me.AjouterAuxFavorisToolStripMenuItem, Me.ToolStripSeparator8})
        Me.FavorisToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FavorisToolStripMenuItem.Name = "FavorisToolStripMenuItem"
        Me.FavorisToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.FavorisToolStripMenuItem.Text = "Favoris"
        '
        'AfficherLesFavorisToolStripMenuItem
        '
        Me.AfficherLesFavorisToolStripMenuItem.Name = "AfficherLesFavorisToolStripMenuItem"
        Me.AfficherLesFavorisToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AfficherLesFavorisToolStripMenuItem.Text = "Afficher les favoris"
        '
        'AfficherLhistoriqueToolStripMenuItem
        '
        Me.AfficherLhistoriqueToolStripMenuItem.Name = "AfficherLhistoriqueToolStripMenuItem"
        Me.AfficherLhistoriqueToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AfficherLhistoriqueToolStripMenuItem.Text = "Afficher l'historique"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(175, 6)
        '
        'AjouterAuxFavorisToolStripMenuItem
        '
        Me.AjouterAuxFavorisToolStripMenuItem.Name = "AjouterAuxFavorisToolStripMenuItem"
        Me.AjouterAuxFavorisToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AjouterAuxFavorisToolStripMenuItem.Text = "Ajouter aux favoris"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(175, 6)
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FavorisToolStripMenuItem1, Me.HistoriqueToolStripMenuItem, Me.TéléchargementsToolStripMenuItem, Me.ToolStripSeparator11, Me.PageDaccueilToolStripMenuItem, Me.ModifierLaPageDaccueilToolStripMenuItem, Me.ToolStripSeparator12, Me.CodeSourceDeLaPageToolStripMenuItem})
        Me.OutilsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'FavorisToolStripMenuItem1
        '
        Me.FavorisToolStripMenuItem1.Image = CType(resources.GetObject("FavorisToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.FavorisToolStripMenuItem1.Name = "FavorisToolStripMenuItem1"
        Me.FavorisToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FavorisToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
        Me.FavorisToolStripMenuItem1.Text = "Favoris"
        '
        'HistoriqueToolStripMenuItem
        '
        Me.HistoriqueToolStripMenuItem.Image = CType(resources.GetObject("HistoriqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistoriqueToolStripMenuItem.Name = "HistoriqueToolStripMenuItem"
        Me.HistoriqueToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HistoriqueToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.HistoriqueToolStripMenuItem.Text = "Historique"
        '
        'TéléchargementsToolStripMenuItem
        '
        Me.TéléchargementsToolStripMenuItem.Image = CType(resources.GetObject("TéléchargementsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TéléchargementsToolStripMenuItem.Name = "TéléchargementsToolStripMenuItem"
        Me.TéléchargementsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.TéléchargementsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.TéléchargementsToolStripMenuItem.Text = "Téléchargements"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(219, 6)
        '
        'PageDaccueilToolStripMenuItem
        '
        Me.PageDaccueilToolStripMenuItem.Image = CType(resources.GetObject("PageDaccueilToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PageDaccueilToolStripMenuItem.Name = "PageDaccueilToolStripMenuItem"
        Me.PageDaccueilToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.PageDaccueilToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.PageDaccueilToolStripMenuItem.Text = "Page d'accueil"
        '
        'ModifierLaPageDaccueilToolStripMenuItem
        '
        Me.ModifierLaPageDaccueilToolStripMenuItem.Name = "ModifierLaPageDaccueilToolStripMenuItem"
        Me.ModifierLaPageDaccueilToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ModifierLaPageDaccueilToolStripMenuItem.Text = "Modifier la page d'accueil..."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(219, 6)
        '
        'CodeSourceDeLaPageToolStripMenuItem
        '
        Me.CodeSourceDeLaPageToolStripMenuItem.CheckOnClick = True
        Me.CodeSourceDeLaPageToolStripMenuItem.Image = CType(resources.GetObject("CodeSourceDeLaPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CodeSourceDeLaPageToolStripMenuItem.Name = "CodeSourceDeLaPageToolStripMenuItem"
        Me.CodeSourceDeLaPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.CodeSourceDeLaPageToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CodeSourceDeLaPageToolStripMenuItem.Text = "Code source de la page"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem, Me.MisesÀJourToolStripMenuItem, Me.ToolStripSeparator9, Me.SupportToolStripMenuItem, Me.ContactToolStripMenuItem, Me.ToolStripSeparator10, Me.ProduitsToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Image = CType(resources.GetObject("AProposToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'MisesÀJourToolStripMenuItem
        '
        Me.MisesÀJourToolStripMenuItem.Image = CType(resources.GetObject("MisesÀJourToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MisesÀJourToolStripMenuItem.Name = "MisesÀJourToolStripMenuItem"
        Me.MisesÀJourToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.MisesÀJourToolStripMenuItem.Text = "Mises à jour"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(138, 6)
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.Image = CType(resources.GetObject("SupportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SupportToolStripMenuItem.Text = "Support"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Image = CType(resources.GetObject("ContactToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(138, 6)
        '
        'ProduitsToolStripMenuItem
        '
        Me.ProduitsToolStripMenuItem.Image = CType(resources.GetObject("ProduitsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProduitsToolStripMenuItem.Name = "ProduitsToolStripMenuItem"
        Me.ProduitsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ProduitsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ProduitsToolStripMenuItem.Text = "Produits"
        '
        'XinBrowserToolStripMenuItem
        '
        Me.XinBrowserToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.XinBrowserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.XinBrowserToolStripMenuItem.Image = CType(resources.GetObject("XinBrowserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.XinBrowserToolStripMenuItem.Name = "XinBrowserToolStripMenuItem"
        Me.XinBrowserToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.XinBrowserToolStripMenuItem.Text = "Xin Browser"
        Me.XinBrowserToolStripMenuItem.Visible = False
        '
        'NavBar
        '
        Me.NavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NavBar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NavBar.Controls.Add(Me.TextBox1)
        Me.NavBar.Controls.Add(Me.PictureBox1)
        Me.NavBar.Controls.Add(Me.Button6)
        Me.NavBar.Controls.Add(Me.Button5)
        Me.NavBar.Controls.Add(Me.Button4)
        Me.NavBar.Controls.Add(Me.Button3)
        Me.NavBar.Controls.Add(Me.Button2)
        Me.NavBar.Controls.Add(Me.Button1)
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavBar.Location = New System.Drawing.Point(0, 24)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(730, 36)
        Me.NavBar.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(144, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(437, 26)
        Me.TextBox1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(116, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(696, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 33)
        Me.Button6.TabIndex = 6
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(625, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 33)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(587, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 33)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(80, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(42, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(4, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FavBar
        '
        Me.FavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FavBar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FavBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FavBar.Location = New System.Drawing.Point(0, 60)
        Me.FavBar.Name = "FavBar"
        Me.FavBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.FavBar.Size = New System.Drawing.Size(730, 25)
        Me.FavBar.TabIndex = 3
        Me.FavBar.Text = "ToolStrip1"
        '
        'WebControl1
        '
        Me.WebControl1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.WebControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl1.Location = New System.Drawing.Point(0, 85)
        Me.WebControl1.Size = New System.Drawing.Size(730, 349)
        Me.WebControl1.Source = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 6
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirLeLienDansUnNouvelOngletToolStripMenuItem, Me.OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem, Me.OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem, Me.EnregistrerLeLienSousToolStripMenuItem, Me.CopierLadresseDuLienToolStripMenuItem, Me.ToolStripSeparator16, Me.EnregistrerLimageToolStripMenuItem, Me.CopierLimageToolStripMenuItem, Me.CopierLurlDeLimageToolStripMenuItem, Me.OuvrirLimageDansUnNouvelOngletToolStripMenuItem, Me.ToolStripSeparator17, Me.PrécédentToolStripMenuItem, Me.SuivantToolStripMenuItem, Me.RafraîchirToolStripMenuItem, Me.ToolStripSeparator14, Me.EnregistrerSousToolStripMenuItem, Me.ImprimerToolStripMenuItem, Me.CodeSourceDeLaPageToolStripMenuItem1, Me.InformationsDeLaPageToolStripMenuItem, Me.ToolStripSeparator15, Me.ExaminerLélémentToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(286, 402)
        '
        'OuvrirLeLienDansUnNouvelOngletToolStripMenuItem
        '
        Me.OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Name = "OuvrirLeLienDansUnNouvelOngletToolStripMenuItem"
        Me.OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Text = "Ouvrir le lien dans un nouvel onglet"
        Me.OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Visible = False
        '
        'OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem
        '
        Me.OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Name = "OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem"
        Me.OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Text = "Ouvrir le lien dans une nouvelle fenêtre"
        Me.OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Visible = False
        '
        'OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem
        '
        Me.OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Name = "OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem"
        Me.OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Text = "Ouvrir le lien en mode navigation privée"
        Me.OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Visible = False
        '
        'EnregistrerLeLienSousToolStripMenuItem
        '
        Me.EnregistrerLeLienSousToolStripMenuItem.Name = "EnregistrerLeLienSousToolStripMenuItem"
        Me.EnregistrerLeLienSousToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.EnregistrerLeLienSousToolStripMenuItem.Text = "Enregistrer le lien sous..."
        '
        'CopierLadresseDuLienToolStripMenuItem
        '
        Me.CopierLadresseDuLienToolStripMenuItem.Name = "CopierLadresseDuLienToolStripMenuItem"
        Me.CopierLadresseDuLienToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.CopierLadresseDuLienToolStripMenuItem.Text = "Copier l'adresse du lien"
        Me.CopierLadresseDuLienToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(282, 6)
        Me.ToolStripSeparator16.Visible = False
        '
        'EnregistrerLimageToolStripMenuItem
        '
        Me.EnregistrerLimageToolStripMenuItem.Name = "EnregistrerLimageToolStripMenuItem"
        Me.EnregistrerLimageToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.EnregistrerLimageToolStripMenuItem.Text = "Enregistrer l'image"
        Me.EnregistrerLimageToolStripMenuItem.Visible = False
        '
        'CopierLimageToolStripMenuItem
        '
        Me.CopierLimageToolStripMenuItem.Name = "CopierLimageToolStripMenuItem"
        Me.CopierLimageToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.CopierLimageToolStripMenuItem.Text = "Copier l'image"
        Me.CopierLimageToolStripMenuItem.Visible = False
        '
        'CopierLurlDeLimageToolStripMenuItem
        '
        Me.CopierLurlDeLimageToolStripMenuItem.Name = "CopierLurlDeLimageToolStripMenuItem"
        Me.CopierLurlDeLimageToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.CopierLurlDeLimageToolStripMenuItem.Text = "Copier l'url de l'image"
        Me.CopierLurlDeLimageToolStripMenuItem.Visible = False
        '
        'OuvrirLimageDansUnNouvelOngletToolStripMenuItem
        '
        Me.OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Name = "OuvrirLimageDansUnNouvelOngletToolStripMenuItem"
        Me.OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Text = "Ouvrir l'image dans un nouvel onglet"
        Me.OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(282, 6)
        Me.ToolStripSeparator17.Visible = False
        '
        'PrécédentToolStripMenuItem
        '
        Me.PrécédentToolStripMenuItem.Name = "PrécédentToolStripMenuItem"
        Me.PrécédentToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.PrécédentToolStripMenuItem.Text = "Précédent"
        '
        'SuivantToolStripMenuItem
        '
        Me.SuivantToolStripMenuItem.Name = "SuivantToolStripMenuItem"
        Me.SuivantToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.SuivantToolStripMenuItem.Text = "Suivant"
        '
        'RafraîchirToolStripMenuItem
        '
        Me.RafraîchirToolStripMenuItem.Name = "RafraîchirToolStripMenuItem"
        Me.RafraîchirToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.RafraîchirToolStripMenuItem.Text = "Rafraîchir"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(282, 6)
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.Image = CType(resources.GetObject("EnregistrerSousToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
        Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.EnregistrerSousToolStripMenuItem.Text = "Enregistrer sous..."
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Image = CType(resources.GetObject("ImprimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.ImprimerToolStripMenuItem.Text = "Imprimer"
        '
        'CodeSourceDeLaPageToolStripMenuItem1
        '
        Me.CodeSourceDeLaPageToolStripMenuItem1.Name = "CodeSourceDeLaPageToolStripMenuItem1"
        Me.CodeSourceDeLaPageToolStripMenuItem1.Size = New System.Drawing.Size(285, 22)
        Me.CodeSourceDeLaPageToolStripMenuItem1.Text = "Code source de la page"
        '
        'InformationsDeLaPageToolStripMenuItem
        '
        Me.InformationsDeLaPageToolStripMenuItem.Name = "InformationsDeLaPageToolStripMenuItem"
        Me.InformationsDeLaPageToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.InformationsDeLaPageToolStripMenuItem.Text = "Informations de la page"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(282, 6)
        '
        'ExaminerLélémentToolStripMenuItem
        '
        Me.ExaminerLélémentToolStripMenuItem.Image = CType(resources.GetObject("ExaminerLélémentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExaminerLélémentToolStripMenuItem.Name = "ExaminerLélémentToolStripMenuItem"
        Me.ExaminerLélémentToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.ExaminerLélémentToolStripMenuItem.Text = "Examiner l'élément"
        '
        'WebControlContextMenu1
        '
        Me.WebControlContextMenu1.Name = "WebControlContextMenu1"
        Me.WebControlContextMenu1.Size = New System.Drawing.Size(204, 126)
        Me.WebControlContextMenu1.View = Nothing
        '
        'HtmlSourcePanel
        '
        Me.HtmlSourcePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.HtmlSourcePanel.Controls.Add(Me.HTMLRichTextBox)
        Me.HtmlSourcePanel.Controls.Add(Me.SearchTextBoxHTML)
        Me.HtmlSourcePanel.Controls.Add(Me.ToolBarHTML)
        Me.HtmlSourcePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HtmlSourcePanel.Location = New System.Drawing.Point(0, 434)
        Me.HtmlSourcePanel.Name = "HtmlSourcePanel"
        Me.HtmlSourcePanel.Size = New System.Drawing.Size(730, 122)
        Me.HtmlSourcePanel.TabIndex = 5
        Me.HtmlSourcePanel.Visible = False
        '
        'HTMLRichTextBox
        '
        Me.HTMLRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.HTMLRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HTMLRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HTMLRichTextBox.ForeColor = System.Drawing.Color.White
        Me.HTMLRichTextBox.Location = New System.Drawing.Point(0, 21)
        Me.HTMLRichTextBox.Name = "HTMLRichTextBox"
        Me.HTMLRichTextBox.Size = New System.Drawing.Size(706, 101)
        Me.HTMLRichTextBox.TabIndex = 1
        Me.HTMLRichTextBox.Text = ""
        '
        'SearchTextBoxHTML
        '
        Me.SearchTextBoxHTML.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchTextBoxHTML.Location = New System.Drawing.Point(0, 0)
        Me.SearchTextBoxHTML.Name = "SearchTextBoxHTML"
        Me.SearchTextBoxHTML.Size = New System.Drawing.Size(706, 21)
        Me.SearchTextBoxHTML.TabIndex = 2
        Me.SearchTextBoxHTML.Text = "Rechercher dans le code html... ('Entrée' pour rechercher)"
        '
        'ToolBarHTML
        '
        Me.ToolBarHTML.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ToolBarHTML.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolBarHTML.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBarHTML.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator13, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolBarHTML.Location = New System.Drawing.Point(706, 0)
        Me.ToolBarHTML.Name = "ToolBarHTML"
        Me.ToolBarHTML.Size = New System.Drawing.Size(24, 122)
        Me.ToolBarHTML.TabIndex = 0
        Me.ToolBarHTML.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripButton1.Text = "Masquer le code source"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(21, 6)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripButton2.Text = "Copier la sélection"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripButton3.Text = "Sélectionner tout"
        '
        'MediaPlayerPanel
        '
        Me.MediaPlayerPanel.BackgroundImage = CType(resources.GetObject("MediaPlayerPanel.BackgroundImage"), System.Drawing.Image)
        Me.MediaPlayerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MediaPlayerPanel.Controls.Add(Me.PdfViewerPanel)
        Me.MediaPlayerPanel.Controls.Add(Me.AxWMPTitleLbl)
        Me.MediaPlayerPanel.Controls.Add(Me.ChromeButton2)
        Me.MediaPlayerPanel.Controls.Add(Me.ChromeButton1)
        Me.MediaPlayerPanel.Controls.Add(Me.PictureBox2)
        Me.MediaPlayerPanel.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.MediaPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaPlayerPanel.Location = New System.Drawing.Point(0, 85)
        Me.MediaPlayerPanel.Name = "MediaPlayerPanel"
        Me.MediaPlayerPanel.Size = New System.Drawing.Size(730, 349)
        Me.MediaPlayerPanel.TabIndex = 7
        Me.MediaPlayerPanel.Visible = False
        '
        'PdfViewerPanel
        '
        Me.PdfViewerPanel.BackgroundImage = CType(resources.GetObject("PdfViewerPanel.BackgroundImage"), System.Drawing.Image)
        Me.PdfViewerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PdfViewerPanel.Controls.Add(Me.AxPDFViewer)
        Me.PdfViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewerPanel.Location = New System.Drawing.Point(0, 0)
        Me.PdfViewerPanel.Name = "PdfViewerPanel"
        Me.PdfViewerPanel.Size = New System.Drawing.Size(730, 349)
        Me.PdfViewerPanel.TabIndex = 8
        Me.PdfViewerPanel.Visible = False
        '
        'AxPDFViewer
        '
        Me.AxPDFViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxPDFViewer.Enabled = True
        Me.AxPDFViewer.Location = New System.Drawing.Point(12, 12)
        Me.AxPDFViewer.Name = "AxPDFViewer"
        Me.AxPDFViewer.OcxState = CType(resources.GetObject("AxPDFViewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPDFViewer.Size = New System.Drawing.Size(706, 322)
        Me.AxPDFViewer.TabIndex = 0
        '
        'AxWMPTitleLbl
        '
        Me.AxWMPTitleLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWMPTitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.AxWMPTitleLbl.ForeColor = System.Drawing.Color.White
        Me.AxWMPTitleLbl.Location = New System.Drawing.Point(51, 18)
        Me.AxWMPTitleLbl.Name = "AxWMPTitleLbl"
        Me.AxWMPTitleLbl.Size = New System.Drawing.Size(655, 18)
        Me.AxWMPTitleLbl.TabIndex = 4
        Me.AxWMPTitleLbl.Text = "Titre.mp3"
        '
        'ChromeButton2
        '
        Me.ChromeButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChromeButton2.BackColor = System.Drawing.Color.Gray
        Me.ChromeButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton2.Image = Nothing
        Me.ChromeButton2.Location = New System.Drawing.Point(574, 107)
        Me.ChromeButton2.Name = "ChromeButton2"
        Me.ChromeButton2.NoRounding = False
        Me.ChromeButton2.Size = New System.Drawing.Size(132, 31)
        Me.ChromeButton2.TabIndex = 3
        Me.ChromeButton2.Text = "Ajouter aux favoris"
        Me.ChromeButton2.Transparent = False
        '
        'ChromeButton1
        '
        Me.ChromeButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChromeButton1.BackColor = System.Drawing.Color.Gray
        Me.ChromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton1.Image = Nothing
        Me.ChromeButton1.Location = New System.Drawing.Point(574, 70)
        Me.ChromeButton1.Name = "ChromeButton1"
        Me.ChromeButton1.NoRounding = False
        Me.ChromeButton1.Size = New System.Drawing.Size(132, 31)
        Me.ChromeButton1.TabIndex = 2
        Me.ChromeButton1.Text = "Télécharger"
        Me.ChromeButton1.Transparent = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 70)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(556, 225)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'WebSessionProvider1
        '
        Me.WebSessionProvider1.DataPath = "C:\Users\Anschaire\Documents\Visual Studio 2012\Projects\Xin Browser\Xin Browser\" & _
    "Xin Browser\bin\Debug\data"
        WebPreferences1.AcceptLanguage = "fr-fr,fr"
        WebPreferences1.AllowInsecureContent = False
        WebPreferences1.CanScriptsAccessClipboard = True
        WebPreferences1.Databases = True
        WebPreferences1.EnableGPUAcceleration = True
        WebPreferences1.FileAccessFromFileURL = True
        WebPreferences1.SmoothScrolling = True
        WebPreferences1.UniversalAccessFromFileURL = True
        WebPreferences1.WebGL = True
        Me.WebSessionProvider1.Preferences = WebPreferences1
        '
        'Onglet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 580)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.MediaPlayerPanel)
        Me.Controls.Add(Me.WebControl1)
        Me.Controls.Add(Me.HtmlSourcePanel)
        Me.Controls.Add(Me.FavBar)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MnuBar)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MnuBar
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(746, 618)
        Me.Name = "Onglet"
        Me.Tag = "onglet"
        Me.Text = "Onglet"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MnuBar.ResumeLayout(False)
        Me.MnuBar.PerformLayout()
        Me.NavBar.ResumeLayout(False)
        Me.NavBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.HtmlSourcePanel.ResumeLayout(False)
        Me.HtmlSourcePanel.PerformLayout()
        Me.ToolBarHTML.ResumeLayout(False)
        Me.ToolBarHTML.PerformLayout()
        Me.MediaPlayerPanel.ResumeLayout(False)
        Me.MediaPlayerPanel.PerformLayout()
        Me.PdfViewerPanel.ResumeLayout(False)
        CType(Me.AxPDFViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MnuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents NavBar As System.Windows.Forms.Panel
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AffichageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FavorisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FavBar As System.Windows.Forms.ToolStrip
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvelOngletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvelleFenêtreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OuvrirUneUrlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirUnePageWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerLaPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimerLaPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropriétésDeLaPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SélectionnerToutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RechercherDansLaPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarreDeMenusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarreDeNavigationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarreDesFavorisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarreDétatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModePleinÉcranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XinBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CadenasSecurity As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents WebControlContextMenu1 As Awesomium.Windows.Forms.WebControlContextMenu
    Friend WithEvents AfficherLesFavorisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfficherLhistoriqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AjouterAuxFavorisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FavorisToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoriqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TéléchargementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeSourceDeLaPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageDaccueilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierLaPageDaccueilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProduitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents FermerCetOngletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PrivateNavigation As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BarreDeMenusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarreDeNavigationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarreDesFavorisToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarreDétatToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HtmlSourcePanel As System.Windows.Forms.Panel
    Friend WithEvents ToolBarHTML As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents HTMLRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SearchTextBoxHTML As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MisesÀJourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrécédentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuivantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RafraîchirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnregistrerSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeSourceDeLaPageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformationsDeLaPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExaminerLélémentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirLeLienDansUnNouvelOngletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierLadresseDuLienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnregistrerLimageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierLimageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierLurlDeLimageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OuvrirLimageDansUnNouvelOngletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerLeLienSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaPlayerPanel As System.Windows.Forms.Panel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ChromeButton2 As Xin_Browser.ChromeButton
    Friend WithEvents ChromeButton1 As Xin_Browser.ChromeButton
    Friend WithEvents AxWMPTitleLbl As System.Windows.Forms.Label
    Friend WithEvents PdfViewerPanel As System.Windows.Forms.Panel
    Friend WithEvents AxPDFViewer As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents WebSessionProvider1 As Awesomium.Windows.Forms.WebSessionProvider
    Friend WithEvents ParamètresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerEtAllerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
