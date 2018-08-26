Public Class frmPreviewAero

    Dim PreviousPosition As New Point
    Private Sub frmPreviewAero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tundra.Aero.Fill(Me)
    End Sub

    Private Sub frmPreviewAero_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub frmPreviewAero_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Tundra.Aero.Fill(Me)
    End Sub

    Private Sub frmPreviewAero_StyleChanged(sender As Object, e As EventArgs) Handles Me.StyleChanged

    End Sub

    Private Sub frmPreviewAero_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Tundra.Aero.Fill(Me)
    End Sub
End Class