<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.MailButton = New System.Windows.Forms.Button()
        Me.MessagerButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.PhotosButton = New System.Windows.Forms.Button()
        Me.VideosButton = New System.Windows.Forms.Button()
        Me.PlayerButton = New System.Windows.Forms.Button()
        Me.TypeWWWButton = New System.Windows.Forms.Button()
        Me.RecentButton = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.Fav3Button = New System.Windows.Forms.Button()
        Me.Fav2Button = New System.Windows.Forms.Button()
        Me.Fav1Button = New System.Windows.Forms.Button()
        Me.SaveFavButton = New System.Windows.Forms.Button()
        Me.FavsButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(0)
        Me.WebBrowser1.MaximumSize = New System.Drawing.Size(640, 480)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(640, 480)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("data:Loading", System.UriKind.Absolute)
        '
        'lstHistory
        '
        Me.lstHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.HorizontalScrollbar = True
        Me.lstHistory.Location = New System.Drawing.Point(652, 25)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(120, 459)
        Me.lstHistory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(689, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "History"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 526)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(154, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 510)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Page Loading (%):"
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(331, 484)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 75)
        Me.Label3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(549, 485)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Keyboard Buttons"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(339, 500)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(44, 23)
        Me.HomeButton.TabIndex = 7
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'MailButton
        '
        Me.MailButton.Location = New System.Drawing.Point(389, 500)
        Me.MailButton.Name = "MailButton"
        Me.MailButton.Size = New System.Drawing.Size(44, 23)
        Me.MailButton.TabIndex = 8
        Me.MailButton.Text = "Mail"
        Me.MailButton.UseVisualStyleBackColor = True
        '
        'MessagerButton
        '
        Me.MessagerButton.Location = New System.Drawing.Point(439, 500)
        Me.MessagerButton.Name = "MessagerButton"
        Me.MessagerButton.Size = New System.Drawing.Size(44, 23)
        Me.MessagerButton.TabIndex = 10
        Me.MessagerButton.Text = "Msgr"
        Me.MessagerButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(489, 500)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(55, 23)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'PhotosButton
        '
        Me.PhotosButton.Location = New System.Drawing.Point(550, 500)
        Me.PhotosButton.Name = "PhotosButton"
        Me.PhotosButton.Size = New System.Drawing.Size(55, 23)
        Me.PhotosButton.TabIndex = 12
        Me.PhotosButton.Text = "Photos"
        Me.PhotosButton.UseVisualStyleBackColor = True
        '
        'VideosButton
        '
        Me.VideosButton.Location = New System.Drawing.Point(611, 500)
        Me.VideosButton.Name = "VideosButton"
        Me.VideosButton.Size = New System.Drawing.Size(55, 23)
        Me.VideosButton.TabIndex = 13
        Me.VideosButton.Text = "Videos"
        Me.VideosButton.UseVisualStyleBackColor = True
        '
        'PlayerButton
        '
        Me.PlayerButton.Location = New System.Drawing.Point(672, 500)
        Me.PlayerButton.Name = "PlayerButton"
        Me.PlayerButton.Size = New System.Drawing.Size(55, 23)
        Me.PlayerButton.TabIndex = 14
        Me.PlayerButton.Text = "Player"
        Me.PlayerButton.UseVisualStyleBackColor = True
        '
        'TypeWWWButton
        '
        Me.TypeWWWButton.Location = New System.Drawing.Point(672, 526)
        Me.TypeWWWButton.Name = "TypeWWWButton"
        Me.TypeWWWButton.Size = New System.Drawing.Size(49, 23)
        Me.TypeWWWButton.TabIndex = 21
        Me.TypeWWWButton.Text = "WWW"
        Me.TypeWWWButton.UseVisualStyleBackColor = True
        '
        'RecentButton
        '
        Me.RecentButton.Location = New System.Drawing.Point(613, 526)
        Me.RecentButton.Name = "RecentButton"
        Me.RecentButton.Size = New System.Drawing.Size(53, 23)
        Me.RecentButton.TabIndex = 20
        Me.RecentButton.Text = "Recent"
        Me.RecentButton.UseVisualStyleBackColor = True
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(560, 526)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(45, 23)
        Me.MenuButton.TabIndex = 19
        Me.MenuButton.Text = "Menu"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'Fav3Button
        '
        Me.Fav3Button.Location = New System.Drawing.Point(507, 526)
        Me.Fav3Button.Name = "Fav3Button"
        Me.Fav3Button.Size = New System.Drawing.Size(44, 23)
        Me.Fav3Button.TabIndex = 18
        Me.Fav3Button.Text = "#3"
        Me.Fav3Button.UseVisualStyleBackColor = True
        '
        'Fav2Button
        '
        Me.Fav2Button.Location = New System.Drawing.Point(457, 526)
        Me.Fav2Button.Name = "Fav2Button"
        Me.Fav2Button.Size = New System.Drawing.Size(44, 23)
        Me.Fav2Button.TabIndex = 17
        Me.Fav2Button.Text = "#2"
        Me.Fav2Button.UseVisualStyleBackColor = True
        '
        'Fav1Button
        '
        Me.Fav1Button.Location = New System.Drawing.Point(407, 526)
        Me.Fav1Button.Name = "Fav1Button"
        Me.Fav1Button.Size = New System.Drawing.Size(44, 23)
        Me.Fav1Button.TabIndex = 16
        Me.Fav1Button.Text = "#1"
        Me.Fav1Button.UseVisualStyleBackColor = True
        '
        'SaveFavButton
        '
        Me.SaveFavButton.Location = New System.Drawing.Point(339, 526)
        Me.SaveFavButton.Name = "SaveFavButton"
        Me.SaveFavButton.Size = New System.Drawing.Size(62, 23)
        Me.SaveFavButton.TabIndex = 15
        Me.SaveFavButton.Text = "Save Fav"
        Me.SaveFavButton.UseVisualStyleBackColor = True
        '
        'FavsButton
        '
        Me.FavsButton.Location = New System.Drawing.Point(728, 500)
        Me.FavsButton.Name = "FavsButton"
        Me.FavsButton.Size = New System.Drawing.Size(44, 23)
        Me.FavsButton.TabIndex = 22
        Me.FavsButton.Text = "Favs"
        Me.FavsButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(727, 526)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(45, 23)
        Me.BackButton.TabIndex = 23
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.FavsButton)
        Me.Controls.Add(Me.TypeWWWButton)
        Me.Controls.Add(Me.RecentButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.Fav3Button)
        Me.Controls.Add(Me.Fav2Button)
        Me.Controls.Add(Me.Fav1Button)
        Me.Controls.Add(Me.SaveFavButton)
        Me.Controls.Add(Me.PlayerButton)
        Me.Controls.Add(Me.VideosButton)
        Me.Controls.Add(Me.PhotosButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.MessagerButton)
        Me.Controls.Add(Me.MailButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstHistory)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.Text = "tv2js"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents lstHistory As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HomeButton As Button
    Friend WithEvents MailButton As Button
    Friend WithEvents MessagerButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents PhotosButton As Button
    Friend WithEvents VideosButton As Button
    Friend WithEvents PlayerButton As Button
    Friend WithEvents TypeWWWButton As Button
    Friend WithEvents RecentButton As Button
    Friend WithEvents MenuButton As Button
    Friend WithEvents Fav3Button As Button
    Friend WithEvents Fav2Button As Button
    Friend WithEvents Fav1Button As Button
    Friend WithEvents SaveFavButton As Button
    Friend WithEvents FavsButton As Button
    Friend WithEvents BackButton As Button
End Class
