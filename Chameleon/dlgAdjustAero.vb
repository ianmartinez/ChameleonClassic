Imports System.Windows.Forms
Imports Tundra.Aero
Public Class dlgAdjustAero
    Dim PreviousPosition As New Point
    Private Loading = True

    Private Sub dlgAdjustAero_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tmrUpdate.Enabled = False
    End Sub

    Private Sub dlgAdjustAero_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tmrUpdate.Enabled = False
    End Sub
    Private Sub dlgAdjustAero_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Surround(Me, pnlBack)
        btnMainColor.Color = GetColor()
        cbTransparency.Checked = GetOpacity()
        btnAfterglow.Color = GetAfterglowColor()
        tbBlurBalance.Value = GetBlurBalance()
        tbColorBalance.Value = GetColorBalance()
        tbAfterglowBalance.Value = GetAfterGlowBalance()
        tbGlassReflectionIntensity.Value = GetGlassReflectionIntensity()

        If Environment.OSVersion.Version.Build >= 9200 Then
            MessageBox.Show("These features are only available in Windows Vista and Windows 7. Windows 8 and higher do not support them.")
            Me.Close()
        Else
            tmrUpdate.Start()
            Loading = False
        End If
    End Sub

    Private Sub tmrUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUpdate.Tick
        On Error Resume Next
        SaveAdjustment("C:\Users\Ian Martinez\Desktop\New folder (4)\aero.aero")
        btnMainColor.Color = GetColor()
        cbTransparency.Checked = GetOpacity()
        btnAfterglow.Color = GetAfterglowColor()
        tbBlurBalance.Value = GetBlurBalance()
        tbColorBalance.Value = GetColorBalance()
        tbAfterglowBalance.Value = GetAfterglowBalance()
        tbGlassReflectionIntensity.Value = GetGlassReflectionIntensity()
    End Sub

    Private Sub cbTransparency_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbTransparency.CheckedChanged
        On Error Resume Next
        If Loading = True Then Exit Sub
        tmrUpdate.Stop()
        SetOpacity(cbTransparency.Checked)
        tmrUpdate.Start()
    End Sub

    Private Sub btnMainColor_ColorChanged(sender As Object, e As System.EventArgs) Handles btnMainColor.ColorChanged
        On Error Resume Next
        If Loading = True Then Exit Sub
        tmrUpdate.Stop()
        SetColor(btnMainColor.Color)
        tmrUpdate.Start()
    End Sub

    Private Sub btnAfterglow_ColorChanged(sender As Object, e As System.EventArgs) Handles btnAfterglow.ColorChanged
        On Error Resume Next
        If Loading = True Then Exit Sub
        tmrUpdate.Stop()
        SetAfterglowColor(btnAfterglow.Color)
        tmrUpdate.Start()
    End Sub

    Private Sub tbColorBalance_Scroll(sender As System.Object, e As System.EventArgs) Handles tbColorBalance.Scroll
        On Error Resume Next
        If Loading = True Then Exit Sub
        tmrUpdate.Stop()
        SetColorBalance(tbColorBalance.Value)
        tmrUpdate.Start()
    End Sub

    Private Sub tbAfterglowBalance_Scroll(sender As System.Object, e As System.EventArgs) Handles tbAfterglowBalance.Scroll
        On Error Resume Next
        If Loading = True Then Exit Sub
        tmrUpdate.Stop()
        SetAfterglowBalance(tbAfterglowBalance.Value)
        tmrUpdate.Start()
    End Sub

    Private Sub tbBlurBalance_Scroll(sender As System.Object, e As System.EventArgs) Handles tbBlurBalance.Scroll
        On Error Resume Next
        If Loading = True Then Exit Sub
        tmrUpdate.Stop()
        SetBlurBalance(tbBlurBalance.Value)
        tmrUpdate.Start()
    End Sub

    Private Sub tbGlassReflectionIntensity_Scroll(sender As System.Object, e As System.EventArgs) Handles tbGlassReflectionIntensity.Scroll
        On Error Resume Next
        If Loading = True Then Exit Sub
        tmrUpdate.Stop()
        SetGlassReflectionIntensity(tbGlassReflectionIntensity.Value)
        tmrUpdate.Start()
    End Sub

    Private Sub dlgAdjustAero_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            On Error Resume Next
            AeroAdjustment.LoadAdjustment(dlgOpen.FileName)
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            On Error Resume Next
            AeroAdjustment.SaveAdjustment(dlgSave.FileName)
        End If
    End Sub
End Class
