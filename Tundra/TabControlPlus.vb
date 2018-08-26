Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class TabControlPlus
    Inherits TabControl
    Public Sub PaintTransparentBackground(graphics As Graphics, clipRect As Rectangle)
        graphics.Clear(Color.Transparent)
        If (Me.Parent IsNot Nothing) Then
            clipRect.Offset(Me.Location)
            Dim e As New PaintEventArgs(graphics, clipRect)
            Dim state As GraphicsState = graphics.Save()
            graphics.SmoothingMode = SmoothingMode.HighSpeed
            Try
                graphics.TranslateTransform(CSng(-Me.Location.X), CSng(-Me.Location.Y))
                Me.InvokePaintBackground(Me.Parent, e)
                Me.InvokePaint(Me.Parent, e)
            Finally
                graphics.Restore(state)
                clipRect.Offset(-Me.Location.X, -Me.Location.Y)
            End Try
        End If
    End Sub

    Private Sub TabControlPlus_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

    End Sub
End Class
