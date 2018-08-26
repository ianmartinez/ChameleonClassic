<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAdjustAero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAdjustAero))
        Me.btnClose = New Tundra.StylizedButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbGlassReflectionIntensity = New TrackBar.Dotnetrix.Controls.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbBlurBalance = New TrackBar.Dotnetrix.Controls.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAfterglowBalance = New TrackBar.Dotnetrix.Controls.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAfterglow = New Tundra.StylizedColorButton()
        Me.btnMainColor = New Tundra.StylizedColorButton()
        Me.cbTransparency = New System.Windows.Forms.CheckBox()
        Me.tbColorBalance = New TrackBar.Dotnetrix.Controls.TrackBar()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBack = New Tundra.DoubleBufferedPanel()
        Me.btnSave = New Tundra.StylizedButton()
        Me.btnOpen = New Tundra.StylizedButton()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.tbGlassReflectionIntensity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBlurBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAfterglowBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbColorBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(325, 284)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnClose.Size = New System.Drawing.Size(101, 28)
        Me.btnClose.Style = resources.GetString("btnClose.Style")
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 36)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Glass Reflection Intensity:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbGlassReflectionIntensity
        '
        Me.tbGlassReflectionIntensity.AutoSize = False
        Me.tbGlassReflectionIntensity.BackColor = System.Drawing.SystemColors.Control
        Me.tbGlassReflectionIntensity.LargeChange = 20
        Me.tbGlassReflectionIntensity.Location = New System.Drawing.Point(188, 212)
        Me.tbGlassReflectionIntensity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbGlassReflectionIntensity.Maximum = 120
        Me.tbGlassReflectionIntensity.Name = "tbGlassReflectionIntensity"
        Me.tbGlassReflectionIntensity.Size = New System.Drawing.Size(239, 36)
        Me.tbGlassReflectionIntensity.TabIndex = 29
        Me.tbGlassReflectionIntensity.TickFrequency = 10
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 36)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Blur Balance:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbBlurBalance
        '
        Me.tbBlurBalance.AutoSize = False
        Me.tbBlurBalance.BackColor = System.Drawing.SystemColors.Control
        Me.tbBlurBalance.LargeChange = 20
        Me.tbBlurBalance.Location = New System.Drawing.Point(188, 169)
        Me.tbBlurBalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbBlurBalance.Maximum = 120
        Me.tbBlurBalance.Name = "tbBlurBalance"
        Me.tbBlurBalance.Size = New System.Drawing.Size(239, 36)
        Me.tbBlurBalance.TabIndex = 27
        Me.tbBlurBalance.TickFrequency = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 36)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Afterglow Balance:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbAfterglowBalance
        '
        Me.tbAfterglowBalance.AutoSize = False
        Me.tbAfterglowBalance.BackColor = System.Drawing.SystemColors.Control
        Me.tbAfterglowBalance.LargeChange = 20
        Me.tbAfterglowBalance.Location = New System.Drawing.Point(188, 126)
        Me.tbAfterglowBalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbAfterglowBalance.Maximum = 120
        Me.tbAfterglowBalance.Name = "tbAfterglowBalance"
        Me.tbAfterglowBalance.Size = New System.Drawing.Size(239, 36)
        Me.tbAfterglowBalance.TabIndex = 25
        Me.tbAfterglowBalance.TickFrequency = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 36)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Color Balance:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAfterglow
        '
        Me.btnAfterglow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAfterglow.BackColor = System.Drawing.Color.Transparent
        Me.btnAfterglow.BackgroundImage = CType(resources.GetObject("btnAfterglow.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterglow.Color = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnAfterglow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAfterglow.FlatAppearance.BorderSize = 0
        Me.btnAfterglow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAfterglow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAfterglow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAfterglow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAfterglow.Image = CType(resources.GetObject("btnAfterglow.Image"), System.Drawing.Image)
        Me.btnAfterglow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAfterglow.Location = New System.Drawing.Point(136, 34)
        Me.btnAfterglow.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnAfterglow.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnAfterglow.Name = "btnAfterglow"
        Me.btnAfterglow.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnAfterglow.Size = New System.Drawing.Size(125, 37)
        Me.btnAfterglow.Style = resources.GetString("btnAfterglow.Style")
        Me.btnAfterglow.TabIndex = 23
        Me.btnAfterglow.Text = "Afterglow"
        Me.btnAfterglow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAfterglow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAfterglow.UseCompatibleTextRendering = True
        Me.btnAfterglow.UseVisualStyleBackColor = False
        '
        'btnMainColor
        '
        Me.btnMainColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMainColor.BackColor = System.Drawing.Color.Transparent
        Me.btnMainColor.BackgroundImage = CType(resources.GetObject("btnMainColor.BackgroundImage"), System.Drawing.Image)
        Me.btnMainColor.Color = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnMainColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMainColor.FlatAppearance.BorderSize = 0
        Me.btnMainColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMainColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMainColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMainColor.Image = CType(resources.GetObject("btnMainColor.Image"), System.Drawing.Image)
        Me.btnMainColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMainColor.Location = New System.Drawing.Point(4, 34)
        Me.btnMainColor.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMainColor.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMainColor.Name = "btnMainColor"
        Me.btnMainColor.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMainColor.Size = New System.Drawing.Size(125, 37)
        Me.btnMainColor.Style = resources.GetString("btnMainColor.Style")
        Me.btnMainColor.TabIndex = 22
        Me.btnMainColor.Text = "Main"
        Me.btnMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMainColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMainColor.UseCompatibleTextRendering = True
        Me.btnMainColor.UseVisualStyleBackColor = False
        '
        'cbTransparency
        '
        Me.cbTransparency.AutoSize = True
        Me.cbTransparency.Location = New System.Drawing.Point(4, 4)
        Me.cbTransparency.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTransparency.Name = "cbTransparency"
        Me.cbTransparency.Size = New System.Drawing.Size(78, 21)
        Me.cbTransparency.TabIndex = 1
        Me.cbTransparency.Text = "Opacity"
        Me.cbTransparency.UseVisualStyleBackColor = True
        '
        'tbColorBalance
        '
        Me.tbColorBalance.AutoSize = False
        Me.tbColorBalance.BackColor = System.Drawing.SystemColors.Control
        Me.tbColorBalance.LargeChange = 20
        Me.tbColorBalance.Location = New System.Drawing.Point(188, 82)
        Me.tbColorBalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbColorBalance.Maximum = 120
        Me.tbColorBalance.Name = "tbColorBalance"
        Me.tbColorBalance.Size = New System.Drawing.Size(239, 36)
        Me.tbColorBalance.TabIndex = 0
        Me.tbColorBalance.TickFrequency = 10
        '
        'tmrUpdate
        '
        '
        'pnlBack
        '
        Me.pnlBack.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBack.Controls.Add(Me.Label4)
        Me.pnlBack.Controls.Add(Me.cbTransparency)
        Me.pnlBack.Controls.Add(Me.Label1)
        Me.pnlBack.Controls.Add(Me.tbGlassReflectionIntensity)
        Me.pnlBack.Controls.Add(Me.btnAfterglow)
        Me.pnlBack.Controls.Add(Me.Label3)
        Me.pnlBack.Controls.Add(Me.tbAfterglowBalance)
        Me.pnlBack.Controls.Add(Me.btnMainColor)
        Me.pnlBack.Controls.Add(Me.tbBlurBalance)
        Me.pnlBack.Controls.Add(Me.Label2)
        Me.pnlBack.Controls.Add(Me.tbColorBalance)
        Me.pnlBack.Location = New System.Drawing.Point(0, 15)
        Me.pnlBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(427, 262)
        Me.pnlBack.TabIndex = 31
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(39, 284)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnSave.Size = New System.Drawing.Size(31, 28)
        Me.btnSave.Style = resources.GetString("btnSave.Style")
        Me.btnSave.TabIndex = 33
        Me.btnSave.UseCompatibleTextRendering = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.BackgroundImage = CType(resources.GetObject("btnOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.Location = New System.Drawing.Point(0, 284)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnOpen.Size = New System.Drawing.Size(31, 28)
        Me.btnOpen.Style = resources.GetString("btnOpen.Style")
        Me.btnOpen.TabIndex = 32
        Me.btnOpen.UseCompatibleTextRendering = True
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Aero Parameters(*aero)|*.aero"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Aero Parameters(*aero)|*.aero"
        '
        'dlgAdjustAero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(427, 313)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlBack)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAdjustAero"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adjust Aero"
        CType(Me.tbGlassReflectionIntensity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBlurBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAfterglowBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbColorBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBack.ResumeLayout(False)
        Me.pnlBack.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Tundra.StylizedButton
    Friend WithEvents cbTransparency As System.Windows.Forms.CheckBox
    Friend WithEvents tbColorBalance As TrackBar.Dotnetrix.Controls.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbGlassReflectionIntensity As TrackBar.Dotnetrix.Controls.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbBlurBalance As TrackBar.Dotnetrix.Controls.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbAfterglowBalance As TrackBar.Dotnetrix.Controls.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAfterglow As Tundra.StylizedColorButton
    Friend WithEvents btnMainColor As Tundra.StylizedColorButton
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents pnlBack As Tundra.DoubleBufferedPanel
    Friend WithEvents btnSave As Tundra.StylizedButton
    Friend WithEvents btnOpen As Tundra.StylizedButton
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog

End Class
