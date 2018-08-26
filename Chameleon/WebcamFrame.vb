Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms

Public Class WebcamFrame
    Inherits PictureBox
    Private VideoSource As VideoCaptureDevice
    Private WebcamImage As Image
    Public Shine As Boolean = False
    Private UneditedWebcamImage As Image
    Public Sub ActivateWebcam()
        Dim VideoSources As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If VideoSources IsNot Nothing Then
            VideoSource = New VideoCaptureDevice(VideoSources(0).MonikerString)
            Try
                If VideoSource.VideoCapabilities.Length > 0 Then
                    Dim highestSolution As String = "0;0"
                    For i As Integer = 0 To VideoSource.VideoCapabilities.Length - 1
                        If VideoSource.VideoCapabilities(i).FrameSize.Width > Convert.ToInt32(highestSolution.Split(";"c)(0)) Then
                            highestSolution = VideoSource.VideoCapabilities(i).FrameSize.Width.ToString() & ";" & i.ToString()
                        End If
                    Next
                    VideoSource.DesiredFrameSize = VideoSource.VideoCapabilities(Convert.ToInt32(highestSolution.Split(";"c)(1))).FrameSize
                End If
            Catch
            End Try
            AddHandler VideoSource.NewFrame, New AForge.Video.NewFrameEventHandler(AddressOf videoSource_NewFrame)
            Play()
        End If
    End Sub
    Public Sub DeactivateWebcam()
        If VideoSource IsNot Nothing AndAlso VideoSource.IsRunning Then
            VideoSource.SignalToStop()
            VideoSource = Nothing
        End If
    End Sub
    Public Sub Pause()
        VideoSource.Stop()
    End Sub
    Public Sub Play()
        VideoSource.Start()
    End Sub
    Public Function GetSnapshot() As Image
        Return UneditedWebcamImage
    End Function
    Private Sub SetWebcamPicture()
        On Error Resume Next
        If Shine = True Then
            Dim g As Graphics = Graphics.FromImage(WebcamImage)
            Dim b As New ColorBlend()
            b.Colors = {Color.FromArgb(80, 255, 255, 255), Color.Transparent, Color.Transparent, Color.FromArgb(80, 255, 255, 255)}
            b.Positions = {0, 0.13, 0.95, 1}
            Dim rect As New Rectangle(-1, -1, WebcamImage.Width + 2, WebcamImage.Height + 2)
            Dim gr As New LinearGradientBrush(rect, Color.Transparent, Color.Transparent, 90)
            gr.InterpolationColors = b
            g.FillRectangle(gr, rect)
            g.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(200, 255, 255, 255)), 4), New Rectangle(2, 2, WebcamImage.Width - 4, WebcamImage.Height - 4))
            g.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(250, 0, 0, 0)), 2), New Rectangle(1, 1, WebcamImage.Width - 2, WebcamImage.Height - 2))
        End If
        Me.Image = WebcamImage
    End Sub
    Private Sub VideoSource_NewFrame(ByVal sender As Object, ByVal eventArgs As AForge.Video.NewFrameEventArgs)
        WebcamImage = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        UneditedWebcamImage = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        SetWebcamPicture()
    End Sub
End Class