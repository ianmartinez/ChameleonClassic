<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSettings))
        Me.btnOK = New Tundra.StylizedButton()
        Me.btnCancel = New Tundra.StylizedButton()
        Me.StylizedPanel2 = New Tundra.StylizedPanel()
        Me.lblConditions = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.btnTest = New Tundra.StylizedButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudWeatherInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudTimerInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlBack = New Tundra.DoubleBufferedPanel()
        Me.btnSave = New Tundra.StylizedButton()
        Me.btnOpen = New Tundra.StylizedButton()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.btnEraseAll = New Tundra.StylizedButton()
        Me.StylizedPanel2.SuspendLayout()
        CType(Me.nudWeatherInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimerInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(271, 252)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnOK.Size = New System.Drawing.Size(101, 28)
        Me.btnOK.Style = resources.GetString("btnOK.Style")
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseCompatibleTextRendering = True
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(380, 252)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(101, 28)
        Me.btnCancel.Style = resources.GetString("btnCancel.Style")
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseCompatibleTextRendering = True
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'StylizedPanel2
        '
        Me.StylizedPanel2.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel2.Controls.Add(Me.lblConditions)
        Me.StylizedPanel2.Controls.Add(Me.lblTemperature)
        Me.StylizedPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StylizedPanel2.Location = New System.Drawing.Point(4, 143)
        Me.StylizedPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel2.Name = "StylizedPanel2"
        Me.StylizedPanel2.Size = New System.Drawing.Size(473, 84)
        Me.StylizedPanel2.Style = "Colors=#46626f|#142440|#142440" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|0.3|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Col" & _
    "or=190,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=60,255,255,255" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.StylizedPanel2.TabIndex = 29
        '
        'lblConditions
        '
        Me.lblConditions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConditions.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConditions.Location = New System.Drawing.Point(0, 55)
        Me.lblConditions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConditions.Name = "lblConditions"
        Me.lblConditions.Size = New System.Drawing.Size(473, 29)
        Me.lblConditions.TabIndex = 30
        Me.lblConditions.Text = "It's a cold day in Hell."
        Me.lblConditions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTemperature
        '
        Me.lblTemperature.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTemperature.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.Location = New System.Drawing.Point(0, 0)
        Me.lblTemperature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(473, 55)
        Me.lblTemperature.TabIndex = 29
        Me.lblTemperature.Text = "32 °F"
        Me.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTest
        '
        Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTest.BackColor = System.Drawing.Color.Transparent
        Me.btnTest.BackgroundImage = CType(resources.GetObject("btnTest.BackgroundImage"), System.Drawing.Image)
        Me.btnTest.FlatAppearance.BorderSize = 0
        Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTest.Location = New System.Drawing.Point(376, 108)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnTest.Size = New System.Drawing.Size(101, 28)
        Me.btnTest.Style = resources.GetString("btnTest.Style")
        Me.btnTest.TabIndex = 27
        Me.btnTest.Text = "Test"
        Me.btnTest.UseCompatibleTextRendering = True
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Location:"
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.Color.White
        Me.txtLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLocation.Location = New System.Drawing.Point(76, 111)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(291, 22)
        Me.txtLocation.TabIndex = 25
        Me.txtLocation.Text = "Hell, Michigan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "second(s)"
        '
        'nudWeatherInterval
        '
        Me.nudWeatherInterval.BackColor = System.Drawing.Color.White
        Me.nudWeatherInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nudWeatherInterval.Location = New System.Drawing.Point(172, 79)
        Me.nudWeatherInterval.Margin = New System.Windows.Forms.Padding(4)
        Me.nudWeatherInterval.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudWeatherInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWeatherInterval.Name = "nudWeatherInterval"
        Me.nudWeatherInterval.Size = New System.Drawing.Size(105, 22)
        Me.nudWeatherInterval.TabIndex = 23
        Me.nudWeatherInterval.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Weather refresh interval:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "millisecond(s)"
        '
        'nudTimerInterval
        '
        Me.nudTimerInterval.BackColor = System.Drawing.Color.White
        Me.nudTimerInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nudTimerInterval.Location = New System.Drawing.Point(105, 27)
        Me.nudTimerInterval.Margin = New System.Windows.Forms.Padding(4)
        Me.nudTimerInterval.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudTimerInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTimerInterval.Name = "nudTimerInterval"
        Me.nudTimerInterval.Size = New System.Drawing.Size(102, 22)
        Me.nudTimerInterval.TabIndex = 20
        Me.nudTimerInterval.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Timer interval:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(444, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Weather"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 55)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(33, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Behavior"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlBack
        '
        Me.pnlBack.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBack.Controls.Add(Me.StylizedPanel2)
        Me.pnlBack.Controls.Add(Me.PictureBox1)
        Me.pnlBack.Controls.Add(Me.btnTest)
        Me.pnlBack.Controls.Add(Me.Label1)
        Me.pnlBack.Controls.Add(Me.Label7)
        Me.pnlBack.Controls.Add(Me.PictureBox2)
        Me.pnlBack.Controls.Add(Me.txtLocation)
        Me.pnlBack.Controls.Add(Me.Label2)
        Me.pnlBack.Controls.Add(Me.Label5)
        Me.pnlBack.Controls.Add(Me.Label3)
        Me.pnlBack.Controls.Add(Me.nudWeatherInterval)
        Me.pnlBack.Controls.Add(Me.nudTimerInterval)
        Me.pnlBack.Controls.Add(Me.Label6)
        Me.pnlBack.Controls.Add(Me.Label4)
        Me.pnlBack.Location = New System.Drawing.Point(0, 15)
        Me.pnlBack.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(481, 230)
        Me.pnlBack.TabIndex = 3
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
        Me.btnSave.Location = New System.Drawing.Point(39, 252)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnSave.Size = New System.Drawing.Size(31, 28)
        Me.btnSave.Style = resources.GetString("btnSave.Style")
        Me.btnSave.TabIndex = 6
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
        Me.btnOpen.Location = New System.Drawing.Point(0, 252)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnOpen.Size = New System.Drawing.Size(31, 28)
        Me.btnOpen.Style = resources.GetString("btnOpen.Style")
        Me.btnOpen.TabIndex = 5
        Me.btnOpen.UseCompatibleTextRendering = True
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Zia Files (*.zia)|*.zia"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Zia Files (*.zia)|*.zia"
        '
        'btnEraseAll
        '
        Me.btnEraseAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEraseAll.BackColor = System.Drawing.Color.Transparent
        Me.btnEraseAll.BackgroundImage = CType(resources.GetObject("btnEraseAll.BackgroundImage"), System.Drawing.Image)
        Me.btnEraseAll.FlatAppearance.BorderSize = 0
        Me.btnEraseAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEraseAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEraseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEraseAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEraseAll.Image = CType(resources.GetObject("btnEraseAll.Image"), System.Drawing.Image)
        Me.btnEraseAll.Location = New System.Drawing.Point(78, 252)
        Me.btnEraseAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEraseAll.Name = "btnEraseAll"
        Me.btnEraseAll.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnEraseAll.Size = New System.Drawing.Size(31, 28)
        Me.btnEraseAll.Style = resources.GetString("btnEraseAll.Style")
        Me.btnEraseAll.TabIndex = 7
        Me.btnEraseAll.UseCompatibleTextRendering = True
        Me.btnEraseAll.UseVisualStyleBackColor = False
        '
        'dlgSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(481, 281)
        Me.Controls.Add(Me.btnEraseAll)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.pnlBack)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.StylizedPanel2.ResumeLayout(False)
        CType(Me.nudWeatherInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimerInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBack.ResumeLayout(False)
        Me.pnlBack.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As Tundra.StylizedButton
    Friend WithEvents btnOK As Tundra.StylizedButton
    Friend WithEvents btnTest As Tundra.StylizedButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudWeatherInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudTimerInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StylizedPanel2 As Tundra.StylizedPanel
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents lblConditions As System.Windows.Forms.Label
    Friend WithEvents pnlBack As Tundra.DoubleBufferedPanel
    Friend WithEvents btnSave As Tundra.StylizedButton
    Friend WithEvents btnOpen As Tundra.StylizedButton
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnEraseAll As Tundra.StylizedButton

End Class
