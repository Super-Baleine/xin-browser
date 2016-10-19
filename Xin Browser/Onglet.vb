Imports Awesomium.Core
Imports System.Net

Public Class Onglet
    Private WithEvents ZoomBar1 As New TrackBar
    Dim host As ToolStripControlHost
    Dim fullscreenMode As Boolean = False
    Dim isPrivateNavigation As Boolean = False

    Dim lastUrlTarget As String
    Dim MouseWebX As Integer
    Dim MouseWebY As Integer
    Dim MediaSourceUrl As String

    Private Sub SearchIn(ByVal webControl As Awesomium.Windows.Forms.WebControl)
        'Permet la recherche sur internet si dans la boîte à url, l'url n'en est pas une et donc ainsi une recherche à effectuer sur le web
        If My.Settings.SearchEngineName = "Google" Then
            WebControl1.Source = New Uri("http://www.google.fr/search?q=" & TextBox1.Text)
        ElseIf My.Settings.SearchEngineName = "Yahoo" Then
            WebControl1.Source = New Uri("http://search.yahoo.com/search?q=" & TextBox1.Text)
        ElseIf My.Settings.SearchEngineName = "Bing" Then
            WebControl1.Source = New Uri("http://www.bing.com/search?q=" & TextBox1.Text)
        ElseIf My.Settings.SearchEngineName = "DuckDuckGo" Then
            WebControl1.Source = New Uri("http://duckduckgo.com/?q=" & TextBox1.Text)
        ElseIf My.Settings.SearchEngineName = "Qwant" Then
            WebControl1.Source = New Uri("http://www.qwant.com/?q=" & TextBox1.Text)
        End If
    End Sub

    Private Sub AddNewDownload(ByVal Uri As Uri, ByVal Path As String)
        'Ajoute un nouveau téléchargement si détecté dans la navigation sur le web
        Dim nd As New FileDownload
        nd.DownloadURL = Uri
        nd.DownloadPath = Path
        nd.SetInfos()
        nd.StartDownload()
        nd.Dock = DockStyle.Top
        DownloadForm.DownloadsContainer.Controls.Add(nd)
        DownloadForm.Show()
    End Sub

    Public Function GetFileNameFromURL(ByVal URL As String) As String
        Try
            Return URL.Substring(URL.LastIndexOf("/") + 1)
        Catch ex As Exception
            Return URL
        End Try
    End Function

    Private Sub CheckForDownloads(ByVal Url As Uri)
        'Vérifie si il y a présence d'un fichier internet à télécharger pendant la navigation
        Dim sd As New SaveFileDialog
        sd.Title = "Enregistrer sous..."
        sd.FileName = GetFileNameFromURL(Url.ToString)
        If Url.ToString.EndsWith(".exe") Then
            sd.Filter = "Fichier exécutable (*.exe)|*.exe"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".msi") Then
            sd.Filter = "Fichier d'installation microsoft (*.msi)|*.msi"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".dmg") Then
            sd.Filter = "Installateur Mac OS X (*.dmg)|*.dmg"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".app") Then
            sd.Filter = "Application Mac OS X (*.app)|*.app"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".rar") Then
            sd.Filter = "Archive RAR (*.rar)|*.rar"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".tar") Then
            sd.Filter = "Archive TAR (*.tar)|*.tar"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".tgz") Then
            sd.Filter = "Archive TGZ (*.tgz)|*.tgz"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".zip") Then
            sd.Filter = "Archive de fichiers compressés (*.zip)|*.zip"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".7z") Then
            sd.Filter = "Archive 7ZIP (*.7z)|*.7z"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".gz") Then
            sd.Filter = "Archive GZ (*.gz)|*.gz"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".tar.gz") Then
            sd.Filter = "Archive TAR.GZ (*.tar.gz)|*.tar.gz"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".aac") Then
            sd.Filter = "Encodage Audio (*.aac)|*.aac"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".asx") Then
            sd.Filter = "Flux Radio Windows Media Player (*.asx)|*.asx"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".aup") Then
            sd.Filter = "Fichier de projet audacity (*.aup)|*.aup"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".cda") Then
            sd.Filter = "Piste audio (*.cda)|*.cda"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".flac") Then
            sd.Filter = "Codec Audio (*.flac)|*.flac"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".flv") Then
            sd.Filter = "Vidéo Flash (*.flv)|*.flv"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".exe") Then
            sd.Filter = "Fichier exécutable (*.exe)|*.exe"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".m3u") Then
            sd.Filter = "Audio MPEG 3.0 URL (*.m3u)|*.m3u"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mp2") Then
            sd.Filter = "Audio MPEG Audio Layer 2 (*.mp2)|*.mp2"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mp3") Then
            'sd.Filter = "Audio MPEG Audio Layer 3 (*.mp3)|*.mp3"
            'If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
            'AddNewDownload(Url, sd.FileName)
            'End If
        End If

        If Url.ToString.EndsWith(".ogg") Then
            sd.Filter = "Fichier Audio Compressé (*.ogg)|*.ogg"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ogm") Then
            sd.Filter = "Média OGG (*.ogm)|*.ogm"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".song") Then
            sd.Filter = "Fichier musical audacity (*.song)|*.song"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".wma") Then
            sd.Filter = "Windows Media Audio (*.wma)|*.wma"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".avi") Then
            sd.Filter = "Média Audio/Vidéo (*.avi)|*.avi"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".divx") Then
            sd.Filter = "Média DIVX (*.divx)|*.divx"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".m4a") Then
            sd.Filter = "MPEG 4 (*.m4a)|*.m4a"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mov") Then
            sd.Filter = "Vidéo QuickTime (*.mov)|*.mov"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mpeg") Then
            sd.Filter = "Média Vidéo MPEG (*.mpeg)|*.mpeg"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".wmv") Then
            sd.Filter = "Windows Media Vidéo (*.wmv)|*.wmv"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mkv") Then
            sd.Filter = "Média Vidéo MKV (*.mkv)|*.mkv"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mid") Then
            sd.Filter = "Fichier MID (*.mid)|*.mid"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".midi") Then
            sd.Filter = "Fichier MIDI (*.midi)|*.midi"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".abw") Then
            sd.Filter = "Document AbiWord (*.abw)|*.abw"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".doc") Then
            sd.Filter = "Document Word 97-2003 (*.doc)|*.doc"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".docx") Then
            sd.Filter = "Document Word 2007-2013 (*.docx)|*.docx"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".docm") Then
            sd.Filter = "Document Word 97-2003 avec macros (*.docm)|*.docm"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".docx") Then
            sd.Filter = " (*.docx)|*.docx"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".odb") Then
            sd.Filter = "Base de données OpenDocument (*.odb)|*.odb"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".odc") Then
            sd.Filter = "Diagramme OpenDocument (*.odc)|*.odc"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".odf") Then
            sd.Filter = "Formule OpenDocument (*.odf)|*.odf"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".odg") Then
            sd.Filter = "Dessin OpenDocument (*.odg)|*.odg"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".odp") Then
            sd.Filter = "Présentation OpenDocument (*.odp)|*.odp"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ods") Then
            sd.Filter = "Classeur OpenDocument (*.ods)|*.ods"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".odt") Then
            sd.Filter = "Document Texte OpenDocument (*.odt)|*.odt"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".pages") Then
            sd.Filter = "Document Pages Apple (*.pages)|*.pages"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".pdf") Then
            sd.Filter = "Portable Document File (*.pdf)|*.pdf"
            Dim result As MsgBoxResult = MsgBox("Voulez-vous ouvrir le fichier PDF dans le navigateur ?" & vbNewLine & "En cas de refus, le fichier sera automatiquement téléchargé", MsgBoxStyle.YesNo, "Ouvrir le fichier dans le navigateur")
            If result = MsgBoxResult.Yes Then
                'Afficher le fichier PDF
                MediaPlayerPanel.Visible = True
                PdfViewerPanel.Visible = True
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                AxWindowsMediaPlayer1.URL = Nothing
                AxPDFViewer.src = Url.ToString

                WebControl1.Source = New Uri("about:blank")
                TextBox1.Text = "xinbrowser://pdfviewer"
                Me.Text = AxWindowsMediaPlayer1.currentMedia.name & " (Lecteur PDF)"
                Me.Icon = Principal.Icon
            Else
                If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    AddNewDownload(Url, sd.FileName)
                End If
            End If
        End If

        If Url.ToString.EndsWith(".pps") Then
            sd.Filter = "Présentation PowerPoint (*.pps)|*.pps"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ppt") Then
            sd.Filter = "Présentation PowerPoint 97-2003 (*.ppt)|*.ppt"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".pptx") Then
            sd.Filter = "Présentation PowerPoint 2007-2013 (*.pptx)|*.pptx"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".pub") Then
            sd.Filter = "Document Microsoft Publisher (*.pub)|*.pub"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".rtf") Then
            sd.Filter = "Document RTF (*.rtf)|*.rtf"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".txt") Then
            sd.Filter = "Fichier Texte (*.txt)|*.txt"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".xls") Then
            sd.Filter = "Classeur Excel 97-2003 (*.xls)|*.xls"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".xlsx") Then
            sd.Filter = "Classeur Excel 2007-2013 (*.xlsx)|*.xlsx"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".xlsm") Then
            sd.Filter = "Classeur Excel avec macros (*.xlsm)|*.xlsm"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".bmp") Then
            sd.Filter = "Image Bitmap (*.bmp)|*.bmp"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".gif") Then
            sd.Filter = "Image animée (*.gif)|*.gif"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".jpg") Then
            sd.Filter = "Image JPG (*.jpg)|*.jpg"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".jpeg") Then
            sd.Filter = "Image JPEG (*.jpeg)|*.jpeg"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".png") Then
            sd.Filter = "Portable Graphics Network (*.png)|*.png"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".tiff") Then
            sd.Filter = "Image TIFF (*.tiff)|*.tiff"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".tif") Then
            sd.Filter = "Image TIF (*.tif)|*.tif"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ico") Then
            sd.Filter = "Icône Windows (*.ico)|*.ico"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".icns") Then
            sd.Filter = "Icône Apple (*.icns)|*.icns"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".pfi") Then
            sd.Filter = "Image Photofiltre (*.pfi)|*.pfi"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".xls") Then
            sd.Filter = " (*.xls)|*.xls"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ai") Then
            sd.Filter = "Document Adobe Illustrator (*.ai)|*.ai"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ani") Then
            sd.Filter = "Curseur animé (*.ani)|*.ani"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".apk") Then
            sd.Filter = "Application Android (*.apk)|*.apk"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".bak") Then
            sd.Filter = "Fichier Backup (*.bak)|*.bak"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".bat") Then
            sd.Filter = "Batch Windows (*.bat)|*.bat"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".bin") Then
            sd.Filter = "Fichier BIN (*.bin)|*.bin"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".bsp") Then
            sd.Filter = "Fichier Map (*.bsp)|*.bsp"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".bz") Then
            sd.Filter = "Archive BZ (*.bz)|*.bz"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".bz2") Then
            sd.Filter = "Archive BZ2 (*.bz2)|*.bz2"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".c4d") Then
            sd.Filter = "Cinema4D modèle 3D (*.c4d)|*.c4d"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".class") Then
            sd.Filter = "Classe java (*.class)|*.class"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".cmd") Then
            sd.Filter = "Commande (*.cmd)|*.cmd"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".config") Then
            sd.Filter = "Fichier de configuration (*.config)|*.config"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".cpp") Then
            sd.Filter = "Classe C++ (*.cpp)|*.cpp"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".cur") Then
            sd.Filter = "Curseur (*.cur)|*.cur"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".dds") Then
            sd.Filter = "Textures DDS (*.dds)|*.dds"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".dll") Then
            sd.Filter = "Bibliothèque de classes (*.dll)|*.dll"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".h") Then
            sd.Filter = "C++ Classe Header (*.h)|*.h"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".cs") Then
            sd.Filter = "Fichier de code C# (*.cs)|*.cs"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".inf") Then
            sd.Filter = "Fichier autorun  (*.inf)|*.inf"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ipa") Then
            sd.Filter = "Application iOS (*.ipa)|*.ipa"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".iso") Then
            sd.Filter = "Image disque (*.iso)|*.iso"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".iss") Then
            sd.Filter = "Script d'installation Inno Setup (*.iss)|*.iss"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".3ds") Then
            sd.Filter = "Modèle 3DMAX  (*.3ds)|*.3ds"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".jar") Then
            sd.Filter = "Exécutable/Archive JAR (*.jar)|*.jar"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".js") Then
            sd.Filter = "Script Javascript (*.js)|*.js"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".lnk") Then
            sd.Filter = "Raccourci (*.lnk)|*.lnk"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".lic") Then
            sd.Filter = "Fichier license (*.lic)|*.lic"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".licx") Then
            sd.Filter = "Fichier license (*.licx)|*.licx"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".log") Then
            sd.Filter = "Fichier LOG (*.log)|*.log"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".lua") Then
            sd.Filter = "Script LUA (*.lua)|*.lua"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".lwo") Then
            sd.Filter = "Modèle 3D LWO (*.lwo)|*.lwo"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".m") Then
            sd.Filter = "C++ Classe Main (*.m)|*.m"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".max") Then
            sd.Filter = "Modèle 3D (*.max)|*.max"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mda") Then
            sd.Filter = "Add-In pour Microsoft Access (*.mda)|*.mda"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mdb") Then
            sd.Filter = "Base de données Microsoft Access (*.mdb)|*.mdb"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mdf") Then
            sd.Filter = "Fichier principal de base de données (*.mdf)|*.mdf"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".msc") Then
            sd.Filter = "Fichier console d'administration windows (*.msc)|*.msc"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".mtl") Then
            sd.Filter = "Modèle 3D (*.mtl)|*.mtl"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".nfo") Then
            sd.Filter = "Informations Système (*.nfo)|*.nfo"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".obj") Then
            sd.Filter = "Modèle 3D (*.obj)|*.obj"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".old") Then
            sd.Filter = "Fichier de sauvegarde (*.old)|*.old"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".psd") Then
            sd.Filter = "Document Photoshop (*.psd)|*.psd"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".sln") Then
            sd.Filter = "Solution Visual Studio (*.sln)|*.sln"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".sql") Then
            sd.Filter = "Base de données SQL (*.sql)|*.sql"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".ttf") Then
            sd.Filter = "Police de caractère (*.ttf)|*.ttf"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".vb") Then
            sd.Filter = "Fichier de code VB/VB.NET(*.vb)|*.vb"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".vbproj") Then
            sd.Filter = "Projet VB (*.vbproj)|*.vbproj"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".csproj") Then
            sd.Filter = "Projet CS (*.csproj)|*.csproj"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".yml") Then
            sd.Filter = "Configuration YML (*.yml)|*.yml"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If

        If Url.ToString.EndsWith(".torrent") Then
            sd.Filter = "Fichier TORRENT (*.torrent)|*.torrent"
            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                AddNewDownload(Url, sd.FileName)
            End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Onglet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mise en place des thèmes sur le logiciel
        MnuBar.Renderer = New ToolStripProfessionalRenderer(New Themes.XinBrowserOrangeTheme)
        FavBar.Renderer = New ToolStripProfessionalRenderer(New Themes.XinBrowserOrangeTheme)
        StatusStrip1.Renderer = New ToolStripProfessionalRenderer(New Themes.XinBrowserOrangeTheme)
        'Attribution des paramètres du curseur de zoom
        ZoomBar1.TickStyle = TickStyle.None
        ZoomBar1.Maximum = 9
        ZoomBar1.Value = 4
        ZoomBar1.AutoSize = False
        ZoomBar1.BackColor = Color.FromArgb(44, 44, 44)
        ZoomBar1.Size = New Size(New Point(80, 16))

        'Ajout du curseur de zoom dans la statusstrip
        host = New ToolStripControlHost(ZoomBar1)
        StatusStrip1.Items.Add(host)

        'Vérification des paramètres d'affichage de menus
        MnuBar.Visible = My.Settings.mnubarVisible
        NavBar.Visible = My.Settings.navbarVisible
        FavBar.Visible = My.Settings.favbarVisible
        StatusStrip1.Visible = My.Settings.statusbarVisible

        'Ajout des favoris dans la barre des favoris
        For Each i As String In My.Settings.favlist
            Dim favbutton As New ToolStripButton
            Dim a As Array = i.Split("|")
            Dim a1 As Array = a(1).ToString.Split("/")
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
            favbutton.Text = a(0)
            favbutton.Tag = a(1)
            favbutton.ForeColor = Color.White
            FavBar.Items.Add(favbutton)
        Next

        'Vérification des affichages de menus, si aucun n'est affiché alors on affiche automatiquement la barre de navigation pour permettre à l'utilisateur de continuer à interagir avec le logiciel ainsi que de réafficher les autres menus
        If My.Settings.mnubarVisible = False And My.Settings.navbarVisible = False And My.Settings.favbarVisible = False And My.Settings.statusbarVisible = False Then
            NavBar.Visible = True
        End If
    End Sub

    Private Sub ZoomBar1_Scroll(sender As Object, e As EventArgs) Handles ZoomBar1.Scroll
        'Vérification de la valeur attribué au curseur de zoom pour attribuer le niveau de zoom au noyau web
        If ZoomBar1.Value = 0 Then
            WebControl1.Zoom = 25
            ZoomLbl.Text = "25%"
        ElseIf ZoomBar1.Value = 1 Then
            WebControl1.Zoom = 33
            ZoomLbl.Text = "33%"
        ElseIf ZoomBar1.Value = 2 Then
            WebControl1.Zoom = 50
            ZoomLbl.Text = "50%"
        ElseIf ZoomBar1.Value = 3 Then
            WebControl1.Zoom = 75
            ZoomLbl.Text = "75%"
        ElseIf ZoomBar1.Value = 4 Then
            WebControl1.Zoom = 100
            ZoomLbl.Text = "100%"
        ElseIf ZoomBar1.Value = 5 Then
            WebControl1.Zoom = 110
            ZoomLbl.Text = "110%"
        ElseIf ZoomBar1.Value = 6 Then
            WebControl1.Zoom = 125
            ZoomLbl.Text = "125%"
        ElseIf ZoomBar1.Value = 7 Then
            WebControl1.Zoom = 133
            ZoomLbl.Text = "133%"
        ElseIf ZoomBar1.Value = 8 Then
            WebControl1.Zoom = 200
            ZoomLbl.Text = "200%"
        ElseIf ZoomBar1.Value = 9 Then
            WebControl1.Zoom = 500
            ZoomLbl.Text = "500%"
        End If
    End Sub

    Private Sub NouvelOngletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelOngletToolStripMenuItem.Click
        'Création d'une nouvelle fenêtre (mdi)
        Dim dlg As New Onglet
        'Vérification du paramètre 'Charger la page d'accueil lors de l'ouverture d'un nouvel onglet' pour l'exécuter ou non
        If My.Settings.loadhomepageatnewtab = True Then
            dlg.WebControl1.Source = New Uri(My.Settings.homepage)
        End If
        'Ajout de la fenêtre (mdi) en tant qu'onglet
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub NouvelleFenêtreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleFenêtreToolStripMenuItem.Click
        'Ouvre une nouvelle fenêtre
        Dim dlg As New Principal
        dlg.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Navigation < retour
        WebControl1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Navigation > suivant
        WebControl1.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Exécute un script pour rafraîchir la page web
        WebControl1.ExecuteJavascript("window.location.reload()")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text.Contains("xinbrowser://") Then
            If TextBox1.Text = "xinbrowser://about" Then
                WebControl1.Source = New Uri("file:///" & Application.StartupPath & "\html\about.html")
            ElseIf TextBox1.Text = "xinbrowser://favourites" Then
                If Principal.TabControl1.TabPages.Count = 1 Then
                    NouvelOngletToolStripMenuItem.PerformClick()
                    FavList.Show()
                    Me.Close()
                    FavList.BringToFront()
                End If
            ElseIf TextBox1.Text = "xinbrowser://history" Then
                If Principal.TabControl1.TabPages.Count = 1 Then
                    NouvelOngletToolStripMenuItem.PerformClick()
                    HistList.Show()
                    Me.Close()
                    HistList.BringToFront()
                End If
            ElseIf TextBox1.Text = "xinbrowser://downloads" Then
                If Principal.TabControl1.TabPages.Count = 1 Then
                    NouvelOngletToolStripMenuItem.PerformClick()
                    DownloadForm.Show()
                    Me.Close()
                    DownloadForm.BringToFront()
                End If
            ElseIf TextBox1.Text = "xinbrowser://home" Then
                WebControl1.Source = New Uri("http://www.google.fr/")
            ElseIf TextBox1.Text = "xinbrowser://settings" Then
                WebControl1.Source = New Uri("file:///" & Application.StartupPath & "\html\settings.html")
            End If
        End If
        Try
            If TextBox1.Text.StartsWith("http://") Or TextBox1.Text.StartsWith("https://") Or TextBox1.Text.StartsWith("ftp://") Or TextBox1.Text.StartsWith("file:") Then
                WebControl1.Source = New Uri(TextBox1.Text)
            ElseIf TextBox1.Text.StartsWith("www") Then
                WebControl1.Source = New Uri("http://" & TextBox1.Text)
            Else
                If TextBox1.Text.EndsWith(".com") Or TextBox1.Text.EndsWith(".fr") Or TextBox1.Text.EndsWith(".net") Or TextBox1.Text.EndsWith(".org") Or TextBox1.Text.EndsWith(".co.uk") Then
                    WebControl1.Source = New Uri("http://www." & TextBox1.Text)
                Else
                    SearchIn(WebControl1)
                End If
            End If
        Catch ex2 As Exception
            MsgBox("Le format URL n'est pas valide, Xin Browser ne peut pas charger ce format d'url", MsgBoxStyle.Critical, "Erreur dans le format de l'url")
        End Try

        Try
            CheckForDownloads(New Uri(TextBox1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OuvrirUneUrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirUneUrlToolStripMenuItem.Click
        TextBox1.Focus()
    End Sub

    Private Sub OuvrirUnePageWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirUnePageWebToolStripMenuItem.Click
        Dim dlg As New OpenFileDialog
        dlg.Title = "Ouvrir une page web"
        dlg.Multiselect = True
        dlg.Filter = "Page web (*.html;*.htm)|*.html;*.htm"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each i As String In dlg.FileNames
                Dim tab As New Onglet
                tab.WebControl1.Source = New Uri(i)
                Principal.TabControl1.TabPages.Add(tab)
            Next
        End If
    End Sub

    Private Sub EnregistrerLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerLaPageToolStripMenuItem.Click
        Dim dlg As New SaveFileDialog
        dlg.Title = "Enregistrer la page sous..."
        dlg.Filter = "Page web (*.html;*.htm)|*.html;*.htm"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rtb As New RichTextBox
            rtb.Text = WebControl1.HTML
            rtb.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ImprimerLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerLaPageToolStripMenuItem.Click
        WebControl1.ExecuteJavascriptWithResult("window.print()")
    End Sub

    Private Sub PropriétésDeLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriétésDeLaPageToolStripMenuItem.Click
        MsgBox(WebControl1.Title & vbNewLine & WebControl1.Source.ToString, MsgBoxStyle.Information, "Propriétés de la page")
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Principal.Close()
    End Sub

    Private Sub FermerCetOngletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerCetOngletToolStripMenuItem.Click
        Principal.TabControl1.TabPages.Remove(Principal.TabControl1.TabPages.SelectedTab)
    End Sub

    Private Sub CouperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouperToolStripMenuItem.Click
        WebControl1.Cut()
    End Sub

    Private Sub CopierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem.Click
        WebControl1.Copy()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem.Click
        WebControl1.Paste()
    End Sub

    Private Sub SélectionnerToutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SélectionnerToutToolStripMenuItem.Click
        WebControl1.SelectAll()
    End Sub

    Private Sub RechercherDansLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechercherDansLaPageToolStripMenuItem.Click
        Dim strtofind As String = InputBox("Entrez le mot à rechercher:", "Rechercher sur la page")
        If Not strtofind = Nothing Then
            WebControl1.ExecuteJavascript("window.find(""" + strtofind + """, false, false);")
        End If
    End Sub

    Private Sub AffichageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffichageToolStripMenuItem.Click
        BarreDeMenusToolStripMenuItem.Checked = My.Settings.mnubarVisible
        BarreDeNavigationToolStripMenuItem.Checked = My.Settings.navbarVisible
        BarreDesFavorisToolStripMenuItem.Checked = My.Settings.favbarVisible
        BarreDétatToolStripMenuItem.Checked = My.Settings.statusbarVisible
        ModePleinÉcranToolStripMenuItem.Checked = fullscreenMode
    End Sub

    Private Sub BarreDeMenusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarreDeMenusToolStripMenuItem.Click
        MnuBar.Visible = BarreDeMenusToolStripMenuItem.Checked
        My.Settings.mnubarVisible = BarreDeMenusToolStripMenuItem.Checked
        My.Settings.Save()
    End Sub

    Private Sub BarreDeNavigationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarreDeNavigationToolStripMenuItem.Click
        NavBar.Visible = BarreDeNavigationToolStripMenuItem.Checked
        My.Settings.navbarVisible = BarreDeNavigationToolStripMenuItem.Checked
        My.Settings.Save()
    End Sub

    Private Sub BarreDesFavorisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarreDesFavorisToolStripMenuItem.Click
        FavBar.Visible = BarreDesFavorisToolStripMenuItem.Checked
        My.Settings.favbarVisible = BarreDesFavorisToolStripMenuItem.Checked
        My.Settings.Save()
    End Sub

    Private Sub BarreDétatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarreDétatToolStripMenuItem.Click
        StatusStrip1.Visible = BarreDétatToolStripMenuItem.Checked
        My.Settings.statusbarVisible = BarreDétatToolStripMenuItem.Checked
        My.Settings.Save()
    End Sub

    Private Sub ModePleinÉcranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModePleinÉcranToolStripMenuItem.Click
        If fullscreenMode = True Then
            fullscreenMode = False
            Principal.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Principal.WindowState = FormWindowState.Normal
        Else
            fullscreenMode = True
            Principal.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Principal.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub FavorisToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FavorisToolStripMenuItem.DropDownItemClicked
        If e.ClickedItem.Text = "Afficher les favoris" Then
            FavList.Show()
        ElseIf e.ClickedItem.Text = "Afficher l'historique" Then
            HistList.Show()
        ElseIf e.ClickedItem.Text = "Ajouter aux favoris" Then
            FavAdding.SetInfos(WebControl1.Source, WebControl1.Title, FavBar)
            FavAdding.ShowDialog()
        Else
            Dim ong As New Onglet
            ong.WebControl1.Source = New Uri(e.ClickedItem.Tag)
            Principal.TabControl1.TabPages.Add(ong)
        End If
    End Sub

    Private Sub FavorisToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FavorisToolStripMenuItem1.Click
        FavList.Show()
    End Sub

    Private Sub HistoriqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriqueToolStripMenuItem.Click
        HistList.Show()
    End Sub

    Private Sub TéléchargementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TéléchargementsToolStripMenuItem.Click
        DownloadForm.Show()
    End Sub

    Private Sub PageDaccueilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageDaccueilToolStripMenuItem.Click
        WebControl1.Source = New Uri(My.Settings.homepage)
    End Sub

    Private Sub ModifierLaPageDaccueilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierLaPageDaccueilToolStripMenuItem.Click
        Dim result As MsgBoxResult = MsgBox("Voulez-vous définir la page courante en tant que page d'accueil ?", MsgBoxStyle.YesNo, "Modifier la page d'accueil")
        If result = MsgBoxResult.Yes Then
            My.Settings.homepage = WebControl1.Source.ToString
            My.Settings.Save()
        Else
            Dim newpage As String = InputBox("Entrez l'adresse web à définir en tant que page d'accueil:")
            If newpage = Nothing Then
                My.Settings.homepage = "about:blank"
                My.Settings.Save()
                MsgBox("La page d'accueil a été définie avec 'about:blank', le champ d'entrée étant vide", MsgBoxStyle.Exclamation)
            Else
                My.Settings.homepage = WebControl1.Source.ToString
                My.Settings.Save()
                MsgBox("La page d'accueil a été définie avec '" & WebControl1.Source.ToString & "', le champ d'entrée étant vide", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub CodeSourceDeLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeSourceDeLaPageToolStripMenuItem.Click
        Dim isChecked As Boolean = CodeSourceDeLaPageToolStripMenuItem.Checked
        If isChecked = True Then
            HTMLRichTextBox.Text = WebControl1.ExecuteJavascriptWithResult("document.documentElement.outerHTML").ToString()
            HtmlSourcePanel.Visible = True
        Else
            HtmlSourcePanel.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dlg As New FavAdding
        dlg.SetInfos(WebControl1.Source, WebControl1.Title, FavBar)
        dlg.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DownloadForm.Show()
    End Sub

    Private Sub NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleFenêtreEnNavigationPrivéeToolStripMenuItem.Click
        Dim wd As New Onglet
        wd.isPrivateNavigation = True
        Principal.TabControl1.TabPages.Add(wd)
        Principal.TabControl1.TabPages.SelectedTab.BackHighColor = Color.Orange
        Principal.TabControl1.TabPages.SelectedTab.BackLowColor = Color.DarkOrange
        Principal.TabControl1.TabPages.SelectedTab.BackLowColorDisabled = Color.BurlyWood
        Principal.TabControl1.TabPages.SelectedTab.BackHighColorDisabled = Color.BurlyWood
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        BarreDeMenusToolStripMenuItem1.Checked = My.Settings.mnubarVisible
        BarreDeNavigationToolStripMenuItem1.Checked = My.Settings.navbarVisible
        BarreDesFavorisToolStripMenuItem1.Checked = My.Settings.favbarVisible
        BarreDétatToolStripMenuItem1.Checked = My.Settings.statusbarVisible
    End Sub

    Private Sub BarreDeMenusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarreDeMenusToolStripMenuItem1.Click
        MnuBar.Visible = BarreDeMenusToolStripMenuItem1.Checked
        My.Settings.mnubarVisible = BarreDeMenusToolStripMenuItem1.Checked
        My.Settings.Save()
    End Sub

    Private Sub BarreDeNavigationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarreDeNavigationToolStripMenuItem1.Click
        NavBar.Visible = BarreDeNavigationToolStripMenuItem1.Checked
        My.Settings.navbarVisible = BarreDeNavigationToolStripMenuItem1.Checked
        My.Settings.Save()
    End Sub

    Private Sub BarreDesFavorisToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarreDesFavorisToolStripMenuItem1.Click
        FavBar.Visible = BarreDesFavorisToolStripMenuItem1.Checked
        My.Settings.favbarVisible = BarreDesFavorisToolStripMenuItem1.Checked
        My.Settings.Save()
    End Sub

    Private Sub BarreDétatToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarreDétatToolStripMenuItem1.Click
        StatusStrip1.Visible = BarreDétatToolStripMenuItem1.Checked
        My.Settings.statusbarVisible = BarreDétatToolStripMenuItem1.Checked
        My.Settings.Save()
    End Sub

    Private Sub FavorisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavorisToolStripMenuItem.Click
        FavorisToolStripMenuItem.DropDownItems.Clear()
        FavBar.Items.Clear()

        Dim mnuitem As ToolStripMenuItem
        mnuitem = New ToolStripMenuItem
        mnuitem.Text = "Afficher les favoris"
        FavorisToolStripMenuItem.DropDownItems.Add(mnuitem)

        mnuitem = New ToolStripMenuItem
        mnuitem.Text = "Afficher l'historique"
        FavorisToolStripMenuItem.DropDownItems.Add(mnuitem)

        FavorisToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator)

        mnuitem = New ToolStripMenuItem
        mnuitem.Text = "Ajouter aux favoris"
        FavorisToolStripMenuItem.DropDownItems.Add(mnuitem)

        FavorisToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator)

        For Each i As String In My.Settings.favlist
            mnuitem = New ToolStripMenuItem
            Dim favbutton As New ToolStripButton
            Dim a As Array = i.Split("|")
            Dim a1 As Array = a(1).ToString.Split("/")
            Try
                Dim iconURL As String = "http://" & a1(2) & "/favicon.ico"
                Dim web As New Net.WebClient
                Dim ms As New IO.MemoryStream(web.DownloadData(iconURL))
                Dim icon As New Icon(ms)
                favbutton.Image = icon.ToBitmap
                mnuitem.Image = icon.ToBitmap
                If icon Is Nothing Then
                    favbutton.Image = Principal.Icon.ToBitmap
                    mnuitem.Image = Principal.Icon.ToBitmap
                End If
            Catch ex As Exception
                favbutton.Image = Principal.Icon.ToBitmap
                mnuitem.Image = Principal.Icon.ToBitmap
            End Try
            favbutton.Text = a(0)
            favbutton.Tag = a(1)
            favbutton.ForeColor = Color.White
            mnuitem.Text = a(0)
            mnuitem.Tag = a(1)

            FavorisToolStripMenuItem.DropDownItems.Add(mnuitem)
            FavBar.Items.Add(favbutton)
        Next
    End Sub

    Private Sub FavBar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FavBar.ItemClicked
        Dim ong As New Onglet
        ong.WebControl1.Source = New Uri(e.ClickedItem.Tag)
        Principal.TabControl1.TabPages.Add(ong)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "xinbrowser://about" Then
                WebControl1.Source = New Uri("file:///" & Application.StartupPath & "\html\about.html")
            ElseIf TextBox1.Text = "xinbrowser://favourites" Then
                If Principal.TabControl1.TabPages.Count = 1 Then
                    NouvelOngletToolStripMenuItem.PerformClick()
                    FavList.Show()
                    Me.Close()
                    FavList.BringToFront()
                End If
            ElseIf TextBox1.Text = "xinbrowser://history" Then
                If Principal.TabControl1.TabPages.Count = 1 Then
                    NouvelOngletToolStripMenuItem.PerformClick()
                    HistList.Show()
                    Me.Close()
                    HistList.BringToFront()
                End If
            ElseIf TextBox1.Text = "xinbrowser://downloads" Then
                If Principal.TabControl1.TabPages.Count = 1 Then
                    NouvelOngletToolStripMenuItem.PerformClick()
                    DownloadForm.Show()
                    Me.Close()
                    DownloadForm.BringToFront()
                End If
            ElseIf TextBox1.Text = "xinbrowser://home" Then
                WebControl1.Source = New Uri("http://www.google.fr/")
            ElseIf TextBox1.Text = "xinbrowser://settings" Then
                WebControl1.Source = New Uri("file:///" & Application.StartupPath & "\html\settings.html")
            End If
            Try
                If TextBox1.Text.StartsWith("http://") Or TextBox1.Text.StartsWith("https://") Or TextBox1.Text.StartsWith("ftp://") Or TextBox1.Text.StartsWith("file:") Then
                    WebControl1.Source = New Uri(TextBox1.Text)
                ElseIf TextBox1.Text.StartsWith("www") Then
                    WebControl1.Source = New Uri("http://" & TextBox1.Text)
                Else
                    If TextBox1.Text.EndsWith(".com") Or TextBox1.Text.EndsWith(".fr") Or TextBox1.Text.EndsWith(".net") Or TextBox1.Text.EndsWith(".org") Or TextBox1.Text.EndsWith(".co.uk") Then
                        WebControl1.Source = New Uri("http://www." & TextBox1.Text)
                    Else
                        SearchIn(WebControl1)
                    End If
                End If
            Catch ex2 As Exception
                MsgBox("Le format URL n'est pas valide, Xin Browser ne peut pas charger ce format d'url", MsgBoxStyle.Critical, "Erreur dans le format de l'url")
            End Try
            Try
                CheckForDownloads(New Uri(TextBox1.Text))
            Catch ex As Exception

            End Try
        End If

        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            TextBox1.Clear()
            TextBox1.Paste()
            e.Handled = True
        End If
    End Sub

    Private Sub WebControl1_Click(sender As Object, e As EventArgs) Handles WebControl1.Click
        'Détection des téléchargements
        Try
            CheckForDownloads(New Uri(lastUrlTarget))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebControl1_Crashed(sender As Object, e As CrashedEventArgs) Handles WebControl1.Crashed
        'Crashé
        Dim ans As MsgBoxResult = MsgBox("La page actuelle ne répond plus, voulez-vous fermer la fenêtre ?", MsgBoxStyle.YesNo, "La page ne répond plus")
        If ans = MsgBoxResult.Yes Then
            If Principal.TabControl1.TabPages.Count = 1 Then
                End
            Else
                Principal.TabControl1.TabPages.Remove(Principal.TabControl1.TabPages.SelectedTab)
            End If
        End If
    End Sub

    Private Sub WebControl1_DocumentReady(sender As Object, e As UrlEventArgs) Handles WebControl1.DocumentReady
        If e.Url.ToString.EndsWith(".mp3") Then
            MediaPlayerPanel.Visible = True
            PdfViewerPanel.Visible = False
            AxWindowsMediaPlayer1.URL = e.Url.ToString
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            AxWMPTitleLbl.Text = AxWindowsMediaPlayer1.currentMedia.name
            WebControl1.Source = New Uri("about:blank")
            TextBox1.Text = "xinbrowser://audioplayer"
            Me.Text = AxWindowsMediaPlayer1.currentMedia.name & " (Lecteur Audio)"
            Me.Icon = Principal.Icon
            'WebControl1.Source = New Uri(Application.StartupPath & "\html\audioplayer.html")
            'Dim rtb As New RichTextBox
            'rtb.LoadFile(Application.StartupPath & "\html\audioplayer.html")
            'rtb.Text.Replace("myURL", e.Url.ToString)
            'WebControl1.LoadHTML(rtb.Text)
        ElseIf WebControl1.TargetURL.ToString.EndsWith(".pdf") Then
            'Voir CheckForDownloads()
        Else
            MediaPlayerPanel.Visible = False
            PdfViewerPanel.Visible = False
            TextBox1.Text = WebControl1.Source.ToString
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.URL = Nothing
        End If
        Dim oURL As Uri = New Uri(WebControl1.Source.AbsoluteUri)
        If oURL.HostNameType = UriHostNameType.Dns Then
            Try
                Dim iconURL As String = "http://" & oURL.Host & "/favicon.ico"
                Dim web As New Net.WebClient
                Dim ms As New IO.MemoryStream(web.DownloadData(iconURL))
                Dim icon As New Icon(ms)
                Me.Icon = icon
                PictureBox1.Image = icon.ToBitmap
                If icon Is Nothing Then
                    Me.Icon = Principal.Icon
                    PictureBox1.Image = Principal.Icon.ToBitmap
                End If
            Catch ex As Exception
                Me.Icon = Principal.Icon
                PictureBox1.Image = Principal.Icon.ToBitmap
            End Try
        End If

        'Vérification site sécurisé (https)
        If e.Url.ToString.Contains("https://") Then
            CadenasSecurity.Visible = True
            TextBox1.ForeColor = Color.LimeGreen
        Else
            CadenasSecurity.Visible = False
            TextBox1.ForeColor = Color.Black
        End If

        'Url personnalisées
        Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
        Dim ff As String = Strings.Replace(f1, " ", "%20")
        If e.Url.ToString = "file:///" & ff & "/html/about.html" Then
            TextBox1.Text = "xinbrowser://about"
            'Changement du numéro de version de Xin Browser
            WebControl1.ExecuteJavascript("document.getElementById(" & """currentvers""" & ").innerHTML = """ & "Version installée: " & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." & My.Application.Info.Version.Build.ToString & """;")
        End If
        If e.Url.ToString = "file:///" & ff & "/html/audioplayer.html" Then
            TextBox1.Text = "xinbrowser://audioplayer"
        End If
        If e.Url.ToString = "file:///" & ff & "/html/settings.html" Then
            TextBox1.Text = "xinbrowser://settings"
            'Chargement des paramètres
            'Page d'accueil
            WebControl1.ExecuteJavascript("document.getElementById(" & """homepageTextBox""" & ").value =""" & My.Settings.homepage & """" & ";")
            'Moteur de recherche
            If My.Settings.SearchEngineName = "Google" Then
                WebControl1.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = true;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "Bing" Then
                WebControl1.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = true;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "Yahoo" Then
                WebControl1.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = true;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "DuckDuckGo" Then
                WebControl1.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = true;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "Qwant" Then
                WebControl1.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                WebControl1.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = true;")
            End If
            'Emplacement des téléchargements
            If My.Settings.choosedownloadplace = True Then
                WebControl1.ExecuteJavascript("document.getElementById(" & """autosavedownload""" & ").checked = true;")
            Else
                WebControl1.ExecuteJavascript("document.getElementById(" & """autosavedownload""" & ").checked = false;")
            End If
        End If

        If e.Url.ToString = "xinbrowser://updates" Then
            'Vérifier les mises à jour
            MisesÀJourToolStripMenuItem.PerformClick()
        End If

        If TextBox1.Text.Contains("xinbrowser://") Then
            TextBox1.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub WebControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles WebControl1.MouseClick
        'Détection des téléchargements
        CheckForDownloads(New Uri(lastUrlTarget))
    End Sub

    Private Sub WebControl1_ShowCreatedWebView(sender As Object, e As ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView
        If e.IsPopup = True Then
            If My.Settings.blockpopup = False Then
                Dim window As New Onglet
                window.MnuBar.Enabled = False
                window.StatusStrip1.Enabled = False
                window.Button1.Visible = False
                window.Button2.Visible = False
                window.Button3.Visible = False
                window.Button4.Visible = False
                window.Button5.Visible = False
                window.Button6.Visible = False
                window.TextBox1.Size = New Size(New Point(window.Width - 20, 24))
                window.TextBox1.Location = New Point(5, 5)
                window.WebControl1.Source = e.OpenerURL
                window.Tag = Nothing
                window.Show()
            Else
                Dim result As MsgBoxResult = MsgBox("La protection anti-popup a détecté une fenêtre pop-up, voulez-vous l'ouvrir ?", MsgBoxStyle.YesNo, "Protection anti-popup")
                If result = MsgBoxResult.Yes Then
                    Dim window As New Onglet
                    window.MnuBar.Enabled = False
                    window.StatusStrip1.Enabled = False
                    window.Button1.Visible = False
                    window.Button2.Visible = False
                    window.Button3.Visible = False
                    window.Button4.Visible = False
                    window.Button5.Visible = False
                    window.Button6.Visible = False
                    window.TextBox1.Size = New Size(New Point(window.Width - 20, 24))
                    window.TextBox1.Location = New Point(5, 5)
                    window.WebControl1.Source = e.OpenerURL
                    window.Tag = Nothing
                    window.Show()
                End If
            End If
        End If
        If e.IsWindowOpen = True Then
            Dim window As New Onglet
            window.WebControl1.Source = e.OpenerURL
            Principal.TabControl1.TabPages.Add(window)
        End If
        Dim Link As String = WebControl1.Source.ToString()
        Dim Req As Net.HttpWebRequest = _
        CType(Net.WebRequest.Create(Link), Net.HttpWebRequest)
        Req.Credentials = Net.CredentialCache.DefaultCredentials

        'Prepares to probe the link
        Dim Res As Net.HttpWebResponse = Nothing
        Dim ValidLink As Boolean
        Try
            'Tries to get the an ok response from the server
            Res = CType(Req.GetResponse(), Net.HttpWebResponse)
            ValidLink = True

        Catch Ex As Net.WebException
        Finally
            If Res IsNot Nothing Then Res.Close()
        End Try
    End Sub

    Private Sub WebControl1_ShowJavascriptDialog(sender As Object, e As JavascriptDialogEventArgs) Handles WebControl1.ShowJavascriptDialog
        e.Handled = True
        e.Cancel = True
        If e.Message = "xinbrowser://favourites" Then
            AfficherLesFavorisToolStripMenuItem.PerformClick()
        ElseIf e.Message = "xinbrowser://history" Then
            HistoriqueToolStripMenuItem.PerformClick()
        ElseIf e.Message = "xinbrowser://downloads" Then
            TéléchargementsToolStripMenuItem.PerformClick()
        ElseIf e.Message = "xinbrowser://updates" Then
            MisesÀJourToolStripMenuItem.PerformClick()
        ElseIf e.Message.StartsWith("searchengine|") Then
            Dim a As Array = e.Message.Split("|")
            My.Settings.SearchEngineName = a(1)
            My.Settings.SearchEngineURL = a(2)
            My.Settings.Save()
        ElseIf e.Message.StartsWith("homepage|") Then
            Dim a As Array = e.Message.Split("|")
            My.Settings.homepage = a(1)
            My.Settings.Save()
        Else
            Dim dlg As New JSAlertPopUp
            dlg.MsgBody.Text = e.Message
            dlg.ShowDialog()
        End If
    End Sub

    Private Sub WebControl1_TargetURLChanged(sender As Object, e As UrlEventArgs) Handles WebControl1.TargetURLChanged
        If Not e.Url.ToString = "about:blank" Then
            ToolStripStatusLabel2.Text = e.Url.ToString
        End If
        If e.Url = Nothing Then
            ToolStripStatusLabel2.Text = Nothing
        End If
        lastUrlTarget = e.Url.ToString
    End Sub

    Private Sub WebControl1_TitleChanged(sender As Object, e As TitleChangedEventArgs) Handles WebControl1.TitleChanged
        If isPrivateNavigation = False Then
            My.Settings.histlist.Add(WebControl1.Title & "|" & WebControl1.Source.ToString & "|" & My.Computer.Clock.LocalTime.ToShortDateString & " - " & My.Computer.Clock.LocalTime.ToShortTimeString)
            My.Settings.Save()
            PrivateNavigation.Visible = False
        Else
            PrivateNavigation.Visible = True
        End If
        Me.Text = e.Title
    End Sub

    Private Sub ZoomLbl_Click(sender As Object, e As EventArgs) Handles ZoomLbl.Click
        ZoomBar1.Value = 4
        WebControl1.Zoom = 100
        ZoomLbl.Text = "100%"
    End Sub

    Private Sub FichierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichierToolStripMenuItem.Click
        If Principal.TabControl1.TabPages.Count = 1 Then
            FermerCetOngletToolStripMenuItem.Enabled = False
        Else
            FermerCetOngletToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        HTMLRichTextBox.Copy()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CodeSourceDeLaPageToolStripMenuItem.Checked = False
        HtmlSourcePanel.Visible = False
    End Sub

    Private Sub TextBox1_KeyDown_1(sender As Object, e As KeyEventArgs) Handles SearchTextBoxHTML.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim index As Integer = 0
            Dim temp As String = HTMLRichTextBox.Text
            HTMLRichTextBox.Text = ""
            HTMLRichTextBox.Text = temp

            While index < HTMLRichTextBox.Text.LastIndexOf(SearchTextBoxHTML.Text)
                HTMLRichTextBox.Find(SearchTextBoxHTML.Text, index, HTMLRichTextBox.TextLength, RichTextBoxFinds.None)
                HTMLRichTextBox.SelectionBackColor = Color.DarkRed
                index = HTMLRichTextBox.Text.IndexOf(SearchTextBoxHTML.Text, index) + 1
            End While
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        HTMLRichTextBox.SelectionStart = 0
        HTMLRichTextBox.SelectionLength = HTMLRichTextBox.Text.Length
    End Sub

    Private Sub SupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri("https://sites.google.com/site/xinloxx/nagisa")
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri("https://sites.google.com/site/xinloxx/nagisa")
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub ProduitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduitsToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri("https://sites.google.com/site/xinloxx/misaki")
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri("file:///" & Application.StartupPath & "\html\about.html")
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub MisesÀJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisesÀJourToolStripMenuItem.Click
        Dim myVersion As String = My.Application.Info.Version.ToString
        Dim client As New WebClient
        Dim newVersion As String = client.DownloadString("https://dl.dropboxusercontent.com/u/56127675/XinLoxx/Xin%20Browser/version.txt")
        If myVersion < newVersion Then
            'Mise à jour disponible !
            Dim ans As MsgBoxResult = MsgBox("Une mise à jour est disponible, souhaitez-vous la télécharger maintenant ?", MsgBoxStyle.YesNo, "Mise à jour disponible !")
            If ans = MsgBoxResult.Yes Then
                Dim myUrl As String = client.DownloadString("https://dl.dropboxusercontent.com/u/56127675/XinLoxx/Xin%20Browser/url.txt")
                Dim dlg As New Onglet
                dlg.WebControl1.Source = New Uri(myUrl)
                Principal.TabControl1.TabPages.Add(dlg)
            End If
        Else
            'Pas de mises à jour !
            MsgBox("Vous possédez la dernière version de Xin Browser ! (Version: " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & ")", MsgBoxStyle.Information, "Mises à jour")
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Focus()
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_LoginRequest(sender As Object, e As LoginRequestEventArgs) Handles WebControl1.LoginRequest
        Dim dlg As New LoginRequestForm
        dlg.Label2.Text = e.Info.RequestURL & " (" & e.Info.Host & ")"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            e.Username = dlg.TextBox1.Text
            e.Password = dlg.TextBox2.Text
        ElseIf dlg.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowContextMenu(sender As Object, e As ContextMenuEventArgs) Handles WebControl1.ShowContextMenu
        If e.Info.MediaType = MediaType.None Then
            OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Visible = False
            OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Visible = False
            OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Visible = False
            EnregistrerLeLienSousToolStripMenuItem.Visible = False
            CopierLadresseDuLienToolStripMenuItem.Visible = False
            ToolStripSeparator16.Visible = False
            EnregistrerLimageToolStripMenuItem.Visible = False
            CopierLimageToolStripMenuItem.Visible = False
            CopierLurlDeLimageToolStripMenuItem.Visible = False
            OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Visible = False
            ToolStripSeparator17.Visible = False
            PrécédentToolStripMenuItem.Visible = True
            SuivantToolStripMenuItem.Visible = True
            RafraîchirToolStripMenuItem.Visible = True
            ToolStripSeparator14.Visible = True
            EnregistrerSousToolStripMenuItem.Visible = True
            ImprimerToolStripMenuItem.Visible = True
            CodeSourceDeLaPageToolStripMenuItem1.Visible = True
            InformationsDeLaPageToolStripMenuItem.Visible = True
            e.Handled = True
            ContextMenuStrip2.Show(New Point(WebControl1.Location.X + e.Info.MouseX, WebControl1.Location.Y + e.Info.MouseY), ToolStripDropDownDirection.Default)
        ElseIf e.Info.MediaType = MediaType.Image Then
            OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Visible = True
            OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Visible = True
            OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Visible = True
            EnregistrerLeLienSousToolStripMenuItem.Visible = True
            CopierLadresseDuLienToolStripMenuItem.Visible = True
            ToolStripSeparator16.Visible = True
            EnregistrerLimageToolStripMenuItem.Visible = True
            CopierLimageToolStripMenuItem.Visible = True
            CopierLurlDeLimageToolStripMenuItem.Visible = True
            OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Visible = True
            ToolStripSeparator17.Visible = True
            PrécédentToolStripMenuItem.Visible = False
            SuivantToolStripMenuItem.Visible = False
            RafraîchirToolStripMenuItem.Visible = False
            ToolStripSeparator14.Visible = False
            EnregistrerSousToolStripMenuItem.Visible = False
            ImprimerToolStripMenuItem.Visible = True
            CodeSourceDeLaPageToolStripMenuItem1.Visible = False
            InformationsDeLaPageToolStripMenuItem.Visible = False
            e.Handled = True
            ContextMenuStrip2.Show(New Point(WebControl1.Location.X + e.Info.MouseX, WebControl1.Location.Y + e.Info.MouseY), ToolStripDropDownDirection.Default)
        ElseIf e.Info.HasLinkURL = True Then
            OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Visible = True
            OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Visible = True
            OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Visible = True
            EnregistrerLeLienSousToolStripMenuItem.Visible = True
            CopierLadresseDuLienToolStripMenuItem.Visible = True
            ToolStripSeparator16.Visible = False
            EnregistrerLimageToolStripMenuItem.Visible = False
            CopierLimageToolStripMenuItem.Visible = False
            CopierLurlDeLimageToolStripMenuItem.Visible = False
            OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Visible = False
            ToolStripSeparator17.Visible = False
            PrécédentToolStripMenuItem.Visible = True
            SuivantToolStripMenuItem.Visible = True
            RafraîchirToolStripMenuItem.Visible = True
            ToolStripSeparator14.Visible = True
            EnregistrerSousToolStripMenuItem.Visible = True
            ImprimerToolStripMenuItem.Visible = True
            CodeSourceDeLaPageToolStripMenuItem1.Visible = True
            InformationsDeLaPageToolStripMenuItem.Visible = True
            e.Handled = True
            ContextMenuStrip2.Show(New Point(WebControl1.Location.X + e.Info.MouseX, WebControl1.Location.Y + e.Info.MouseY), ToolStripDropDownDirection.Default)
        ElseIf e.Info.MediaType = MediaType.Audio And e.Info.MediaState = MediaState.CanSave Then
            OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Visible = True
            OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Visible = True
            OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Visible = True
            EnregistrerLeLienSousToolStripMenuItem.Visible = True
            CopierLadresseDuLienToolStripMenuItem.Visible = True
            ToolStripSeparator16.Visible = False
            EnregistrerLimageToolStripMenuItem.Visible = False
            CopierLimageToolStripMenuItem.Visible = False
            CopierLurlDeLimageToolStripMenuItem.Visible = False
            OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Visible = False
            ToolStripSeparator17.Visible = False
            PrécédentToolStripMenuItem.Visible = True
            SuivantToolStripMenuItem.Visible = True
            RafraîchirToolStripMenuItem.Visible = True
            ToolStripSeparator14.Visible = True
            EnregistrerSousToolStripMenuItem.Visible = True
            ImprimerToolStripMenuItem.Visible = True
            CodeSourceDeLaPageToolStripMenuItem1.Visible = True
            InformationsDeLaPageToolStripMenuItem.Visible = True
            e.Handled = True
            ContextMenuStrip2.Show(New Point(WebControl1.Location.X + e.Info.MouseX, WebControl1.Location.Y + e.Info.MouseY), ToolStripDropDownDirection.Default)
        End If
        MouseWebX = e.Info.MouseX
        MouseWebY = e.Info.MouseY
        MediaSourceUrl = e.Info.SourceURL.ToString
    End Sub

    Private Sub OuvrirLeLienDansUnNouvelOngletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLeLienDansUnNouvelOngletToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri(MediaSourceUrl)
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLeLienDansUneNouvelleFenêtreToolStripMenuItem.Click
        Dim pra As New Principal
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri(MediaSourceUrl)
        pra.TabControl1.TabPages.Add(dlg)
        pra.Show()
    End Sub

    Private Sub OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLeLienEnModeNavigationPrivéeToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.isPrivateNavigation = True
        dlg.WebControl1.Source = New Uri(MediaSourceUrl)
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub EnregistrerLeLienSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerLeLienSousToolStripMenuItem.Click
        Dim dlg As New SaveFileDialog
        dlg.Title = "Enregistrer le lien sous..."
        Dim filt_filename As String = GetFileNameFromURL(MediaSourceUrl)
        Dim filt As String = IO.Path.GetExtension(filt_filename)
        dlg.Filter = "Fichier " & filt & "|*" & filt
        dlg.FileName = IO.Path.GetFileNameWithoutExtension(filt_filename)
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddNewDownload(New Uri(MediaSourceUrl), dlg.FileName)
        End If
    End Sub

    Private Sub CopierLadresseDuLienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLadresseDuLienToolStripMenuItem.Click
        WebControl1.CopyLinkAddress()
        If Clipboard.GetText() = Nothing Then
            Clipboard.SetText(MediaSourceUrl)
        End If
    End Sub

    Private Sub EnregistrerLimageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerLimageToolStripMenuItem.Click
        WebControl1.SaveImageAt(MouseWebX, MouseWebY)
    End Sub

    Private Sub CopierLimageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLimageToolStripMenuItem.Click
        WebControl1.CopyImageAt(MouseWebX, MouseWebY)
    End Sub

    Private Sub CopierLurlDeLimageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLurlDeLimageToolStripMenuItem.Click
        WebControl1.CopyLinkAddress()
    End Sub

    Private Sub OuvrirLimageDansUnNouvelOngletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLimageDansUnNouvelOngletToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri(MediaSourceUrl)
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub PrécédentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrécédentToolStripMenuItem.Click
        WebControl1.GoBack()
    End Sub

    Private Sub SuivantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuivantToolStripMenuItem.Click
        WebControl1.GoForward()
    End Sub

    Private Sub RafraîchirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RafraîchirToolStripMenuItem.Click
        WebControl1.ExecuteJavascript("window.location.reload()")
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        Dim dlg As New SaveFileDialog
        dlg.Title = "Enregistrer la page sous..."
        dlg.Filter = "Page web (*.html;*.htm)|*.html;*.htm"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rtb As New RichTextBox
            rtb.Text = WebControl1.HTML
            rtb.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem.Click
        WebControl1.ExecuteJavascriptWithResult("window.print()")
    End Sub

    Private Sub CodeSourceDeLaPageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CodeSourceDeLaPageToolStripMenuItem1.Click
        CodeSourceDeLaPageToolStripMenuItem.Checked = True
        HTMLRichTextBox.Text = WebControl1.ExecuteJavascriptWithResult("document.documentElement.outerHTML").ToString()
        HtmlSourcePanel.Visible = True
    End Sub

    Private Sub InformationsDeLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationsDeLaPageToolStripMenuItem.Click
        MsgBox(WebControl1.Title & vbNewLine & WebControl1.Source.ToString, MsgBoxStyle.Information, "Propriétés de la page")
    End Sub

    Private Sub ExaminerLélémentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExaminerLélémentToolStripMenuItem.Click
        CodeSourceDeLaPageToolStripMenuItem.Checked = True
        HTMLRichTextBox.Text = WebControl1.ExecuteJavascriptWithResult("document.documentElement.outerHTML").ToString()
        HtmlSourcePanel.Visible = True

        Dim index As Integer = 0
        Dim temp As String = HTMLRichTextBox.Text
        HTMLRichTextBox.Text = ""
        HTMLRichTextBox.Text = temp

        While index < HTMLRichTextBox.Text.LastIndexOf(MediaSourceUrl)
            HTMLRichTextBox.Find(MediaSourceUrl, index, HTMLRichTextBox.TextLength, RichTextBoxFinds.None)
            HTMLRichTextBox.SelectionBackColor = Color.DarkRed
            index = HTMLRichTextBox.Text.IndexOf(MediaSourceUrl, index) + 1
        End While
    End Sub

    Private Sub ChromeButton1_Click(sender As Object, e As EventArgs) Handles ChromeButton1.Click
        Dim sd As New SaveFileDialog
        sd.Title = "Enregistrer sous..."
        sd.FileName = GetFileNameFromURL(AxWindowsMediaPlayer1.URL.ToString)
        sd.Filter = "Fichier audio MP3 (*.mp3)|*.mp3"
        If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddNewDownload(New Uri(AxWindowsMediaPlayer1.URL), sd.FileName)
        End If
    End Sub

    Private Sub ChromeButton2_Click(sender As Object, e As EventArgs) Handles ChromeButton2.Click
        Dim dlg As New FavAdding
        dlg.SetInfos(New Uri(AxWindowsMediaPlayer1.URL), GetFileNameFromURL(AxWindowsMediaPlayer1.URL), FavBar)
        dlg.ShowDialog()
    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Focus()
    End Sub

    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        Dim dlg As New Onglet
        dlg.WebControl1.Source = New Uri("file:///" & Application.StartupPath & "\html\settings.html")
        Principal.TabControl1.TabPages.Add(dlg)
    End Sub

    Private Sub CollerEtAllerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerEtAllerToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox1.Paste()
        WebControl1.Source = New Uri(TextBox1.Text)
    End Sub
End Class