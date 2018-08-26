Imports Tundra
Imports Tundra.ZiaFile

Public Module Theme
    Public Sub SaveSettings(ByVal DestinationPath As String)
        On Error Resume Next
        Dim FileData As String = ""
        Dim ValueCollection As New List(Of ZiaLine)
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Versions"))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Chameleon Version", My.Application.Info.Version.ToString))
        ValueCollection.Add(New ZiaLine(LineType.Blank))
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Weather"))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Weather Interval", frmMain.WeatherInterval))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Weather Location", frmMain.CityLocation))
        ValueCollection.Add(New ZiaLine(LineType.Blank))
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Timers"))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Timer Interval", frmMain.MainInterval))
        ValueCollection.Add(New ZiaLine(LineType.Blank))
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Button Colors"))
        For Each ConditionButton As Tundra.StylizedColorButton In frmMain.pnlConditions.Controls
            If Not TypeOf ConditionButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, ConditionButton.Name.ToString, ConditionButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        For Each TemperatureButton As Tundra.StylizedColorButton In frmMain.pnlTemperature.Controls
            If Not TypeOf TemperatureButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, TemperatureButton.Name.ToString, TemperatureButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        For Each BatteryButton As Tundra.StylizedColorButton In frmMain.pnlBattery.Controls
            If Not TypeOf BatteryButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, BatteryButton.Name.ToString, BatteryButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        For Each HumidityButton As Tundra.StylizedColorButton In frmMain.pnlHumidity.Controls
            If Not TypeOf HumidityButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, HumidityButton.Name.ToString, HumidityButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        For Each CursorXButton As Tundra.StylizedColorButton In frmMain.pnlCursorX.Controls
            If Not TypeOf CursorXButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, CursorXButton.Name.ToString, CursorXButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        For Each CursorYButton As Tundra.StylizedColorButton In frmMain.pnlCursorY.Controls
            If Not TypeOf CursorYButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, CursorYButton.Name.ToString, CursorYButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        For Each WindSpeedButton As Tundra.StylizedColorButton In frmMain.pnlWindSpeed.Controls
            If Not TypeOf WindSpeedButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, WindSpeedButton.Name.ToString, WindSpeedButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        For Each TimeButton As Tundra.StylizedColorButton In frmMain.pnlTime.Controls
            If Not TypeOf TimeButton Is Tundra.StylizedColorButton Then Exit For
            Dim Data As New ZiaLine(LineType.KeyValue, TimeButton.Name.ToString, TimeButton.Color.ToArgb)
            ValueCollection.Add(Data)
        Next
        System.IO.File.WriteAllText(DestinationPath, ZiaFile.Write(ValueCollection))
    End Sub
    Public Sub LoadSettings(ByVal SourcePath As String)
        On Error Resume Next
        Dim Source As String = System.IO.File.ReadAllText(SourcePath, System.Text.Encoding.UTF8)
        If Source = Nothing Then Exit Sub

        For Each ConditionButton As Tundra.StylizedColorButton In frmMain.pnlConditions.Controls
            If Not TypeOf ConditionButton Is Tundra.StylizedColorButton Then Exit For
            ConditionButton.Color = Color.FromArgb(GetValue(Source, ConditionButton.Name.ToString))
        Next
        For Each TemperatureButton As Tundra.StylizedColorButton In frmMain.pnlTemperature.Controls
            If Not TypeOf TemperatureButton Is Tundra.StylizedColorButton Then Exit For
            TemperatureButton.Color = Color.FromArgb(GetValue(Source, TemperatureButton.Name.ToString))
        Next
        For Each BatteryButton As Tundra.StylizedColorButton In frmMain.pnlBattery.Controls
            If Not TypeOf BatteryButton Is Tundra.StylizedColorButton Then Exit For
            BatteryButton.Color = Color.FromArgb(GetValue(Source, BatteryButton.Name.ToString))
        Next
        For Each TimeButton As Tundra.StylizedColorButton In frmMain.pnlTime.Controls
            If Not TypeOf TimeButton Is Tundra.StylizedColorButton Then Exit For
            TimeButton.Color = Color.FromArgb(GetValue(Source, TimeButton.Name.ToString))
        Next
        For Each HumidityButton As Tundra.StylizedColorButton In frmMain.pnlHumidity.Controls
            If Not TypeOf HumidityButton Is Tundra.StylizedColorButton Then Exit For
            HumidityButton.Color = Color.FromArgb(GetValue(Source, HumidityButton.Name.ToString))
        Next
        For Each WindSpeedButton As Tundra.StylizedColorButton In frmMain.pnlWindSpeed.Controls
            If Not TypeOf WindSpeedButton Is Tundra.StylizedColorButton Then Exit For
            WindSpeedButton.Color = Color.FromArgb(GetValue(Source, WindSpeedButton.Name.ToString))
        Next
        For Each CursorXButton As Tundra.StylizedColorButton In frmMain.pnlCursorX.Controls
            If Not TypeOf CursorXButton Is Tundra.StylizedColorButton Then Exit For
            CursorXButton.Color = Color.FromArgb(GetValue(Source, CursorXButton.Name.ToString))
        Next
        For Each CursorYButton As Tundra.StylizedColorButton In frmMain.pnlCursorY.Controls
            If Not TypeOf CursorYButton Is Tundra.StylizedColorButton Then Exit For
            CursorYButton.Color = Color.FromArgb(GetValue(Source, CursorYButton.Name.ToString))
        Next
        If GetValue(Source, "AeroMethod") = AeroMethod.None Then
            frmMain.btnNone.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Wallpaper Then
            frmMain.btnWallpaper.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Screen Then
            frmMain.btnScreen.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.ProgramIcon Then
            frmMain.btnProgramIcon.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Random Then
            frmMain.btnRandom.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Conditions Then
            frmMain.btnConditions.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Temperature Then
            frmMain.btnTemperature.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Battery Then
            frmMain.btnBattery.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Time Then
            frmMain.btnTime.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Webcam Then
            frmMain.btnWebcam.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.Humidity Then
            frmMain.btnHumidity.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.CursorX Then
            frmMain.btnCursorX.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.CursorY Then
            frmMain.btnCursorY.Checked = True
        ElseIf GetValue(Source, "AeroMethod") = AeroMethod.WindSpeed Then
            frmMain.btnWindSpeed.Checked = True
        Else
            frmMain.btnNone.Checked = True
        End If

        frmMain.WeatherInterval = CInt(GetValue(Source, "Weather Interval"))
        frmMain.MainInterval = CInt(GetValue(Source, "Timer Interval"))
        frmMain.CityLocation = GetValue(Source, "Weather Location")
    End Sub

End Module
