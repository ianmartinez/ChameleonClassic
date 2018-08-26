Imports Tundra
Imports Tundra.ZiaFile
Imports Tundra.Aero

Module AeroAdjustment
    Public Sub SaveAdjustment(ByVal DestinationPath As String)
        On Error Resume Next
        Dim FileData As String = ""
        Dim ValueCollection As New List(Of ZiaLine)

        ValueCollection.Add(New ZiaLine(LineType.Comment, "Aero Adjustment"))
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Open with Chameleon 5.0 or higher"))
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Created: " & Date.Today.ToLongDateString))
        ValueCollection.Add(New ZiaLine(LineType.Blank))

        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Opacity", GetOpacity()))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Color", ToCompatibleColor(GetColor())))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "AfterglowColor", ToCompatibleColor(GetAfterglowColor())))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "BlurBalance", GetBlurBalance()))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "ColorBalance", GetColorBalance()))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "AfterglowBalance", GetAfterglowBalance()))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "GlassReflectionIntensity", GetGlassReflectionIntensity))

        System.IO.File.WriteAllText(DestinationPath, ZiaFile.Write(ValueCollection))
    End Sub
    Public Sub LoadAdjustment(ByVal SourcePath As String)
        On Error Resume Next
        Dim Source As String = System.IO.File.ReadAllText(SourcePath, System.Text.Encoding.UTF8)
        If Source = Nothing Then Exit Sub
        SetOpacity(GetValue(Source, "Opacity"))
        SetColor(ReadColor(GetValue(Source, "Color")))
        SetAfterglowColor(ReadColor(GetValue(Source, "AfterglowColor")))
        SetBlurBalance(GetValue(Source, "BlurBalance"))
        SetColorBalance(GetValue(Source, "ColorBalance"))
        SetAfterglowBalance(GetValue(Source, "AfterglowBalance"))
        SetGlassReflectionIntensity(GetValue(Source, "GlassReflectionIntensity"))
    End Sub
End Module
