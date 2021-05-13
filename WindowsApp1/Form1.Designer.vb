<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnDownload = New Bunifu.Framework.UI.BunifuTileButton()
        Me.url = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PanelTitleBar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnExit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelTitleBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.Maroon
        Me.btnDownload.color = System.Drawing.Color.Maroon
        Me.btnDownload.colorActive = System.Drawing.Color.Red
        Me.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownload.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDownload.Image = Global.WindowsApp1.My.Resources.Resources.download_logo
        Me.btnDownload.ImagePosition = 0
        Me.btnDownload.ImageZoom = 30
        Me.btnDownload.LabelPosition = 25
        Me.btnDownload.LabelText = "Download"
        Me.btnDownload.Location = New System.Drawing.Point(239, 111)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(88, 54)
        Me.btnDownload.TabIndex = 5
        '
        'url
        '
        Me.url.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.url.BorderColorFocused = System.Drawing.Color.MediumSeaGreen
        Me.url.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.url.BorderColorMouseHover = System.Drawing.Color.SeaGreen
        Me.url.BorderThickness = 3
        Me.url.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.url.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.url.ForeColor = System.Drawing.Color.Gray
        Me.url.isPassword = False
        Me.url.Location = New System.Drawing.Point(114, 59)
        Me.url.Margin = New System.Windows.Forms.Padding(4)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(370, 44)
        Me.url.TabIndex = 4
        Me.url.Text = "Insert URL address here"
        Me.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackgroundImage = CType(resources.GetObject("PanelTitleBar.BackgroundImage"), System.Drawing.Image)
        Me.PanelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.Label1)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.GradientBottomLeft = System.Drawing.Color.Maroon
        Me.PanelTitleBar.GradientBottomRight = System.Drawing.Color.Red
        Me.PanelTitleBar.GradientTopLeft = System.Drawing.Color.Maroon
        Me.PanelTitleBar.GradientTopRight = System.Drawing.Color.Maroon
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Quality = 10
        Me.PanelTitleBar.Size = New System.Drawing.Size(584, 40)
        Me.PanelTitleBar.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.ActiveBorderThickness = 1
        Me.btnExit.ActiveCornerRadius = 20
        Me.btnExit.ActiveFillColor = System.Drawing.Color.Red
        Me.btnExit.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.ButtonText = " X"
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.IdleBorderThickness = 1
        Me.btnExit.IdleCornerRadius = 20
        Me.btnExit.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnExit.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(550, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(29, 41)
        Me.btnExit.TabIndex = 0
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Youtube Downloader"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.beautiful_color_ui_gradients_backgrounds_bloody_mary
        Me.Panel1.Controls.Add(Me.btnDownload)
        Me.Panel1.Controls.Add(Me.url)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 252)
        Me.Panel1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitleBar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents url As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnDownload As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
End Class
