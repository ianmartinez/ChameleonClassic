Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Public Class pImageClass
                Private _title As String
                ''' <summary>
                '''  The title of the image, for example "Yahoo! Weather"
                ''' </summary>
                <XmlElement()> _
                Public Property title() As String
                    Get
                        Return _title
                    End Get
                    Set(ByVal value As String)
                        _title = value
                    End Set
                End Property


                Private _link As String
                ''' <summary>
                '''  The URL of Yahoo! Weather 
                ''' </summary>
                <XmlElement()> _
                Public Property link() As String
                    Get
                        Return _link
                    End Get
                    Set(ByVal value As String)
                        _link = value
                    End Set
                End Property

                Private _url As String
                ''' <summary>
                '''  The URL of the image
                ''' </summary>
                <XmlElement()> _
                Public Property url() As String
                    Get
                        Return _url
                    End Get
                    Set(ByVal value As String)
                        _url = value
                    End Set
                End Property

                Private _width As String
                ''' <summary>
                '''  The width of the image, in pixels
                ''' </summary>
                <XmlElement()> _
                Public Property width() As String
                    Get
                        Return _width
                    End Get
                    Set(ByVal value As String)
                        _width = value
                    End Set
                End Property

                Private _height As String
                ''' <summary>
                '''  The height of the image, in pixels
                ''' </summary>
                <XmlElement()> _
                Public Property height() As String
                    Get
                        Return _height
                    End Get
                    Set(ByVal value As String)
                        _height = value
                    End Set
                End Property

            End Class
        End Class
    End Class
End Class
