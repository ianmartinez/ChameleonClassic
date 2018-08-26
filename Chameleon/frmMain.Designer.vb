<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWeather = New System.Windows.Forms.Timer(Me.components)
        Me.niMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreviewAeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdjustAeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPreviewAero = New Tundra.StylizedButton()
        Me.tbAdjustAero = New Tundra.StylizedButton()
        Me.tbSettings = New Tundra.StylizedButton()
        Me.tbAbout = New Tundra.StylizedButton()
        Me.tmrWebcam = New System.Windows.Forms.Timer(Me.components)
        Me.btnClose = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel1 = New Tundra.DoubleBufferedPanel()
        Me.StylizedPanel9 = New Tundra.StylizedPanel()
        Me.pnlCursorY = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btn0percenty = New Tundra.StylizedColorButton()
        Me.btn1to9percenty = New Tundra.StylizedColorButton()
        Me.btn10to19percenty = New Tundra.StylizedColorButton()
        Me.btn20to29percenty = New Tundra.StylizedColorButton()
        Me.btn30to39percenty = New Tundra.StylizedColorButton()
        Me.btn40to49percenty = New Tundra.StylizedColorButton()
        Me.btn50to59percenty = New Tundra.StylizedColorButton()
        Me.btn60to69percenty = New Tundra.StylizedColorButton()
        Me.btn70to79percenty = New Tundra.StylizedColorButton()
        Me.btn80to89percenty = New Tundra.StylizedColorButton()
        Me.btn90to99percenty = New Tundra.StylizedColorButton()
        Me.btn100percenty = New Tundra.StylizedColorButton()
        Me.btnCursorY = New Tundra.StylizedRadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StylizedPanel8 = New Tundra.StylizedPanel()
        Me.pnlCursorX = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btn0percentx = New Tundra.StylizedColorButton()
        Me.btn1to9percentx = New Tundra.StylizedColorButton()
        Me.btn10to19percentx = New Tundra.StylizedColorButton()
        Me.btn20to29percentx = New Tundra.StylizedColorButton()
        Me.btn30to39percentx = New Tundra.StylizedColorButton()
        Me.btn40to49percentx = New Tundra.StylizedColorButton()
        Me.btn50to59percentx = New Tundra.StylizedColorButton()
        Me.btn60to69percentx = New Tundra.StylizedColorButton()
        Me.btn70to79percentx = New Tundra.StylizedColorButton()
        Me.btn80to89percentx = New Tundra.StylizedColorButton()
        Me.btn90to99percentx = New Tundra.StylizedColorButton()
        Me.btn100percentx = New Tundra.StylizedColorButton()
        Me.btnCursorX = New Tundra.StylizedRadioButton()
        Me.btnWebcam = New Tundra.StylizedRadioButton()
        Me.StylizedPanel5 = New Tundra.StylizedPanel()
        Me.pnlTime = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btn12AM = New Tundra.StylizedColorButton()
        Me.btn1AM = New Tundra.StylizedColorButton()
        Me.btn2AM = New Tundra.StylizedColorButton()
        Me.btn3AM = New Tundra.StylizedColorButton()
        Me.btn4AM = New Tundra.StylizedColorButton()
        Me.btn5AM = New Tundra.StylizedColorButton()
        Me.btn6AM = New Tundra.StylizedColorButton()
        Me.btn7AM = New Tundra.StylizedColorButton()
        Me.btn8AM = New Tundra.StylizedColorButton()
        Me.btn9AM = New Tundra.StylizedColorButton()
        Me.btn10AM = New Tundra.StylizedColorButton()
        Me.btn11AM = New Tundra.StylizedColorButton()
        Me.btn12PM = New Tundra.StylizedColorButton()
        Me.btn1PM = New Tundra.StylizedColorButton()
        Me.btn2PM = New Tundra.StylizedColorButton()
        Me.btn3PM = New Tundra.StylizedColorButton()
        Me.btn4PM = New Tundra.StylizedColorButton()
        Me.btn5PM = New Tundra.StylizedColorButton()
        Me.btn6PM = New Tundra.StylizedColorButton()
        Me.btn7PM = New Tundra.StylizedColorButton()
        Me.btn8PM = New Tundra.StylizedColorButton()
        Me.btn9PM = New Tundra.StylizedColorButton()
        Me.btn10PM = New Tundra.StylizedColorButton()
        Me.btn11PM = New Tundra.StylizedColorButton()
        Me.StylizedPanel4 = New Tundra.StylizedPanel()
        Me.pnlBattery = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btn0Percent = New Tundra.StylizedColorButton()
        Me.btn1to9Percent = New Tundra.StylizedColorButton()
        Me.btn10to19Percent = New Tundra.StylizedColorButton()
        Me.btn20to29Percent = New Tundra.StylizedColorButton()
        Me.btn30to39Percent = New Tundra.StylizedColorButton()
        Me.btn40to49Percent = New Tundra.StylizedColorButton()
        Me.btn50to59Percent = New Tundra.StylizedColorButton()
        Me.btn60to69Percent = New Tundra.StylizedColorButton()
        Me.btn70to79Percent = New Tundra.StylizedColorButton()
        Me.btn80to89Percent = New Tundra.StylizedColorButton()
        Me.btn90to99Percent = New Tundra.StylizedColorButton()
        Me.btn100Percent = New Tundra.StylizedColorButton()
        Me.StylizedPanel7 = New Tundra.StylizedPanel()
        Me.pnlWindSpeed = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btn0MPH = New Tundra.StylizedColorButton()
        Me.btn1to9MPH = New Tundra.StylizedColorButton()
        Me.btn10to19MPH = New Tundra.StylizedColorButton()
        Me.btn20to29MPH = New Tundra.StylizedColorButton()
        Me.btn30to39MPH = New Tundra.StylizedColorButton()
        Me.btn40to49MPH = New Tundra.StylizedColorButton()
        Me.btn50to59MPH = New Tundra.StylizedColorButton()
        Me.btn60to69MPH = New Tundra.StylizedColorButton()
        Me.btn70to79MPH = New Tundra.StylizedColorButton()
        Me.btn80to89MPH = New Tundra.StylizedColorButton()
        Me.btn90to99MPH = New Tundra.StylizedColorButton()
        Me.btn100to110MPH = New Tundra.StylizedColorButton()
        Me.btnMoreThan110MPH = New Tundra.StylizedColorButton()
        Me.btnBattery = New Tundra.StylizedRadioButton()
        Me.StylizedPanel6 = New Tundra.StylizedPanel()
        Me.pnlHumidity = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btn0PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn1to9PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn10to19PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn20to29PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn30to39PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn40to49PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn50to59PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn60to69PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn70to79PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn80to89PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn90to99PercentHumidity = New Tundra.StylizedColorButton()
        Me.btn100PercentHumidity = New Tundra.StylizedColorButton()
        Me.StylizedPanel3 = New Tundra.StylizedPanel()
        Me.pnlTemperature = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btnLessthan50 = New Tundra.StylizedColorButton()
        Me.btn50to40 = New Tundra.StylizedColorButton()
        Me.btn39to30 = New Tundra.StylizedColorButton()
        Me.btn29to20 = New Tundra.StylizedColorButton()
        Me.btn19to10 = New Tundra.StylizedColorButton()
        Me.btn9to1 = New Tundra.StylizedColorButton()
        Me.btn0 = New Tundra.StylizedColorButton()
        Me.btn1to9 = New Tundra.StylizedColorButton()
        Me.btn10to19 = New Tundra.StylizedColorButton()
        Me.btn20to29 = New Tundra.StylizedColorButton()
        Me.btn30to39 = New Tundra.StylizedColorButton()
        Me.btn40to49 = New Tundra.StylizedColorButton()
        Me.btn50to59 = New Tundra.StylizedColorButton()
        Me.btn60to69 = New Tundra.StylizedColorButton()
        Me.btn70to79 = New Tundra.StylizedColorButton()
        Me.btn80to89 = New Tundra.StylizedColorButton()
        Me.btn90to99 = New Tundra.StylizedColorButton()
        Me.btn100to110 = New Tundra.StylizedColorButton()
        Me.btnMorethan110 = New Tundra.StylizedColorButton()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.pnlConditions = New Tundra.DoubleBufferedFlowLayoutPanel()
        Me.btnClear = New Tundra.StylizedColorButton()
        Me.btnSunny = New Tundra.StylizedColorButton()
        Me.btnFair = New Tundra.StylizedColorButton()
        Me.btnCloudy = New Tundra.StylizedColorButton()
        Me.btnPartlyCloudy = New Tundra.StylizedColorButton()
        Me.btnMostlyCloudy = New Tundra.StylizedColorButton()
        Me.btnBlustery = New Tundra.StylizedColorButton()
        Me.btnWindy = New Tundra.StylizedColorButton()
        Me.btnHot = New Tundra.StylizedColorButton()
        Me.btnCold = New Tundra.StylizedColorButton()
        Me.btnTornado = New Tundra.StylizedColorButton()
        Me.btnTropicalStorm = New Tundra.StylizedColorButton()
        Me.btnHurricane = New Tundra.StylizedColorButton()
        Me.btnSevereThunderstorm = New Tundra.StylizedColorButton()
        Me.btnThunderstorms = New Tundra.StylizedColorButton()
        Me.btnHail = New Tundra.StylizedColorButton()
        Me.btnSleet = New Tundra.StylizedColorButton()
        Me.btnDrizzle = New Tundra.StylizedColorButton()
        Me.btnShowers = New Tundra.StylizedColorButton()
        Me.btnThundershowers = New Tundra.StylizedColorButton()
        Me.btnIsolatedThundershowers = New Tundra.StylizedColorButton()
        Me.btnIsolatedThunderstorms = New Tundra.StylizedColorButton()
        Me.btnScatteredThunderstorms = New Tundra.StylizedColorButton()
        Me.btnScatteredShowers = New Tundra.StylizedColorButton()
        Me.btnMixedRainandHail = New Tundra.StylizedColorButton()
        Me.btnMixedRainandSleet = New Tundra.StylizedColorButton()
        Me.btnMixedRainandSnow = New Tundra.StylizedColorButton()
        Me.btnMixedSnowandSleet = New Tundra.StylizedColorButton()
        Me.btnFreezingDrizzle = New Tundra.StylizedColorButton()
        Me.btnFreezingRain = New Tundra.StylizedColorButton()
        Me.btnSnowFlurries = New Tundra.StylizedColorButton()
        Me.btnSnow = New Tundra.StylizedColorButton()
        Me.btnLightSnowShowers = New Tundra.StylizedColorButton()
        Me.btnScatteredSnowShowers = New Tundra.StylizedColorButton()
        Me.btnBlowingSnow = New Tundra.StylizedColorButton()
        Me.btnHeavySnow = New Tundra.StylizedColorButton()
        Me.btnSnowShowers = New Tundra.StylizedColorButton()
        Me.btnDust = New Tundra.StylizedColorButton()
        Me.btnFog = New Tundra.StylizedColorButton()
        Me.btnHaze = New Tundra.StylizedColorButton()
        Me.btnSmoke = New Tundra.StylizedColorButton()
        Me.btnUnavailable = New Tundra.StylizedColorButton()
        Me.btnTime = New Tundra.StylizedRadioButton()
        Me.btnNone = New Tundra.StylizedRadioButton()
        Me.btnWindSpeed = New Tundra.StylizedRadioButton()
        Me.btnHumidity = New Tundra.StylizedRadioButton()
        Me.btnRandom = New Tundra.StylizedRadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConditions = New Tundra.StylizedRadioButton()
        Me.btnWallpaper = New Tundra.StylizedRadioButton()
        Me.btnScreen = New Tundra.StylizedRadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTemperature = New Tundra.StylizedRadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnProgramIcon = New Tundra.StylizedRadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmsMain.SuspendLayout()
        Me.DoubleBufferedPanel1.SuspendLayout()
        Me.StylizedPanel9.SuspendLayout()
        Me.pnlCursorY.SuspendLayout()
        Me.StylizedPanel8.SuspendLayout()
        Me.pnlCursorX.SuspendLayout()
        Me.StylizedPanel5.SuspendLayout()
        Me.pnlTime.SuspendLayout()
        Me.StylizedPanel4.SuspendLayout()
        Me.pnlBattery.SuspendLayout()
        Me.StylizedPanel7.SuspendLayout()
        Me.pnlWindSpeed.SuspendLayout()
        Me.StylizedPanel6.SuspendLayout()
        Me.pnlHumidity.SuspendLayout()
        Me.StylizedPanel3.SuspendLayout()
        Me.pnlTemperature.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.pnlConditions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrMain
        '
        '
        'tmrWeather
        '
        '
        'niMain
        '
        Me.niMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.niMain.BalloonTipText = "Chameleon is still running in the background."
        Me.niMain.BalloonTipTitle = "Chameleon"
        Me.niMain.ContextMenuStrip = Me.cmsMain
        Me.niMain.Icon = CType(resources.GetObject("niMain.Icon"), System.Drawing.Icon)
        Me.niMain.Text = "Chameleon"
        '
        'cmsMain
        '
        Me.cmsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowWindowToolStripMenuItem, Me.ToolStripMenuItem1, Me.PreviewAeroToolStripMenuItem, Me.AdjustAeroToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.cmsMain.Name = "cmsMain"
        Me.cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsMain.Size = New System.Drawing.Size(178, 172)
        '
        'ShowWindowToolStripMenuItem
        '
        Me.ShowWindowToolStripMenuItem.Image = CType(resources.GetObject("ShowWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowWindowToolStripMenuItem.Name = "ShowWindowToolStripMenuItem"
        Me.ShowWindowToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.ShowWindowToolStripMenuItem.Text = "Show Window"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'PreviewAeroToolStripMenuItem
        '
        Me.PreviewAeroToolStripMenuItem.Image = CType(resources.GetObject("PreviewAeroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PreviewAeroToolStripMenuItem.Name = "PreviewAeroToolStripMenuItem"
        Me.PreviewAeroToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.PreviewAeroToolStripMenuItem.Text = "Preview Aero"
        '
        'AdjustAeroToolStripMenuItem
        '
        Me.AdjustAeroToolStripMenuItem.Image = CType(resources.GetObject("AdjustAeroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdjustAeroToolStripMenuItem.Name = "AdjustAeroToolStripMenuItem"
        Me.AdjustAeroToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.AdjustAeroToolStripMenuItem.Text = "Adjust Aero"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnPreviewAero
        '
        Me.btnPreviewAero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreviewAero.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviewAero.BackgroundImage = CType(resources.GetObject("btnPreviewAero.BackgroundImage"), System.Drawing.Image)
        Me.btnPreviewAero.FlatAppearance.BorderSize = 0
        Me.btnPreviewAero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPreviewAero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPreviewAero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviewAero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPreviewAero.Image = CType(resources.GetObject("btnPreviewAero.Image"), System.Drawing.Image)
        Me.btnPreviewAero.Location = New System.Drawing.Point(865, 1)
        Me.btnPreviewAero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreviewAero.Name = "btnPreviewAero"
        Me.btnPreviewAero.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnPreviewAero.Size = New System.Drawing.Size(32, 30)
        Me.btnPreviewAero.Style = resources.GetString("btnPreviewAero.Style")
        Me.btnPreviewAero.TabIndex = 16
        Me.ttMain.SetToolTip(Me.btnPreviewAero, "Preview Aero")
        Me.btnPreviewAero.UseCompatibleTextRendering = True
        Me.btnPreviewAero.UseVisualStyleBackColor = False
        '
        'tbAdjustAero
        '
        Me.tbAdjustAero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAdjustAero.BackColor = System.Drawing.Color.Transparent
        Me.tbAdjustAero.BackgroundImage = CType(resources.GetObject("tbAdjustAero.BackgroundImage"), System.Drawing.Image)
        Me.tbAdjustAero.FlatAppearance.BorderSize = 0
        Me.tbAdjustAero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.tbAdjustAero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.tbAdjustAero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbAdjustAero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbAdjustAero.Image = CType(resources.GetObject("tbAdjustAero.Image"), System.Drawing.Image)
        Me.tbAdjustAero.Location = New System.Drawing.Point(905, 1)
        Me.tbAdjustAero.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAdjustAero.Name = "tbAdjustAero"
        Me.tbAdjustAero.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.tbAdjustAero.Size = New System.Drawing.Size(32, 30)
        Me.tbAdjustAero.Style = resources.GetString("tbAdjustAero.Style")
        Me.tbAdjustAero.TabIndex = 15
        Me.ttMain.SetToolTip(Me.tbAdjustAero, "Adjust Aero")
        Me.tbAdjustAero.UseCompatibleTextRendering = True
        Me.tbAdjustAero.UseVisualStyleBackColor = False
        '
        'tbSettings
        '
        Me.tbSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSettings.BackColor = System.Drawing.Color.Transparent
        Me.tbSettings.BackgroundImage = CType(resources.GetObject("tbSettings.BackgroundImage"), System.Drawing.Image)
        Me.tbSettings.FlatAppearance.BorderSize = 0
        Me.tbSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.tbSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.tbSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbSettings.Image = CType(resources.GetObject("tbSettings.Image"), System.Drawing.Image)
        Me.tbSettings.Location = New System.Drawing.Point(945, 2)
        Me.tbSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSettings.Name = "tbSettings"
        Me.tbSettings.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.tbSettings.Size = New System.Drawing.Size(32, 30)
        Me.tbSettings.Style = resources.GetString("tbSettings.Style")
        Me.tbSettings.TabIndex = 12
        Me.ttMain.SetToolTip(Me.tbSettings, "Settings")
        Me.tbSettings.UseCompatibleTextRendering = True
        Me.tbSettings.UseVisualStyleBackColor = False
        '
        'tbAbout
        '
        Me.tbAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAbout.BackColor = System.Drawing.Color.Transparent
        Me.tbAbout.BackgroundImage = CType(resources.GetObject("tbAbout.BackgroundImage"), System.Drawing.Image)
        Me.tbAbout.FlatAppearance.BorderSize = 0
        Me.tbAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.tbAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.tbAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbAbout.Image = CType(resources.GetObject("tbAbout.Image"), System.Drawing.Image)
        Me.tbAbout.Location = New System.Drawing.Point(985, 2)
        Me.tbAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.tbAbout.Size = New System.Drawing.Size(32, 30)
        Me.tbAbout.Style = resources.GetString("tbAbout.Style")
        Me.tbAbout.TabIndex = 11
        Me.ttMain.SetToolTip(Me.tbAbout, "About")
        Me.tbAbout.UseCompatibleTextRendering = True
        Me.tbAbout.UseVisualStyleBackColor = False
        '
        'tmrWebcam
        '
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
        Me.btnClose.Location = New System.Drawing.Point(916, 549)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnClose.Size = New System.Drawing.Size(101, 28)
        Me.btnClose.Style = resources.GetString("btnClose.Style")
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Run"
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.AutoScroll = True
        Me.DoubleBufferedPanel1.AutoScrollMargin = New System.Drawing.Size(0, 4)
        Me.DoubleBufferedPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel9)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnCursorY)
        Me.DoubleBufferedPanel1.Controls.Add(Me.Label6)
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel8)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnCursorX)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnWebcam)
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel5)
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel4)
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel7)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnBattery)
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel6)
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel3)
        Me.DoubleBufferedPanel1.Controls.Add(Me.StylizedPanel1)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnTime)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnNone)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnWindSpeed)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnHumidity)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnRandom)
        Me.DoubleBufferedPanel1.Controls.Add(Me.Label5)
        Me.DoubleBufferedPanel1.Controls.Add(Me.Label1)
        Me.DoubleBufferedPanel1.Controls.Add(Me.Label4)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnConditions)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnWallpaper)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnScreen)
        Me.DoubleBufferedPanel1.Controls.Add(Me.Label2)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnTemperature)
        Me.DoubleBufferedPanel1.Controls.Add(Me.Label3)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnProgramIcon)
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(0, 39)
        Me.DoubleBufferedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(1017, 502)
        Me.DoubleBufferedPanel1.TabIndex = 0
        '
        'StylizedPanel9
        '
        Me.StylizedPanel9.Controls.Add(Me.pnlCursorY)
        Me.StylizedPanel9.Location = New System.Drawing.Point(167, 804)
        Me.StylizedPanel9.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel9.Name = "StylizedPanel9"
        Me.StylizedPanel9.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel9.Size = New System.Drawing.Size(821, 76)
        Me.StylizedPanel9.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel9.TabIndex = 90
        '
        'pnlCursorY
        '
        Me.pnlCursorY.AutoScroll = True
        Me.pnlCursorY.BackColor = System.Drawing.Color.White
        Me.pnlCursorY.Controls.Add(Me.btn0percenty)
        Me.pnlCursorY.Controls.Add(Me.btn1to9percenty)
        Me.pnlCursorY.Controls.Add(Me.btn10to19percenty)
        Me.pnlCursorY.Controls.Add(Me.btn20to29percenty)
        Me.pnlCursorY.Controls.Add(Me.btn30to39percenty)
        Me.pnlCursorY.Controls.Add(Me.btn40to49percenty)
        Me.pnlCursorY.Controls.Add(Me.btn50to59percenty)
        Me.pnlCursorY.Controls.Add(Me.btn60to69percenty)
        Me.pnlCursorY.Controls.Add(Me.btn70to79percenty)
        Me.pnlCursorY.Controls.Add(Me.btn80to89percenty)
        Me.pnlCursorY.Controls.Add(Me.btn90to99percenty)
        Me.pnlCursorY.Controls.Add(Me.btn100percenty)
        Me.pnlCursorY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCursorY.Location = New System.Drawing.Point(1, 1)
        Me.pnlCursorY.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCursorY.Name = "pnlCursorY"
        Me.pnlCursorY.Padding = New System.Windows.Forms.Padding(7, 0, 13, 0)
        Me.pnlCursorY.Size = New System.Drawing.Size(819, 74)
        Me.pnlCursorY.TabIndex = 63
        Me.pnlCursorY.WrapContents = False
        '
        'btn0percenty
        '
        Me.btn0percenty.AutoSize = True
        Me.btn0percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn0percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn0percenty.BackgroundImage = CType(resources.GetObject("btn0percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn0percenty.Color = System.Drawing.Color.White
        Me.btn0percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn0percenty.FlatAppearance.BorderSize = 0
        Me.btn0percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn0percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn0percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn0percenty.Image = CType(resources.GetObject("btn0percenty.Image"), System.Drawing.Image)
        Me.btn0percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn0percenty.Location = New System.Drawing.Point(7, 6)
        Me.btn0percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn0percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn0percenty.Name = "btn0percenty"
        Me.btn0percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn0percenty.Size = New System.Drawing.Size(52, 37)
        Me.btn0percenty.Style = resources.GetString("btn0percenty.Style")
        Me.btn0percenty.TabIndex = 62
        Me.btn0percenty.Text = "0%"
        Me.btn0percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn0percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0percenty.UseCompatibleTextRendering = True
        Me.btn0percenty.UseVisualStyleBackColor = True
        '
        'btn1to9percenty
        '
        Me.btn1to9percenty.AutoSize = True
        Me.btn1to9percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1to9percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn1to9percenty.BackgroundImage = CType(resources.GetObject("btn1to9percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn1to9percenty.Color = System.Drawing.Color.Azure
        Me.btn1to9percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1to9percenty.FlatAppearance.BorderSize = 0
        Me.btn1to9percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1to9percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1to9percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1to9percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1to9percenty.Image = CType(resources.GetObject("btn1to9percenty.Image"), System.Drawing.Image)
        Me.btn1to9percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1to9percenty.Location = New System.Drawing.Point(66, 6)
        Me.btn1to9percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1to9percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1to9percenty.Name = "btn1to9percenty"
        Me.btn1to9percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1to9percenty.Size = New System.Drawing.Size(78, 37)
        Me.btn1to9percenty.Style = resources.GetString("btn1to9percenty.Style")
        Me.btn1to9percenty.TabIndex = 63
        Me.btn1to9percenty.Text = "1 to 9%"
        Me.btn1to9percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1to9percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1to9percenty.UseCompatibleTextRendering = True
        Me.btn1to9percenty.UseVisualStyleBackColor = True
        '
        'btn10to19percenty
        '
        Me.btn10to19percenty.AutoSize = True
        Me.btn10to19percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10to19percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn10to19percenty.BackgroundImage = CType(resources.GetObject("btn10to19percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn10to19percenty.Color = System.Drawing.Color.AliceBlue
        Me.btn10to19percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10to19percenty.FlatAppearance.BorderSize = 0
        Me.btn10to19percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10to19percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10to19percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10to19percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10to19percenty.Image = CType(resources.GetObject("btn10to19percenty.Image"), System.Drawing.Image)
        Me.btn10to19percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10to19percenty.Location = New System.Drawing.Point(151, 6)
        Me.btn10to19percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10to19percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10to19percenty.Name = "btn10to19percenty"
        Me.btn10to19percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10to19percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn10to19percenty.Style = resources.GetString("btn10to19percenty.Style")
        Me.btn10to19percenty.TabIndex = 64
        Me.btn10to19percenty.Text = "10 to 19%"
        Me.btn10to19percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10to19percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10to19percenty.UseCompatibleTextRendering = True
        Me.btn10to19percenty.UseVisualStyleBackColor = True
        '
        'btn20to29percenty
        '
        Me.btn20to29percenty.AutoSize = True
        Me.btn20to29percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn20to29percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn20to29percenty.BackgroundImage = CType(resources.GetObject("btn20to29percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn20to29percenty.Color = System.Drawing.Color.LightBlue
        Me.btn20to29percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn20to29percenty.FlatAppearance.BorderSize = 0
        Me.btn20to29percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn20to29percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn20to29percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20to29percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn20to29percenty.Image = CType(resources.GetObject("btn20to29percenty.Image"), System.Drawing.Image)
        Me.btn20to29percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20to29percenty.Location = New System.Drawing.Point(251, 6)
        Me.btn20to29percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn20to29percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn20to29percenty.Name = "btn20to29percenty"
        Me.btn20to29percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn20to29percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn20to29percenty.Style = resources.GetString("btn20to29percenty.Style")
        Me.btn20to29percenty.TabIndex = 65
        Me.btn20to29percenty.Text = "20 to 29%"
        Me.btn20to29percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn20to29percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20to29percenty.UseCompatibleTextRendering = True
        Me.btn20to29percenty.UseVisualStyleBackColor = True
        '
        'btn30to39percenty
        '
        Me.btn30to39percenty.AutoSize = True
        Me.btn30to39percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn30to39percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn30to39percenty.BackgroundImage = CType(resources.GetObject("btn30to39percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn30to39percenty.Color = System.Drawing.Color.LightSkyBlue
        Me.btn30to39percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn30to39percenty.FlatAppearance.BorderSize = 0
        Me.btn30to39percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn30to39percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn30to39percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn30to39percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn30to39percenty.Image = CType(resources.GetObject("btn30to39percenty.Image"), System.Drawing.Image)
        Me.btn30to39percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30to39percenty.Location = New System.Drawing.Point(351, 6)
        Me.btn30to39percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn30to39percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn30to39percenty.Name = "btn30to39percenty"
        Me.btn30to39percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn30to39percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn30to39percenty.Style = resources.GetString("btn30to39percenty.Style")
        Me.btn30to39percenty.TabIndex = 66
        Me.btn30to39percenty.Text = "30 to 39%"
        Me.btn30to39percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn30to39percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn30to39percenty.UseCompatibleTextRendering = True
        Me.btn30to39percenty.UseVisualStyleBackColor = True
        '
        'btn40to49percenty
        '
        Me.btn40to49percenty.AutoSize = True
        Me.btn40to49percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn40to49percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn40to49percenty.BackgroundImage = CType(resources.GetObject("btn40to49percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn40to49percenty.Color = System.Drawing.Color.SkyBlue
        Me.btn40to49percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn40to49percenty.FlatAppearance.BorderSize = 0
        Me.btn40to49percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn40to49percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn40to49percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn40to49percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn40to49percenty.Image = CType(resources.GetObject("btn40to49percenty.Image"), System.Drawing.Image)
        Me.btn40to49percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40to49percenty.Location = New System.Drawing.Point(451, 6)
        Me.btn40to49percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn40to49percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn40to49percenty.Name = "btn40to49percenty"
        Me.btn40to49percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn40to49percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn40to49percenty.Style = resources.GetString("btn40to49percenty.Style")
        Me.btn40to49percenty.TabIndex = 67
        Me.btn40to49percenty.Text = "40 to 49%"
        Me.btn40to49percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn40to49percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn40to49percenty.UseCompatibleTextRendering = True
        Me.btn40to49percenty.UseVisualStyleBackColor = True
        '
        'btn50to59percenty
        '
        Me.btn50to59percenty.AutoSize = True
        Me.btn50to59percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn50to59percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn50to59percenty.BackgroundImage = CType(resources.GetObject("btn50to59percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn50to59percenty.Color = System.Drawing.Color.DeepSkyBlue
        Me.btn50to59percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn50to59percenty.FlatAppearance.BorderSize = 0
        Me.btn50to59percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn50to59percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn50to59percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50to59percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50to59percenty.Image = CType(resources.GetObject("btn50to59percenty.Image"), System.Drawing.Image)
        Me.btn50to59percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50to59percenty.Location = New System.Drawing.Point(551, 6)
        Me.btn50to59percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn50to59percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn50to59percenty.Name = "btn50to59percenty"
        Me.btn50to59percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn50to59percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn50to59percenty.Style = resources.GetString("btn50to59percenty.Style")
        Me.btn50to59percenty.TabIndex = 68
        Me.btn50to59percenty.Text = "50 to 59%"
        Me.btn50to59percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50to59percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50to59percenty.UseCompatibleTextRendering = True
        Me.btn50to59percenty.UseVisualStyleBackColor = True
        '
        'btn60to69percenty
        '
        Me.btn60to69percenty.AutoSize = True
        Me.btn60to69percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn60to69percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn60to69percenty.BackgroundImage = CType(resources.GetObject("btn60to69percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn60to69percenty.Color = System.Drawing.Color.DodgerBlue
        Me.btn60to69percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn60to69percenty.FlatAppearance.BorderSize = 0
        Me.btn60to69percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn60to69percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn60to69percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn60to69percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn60to69percenty.Image = CType(resources.GetObject("btn60to69percenty.Image"), System.Drawing.Image)
        Me.btn60to69percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn60to69percenty.Location = New System.Drawing.Point(651, 6)
        Me.btn60to69percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn60to69percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn60to69percenty.Name = "btn60to69percenty"
        Me.btn60to69percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn60to69percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn60to69percenty.Style = resources.GetString("btn60to69percenty.Style")
        Me.btn60to69percenty.TabIndex = 69
        Me.btn60to69percenty.Text = "60 to 69%"
        Me.btn60to69percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn60to69percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn60to69percenty.UseCompatibleTextRendering = True
        Me.btn60to69percenty.UseVisualStyleBackColor = True
        '
        'btn70to79percenty
        '
        Me.btn70to79percenty.AutoSize = True
        Me.btn70to79percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn70to79percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn70to79percenty.BackgroundImage = CType(resources.GetObject("btn70to79percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn70to79percenty.Color = System.Drawing.Color.CornflowerBlue
        Me.btn70to79percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn70to79percenty.FlatAppearance.BorderSize = 0
        Me.btn70to79percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn70to79percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn70to79percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn70to79percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn70to79percenty.Image = CType(resources.GetObject("btn70to79percenty.Image"), System.Drawing.Image)
        Me.btn70to79percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn70to79percenty.Location = New System.Drawing.Point(751, 6)
        Me.btn70to79percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn70to79percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn70to79percenty.Name = "btn70to79percenty"
        Me.btn70to79percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn70to79percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn70to79percenty.Style = resources.GetString("btn70to79percenty.Style")
        Me.btn70to79percenty.TabIndex = 70
        Me.btn70to79percenty.Text = "70 to 79%"
        Me.btn70to79percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn70to79percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn70to79percenty.UseCompatibleTextRendering = True
        Me.btn70to79percenty.UseVisualStyleBackColor = True
        '
        'btn80to89percenty
        '
        Me.btn80to89percenty.AutoSize = True
        Me.btn80to89percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn80to89percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn80to89percenty.BackgroundImage = CType(resources.GetObject("btn80to89percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn80to89percenty.Color = System.Drawing.Color.RoyalBlue
        Me.btn80to89percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn80to89percenty.FlatAppearance.BorderSize = 0
        Me.btn80to89percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn80to89percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn80to89percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn80to89percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn80to89percenty.Image = CType(resources.GetObject("btn80to89percenty.Image"), System.Drawing.Image)
        Me.btn80to89percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn80to89percenty.Location = New System.Drawing.Point(851, 6)
        Me.btn80to89percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn80to89percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn80to89percenty.Name = "btn80to89percenty"
        Me.btn80to89percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn80to89percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn80to89percenty.Style = resources.GetString("btn80to89percenty.Style")
        Me.btn80to89percenty.TabIndex = 71
        Me.btn80to89percenty.Text = "80 to 89%"
        Me.btn80to89percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn80to89percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn80to89percenty.UseCompatibleTextRendering = True
        Me.btn80to89percenty.UseVisualStyleBackColor = True
        '
        'btn90to99percenty
        '
        Me.btn90to99percenty.AutoSize = True
        Me.btn90to99percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn90to99percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn90to99percenty.BackgroundImage = CType(resources.GetObject("btn90to99percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn90to99percenty.Color = System.Drawing.Color.Blue
        Me.btn90to99percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn90to99percenty.FlatAppearance.BorderSize = 0
        Me.btn90to99percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn90to99percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn90to99percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn90to99percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn90to99percenty.Image = CType(resources.GetObject("btn90to99percenty.Image"), System.Drawing.Image)
        Me.btn90to99percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn90to99percenty.Location = New System.Drawing.Point(951, 6)
        Me.btn90to99percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn90to99percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn90to99percenty.Name = "btn90to99percenty"
        Me.btn90to99percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn90to99percenty.Size = New System.Drawing.Size(93, 37)
        Me.btn90to99percenty.Style = resources.GetString("btn90to99percenty.Style")
        Me.btn90to99percenty.TabIndex = 72
        Me.btn90to99percenty.Text = "90 to 99%"
        Me.btn90to99percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn90to99percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn90to99percenty.UseCompatibleTextRendering = True
        Me.btn90to99percenty.UseVisualStyleBackColor = True
        '
        'btn100percenty
        '
        Me.btn100percenty.AutoSize = True
        Me.btn100percenty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn100percenty.BackColor = System.Drawing.Color.Transparent
        Me.btn100percenty.BackgroundImage = CType(resources.GetObject("btn100percenty.BackgroundImage"), System.Drawing.Image)
        Me.btn100percenty.Color = System.Drawing.Color.MidnightBlue
        Me.btn100percenty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn100percenty.FlatAppearance.BorderSize = 0
        Me.btn100percenty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn100percenty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn100percenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100percenty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100percenty.Image = CType(resources.GetObject("btn100percenty.Image"), System.Drawing.Image)
        Me.btn100percenty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn100percenty.Location = New System.Drawing.Point(1051, 6)
        Me.btn100percenty.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn100percenty.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn100percenty.Name = "btn100percenty"
        Me.btn100percenty.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn100percenty.Size = New System.Drawing.Size(67, 37)
        Me.btn100percenty.Style = resources.GetString("btn100percenty.Style")
        Me.btn100percenty.TabIndex = 73
        Me.btn100percenty.Text = "100%"
        Me.btn100percenty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn100percenty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn100percenty.UseCompatibleTextRendering = True
        Me.btn100percenty.UseVisualStyleBackColor = True
        '
        'btnCursorY
        '
        Me.btnCursorY.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnCursorY.BackColor = System.Drawing.Color.Transparent
        Me.btnCursorY.BackgroundImage = CType(resources.GetObject("btnCursorY.BackgroundImage"), System.Drawing.Image)
        Me.btnCursorY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCursorY.FlatAppearance.BorderSize = 0
        Me.btnCursorY.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnCursorY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCursorY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCursorY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCursorY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCursorY.Image = CType(resources.GetObject("btnCursorY.Image"), System.Drawing.Image)
        Me.btnCursorY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCursorY.Location = New System.Drawing.Point(4, 804)
        Me.btnCursorY.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCursorY.Name = "btnCursorY"
        Me.btnCursorY.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnCursorY.Size = New System.Drawing.Size(155, 28)
        Me.btnCursorY.Style = resources.GetString("btnCursorY.Style")
        Me.btnCursorY.TabIndex = 89
        Me.btnCursorY.Text = "Cursor (y)"
        Me.btnCursorY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCursorY.UseCompatibleTextRendering = True
        Me.btnCursorY.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(167, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Get color from webcam"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'StylizedPanel8
        '
        Me.StylizedPanel8.Controls.Add(Me.pnlCursorX)
        Me.StylizedPanel8.Location = New System.Drawing.Point(167, 720)
        Me.StylizedPanel8.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel8.Name = "StylizedPanel8"
        Me.StylizedPanel8.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel8.Size = New System.Drawing.Size(821, 76)
        Me.StylizedPanel8.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel8.TabIndex = 88
        '
        'pnlCursorX
        '
        Me.pnlCursorX.AutoScroll = True
        Me.pnlCursorX.BackColor = System.Drawing.Color.White
        Me.pnlCursorX.Controls.Add(Me.btn0percentx)
        Me.pnlCursorX.Controls.Add(Me.btn1to9percentx)
        Me.pnlCursorX.Controls.Add(Me.btn10to19percentx)
        Me.pnlCursorX.Controls.Add(Me.btn20to29percentx)
        Me.pnlCursorX.Controls.Add(Me.btn30to39percentx)
        Me.pnlCursorX.Controls.Add(Me.btn40to49percentx)
        Me.pnlCursorX.Controls.Add(Me.btn50to59percentx)
        Me.pnlCursorX.Controls.Add(Me.btn60to69percentx)
        Me.pnlCursorX.Controls.Add(Me.btn70to79percentx)
        Me.pnlCursorX.Controls.Add(Me.btn80to89percentx)
        Me.pnlCursorX.Controls.Add(Me.btn90to99percentx)
        Me.pnlCursorX.Controls.Add(Me.btn100percentx)
        Me.pnlCursorX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCursorX.Location = New System.Drawing.Point(1, 1)
        Me.pnlCursorX.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCursorX.Name = "pnlCursorX"
        Me.pnlCursorX.Padding = New System.Windows.Forms.Padding(7, 0, 13, 0)
        Me.pnlCursorX.Size = New System.Drawing.Size(819, 74)
        Me.pnlCursorX.TabIndex = 63
        Me.pnlCursorX.WrapContents = False
        '
        'btn0percentx
        '
        Me.btn0percentx.AutoSize = True
        Me.btn0percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn0percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn0percentx.BackgroundImage = CType(resources.GetObject("btn0percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn0percentx.Color = System.Drawing.Color.WhiteSmoke
        Me.btn0percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn0percentx.FlatAppearance.BorderSize = 0
        Me.btn0percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn0percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn0percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn0percentx.Image = CType(resources.GetObject("btn0percentx.Image"), System.Drawing.Image)
        Me.btn0percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn0percentx.Location = New System.Drawing.Point(7, 6)
        Me.btn0percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn0percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn0percentx.Name = "btn0percentx"
        Me.btn0percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn0percentx.Size = New System.Drawing.Size(52, 37)
        Me.btn0percentx.Style = resources.GetString("btn0percentx.Style")
        Me.btn0percentx.TabIndex = 62
        Me.btn0percentx.Text = "0%"
        Me.btn0percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn0percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0percentx.UseCompatibleTextRendering = True
        Me.btn0percentx.UseVisualStyleBackColor = True
        '
        'btn1to9percentx
        '
        Me.btn1to9percentx.AutoSize = True
        Me.btn1to9percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1to9percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn1to9percentx.BackgroundImage = CType(resources.GetObject("btn1to9percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn1to9percentx.Color = System.Drawing.Color.Gainsboro
        Me.btn1to9percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1to9percentx.FlatAppearance.BorderSize = 0
        Me.btn1to9percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1to9percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1to9percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1to9percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1to9percentx.Image = CType(resources.GetObject("btn1to9percentx.Image"), System.Drawing.Image)
        Me.btn1to9percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1to9percentx.Location = New System.Drawing.Point(66, 6)
        Me.btn1to9percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1to9percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1to9percentx.Name = "btn1to9percentx"
        Me.btn1to9percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1to9percentx.Size = New System.Drawing.Size(78, 37)
        Me.btn1to9percentx.Style = resources.GetString("btn1to9percentx.Style")
        Me.btn1to9percentx.TabIndex = 63
        Me.btn1to9percentx.Text = "1 to 9%"
        Me.btn1to9percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1to9percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1to9percentx.UseCompatibleTextRendering = True
        Me.btn1to9percentx.UseVisualStyleBackColor = True
        '
        'btn10to19percentx
        '
        Me.btn10to19percentx.AutoSize = True
        Me.btn10to19percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10to19percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn10to19percentx.BackgroundImage = CType(resources.GetObject("btn10to19percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn10to19percentx.Color = System.Drawing.Color.LightGray
        Me.btn10to19percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10to19percentx.FlatAppearance.BorderSize = 0
        Me.btn10to19percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10to19percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10to19percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10to19percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10to19percentx.Image = CType(resources.GetObject("btn10to19percentx.Image"), System.Drawing.Image)
        Me.btn10to19percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10to19percentx.Location = New System.Drawing.Point(151, 6)
        Me.btn10to19percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10to19percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10to19percentx.Name = "btn10to19percentx"
        Me.btn10to19percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10to19percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn10to19percentx.Style = resources.GetString("btn10to19percentx.Style")
        Me.btn10to19percentx.TabIndex = 64
        Me.btn10to19percentx.Text = "10 to 19%"
        Me.btn10to19percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10to19percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10to19percentx.UseCompatibleTextRendering = True
        Me.btn10to19percentx.UseVisualStyleBackColor = True
        '
        'btn20to29percentx
        '
        Me.btn20to29percentx.AutoSize = True
        Me.btn20to29percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn20to29percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn20to29percentx.BackgroundImage = CType(resources.GetObject("btn20to29percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn20to29percentx.Color = System.Drawing.Color.Silver
        Me.btn20to29percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn20to29percentx.FlatAppearance.BorderSize = 0
        Me.btn20to29percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn20to29percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn20to29percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20to29percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn20to29percentx.Image = CType(resources.GetObject("btn20to29percentx.Image"), System.Drawing.Image)
        Me.btn20to29percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20to29percentx.Location = New System.Drawing.Point(251, 6)
        Me.btn20to29percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn20to29percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn20to29percentx.Name = "btn20to29percentx"
        Me.btn20to29percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn20to29percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn20to29percentx.Style = resources.GetString("btn20to29percentx.Style")
        Me.btn20to29percentx.TabIndex = 65
        Me.btn20to29percentx.Text = "20 to 29%"
        Me.btn20to29percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn20to29percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20to29percentx.UseCompatibleTextRendering = True
        Me.btn20to29percentx.UseVisualStyleBackColor = True
        '
        'btn30to39percentx
        '
        Me.btn30to39percentx.AutoSize = True
        Me.btn30to39percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn30to39percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn30to39percentx.BackgroundImage = CType(resources.GetObject("btn30to39percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn30to39percentx.Color = System.Drawing.Color.DarkGray
        Me.btn30to39percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn30to39percentx.FlatAppearance.BorderSize = 0
        Me.btn30to39percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn30to39percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn30to39percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn30to39percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn30to39percentx.Image = CType(resources.GetObject("btn30to39percentx.Image"), System.Drawing.Image)
        Me.btn30to39percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30to39percentx.Location = New System.Drawing.Point(351, 6)
        Me.btn30to39percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn30to39percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn30to39percentx.Name = "btn30to39percentx"
        Me.btn30to39percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn30to39percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn30to39percentx.Style = resources.GetString("btn30to39percentx.Style")
        Me.btn30to39percentx.TabIndex = 66
        Me.btn30to39percentx.Text = "30 to 39%"
        Me.btn30to39percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn30to39percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn30to39percentx.UseCompatibleTextRendering = True
        Me.btn30to39percentx.UseVisualStyleBackColor = True
        '
        'btn40to49percentx
        '
        Me.btn40to49percentx.AutoSize = True
        Me.btn40to49percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn40to49percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn40to49percentx.BackgroundImage = CType(resources.GetObject("btn40to49percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn40to49percentx.Color = System.Drawing.Color.Gray
        Me.btn40to49percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn40to49percentx.FlatAppearance.BorderSize = 0
        Me.btn40to49percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn40to49percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn40to49percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn40to49percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn40to49percentx.Image = CType(resources.GetObject("btn40to49percentx.Image"), System.Drawing.Image)
        Me.btn40to49percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40to49percentx.Location = New System.Drawing.Point(451, 6)
        Me.btn40to49percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn40to49percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn40to49percentx.Name = "btn40to49percentx"
        Me.btn40to49percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn40to49percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn40to49percentx.Style = resources.GetString("btn40to49percentx.Style")
        Me.btn40to49percentx.TabIndex = 67
        Me.btn40to49percentx.Text = "40 to 49%"
        Me.btn40to49percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn40to49percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn40to49percentx.UseCompatibleTextRendering = True
        Me.btn40to49percentx.UseVisualStyleBackColor = True
        '
        'btn50to59percentx
        '
        Me.btn50to59percentx.AutoSize = True
        Me.btn50to59percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn50to59percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn50to59percentx.BackgroundImage = CType(resources.GetObject("btn50to59percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn50to59percentx.Color = System.Drawing.Color.DimGray
        Me.btn50to59percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn50to59percentx.FlatAppearance.BorderSize = 0
        Me.btn50to59percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn50to59percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn50to59percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50to59percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50to59percentx.Image = CType(resources.GetObject("btn50to59percentx.Image"), System.Drawing.Image)
        Me.btn50to59percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50to59percentx.Location = New System.Drawing.Point(551, 6)
        Me.btn50to59percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn50to59percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn50to59percentx.Name = "btn50to59percentx"
        Me.btn50to59percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn50to59percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn50to59percentx.Style = resources.GetString("btn50to59percentx.Style")
        Me.btn50to59percentx.TabIndex = 68
        Me.btn50to59percentx.Text = "50 to 59%"
        Me.btn50to59percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50to59percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50to59percentx.UseCompatibleTextRendering = True
        Me.btn50to59percentx.UseVisualStyleBackColor = True
        '
        'btn60to69percentx
        '
        Me.btn60to69percentx.AutoSize = True
        Me.btn60to69percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn60to69percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn60to69percentx.BackgroundImage = CType(resources.GetObject("btn60to69percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn60to69percentx.Color = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btn60to69percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn60to69percentx.FlatAppearance.BorderSize = 0
        Me.btn60to69percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn60to69percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn60to69percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn60to69percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn60to69percentx.Image = CType(resources.GetObject("btn60to69percentx.Image"), System.Drawing.Image)
        Me.btn60to69percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn60to69percentx.Location = New System.Drawing.Point(651, 6)
        Me.btn60to69percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn60to69percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn60to69percentx.Name = "btn60to69percentx"
        Me.btn60to69percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn60to69percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn60to69percentx.Style = resources.GetString("btn60to69percentx.Style")
        Me.btn60to69percentx.TabIndex = 69
        Me.btn60to69percentx.Text = "60 to 69%"
        Me.btn60to69percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn60to69percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn60to69percentx.UseCompatibleTextRendering = True
        Me.btn60to69percentx.UseVisualStyleBackColor = True
        '
        'btn70to79percentx
        '
        Me.btn70to79percentx.AutoSize = True
        Me.btn70to79percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn70to79percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn70to79percentx.BackgroundImage = CType(resources.GetObject("btn70to79percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn70to79percentx.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn70to79percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn70to79percentx.FlatAppearance.BorderSize = 0
        Me.btn70to79percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn70to79percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn70to79percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn70to79percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn70to79percentx.Image = CType(resources.GetObject("btn70to79percentx.Image"), System.Drawing.Image)
        Me.btn70to79percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn70to79percentx.Location = New System.Drawing.Point(751, 6)
        Me.btn70to79percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn70to79percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn70to79percentx.Name = "btn70to79percentx"
        Me.btn70to79percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn70to79percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn70to79percentx.Style = resources.GetString("btn70to79percentx.Style")
        Me.btn70to79percentx.TabIndex = 70
        Me.btn70to79percentx.Text = "70 to 79%"
        Me.btn70to79percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn70to79percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn70to79percentx.UseCompatibleTextRendering = True
        Me.btn70to79percentx.UseVisualStyleBackColor = True
        '
        'btn80to89percentx
        '
        Me.btn80to89percentx.AutoSize = True
        Me.btn80to89percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn80to89percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn80to89percentx.BackgroundImage = CType(resources.GetObject("btn80to89percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn80to89percentx.Color = System.Drawing.Color.Black
        Me.btn80to89percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn80to89percentx.FlatAppearance.BorderSize = 0
        Me.btn80to89percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn80to89percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn80to89percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn80to89percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn80to89percentx.Image = CType(resources.GetObject("btn80to89percentx.Image"), System.Drawing.Image)
        Me.btn80to89percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn80to89percentx.Location = New System.Drawing.Point(851, 6)
        Me.btn80to89percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn80to89percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn80to89percentx.Name = "btn80to89percentx"
        Me.btn80to89percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn80to89percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn80to89percentx.Style = resources.GetString("btn80to89percentx.Style")
        Me.btn80to89percentx.TabIndex = 71
        Me.btn80to89percentx.Text = "80 to 89%"
        Me.btn80to89percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn80to89percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn80to89percentx.UseCompatibleTextRendering = True
        Me.btn80to89percentx.UseVisualStyleBackColor = True
        '
        'btn90to99percentx
        '
        Me.btn90to99percentx.AutoSize = True
        Me.btn90to99percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn90to99percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn90to99percentx.BackgroundImage = CType(resources.GetObject("btn90to99percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn90to99percentx.Color = System.Drawing.Color.Black
        Me.btn90to99percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn90to99percentx.FlatAppearance.BorderSize = 0
        Me.btn90to99percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn90to99percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn90to99percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn90to99percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn90to99percentx.Image = CType(resources.GetObject("btn90to99percentx.Image"), System.Drawing.Image)
        Me.btn90to99percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn90to99percentx.Location = New System.Drawing.Point(951, 6)
        Me.btn90to99percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn90to99percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn90to99percentx.Name = "btn90to99percentx"
        Me.btn90to99percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn90to99percentx.Size = New System.Drawing.Size(93, 37)
        Me.btn90to99percentx.Style = resources.GetString("btn90to99percentx.Style")
        Me.btn90to99percentx.TabIndex = 72
        Me.btn90to99percentx.Text = "90 to 99%"
        Me.btn90to99percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn90to99percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn90to99percentx.UseCompatibleTextRendering = True
        Me.btn90to99percentx.UseVisualStyleBackColor = True
        '
        'btn100percentx
        '
        Me.btn100percentx.AutoSize = True
        Me.btn100percentx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn100percentx.BackColor = System.Drawing.Color.Transparent
        Me.btn100percentx.BackgroundImage = CType(resources.GetObject("btn100percentx.BackgroundImage"), System.Drawing.Image)
        Me.btn100percentx.Color = System.Drawing.Color.Black
        Me.btn100percentx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn100percentx.FlatAppearance.BorderSize = 0
        Me.btn100percentx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn100percentx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn100percentx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100percentx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100percentx.Image = CType(resources.GetObject("btn100percentx.Image"), System.Drawing.Image)
        Me.btn100percentx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn100percentx.Location = New System.Drawing.Point(1051, 6)
        Me.btn100percentx.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn100percentx.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn100percentx.Name = "btn100percentx"
        Me.btn100percentx.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn100percentx.Size = New System.Drawing.Size(67, 37)
        Me.btn100percentx.Style = resources.GetString("btn100percentx.Style")
        Me.btn100percentx.TabIndex = 73
        Me.btn100percentx.Text = "100%"
        Me.btn100percentx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn100percentx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn100percentx.UseCompatibleTextRendering = True
        Me.btn100percentx.UseVisualStyleBackColor = True
        '
        'btnCursorX
        '
        Me.btnCursorX.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnCursorX.BackColor = System.Drawing.Color.Transparent
        Me.btnCursorX.BackgroundImage = CType(resources.GetObject("btnCursorX.BackgroundImage"), System.Drawing.Image)
        Me.btnCursorX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCursorX.FlatAppearance.BorderSize = 0
        Me.btnCursorX.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnCursorX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCursorX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCursorX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCursorX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCursorX.Image = CType(resources.GetObject("btnCursorX.Image"), System.Drawing.Image)
        Me.btnCursorX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCursorX.Location = New System.Drawing.Point(4, 720)
        Me.btnCursorX.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCursorX.Name = "btnCursorX"
        Me.btnCursorX.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnCursorX.Size = New System.Drawing.Size(155, 28)
        Me.btnCursorX.Style = resources.GetString("btnCursorX.Style")
        Me.btnCursorX.TabIndex = 87
        Me.btnCursorX.Text = "Cursor (x)"
        Me.btnCursorX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCursorX.UseCompatibleTextRendering = True
        Me.btnCursorX.UseVisualStyleBackColor = False
        '
        'btnWebcam
        '
        Me.btnWebcam.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnWebcam.BackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.BackgroundImage = CType(resources.GetObject("btnWebcam.BackgroundImage"), System.Drawing.Image)
        Me.btnWebcam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWebcam.FlatAppearance.BorderSize = 0
        Me.btnWebcam.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWebcam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnWebcam.Image = CType(resources.GetObject("btnWebcam.Image"), System.Drawing.Image)
        Me.btnWebcam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWebcam.Location = New System.Drawing.Point(4, 182)
        Me.btnWebcam.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWebcam.Name = "btnWebcam"
        Me.btnWebcam.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnWebcam.Size = New System.Drawing.Size(155, 28)
        Me.btnWebcam.Style = resources.GetString("btnWebcam.Style")
        Me.btnWebcam.TabIndex = 86
        Me.btnWebcam.Text = "Webcam"
        Me.btnWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnWebcam.UseCompatibleTextRendering = True
        Me.btnWebcam.UseVisualStyleBackColor = False
        '
        'StylizedPanel5
        '
        Me.StylizedPanel5.Controls.Add(Me.pnlTime)
        Me.StylizedPanel5.Location = New System.Drawing.Point(167, 302)
        Me.StylizedPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel5.Name = "StylizedPanel5"
        Me.StylizedPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel5.Size = New System.Drawing.Size(821, 76)
        Me.StylizedPanel5.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel5.TabIndex = 85
        '
        'pnlTime
        '
        Me.pnlTime.AutoScroll = True
        Me.pnlTime.BackColor = System.Drawing.Color.White
        Me.pnlTime.Controls.Add(Me.btn12AM)
        Me.pnlTime.Controls.Add(Me.btn1AM)
        Me.pnlTime.Controls.Add(Me.btn2AM)
        Me.pnlTime.Controls.Add(Me.btn3AM)
        Me.pnlTime.Controls.Add(Me.btn4AM)
        Me.pnlTime.Controls.Add(Me.btn5AM)
        Me.pnlTime.Controls.Add(Me.btn6AM)
        Me.pnlTime.Controls.Add(Me.btn7AM)
        Me.pnlTime.Controls.Add(Me.btn8AM)
        Me.pnlTime.Controls.Add(Me.btn9AM)
        Me.pnlTime.Controls.Add(Me.btn10AM)
        Me.pnlTime.Controls.Add(Me.btn11AM)
        Me.pnlTime.Controls.Add(Me.btn12PM)
        Me.pnlTime.Controls.Add(Me.btn1PM)
        Me.pnlTime.Controls.Add(Me.btn2PM)
        Me.pnlTime.Controls.Add(Me.btn3PM)
        Me.pnlTime.Controls.Add(Me.btn4PM)
        Me.pnlTime.Controls.Add(Me.btn5PM)
        Me.pnlTime.Controls.Add(Me.btn6PM)
        Me.pnlTime.Controls.Add(Me.btn7PM)
        Me.pnlTime.Controls.Add(Me.btn8PM)
        Me.pnlTime.Controls.Add(Me.btn9PM)
        Me.pnlTime.Controls.Add(Me.btn10PM)
        Me.pnlTime.Controls.Add(Me.btn11PM)
        Me.pnlTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTime.Location = New System.Drawing.Point(1, 1)
        Me.pnlTime.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Padding = New System.Windows.Forms.Padding(7, 0, 13, 0)
        Me.pnlTime.Size = New System.Drawing.Size(819, 74)
        Me.pnlTime.TabIndex = 64
        Me.pnlTime.WrapContents = False
        '
        'btn12AM
        '
        Me.btn12AM.AutoSize = True
        Me.btn12AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn12AM.BackColor = System.Drawing.Color.Transparent
        Me.btn12AM.BackgroundImage = CType(resources.GetObject("btn12AM.BackgroundImage"), System.Drawing.Image)
        Me.btn12AM.Color = System.Drawing.Color.MidnightBlue
        Me.btn12AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn12AM.FlatAppearance.BorderSize = 0
        Me.btn12AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn12AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn12AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn12AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn12AM.Image = CType(resources.GetObject("btn12AM.Image"), System.Drawing.Image)
        Me.btn12AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn12AM.Location = New System.Drawing.Point(7, 6)
        Me.btn12AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn12AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn12AM.Name = "btn12AM"
        Me.btn12AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn12AM.Size = New System.Drawing.Size(71, 37)
        Me.btn12AM.Style = resources.GetString("btn12AM.Style")
        Me.btn12AM.TabIndex = 54
        Me.btn12AM.Text = "12 AM"
        Me.btn12AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn12AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn12AM.UseCompatibleTextRendering = True
        Me.btn12AM.UseVisualStyleBackColor = True
        '
        'btn1AM
        '
        Me.btn1AM.AutoSize = True
        Me.btn1AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1AM.BackColor = System.Drawing.Color.Transparent
        Me.btn1AM.BackgroundImage = CType(resources.GetObject("btn1AM.BackgroundImage"), System.Drawing.Image)
        Me.btn1AM.Color = System.Drawing.Color.DarkBlue
        Me.btn1AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1AM.FlatAppearance.BorderSize = 0
        Me.btn1AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1AM.Image = CType(resources.GetObject("btn1AM.Image"), System.Drawing.Image)
        Me.btn1AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1AM.Location = New System.Drawing.Point(85, 6)
        Me.btn1AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1AM.Name = "btn1AM"
        Me.btn1AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1AM.Size = New System.Drawing.Size(64, 37)
        Me.btn1AM.Style = resources.GetString("btn1AM.Style")
        Me.btn1AM.TabIndex = 55
        Me.btn1AM.Text = "1 AM"
        Me.btn1AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1AM.UseCompatibleTextRendering = True
        Me.btn1AM.UseVisualStyleBackColor = True
        '
        'btn2AM
        '
        Me.btn2AM.AutoSize = True
        Me.btn2AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn2AM.BackColor = System.Drawing.Color.Transparent
        Me.btn2AM.BackgroundImage = CType(resources.GetObject("btn2AM.BackgroundImage"), System.Drawing.Image)
        Me.btn2AM.Color = System.Drawing.Color.MediumBlue
        Me.btn2AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn2AM.FlatAppearance.BorderSize = 0
        Me.btn2AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn2AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn2AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn2AM.Image = CType(resources.GetObject("btn2AM.Image"), System.Drawing.Image)
        Me.btn2AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2AM.Location = New System.Drawing.Point(156, 6)
        Me.btn2AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn2AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn2AM.Name = "btn2AM"
        Me.btn2AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn2AM.Size = New System.Drawing.Size(64, 37)
        Me.btn2AM.Style = resources.GetString("btn2AM.Style")
        Me.btn2AM.TabIndex = 56
        Me.btn2AM.Text = "2 AM"
        Me.btn2AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn2AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn2AM.UseCompatibleTextRendering = True
        Me.btn2AM.UseVisualStyleBackColor = True
        '
        'btn3AM
        '
        Me.btn3AM.AutoSize = True
        Me.btn3AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn3AM.BackColor = System.Drawing.Color.Transparent
        Me.btn3AM.BackgroundImage = CType(resources.GetObject("btn3AM.BackgroundImage"), System.Drawing.Image)
        Me.btn3AM.Color = System.Drawing.Color.SlateBlue
        Me.btn3AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn3AM.FlatAppearance.BorderSize = 0
        Me.btn3AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn3AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn3AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn3AM.Image = CType(resources.GetObject("btn3AM.Image"), System.Drawing.Image)
        Me.btn3AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3AM.Location = New System.Drawing.Point(227, 6)
        Me.btn3AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn3AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn3AM.Name = "btn3AM"
        Me.btn3AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn3AM.Size = New System.Drawing.Size(64, 37)
        Me.btn3AM.Style = resources.GetString("btn3AM.Style")
        Me.btn3AM.TabIndex = 57
        Me.btn3AM.Text = "3 AM"
        Me.btn3AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn3AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn3AM.UseCompatibleTextRendering = True
        Me.btn3AM.UseVisualStyleBackColor = True
        '
        'btn4AM
        '
        Me.btn4AM.AutoSize = True
        Me.btn4AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn4AM.BackColor = System.Drawing.Color.Transparent
        Me.btn4AM.BackgroundImage = CType(resources.GetObject("btn4AM.BackgroundImage"), System.Drawing.Image)
        Me.btn4AM.Color = System.Drawing.Color.MediumPurple
        Me.btn4AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn4AM.FlatAppearance.BorderSize = 0
        Me.btn4AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn4AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn4AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn4AM.Image = CType(resources.GetObject("btn4AM.Image"), System.Drawing.Image)
        Me.btn4AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4AM.Location = New System.Drawing.Point(298, 6)
        Me.btn4AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn4AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn4AM.Name = "btn4AM"
        Me.btn4AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn4AM.Size = New System.Drawing.Size(64, 37)
        Me.btn4AM.Style = resources.GetString("btn4AM.Style")
        Me.btn4AM.TabIndex = 58
        Me.btn4AM.Text = "4 AM"
        Me.btn4AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn4AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn4AM.UseCompatibleTextRendering = True
        Me.btn4AM.UseVisualStyleBackColor = True
        '
        'btn5AM
        '
        Me.btn5AM.AutoSize = True
        Me.btn5AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn5AM.BackColor = System.Drawing.Color.Transparent
        Me.btn5AM.BackgroundImage = CType(resources.GetObject("btn5AM.BackgroundImage"), System.Drawing.Image)
        Me.btn5AM.Color = System.Drawing.Color.Thistle
        Me.btn5AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn5AM.FlatAppearance.BorderSize = 0
        Me.btn5AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn5AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn5AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn5AM.Image = CType(resources.GetObject("btn5AM.Image"), System.Drawing.Image)
        Me.btn5AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn5AM.Location = New System.Drawing.Point(369, 6)
        Me.btn5AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn5AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn5AM.Name = "btn5AM"
        Me.btn5AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn5AM.Size = New System.Drawing.Size(64, 37)
        Me.btn5AM.Style = resources.GetString("btn5AM.Style")
        Me.btn5AM.TabIndex = 59
        Me.btn5AM.Text = "5 AM"
        Me.btn5AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn5AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn5AM.UseCompatibleTextRendering = True
        Me.btn5AM.UseVisualStyleBackColor = True
        '
        'btn6AM
        '
        Me.btn6AM.AutoSize = True
        Me.btn6AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn6AM.BackColor = System.Drawing.Color.Transparent
        Me.btn6AM.BackgroundImage = CType(resources.GetObject("btn6AM.BackgroundImage"), System.Drawing.Image)
        Me.btn6AM.Color = System.Drawing.Color.Plum
        Me.btn6AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn6AM.FlatAppearance.BorderSize = 0
        Me.btn6AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn6AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn6AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn6AM.Image = CType(resources.GetObject("btn6AM.Image"), System.Drawing.Image)
        Me.btn6AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn6AM.Location = New System.Drawing.Point(440, 6)
        Me.btn6AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn6AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn6AM.Name = "btn6AM"
        Me.btn6AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn6AM.Size = New System.Drawing.Size(64, 37)
        Me.btn6AM.Style = resources.GetString("btn6AM.Style")
        Me.btn6AM.TabIndex = 60
        Me.btn6AM.Text = "6 AM"
        Me.btn6AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn6AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn6AM.UseCompatibleTextRendering = True
        Me.btn6AM.UseVisualStyleBackColor = True
        '
        'btn7AM
        '
        Me.btn7AM.AutoSize = True
        Me.btn7AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn7AM.BackColor = System.Drawing.Color.Transparent
        Me.btn7AM.BackgroundImage = CType(resources.GetObject("btn7AM.BackgroundImage"), System.Drawing.Image)
        Me.btn7AM.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn7AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn7AM.FlatAppearance.BorderSize = 0
        Me.btn7AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn7AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn7AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn7AM.Image = CType(resources.GetObject("btn7AM.Image"), System.Drawing.Image)
        Me.btn7AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn7AM.Location = New System.Drawing.Point(511, 6)
        Me.btn7AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn7AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn7AM.Name = "btn7AM"
        Me.btn7AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn7AM.Size = New System.Drawing.Size(64, 37)
        Me.btn7AM.Style = resources.GetString("btn7AM.Style")
        Me.btn7AM.TabIndex = 61
        Me.btn7AM.Text = "7 AM"
        Me.btn7AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn7AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn7AM.UseCompatibleTextRendering = True
        Me.btn7AM.UseVisualStyleBackColor = True
        '
        'btn8AM
        '
        Me.btn8AM.AutoSize = True
        Me.btn8AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn8AM.BackColor = System.Drawing.Color.Transparent
        Me.btn8AM.BackgroundImage = CType(resources.GetObject("btn8AM.BackgroundImage"), System.Drawing.Image)
        Me.btn8AM.Color = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btn8AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn8AM.FlatAppearance.BorderSize = 0
        Me.btn8AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn8AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn8AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn8AM.Image = CType(resources.GetObject("btn8AM.Image"), System.Drawing.Image)
        Me.btn8AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn8AM.Location = New System.Drawing.Point(582, 6)
        Me.btn8AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn8AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn8AM.Name = "btn8AM"
        Me.btn8AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn8AM.Size = New System.Drawing.Size(64, 37)
        Me.btn8AM.Style = resources.GetString("btn8AM.Style")
        Me.btn8AM.TabIndex = 62
        Me.btn8AM.Text = "8 AM"
        Me.btn8AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn8AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn8AM.UseCompatibleTextRendering = True
        Me.btn8AM.UseVisualStyleBackColor = True
        '
        'btn9AM
        '
        Me.btn9AM.AutoSize = True
        Me.btn9AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn9AM.BackColor = System.Drawing.Color.Transparent
        Me.btn9AM.BackgroundImage = CType(resources.GetObject("btn9AM.BackgroundImage"), System.Drawing.Image)
        Me.btn9AM.Color = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn9AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn9AM.FlatAppearance.BorderSize = 0
        Me.btn9AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn9AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn9AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn9AM.Image = CType(resources.GetObject("btn9AM.Image"), System.Drawing.Image)
        Me.btn9AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn9AM.Location = New System.Drawing.Point(653, 6)
        Me.btn9AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn9AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn9AM.Name = "btn9AM"
        Me.btn9AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn9AM.Size = New System.Drawing.Size(64, 37)
        Me.btn9AM.Style = resources.GetString("btn9AM.Style")
        Me.btn9AM.TabIndex = 65
        Me.btn9AM.Text = "9 AM"
        Me.btn9AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn9AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn9AM.UseCompatibleTextRendering = True
        Me.btn9AM.UseVisualStyleBackColor = True
        '
        'btn10AM
        '
        Me.btn10AM.AutoSize = True
        Me.btn10AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10AM.BackColor = System.Drawing.Color.Transparent
        Me.btn10AM.BackgroundImage = CType(resources.GetObject("btn10AM.BackgroundImage"), System.Drawing.Image)
        Me.btn10AM.Color = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn10AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10AM.FlatAppearance.BorderSize = 0
        Me.btn10AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10AM.Image = CType(resources.GetObject("btn10AM.Image"), System.Drawing.Image)
        Me.btn10AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10AM.Location = New System.Drawing.Point(724, 6)
        Me.btn10AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10AM.Name = "btn10AM"
        Me.btn10AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10AM.Size = New System.Drawing.Size(71, 37)
        Me.btn10AM.Style = resources.GetString("btn10AM.Style")
        Me.btn10AM.TabIndex = 63
        Me.btn10AM.Text = "10 AM"
        Me.btn10AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10AM.UseCompatibleTextRendering = True
        Me.btn10AM.UseVisualStyleBackColor = True
        '
        'btn11AM
        '
        Me.btn11AM.AutoSize = True
        Me.btn11AM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn11AM.BackColor = System.Drawing.Color.Transparent
        Me.btn11AM.BackgroundImage = CType(resources.GetObject("btn11AM.BackgroundImage"), System.Drawing.Image)
        Me.btn11AM.Color = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn11AM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn11AM.FlatAppearance.BorderSize = 0
        Me.btn11AM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn11AM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn11AM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn11AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn11AM.Image = CType(resources.GetObject("btn11AM.Image"), System.Drawing.Image)
        Me.btn11AM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn11AM.Location = New System.Drawing.Point(802, 6)
        Me.btn11AM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn11AM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn11AM.Name = "btn11AM"
        Me.btn11AM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn11AM.Size = New System.Drawing.Size(71, 37)
        Me.btn11AM.Style = resources.GetString("btn11AM.Style")
        Me.btn11AM.TabIndex = 64
        Me.btn11AM.Text = "11 AM"
        Me.btn11AM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn11AM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn11AM.UseCompatibleTextRendering = True
        Me.btn11AM.UseVisualStyleBackColor = True
        '
        'btn12PM
        '
        Me.btn12PM.AutoSize = True
        Me.btn12PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn12PM.BackColor = System.Drawing.Color.Transparent
        Me.btn12PM.BackgroundImage = CType(resources.GetObject("btn12PM.BackgroundImage"), System.Drawing.Image)
        Me.btn12PM.Color = System.Drawing.Color.DeepSkyBlue
        Me.btn12PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn12PM.FlatAppearance.BorderSize = 0
        Me.btn12PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn12PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn12PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn12PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn12PM.Image = CType(resources.GetObject("btn12PM.Image"), System.Drawing.Image)
        Me.btn12PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn12PM.Location = New System.Drawing.Point(880, 6)
        Me.btn12PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn12PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn12PM.Name = "btn12PM"
        Me.btn12PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn12PM.Size = New System.Drawing.Size(71, 37)
        Me.btn12PM.Style = resources.GetString("btn12PM.Style")
        Me.btn12PM.TabIndex = 66
        Me.btn12PM.Text = "12 PM"
        Me.btn12PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn12PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn12PM.UseCompatibleTextRendering = True
        Me.btn12PM.UseVisualStyleBackColor = True
        '
        'btn1PM
        '
        Me.btn1PM.AutoSize = True
        Me.btn1PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1PM.BackColor = System.Drawing.Color.Transparent
        Me.btn1PM.BackgroundImage = CType(resources.GetObject("btn1PM.BackgroundImage"), System.Drawing.Image)
        Me.btn1PM.Color = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn1PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1PM.FlatAppearance.BorderSize = 0
        Me.btn1PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1PM.Image = CType(resources.GetObject("btn1PM.Image"), System.Drawing.Image)
        Me.btn1PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1PM.Location = New System.Drawing.Point(958, 6)
        Me.btn1PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1PM.Name = "btn1PM"
        Me.btn1PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1PM.Size = New System.Drawing.Size(64, 37)
        Me.btn1PM.Style = resources.GetString("btn1PM.Style")
        Me.btn1PM.TabIndex = 67
        Me.btn1PM.Text = "1 PM"
        Me.btn1PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1PM.UseCompatibleTextRendering = True
        Me.btn1PM.UseVisualStyleBackColor = True
        '
        'btn2PM
        '
        Me.btn2PM.AutoSize = True
        Me.btn2PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn2PM.BackColor = System.Drawing.Color.Transparent
        Me.btn2PM.BackgroundImage = CType(resources.GetObject("btn2PM.BackgroundImage"), System.Drawing.Image)
        Me.btn2PM.Color = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn2PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn2PM.FlatAppearance.BorderSize = 0
        Me.btn2PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn2PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn2PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn2PM.Image = CType(resources.GetObject("btn2PM.Image"), System.Drawing.Image)
        Me.btn2PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2PM.Location = New System.Drawing.Point(1029, 6)
        Me.btn2PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn2PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn2PM.Name = "btn2PM"
        Me.btn2PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn2PM.Size = New System.Drawing.Size(64, 37)
        Me.btn2PM.Style = resources.GetString("btn2PM.Style")
        Me.btn2PM.TabIndex = 68
        Me.btn2PM.Text = "2 PM"
        Me.btn2PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn2PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn2PM.UseCompatibleTextRendering = True
        Me.btn2PM.UseVisualStyleBackColor = True
        '
        'btn3PM
        '
        Me.btn3PM.AutoSize = True
        Me.btn3PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn3PM.BackColor = System.Drawing.Color.Transparent
        Me.btn3PM.BackgroundImage = CType(resources.GetObject("btn3PM.BackgroundImage"), System.Drawing.Image)
        Me.btn3PM.Color = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn3PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn3PM.FlatAppearance.BorderSize = 0
        Me.btn3PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn3PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn3PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn3PM.Image = CType(resources.GetObject("btn3PM.Image"), System.Drawing.Image)
        Me.btn3PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3PM.Location = New System.Drawing.Point(1100, 6)
        Me.btn3PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn3PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn3PM.Name = "btn3PM"
        Me.btn3PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn3PM.Size = New System.Drawing.Size(64, 37)
        Me.btn3PM.Style = resources.GetString("btn3PM.Style")
        Me.btn3PM.TabIndex = 69
        Me.btn3PM.Text = "3 PM"
        Me.btn3PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn3PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn3PM.UseCompatibleTextRendering = True
        Me.btn3PM.UseVisualStyleBackColor = True
        '
        'btn4PM
        '
        Me.btn4PM.AutoSize = True
        Me.btn4PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn4PM.BackColor = System.Drawing.Color.Transparent
        Me.btn4PM.BackgroundImage = CType(resources.GetObject("btn4PM.BackgroundImage"), System.Drawing.Image)
        Me.btn4PM.Color = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn4PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn4PM.FlatAppearance.BorderSize = 0
        Me.btn4PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn4PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn4PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn4PM.Image = CType(resources.GetObject("btn4PM.Image"), System.Drawing.Image)
        Me.btn4PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4PM.Location = New System.Drawing.Point(1171, 6)
        Me.btn4PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn4PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn4PM.Name = "btn4PM"
        Me.btn4PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn4PM.Size = New System.Drawing.Size(64, 37)
        Me.btn4PM.Style = resources.GetString("btn4PM.Style")
        Me.btn4PM.TabIndex = 70
        Me.btn4PM.Text = "4 PM"
        Me.btn4PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn4PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn4PM.UseCompatibleTextRendering = True
        Me.btn4PM.UseVisualStyleBackColor = True
        '
        'btn5PM
        '
        Me.btn5PM.AutoSize = True
        Me.btn5PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn5PM.BackColor = System.Drawing.Color.Transparent
        Me.btn5PM.BackgroundImage = CType(resources.GetObject("btn5PM.BackgroundImage"), System.Drawing.Image)
        Me.btn5PM.Color = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn5PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn5PM.FlatAppearance.BorderSize = 0
        Me.btn5PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn5PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn5PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn5PM.Image = CType(resources.GetObject("btn5PM.Image"), System.Drawing.Image)
        Me.btn5PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn5PM.Location = New System.Drawing.Point(1242, 6)
        Me.btn5PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn5PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn5PM.Name = "btn5PM"
        Me.btn5PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn5PM.Size = New System.Drawing.Size(64, 37)
        Me.btn5PM.Style = resources.GetString("btn5PM.Style")
        Me.btn5PM.TabIndex = 71
        Me.btn5PM.Text = "5 PM"
        Me.btn5PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn5PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn5PM.UseCompatibleTextRendering = True
        Me.btn5PM.UseVisualStyleBackColor = True
        '
        'btn6PM
        '
        Me.btn6PM.AutoSize = True
        Me.btn6PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn6PM.BackColor = System.Drawing.Color.Transparent
        Me.btn6PM.BackgroundImage = CType(resources.GetObject("btn6PM.BackgroundImage"), System.Drawing.Image)
        Me.btn6PM.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btn6PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn6PM.FlatAppearance.BorderSize = 0
        Me.btn6PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn6PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn6PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn6PM.Image = CType(resources.GetObject("btn6PM.Image"), System.Drawing.Image)
        Me.btn6PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn6PM.Location = New System.Drawing.Point(1313, 6)
        Me.btn6PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn6PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn6PM.Name = "btn6PM"
        Me.btn6PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn6PM.Size = New System.Drawing.Size(64, 37)
        Me.btn6PM.Style = resources.GetString("btn6PM.Style")
        Me.btn6PM.TabIndex = 72
        Me.btn6PM.Text = "6 PM"
        Me.btn6PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn6PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn6PM.UseCompatibleTextRendering = True
        Me.btn6PM.UseVisualStyleBackColor = True
        '
        'btn7PM
        '
        Me.btn7PM.AutoSize = True
        Me.btn7PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn7PM.BackColor = System.Drawing.Color.Transparent
        Me.btn7PM.BackgroundImage = CType(resources.GetObject("btn7PM.BackgroundImage"), System.Drawing.Image)
        Me.btn7PM.Color = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn7PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn7PM.FlatAppearance.BorderSize = 0
        Me.btn7PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn7PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn7PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn7PM.Image = CType(resources.GetObject("btn7PM.Image"), System.Drawing.Image)
        Me.btn7PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn7PM.Location = New System.Drawing.Point(1384, 6)
        Me.btn7PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn7PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn7PM.Name = "btn7PM"
        Me.btn7PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn7PM.Size = New System.Drawing.Size(64, 37)
        Me.btn7PM.Style = resources.GetString("btn7PM.Style")
        Me.btn7PM.TabIndex = 73
        Me.btn7PM.Text = "7 PM"
        Me.btn7PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn7PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn7PM.UseCompatibleTextRendering = True
        Me.btn7PM.UseVisualStyleBackColor = True
        '
        'btn8PM
        '
        Me.btn8PM.AutoSize = True
        Me.btn8PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn8PM.BackColor = System.Drawing.Color.Transparent
        Me.btn8PM.BackgroundImage = CType(resources.GetObject("btn8PM.BackgroundImage"), System.Drawing.Image)
        Me.btn8PM.Color = System.Drawing.Color.Firebrick
        Me.btn8PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn8PM.FlatAppearance.BorderSize = 0
        Me.btn8PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn8PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn8PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn8PM.Image = CType(resources.GetObject("btn8PM.Image"), System.Drawing.Image)
        Me.btn8PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn8PM.Location = New System.Drawing.Point(1455, 6)
        Me.btn8PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn8PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn8PM.Name = "btn8PM"
        Me.btn8PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn8PM.Size = New System.Drawing.Size(64, 37)
        Me.btn8PM.Style = resources.GetString("btn8PM.Style")
        Me.btn8PM.TabIndex = 74
        Me.btn8PM.Text = "8 PM"
        Me.btn8PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn8PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn8PM.UseCompatibleTextRendering = True
        Me.btn8PM.UseVisualStyleBackColor = True
        '
        'btn9PM
        '
        Me.btn9PM.AutoSize = True
        Me.btn9PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn9PM.BackColor = System.Drawing.Color.Transparent
        Me.btn9PM.BackgroundImage = CType(resources.GetObject("btn9PM.BackgroundImage"), System.Drawing.Image)
        Me.btn9PM.Color = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btn9PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn9PM.FlatAppearance.BorderSize = 0
        Me.btn9PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn9PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn9PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn9PM.Image = CType(resources.GetObject("btn9PM.Image"), System.Drawing.Image)
        Me.btn9PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn9PM.Location = New System.Drawing.Point(1526, 6)
        Me.btn9PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn9PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn9PM.Name = "btn9PM"
        Me.btn9PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn9PM.Size = New System.Drawing.Size(64, 37)
        Me.btn9PM.Style = resources.GetString("btn9PM.Style")
        Me.btn9PM.TabIndex = 75
        Me.btn9PM.Text = "9 PM"
        Me.btn9PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn9PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn9PM.UseCompatibleTextRendering = True
        Me.btn9PM.UseVisualStyleBackColor = True
        '
        'btn10PM
        '
        Me.btn10PM.AutoSize = True
        Me.btn10PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10PM.BackColor = System.Drawing.Color.Transparent
        Me.btn10PM.BackgroundImage = CType(resources.GetObject("btn10PM.BackgroundImage"), System.Drawing.Image)
        Me.btn10PM.Color = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btn10PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10PM.FlatAppearance.BorderSize = 0
        Me.btn10PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10PM.Image = CType(resources.GetObject("btn10PM.Image"), System.Drawing.Image)
        Me.btn10PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10PM.Location = New System.Drawing.Point(1597, 6)
        Me.btn10PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10PM.Name = "btn10PM"
        Me.btn10PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10PM.Size = New System.Drawing.Size(71, 37)
        Me.btn10PM.Style = resources.GetString("btn10PM.Style")
        Me.btn10PM.TabIndex = 76
        Me.btn10PM.Text = "10 PM"
        Me.btn10PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10PM.UseCompatibleTextRendering = True
        Me.btn10PM.UseVisualStyleBackColor = True
        '
        'btn11PM
        '
        Me.btn11PM.AutoSize = True
        Me.btn11PM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn11PM.BackColor = System.Drawing.Color.Transparent
        Me.btn11PM.BackgroundImage = CType(resources.GetObject("btn11PM.BackgroundImage"), System.Drawing.Image)
        Me.btn11PM.Color = System.Drawing.Color.Black
        Me.btn11PM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn11PM.FlatAppearance.BorderSize = 0
        Me.btn11PM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn11PM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn11PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn11PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn11PM.Image = CType(resources.GetObject("btn11PM.Image"), System.Drawing.Image)
        Me.btn11PM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn11PM.Location = New System.Drawing.Point(1675, 6)
        Me.btn11PM.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn11PM.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn11PM.Name = "btn11PM"
        Me.btn11PM.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn11PM.Size = New System.Drawing.Size(71, 37)
        Me.btn11PM.Style = resources.GetString("btn11PM.Style")
        Me.btn11PM.TabIndex = 77
        Me.btn11PM.Text = "11 PM"
        Me.btn11PM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn11PM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn11PM.UseCompatibleTextRendering = True
        Me.btn11PM.UseVisualStyleBackColor = True
        '
        'StylizedPanel4
        '
        Me.StylizedPanel4.Controls.Add(Me.pnlBattery)
        Me.StylizedPanel4.Location = New System.Drawing.Point(167, 218)
        Me.StylizedPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel4.Name = "StylizedPanel4"
        Me.StylizedPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel4.Size = New System.Drawing.Size(821, 76)
        Me.StylizedPanel4.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel4.TabIndex = 84
        '
        'pnlBattery
        '
        Me.pnlBattery.AutoScroll = True
        Me.pnlBattery.BackColor = System.Drawing.Color.White
        Me.pnlBattery.Controls.Add(Me.btn0Percent)
        Me.pnlBattery.Controls.Add(Me.btn1to9Percent)
        Me.pnlBattery.Controls.Add(Me.btn10to19Percent)
        Me.pnlBattery.Controls.Add(Me.btn20to29Percent)
        Me.pnlBattery.Controls.Add(Me.btn30to39Percent)
        Me.pnlBattery.Controls.Add(Me.btn40to49Percent)
        Me.pnlBattery.Controls.Add(Me.btn50to59Percent)
        Me.pnlBattery.Controls.Add(Me.btn60to69Percent)
        Me.pnlBattery.Controls.Add(Me.btn70to79Percent)
        Me.pnlBattery.Controls.Add(Me.btn80to89Percent)
        Me.pnlBattery.Controls.Add(Me.btn90to99Percent)
        Me.pnlBattery.Controls.Add(Me.btn100Percent)
        Me.pnlBattery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBattery.Location = New System.Drawing.Point(1, 1)
        Me.pnlBattery.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBattery.Name = "pnlBattery"
        Me.pnlBattery.Padding = New System.Windows.Forms.Padding(7, 0, 13, 0)
        Me.pnlBattery.Size = New System.Drawing.Size(819, 74)
        Me.pnlBattery.TabIndex = 63
        Me.pnlBattery.WrapContents = False
        '
        'btn0Percent
        '
        Me.btn0Percent.AutoSize = True
        Me.btn0Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn0Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn0Percent.BackgroundImage = CType(resources.GetObject("btn0Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn0Percent.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn0Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn0Percent.FlatAppearance.BorderSize = 0
        Me.btn0Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn0Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn0Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn0Percent.Image = CType(resources.GetObject("btn0Percent.Image"), System.Drawing.Image)
        Me.btn0Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn0Percent.Location = New System.Drawing.Point(7, 6)
        Me.btn0Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn0Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn0Percent.Name = "btn0Percent"
        Me.btn0Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn0Percent.Size = New System.Drawing.Size(52, 37)
        Me.btn0Percent.Style = resources.GetString("btn0Percent.Style")
        Me.btn0Percent.TabIndex = 62
        Me.btn0Percent.Text = "0%"
        Me.btn0Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn0Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0Percent.UseCompatibleTextRendering = True
        Me.btn0Percent.UseVisualStyleBackColor = True
        '
        'btn1to9Percent
        '
        Me.btn1to9Percent.AutoSize = True
        Me.btn1to9Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1to9Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn1to9Percent.BackgroundImage = CType(resources.GetObject("btn1to9Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn1to9Percent.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn1to9Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1to9Percent.FlatAppearance.BorderSize = 0
        Me.btn1to9Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1to9Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1to9Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1to9Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1to9Percent.Image = CType(resources.GetObject("btn1to9Percent.Image"), System.Drawing.Image)
        Me.btn1to9Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1to9Percent.Location = New System.Drawing.Point(66, 6)
        Me.btn1to9Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1to9Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1to9Percent.Name = "btn1to9Percent"
        Me.btn1to9Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1to9Percent.Size = New System.Drawing.Size(78, 37)
        Me.btn1to9Percent.Style = resources.GetString("btn1to9Percent.Style")
        Me.btn1to9Percent.TabIndex = 63
        Me.btn1to9Percent.Text = "1 to 9%"
        Me.btn1to9Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1to9Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1to9Percent.UseCompatibleTextRendering = True
        Me.btn1to9Percent.UseVisualStyleBackColor = True
        '
        'btn10to19Percent
        '
        Me.btn10to19Percent.AutoSize = True
        Me.btn10to19Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10to19Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn10to19Percent.BackgroundImage = CType(resources.GetObject("btn10to19Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn10to19Percent.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn10to19Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10to19Percent.FlatAppearance.BorderSize = 0
        Me.btn10to19Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10to19Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10to19Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10to19Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10to19Percent.Image = CType(resources.GetObject("btn10to19Percent.Image"), System.Drawing.Image)
        Me.btn10to19Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10to19Percent.Location = New System.Drawing.Point(151, 6)
        Me.btn10to19Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10to19Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10to19Percent.Name = "btn10to19Percent"
        Me.btn10to19Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10to19Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn10to19Percent.Style = resources.GetString("btn10to19Percent.Style")
        Me.btn10to19Percent.TabIndex = 64
        Me.btn10to19Percent.Text = "10 to 19%"
        Me.btn10to19Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10to19Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10to19Percent.UseCompatibleTextRendering = True
        Me.btn10to19Percent.UseVisualStyleBackColor = True
        '
        'btn20to29Percent
        '
        Me.btn20to29Percent.AutoSize = True
        Me.btn20to29Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn20to29Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn20to29Percent.BackgroundImage = CType(resources.GetObject("btn20to29Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn20to29Percent.Color = System.Drawing.Color.NavajoWhite
        Me.btn20to29Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn20to29Percent.FlatAppearance.BorderSize = 0
        Me.btn20to29Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn20to29Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn20to29Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20to29Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn20to29Percent.Image = CType(resources.GetObject("btn20to29Percent.Image"), System.Drawing.Image)
        Me.btn20to29Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20to29Percent.Location = New System.Drawing.Point(251, 6)
        Me.btn20to29Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn20to29Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn20to29Percent.Name = "btn20to29Percent"
        Me.btn20to29Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn20to29Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn20to29Percent.Style = resources.GetString("btn20to29Percent.Style")
        Me.btn20to29Percent.TabIndex = 65
        Me.btn20to29Percent.Text = "20 to 29%"
        Me.btn20to29Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn20to29Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20to29Percent.UseCompatibleTextRendering = True
        Me.btn20to29Percent.UseVisualStyleBackColor = True
        '
        'btn30to39Percent
        '
        Me.btn30to39Percent.AutoSize = True
        Me.btn30to39Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn30to39Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn30to39Percent.BackgroundImage = CType(resources.GetObject("btn30to39Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn30to39Percent.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btn30to39Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn30to39Percent.FlatAppearance.BorderSize = 0
        Me.btn30to39Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn30to39Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn30to39Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn30to39Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn30to39Percent.Image = CType(resources.GetObject("btn30to39Percent.Image"), System.Drawing.Image)
        Me.btn30to39Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30to39Percent.Location = New System.Drawing.Point(351, 6)
        Me.btn30to39Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn30to39Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn30to39Percent.Name = "btn30to39Percent"
        Me.btn30to39Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn30to39Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn30to39Percent.Style = resources.GetString("btn30to39Percent.Style")
        Me.btn30to39Percent.TabIndex = 66
        Me.btn30to39Percent.Text = "30 to 39%"
        Me.btn30to39Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn30to39Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn30to39Percent.UseCompatibleTextRendering = True
        Me.btn30to39Percent.UseVisualStyleBackColor = True
        '
        'btn40to49Percent
        '
        Me.btn40to49Percent.AutoSize = True
        Me.btn40to49Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn40to49Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn40to49Percent.BackgroundImage = CType(resources.GetObject("btn40to49Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn40to49Percent.Color = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn40to49Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn40to49Percent.FlatAppearance.BorderSize = 0
        Me.btn40to49Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn40to49Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn40to49Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn40to49Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn40to49Percent.Image = CType(resources.GetObject("btn40to49Percent.Image"), System.Drawing.Image)
        Me.btn40to49Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40to49Percent.Location = New System.Drawing.Point(451, 6)
        Me.btn40to49Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn40to49Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn40to49Percent.Name = "btn40to49Percent"
        Me.btn40to49Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn40to49Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn40to49Percent.Style = resources.GetString("btn40to49Percent.Style")
        Me.btn40to49Percent.TabIndex = 67
        Me.btn40to49Percent.Text = "40 to 49%"
        Me.btn40to49Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn40to49Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn40to49Percent.UseCompatibleTextRendering = True
        Me.btn40to49Percent.UseVisualStyleBackColor = True
        '
        'btn50to59Percent
        '
        Me.btn50to59Percent.AutoSize = True
        Me.btn50to59Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn50to59Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn50to59Percent.BackgroundImage = CType(resources.GetObject("btn50to59Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn50to59Percent.Color = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btn50to59Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn50to59Percent.FlatAppearance.BorderSize = 0
        Me.btn50to59Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn50to59Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn50to59Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50to59Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50to59Percent.Image = CType(resources.GetObject("btn50to59Percent.Image"), System.Drawing.Image)
        Me.btn50to59Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50to59Percent.Location = New System.Drawing.Point(551, 6)
        Me.btn50to59Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn50to59Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn50to59Percent.Name = "btn50to59Percent"
        Me.btn50to59Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn50to59Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn50to59Percent.Style = resources.GetString("btn50to59Percent.Style")
        Me.btn50to59Percent.TabIndex = 68
        Me.btn50to59Percent.Text = "50 to 59%"
        Me.btn50to59Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50to59Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50to59Percent.UseCompatibleTextRendering = True
        Me.btn50to59Percent.UseVisualStyleBackColor = True
        '
        'btn60to69Percent
        '
        Me.btn60to69Percent.AutoSize = True
        Me.btn60to69Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn60to69Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn60to69Percent.BackgroundImage = CType(resources.GetObject("btn60to69Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn60to69Percent.Color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btn60to69Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn60to69Percent.FlatAppearance.BorderSize = 0
        Me.btn60to69Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn60to69Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn60to69Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn60to69Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn60to69Percent.Image = CType(resources.GetObject("btn60to69Percent.Image"), System.Drawing.Image)
        Me.btn60to69Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn60to69Percent.Location = New System.Drawing.Point(651, 6)
        Me.btn60to69Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn60to69Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn60to69Percent.Name = "btn60to69Percent"
        Me.btn60to69Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn60to69Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn60to69Percent.Style = resources.GetString("btn60to69Percent.Style")
        Me.btn60to69Percent.TabIndex = 69
        Me.btn60to69Percent.Text = "60 to 69%"
        Me.btn60to69Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn60to69Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn60to69Percent.UseCompatibleTextRendering = True
        Me.btn60to69Percent.UseVisualStyleBackColor = True
        '
        'btn70to79Percent
        '
        Me.btn70to79Percent.AutoSize = True
        Me.btn70to79Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn70to79Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn70to79Percent.BackgroundImage = CType(resources.GetObject("btn70to79Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn70to79Percent.Color = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn70to79Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn70to79Percent.FlatAppearance.BorderSize = 0
        Me.btn70to79Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn70to79Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn70to79Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn70to79Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn70to79Percent.Image = CType(resources.GetObject("btn70to79Percent.Image"), System.Drawing.Image)
        Me.btn70to79Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn70to79Percent.Location = New System.Drawing.Point(751, 6)
        Me.btn70to79Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn70to79Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn70to79Percent.Name = "btn70to79Percent"
        Me.btn70to79Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn70to79Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn70to79Percent.Style = resources.GetString("btn70to79Percent.Style")
        Me.btn70to79Percent.TabIndex = 70
        Me.btn70to79Percent.Text = "70 to 79%"
        Me.btn70to79Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn70to79Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn70to79Percent.UseCompatibleTextRendering = True
        Me.btn70to79Percent.UseVisualStyleBackColor = True
        '
        'btn80to89Percent
        '
        Me.btn80to89Percent.AutoSize = True
        Me.btn80to89Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn80to89Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn80to89Percent.BackgroundImage = CType(resources.GetObject("btn80to89Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn80to89Percent.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn80to89Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn80to89Percent.FlatAppearance.BorderSize = 0
        Me.btn80to89Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn80to89Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn80to89Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn80to89Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn80to89Percent.Image = CType(resources.GetObject("btn80to89Percent.Image"), System.Drawing.Image)
        Me.btn80to89Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn80to89Percent.Location = New System.Drawing.Point(851, 6)
        Me.btn80to89Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn80to89Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn80to89Percent.Name = "btn80to89Percent"
        Me.btn80to89Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn80to89Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn80to89Percent.Style = resources.GetString("btn80to89Percent.Style")
        Me.btn80to89Percent.TabIndex = 71
        Me.btn80to89Percent.Text = "80 to 89%"
        Me.btn80to89Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn80to89Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn80to89Percent.UseCompatibleTextRendering = True
        Me.btn80to89Percent.UseVisualStyleBackColor = True
        '
        'btn90to99Percent
        '
        Me.btn90to99Percent.AutoSize = True
        Me.btn90to99Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn90to99Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn90to99Percent.BackgroundImage = CType(resources.GetObject("btn90to99Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn90to99Percent.Color = System.Drawing.Color.ForestGreen
        Me.btn90to99Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn90to99Percent.FlatAppearance.BorderSize = 0
        Me.btn90to99Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn90to99Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn90to99Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn90to99Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn90to99Percent.Image = CType(resources.GetObject("btn90to99Percent.Image"), System.Drawing.Image)
        Me.btn90to99Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn90to99Percent.Location = New System.Drawing.Point(951, 6)
        Me.btn90to99Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn90to99Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn90to99Percent.Name = "btn90to99Percent"
        Me.btn90to99Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn90to99Percent.Size = New System.Drawing.Size(93, 37)
        Me.btn90to99Percent.Style = resources.GetString("btn90to99Percent.Style")
        Me.btn90to99Percent.TabIndex = 72
        Me.btn90to99Percent.Text = "90 to 99%"
        Me.btn90to99Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn90to99Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn90to99Percent.UseCompatibleTextRendering = True
        Me.btn90to99Percent.UseVisualStyleBackColor = True
        '
        'btn100Percent
        '
        Me.btn100Percent.AutoSize = True
        Me.btn100Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn100Percent.BackColor = System.Drawing.Color.Transparent
        Me.btn100Percent.BackgroundImage = CType(resources.GetObject("btn100Percent.BackgroundImage"), System.Drawing.Image)
        Me.btn100Percent.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn100Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn100Percent.FlatAppearance.BorderSize = 0
        Me.btn100Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn100Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn100Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100Percent.Image = CType(resources.GetObject("btn100Percent.Image"), System.Drawing.Image)
        Me.btn100Percent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn100Percent.Location = New System.Drawing.Point(1051, 6)
        Me.btn100Percent.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn100Percent.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn100Percent.Name = "btn100Percent"
        Me.btn100Percent.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn100Percent.Size = New System.Drawing.Size(67, 37)
        Me.btn100Percent.Style = resources.GetString("btn100Percent.Style")
        Me.btn100Percent.TabIndex = 73
        Me.btn100Percent.Text = "100%"
        Me.btn100Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn100Percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn100Percent.UseCompatibleTextRendering = True
        Me.btn100Percent.UseVisualStyleBackColor = True
        '
        'StylizedPanel7
        '
        Me.StylizedPanel7.Controls.Add(Me.pnlWindSpeed)
        Me.StylizedPanel7.Location = New System.Drawing.Point(167, 636)
        Me.StylizedPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel7.Name = "StylizedPanel7"
        Me.StylizedPanel7.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel7.Size = New System.Drawing.Size(821, 76)
        Me.StylizedPanel7.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel7.TabIndex = 78
        '
        'pnlWindSpeed
        '
        Me.pnlWindSpeed.AutoScroll = True
        Me.pnlWindSpeed.BackColor = System.Drawing.Color.White
        Me.pnlWindSpeed.Controls.Add(Me.btn0MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn1to9MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn10to19MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn20to29MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn30to39MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn40to49MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn50to59MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn60to69MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn70to79MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn80to89MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn90to99MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btn100to110MPH)
        Me.pnlWindSpeed.Controls.Add(Me.btnMoreThan110MPH)
        Me.pnlWindSpeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWindSpeed.Location = New System.Drawing.Point(1, 1)
        Me.pnlWindSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlWindSpeed.Name = "pnlWindSpeed"
        Me.pnlWindSpeed.Padding = New System.Windows.Forms.Padding(7, 0, 13, 0)
        Me.pnlWindSpeed.Size = New System.Drawing.Size(819, 74)
        Me.pnlWindSpeed.TabIndex = 72
        Me.pnlWindSpeed.WrapContents = False
        '
        'btn0MPH
        '
        Me.btn0MPH.AutoSize = True
        Me.btn0MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn0MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn0MPH.BackgroundImage = CType(resources.GetObject("btn0MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn0MPH.Color = System.Drawing.Color.PowderBlue
        Me.btn0MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn0MPH.FlatAppearance.BorderSize = 0
        Me.btn0MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn0MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn0MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn0MPH.Image = CType(resources.GetObject("btn0MPH.Image"), System.Drawing.Image)
        Me.btn0MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn0MPH.Location = New System.Drawing.Point(7, 6)
        Me.btn0MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn0MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn0MPH.Name = "btn0MPH"
        Me.btn0MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn0MPH.Size = New System.Drawing.Size(40, 37)
        Me.btn0MPH.Style = resources.GetString("btn0MPH.Style")
        Me.btn0MPH.TabIndex = 68
        Me.btn0MPH.Text = "0"
        Me.btn0MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn0MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0MPH.UseCompatibleTextRendering = True
        Me.btn0MPH.UseVisualStyleBackColor = True
        '
        'btn1to9MPH
        '
        Me.btn1to9MPH.AutoSize = True
        Me.btn1to9MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1to9MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn1to9MPH.BackgroundImage = CType(resources.GetObject("btn1to9MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn1to9MPH.Color = System.Drawing.Color.LightBlue
        Me.btn1to9MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1to9MPH.FlatAppearance.BorderSize = 0
        Me.btn1to9MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1to9MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1to9MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1to9MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1to9MPH.Image = CType(resources.GetObject("btn1to9MPH.Image"), System.Drawing.Image)
        Me.btn1to9MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1to9MPH.Location = New System.Drawing.Point(54, 6)
        Me.btn1to9MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1to9MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1to9MPH.Name = "btn1to9MPH"
        Me.btn1to9MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1to9MPH.Size = New System.Drawing.Size(66, 37)
        Me.btn1to9MPH.Style = resources.GetString("btn1to9MPH.Style")
        Me.btn1to9MPH.TabIndex = 70
        Me.btn1to9MPH.Text = "1 to 9"
        Me.btn1to9MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1to9MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1to9MPH.UseCompatibleTextRendering = True
        Me.btn1to9MPH.UseVisualStyleBackColor = True
        '
        'btn10to19MPH
        '
        Me.btn10to19MPH.AutoSize = True
        Me.btn10to19MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10to19MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn10to19MPH.BackgroundImage = CType(resources.GetObject("btn10to19MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn10to19MPH.Color = System.Drawing.Color.CornflowerBlue
        Me.btn10to19MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10to19MPH.FlatAppearance.BorderSize = 0
        Me.btn10to19MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10to19MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10to19MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10to19MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10to19MPH.Image = CType(resources.GetObject("btn10to19MPH.Image"), System.Drawing.Image)
        Me.btn10to19MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10to19MPH.Location = New System.Drawing.Point(127, 6)
        Me.btn10to19MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10to19MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10to19MPH.Name = "btn10to19MPH"
        Me.btn10to19MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10to19MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn10to19MPH.Style = resources.GetString("btn10to19MPH.Style")
        Me.btn10to19MPH.TabIndex = 71
        Me.btn10to19MPH.Text = "10 to 19"
        Me.btn10to19MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10to19MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10to19MPH.UseCompatibleTextRendering = True
        Me.btn10to19MPH.UseVisualStyleBackColor = True
        '
        'btn20to29MPH
        '
        Me.btn20to29MPH.AutoSize = True
        Me.btn20to29MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn20to29MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn20to29MPH.BackgroundImage = CType(resources.GetObject("btn20to29MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn20to29MPH.Color = System.Drawing.Color.RoyalBlue
        Me.btn20to29MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn20to29MPH.FlatAppearance.BorderSize = 0
        Me.btn20to29MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn20to29MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn20to29MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20to29MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn20to29MPH.Image = CType(resources.GetObject("btn20to29MPH.Image"), System.Drawing.Image)
        Me.btn20to29MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20to29MPH.Location = New System.Drawing.Point(215, 6)
        Me.btn20to29MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn20to29MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn20to29MPH.Name = "btn20to29MPH"
        Me.btn20to29MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn20to29MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn20to29MPH.Style = resources.GetString("btn20to29MPH.Style")
        Me.btn20to29MPH.TabIndex = 72
        Me.btn20to29MPH.Text = "20 to 29"
        Me.btn20to29MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn20to29MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20to29MPH.UseCompatibleTextRendering = True
        Me.btn20to29MPH.UseVisualStyleBackColor = True
        '
        'btn30to39MPH
        '
        Me.btn30to39MPH.AutoSize = True
        Me.btn30to39MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn30to39MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn30to39MPH.BackgroundImage = CType(resources.GetObject("btn30to39MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn30to39MPH.Color = System.Drawing.Color.SlateBlue
        Me.btn30to39MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn30to39MPH.FlatAppearance.BorderSize = 0
        Me.btn30to39MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn30to39MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn30to39MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn30to39MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn30to39MPH.Image = CType(resources.GetObject("btn30to39MPH.Image"), System.Drawing.Image)
        Me.btn30to39MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30to39MPH.Location = New System.Drawing.Point(303, 6)
        Me.btn30to39MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn30to39MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn30to39MPH.Name = "btn30to39MPH"
        Me.btn30to39MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn30to39MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn30to39MPH.Style = resources.GetString("btn30to39MPH.Style")
        Me.btn30to39MPH.TabIndex = 73
        Me.btn30to39MPH.Text = "30 to 39"
        Me.btn30to39MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn30to39MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn30to39MPH.UseCompatibleTextRendering = True
        Me.btn30to39MPH.UseVisualStyleBackColor = True
        '
        'btn40to49MPH
        '
        Me.btn40to49MPH.AutoSize = True
        Me.btn40to49MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn40to49MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn40to49MPH.BackgroundImage = CType(resources.GetObject("btn40to49MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn40to49MPH.Color = System.Drawing.Color.DarkViolet
        Me.btn40to49MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn40to49MPH.FlatAppearance.BorderSize = 0
        Me.btn40to49MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn40to49MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn40to49MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn40to49MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn40to49MPH.Image = CType(resources.GetObject("btn40to49MPH.Image"), System.Drawing.Image)
        Me.btn40to49MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40to49MPH.Location = New System.Drawing.Point(391, 6)
        Me.btn40to49MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn40to49MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn40to49MPH.Name = "btn40to49MPH"
        Me.btn40to49MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn40to49MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn40to49MPH.Style = resources.GetString("btn40to49MPH.Style")
        Me.btn40to49MPH.TabIndex = 74
        Me.btn40to49MPH.Text = "40 to 49"
        Me.btn40to49MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn40to49MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn40to49MPH.UseCompatibleTextRendering = True
        Me.btn40to49MPH.UseVisualStyleBackColor = True
        '
        'btn50to59MPH
        '
        Me.btn50to59MPH.AutoSize = True
        Me.btn50to59MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn50to59MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn50to59MPH.BackgroundImage = CType(resources.GetObject("btn50to59MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn50to59MPH.Color = System.Drawing.Color.MediumOrchid
        Me.btn50to59MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn50to59MPH.FlatAppearance.BorderSize = 0
        Me.btn50to59MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn50to59MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn50to59MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50to59MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50to59MPH.Image = CType(resources.GetObject("btn50to59MPH.Image"), System.Drawing.Image)
        Me.btn50to59MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50to59MPH.Location = New System.Drawing.Point(479, 6)
        Me.btn50to59MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn50to59MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn50to59MPH.Name = "btn50to59MPH"
        Me.btn50to59MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn50to59MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn50to59MPH.Style = resources.GetString("btn50to59MPH.Style")
        Me.btn50to59MPH.TabIndex = 75
        Me.btn50to59MPH.Text = "50 to 59"
        Me.btn50to59MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50to59MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50to59MPH.UseCompatibleTextRendering = True
        Me.btn50to59MPH.UseVisualStyleBackColor = True
        '
        'btn60to69MPH
        '
        Me.btn60to69MPH.AutoSize = True
        Me.btn60to69MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn60to69MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn60to69MPH.BackgroundImage = CType(resources.GetObject("btn60to69MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn60to69MPH.Color = System.Drawing.Color.IndianRed
        Me.btn60to69MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn60to69MPH.FlatAppearance.BorderSize = 0
        Me.btn60to69MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn60to69MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn60to69MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn60to69MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn60to69MPH.Image = CType(resources.GetObject("btn60to69MPH.Image"), System.Drawing.Image)
        Me.btn60to69MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn60to69MPH.Location = New System.Drawing.Point(567, 6)
        Me.btn60to69MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn60to69MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn60to69MPH.Name = "btn60to69MPH"
        Me.btn60to69MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn60to69MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn60to69MPH.Style = resources.GetString("btn60to69MPH.Style")
        Me.btn60to69MPH.TabIndex = 76
        Me.btn60to69MPH.Text = "60 to 69"
        Me.btn60to69MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn60to69MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn60to69MPH.UseCompatibleTextRendering = True
        Me.btn60to69MPH.UseVisualStyleBackColor = True
        '
        'btn70to79MPH
        '
        Me.btn70to79MPH.AutoSize = True
        Me.btn70to79MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn70to79MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn70to79MPH.BackgroundImage = CType(resources.GetObject("btn70to79MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn70to79MPH.Color = System.Drawing.Color.Firebrick
        Me.btn70to79MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn70to79MPH.FlatAppearance.BorderSize = 0
        Me.btn70to79MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn70to79MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn70to79MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn70to79MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn70to79MPH.Image = CType(resources.GetObject("btn70to79MPH.Image"), System.Drawing.Image)
        Me.btn70to79MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn70to79MPH.Location = New System.Drawing.Point(655, 6)
        Me.btn70to79MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn70to79MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn70to79MPH.Name = "btn70to79MPH"
        Me.btn70to79MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn70to79MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn70to79MPH.Style = resources.GetString("btn70to79MPH.Style")
        Me.btn70to79MPH.TabIndex = 77
        Me.btn70to79MPH.Text = "70 to 79"
        Me.btn70to79MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn70to79MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn70to79MPH.UseCompatibleTextRendering = True
        Me.btn70to79MPH.UseVisualStyleBackColor = True
        '
        'btn80to89MPH
        '
        Me.btn80to89MPH.AutoSize = True
        Me.btn80to89MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn80to89MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn80to89MPH.BackgroundImage = CType(resources.GetObject("btn80to89MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn80to89MPH.Color = System.Drawing.Color.Brown
        Me.btn80to89MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn80to89MPH.FlatAppearance.BorderSize = 0
        Me.btn80to89MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn80to89MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn80to89MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn80to89MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn80to89MPH.Image = CType(resources.GetObject("btn80to89MPH.Image"), System.Drawing.Image)
        Me.btn80to89MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn80to89MPH.Location = New System.Drawing.Point(743, 6)
        Me.btn80to89MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn80to89MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn80to89MPH.Name = "btn80to89MPH"
        Me.btn80to89MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn80to89MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn80to89MPH.Style = resources.GetString("btn80to89MPH.Style")
        Me.btn80to89MPH.TabIndex = 78
        Me.btn80to89MPH.Text = "80 to 89"
        Me.btn80to89MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn80to89MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn80to89MPH.UseCompatibleTextRendering = True
        Me.btn80to89MPH.UseVisualStyleBackColor = True
        '
        'btn90to99MPH
        '
        Me.btn90to99MPH.AutoSize = True
        Me.btn90to99MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn90to99MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn90to99MPH.BackgroundImage = CType(resources.GetObject("btn90to99MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn90to99MPH.Color = System.Drawing.Color.DarkRed
        Me.btn90to99MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn90to99MPH.FlatAppearance.BorderSize = 0
        Me.btn90to99MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn90to99MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn90to99MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn90to99MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn90to99MPH.Image = CType(resources.GetObject("btn90to99MPH.Image"), System.Drawing.Image)
        Me.btn90to99MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn90to99MPH.Location = New System.Drawing.Point(831, 6)
        Me.btn90to99MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn90to99MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn90to99MPH.Name = "btn90to99MPH"
        Me.btn90to99MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn90to99MPH.Size = New System.Drawing.Size(81, 37)
        Me.btn90to99MPH.Style = resources.GetString("btn90to99MPH.Style")
        Me.btn90to99MPH.TabIndex = 79
        Me.btn90to99MPH.Text = "90 to 99"
        Me.btn90to99MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn90to99MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn90to99MPH.UseCompatibleTextRendering = True
        Me.btn90to99MPH.UseVisualStyleBackColor = True
        '
        'btn100to110MPH
        '
        Me.btn100to110MPH.AutoSize = True
        Me.btn100to110MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn100to110MPH.BackColor = System.Drawing.Color.Transparent
        Me.btn100to110MPH.BackgroundImage = CType(resources.GetObject("btn100to110MPH.BackgroundImage"), System.Drawing.Image)
        Me.btn100to110MPH.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn100to110MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn100to110MPH.FlatAppearance.BorderSize = 0
        Me.btn100to110MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn100to110MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn100to110MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100to110MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100to110MPH.Image = CType(resources.GetObject("btn100to110MPH.Image"), System.Drawing.Image)
        Me.btn100to110MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn100to110MPH.Location = New System.Drawing.Point(919, 6)
        Me.btn100to110MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn100to110MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn100to110MPH.Name = "btn100to110MPH"
        Me.btn100to110MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn100to110MPH.Size = New System.Drawing.Size(96, 37)
        Me.btn100to110MPH.Style = resources.GetString("btn100to110MPH.Style")
        Me.btn100to110MPH.TabIndex = 80
        Me.btn100to110MPH.Text = "100 to 110"
        Me.btn100to110MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn100to110MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn100to110MPH.UseCompatibleTextRendering = True
        Me.btn100to110MPH.UseVisualStyleBackColor = True
        '
        'btnMoreThan110MPH
        '
        Me.btnMoreThan110MPH.AutoSize = True
        Me.btnMoreThan110MPH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoreThan110MPH.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreThan110MPH.BackgroundImage = CType(resources.GetObject("btnMoreThan110MPH.BackgroundImage"), System.Drawing.Image)
        Me.btnMoreThan110MPH.Color = System.Drawing.Color.Red
        Me.btnMoreThan110MPH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMoreThan110MPH.FlatAppearance.BorderSize = 0
        Me.btnMoreThan110MPH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMoreThan110MPH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMoreThan110MPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreThan110MPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMoreThan110MPH.Image = CType(resources.GetObject("btnMoreThan110MPH.Image"), System.Drawing.Image)
        Me.btnMoreThan110MPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMoreThan110MPH.Location = New System.Drawing.Point(1022, 6)
        Me.btnMoreThan110MPH.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMoreThan110MPH.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMoreThan110MPH.Name = "btnMoreThan110MPH"
        Me.btnMoreThan110MPH.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMoreThan110MPH.Size = New System.Drawing.Size(119, 37)
        Me.btnMoreThan110MPH.Style = resources.GetString("btnMoreThan110MPH.Style")
        Me.btnMoreThan110MPH.TabIndex = 81
        Me.btnMoreThan110MPH.Text = "More than 110"
        Me.btnMoreThan110MPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMoreThan110MPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMoreThan110MPH.UseCompatibleTextRendering = True
        Me.btnMoreThan110MPH.UseVisualStyleBackColor = True
        '
        'btnBattery
        '
        Me.btnBattery.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnBattery.BackColor = System.Drawing.Color.Transparent
        Me.btnBattery.BackgroundImage = CType(resources.GetObject("btnBattery.BackgroundImage"), System.Drawing.Image)
        Me.btnBattery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBattery.FlatAppearance.BorderSize = 0
        Me.btnBattery.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnBattery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBattery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBattery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBattery.Image = CType(resources.GetObject("btnBattery.Image"), System.Drawing.Image)
        Me.btnBattery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBattery.Location = New System.Drawing.Point(4, 218)
        Me.btnBattery.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBattery.Name = "btnBattery"
        Me.btnBattery.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnBattery.Size = New System.Drawing.Size(155, 28)
        Me.btnBattery.Style = resources.GetString("btnBattery.Style")
        Me.btnBattery.TabIndex = 82
        Me.btnBattery.Text = "Battery"
        Me.btnBattery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBattery.UseCompatibleTextRendering = True
        Me.btnBattery.UseVisualStyleBackColor = False
        '
        'StylizedPanel6
        '
        Me.StylizedPanel6.Controls.Add(Me.pnlHumidity)
        Me.StylizedPanel6.Location = New System.Drawing.Point(167, 553)
        Me.StylizedPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel6.Name = "StylizedPanel6"
        Me.StylizedPanel6.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel6.Size = New System.Drawing.Size(820, 76)
        Me.StylizedPanel6.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel6.TabIndex = 77
        '
        'pnlHumidity
        '
        Me.pnlHumidity.AutoScroll = True
        Me.pnlHumidity.BackColor = System.Drawing.Color.White
        Me.pnlHumidity.Controls.Add(Me.btn0PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn1to9PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn10to19PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn20to29PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn30to39PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn40to49PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn50to59PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn60to69PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn70to79PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn80to89PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn90to99PercentHumidity)
        Me.pnlHumidity.Controls.Add(Me.btn100PercentHumidity)
        Me.pnlHumidity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHumidity.Location = New System.Drawing.Point(1, 1)
        Me.pnlHumidity.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHumidity.Name = "pnlHumidity"
        Me.pnlHumidity.Padding = New System.Windows.Forms.Padding(7, 0, 13, 0)
        Me.pnlHumidity.Size = New System.Drawing.Size(818, 74)
        Me.pnlHumidity.TabIndex = 71
        Me.pnlHumidity.WrapContents = False
        '
        'btn0PercentHumidity
        '
        Me.btn0PercentHumidity.AutoSize = True
        Me.btn0PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn0PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn0PercentHumidity.BackgroundImage = CType(resources.GetObject("btn0PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn0PercentHumidity.Color = System.Drawing.Color.GhostWhite
        Me.btn0PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn0PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn0PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn0PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn0PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn0PercentHumidity.Image = CType(resources.GetObject("btn0PercentHumidity.Image"), System.Drawing.Image)
        Me.btn0PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn0PercentHumidity.Location = New System.Drawing.Point(7, 6)
        Me.btn0PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn0PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn0PercentHumidity.Name = "btn0PercentHumidity"
        Me.btn0PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn0PercentHumidity.Size = New System.Drawing.Size(52, 37)
        Me.btn0PercentHumidity.Style = resources.GetString("btn0PercentHumidity.Style")
        Me.btn0PercentHumidity.TabIndex = 74
        Me.btn0PercentHumidity.Text = "0%"
        Me.btn0PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn0PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0PercentHumidity.UseCompatibleTextRendering = True
        Me.btn0PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn1to9PercentHumidity
        '
        Me.btn1to9PercentHumidity.AutoSize = True
        Me.btn1to9PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1to9PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn1to9PercentHumidity.BackgroundImage = CType(resources.GetObject("btn1to9PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn1to9PercentHumidity.Color = System.Drawing.Color.Lavender
        Me.btn1to9PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1to9PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn1to9PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1to9PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1to9PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1to9PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1to9PercentHumidity.Image = CType(resources.GetObject("btn1to9PercentHumidity.Image"), System.Drawing.Image)
        Me.btn1to9PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1to9PercentHumidity.Location = New System.Drawing.Point(66, 6)
        Me.btn1to9PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1to9PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1to9PercentHumidity.Name = "btn1to9PercentHumidity"
        Me.btn1to9PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1to9PercentHumidity.Size = New System.Drawing.Size(78, 37)
        Me.btn1to9PercentHumidity.Style = resources.GetString("btn1to9PercentHumidity.Style")
        Me.btn1to9PercentHumidity.TabIndex = 75
        Me.btn1to9PercentHumidity.Text = "1 to 9%"
        Me.btn1to9PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1to9PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1to9PercentHumidity.UseCompatibleTextRendering = True
        Me.btn1to9PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn10to19PercentHumidity
        '
        Me.btn10to19PercentHumidity.AutoSize = True
        Me.btn10to19PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10to19PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn10to19PercentHumidity.BackgroundImage = CType(resources.GetObject("btn10to19PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn10to19PercentHumidity.Color = System.Drawing.Color.LightCyan
        Me.btn10to19PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10to19PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn10to19PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10to19PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10to19PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10to19PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10to19PercentHumidity.Image = CType(resources.GetObject("btn10to19PercentHumidity.Image"), System.Drawing.Image)
        Me.btn10to19PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10to19PercentHumidity.Location = New System.Drawing.Point(151, 6)
        Me.btn10to19PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10to19PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10to19PercentHumidity.Name = "btn10to19PercentHumidity"
        Me.btn10to19PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10to19PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn10to19PercentHumidity.Style = resources.GetString("btn10to19PercentHumidity.Style")
        Me.btn10to19PercentHumidity.TabIndex = 76
        Me.btn10to19PercentHumidity.Text = "10 to 19%"
        Me.btn10to19PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10to19PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10to19PercentHumidity.UseCompatibleTextRendering = True
        Me.btn10to19PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn20to29PercentHumidity
        '
        Me.btn20to29PercentHumidity.AutoSize = True
        Me.btn20to29PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn20to29PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn20to29PercentHumidity.BackgroundImage = CType(resources.GetObject("btn20to29PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn20to29PercentHumidity.Color = System.Drawing.Color.LightSteelBlue
        Me.btn20to29PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn20to29PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn20to29PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn20to29PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn20to29PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20to29PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn20to29PercentHumidity.Image = CType(resources.GetObject("btn20to29PercentHumidity.Image"), System.Drawing.Image)
        Me.btn20to29PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20to29PercentHumidity.Location = New System.Drawing.Point(251, 6)
        Me.btn20to29PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn20to29PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn20to29PercentHumidity.Name = "btn20to29PercentHumidity"
        Me.btn20to29PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn20to29PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn20to29PercentHumidity.Style = resources.GetString("btn20to29PercentHumidity.Style")
        Me.btn20to29PercentHumidity.TabIndex = 77
        Me.btn20to29PercentHumidity.Text = "20 to 29%"
        Me.btn20to29PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn20to29PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20to29PercentHumidity.UseCompatibleTextRendering = True
        Me.btn20to29PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn30to39PercentHumidity
        '
        Me.btn30to39PercentHumidity.AutoSize = True
        Me.btn30to39PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn30to39PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn30to39PercentHumidity.BackgroundImage = CType(resources.GetObject("btn30to39PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn30to39PercentHumidity.Color = System.Drawing.Color.CornflowerBlue
        Me.btn30to39PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn30to39PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn30to39PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn30to39PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn30to39PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn30to39PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn30to39PercentHumidity.Image = CType(resources.GetObject("btn30to39PercentHumidity.Image"), System.Drawing.Image)
        Me.btn30to39PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30to39PercentHumidity.Location = New System.Drawing.Point(351, 6)
        Me.btn30to39PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn30to39PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn30to39PercentHumidity.Name = "btn30to39PercentHumidity"
        Me.btn30to39PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn30to39PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn30to39PercentHumidity.Style = resources.GetString("btn30to39PercentHumidity.Style")
        Me.btn30to39PercentHumidity.TabIndex = 78
        Me.btn30to39PercentHumidity.Text = "30 to 39%"
        Me.btn30to39PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn30to39PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn30to39PercentHumidity.UseCompatibleTextRendering = True
        Me.btn30to39PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn40to49PercentHumidity
        '
        Me.btn40to49PercentHumidity.AutoSize = True
        Me.btn40to49PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn40to49PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn40to49PercentHumidity.BackgroundImage = CType(resources.GetObject("btn40to49PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn40to49PercentHumidity.Color = System.Drawing.Color.RoyalBlue
        Me.btn40to49PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn40to49PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn40to49PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn40to49PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn40to49PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn40to49PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn40to49PercentHumidity.Image = CType(resources.GetObject("btn40to49PercentHumidity.Image"), System.Drawing.Image)
        Me.btn40to49PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40to49PercentHumidity.Location = New System.Drawing.Point(451, 6)
        Me.btn40to49PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn40to49PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn40to49PercentHumidity.Name = "btn40to49PercentHumidity"
        Me.btn40to49PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn40to49PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn40to49PercentHumidity.Style = resources.GetString("btn40to49PercentHumidity.Style")
        Me.btn40to49PercentHumidity.TabIndex = 79
        Me.btn40to49PercentHumidity.Text = "40 to 49%"
        Me.btn40to49PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn40to49PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn40to49PercentHumidity.UseCompatibleTextRendering = True
        Me.btn40to49PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn50to59PercentHumidity
        '
        Me.btn50to59PercentHumidity.AutoSize = True
        Me.btn50to59PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn50to59PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn50to59PercentHumidity.BackgroundImage = CType(resources.GetObject("btn50to59PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn50to59PercentHumidity.Color = System.Drawing.Color.Blue
        Me.btn50to59PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn50to59PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn50to59PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn50to59PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn50to59PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50to59PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50to59PercentHumidity.Image = CType(resources.GetObject("btn50to59PercentHumidity.Image"), System.Drawing.Image)
        Me.btn50to59PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50to59PercentHumidity.Location = New System.Drawing.Point(551, 6)
        Me.btn50to59PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn50to59PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn50to59PercentHumidity.Name = "btn50to59PercentHumidity"
        Me.btn50to59PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn50to59PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn50to59PercentHumidity.Style = resources.GetString("btn50to59PercentHumidity.Style")
        Me.btn50to59PercentHumidity.TabIndex = 80
        Me.btn50to59PercentHumidity.Text = "50 to 59%"
        Me.btn50to59PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50to59PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50to59PercentHumidity.UseCompatibleTextRendering = True
        Me.btn50to59PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn60to69PercentHumidity
        '
        Me.btn60to69PercentHumidity.AutoSize = True
        Me.btn60to69PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn60to69PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn60to69PercentHumidity.BackgroundImage = CType(resources.GetObject("btn60to69PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn60to69PercentHumidity.Color = System.Drawing.Color.MediumBlue
        Me.btn60to69PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn60to69PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn60to69PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn60to69PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn60to69PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn60to69PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn60to69PercentHumidity.Image = CType(resources.GetObject("btn60to69PercentHumidity.Image"), System.Drawing.Image)
        Me.btn60to69PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn60to69PercentHumidity.Location = New System.Drawing.Point(651, 6)
        Me.btn60to69PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn60to69PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn60to69PercentHumidity.Name = "btn60to69PercentHumidity"
        Me.btn60to69PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn60to69PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn60to69PercentHumidity.Style = resources.GetString("btn60to69PercentHumidity.Style")
        Me.btn60to69PercentHumidity.TabIndex = 81
        Me.btn60to69PercentHumidity.Text = "60 to 69%"
        Me.btn60to69PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn60to69PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn60to69PercentHumidity.UseCompatibleTextRendering = True
        Me.btn60to69PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn70to79PercentHumidity
        '
        Me.btn70to79PercentHumidity.AutoSize = True
        Me.btn70to79PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn70to79PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn70to79PercentHumidity.BackgroundImage = CType(resources.GetObject("btn70to79PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn70to79PercentHumidity.Color = System.Drawing.Color.DarkBlue
        Me.btn70to79PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn70to79PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn70to79PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn70to79PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn70to79PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn70to79PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn70to79PercentHumidity.Image = CType(resources.GetObject("btn70to79PercentHumidity.Image"), System.Drawing.Image)
        Me.btn70to79PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn70to79PercentHumidity.Location = New System.Drawing.Point(751, 6)
        Me.btn70to79PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn70to79PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn70to79PercentHumidity.Name = "btn70to79PercentHumidity"
        Me.btn70to79PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn70to79PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn70to79PercentHumidity.Style = resources.GetString("btn70to79PercentHumidity.Style")
        Me.btn70to79PercentHumidity.TabIndex = 82
        Me.btn70to79PercentHumidity.Text = "70 to 79%"
        Me.btn70to79PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn70to79PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn70to79PercentHumidity.UseCompatibleTextRendering = True
        Me.btn70to79PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn80to89PercentHumidity
        '
        Me.btn80to89PercentHumidity.AutoSize = True
        Me.btn80to89PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn80to89PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn80to89PercentHumidity.BackgroundImage = CType(resources.GetObject("btn80to89PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn80to89PercentHumidity.Color = System.Drawing.Color.Navy
        Me.btn80to89PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn80to89PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn80to89PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn80to89PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn80to89PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn80to89PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn80to89PercentHumidity.Image = CType(resources.GetObject("btn80to89PercentHumidity.Image"), System.Drawing.Image)
        Me.btn80to89PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn80to89PercentHumidity.Location = New System.Drawing.Point(851, 6)
        Me.btn80to89PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn80to89PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn80to89PercentHumidity.Name = "btn80to89PercentHumidity"
        Me.btn80to89PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn80to89PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn80to89PercentHumidity.Style = resources.GetString("btn80to89PercentHumidity.Style")
        Me.btn80to89PercentHumidity.TabIndex = 83
        Me.btn80to89PercentHumidity.Text = "80 to 89%"
        Me.btn80to89PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn80to89PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn80to89PercentHumidity.UseCompatibleTextRendering = True
        Me.btn80to89PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn90to99PercentHumidity
        '
        Me.btn90to99PercentHumidity.AutoSize = True
        Me.btn90to99PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn90to99PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn90to99PercentHumidity.BackgroundImage = CType(resources.GetObject("btn90to99PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn90to99PercentHumidity.Color = System.Drawing.Color.MidnightBlue
        Me.btn90to99PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn90to99PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn90to99PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn90to99PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn90to99PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn90to99PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn90to99PercentHumidity.Image = CType(resources.GetObject("btn90to99PercentHumidity.Image"), System.Drawing.Image)
        Me.btn90to99PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn90to99PercentHumidity.Location = New System.Drawing.Point(951, 6)
        Me.btn90to99PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn90to99PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn90to99PercentHumidity.Name = "btn90to99PercentHumidity"
        Me.btn90to99PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn90to99PercentHumidity.Size = New System.Drawing.Size(93, 37)
        Me.btn90to99PercentHumidity.Style = resources.GetString("btn90to99PercentHumidity.Style")
        Me.btn90to99PercentHumidity.TabIndex = 84
        Me.btn90to99PercentHumidity.Text = "90 to 99%"
        Me.btn90to99PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn90to99PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn90to99PercentHumidity.UseCompatibleTextRendering = True
        Me.btn90to99PercentHumidity.UseVisualStyleBackColor = True
        '
        'btn100PercentHumidity
        '
        Me.btn100PercentHumidity.AutoSize = True
        Me.btn100PercentHumidity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn100PercentHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btn100PercentHumidity.BackgroundImage = CType(resources.GetObject("btn100PercentHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btn100PercentHumidity.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100PercentHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn100PercentHumidity.FlatAppearance.BorderSize = 0
        Me.btn100PercentHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn100PercentHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn100PercentHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100PercentHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100PercentHumidity.Image = CType(resources.GetObject("btn100PercentHumidity.Image"), System.Drawing.Image)
        Me.btn100PercentHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn100PercentHumidity.Location = New System.Drawing.Point(1051, 6)
        Me.btn100PercentHumidity.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn100PercentHumidity.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn100PercentHumidity.Name = "btn100PercentHumidity"
        Me.btn100PercentHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn100PercentHumidity.Size = New System.Drawing.Size(67, 37)
        Me.btn100PercentHumidity.Style = resources.GetString("btn100PercentHumidity.Style")
        Me.btn100PercentHumidity.TabIndex = 85
        Me.btn100PercentHumidity.Text = "100%"
        Me.btn100PercentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn100PercentHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn100PercentHumidity.UseCompatibleTextRendering = True
        Me.btn100PercentHumidity.UseVisualStyleBackColor = True
        '
        'StylizedPanel3
        '
        Me.StylizedPanel3.Controls.Add(Me.pnlTemperature)
        Me.StylizedPanel3.Location = New System.Drawing.Point(167, 469)
        Me.StylizedPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel3.Name = "StylizedPanel3"
        Me.StylizedPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel3.Size = New System.Drawing.Size(821, 76)
        Me.StylizedPanel3.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel3.TabIndex = 17
        '
        'pnlTemperature
        '
        Me.pnlTemperature.AutoScroll = True
        Me.pnlTemperature.BackColor = System.Drawing.Color.White
        Me.pnlTemperature.Controls.Add(Me.btnLessthan50)
        Me.pnlTemperature.Controls.Add(Me.btn50to40)
        Me.pnlTemperature.Controls.Add(Me.btn39to30)
        Me.pnlTemperature.Controls.Add(Me.btn29to20)
        Me.pnlTemperature.Controls.Add(Me.btn19to10)
        Me.pnlTemperature.Controls.Add(Me.btn9to1)
        Me.pnlTemperature.Controls.Add(Me.btn0)
        Me.pnlTemperature.Controls.Add(Me.btn1to9)
        Me.pnlTemperature.Controls.Add(Me.btn10to19)
        Me.pnlTemperature.Controls.Add(Me.btn20to29)
        Me.pnlTemperature.Controls.Add(Me.btn30to39)
        Me.pnlTemperature.Controls.Add(Me.btn40to49)
        Me.pnlTemperature.Controls.Add(Me.btn50to59)
        Me.pnlTemperature.Controls.Add(Me.btn60to69)
        Me.pnlTemperature.Controls.Add(Me.btn70to79)
        Me.pnlTemperature.Controls.Add(Me.btn80to89)
        Me.pnlTemperature.Controls.Add(Me.btn90to99)
        Me.pnlTemperature.Controls.Add(Me.btn100to110)
        Me.pnlTemperature.Controls.Add(Me.btnMorethan110)
        Me.pnlTemperature.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTemperature.Location = New System.Drawing.Point(1, 1)
        Me.pnlTemperature.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTemperature.Name = "pnlTemperature"
        Me.pnlTemperature.Padding = New System.Windows.Forms.Padding(7, 0, 13, 0)
        Me.pnlTemperature.Size = New System.Drawing.Size(819, 74)
        Me.pnlTemperature.TabIndex = 6
        Me.pnlTemperature.WrapContents = False
        '
        'btnLessthan50
        '
        Me.btnLessthan50.AutoSize = True
        Me.btnLessthan50.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLessthan50.BackColor = System.Drawing.Color.Transparent
        Me.btnLessthan50.BackgroundImage = CType(resources.GetObject("btnLessthan50.BackgroundImage"), System.Drawing.Image)
        Me.btnLessthan50.Color = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLessthan50.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLessthan50.FlatAppearance.BorderSize = 0
        Me.btnLessthan50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLessthan50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLessthan50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLessthan50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLessthan50.Image = CType(resources.GetObject("btnLessthan50.Image"), System.Drawing.Image)
        Me.btnLessthan50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLessthan50.Location = New System.Drawing.Point(7, 6)
        Me.btnLessthan50.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnLessthan50.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnLessthan50.Name = "btnLessthan50"
        Me.btnLessthan50.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnLessthan50.Size = New System.Drawing.Size(114, 37)
        Me.btnLessthan50.Style = resources.GetString("btnLessthan50.Style")
        Me.btnLessthan50.TabIndex = 63
        Me.btnLessthan50.Text = "Less than -50"
        Me.btnLessthan50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLessthan50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLessthan50.UseCompatibleTextRendering = True
        Me.btnLessthan50.UseVisualStyleBackColor = True
        '
        'btn50to40
        '
        Me.btn50to40.AutoSize = True
        Me.btn50to40.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn50to40.BackColor = System.Drawing.Color.Transparent
        Me.btn50to40.BackgroundImage = CType(resources.GetObject("btn50to40.BackgroundImage"), System.Drawing.Image)
        Me.btn50to40.Color = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn50to40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn50to40.FlatAppearance.BorderSize = 0
        Me.btn50to40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn50to40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn50to40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50to40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50to40.Image = CType(resources.GetObject("btn50to40.Image"), System.Drawing.Image)
        Me.btn50to40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50to40.Location = New System.Drawing.Point(128, 6)
        Me.btn50to40.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn50to40.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn50to40.Name = "btn50to40"
        Me.btn50to40.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn50to40.Size = New System.Drawing.Size(90, 37)
        Me.btn50to40.Style = resources.GetString("btn50to40.Style")
        Me.btn50to40.TabIndex = 82
        Me.btn50to40.Text = "-50 to -40"
        Me.btn50to40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50to40.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50to40.UseCompatibleTextRendering = True
        Me.btn50to40.UseVisualStyleBackColor = True
        '
        'btn39to30
        '
        Me.btn39to30.AutoSize = True
        Me.btn39to30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn39to30.BackColor = System.Drawing.Color.Transparent
        Me.btn39to30.BackgroundImage = CType(resources.GetObject("btn39to30.BackgroundImage"), System.Drawing.Image)
        Me.btn39to30.Color = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn39to30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn39to30.FlatAppearance.BorderSize = 0
        Me.btn39to30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn39to30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn39to30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn39to30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn39to30.Image = CType(resources.GetObject("btn39to30.Image"), System.Drawing.Image)
        Me.btn39to30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn39to30.Location = New System.Drawing.Point(225, 6)
        Me.btn39to30.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn39to30.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn39to30.Name = "btn39to30"
        Me.btn39to30.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn39to30.Size = New System.Drawing.Size(90, 37)
        Me.btn39to30.Style = resources.GetString("btn39to30.Style")
        Me.btn39to30.TabIndex = 64
        Me.btn39to30.Text = "-39 to -30"
        Me.btn39to30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn39to30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn39to30.UseCompatibleTextRendering = True
        Me.btn39to30.UseVisualStyleBackColor = True
        '
        'btn29to20
        '
        Me.btn29to20.AutoSize = True
        Me.btn29to20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn29to20.BackColor = System.Drawing.Color.Transparent
        Me.btn29to20.BackgroundImage = CType(resources.GetObject("btn29to20.BackgroundImage"), System.Drawing.Image)
        Me.btn29to20.Color = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btn29to20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn29to20.FlatAppearance.BorderSize = 0
        Me.btn29to20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn29to20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn29to20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn29to20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn29to20.Image = CType(resources.GetObject("btn29to20.Image"), System.Drawing.Image)
        Me.btn29to20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn29to20.Location = New System.Drawing.Point(322, 6)
        Me.btn29to20.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn29to20.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn29to20.Name = "btn29to20"
        Me.btn29to20.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn29to20.Size = New System.Drawing.Size(90, 37)
        Me.btn29to20.Style = resources.GetString("btn29to20.Style")
        Me.btn29to20.TabIndex = 65
        Me.btn29to20.Text = "-29 to -20"
        Me.btn29to20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn29to20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn29to20.UseCompatibleTextRendering = True
        Me.btn29to20.UseVisualStyleBackColor = True
        '
        'btn19to10
        '
        Me.btn19to10.AutoSize = True
        Me.btn19to10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn19to10.BackColor = System.Drawing.Color.Transparent
        Me.btn19to10.BackgroundImage = CType(resources.GetObject("btn19to10.BackgroundImage"), System.Drawing.Image)
        Me.btn19to10.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn19to10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn19to10.FlatAppearance.BorderSize = 0
        Me.btn19to10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn19to10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn19to10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn19to10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn19to10.Image = CType(resources.GetObject("btn19to10.Image"), System.Drawing.Image)
        Me.btn19to10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn19to10.Location = New System.Drawing.Point(419, 6)
        Me.btn19to10.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn19to10.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn19to10.Name = "btn19to10"
        Me.btn19to10.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn19to10.Size = New System.Drawing.Size(90, 37)
        Me.btn19to10.Style = resources.GetString("btn19to10.Style")
        Me.btn19to10.TabIndex = 66
        Me.btn19to10.Text = "-19 to -10"
        Me.btn19to10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn19to10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn19to10.UseCompatibleTextRendering = True
        Me.btn19to10.UseVisualStyleBackColor = True
        '
        'btn9to1
        '
        Me.btn9to1.AutoSize = True
        Me.btn9to1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn9to1.BackColor = System.Drawing.Color.Transparent
        Me.btn9to1.BackgroundImage = CType(resources.GetObject("btn9to1.BackgroundImage"), System.Drawing.Image)
        Me.btn9to1.Color = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btn9to1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn9to1.FlatAppearance.BorderSize = 0
        Me.btn9to1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn9to1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn9to1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9to1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn9to1.Image = CType(resources.GetObject("btn9to1.Image"), System.Drawing.Image)
        Me.btn9to1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn9to1.Location = New System.Drawing.Point(516, 6)
        Me.btn9to1.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn9to1.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn9to1.Name = "btn9to1"
        Me.btn9to1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn9to1.Size = New System.Drawing.Size(75, 37)
        Me.btn9to1.Style = resources.GetString("btn9to1.Style")
        Me.btn9to1.TabIndex = 67
        Me.btn9to1.Text = "-9 to -1"
        Me.btn9to1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn9to1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn9to1.UseCompatibleTextRendering = True
        Me.btn9to1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.AutoSize = True
        Me.btn0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn0.BackColor = System.Drawing.Color.Transparent
        Me.btn0.BackgroundImage = CType(resources.GetObject("btn0.BackgroundImage"), System.Drawing.Image)
        Me.btn0.Color = System.Drawing.Color.SkyBlue
        Me.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn0.Image = CType(resources.GetObject("btn0.Image"), System.Drawing.Image)
        Me.btn0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn0.Location = New System.Drawing.Point(598, 6)
        Me.btn0.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn0.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn0.Name = "btn0"
        Me.btn0.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn0.Size = New System.Drawing.Size(40, 37)
        Me.btn0.Style = resources.GetString("btn0.Style")
        Me.btn0.TabIndex = 68
        Me.btn0.Text = "0"
        Me.btn0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0.UseCompatibleTextRendering = True
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn1to9
        '
        Me.btn1to9.AutoSize = True
        Me.btn1to9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1to9.BackColor = System.Drawing.Color.Transparent
        Me.btn1to9.BackgroundImage = CType(resources.GetObject("btn1to9.BackgroundImage"), System.Drawing.Image)
        Me.btn1to9.Color = System.Drawing.Color.PowderBlue
        Me.btn1to9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn1to9.FlatAppearance.BorderSize = 0
        Me.btn1to9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn1to9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn1to9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1to9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1to9.Image = CType(resources.GetObject("btn1to9.Image"), System.Drawing.Image)
        Me.btn1to9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1to9.Location = New System.Drawing.Point(645, 6)
        Me.btn1to9.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn1to9.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn1to9.Name = "btn1to9"
        Me.btn1to9.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn1to9.Size = New System.Drawing.Size(66, 37)
        Me.btn1to9.Style = resources.GetString("btn1to9.Style")
        Me.btn1to9.TabIndex = 70
        Me.btn1to9.Text = "1 to 9"
        Me.btn1to9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn1to9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1to9.UseCompatibleTextRendering = True
        Me.btn1to9.UseVisualStyleBackColor = True
        '
        'btn10to19
        '
        Me.btn10to19.AutoSize = True
        Me.btn10to19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn10to19.BackColor = System.Drawing.Color.Transparent
        Me.btn10to19.BackgroundImage = CType(resources.GetObject("btn10to19.BackgroundImage"), System.Drawing.Image)
        Me.btn10to19.Color = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn10to19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn10to19.FlatAppearance.BorderSize = 0
        Me.btn10to19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn10to19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn10to19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10to19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn10to19.Image = CType(resources.GetObject("btn10to19.Image"), System.Drawing.Image)
        Me.btn10to19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10to19.Location = New System.Drawing.Point(718, 6)
        Me.btn10to19.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn10to19.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn10to19.Name = "btn10to19"
        Me.btn10to19.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn10to19.Size = New System.Drawing.Size(81, 37)
        Me.btn10to19.Style = resources.GetString("btn10to19.Style")
        Me.btn10to19.TabIndex = 71
        Me.btn10to19.Text = "10 to 19"
        Me.btn10to19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10to19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10to19.UseCompatibleTextRendering = True
        Me.btn10to19.UseVisualStyleBackColor = True
        '
        'btn20to29
        '
        Me.btn20to29.AutoSize = True
        Me.btn20to29.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn20to29.BackColor = System.Drawing.Color.Transparent
        Me.btn20to29.BackgroundImage = CType(resources.GetObject("btn20to29.BackgroundImage"), System.Drawing.Image)
        Me.btn20to29.Color = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btn20to29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn20to29.FlatAppearance.BorderSize = 0
        Me.btn20to29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn20to29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn20to29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20to29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn20to29.Image = CType(resources.GetObject("btn20to29.Image"), System.Drawing.Image)
        Me.btn20to29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20to29.Location = New System.Drawing.Point(806, 6)
        Me.btn20to29.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn20to29.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn20to29.Name = "btn20to29"
        Me.btn20to29.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn20to29.Size = New System.Drawing.Size(81, 37)
        Me.btn20to29.Style = resources.GetString("btn20to29.Style")
        Me.btn20to29.TabIndex = 72
        Me.btn20to29.Text = "20 to 29"
        Me.btn20to29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn20to29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20to29.UseCompatibleTextRendering = True
        Me.btn20to29.UseVisualStyleBackColor = True
        '
        'btn30to39
        '
        Me.btn30to39.AutoSize = True
        Me.btn30to39.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn30to39.BackColor = System.Drawing.Color.Transparent
        Me.btn30to39.BackgroundImage = CType(resources.GetObject("btn30to39.BackgroundImage"), System.Drawing.Image)
        Me.btn30to39.Color = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn30to39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn30to39.FlatAppearance.BorderSize = 0
        Me.btn30to39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn30to39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn30to39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn30to39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn30to39.Image = CType(resources.GetObject("btn30to39.Image"), System.Drawing.Image)
        Me.btn30to39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30to39.Location = New System.Drawing.Point(894, 6)
        Me.btn30to39.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn30to39.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn30to39.Name = "btn30to39"
        Me.btn30to39.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn30to39.Size = New System.Drawing.Size(81, 37)
        Me.btn30to39.Style = resources.GetString("btn30to39.Style")
        Me.btn30to39.TabIndex = 73
        Me.btn30to39.Text = "30 to 39"
        Me.btn30to39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn30to39.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn30to39.UseCompatibleTextRendering = True
        Me.btn30to39.UseVisualStyleBackColor = True
        '
        'btn40to49
        '
        Me.btn40to49.AutoSize = True
        Me.btn40to49.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn40to49.BackColor = System.Drawing.Color.Transparent
        Me.btn40to49.BackgroundImage = CType(resources.GetObject("btn40to49.BackgroundImage"), System.Drawing.Image)
        Me.btn40to49.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn40to49.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn40to49.FlatAppearance.BorderSize = 0
        Me.btn40to49.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn40to49.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn40to49.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn40to49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn40to49.Image = CType(resources.GetObject("btn40to49.Image"), System.Drawing.Image)
        Me.btn40to49.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40to49.Location = New System.Drawing.Point(982, 6)
        Me.btn40to49.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn40to49.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn40to49.Name = "btn40to49"
        Me.btn40to49.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn40to49.Size = New System.Drawing.Size(81, 37)
        Me.btn40to49.Style = resources.GetString("btn40to49.Style")
        Me.btn40to49.TabIndex = 74
        Me.btn40to49.Text = "40 to 49"
        Me.btn40to49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn40to49.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn40to49.UseCompatibleTextRendering = True
        Me.btn40to49.UseVisualStyleBackColor = True
        '
        'btn50to59
        '
        Me.btn50to59.AutoSize = True
        Me.btn50to59.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn50to59.BackColor = System.Drawing.Color.Transparent
        Me.btn50to59.BackgroundImage = CType(resources.GetObject("btn50to59.BackgroundImage"), System.Drawing.Image)
        Me.btn50to59.Color = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn50to59.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn50to59.FlatAppearance.BorderSize = 0
        Me.btn50to59.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn50to59.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn50to59.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50to59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50to59.Image = CType(resources.GetObject("btn50to59.Image"), System.Drawing.Image)
        Me.btn50to59.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50to59.Location = New System.Drawing.Point(1070, 6)
        Me.btn50to59.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn50to59.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn50to59.Name = "btn50to59"
        Me.btn50to59.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn50to59.Size = New System.Drawing.Size(81, 37)
        Me.btn50to59.Style = resources.GetString("btn50to59.Style")
        Me.btn50to59.TabIndex = 75
        Me.btn50to59.Text = "50 to 59"
        Me.btn50to59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50to59.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50to59.UseCompatibleTextRendering = True
        Me.btn50to59.UseVisualStyleBackColor = True
        '
        'btn60to69
        '
        Me.btn60to69.AutoSize = True
        Me.btn60to69.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn60to69.BackColor = System.Drawing.Color.Transparent
        Me.btn60to69.BackgroundImage = CType(resources.GetObject("btn60to69.BackgroundImage"), System.Drawing.Image)
        Me.btn60to69.Color = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn60to69.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn60to69.FlatAppearance.BorderSize = 0
        Me.btn60to69.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn60to69.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn60to69.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn60to69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn60to69.Image = CType(resources.GetObject("btn60to69.Image"), System.Drawing.Image)
        Me.btn60to69.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn60to69.Location = New System.Drawing.Point(1158, 6)
        Me.btn60to69.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn60to69.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn60to69.Name = "btn60to69"
        Me.btn60to69.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn60to69.Size = New System.Drawing.Size(81, 37)
        Me.btn60to69.Style = resources.GetString("btn60to69.Style")
        Me.btn60to69.TabIndex = 76
        Me.btn60to69.Text = "60 to 69"
        Me.btn60to69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn60to69.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn60to69.UseCompatibleTextRendering = True
        Me.btn60to69.UseVisualStyleBackColor = True
        '
        'btn70to79
        '
        Me.btn70to79.AutoSize = True
        Me.btn70to79.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn70to79.BackColor = System.Drawing.Color.Transparent
        Me.btn70to79.BackgroundImage = CType(resources.GetObject("btn70to79.BackgroundImage"), System.Drawing.Image)
        Me.btn70to79.Color = System.Drawing.Color.PapayaWhip
        Me.btn70to79.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn70to79.FlatAppearance.BorderSize = 0
        Me.btn70to79.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn70to79.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn70to79.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn70to79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn70to79.Image = CType(resources.GetObject("btn70to79.Image"), System.Drawing.Image)
        Me.btn70to79.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn70to79.Location = New System.Drawing.Point(1246, 6)
        Me.btn70to79.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn70to79.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn70to79.Name = "btn70to79"
        Me.btn70to79.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn70to79.Size = New System.Drawing.Size(81, 37)
        Me.btn70to79.Style = resources.GetString("btn70to79.Style")
        Me.btn70to79.TabIndex = 77
        Me.btn70to79.Text = "70 to 79"
        Me.btn70to79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn70to79.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn70to79.UseCompatibleTextRendering = True
        Me.btn70to79.UseVisualStyleBackColor = True
        '
        'btn80to89
        '
        Me.btn80to89.AutoSize = True
        Me.btn80to89.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn80to89.BackColor = System.Drawing.Color.Transparent
        Me.btn80to89.BackgroundImage = CType(resources.GetObject("btn80to89.BackgroundImage"), System.Drawing.Image)
        Me.btn80to89.Color = System.Drawing.Color.NavajoWhite
        Me.btn80to89.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn80to89.FlatAppearance.BorderSize = 0
        Me.btn80to89.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn80to89.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn80to89.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn80to89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn80to89.Image = CType(resources.GetObject("btn80to89.Image"), System.Drawing.Image)
        Me.btn80to89.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn80to89.Location = New System.Drawing.Point(1334, 6)
        Me.btn80to89.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn80to89.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn80to89.Name = "btn80to89"
        Me.btn80to89.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn80to89.Size = New System.Drawing.Size(81, 37)
        Me.btn80to89.Style = resources.GetString("btn80to89.Style")
        Me.btn80to89.TabIndex = 78
        Me.btn80to89.Text = "80 to 89"
        Me.btn80to89.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn80to89.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn80to89.UseCompatibleTextRendering = True
        Me.btn80to89.UseVisualStyleBackColor = True
        '
        'btn90to99
        '
        Me.btn90to99.AutoSize = True
        Me.btn90to99.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn90to99.BackColor = System.Drawing.Color.Transparent
        Me.btn90to99.BackgroundImage = CType(resources.GetObject("btn90to99.BackgroundImage"), System.Drawing.Image)
        Me.btn90to99.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn90to99.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn90to99.FlatAppearance.BorderSize = 0
        Me.btn90to99.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn90to99.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn90to99.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn90to99.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn90to99.Image = CType(resources.GetObject("btn90to99.Image"), System.Drawing.Image)
        Me.btn90to99.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn90to99.Location = New System.Drawing.Point(1422, 6)
        Me.btn90to99.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn90to99.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn90to99.Name = "btn90to99"
        Me.btn90to99.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn90to99.Size = New System.Drawing.Size(81, 37)
        Me.btn90to99.Style = resources.GetString("btn90to99.Style")
        Me.btn90to99.TabIndex = 79
        Me.btn90to99.Text = "90 to 99"
        Me.btn90to99.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn90to99.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn90to99.UseCompatibleTextRendering = True
        Me.btn90to99.UseVisualStyleBackColor = True
        '
        'btn100to110
        '
        Me.btn100to110.AutoSize = True
        Me.btn100to110.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn100to110.BackColor = System.Drawing.Color.Transparent
        Me.btn100to110.BackgroundImage = CType(resources.GetObject("btn100to110.BackgroundImage"), System.Drawing.Image)
        Me.btn100to110.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn100to110.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn100to110.FlatAppearance.BorderSize = 0
        Me.btn100to110.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn100to110.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn100to110.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100to110.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100to110.Image = CType(resources.GetObject("btn100to110.Image"), System.Drawing.Image)
        Me.btn100to110.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn100to110.Location = New System.Drawing.Point(1510, 6)
        Me.btn100to110.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btn100to110.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btn100to110.Name = "btn100to110"
        Me.btn100to110.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn100to110.Size = New System.Drawing.Size(96, 37)
        Me.btn100to110.Style = resources.GetString("btn100to110.Style")
        Me.btn100to110.TabIndex = 80
        Me.btn100to110.Text = "100 to 110"
        Me.btn100to110.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn100to110.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn100to110.UseCompatibleTextRendering = True
        Me.btn100to110.UseVisualStyleBackColor = True
        '
        'btnMorethan110
        '
        Me.btnMorethan110.AutoSize = True
        Me.btnMorethan110.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMorethan110.BackColor = System.Drawing.Color.Transparent
        Me.btnMorethan110.BackgroundImage = CType(resources.GetObject("btnMorethan110.BackgroundImage"), System.Drawing.Image)
        Me.btnMorethan110.Color = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnMorethan110.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMorethan110.FlatAppearance.BorderSize = 0
        Me.btnMorethan110.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMorethan110.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMorethan110.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMorethan110.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMorethan110.Image = CType(resources.GetObject("btnMorethan110.Image"), System.Drawing.Image)
        Me.btnMorethan110.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMorethan110.Location = New System.Drawing.Point(1613, 6)
        Me.btnMorethan110.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMorethan110.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMorethan110.Name = "btnMorethan110"
        Me.btnMorethan110.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMorethan110.Size = New System.Drawing.Size(119, 37)
        Me.btnMorethan110.Style = resources.GetString("btnMorethan110.Style")
        Me.btnMorethan110.TabIndex = 81
        Me.btnMorethan110.Text = "More than 110"
        Me.btnMorethan110.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMorethan110.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMorethan110.UseCompatibleTextRendering = True
        Me.btnMorethan110.UseVisualStyleBackColor = True
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.Controls.Add(Me.pnlConditions)
        Me.StylizedPanel1.Location = New System.Drawing.Point(167, 385)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel1.Size = New System.Drawing.Size(821, 76)
        Me.StylizedPanel1.Style = "Colors=0,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#c9c9c9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0"
        Me.StylizedPanel1.TabIndex = 74
        '
        'pnlConditions
        '
        Me.pnlConditions.AutoScroll = True
        Me.pnlConditions.BackColor = System.Drawing.Color.White
        Me.pnlConditions.Controls.Add(Me.btnClear)
        Me.pnlConditions.Controls.Add(Me.btnSunny)
        Me.pnlConditions.Controls.Add(Me.btnFair)
        Me.pnlConditions.Controls.Add(Me.btnCloudy)
        Me.pnlConditions.Controls.Add(Me.btnPartlyCloudy)
        Me.pnlConditions.Controls.Add(Me.btnMostlyCloudy)
        Me.pnlConditions.Controls.Add(Me.btnBlustery)
        Me.pnlConditions.Controls.Add(Me.btnWindy)
        Me.pnlConditions.Controls.Add(Me.btnHot)
        Me.pnlConditions.Controls.Add(Me.btnCold)
        Me.pnlConditions.Controls.Add(Me.btnTornado)
        Me.pnlConditions.Controls.Add(Me.btnTropicalStorm)
        Me.pnlConditions.Controls.Add(Me.btnHurricane)
        Me.pnlConditions.Controls.Add(Me.btnSevereThunderstorm)
        Me.pnlConditions.Controls.Add(Me.btnThunderstorms)
        Me.pnlConditions.Controls.Add(Me.btnHail)
        Me.pnlConditions.Controls.Add(Me.btnSleet)
        Me.pnlConditions.Controls.Add(Me.btnDrizzle)
        Me.pnlConditions.Controls.Add(Me.btnShowers)
        Me.pnlConditions.Controls.Add(Me.btnThundershowers)
        Me.pnlConditions.Controls.Add(Me.btnIsolatedThundershowers)
        Me.pnlConditions.Controls.Add(Me.btnIsolatedThunderstorms)
        Me.pnlConditions.Controls.Add(Me.btnScatteredThunderstorms)
        Me.pnlConditions.Controls.Add(Me.btnScatteredShowers)
        Me.pnlConditions.Controls.Add(Me.btnMixedRainandHail)
        Me.pnlConditions.Controls.Add(Me.btnMixedRainandSleet)
        Me.pnlConditions.Controls.Add(Me.btnMixedRainandSnow)
        Me.pnlConditions.Controls.Add(Me.btnMixedSnowandSleet)
        Me.pnlConditions.Controls.Add(Me.btnFreezingDrizzle)
        Me.pnlConditions.Controls.Add(Me.btnFreezingRain)
        Me.pnlConditions.Controls.Add(Me.btnSnowFlurries)
        Me.pnlConditions.Controls.Add(Me.btnSnow)
        Me.pnlConditions.Controls.Add(Me.btnLightSnowShowers)
        Me.pnlConditions.Controls.Add(Me.btnScatteredSnowShowers)
        Me.pnlConditions.Controls.Add(Me.btnBlowingSnow)
        Me.pnlConditions.Controls.Add(Me.btnHeavySnow)
        Me.pnlConditions.Controls.Add(Me.btnSnowShowers)
        Me.pnlConditions.Controls.Add(Me.btnDust)
        Me.pnlConditions.Controls.Add(Me.btnFog)
        Me.pnlConditions.Controls.Add(Me.btnHaze)
        Me.pnlConditions.Controls.Add(Me.btnSmoke)
        Me.pnlConditions.Controls.Add(Me.btnUnavailable)
        Me.pnlConditions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConditions.Location = New System.Drawing.Point(1, 1)
        Me.pnlConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlConditions.Name = "pnlConditions"
        Me.pnlConditions.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.pnlConditions.Size = New System.Drawing.Size(819, 74)
        Me.pnlConditions.TabIndex = 5
        Me.pnlConditions.WrapContents = False
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.Color = System.Drawing.Color.SkyBlue
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(7, 6)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnClear.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnClear.Size = New System.Drawing.Size(65, 37)
        Me.btnClear.Style = resources.GetString("btnClear.Style")
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseCompatibleTextRendering = True
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSunny
        '
        Me.btnSunny.AutoSize = True
        Me.btnSunny.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSunny.BackColor = System.Drawing.Color.Transparent
        Me.btnSunny.BackgroundImage = CType(resources.GetObject("btnSunny.BackgroundImage"), System.Drawing.Image)
        Me.btnSunny.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnSunny.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSunny.FlatAppearance.BorderSize = 0
        Me.btnSunny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSunny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSunny.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSunny.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSunny.Image = CType(resources.GetObject("btnSunny.Image"), System.Drawing.Image)
        Me.btnSunny.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSunny.Location = New System.Drawing.Point(79, 6)
        Me.btnSunny.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnSunny.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnSunny.Name = "btnSunny"
        Me.btnSunny.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSunny.Size = New System.Drawing.Size(71, 37)
        Me.btnSunny.Style = resources.GetString("btnSunny.Style")
        Me.btnSunny.TabIndex = 19
        Me.btnSunny.Text = "Sunny"
        Me.btnSunny.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSunny.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSunny.UseCompatibleTextRendering = True
        Me.btnSunny.UseVisualStyleBackColor = True
        '
        'btnFair
        '
        Me.btnFair.AutoSize = True
        Me.btnFair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFair.BackColor = System.Drawing.Color.Transparent
        Me.btnFair.BackgroundImage = CType(resources.GetObject("btnFair.BackgroundImage"), System.Drawing.Image)
        Me.btnFair.Color = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnFair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFair.FlatAppearance.BorderSize = 0
        Me.btnFair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFair.Image = CType(resources.GetObject("btnFair.Image"), System.Drawing.Image)
        Me.btnFair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFair.Location = New System.Drawing.Point(157, 6)
        Me.btnFair.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnFair.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnFair.Name = "btnFair"
        Me.btnFair.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnFair.Size = New System.Drawing.Size(56, 37)
        Me.btnFair.Style = resources.GetString("btnFair.Style")
        Me.btnFair.TabIndex = 20
        Me.btnFair.Text = "Fair"
        Me.btnFair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFair.UseCompatibleTextRendering = True
        Me.btnFair.UseVisualStyleBackColor = True
        '
        'btnCloudy
        '
        Me.btnCloudy.AutoSize = True
        Me.btnCloudy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCloudy.BackColor = System.Drawing.Color.Transparent
        Me.btnCloudy.BackgroundImage = CType(resources.GetObject("btnCloudy.BackgroundImage"), System.Drawing.Image)
        Me.btnCloudy.Color = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnCloudy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCloudy.FlatAppearance.BorderSize = 0
        Me.btnCloudy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCloudy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCloudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloudy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCloudy.Image = CType(resources.GetObject("btnCloudy.Image"), System.Drawing.Image)
        Me.btnCloudy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloudy.Location = New System.Drawing.Point(220, 6)
        Me.btnCloudy.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnCloudy.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnCloudy.Name = "btnCloudy"
        Me.btnCloudy.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnCloudy.Size = New System.Drawing.Size(75, 37)
        Me.btnCloudy.Style = resources.GetString("btnCloudy.Style")
        Me.btnCloudy.TabIndex = 61
        Me.btnCloudy.Text = "Cloudy"
        Me.btnCloudy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCloudy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCloudy.UseCompatibleTextRendering = True
        Me.btnCloudy.UseVisualStyleBackColor = True
        '
        'btnPartlyCloudy
        '
        Me.btnPartlyCloudy.AutoSize = True
        Me.btnPartlyCloudy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPartlyCloudy.BackColor = System.Drawing.Color.Transparent
        Me.btnPartlyCloudy.BackgroundImage = CType(resources.GetObject("btnPartlyCloudy.BackgroundImage"), System.Drawing.Image)
        Me.btnPartlyCloudy.Color = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnPartlyCloudy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPartlyCloudy.FlatAppearance.BorderSize = 0
        Me.btnPartlyCloudy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPartlyCloudy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPartlyCloudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPartlyCloudy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPartlyCloudy.Image = CType(resources.GetObject("btnPartlyCloudy.Image"), System.Drawing.Image)
        Me.btnPartlyCloudy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPartlyCloudy.Location = New System.Drawing.Point(302, 6)
        Me.btnPartlyCloudy.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnPartlyCloudy.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnPartlyCloudy.Name = "btnPartlyCloudy"
        Me.btnPartlyCloudy.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnPartlyCloudy.Size = New System.Drawing.Size(112, 37)
        Me.btnPartlyCloudy.Style = resources.GetString("btnPartlyCloudy.Style")
        Me.btnPartlyCloudy.TabIndex = 21
        Me.btnPartlyCloudy.Text = "Partly Cloudy"
        Me.btnPartlyCloudy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPartlyCloudy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPartlyCloudy.UseCompatibleTextRendering = True
        Me.btnPartlyCloudy.UseVisualStyleBackColor = True
        '
        'btnMostlyCloudy
        '
        Me.btnMostlyCloudy.AutoSize = True
        Me.btnMostlyCloudy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMostlyCloudy.BackColor = System.Drawing.Color.Transparent
        Me.btnMostlyCloudy.BackgroundImage = CType(resources.GetObject("btnMostlyCloudy.BackgroundImage"), System.Drawing.Image)
        Me.btnMostlyCloudy.Color = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnMostlyCloudy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMostlyCloudy.FlatAppearance.BorderSize = 0
        Me.btnMostlyCloudy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMostlyCloudy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMostlyCloudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostlyCloudy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMostlyCloudy.Image = CType(resources.GetObject("btnMostlyCloudy.Image"), System.Drawing.Image)
        Me.btnMostlyCloudy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostlyCloudy.Location = New System.Drawing.Point(421, 6)
        Me.btnMostlyCloudy.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMostlyCloudy.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMostlyCloudy.Name = "btnMostlyCloudy"
        Me.btnMostlyCloudy.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMostlyCloudy.Size = New System.Drawing.Size(117, 37)
        Me.btnMostlyCloudy.Style = resources.GetString("btnMostlyCloudy.Style")
        Me.btnMostlyCloudy.TabIndex = 22
        Me.btnMostlyCloudy.Text = "Mostly Cloudy"
        Me.btnMostlyCloudy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostlyCloudy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMostlyCloudy.UseCompatibleTextRendering = True
        Me.btnMostlyCloudy.UseVisualStyleBackColor = True
        '
        'btnBlustery
        '
        Me.btnBlustery.AutoSize = True
        Me.btnBlustery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBlustery.BackColor = System.Drawing.Color.Transparent
        Me.btnBlustery.BackgroundImage = CType(resources.GetObject("btnBlustery.BackgroundImage"), System.Drawing.Image)
        Me.btnBlustery.Color = System.Drawing.Color.LightCyan
        Me.btnBlustery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBlustery.FlatAppearance.BorderSize = 0
        Me.btnBlustery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBlustery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBlustery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlustery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBlustery.Image = CType(resources.GetObject("btnBlustery.Image"), System.Drawing.Image)
        Me.btnBlustery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlustery.Location = New System.Drawing.Point(545, 6)
        Me.btnBlustery.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnBlustery.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnBlustery.Name = "btnBlustery"
        Me.btnBlustery.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnBlustery.Size = New System.Drawing.Size(81, 37)
        Me.btnBlustery.Style = resources.GetString("btnBlustery.Style")
        Me.btnBlustery.TabIndex = 23
        Me.btnBlustery.Text = "Blustery"
        Me.btnBlustery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBlustery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBlustery.UseCompatibleTextRendering = True
        Me.btnBlustery.UseVisualStyleBackColor = True
        '
        'btnWindy
        '
        Me.btnWindy.AutoSize = True
        Me.btnWindy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnWindy.BackColor = System.Drawing.Color.Transparent
        Me.btnWindy.BackgroundImage = CType(resources.GetObject("btnWindy.BackgroundImage"), System.Drawing.Image)
        Me.btnWindy.Color = System.Drawing.Color.LightCyan
        Me.btnWindy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWindy.FlatAppearance.BorderSize = 0
        Me.btnWindy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWindy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWindy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWindy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnWindy.Image = CType(resources.GetObject("btnWindy.Image"), System.Drawing.Image)
        Me.btnWindy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWindy.Location = New System.Drawing.Point(633, 6)
        Me.btnWindy.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnWindy.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnWindy.Name = "btnWindy"
        Me.btnWindy.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnWindy.Size = New System.Drawing.Size(70, 37)
        Me.btnWindy.Style = resources.GetString("btnWindy.Style")
        Me.btnWindy.TabIndex = 24
        Me.btnWindy.Text = "Windy"
        Me.btnWindy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWindy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWindy.UseCompatibleTextRendering = True
        Me.btnWindy.UseVisualStyleBackColor = True
        '
        'btnHot
        '
        Me.btnHot.AutoSize = True
        Me.btnHot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHot.BackColor = System.Drawing.Color.Transparent
        Me.btnHot.BackgroundImage = CType(resources.GetObject("btnHot.BackgroundImage"), System.Drawing.Image)
        Me.btnHot.Color = System.Drawing.Color.Firebrick
        Me.btnHot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHot.FlatAppearance.BorderSize = 0
        Me.btnHot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHot.Image = CType(resources.GetObject("btnHot.Image"), System.Drawing.Image)
        Me.btnHot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHot.Location = New System.Drawing.Point(710, 6)
        Me.btnHot.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnHot.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnHot.Name = "btnHot"
        Me.btnHot.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnHot.Size = New System.Drawing.Size(54, 37)
        Me.btnHot.Style = resources.GetString("btnHot.Style")
        Me.btnHot.TabIndex = 25
        Me.btnHot.Text = "Hot"
        Me.btnHot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHot.UseCompatibleTextRendering = True
        Me.btnHot.UseVisualStyleBackColor = True
        '
        'btnCold
        '
        Me.btnCold.AutoSize = True
        Me.btnCold.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCold.BackColor = System.Drawing.Color.Transparent
        Me.btnCold.BackgroundImage = CType(resources.GetObject("btnCold.BackgroundImage"), System.Drawing.Image)
        Me.btnCold.Color = System.Drawing.Color.SteelBlue
        Me.btnCold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCold.FlatAppearance.BorderSize = 0
        Me.btnCold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCold.Image = CType(resources.GetObject("btnCold.Image"), System.Drawing.Image)
        Me.btnCold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCold.Location = New System.Drawing.Point(771, 6)
        Me.btnCold.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnCold.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnCold.Name = "btnCold"
        Me.btnCold.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnCold.Size = New System.Drawing.Size(60, 37)
        Me.btnCold.Style = resources.GetString("btnCold.Style")
        Me.btnCold.TabIndex = 26
        Me.btnCold.Text = "Cold"
        Me.btnCold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCold.UseCompatibleTextRendering = True
        Me.btnCold.UseVisualStyleBackColor = True
        '
        'btnTornado
        '
        Me.btnTornado.AutoSize = True
        Me.btnTornado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTornado.BackColor = System.Drawing.Color.Transparent
        Me.btnTornado.BackgroundImage = CType(resources.GetObject("btnTornado.BackgroundImage"), System.Drawing.Image)
        Me.btnTornado.Color = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnTornado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTornado.FlatAppearance.BorderSize = 0
        Me.btnTornado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTornado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTornado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTornado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTornado.Image = CType(resources.GetObject("btnTornado.Image"), System.Drawing.Image)
        Me.btnTornado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTornado.Location = New System.Drawing.Point(838, 6)
        Me.btnTornado.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnTornado.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnTornado.Name = "btnTornado"
        Me.btnTornado.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnTornado.Size = New System.Drawing.Size(83, 37)
        Me.btnTornado.Style = resources.GetString("btnTornado.Style")
        Me.btnTornado.TabIndex = 27
        Me.btnTornado.Text = "Tornado"
        Me.btnTornado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTornado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTornado.UseCompatibleTextRendering = True
        Me.btnTornado.UseVisualStyleBackColor = True
        '
        'btnTropicalStorm
        '
        Me.btnTropicalStorm.AutoSize = True
        Me.btnTropicalStorm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTropicalStorm.BackColor = System.Drawing.Color.Transparent
        Me.btnTropicalStorm.BackgroundImage = CType(resources.GetObject("btnTropicalStorm.BackgroundImage"), System.Drawing.Image)
        Me.btnTropicalStorm.Color = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnTropicalStorm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTropicalStorm.FlatAppearance.BorderSize = 0
        Me.btnTropicalStorm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTropicalStorm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTropicalStorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTropicalStorm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTropicalStorm.Image = CType(resources.GetObject("btnTropicalStorm.Image"), System.Drawing.Image)
        Me.btnTropicalStorm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTropicalStorm.Location = New System.Drawing.Point(928, 6)
        Me.btnTropicalStorm.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnTropicalStorm.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnTropicalStorm.Name = "btnTropicalStorm"
        Me.btnTropicalStorm.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnTropicalStorm.Size = New System.Drawing.Size(120, 37)
        Me.btnTropicalStorm.Style = resources.GetString("btnTropicalStorm.Style")
        Me.btnTropicalStorm.TabIndex = 28
        Me.btnTropicalStorm.Text = "Tropical Storm"
        Me.btnTropicalStorm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTropicalStorm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTropicalStorm.UseCompatibleTextRendering = True
        Me.btnTropicalStorm.UseVisualStyleBackColor = True
        '
        'btnHurricane
        '
        Me.btnHurricane.AutoSize = True
        Me.btnHurricane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHurricane.BackColor = System.Drawing.Color.Transparent
        Me.btnHurricane.BackgroundImage = CType(resources.GetObject("btnHurricane.BackgroundImage"), System.Drawing.Image)
        Me.btnHurricane.Color = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnHurricane.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHurricane.FlatAppearance.BorderSize = 0
        Me.btnHurricane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHurricane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHurricane.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHurricane.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHurricane.Image = CType(resources.GetObject("btnHurricane.Image"), System.Drawing.Image)
        Me.btnHurricane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHurricane.Location = New System.Drawing.Point(1055, 6)
        Me.btnHurricane.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnHurricane.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnHurricane.Name = "btnHurricane"
        Me.btnHurricane.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnHurricane.Size = New System.Drawing.Size(91, 37)
        Me.btnHurricane.Style = resources.GetString("btnHurricane.Style")
        Me.btnHurricane.TabIndex = 29
        Me.btnHurricane.Text = "Hurricane"
        Me.btnHurricane.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHurricane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHurricane.UseCompatibleTextRendering = True
        Me.btnHurricane.UseVisualStyleBackColor = True
        '
        'btnSevereThunderstorm
        '
        Me.btnSevereThunderstorm.AutoSize = True
        Me.btnSevereThunderstorm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSevereThunderstorm.BackColor = System.Drawing.Color.Transparent
        Me.btnSevereThunderstorm.BackgroundImage = CType(resources.GetObject("btnSevereThunderstorm.BackgroundImage"), System.Drawing.Image)
        Me.btnSevereThunderstorm.Color = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSevereThunderstorm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSevereThunderstorm.FlatAppearance.BorderSize = 0
        Me.btnSevereThunderstorm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSevereThunderstorm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSevereThunderstorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSevereThunderstorm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSevereThunderstorm.Image = CType(resources.GetObject("btnSevereThunderstorm.Image"), System.Drawing.Image)
        Me.btnSevereThunderstorm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSevereThunderstorm.Location = New System.Drawing.Point(1153, 6)
        Me.btnSevereThunderstorm.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnSevereThunderstorm.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnSevereThunderstorm.Name = "btnSevereThunderstorm"
        Me.btnSevereThunderstorm.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSevereThunderstorm.Size = New System.Drawing.Size(162, 37)
        Me.btnSevereThunderstorm.Style = resources.GetString("btnSevereThunderstorm.Style")
        Me.btnSevereThunderstorm.TabIndex = 30
        Me.btnSevereThunderstorm.Text = "Severe Thunderstorm"
        Me.btnSevereThunderstorm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSevereThunderstorm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSevereThunderstorm.UseCompatibleTextRendering = True
        Me.btnSevereThunderstorm.UseVisualStyleBackColor = True
        '
        'btnThunderstorms
        '
        Me.btnThunderstorms.AutoSize = True
        Me.btnThunderstorms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnThunderstorms.BackColor = System.Drawing.Color.Transparent
        Me.btnThunderstorms.BackgroundImage = CType(resources.GetObject("btnThunderstorms.BackgroundImage"), System.Drawing.Image)
        Me.btnThunderstorms.Color = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnThunderstorms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnThunderstorms.FlatAppearance.BorderSize = 0
        Me.btnThunderstorms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnThunderstorms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnThunderstorms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThunderstorms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnThunderstorms.Image = CType(resources.GetObject("btnThunderstorms.Image"), System.Drawing.Image)
        Me.btnThunderstorms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThunderstorms.Location = New System.Drawing.Point(1322, 6)
        Me.btnThunderstorms.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnThunderstorms.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnThunderstorms.Name = "btnThunderstorms"
        Me.btnThunderstorms.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnThunderstorms.Size = New System.Drawing.Size(123, 37)
        Me.btnThunderstorms.Style = resources.GetString("btnThunderstorms.Style")
        Me.btnThunderstorms.TabIndex = 31
        Me.btnThunderstorms.Text = "Thunderstorms"
        Me.btnThunderstorms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThunderstorms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThunderstorms.UseCompatibleTextRendering = True
        Me.btnThunderstorms.UseVisualStyleBackColor = True
        '
        'btnHail
        '
        Me.btnHail.AutoSize = True
        Me.btnHail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHail.BackColor = System.Drawing.Color.Transparent
        Me.btnHail.BackgroundImage = CType(resources.GetObject("btnHail.BackgroundImage"), System.Drawing.Image)
        Me.btnHail.Color = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHail.FlatAppearance.BorderSize = 0
        Me.btnHail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHail.Image = CType(resources.GetObject("btnHail.Image"), System.Drawing.Image)
        Me.btnHail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHail.Location = New System.Drawing.Point(1452, 6)
        Me.btnHail.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnHail.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnHail.Name = "btnHail"
        Me.btnHail.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnHail.Size = New System.Drawing.Size(56, 37)
        Me.btnHail.Style = resources.GetString("btnHail.Style")
        Me.btnHail.TabIndex = 32
        Me.btnHail.Text = "Hail"
        Me.btnHail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHail.UseCompatibleTextRendering = True
        Me.btnHail.UseVisualStyleBackColor = True
        '
        'btnSleet
        '
        Me.btnSleet.AutoSize = True
        Me.btnSleet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSleet.BackColor = System.Drawing.Color.Transparent
        Me.btnSleet.BackgroundImage = CType(resources.GetObject("btnSleet.BackgroundImage"), System.Drawing.Image)
        Me.btnSleet.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnSleet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSleet.FlatAppearance.BorderSize = 0
        Me.btnSleet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSleet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSleet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSleet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSleet.Image = CType(resources.GetObject("btnSleet.Image"), System.Drawing.Image)
        Me.btnSleet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSleet.Location = New System.Drawing.Point(1515, 6)
        Me.btnSleet.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnSleet.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnSleet.Name = "btnSleet"
        Me.btnSleet.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSleet.Size = New System.Drawing.Size(63, 37)
        Me.btnSleet.Style = resources.GetString("btnSleet.Style")
        Me.btnSleet.TabIndex = 33
        Me.btnSleet.Text = "Sleet"
        Me.btnSleet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSleet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSleet.UseCompatibleTextRendering = True
        Me.btnSleet.UseVisualStyleBackColor = True
        '
        'btnDrizzle
        '
        Me.btnDrizzle.AutoSize = True
        Me.btnDrizzle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDrizzle.BackColor = System.Drawing.Color.Transparent
        Me.btnDrizzle.BackgroundImage = CType(resources.GetObject("btnDrizzle.BackgroundImage"), System.Drawing.Image)
        Me.btnDrizzle.Color = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnDrizzle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDrizzle.FlatAppearance.BorderSize = 0
        Me.btnDrizzle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDrizzle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDrizzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrizzle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDrizzle.Image = CType(resources.GetObject("btnDrizzle.Image"), System.Drawing.Image)
        Me.btnDrizzle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDrizzle.Location = New System.Drawing.Point(1585, 6)
        Me.btnDrizzle.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnDrizzle.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnDrizzle.Name = "btnDrizzle"
        Me.btnDrizzle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnDrizzle.Size = New System.Drawing.Size(74, 37)
        Me.btnDrizzle.Style = resources.GetString("btnDrizzle.Style")
        Me.btnDrizzle.TabIndex = 34
        Me.btnDrizzle.Text = "Drizzle"
        Me.btnDrizzle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDrizzle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDrizzle.UseCompatibleTextRendering = True
        Me.btnDrizzle.UseVisualStyleBackColor = True
        '
        'btnShowers
        '
        Me.btnShowers.AutoSize = True
        Me.btnShowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnShowers.BackColor = System.Drawing.Color.Transparent
        Me.btnShowers.BackgroundImage = CType(resources.GetObject("btnShowers.BackgroundImage"), System.Drawing.Image)
        Me.btnShowers.Color = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnShowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShowers.FlatAppearance.BorderSize = 0
        Me.btnShowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnShowers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnShowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnShowers.Image = CType(resources.GetObject("btnShowers.Image"), System.Drawing.Image)
        Me.btnShowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowers.Location = New System.Drawing.Point(1666, 6)
        Me.btnShowers.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnShowers.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnShowers.Name = "btnShowers"
        Me.btnShowers.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnShowers.Size = New System.Drawing.Size(85, 37)
        Me.btnShowers.Style = resources.GetString("btnShowers.Style")
        Me.btnShowers.TabIndex = 35
        Me.btnShowers.Text = "Showers"
        Me.btnShowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowers.UseCompatibleTextRendering = True
        Me.btnShowers.UseVisualStyleBackColor = True
        '
        'btnThundershowers
        '
        Me.btnThundershowers.AutoSize = True
        Me.btnThundershowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnThundershowers.BackColor = System.Drawing.Color.Transparent
        Me.btnThundershowers.BackgroundImage = CType(resources.GetObject("btnThundershowers.BackgroundImage"), System.Drawing.Image)
        Me.btnThundershowers.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnThundershowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnThundershowers.FlatAppearance.BorderSize = 0
        Me.btnThundershowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnThundershowers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnThundershowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThundershowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnThundershowers.Image = CType(resources.GetObject("btnThundershowers.Image"), System.Drawing.Image)
        Me.btnThundershowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThundershowers.Location = New System.Drawing.Point(1758, 6)
        Me.btnThundershowers.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnThundershowers.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnThundershowers.Name = "btnThundershowers"
        Me.btnThundershowers.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnThundershowers.Size = New System.Drawing.Size(133, 37)
        Me.btnThundershowers.Style = resources.GetString("btnThundershowers.Style")
        Me.btnThundershowers.TabIndex = 36
        Me.btnThundershowers.Text = "Thundershowers"
        Me.btnThundershowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThundershowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThundershowers.UseCompatibleTextRendering = True
        Me.btnThundershowers.UseVisualStyleBackColor = True
        '
        'btnIsolatedThundershowers
        '
        Me.btnIsolatedThundershowers.AutoSize = True
        Me.btnIsolatedThundershowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnIsolatedThundershowers.BackColor = System.Drawing.Color.Transparent
        Me.btnIsolatedThundershowers.BackgroundImage = CType(resources.GetObject("btnIsolatedThundershowers.BackgroundImage"), System.Drawing.Image)
        Me.btnIsolatedThundershowers.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnIsolatedThundershowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIsolatedThundershowers.FlatAppearance.BorderSize = 0
        Me.btnIsolatedThundershowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnIsolatedThundershowers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIsolatedThundershowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIsolatedThundershowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIsolatedThundershowers.Image = CType(resources.GetObject("btnIsolatedThundershowers.Image"), System.Drawing.Image)
        Me.btnIsolatedThundershowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIsolatedThundershowers.Location = New System.Drawing.Point(1898, 6)
        Me.btnIsolatedThundershowers.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnIsolatedThundershowers.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnIsolatedThundershowers.Name = "btnIsolatedThundershowers"
        Me.btnIsolatedThundershowers.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnIsolatedThundershowers.Size = New System.Drawing.Size(183, 37)
        Me.btnIsolatedThundershowers.Style = resources.GetString("btnIsolatedThundershowers.Style")
        Me.btnIsolatedThundershowers.TabIndex = 60
        Me.btnIsolatedThundershowers.Text = "Isolated Thundershowers"
        Me.btnIsolatedThundershowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIsolatedThundershowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIsolatedThundershowers.UseCompatibleTextRendering = True
        Me.btnIsolatedThundershowers.UseVisualStyleBackColor = True
        '
        'btnIsolatedThunderstorms
        '
        Me.btnIsolatedThunderstorms.AutoSize = True
        Me.btnIsolatedThunderstorms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnIsolatedThunderstorms.BackColor = System.Drawing.Color.Transparent
        Me.btnIsolatedThunderstorms.BackgroundImage = CType(resources.GetObject("btnIsolatedThunderstorms.BackgroundImage"), System.Drawing.Image)
        Me.btnIsolatedThunderstorms.Color = System.Drawing.Color.DarkSlateGray
        Me.btnIsolatedThunderstorms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIsolatedThunderstorms.FlatAppearance.BorderSize = 0
        Me.btnIsolatedThunderstorms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnIsolatedThunderstorms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIsolatedThunderstorms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIsolatedThunderstorms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIsolatedThunderstorms.Image = CType(resources.GetObject("btnIsolatedThunderstorms.Image"), System.Drawing.Image)
        Me.btnIsolatedThunderstorms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIsolatedThunderstorms.Location = New System.Drawing.Point(2088, 6)
        Me.btnIsolatedThunderstorms.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnIsolatedThunderstorms.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnIsolatedThunderstorms.Name = "btnIsolatedThunderstorms"
        Me.btnIsolatedThunderstorms.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnIsolatedThunderstorms.Size = New System.Drawing.Size(173, 37)
        Me.btnIsolatedThunderstorms.Style = resources.GetString("btnIsolatedThunderstorms.Style")
        Me.btnIsolatedThunderstorms.TabIndex = 37
        Me.btnIsolatedThunderstorms.Text = "Isolated Thunderstorms"
        Me.btnIsolatedThunderstorms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIsolatedThunderstorms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIsolatedThunderstorms.UseCompatibleTextRendering = True
        Me.btnIsolatedThunderstorms.UseVisualStyleBackColor = True
        '
        'btnScatteredThunderstorms
        '
        Me.btnScatteredThunderstorms.AutoSize = True
        Me.btnScatteredThunderstorms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnScatteredThunderstorms.BackColor = System.Drawing.Color.Transparent
        Me.btnScatteredThunderstorms.BackgroundImage = CType(resources.GetObject("btnScatteredThunderstorms.BackgroundImage"), System.Drawing.Image)
        Me.btnScatteredThunderstorms.Color = System.Drawing.Color.DarkSlateGray
        Me.btnScatteredThunderstorms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnScatteredThunderstorms.FlatAppearance.BorderSize = 0
        Me.btnScatteredThunderstorms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnScatteredThunderstorms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnScatteredThunderstorms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScatteredThunderstorms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnScatteredThunderstorms.Image = CType(resources.GetObject("btnScatteredThunderstorms.Image"), System.Drawing.Image)
        Me.btnScatteredThunderstorms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScatteredThunderstorms.Location = New System.Drawing.Point(2268, 6)
        Me.btnScatteredThunderstorms.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnScatteredThunderstorms.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnScatteredThunderstorms.Name = "btnScatteredThunderstorms"
        Me.btnScatteredThunderstorms.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnScatteredThunderstorms.Size = New System.Drawing.Size(184, 37)
        Me.btnScatteredThunderstorms.Style = resources.GetString("btnScatteredThunderstorms.Style")
        Me.btnScatteredThunderstorms.TabIndex = 38
        Me.btnScatteredThunderstorms.Text = "Scattered Thunderstorms"
        Me.btnScatteredThunderstorms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnScatteredThunderstorms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScatteredThunderstorms.UseCompatibleTextRendering = True
        Me.btnScatteredThunderstorms.UseVisualStyleBackColor = True
        '
        'btnScatteredShowers
        '
        Me.btnScatteredShowers.AutoSize = True
        Me.btnScatteredShowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnScatteredShowers.BackColor = System.Drawing.Color.Transparent
        Me.btnScatteredShowers.BackgroundImage = CType(resources.GetObject("btnScatteredShowers.BackgroundImage"), System.Drawing.Image)
        Me.btnScatteredShowers.Color = System.Drawing.Color.LightSlateGray
        Me.btnScatteredShowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnScatteredShowers.FlatAppearance.BorderSize = 0
        Me.btnScatteredShowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnScatteredShowers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnScatteredShowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScatteredShowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnScatteredShowers.Image = CType(resources.GetObject("btnScatteredShowers.Image"), System.Drawing.Image)
        Me.btnScatteredShowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScatteredShowers.Location = New System.Drawing.Point(2459, 6)
        Me.btnScatteredShowers.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnScatteredShowers.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnScatteredShowers.Name = "btnScatteredShowers"
        Me.btnScatteredShowers.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnScatteredShowers.Size = New System.Drawing.Size(146, 37)
        Me.btnScatteredShowers.Style = resources.GetString("btnScatteredShowers.Style")
        Me.btnScatteredShowers.TabIndex = 39
        Me.btnScatteredShowers.Text = "Scattered Showers"
        Me.btnScatteredShowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnScatteredShowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScatteredShowers.UseCompatibleTextRendering = True
        Me.btnScatteredShowers.UseVisualStyleBackColor = True
        '
        'btnMixedRainandHail
        '
        Me.btnMixedRainandHail.AutoSize = True
        Me.btnMixedRainandHail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMixedRainandHail.BackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandHail.BackgroundImage = CType(resources.GetObject("btnMixedRainandHail.BackgroundImage"), System.Drawing.Image)
        Me.btnMixedRainandHail.Color = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnMixedRainandHail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMixedRainandHail.FlatAppearance.BorderSize = 0
        Me.btnMixedRainandHail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandHail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandHail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMixedRainandHail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMixedRainandHail.Image = CType(resources.GetObject("btnMixedRainandHail.Image"), System.Drawing.Image)
        Me.btnMixedRainandHail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMixedRainandHail.Location = New System.Drawing.Point(2612, 6)
        Me.btnMixedRainandHail.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMixedRainandHail.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMixedRainandHail.Name = "btnMixedRainandHail"
        Me.btnMixedRainandHail.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMixedRainandHail.Size = New System.Drawing.Size(152, 37)
        Me.btnMixedRainandHail.Style = resources.GetString("btnMixedRainandHail.Style")
        Me.btnMixedRainandHail.TabIndex = 40
        Me.btnMixedRainandHail.Text = "Mixed Rain and Hail"
        Me.btnMixedRainandHail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMixedRainandHail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMixedRainandHail.UseCompatibleTextRendering = True
        Me.btnMixedRainandHail.UseVisualStyleBackColor = True
        '
        'btnMixedRainandSleet
        '
        Me.btnMixedRainandSleet.AutoSize = True
        Me.btnMixedRainandSleet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMixedRainandSleet.BackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandSleet.BackgroundImage = CType(resources.GetObject("btnMixedRainandSleet.BackgroundImage"), System.Drawing.Image)
        Me.btnMixedRainandSleet.Color = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMixedRainandSleet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMixedRainandSleet.FlatAppearance.BorderSize = 0
        Me.btnMixedRainandSleet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandSleet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandSleet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMixedRainandSleet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMixedRainandSleet.Image = CType(resources.GetObject("btnMixedRainandSleet.Image"), System.Drawing.Image)
        Me.btnMixedRainandSleet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMixedRainandSleet.Location = New System.Drawing.Point(2771, 6)
        Me.btnMixedRainandSleet.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMixedRainandSleet.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMixedRainandSleet.Name = "btnMixedRainandSleet"
        Me.btnMixedRainandSleet.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMixedRainandSleet.Size = New System.Drawing.Size(160, 37)
        Me.btnMixedRainandSleet.Style = resources.GetString("btnMixedRainandSleet.Style")
        Me.btnMixedRainandSleet.TabIndex = 41
        Me.btnMixedRainandSleet.Text = "Mixed Rain and Sleet"
        Me.btnMixedRainandSleet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMixedRainandSleet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMixedRainandSleet.UseCompatibleTextRendering = True
        Me.btnMixedRainandSleet.UseVisualStyleBackColor = True
        '
        'btnMixedRainandSnow
        '
        Me.btnMixedRainandSnow.AutoSize = True
        Me.btnMixedRainandSnow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMixedRainandSnow.BackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandSnow.BackgroundImage = CType(resources.GetObject("btnMixedRainandSnow.BackgroundImage"), System.Drawing.Image)
        Me.btnMixedRainandSnow.Color = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnMixedRainandSnow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMixedRainandSnow.FlatAppearance.BorderSize = 0
        Me.btnMixedRainandSnow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandSnow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMixedRainandSnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMixedRainandSnow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMixedRainandSnow.Image = CType(resources.GetObject("btnMixedRainandSnow.Image"), System.Drawing.Image)
        Me.btnMixedRainandSnow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMixedRainandSnow.Location = New System.Drawing.Point(2938, 6)
        Me.btnMixedRainandSnow.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMixedRainandSnow.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMixedRainandSnow.Name = "btnMixedRainandSnow"
        Me.btnMixedRainandSnow.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMixedRainandSnow.Size = New System.Drawing.Size(163, 37)
        Me.btnMixedRainandSnow.Style = resources.GetString("btnMixedRainandSnow.Style")
        Me.btnMixedRainandSnow.TabIndex = 42
        Me.btnMixedRainandSnow.Text = "Mixed Rain and Snow"
        Me.btnMixedRainandSnow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMixedRainandSnow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMixedRainandSnow.UseCompatibleTextRendering = True
        Me.btnMixedRainandSnow.UseVisualStyleBackColor = True
        '
        'btnMixedSnowandSleet
        '
        Me.btnMixedSnowandSleet.AutoSize = True
        Me.btnMixedSnowandSleet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMixedSnowandSleet.BackColor = System.Drawing.Color.Transparent
        Me.btnMixedSnowandSleet.BackgroundImage = CType(resources.GetObject("btnMixedSnowandSleet.BackgroundImage"), System.Drawing.Image)
        Me.btnMixedSnowandSleet.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMixedSnowandSleet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMixedSnowandSleet.FlatAppearance.BorderSize = 0
        Me.btnMixedSnowandSleet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMixedSnowandSleet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMixedSnowandSleet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMixedSnowandSleet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMixedSnowandSleet.Image = CType(resources.GetObject("btnMixedSnowandSleet.Image"), System.Drawing.Image)
        Me.btnMixedSnowandSleet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMixedSnowandSleet.Location = New System.Drawing.Point(3108, 6)
        Me.btnMixedSnowandSleet.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnMixedSnowandSleet.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnMixedSnowandSleet.Name = "btnMixedSnowandSleet"
        Me.btnMixedSnowandSleet.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnMixedSnowandSleet.Size = New System.Drawing.Size(166, 37)
        Me.btnMixedSnowandSleet.Style = resources.GetString("btnMixedSnowandSleet.Style")
        Me.btnMixedSnowandSleet.TabIndex = 43
        Me.btnMixedSnowandSleet.Text = "Mixed Snow and Sleet"
        Me.btnMixedSnowandSleet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMixedSnowandSleet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMixedSnowandSleet.UseCompatibleTextRendering = True
        Me.btnMixedSnowandSleet.UseVisualStyleBackColor = True
        '
        'btnFreezingDrizzle
        '
        Me.btnFreezingDrizzle.AutoSize = True
        Me.btnFreezingDrizzle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFreezingDrizzle.BackColor = System.Drawing.Color.Transparent
        Me.btnFreezingDrizzle.BackgroundImage = CType(resources.GetObject("btnFreezingDrizzle.BackgroundImage"), System.Drawing.Image)
        Me.btnFreezingDrizzle.Color = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFreezingDrizzle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFreezingDrizzle.FlatAppearance.BorderSize = 0
        Me.btnFreezingDrizzle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFreezingDrizzle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFreezingDrizzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFreezingDrizzle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFreezingDrizzle.Image = CType(resources.GetObject("btnFreezingDrizzle.Image"), System.Drawing.Image)
        Me.btnFreezingDrizzle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFreezingDrizzle.Location = New System.Drawing.Point(3281, 6)
        Me.btnFreezingDrizzle.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnFreezingDrizzle.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnFreezingDrizzle.Name = "btnFreezingDrizzle"
        Me.btnFreezingDrizzle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnFreezingDrizzle.Size = New System.Drawing.Size(130, 37)
        Me.btnFreezingDrizzle.Style = resources.GetString("btnFreezingDrizzle.Style")
        Me.btnFreezingDrizzle.TabIndex = 44
        Me.btnFreezingDrizzle.Text = "Freezing Drizzle"
        Me.btnFreezingDrizzle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFreezingDrizzle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFreezingDrizzle.UseCompatibleTextRendering = True
        Me.btnFreezingDrizzle.UseVisualStyleBackColor = True
        '
        'btnFreezingRain
        '
        Me.btnFreezingRain.AutoSize = True
        Me.btnFreezingRain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFreezingRain.BackColor = System.Drawing.Color.Transparent
        Me.btnFreezingRain.BackgroundImage = CType(resources.GetObject("btnFreezingRain.BackgroundImage"), System.Drawing.Image)
        Me.btnFreezingRain.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFreezingRain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFreezingRain.FlatAppearance.BorderSize = 0
        Me.btnFreezingRain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFreezingRain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFreezingRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFreezingRain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFreezingRain.Image = CType(resources.GetObject("btnFreezingRain.Image"), System.Drawing.Image)
        Me.btnFreezingRain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFreezingRain.Location = New System.Drawing.Point(3418, 6)
        Me.btnFreezingRain.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnFreezingRain.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnFreezingRain.Name = "btnFreezingRain"
        Me.btnFreezingRain.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnFreezingRain.Size = New System.Drawing.Size(116, 37)
        Me.btnFreezingRain.Style = resources.GetString("btnFreezingRain.Style")
        Me.btnFreezingRain.TabIndex = 45
        Me.btnFreezingRain.Text = "Freezing Rain"
        Me.btnFreezingRain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFreezingRain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFreezingRain.UseCompatibleTextRendering = True
        Me.btnFreezingRain.UseVisualStyleBackColor = True
        '
        'btnSnowFlurries
        '
        Me.btnSnowFlurries.AutoSize = True
        Me.btnSnowFlurries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSnowFlurries.BackColor = System.Drawing.Color.Transparent
        Me.btnSnowFlurries.BackgroundImage = CType(resources.GetObject("btnSnowFlurries.BackgroundImage"), System.Drawing.Image)
        Me.btnSnowFlurries.Color = System.Drawing.Color.Azure
        Me.btnSnowFlurries.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSnowFlurries.FlatAppearance.BorderSize = 0
        Me.btnSnowFlurries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSnowFlurries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSnowFlurries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnowFlurries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSnowFlurries.Image = CType(resources.GetObject("btnSnowFlurries.Image"), System.Drawing.Image)
        Me.btnSnowFlurries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSnowFlurries.Location = New System.Drawing.Point(3541, 6)
        Me.btnSnowFlurries.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnSnowFlurries.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnSnowFlurries.Name = "btnSnowFlurries"
        Me.btnSnowFlurries.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSnowFlurries.Size = New System.Drawing.Size(115, 37)
        Me.btnSnowFlurries.Style = resources.GetString("btnSnowFlurries.Style")
        Me.btnSnowFlurries.TabIndex = 46
        Me.btnSnowFlurries.Text = "Snow Flurries"
        Me.btnSnowFlurries.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSnowFlurries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSnowFlurries.UseCompatibleTextRendering = True
        Me.btnSnowFlurries.UseVisualStyleBackColor = True
        '
        'btnSnow
        '
        Me.btnSnow.AutoSize = True
        Me.btnSnow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSnow.BackColor = System.Drawing.Color.Transparent
        Me.btnSnow.BackgroundImage = CType(resources.GetObject("btnSnow.BackgroundImage"), System.Drawing.Image)
        Me.btnSnow.Color = System.Drawing.Color.Azure
        Me.btnSnow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSnow.FlatAppearance.BorderSize = 0
        Me.btnSnow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSnow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSnow.Image = CType(resources.GetObject("btnSnow.Image"), System.Drawing.Image)
        Me.btnSnow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSnow.Location = New System.Drawing.Point(3663, 6)
        Me.btnSnow.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnSnow.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnSnow.Name = "btnSnow"
        Me.btnSnow.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSnow.Size = New System.Drawing.Size(66, 37)
        Me.btnSnow.Style = resources.GetString("btnSnow.Style")
        Me.btnSnow.TabIndex = 47
        Me.btnSnow.Text = "Snow"
        Me.btnSnow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSnow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSnow.UseCompatibleTextRendering = True
        Me.btnSnow.UseVisualStyleBackColor = True
        '
        'btnLightSnowShowers
        '
        Me.btnLightSnowShowers.AutoSize = True
        Me.btnLightSnowShowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLightSnowShowers.BackColor = System.Drawing.Color.Transparent
        Me.btnLightSnowShowers.BackgroundImage = CType(resources.GetObject("btnLightSnowShowers.BackgroundImage"), System.Drawing.Image)
        Me.btnLightSnowShowers.Color = System.Drawing.Color.Azure
        Me.btnLightSnowShowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLightSnowShowers.FlatAppearance.BorderSize = 0
        Me.btnLightSnowShowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLightSnowShowers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLightSnowShowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLightSnowShowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLightSnowShowers.Image = CType(resources.GetObject("btnLightSnowShowers.Image"), System.Drawing.Image)
        Me.btnLightSnowShowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLightSnowShowers.Location = New System.Drawing.Point(3736, 6)
        Me.btnLightSnowShowers.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnLightSnowShowers.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnLightSnowShowers.Name = "btnLightSnowShowers"
        Me.btnLightSnowShowers.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnLightSnowShowers.Size = New System.Drawing.Size(155, 37)
        Me.btnLightSnowShowers.Style = resources.GetString("btnLightSnowShowers.Style")
        Me.btnLightSnowShowers.TabIndex = 48
        Me.btnLightSnowShowers.Text = "Light Snow Showers"
        Me.btnLightSnowShowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLightSnowShowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLightSnowShowers.UseCompatibleTextRendering = True
        Me.btnLightSnowShowers.UseVisualStyleBackColor = True
        '
        'btnScatteredSnowShowers
        '
        Me.btnScatteredSnowShowers.AutoSize = True
        Me.btnScatteredSnowShowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnScatteredSnowShowers.BackColor = System.Drawing.Color.Transparent
        Me.btnScatteredSnowShowers.BackgroundImage = CType(resources.GetObject("btnScatteredSnowShowers.BackgroundImage"), System.Drawing.Image)
        Me.btnScatteredSnowShowers.Color = System.Drawing.Color.Azure
        Me.btnScatteredSnowShowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnScatteredSnowShowers.FlatAppearance.BorderSize = 0
        Me.btnScatteredSnowShowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnScatteredSnowShowers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnScatteredSnowShowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScatteredSnowShowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnScatteredSnowShowers.Image = CType(resources.GetObject("btnScatteredSnowShowers.Image"), System.Drawing.Image)
        Me.btnScatteredSnowShowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScatteredSnowShowers.Location = New System.Drawing.Point(3898, 6)
        Me.btnScatteredSnowShowers.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnScatteredSnowShowers.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnScatteredSnowShowers.Name = "btnScatteredSnowShowers"
        Me.btnScatteredSnowShowers.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnScatteredSnowShowers.Size = New System.Drawing.Size(183, 37)
        Me.btnScatteredSnowShowers.Style = resources.GetString("btnScatteredSnowShowers.Style")
        Me.btnScatteredSnowShowers.TabIndex = 49
        Me.btnScatteredSnowShowers.Text = "Scattered Snow Showers"
        Me.btnScatteredSnowShowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnScatteredSnowShowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScatteredSnowShowers.UseCompatibleTextRendering = True
        Me.btnScatteredSnowShowers.UseVisualStyleBackColor = True
        '
        'btnBlowingSnow
        '
        Me.btnBlowingSnow.AutoSize = True
        Me.btnBlowingSnow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBlowingSnow.BackColor = System.Drawing.Color.Transparent
        Me.btnBlowingSnow.BackgroundImage = CType(resources.GetObject("btnBlowingSnow.BackgroundImage"), System.Drawing.Image)
        Me.btnBlowingSnow.Color = System.Drawing.Color.Azure
        Me.btnBlowingSnow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBlowingSnow.FlatAppearance.BorderSize = 0
        Me.btnBlowingSnow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBlowingSnow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBlowingSnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlowingSnow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBlowingSnow.Image = CType(resources.GetObject("btnBlowingSnow.Image"), System.Drawing.Image)
        Me.btnBlowingSnow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlowingSnow.Location = New System.Drawing.Point(4088, 6)
        Me.btnBlowingSnow.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnBlowingSnow.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnBlowingSnow.Name = "btnBlowingSnow"
        Me.btnBlowingSnow.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnBlowingSnow.Size = New System.Drawing.Size(117, 37)
        Me.btnBlowingSnow.Style = resources.GetString("btnBlowingSnow.Style")
        Me.btnBlowingSnow.TabIndex = 50
        Me.btnBlowingSnow.Text = "Blowing Snow"
        Me.btnBlowingSnow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBlowingSnow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBlowingSnow.UseCompatibleTextRendering = True
        Me.btnBlowingSnow.UseVisualStyleBackColor = True
        '
        'btnHeavySnow
        '
        Me.btnHeavySnow.AutoSize = True
        Me.btnHeavySnow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHeavySnow.BackColor = System.Drawing.Color.Transparent
        Me.btnHeavySnow.BackgroundImage = CType(resources.GetObject("btnHeavySnow.BackgroundImage"), System.Drawing.Image)
        Me.btnHeavySnow.Color = System.Drawing.Color.White
        Me.btnHeavySnow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHeavySnow.FlatAppearance.BorderSize = 0
        Me.btnHeavySnow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHeavySnow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHeavySnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeavySnow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHeavySnow.Image = CType(resources.GetObject("btnHeavySnow.Image"), System.Drawing.Image)
        Me.btnHeavySnow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeavySnow.Location = New System.Drawing.Point(4212, 6)
        Me.btnHeavySnow.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnHeavySnow.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnHeavySnow.Name = "btnHeavySnow"
        Me.btnHeavySnow.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnHeavySnow.Size = New System.Drawing.Size(108, 37)
        Me.btnHeavySnow.Style = resources.GetString("btnHeavySnow.Style")
        Me.btnHeavySnow.TabIndex = 51
        Me.btnHeavySnow.Text = "Heavy Snow"
        Me.btnHeavySnow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHeavySnow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHeavySnow.UseCompatibleTextRendering = True
        Me.btnHeavySnow.UseVisualStyleBackColor = True
        '
        'btnSnowShowers
        '
        Me.btnSnowShowers.AutoSize = True
        Me.btnSnowShowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSnowShowers.BackColor = System.Drawing.Color.Transparent
        Me.btnSnowShowers.BackgroundImage = CType(resources.GetObject("btnSnowShowers.BackgroundImage"), System.Drawing.Image)
        Me.btnSnowShowers.Color = System.Drawing.Color.Azure
        Me.btnSnowShowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSnowShowers.FlatAppearance.BorderSize = 0
        Me.btnSnowShowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSnowShowers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSnowShowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnowShowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSnowShowers.Image = CType(resources.GetObject("btnSnowShowers.Image"), System.Drawing.Image)
        Me.btnSnowShowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSnowShowers.Location = New System.Drawing.Point(4327, 6)
        Me.btnSnowShowers.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnSnowShowers.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnSnowShowers.Name = "btnSnowShowers"
        Me.btnSnowShowers.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSnowShowers.Size = New System.Drawing.Size(122, 37)
        Me.btnSnowShowers.Style = resources.GetString("btnSnowShowers.Style")
        Me.btnSnowShowers.TabIndex = 52
        Me.btnSnowShowers.Text = "Snow Showers"
        Me.btnSnowShowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSnowShowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSnowShowers.UseCompatibleTextRendering = True
        Me.btnSnowShowers.UseVisualStyleBackColor = True
        '
        'btnDust
        '
        Me.btnDust.AutoSize = True
        Me.btnDust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDust.BackColor = System.Drawing.Color.Transparent
        Me.btnDust.BackgroundImage = CType(resources.GetObject("btnDust.BackgroundImage"), System.Drawing.Image)
        Me.btnDust.Color = System.Drawing.Color.Tan
        Me.btnDust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDust.FlatAppearance.BorderSize = 0
        Me.btnDust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDust.Image = CType(resources.GetObject("btnDust.Image"), System.Drawing.Image)
        Me.btnDust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDust.Location = New System.Drawing.Point(4456, 6)
        Me.btnDust.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnDust.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnDust.Name = "btnDust"
        Me.btnDust.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnDust.Size = New System.Drawing.Size(60, 37)
        Me.btnDust.Style = resources.GetString("btnDust.Style")
        Me.btnDust.TabIndex = 53
        Me.btnDust.Text = "Dust"
        Me.btnDust.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDust.UseCompatibleTextRendering = True
        Me.btnDust.UseVisualStyleBackColor = True
        '
        'btnFog
        '
        Me.btnFog.AutoSize = True
        Me.btnFog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFog.BackColor = System.Drawing.Color.Transparent
        Me.btnFog.BackgroundImage = CType(resources.GetObject("btnFog.BackgroundImage"), System.Drawing.Image)
        Me.btnFog.Color = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnFog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFog.FlatAppearance.BorderSize = 0
        Me.btnFog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFog.Image = CType(resources.GetObject("btnFog.Image"), System.Drawing.Image)
        Me.btnFog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFog.Location = New System.Drawing.Point(4523, 6)
        Me.btnFog.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnFog.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnFog.Name = "btnFog"
        Me.btnFog.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnFog.Size = New System.Drawing.Size(56, 37)
        Me.btnFog.Style = resources.GetString("btnFog.Style")
        Me.btnFog.TabIndex = 54
        Me.btnFog.Text = "Fog"
        Me.btnFog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFog.UseCompatibleTextRendering = True
        Me.btnFog.UseVisualStyleBackColor = True
        '
        'btnHaze
        '
        Me.btnHaze.AutoSize = True
        Me.btnHaze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHaze.BackColor = System.Drawing.Color.Transparent
        Me.btnHaze.BackgroundImage = CType(resources.GetObject("btnHaze.BackgroundImage"), System.Drawing.Image)
        Me.btnHaze.Color = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnHaze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHaze.FlatAppearance.BorderSize = 0
        Me.btnHaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHaze.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHaze.Image = CType(resources.GetObject("btnHaze.Image"), System.Drawing.Image)
        Me.btnHaze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHaze.Location = New System.Drawing.Point(4586, 6)
        Me.btnHaze.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnHaze.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnHaze.Name = "btnHaze"
        Me.btnHaze.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnHaze.Size = New System.Drawing.Size(64, 37)
        Me.btnHaze.Style = resources.GetString("btnHaze.Style")
        Me.btnHaze.TabIndex = 55
        Me.btnHaze.Text = "Haze"
        Me.btnHaze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHaze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHaze.UseCompatibleTextRendering = True
        Me.btnHaze.UseVisualStyleBackColor = True
        '
        'btnSmoke
        '
        Me.btnSmoke.AutoSize = True
        Me.btnSmoke.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSmoke.BackColor = System.Drawing.Color.Transparent
        Me.btnSmoke.BackgroundImage = CType(resources.GetObject("btnSmoke.BackgroundImage"), System.Drawing.Image)
        Me.btnSmoke.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSmoke.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSmoke.FlatAppearance.BorderSize = 0
        Me.btnSmoke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSmoke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSmoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSmoke.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSmoke.Image = CType(resources.GetObject("btnSmoke.Image"), System.Drawing.Image)
        Me.btnSmoke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSmoke.Location = New System.Drawing.Point(4657, 6)
        Me.btnSmoke.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnSmoke.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnSmoke.Name = "btnSmoke"
        Me.btnSmoke.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSmoke.Size = New System.Drawing.Size(75, 37)
        Me.btnSmoke.Style = resources.GetString("btnSmoke.Style")
        Me.btnSmoke.TabIndex = 56
        Me.btnSmoke.Text = "Smoke"
        Me.btnSmoke.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSmoke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSmoke.UseCompatibleTextRendering = True
        Me.btnSmoke.UseVisualStyleBackColor = True
        '
        'btnUnavailable
        '
        Me.btnUnavailable.AutoSize = True
        Me.btnUnavailable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUnavailable.BackColor = System.Drawing.Color.Transparent
        Me.btnUnavailable.BackgroundImage = CType(resources.GetObject("btnUnavailable.BackgroundImage"), System.Drawing.Image)
        Me.btnUnavailable.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUnavailable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUnavailable.FlatAppearance.BorderSize = 0
        Me.btnUnavailable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUnavailable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUnavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnavailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUnavailable.Image = CType(resources.GetObject("btnUnavailable.Image"), System.Drawing.Image)
        Me.btnUnavailable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnavailable.Location = New System.Drawing.Point(4739, 6)
        Me.btnUnavailable.Margin = New System.Windows.Forms.Padding(0, 6, 7, 6)
        Me.btnUnavailable.MinimumSize = New System.Drawing.Size(4, 37)
        Me.btnUnavailable.Name = "btnUnavailable"
        Me.btnUnavailable.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnUnavailable.Size = New System.Drawing.Size(103, 37)
        Me.btnUnavailable.Style = resources.GetString("btnUnavailable.Style")
        Me.btnUnavailable.TabIndex = 59
        Me.btnUnavailable.Text = "Unavailable"
        Me.btnUnavailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUnavailable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUnavailable.UseCompatibleTextRendering = True
        Me.btnUnavailable.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnTime.BackColor = System.Drawing.Color.Transparent
        Me.btnTime.BackgroundImage = CType(resources.GetObject("btnTime.BackgroundImage"), System.Drawing.Image)
        Me.btnTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTime.FlatAppearance.BorderSize = 0
        Me.btnTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTime.Image = CType(resources.GetObject("btnTime.Image"), System.Drawing.Image)
        Me.btnTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTime.Location = New System.Drawing.Point(4, 302)
        Me.btnTime.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnTime.Size = New System.Drawing.Size(155, 28)
        Me.btnTime.Style = resources.GetString("btnTime.Style")
        Me.btnTime.TabIndex = 83
        Me.btnTime.Text = "Time"
        Me.btnTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTime.UseCompatibleTextRendering = True
        Me.btnTime.UseVisualStyleBackColor = False
        '
        'btnNone
        '
        Me.btnNone.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnNone.BackColor = System.Drawing.Color.Transparent
        Me.btnNone.BackgroundImage = CType(resources.GetObject("btnNone.BackgroundImage"), System.Drawing.Image)
        Me.btnNone.Checked = True
        Me.btnNone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNone.FlatAppearance.BorderSize = 0
        Me.btnNone.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnNone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnNone.Image = CType(resources.GetObject("btnNone.Image"), System.Drawing.Image)
        Me.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNone.Location = New System.Drawing.Point(4, 4)
        Me.btnNone.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnNone.Size = New System.Drawing.Size(155, 28)
        Me.btnNone.Style = resources.GetString("btnNone.Style")
        Me.btnNone.TabIndex = 2
        Me.btnNone.TabStop = True
        Me.btnNone.Text = "None"
        Me.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNone.UseCompatibleTextRendering = True
        Me.btnNone.UseVisualStyleBackColor = False
        '
        'btnWindSpeed
        '
        Me.btnWindSpeed.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnWindSpeed.BackColor = System.Drawing.Color.Transparent
        Me.btnWindSpeed.BackgroundImage = CType(resources.GetObject("btnWindSpeed.BackgroundImage"), System.Drawing.Image)
        Me.btnWindSpeed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWindSpeed.FlatAppearance.BorderSize = 0
        Me.btnWindSpeed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnWindSpeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWindSpeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWindSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWindSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnWindSpeed.Image = CType(resources.GetObject("btnWindSpeed.Image"), System.Drawing.Image)
        Me.btnWindSpeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWindSpeed.Location = New System.Drawing.Point(4, 636)
        Me.btnWindSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWindSpeed.Name = "btnWindSpeed"
        Me.btnWindSpeed.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnWindSpeed.Size = New System.Drawing.Size(155, 28)
        Me.btnWindSpeed.Style = resources.GetString("btnWindSpeed.Style")
        Me.btnWindSpeed.TabIndex = 73
        Me.btnWindSpeed.Text = "Wind Speed"
        Me.btnWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnWindSpeed.UseCompatibleTextRendering = True
        Me.btnWindSpeed.UseVisualStyleBackColor = False
        '
        'btnHumidity
        '
        Me.btnHumidity.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnHumidity.BackColor = System.Drawing.Color.Transparent
        Me.btnHumidity.BackgroundImage = CType(resources.GetObject("btnHumidity.BackgroundImage"), System.Drawing.Image)
        Me.btnHumidity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHumidity.FlatAppearance.BorderSize = 0
        Me.btnHumidity.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnHumidity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHumidity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHumidity.Image = CType(resources.GetObject("btnHumidity.Image"), System.Drawing.Image)
        Me.btnHumidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHumidity.Location = New System.Drawing.Point(4, 553)
        Me.btnHumidity.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHumidity.Name = "btnHumidity"
        Me.btnHumidity.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnHumidity.Size = New System.Drawing.Size(155, 28)
        Me.btnHumidity.Style = resources.GetString("btnHumidity.Style")
        Me.btnHumidity.TabIndex = 70
        Me.btnHumidity.Text = "Humidity"
        Me.btnHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHumidity.UseCompatibleTextRendering = True
        Me.btnHumidity.UseVisualStyleBackColor = False
        '
        'btnRandom
        '
        Me.btnRandom.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnRandom.BackColor = System.Drawing.Color.Transparent
        Me.btnRandom.BackgroundImage = CType(resources.GetObject("btnRandom.BackgroundImage"), System.Drawing.Image)
        Me.btnRandom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRandom.FlatAppearance.BorderSize = 0
        Me.btnRandom.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRandom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRandom.Image = CType(resources.GetObject("btnRandom.Image"), System.Drawing.Image)
        Me.btnRandom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRandom.Location = New System.Drawing.Point(4, 146)
        Me.btnRandom.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnRandom.Size = New System.Drawing.Size(155, 28)
        Me.btnRandom.Style = resources.GetString("btnRandom.Style")
        Me.btnRandom.TabIndex = 6
        Me.btnRandom.Text = "Random"
        Me.btnRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRandom.UseCompatibleTextRendering = True
        Me.btnRandom.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(167, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Generate random colors"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(167, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "The color you set in the Control Panel"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(167, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 20)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Get the color from the current program's icon"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'btnConditions
        '
        Me.btnConditions.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnConditions.BackColor = System.Drawing.Color.Transparent
        Me.btnConditions.BackgroundImage = CType(resources.GetObject("btnConditions.BackgroundImage"), System.Drawing.Image)
        Me.btnConditions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConditions.FlatAppearance.BorderSize = 0
        Me.btnConditions.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnConditions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConditions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConditions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConditions.Image = CType(resources.GetObject("btnConditions.Image"), System.Drawing.Image)
        Me.btnConditions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConditions.Location = New System.Drawing.Point(4, 385)
        Me.btnConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConditions.Name = "btnConditions"
        Me.btnConditions.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnConditions.Size = New System.Drawing.Size(155, 28)
        Me.btnConditions.Style = resources.GetString("btnConditions.Style")
        Me.btnConditions.TabIndex = 7
        Me.btnConditions.Text = "Conditions"
        Me.btnConditions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnConditions.UseCompatibleTextRendering = True
        Me.btnConditions.UseVisualStyleBackColor = False
        '
        'btnWallpaper
        '
        Me.btnWallpaper.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnWallpaper.BackColor = System.Drawing.Color.Transparent
        Me.btnWallpaper.BackgroundImage = CType(resources.GetObject("btnWallpaper.BackgroundImage"), System.Drawing.Image)
        Me.btnWallpaper.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWallpaper.FlatAppearance.BorderSize = 0
        Me.btnWallpaper.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnWallpaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWallpaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWallpaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWallpaper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnWallpaper.Image = CType(resources.GetObject("btnWallpaper.Image"), System.Drawing.Image)
        Me.btnWallpaper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWallpaper.Location = New System.Drawing.Point(4, 39)
        Me.btnWallpaper.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWallpaper.Name = "btnWallpaper"
        Me.btnWallpaper.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnWallpaper.Size = New System.Drawing.Size(155, 28)
        Me.btnWallpaper.Style = resources.GetString("btnWallpaper.Style")
        Me.btnWallpaper.TabIndex = 3
        Me.btnWallpaper.Text = "Wallpaper"
        Me.btnWallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnWallpaper.UseCompatibleTextRendering = True
        Me.btnWallpaper.UseVisualStyleBackColor = False
        '
        'btnScreen
        '
        Me.btnScreen.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnScreen.BackColor = System.Drawing.Color.Transparent
        Me.btnScreen.BackgroundImage = CType(resources.GetObject("btnScreen.BackgroundImage"), System.Drawing.Image)
        Me.btnScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnScreen.FlatAppearance.BorderSize = 0
        Me.btnScreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnScreen.Image = CType(resources.GetObject("btnScreen.Image"), System.Drawing.Image)
        Me.btnScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScreen.Location = New System.Drawing.Point(4, 75)
        Me.btnScreen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnScreen.Name = "btnScreen"
        Me.btnScreen.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnScreen.Size = New System.Drawing.Size(155, 28)
        Me.btnScreen.Style = resources.GetString("btnScreen.Style")
        Me.btnScreen.TabIndex = 4
        Me.btnScreen.Text = "Screen"
        Me.btnScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnScreen.UseCompatibleTextRendering = True
        Me.btnScreen.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(167, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Get the color from the wallpaper"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'btnTemperature
        '
        Me.btnTemperature.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnTemperature.BackColor = System.Drawing.Color.Transparent
        Me.btnTemperature.BackgroundImage = CType(resources.GetObject("btnTemperature.BackgroundImage"), System.Drawing.Image)
        Me.btnTemperature.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTemperature.FlatAppearance.BorderSize = 0
        Me.btnTemperature.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnTemperature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTemperature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTemperature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTemperature.Image = CType(resources.GetObject("btnTemperature.Image"), System.Drawing.Image)
        Me.btnTemperature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTemperature.Location = New System.Drawing.Point(4, 469)
        Me.btnTemperature.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTemperature.Name = "btnTemperature"
        Me.btnTemperature.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnTemperature.Size = New System.Drawing.Size(155, 28)
        Me.btnTemperature.Style = resources.GetString("btnTemperature.Style")
        Me.btnTemperature.TabIndex = 8
        Me.btnTemperature.Text = "Temperature"
        Me.btnTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTemperature.UseCompatibleTextRendering = True
        Me.btnTemperature.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(167, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 20)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Get the color from the current screen"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'btnProgramIcon
        '
        Me.btnProgramIcon.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnProgramIcon.BackColor = System.Drawing.Color.Transparent
        Me.btnProgramIcon.BackgroundImage = CType(resources.GetObject("btnProgramIcon.BackgroundImage"), System.Drawing.Image)
        Me.btnProgramIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProgramIcon.FlatAppearance.BorderSize = 0
        Me.btnProgramIcon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnProgramIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnProgramIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnProgramIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgramIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProgramIcon.Image = CType(resources.GetObject("btnProgramIcon.Image"), System.Drawing.Image)
        Me.btnProgramIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgramIcon.Location = New System.Drawing.Point(4, 111)
        Me.btnProgramIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProgramIcon.Name = "btnProgramIcon"
        Me.btnProgramIcon.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnProgramIcon.Size = New System.Drawing.Size(155, 28)
        Me.btnProgramIcon.Style = resources.GetString("btnProgramIcon.Style")
        Me.btnProgramIcon.TabIndex = 5
        Me.btnProgramIcon.Text = "Program Icon"
        Me.btnProgramIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProgramIcon.UseCompatibleTextRendering = True
        Me.btnProgramIcon.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 577)
        Me.Panel1.TabIndex = 17
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1017, 577)
        Me.Controls.Add(Me.btnPreviewAero)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DoubleBufferedPanel1)
        Me.Controls.Add(Me.tbAdjustAero)
        Me.Controls.Add(Me.tbSettings)
        Me.Controls.Add(Me.tbAbout)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Chameleon 6"
        Me.cmsMain.ResumeLayout(False)
        Me.DoubleBufferedPanel1.ResumeLayout(False)
        Me.DoubleBufferedPanel1.PerformLayout()
        Me.StylizedPanel9.ResumeLayout(False)
        Me.pnlCursorY.ResumeLayout(False)
        Me.pnlCursorY.PerformLayout()
        Me.StylizedPanel8.ResumeLayout(False)
        Me.pnlCursorX.ResumeLayout(False)
        Me.pnlCursorX.PerformLayout()
        Me.StylizedPanel5.ResumeLayout(False)
        Me.pnlTime.ResumeLayout(False)
        Me.pnlTime.PerformLayout()
        Me.StylizedPanel4.ResumeLayout(False)
        Me.pnlBattery.ResumeLayout(False)
        Me.pnlBattery.PerformLayout()
        Me.StylizedPanel7.ResumeLayout(False)
        Me.pnlWindSpeed.ResumeLayout(False)
        Me.pnlWindSpeed.PerformLayout()
        Me.StylizedPanel6.ResumeLayout(False)
        Me.pnlHumidity.ResumeLayout(False)
        Me.pnlHumidity.PerformLayout()
        Me.StylizedPanel3.ResumeLayout(False)
        Me.pnlTemperature.ResumeLayout(False)
        Me.pnlTemperature.PerformLayout()
        Me.StylizedPanel1.ResumeLayout(False)
        Me.pnlConditions.ResumeLayout(False)
        Me.pnlConditions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Tundra.StylizedButton
    Friend WithEvents tbAbout As Tundra.StylizedButton
    Friend WithEvents tbSettings As Tundra.StylizedButton
    Friend WithEvents tbAdjustAero As Tundra.StylizedButton
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents tmrWeather As System.Windows.Forms.Timer
    Friend WithEvents niMain As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdjustAeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents btnTemperature As Tundra.StylizedRadioButton
    Friend WithEvents btnConditions As Tundra.StylizedRadioButton
    Friend WithEvents btnRandom As Tundra.StylizedRadioButton
    Friend WithEvents btnProgramIcon As Tundra.StylizedRadioButton
    Friend WithEvents btnScreen As Tundra.StylizedRadioButton
    Friend WithEvents btnWallpaper As Tundra.StylizedRadioButton
    Friend WithEvents btnNone As Tundra.StylizedRadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTemperature As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btnLessthan50 As Tundra.StylizedColorButton
    Friend WithEvents btn50to40 As Tundra.StylizedColorButton
    Friend WithEvents btn39to30 As Tundra.StylizedColorButton
    Friend WithEvents btn29to20 As Tundra.StylizedColorButton
    Friend WithEvents btn19to10 As Tundra.StylizedColorButton
    Friend WithEvents btn9to1 As Tundra.StylizedColorButton
    Friend WithEvents btn0 As Tundra.StylizedColorButton
    Friend WithEvents btn1to9 As Tundra.StylizedColorButton
    Friend WithEvents btn10to19 As Tundra.StylizedColorButton
    Friend WithEvents btn20to29 As Tundra.StylizedColorButton
    Friend WithEvents btn30to39 As Tundra.StylizedColorButton
    Friend WithEvents btn40to49 As Tundra.StylizedColorButton
    Friend WithEvents btn50to59 As Tundra.StylizedColorButton
    Friend WithEvents btn60to69 As Tundra.StylizedColorButton
    Friend WithEvents btn70to79 As Tundra.StylizedColorButton
    Friend WithEvents btn80to89 As Tundra.StylizedColorButton
    Friend WithEvents btn90to99 As Tundra.StylizedColorButton
    Friend WithEvents btn100to110 As Tundra.StylizedColorButton
    Friend WithEvents btnMorethan110 As Tundra.StylizedColorButton
    Friend WithEvents pnlConditions As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btnClear As Tundra.StylizedColorButton
    Friend WithEvents btnSunny As Tundra.StylizedColorButton
    Friend WithEvents btnFair As Tundra.StylizedColorButton
    Friend WithEvents btnCloudy As Tundra.StylizedColorButton
    Friend WithEvents btnPartlyCloudy As Tundra.StylizedColorButton
    Friend WithEvents btnMostlyCloudy As Tundra.StylizedColorButton
    Friend WithEvents btnBlustery As Tundra.StylizedColorButton
    Friend WithEvents btnWindy As Tundra.StylizedColorButton
    Friend WithEvents btnHot As Tundra.StylizedColorButton
    Friend WithEvents btnCold As Tundra.StylizedColorButton
    Friend WithEvents btnTornado As Tundra.StylizedColorButton
    Friend WithEvents btnTropicalStorm As Tundra.StylizedColorButton
    Friend WithEvents btnHurricane As Tundra.StylizedColorButton
    Friend WithEvents btnSevereThunderstorm As Tundra.StylizedColorButton
    Friend WithEvents btnThunderstorms As Tundra.StylizedColorButton
    Friend WithEvents btnHail As Tundra.StylizedColorButton
    Friend WithEvents btnSleet As Tundra.StylizedColorButton
    Friend WithEvents btnDrizzle As Tundra.StylizedColorButton
    Friend WithEvents btnShowers As Tundra.StylizedColorButton
    Friend WithEvents btnThundershowers As Tundra.StylizedColorButton
    Friend WithEvents btnIsolatedThundershowers As Tundra.StylizedColorButton
    Friend WithEvents btnIsolatedThunderstorms As Tundra.StylizedColorButton
    Friend WithEvents btnScatteredThunderstorms As Tundra.StylizedColorButton
    Friend WithEvents btnScatteredShowers As Tundra.StylizedColorButton
    Friend WithEvents btnMixedRainandHail As Tundra.StylizedColorButton
    Friend WithEvents btnMixedRainandSleet As Tundra.StylizedColorButton
    Friend WithEvents btnMixedRainandSnow As Tundra.StylizedColorButton
    Friend WithEvents btnMixedSnowandSleet As Tundra.StylizedColorButton
    Friend WithEvents btnFreezingDrizzle As Tundra.StylizedColorButton
    Friend WithEvents btnFreezingRain As Tundra.StylizedColorButton
    Friend WithEvents btnSnowFlurries As Tundra.StylizedColorButton
    Friend WithEvents btnSnow As Tundra.StylizedColorButton
    Friend WithEvents btnLightSnowShowers As Tundra.StylizedColorButton
    Friend WithEvents btnScatteredSnowShowers As Tundra.StylizedColorButton
    Friend WithEvents btnBlowingSnow As Tundra.StylizedColorButton
    Friend WithEvents btnHeavySnow As Tundra.StylizedColorButton
    Friend WithEvents btnSnowShowers As Tundra.StylizedColorButton
    Friend WithEvents btnDust As Tundra.StylizedColorButton
    Friend WithEvents btnFog As Tundra.StylizedColorButton
    Friend WithEvents btnHaze As Tundra.StylizedColorButton
    Friend WithEvents btnSmoke As Tundra.StylizedColorButton
    Friend WithEvents btnUnavailable As Tundra.StylizedColorButton
    Friend WithEvents btnWindSpeed As Tundra.StylizedRadioButton
    Friend WithEvents pnlWindSpeed As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btn0MPH As Tundra.StylizedColorButton
    Friend WithEvents btn1to9MPH As Tundra.StylizedColorButton
    Friend WithEvents btn10to19MPH As Tundra.StylizedColorButton
    Friend WithEvents btn20to29MPH As Tundra.StylizedColorButton
    Friend WithEvents btn30to39MPH As Tundra.StylizedColorButton
    Friend WithEvents btn40to49MPH As Tundra.StylizedColorButton
    Friend WithEvents btn50to59MPH As Tundra.StylizedColorButton
    Friend WithEvents btn60to69MPH As Tundra.StylizedColorButton
    Friend WithEvents btn70to79MPH As Tundra.StylizedColorButton
    Friend WithEvents btn80to89MPH As Tundra.StylizedColorButton
    Friend WithEvents btn90to99MPH As Tundra.StylizedColorButton
    Friend WithEvents btn100to110MPH As Tundra.StylizedColorButton
    Friend WithEvents btnMoreThan110MPH As Tundra.StylizedColorButton
    Friend WithEvents btnHumidity As Tundra.StylizedRadioButton
    Friend WithEvents pnlHumidity As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btn0PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn1to9PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn10to19PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn20to29PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn30to39PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn40to49PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn50to59PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn60to69PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn70to79PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn80to89PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn90to99PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents btn100PercentHumidity As Tundra.StylizedColorButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlTime As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btn12AM As Tundra.StylizedColorButton
    Friend WithEvents btn1AM As Tundra.StylizedColorButton
    Friend WithEvents btn2AM As Tundra.StylizedColorButton
    Friend WithEvents btn3AM As Tundra.StylizedColorButton
    Friend WithEvents btn4AM As Tundra.StylizedColorButton
    Friend WithEvents btn5AM As Tundra.StylizedColorButton
    Friend WithEvents btn6AM As Tundra.StylizedColorButton
    Friend WithEvents btn7AM As Tundra.StylizedColorButton
    Friend WithEvents btn8AM As Tundra.StylizedColorButton
    Friend WithEvents btn9AM As Tundra.StylizedColorButton
    Friend WithEvents btn10AM As Tundra.StylizedColorButton
    Friend WithEvents btn11AM As Tundra.StylizedColorButton
    Friend WithEvents btn12PM As Tundra.StylizedColorButton
    Friend WithEvents btn1PM As Tundra.StylizedColorButton
    Friend WithEvents btn2PM As Tundra.StylizedColorButton
    Friend WithEvents btn3PM As Tundra.StylizedColorButton
    Friend WithEvents btn4PM As Tundra.StylizedColorButton
    Friend WithEvents btn5PM As Tundra.StylizedColorButton
    Friend WithEvents btn6PM As Tundra.StylizedColorButton
    Friend WithEvents btn7PM As Tundra.StylizedColorButton
    Friend WithEvents btn8PM As Tundra.StylizedColorButton
    Friend WithEvents btn9PM As Tundra.StylizedColorButton
    Friend WithEvents btn10PM As Tundra.StylizedColorButton
    Friend WithEvents btn11PM As Tundra.StylizedColorButton
    Friend WithEvents pnlBattery As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btn0Percent As Tundra.StylizedColorButton
    Friend WithEvents btn1to9Percent As Tundra.StylizedColorButton
    Friend WithEvents btn10to19Percent As Tundra.StylizedColorButton
    Friend WithEvents btn20to29Percent As Tundra.StylizedColorButton
    Friend WithEvents btn30to39Percent As Tundra.StylizedColorButton
    Friend WithEvents btn40to49Percent As Tundra.StylizedColorButton
    Friend WithEvents btn50to59Percent As Tundra.StylizedColorButton
    Friend WithEvents btn60to69Percent As Tundra.StylizedColorButton
    Friend WithEvents btn70to79Percent As Tundra.StylizedColorButton
    Friend WithEvents btn80to89Percent As Tundra.StylizedColorButton
    Friend WithEvents btn90to99Percent As Tundra.StylizedColorButton
    Friend WithEvents btn100Percent As Tundra.StylizedColorButton
    Friend WithEvents btnBattery As Tundra.StylizedRadioButton
    Friend WithEvents btnTime As Tundra.StylizedRadioButton
    Friend WithEvents tmrWebcam As System.Windows.Forms.Timer
    Friend WithEvents btnWebcam As Tundra.StylizedRadioButton
    Friend WithEvents pnlCursorY As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btn0percenty As Tundra.StylizedColorButton
    Friend WithEvents btn1to9percenty As Tundra.StylizedColorButton
    Friend WithEvents btn10to19percenty As Tundra.StylizedColorButton
    Friend WithEvents btn20to29percenty As Tundra.StylizedColorButton
    Friend WithEvents btn30to39percenty As Tundra.StylizedColorButton
    Friend WithEvents btn40to49percenty As Tundra.StylizedColorButton
    Friend WithEvents btn50to59percenty As Tundra.StylizedColorButton
    Friend WithEvents btn60to69percenty As Tundra.StylizedColorButton
    Friend WithEvents btn70to79percenty As Tundra.StylizedColorButton
    Friend WithEvents btn80to89percenty As Tundra.StylizedColorButton
    Friend WithEvents btn90to99percenty As Tundra.StylizedColorButton
    Friend WithEvents btn100percenty As Tundra.StylizedColorButton
    Friend WithEvents btnCursorY As Tundra.StylizedRadioButton
    Friend WithEvents pnlCursorX As Tundra.DoubleBufferedFlowLayoutPanel
    Friend WithEvents btn0percentx As Tundra.StylizedColorButton
    Friend WithEvents btn1to9percentx As Tundra.StylizedColorButton
    Friend WithEvents btn10to19percentx As Tundra.StylizedColorButton
    Friend WithEvents btn20to29percentx As Tundra.StylizedColorButton
    Friend WithEvents btn30to39percentx As Tundra.StylizedColorButton
    Friend WithEvents btn40to49percentx As Tundra.StylizedColorButton
    Friend WithEvents btn50to59percentx As Tundra.StylizedColorButton
    Friend WithEvents btn60to69percentx As Tundra.StylizedColorButton
    Friend WithEvents btn70to79percentx As Tundra.StylizedColorButton
    Friend WithEvents btn80to89percentx As Tundra.StylizedColorButton
    Friend WithEvents btn90to99percentx As Tundra.StylizedColorButton
    Friend WithEvents btn100percentx As Tundra.StylizedColorButton
    Friend WithEvents btnCursorX As Tundra.StylizedRadioButton
    Friend WithEvents DoubleBufferedPanel1 As Tundra.DoubleBufferedPanel
    Friend WithEvents StylizedPanel9 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel8 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel5 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel4 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel7 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel6 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel3 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents btnPreviewAero As Tundra.StylizedButton
    Friend WithEvents PreviewAeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
