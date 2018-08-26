Imports System.Windows.Forms
Imports Tundra.Aero
Public Class dlgAbout
    Dim PreviousPosition As New Point

    Private Sub dlgAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Surround(Me, pnlBack)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnWebsite_Click(sender As System.Object, e As System.EventArgs) Handles btnWebsite.Click
        Process.Start("http://kwuus.deviantart.com/")
    End Sub

    Private Sub dlgAbout_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub
End Class
