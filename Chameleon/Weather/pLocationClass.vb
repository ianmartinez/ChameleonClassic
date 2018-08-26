Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Public Class pLocationClass
                Private _city As String
                ''' <summary>
                ''' The city's name
                ''' </summary>
                <XmlAttribute()> _
                Public Property city() As String
                    Get
                        Return _city
                    End Get
                    Set(ByVal value As String)
                        _city = value
                    End Set
                End Property

                Private _region As String
                ''' <summary>
                '''  The state, territory, or region, if given
                ''' </summary>
                <XmlAttribute()> _
                Public Property region() As String
                    Get
                        Return _region
                    End Get
                    Set(ByVal value As String)
                        _region = value
                    End Set
                End Property

                Private _country As String
                ''' <summary>
                '''  The 2 character country code
                ''' </summary>
                <XmlAttribute()> _
                Public Property country() As String
                    Get
                        Return _country
                    End Get
                    Set(ByVal value As String)
                        _country = value
                    End Set
                End Property
            End Class
        End Class
    End Class
End Class
