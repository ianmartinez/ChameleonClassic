Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Tundra.ZiaFile
Imports System.ComponentModel.Design
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class StylizedPanel
    Inherits DoubleBufferedPanel
    Private mStyle As String
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))> _
    Public Property Style As String
        Get
            Return mStyle
        End Get
        Set(ByVal value As String)
            mStyle = value
            Refresh()
        End Set
    End Property

    Private Colors As Color()
    Private Positions As Single()
    Private Angle As Integer
    Private Radius As Integer
    Private BorderColor As Color
    Private HighlightColor As Color

    Private Sub ReadStyle()
        On Error Resume Next
        Colors = ReadColorList(GetValue(Style, "Colors"))
        Positions = ReadSingleList(GetValue(Style, "Positions"))
        Angle = CInt(GetValue(Style, "Angle"))
        Radius = CInt(GetValue(Style, "Radius"))
        BorderColor = ReadColor(GetValue(Style, "Border Color"))
        HighlightColor = ReadColor(GetValue(Style, "Highlight Color"))
    End Sub

    Private Sub StylizedPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        On Error Resume Next
        ReadStyle()
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim Blend As New ColorBlend()
        Dim FillRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim HighlightRectangle As New Rectangle(1, 1, Me.Width - 3, Me.Height - 3)
        Dim FillRoundedRectangle As GraphicsPath = RoundedRectangle(FillRectangle, Radius)
        Dim HighlightRoundedRectangle As GraphicsPath = RoundedRectangle(HighlightRectangle, Radius)
        Dim FillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, Angle)

        Blend.Colors = Colors
        Blend.Positions = Positions
        FillBlend.InterpolationColors = Blend

        e.Graphics.FillPath(FillBlend, FillRoundedRectangle)
        e.Graphics.DrawPath(New Pen(New SolidBrush(BorderColor)), FillRoundedRectangle)
        e.Graphics.DrawPath(New Pen(New SolidBrush(HighlightColor)), HighlightRoundedRectangle)
    End Sub
End Class
