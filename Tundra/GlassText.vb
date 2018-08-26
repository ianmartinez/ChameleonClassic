
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Public Class GlassText
    Inherits Control
    Private mGlow As Integer
    Public Property Glow As Integer
        Get
            Return mGlow
        End Get
        Set(ByVal value As Integer)
            mGlow = value
            Refresh()
        End Set
    End Property
    Private Const DTT_COMPOSITED As Integer = CInt(1UL << 13)
    Private Const DTT_GLOWSIZE As Integer = CInt(1UL << 11)

    'Text format consts
    Private Const DT_SINGLELINE As Integer = &H20
    Private Const DT_CENTER As Integer = &H1
    Private Const DT_VCENTER As Integer = &H4
    Private Const DT_NOPREFIX As Integer = &H800

    'Const for BitBlt
    Private Const SRCCOPY As Integer = &HCC0020


    'Consts for CreateDIBSection
    Private Const BI_RGB As Integer = 0
    Private Const DIB_RGB_COLORS As Integer = 0
    'color table in RGBs
    Private Structure MARGINS
        Public m_Left As Integer
        Public m_Right As Integer
        Public m_Top As Integer
        Public m_Buttom As Integer
    End Structure

    Private Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    Private Structure DTTOPTS
        Public dwSize As UInteger
        Public dwFlags As UInteger
        Public crText As UInteger
        Public crBorder As UInteger
        Public crShadow As UInteger
        Public iTextShadowType As Integer
        Public ptShadowOffset As POINTAPI
        Public iBorderSize As Integer
        Public iFontPropId As Integer
        Public iColorPropId As Integer
        Public iStateId As Integer
        Public fApplyOverlay As Integer
        Public iGlowSize As Integer
        Public pfnDrawTextCallback As IntPtr
        Public lParam As Integer
    End Structure

    Private Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer


    End Structure

    Private Structure BITMAPINFOHEADER
        Public biSize As Integer
        Public biWidth As Integer
        Public biHeight As Integer
        Public biPlanes As Short
        Public biBitCount As Short
        Public biCompression As Integer
        Public biSizeImage As Integer
        Public biXPelsPerMeter As Integer
        Public biYPelsPerMeter As Integer
        Public biClrUsed As Integer
        Public biClrImportant As Integer
    End Structure

    Private Structure RGBQUAD
        Public rgbBlue As Byte
        Public rgbGreen As Byte
        Public rgbRed As Byte
        Public rgbReserved As Byte
    End Structure

    Private Structure BITMAPINFO
        Public bmiHeader As BITMAPINFOHEADER
        Public bmiColors As RGBQUAD
    End Structure


    'API declares
    <DllImport("dwmapi.dll")> _
    Private Shared Sub DwmIsCompositionEnabled(ByRef enabledptr As Integer)
    End Sub
    <DllImport("dwmapi.dll")> _
    Private Shared Sub DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef margin As MARGINS)
    End Sub


    Private Declare Auto Function GetDC Lib "user32.dll" (hdc As IntPtr) As IntPtr
    Private Declare Auto Function SaveDC Lib "gdi32.dll" (hdc As IntPtr) As Integer
    Private Declare Auto Function ReleaseDC Lib "user32.dll" (hdc As IntPtr, state As Integer) As Integer
    Private Declare Auto Function CreateCompatibleDC Lib "gdi32.dll" (hDC As IntPtr) As IntPtr
    <DllImport("gdi32.dll", ExactSpelling:=True)> _
    Private Shared Function SelectObject(hDC As IntPtr, hObject As IntPtr) As IntPtr
    End Function
    Private Declare Auto Function DeleteObject Lib "gdi32.dll" (hObject As IntPtr) As Boolean
    Private Declare Auto Function DeleteDC Lib "gdi32.dll" (hdc As IntPtr) As Boolean
    <DllImport("gdi32.dll")> _
    Private Shared Function BitBlt(hdc As IntPtr, nXDest As Integer, nYDest As Integer, nWidth As Integer, nHeight As Integer, hdcSrc As IntPtr, _
   nXSrc As Integer, nYSrc As Integer, dwRop As UInteger) As Boolean
    End Function

    Private Declare Unicode Function DrawThemeTextEx Lib "UxTheme.dll" (hTheme As IntPtr, hdc As IntPtr, iPartId As Integer, iStateId As Integer, text As String, iCharCount As Integer, _
     dwFlags As Integer, ByRef pRect As RECT, ByRef pOptions As DTTOPTS) As Integer
    Private Declare Auto Function DrawThemeText Lib "UxTheme.dll" (hTheme As IntPtr, hdc As IntPtr, iPartId As Integer, iStateId As Integer, text As String, iCharCount As Integer, _
     dwFlags1 As Integer, dwFlags2 As Integer, ByRef pRect As RECT) As Integer
    Private Declare Auto Function CreateDIBSection Lib "gdi32.dll" (hdc As IntPtr, ByRef pbmi As BITMAPINFO, iUsage As UInteger, ppvBits As Integer, hSection As IntPtr, dwOffset As UInteger) As IntPtr
    Public Sub DrawTextOnGlass(hwnd As IntPtr, text As [String], font As Font, ctlrct As Rectangle, iglowSize As Integer)
        If Aero.DWMEnabled Then
            Dim rc As New RECT()
            Dim rc2 As New RECT()

            rc.left = ctlrct.Left
            rc.right = ctlrct.Right + 2 * iglowSize
            'make it larger to contain the glow effect
            rc.top = ctlrct.Top
            rc.bottom = ctlrct.Bottom + 2 * iglowSize

            'Just the same rect with rc,but (0,0) at the lefttop
            rc2.left = 0
            rc2.top = 0
            rc2.right = rc.right - rc.left
            rc2.bottom = rc.bottom - rc.top

            Dim destdc As IntPtr = GetDC(hwnd)
            'hwnd must be the handle of form,not control
            Dim Memdc As IntPtr = CreateCompatibleDC(destdc)
            ' Set up a memory DC where we'll draw the text.
            Dim bitmap As IntPtr
            Dim bitmapOld As IntPtr = IntPtr.Zero
            Dim logfnotOld As IntPtr

            Dim uFormat As Integer = DT_SINGLELINE Or DT_CENTER Or DT_VCENTER Or DT_NOPREFIX
            'text format
            Dim dib As New BITMAPINFO()
            dib.bmiHeader.biHeight = -(rc.bottom - rc.top)
            ' negative because DrawThemeTextEx() uses a top-down DIB
            dib.bmiHeader.biWidth = rc.right - rc.left
            dib.bmiHeader.biPlanes = 1
            dib.bmiHeader.biSize = Marshal.SizeOf(GetType(BITMAPINFOHEADER))
            dib.bmiHeader.biBitCount = 32
            dib.bmiHeader.biCompression = BI_RGB
            If Not (SaveDC(Memdc) = 0) Then
                bitmap = CreateDIBSection(Memdc, dib, DIB_RGB_COLORS, 0, IntPtr.Zero, 0)
                ' Create a 32-bit bmp for use in offscreen drawing when glass is on
                If Not (bitmap = IntPtr.Zero) Then
                    bitmapOld = SelectObject(Memdc, bitmap)
                    Dim hFont As IntPtr = font.ToHfont()
                    logfnotOld = SelectObject(Memdc, hFont)
                    Try

                        Dim renderer As New System.Windows.Forms.VisualStyles.VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Window.Caption.Active)

                        Dim dttOpts As New DTTOPTS()

                        dttOpts.dwSize = CUInt(Marshal.SizeOf(GetType(DTTOPTS)))

                        dttOpts.dwFlags = DTT_COMPOSITED Or DTT_GLOWSIZE


                        dttOpts.iGlowSize = iglowSize

                        DrawThemeTextEx(renderer.Handle, Memdc, 0, 0, text, -1, _
                         uFormat, rc2, dttOpts)







                        BitBlt(destdc, rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top, Memdc, _
                         0, 0, SRCCOPY)
                    Catch e As Exception
                        Trace.WriteLine(e.Message)
                    End Try


                    'Remember to clean up
                    SelectObject(Memdc, bitmapOld)
                    SelectObject(Memdc, logfnotOld)
                    DeleteObject(bitmap)
                    DeleteObject(hFont)

                    ReleaseDC(Memdc, -1)



                    DeleteDC(Memdc)



                End If



            End If
        End If

    End Sub

    Private Sub GlassText_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Me.DrawTextOnGlass(Me.Handle, Text, Font, Me.ClientRectangle, Glow)
    End Sub

    Private Sub GlassText_TextChanged(sender As Object, e As System.EventArgs) Handles Me.TextChanged
        Me.DrawTextOnGlass(Me.Handle, Text, Font, Me.ClientRectangle, Glow)
    End Sub

    Private Sub GlassText_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then Me.DrawTextOnGlass(Me.Handle, Text, Font, Me.ClientRectangle, Glow)
    End Sub
End Class