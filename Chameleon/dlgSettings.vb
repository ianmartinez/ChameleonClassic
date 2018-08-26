Imports System.Windows.Forms
Imports Tundra.Aero
Imports Chameleon.pWeatherForecast

Public Class dlgSettings
    Dim PreviousPosition As New Point

    Private Sub dlgSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Surround(Me, pnlBack)
        txtLocation.Text = frmMain.CityLocation
        nudWeatherInterval.Value = frmMain.WeatherInterval / 1000
        nudTimerInterval.Value = frmMain.MainInterval
    End Sub

    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Cursor = Cursors.WaitCursor
        Try
            Dim CurrentWeather As New pWeatherForecast(txtLocation.Text, temperatureUnit.Fahrenheit)

            lblConditions.Text = Weather.GetConditionsWithDescription(Weather.GetConditions(CurrentWeather))
            lblTemperature.Text = CurrentWeather.rss.channel.item.condition.temp & " °F"
        Catch ex As Exception
            MessageBox.Show("Sorry, there was an error getting your weather, try checking the spelling.")
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        frmMain.CityLocation = txtLocation.Text
        frmMain.MainInterval = nudTimerInterval.Value
        frmMain.WeatherInterval = nudWeatherInterval.Value * 1000
        frmMain.tmrMain.Interval = frmMain.MainInterval
        frmMain.tmrWeather.Interval = frmMain.WeatherInterval
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub dlgSettings_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Theme.LoadSettings(dlgOpen.FileName)
            Catch ex As Exception
                MessageBox.Show("Error applying theme file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Theme.SaveSettings(dlgSave.FileName)
        End If
    End Sub

    Private Sub btnEraseAll_Click(sender As Object, e As EventArgs) Handles btnEraseAll.Click
        On Error Resume Next
        If MessageBox.Show("Are you sure you want to erase all settings? This cannot be undone.", "", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
            System.IO.File.Delete(Application.UserAppDataPath & "\Settings.zia")
            frmMain.EraseAll = True
            Application.Restart()
        End If
    End Sub

    Private Sub txtLocation_Enter(sender As Object, e As EventArgs) Handles txtLocation.Enter

    End Sub

    Private Sub txtLocation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocation.KeyPress

    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged

    End Sub
End Class
