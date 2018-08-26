Imports Tundra.Aero
Imports Microsoft.Win32
Imports Tundra.Appearance
Imports Chameleon.Weather
Imports Chameleon.pWeatherForecast
Imports System.IO
Imports System.Security.Cryptography
Imports Tundra.Common
Imports RegistryUtils
Public Enum AeroMethod
    None
    Wallpaper
    Screen
    ProgramIcon
    Random
    Conditions
    Temperature
    Battery
    CursorX
    CursorY
    Time
    Webcam
    Humidity
    WindSpeed
End Enum

Public Class frmMain
    Dim wf As New WebcamFrame
    Dim AeroMethod As New AeroMethod
    Dim PreviousPosition As New Point
    Dim WallpaperFileMonitor As New FileSystemWatcher
    Dim Loaded As Boolean = False
    Public CityLocation As String = "Hell, Michigan"
    Public WeatherInterval As Integer = 60000
    Public MainInterval As Integer = 500
    Public EraseAll As Boolean = False
    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EraseAll = False Then Theme.SaveSettings(Application.UserAppDataPath & "\Settings.zia")
        Me.Hide()
        wf.DeactivateWebcam()
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function SetProcessDPIAware() As Boolean
    End Function
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        niMain.Visible = False

        If Tundra.Aero.DWMEnabled() = False Then
            MessageBox.Show("Aero is not enabled!")
        End If

        Dim WallpaperRegistryMonitor As New RegistryMonitor(RegistryHive.CurrentUser, "Environment")
        AddHandler WallpaperRegistryMonitor.RegChanged, AddressOf OnWallpaperChanged

        WallpaperFileMonitor.Path = Path.GetDirectoryName(GetWallpaperPath())
        WallpaperFileMonitor.Filter = Path.GetFileName(GetWallpaperPath())
        WallpaperFileMonitor.EnableRaisingEvents = True
        AddHandler WallpaperFileMonitor.Changed, AddressOf OnWallpaperChanged

        Surround(Me, DoubleBufferedPanel1)
        LoadSettings(Application.UserAppDataPath & "\Settings.zia")
        tmrMain.Interval = MainInterval
        tmrWeather.Interval = WeatherInterval
        niMain.Visible = True
        Loaded = True
    End Sub

    Private Sub OnWallpaperChanged(sender As Object, e As EventArgs)
        If AeroMethod = Chameleon.AeroMethod.Wallpaper Then
            SetAeroColorFromWallpaper()
        End If
    End Sub

    Private Sub tbAbout_Click(sender As System.Object, e As System.EventArgs) Handles tbAbout.Click
        dlgAbout.ShowDialog()
    End Sub

    Private Sub tbSettings_Click(sender As System.Object, e As System.EventArgs) Handles tbSettings.Click
        dlgSettings.ShowDialog()
    End Sub

    Private Sub frmMain_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate

    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub tbAdjustAero_Click(sender As System.Object, e As System.EventArgs) Handles tbAdjustAero.Click
        dlgAdjustAero.ShowDialog()
    End Sub

    Private Sub tmrMain_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMain.Tick
        If Not Me.WindowState = FormWindowState.Minimized Then tmrMain.Stop()
        If AeroMethod = Chameleon.AeroMethod.None Then
            Exit Sub
        ElseIf AeroMethod = Chameleon.AeroMethod.Battery Then
            Dim CurrentBattery As PowerStatus = SystemInformation.PowerStatus
            Dim PercentFull As Single = CurrentBattery.BatteryLifePercent * 100
            Select Case PercentFull
                Case 0
                    SetAllColors(Me.btn0Percent.Color)
                Case 1 To 9
                    SetAllColors(Me.btn1to9Percent.Color)
                Case 10 To 19
                    SetAllColors(Me.btn10to19Percent.Color)
                Case 20 To 29
                    SetAllColors(Me.btn20to29Percent.Color)
                Case 30 To 39
                    SetAllColors(Me.btn30to39Percent.Color)
                Case 40 To 49
                    SetAllColors(Me.btn40to49Percent.Color)
                Case 50 To 59
                    SetAllColors(Me.btn50to59Percent.Color)
                Case 60 To 69
                    SetAllColors(Me.btn60to69Percent.Color)
                Case 70 To 79
                    SetAllColors(Me.btn70to79Percent.Color)
                Case 80 To 89
                    SetAllColors(Me.btn80to89Percent.Color)
                Case 90 To 99
                    SetAllColors(Me.btn90to99Percent.Color)
                Case 100
                    SetAllColors(Me.btn100Percent.Color)
                Case Else
                    SetAllColors(Me.btn100Percent.Color)
            End Select
        ElseIf AeroMethod = Chameleon.AeroMethod.CursorX Then
            Dim PercentX As Single = Cursor.Position.X * 100 / My.Computer.Screen.WorkingArea.Width
            Select Case PercentX
                Case 0
                    SetAllColors(Me.btn0percentx.Color)
                Case 1 To 9
                    SetAllColors(Me.btn1to9percentx.Color)
                Case 10 To 19
                    SetAllColors(Me.btn10to19percentx.Color)
                Case 20 To 29
                    SetAllColors(Me.btn20to29percentx.Color)
                Case 30 To 39
                    SetAllColors(Me.btn30to39percentx.Color)
                Case 40 To 49
                    SetAllColors(Me.btn40to49percentx.Color)
                Case 50 To 59
                    SetAllColors(Me.btn50to59percentx.Color)
                Case 60 To 69
                    SetAllColors(Me.btn60to69percentx.Color)
                Case 70 To 79
                    SetAllColors(Me.btn70to79percentx.Color)
                Case 80 To 89
                    SetAllColors(Me.btn80to89percentx.Color)
                Case 90 To 99
                    SetAllColors(Me.btn90to99percentx.Color)
                Case 100
                    SetAllColors(Me.btn100percentx.Color)
                Case Else

            End Select
        ElseIf AeroMethod = Chameleon.AeroMethod.CursorY Then
            Dim PercentY As Single = Cursor.Position.Y * 100 / My.Computer.Screen.WorkingArea.Height
            Select Case PercentY
                Case 0
                    SetAllColors(Me.btn0percenty.Color)
                Case 1 To 9
                    SetAllColors(Me.btn1to9percenty.Color)
                Case 10 To 19
                    SetAllColors(Me.btn10to19percenty.Color)
                Case 20 To 29
                    SetAllColors(Me.btn20to29percenty.Color)
                Case 30 To 39
                    SetAllColors(Me.btn30to39percenty.Color)
                Case 40 To 49
                    SetAllColors(Me.btn40to49percenty.Color)
                Case 50 To 59
                    SetAllColors(Me.btn50to59percenty.Color)
                Case 60 To 69
                    SetAllColors(Me.btn60to69percenty.Color)
                Case 70 To 79
                    SetAllColors(Me.btn70to79percenty.Color)
                Case 80 To 89
                    SetAllColors(Me.btn80to89percenty.Color)
                Case 90 To 99
                    SetAllColors(Me.btn90to99percenty.Color)
                Case 100
                    SetAllColors(Me.btn100percenty.Color)
                Case Else

            End Select
        ElseIf AeroMethod = Chameleon.AeroMethod.ProgramIcon Then
            SetAeroColorFromCurrentWindowIcon()
        ElseIf AeroMethod = Chameleon.AeroMethod.Random Then
            Dim generator As New Random
            SetAllColors(Color.FromArgb(generator.Next(0, 255), generator.Next(0, 255), generator.Next(0, 255)))
        ElseIf AeroMethod = Chameleon.AeroMethod.Screen Then
            SetAeroColorFromImage(TakeScreenshot())
        ElseIf AeroMethod = Chameleon.AeroMethod.Time Then
            Dim CurrentTime As DateTime = Date.Now
            Dim CurrentTimeString As String = CurrentTime.ToString("h tt")
            If CurrentTimeString = "12 AM" Then
                SetAllColors(Me.btn12AM.Color)
            ElseIf CurrentTimeString = "1 AM" Then
                SetAllColors(Me.btn1AM.Color)
            ElseIf CurrentTimeString = "2 AM" Then
                SetAllColors(Me.btn2AM.Color)
            ElseIf CurrentTimeString = "3 AM" Then
                SetAllColors(Me.btn3AM.Color)
            ElseIf CurrentTimeString = "4 AM" Then
                SetAllColors(Me.btn4AM.Color)
            ElseIf CurrentTimeString = "5 AM" Then
                SetAllColors(Me.btn5AM.Color)
            ElseIf CurrentTimeString = "6 AM" Then
                SetAllColors(Me.btn6AM.Color)
            ElseIf CurrentTimeString = "7 AM" Then
                SetAllColors(Me.btn7AM.Color)
            ElseIf CurrentTimeString = "8 AM" Then
                SetAllColors(Me.btn8AM.Color)
            ElseIf CurrentTimeString = "9 AM" Then
                SetAllColors(Me.btn9AM.Color)
            ElseIf CurrentTimeString = "10 AM" Then
                SetAllColors(Me.btn10AM.Color)
            ElseIf CurrentTimeString = "11 AM" Then
                SetAllColors(Me.btn11AM.Color)
            ElseIf CurrentTimeString = "12 PM" Then
                SetAllColors(Me.btn12PM.Color)
            ElseIf CurrentTimeString = "1 PM" Then
                SetAllColors(Me.btn1PM.Color)
            ElseIf CurrentTimeString = "2 PM" Then
                SetAllColors(Me.btn2PM.Color)
            ElseIf CurrentTimeString = "3 PM" Then
                SetAllColors(Me.btn3PM.Color)
            ElseIf CurrentTimeString = "4 PM" Then
                SetAllColors(Me.btn4PM.Color)
            ElseIf CurrentTimeString = "5 PM" Then
                SetAllColors(Me.btn5PM.Color)
            ElseIf CurrentTimeString = "6 PM" Then
                SetAllColors(Me.btn6PM.Color)
            ElseIf CurrentTimeString = "7 PM" Then
                SetAllColors(Me.btn7PM.Color)
            ElseIf CurrentTimeString = "8 PM" Then
                SetAllColors(Me.btn8PM.Color)
            ElseIf CurrentTimeString = "9 PM" Then
                SetAllColors(Me.btn9PM.Color)
            ElseIf CurrentTimeString = "10 PM" Then
                SetAllColors(Me.btn10PM.Color)
            ElseIf CurrentTimeString = "11 PM" Then
                SetAllColors(Me.btn11PM.Color)
            End If
        ElseIf AeroMethod = Chameleon.AeroMethod.Wallpaper Then
            If Not WallpaperFileMonitor.Path = Path.GetDirectoryName(GetWallpaperPath()) AndAlso WallpaperFileMonitor.Filter = Path.GetFileName(GetWallpaperPath()) Then
                WallpaperFileMonitor.Path = Path.GetDirectoryName(GetWallpaperPath())
                WallpaperFileMonitor.Filter = Path.GetFileName(GetWallpaperPath())
            End If
        Else
            Exit Sub
        End If
    End Sub

    Public Sub SetAeroColorFromWallpaper()
        On Error Resume Next
        SetAeroColorFromImage(GetWallpaper())
    End Sub
    Public Sub SetAeroColorFromCurrentWindowIcon()
        On Error Resume Next
        Dim CurrentIcon As Icon = GetAppIcon(GetForegroundWindow)
        SetAeroColorFromImage(CurrentIcon.ToBitmap, True)
    End Sub

    Public Sub SetAeroColorFromImage(ByVal Source As Image, Optional ByVal Pixel As Boolean = False)
        On Error Resume Next
        If Source Is Nothing Then Exit Sub
        If Pixel = True Then
            SetAllColors(GetAveragePixel(Source))
        Else
            SetAllColors(GetAverageColor(Source))
        End If

    End Sub


    Private Sub tmrWeather_Tick(sender As System.Object, e As System.EventArgs) Handles tmrWeather.Tick
        If Not Me.WindowState = FormWindowState.Minimized Then tmrMain.Stop()
        If AeroMethod = Chameleon.AeroMethod.Conditions Then
            Try
                Dim CurrentWeather As New pWeatherForecast(CityLocation, temperatureUnit.Fahrenheit)
                Dim CurrentConditions As WeatherCondition = GetConditions(CurrentWeather)
                niMain.BalloonTipText = "Chameleon is still running in the background." & Environment.NewLine & Weather.GetConditionsWithDescription(Weather.GetConditions(CurrentWeather))
                If CurrentConditions.Value = "Tornado" Then
                    SetAllColors(Me.btnTornado.Color)
                ElseIf CurrentConditions.Value = "Tropical Storm" Then
                    SetAllColors(Me.btnTropicalStorm.Color)
                ElseIf CurrentConditions.Value = "Hurricane" Then
                    SetAllColors(Me.btnHurricane.Color)
                ElseIf CurrentConditions.Value = "Severe Thunderstorm" Then
                    SetAllColors(Me.btnSevereThunderstorm.Color)
                ElseIf CurrentConditions.Value = "Thunderstorm" Then
                    SetAllColors(Me.btnThunderstorms.Color)
                ElseIf CurrentConditions.Value = "Mixed Rain and Snow" Then
                    SetAllColors(Me.btnMixedRainandSnow.Color)
                ElseIf CurrentConditions.Value = "Mixed Rain and Sleet" Then
                    SetAllColors(Me.btnMixedRainandSleet.Color)
                ElseIf CurrentConditions.Value = "Mixed Snow and Sleet" Then
                    SetAllColors(Me.btnMixedSnowandSleet.Color)
                ElseIf CurrentConditions.Value = "Freezing Drizzle" Then
                    SetAllColors(Me.btnFreezingDrizzle.Color)
                ElseIf CurrentConditions.Value = "Drizzling" Then
                    SetAllColors(Me.btnDrizzle.Color)
                ElseIf CurrentConditions.Value = "Freezing Rain" Then
                    SetAllColors(Me.btnFreezingRain.Color)
                ElseIf CurrentConditions.Value = "Showers" Then
                    SetAllColors(Me.btnShowers.Color)
                ElseIf CurrentConditions.Value = "Snow Flurries" Then
                    SetAllColors(Me.btnSnowFlurries.Color)
                ElseIf CurrentConditions.Value = "Light Snow Showers" Then
                    SetAllColors(Me.btnLightSnowShowers.Color)
                ElseIf CurrentConditions.Value = "Blowing Snow" Then
                    SetAllColors(Me.btnBlowingSnow.Color)
                ElseIf CurrentConditions.Value = "Snow" Then
                    SetAllColors(Me.btnSnow.Color)
                ElseIf CurrentConditions.Value = "Hail" Then
                    SetAllColors(Me.btnHail.Color)
                ElseIf CurrentConditions.Value = "Sleet" Then
                    SetAllColors(Me.btnSleet.Color)
                ElseIf CurrentConditions.Value = "Dusty" Then
                    SetAllColors(Me.btnDust.Color)
                ElseIf CurrentConditions.Value = "Foggy" Then
                    SetAllColors(Me.btnFog.Color)
                ElseIf CurrentConditions.Value = "Hazy" Then
                    SetAllColors(Me.btnHaze.Color)
                ElseIf CurrentConditions.Value = "Smoky" Then
                    SetAllColors(Me.btnSmoke.Color)
                ElseIf CurrentConditions.Value = "Blustery" Then
                    SetAllColors(Me.btnBlustery.Color)
                ElseIf CurrentConditions.Value = "Windy" Then
                    SetAllColors(Me.btnWindy.Color)
                ElseIf CurrentConditions.Value = "Cold" Then
                    SetAllColors(Me.btnCold.Color)
                ElseIf CurrentConditions.Value = "Cloudy" Then
                    SetAllColors(Me.btnCloudy.Color)
                ElseIf CurrentConditions.Value = "Mostly Cloudy" Then
                    SetAllColors(Me.btnMostlyCloudy.Color)
                ElseIf CurrentConditions.Value = "Partly Cloudy" Then
                    SetAllColors(Me.btnPartlyCloudy.Color)
                ElseIf CurrentConditions.Value = "Clear" Then
                    SetAllColors(Me.btnClear.Color)
                ElseIf CurrentConditions.Value = "Sunny" Then
                    SetAllColors(Me.btnSunny.Color)
                ElseIf CurrentConditions.Value = "Fair" Then
                    SetAllColors(Me.btnFair.Color)
                ElseIf CurrentConditions.Value = "Mixed Rain and Hail" Then
                    SetAllColors(Me.btnMixedRainandHail.Color)
                ElseIf CurrentConditions.Value = "Hot" Then
                    SetAllColors(Me.btnHot.Color)
                ElseIf CurrentConditions.Value = "Isolated Thunderstorms" Then
                    SetAllColors(Me.btnIsolatedThunderstorms.Color)
                ElseIf CurrentConditions.Value = "Scattered Thunderstorms" Then
                    SetAllColors(Me.btnScatteredThunderstorms.Color)
                ElseIf CurrentConditions.Value = "Scattered Showers" Then
                    SetAllColors(Me.btnScatteredShowers.Color)
                ElseIf CurrentConditions.Value = "Heavy Snow" Then
                    SetAllColors(Me.btnHeavySnow.Color)
                ElseIf CurrentConditions.Value = "Scattered Snow Showers" Then
                    SetAllColors(Me.btnScatteredSnowShowers.Color)
                ElseIf CurrentConditions.Value = "Thundershowers" Then
                    SetAllColors(Me.btnThundershowers.Color)
                ElseIf CurrentConditions.Value = "Snow Showers" Then
                    SetAllColors(Me.btnSnowShowers.Color)
                ElseIf CurrentConditions.Value = "Isolated Thundershowers" Then
                    SetAllColors(Me.btnIsolatedThundershowers.Color)
                ElseIf CurrentConditions.Value = "Unavailable" Then
                    SetAllColors(Me.btnUnavailable.Color)
                Else
                    SetAllColors(Me.btnUnavailable.Color)
                End If
            Catch ex As Exception
            End Try
        ElseIf AeroMethod = Chameleon.AeroMethod.Temperature Then
            Try
                Dim CurrentWeather As New pWeatherForecast(CityLocation, temperatureUnit.Fahrenheit)
                niMain.BalloonTipText = "Chameleon is still running in the background." & Environment.NewLine & CurrentWeather.rss.channel.item.condition.temp & "°F"
                Select Case CurrentWeather.rss.channel.item.condition.temp
                    Case Is < -50
                        SetAllColors(Me.btnLessthan50.Color)
                    Case -50 To -40
                        SetAllColors(Me.btn50to40.Color)
                    Case -39 To -30
                        SetAllColors(Me.btn39to30.Color)
                    Case -29 To -20
                        SetAllColors(Me.btn29to20.Color)
                    Case -19 To -10
                        SetAllColors(Me.btn19to10.Color)
                    Case -9 To -1
                        SetAllColors(Me.btn9to1.Color)
                    Case 0
                        SetAllColors(Me.btn0.Color)
                    Case 1 To 9
                        SetAllColors(Me.btn1to9.Color)
                    Case 10 To 19
                        SetAllColors(Me.btn10to19.Color)
                    Case 20 To 29
                        SetAllColors(Me.btn20to29.Color)
                    Case 30 To 39
                        SetAllColors(Me.btn30to39.Color)
                    Case 40 To 49
                        SetAllColors(Me.btn40to49.Color)
                    Case 50 To 59
                        SetAllColors(Me.btn50to59.Color)
                    Case 60 To 69
                        SetAllColors(Me.btn60to69.Color)
                    Case 70 To 79
                        SetAllColors(Me.btn70to79.Color)
                    Case 80 To 89
                        SetAllColors(Me.btn80to89.Color)
                    Case 90 To 99
                        SetAllColors(Me.btn90to99.Color)
                    Case 100 To 110
                        SetAllColors(Me.btn100to110.Color)
                    Case Is > 100
                        SetAllColors(Me.btnMorethan110.Color)
                    Case Else
                        SetAllColors(Me.btn70to79.Color)
                End Select
            Catch ex As Exception
            End Try
        ElseIf AeroMethod = Chameleon.AeroMethod.WindSpeed Then
            Try
                Dim CurrentWeather As New pWeatherForecast(CityLocation, temperatureUnit.Fahrenheit)
                niMain.BalloonTipText = "Chameleon is still running in the background." & Environment.NewLine & CurrentWeather.rss.channel.wind.speed & " MPH Wind Speed"
                Select Case CurrentWeather.rss.channel.wind.speed
                    Case 0
                        SetAllColors(Me.btn0MPH.Color)
                    Case 1 To 9
                        SetAllColors(Me.btn1to9MPH.Color)
                    Case 10 To 19
                        SetAllColors(Me.btn10to19MPH.Color)
                    Case 20 To 29
                        SetAllColors(Me.btn20to29MPH.Color)
                    Case 30 To 39
                        SetAllColors(Me.btn30to39MPH.Color)
                    Case 40 To 49
                        SetAllColors(Me.btn40to49MPH.Color)
                    Case 50 To 59
                        SetAllColors(Me.btn50to59MPH.Color)
                    Case 60 To 69
                        SetAllColors(Me.btn60to69MPH.Color)
                    Case 70 To 79
                        SetAllColors(Me.btn70to79MPH.Color)
                    Case 80 To 89
                        SetAllColors(Me.btn80to89MPH.Color)
                    Case 90 To 99
                        SetAllColors(Me.btn90to99MPH.Color)
                    Case 100 To 110
                        SetAllColors(Me.btn100to110MPH.Color)
                    Case Is > 100
                        SetAllColors(Me.btnMoreThan110MPH.Color)
                    Case Else
                        SetAllColors(Me.btn0MPH.Color)
                End Select
            Catch ex As Exception
            End Try
        ElseIf AeroMethod = Chameleon.AeroMethod.Humidity Then
            Dim CurrentWeather As New pWeatherForecast(CityLocation, temperatureUnit.Fahrenheit)
            niMain.BalloonTipText = "Chameleon is still running in the background." & Environment.NewLine & CurrentWeather.rss.channel.atmosphere.humidity & "% Humidity"
            Select Case CurrentWeather.rss.channel.atmosphere.humidity
                Case 0
                    SetAllColors(Me.btn0PercentHumidity.Color)
                Case 1 To 9
                    SetAllColors(Me.btn1to9PercentHumidity.Color)
                Case 10 To 19
                    SetAllColors(Me.btn10to19PercentHumidity.Color)
                Case 20 To 29
                    SetAllColors(Me.btn20to29PercentHumidity.Color)
                Case 30 To 39
                    SetAllColors(Me.btn30to39PercentHumidity.Color)
                Case 40 To 49
                    SetAllColors(Me.btn40to49PercentHumidity.Color)
                Case 50 To 59
                    SetAllColors(Me.btn50to59PercentHumidity.Color)
                Case 60 To 69
                    SetAllColors(Me.btn60to69PercentHumidity.Color)
                Case 70 To 79
                    SetAllColors(Me.btn70to79PercentHumidity.Color)
                Case 80 To 89
                    SetAllColors(Me.btn80to89PercentHumidity.Color)
                Case 90 To 99
                    SetAllColors(Me.btn90to99PercentHumidity.Color)
                Case 100
                    SetAllColors(Me.btn100PercentHumidity.Color)
                Case Else

            End Select
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        Me.Visible = False
        If AeroMethod = Chameleon.AeroMethod.None Then
            niMain.BalloonTipText = "Chameleon is still running in the background."
        ElseIf AeroMethod = Chameleon.AeroMethod.Conditions Then
            tmrWeather.Enabled = True
            tmrWeather_Tick(Me, e)
        ElseIf AeroMethod = Chameleon.AeroMethod.WindSpeed Then
            tmrWeather.Enabled = True
            tmrWeather_Tick(Me, e)
        ElseIf AeroMethod = Chameleon.AeroMethod.Humidity Then
            tmrWeather.Enabled = True
            tmrWeather_Tick(Me, e)
        ElseIf AeroMethod = Chameleon.AeroMethod.Temperature Then
            tmrWeather.Enabled = True
            tmrWeather_Tick(Me, e)
        ElseIf AeroMethod = Chameleon.AeroMethod.Wallpaper Then
            SetAeroColorFromWallpaper()
        ElseIf AeroMethod = Chameleon.AeroMethod.Webcam Then
            tmrWebcam.Enabled = True
            tmrWebcam_Tick(Me, e)
        ElseIf AeroMethod = Chameleon.AeroMethod.Battery Then
            Dim CurrentBattery As PowerStatus = SystemInformation.PowerStatus
            Dim PercentFull As Single = CurrentBattery.BatteryLifePercent * 100
            niMain.BalloonTipText = "Chameleon is still running in the background." & Environment.NewLine & PercentFull & "% Battery"
            tmrMain.Enabled = True
        Else
            niMain.BalloonTipText = "Chameleon is still running in the background."
            tmrMain.Enabled = True
        End If
        niMain.ShowBalloonTip(3500)
        Theme.SaveSettings(Application.UserAppDataPath & "\Settings.zia")
    End Sub

    Private Sub btnNone_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnNone.CheckedChanged
        If btnNone.Checked = True Then AeroMethod = Chameleon.AeroMethod.None
    End Sub

    Private Sub btnWallpaper_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnWallpaper.CheckedChanged
        If btnWallpaper.Checked = True Then AeroMethod = Chameleon.AeroMethod.Wallpaper
    End Sub

    Private Sub btnScreen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnScreen.CheckedChanged
        If btnScreen.Checked = True Then AeroMethod = Chameleon.AeroMethod.Screen
    End Sub

    Private Sub btnProgramIcon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnProgramIcon.CheckedChanged
        If btnProgramIcon.Checked = True Then AeroMethod = Chameleon.AeroMethod.ProgramIcon
    End Sub

    Private Sub btnRandom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnRandom.CheckedChanged
        If btnRandom.Checked = True Then AeroMethod = Chameleon.AeroMethod.Random
    End Sub

    Private Sub btnConditions_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnConditions.CheckedChanged
        If btnConditions.Checked = True Then AeroMethod = Chameleon.AeroMethod.Conditions
    End Sub

    Private Sub btnTemperature_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnTemperature.CheckedChanged
        If btnTemperature.Checked = True Then AeroMethod = Chameleon.AeroMethod.Temperature
    End Sub

    Private Sub btnBattery_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnBattery.CheckedChanged
        If btnBattery.Checked = True Then AeroMethod = Chameleon.AeroMethod.Battery
    End Sub

    Private Sub btnTime_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnTime.CheckedChanged
        If btnTime.Checked = True Then AeroMethod = Chameleon.AeroMethod.Time
    End Sub

    Private Sub ShowWindowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowWindowToolStripMenuItem.Click
        Me.Visible = True
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Normal
        Surround(Me, DoubleBufferedPanel1)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        dlgSettings.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        dlgAbout.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        wf.DeactivateWebcam()
        Me.Close()
    End Sub

    Private Sub AdjustAeroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AdjustAeroToolStripMenuItem.Click
        dlgAdjustAero.ShowDialog()
    End Sub


    Private Sub niMain_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles niMain.MouseDoubleClick
        If Loaded = True Then ShowWindowToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub frmMain_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then Surround(Me, DoubleBufferedPanel1)
    End Sub

    Private Sub tmrWebcam_Tick(sender As System.Object, e As System.EventArgs) Handles tmrWebcam.Tick
        If Not Me.WindowState = FormWindowState.Minimized Then
            tmrWebcam.Stop()
            wf.DeactivateWebcam()
        End If
        If Not AeroMethod = Chameleon.AeroMethod.Webcam Then
            tmrWebcam.Stop()
            wf.DeactivateWebcam()
        End If

        wf.ActivateWebcam()
        Threading.Thread.Sleep(2000)
        SetAeroColorFromImage(wf.GetSnapshot)
        wf.DeactivateWebcam()
    End Sub

    Private Sub btnWebcam_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnWebcam.CheckedChanged
        If btnWebcam.Checked = True Then AeroMethod = Chameleon.AeroMethod.Webcam
    End Sub

    Private Sub btnCursorX_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnCursorX.CheckedChanged
        If btnCursorX.Checked = True Then AeroMethod = Chameleon.AeroMethod.CursorX
    End Sub

    Private Sub btnCursorY_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnCursorY.CheckedChanged
        If btnCursorY.Checked = True Then AeroMethod = Chameleon.AeroMethod.CursorY
    End Sub

    Private Sub btnHumidity_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnHumidity.CheckedChanged
        If btnHumidity.Checked = True Then AeroMethod = Chameleon.AeroMethod.Humidity
    End Sub

    Private Sub btnWindSpeed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnWindSpeed.CheckedChanged
        If btnWindSpeed.Checked = True Then AeroMethod = Chameleon.AeroMethod.WindSpeed
    End Sub

    Private Sub btnPreviewAero_Click(sender As Object, e As EventArgs) Handles btnPreviewAero.Click
        frmPreviewAero.Show()
    End Sub

    Private Sub PreviewAeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewAeroToolStripMenuItem.Click
        frmPreviewAero.Show()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
