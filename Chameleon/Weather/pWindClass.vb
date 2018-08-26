Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Public Class pWindClass
                Private _chill As Integer
                ''' <summary>
                '''  wind chill in degrees 
                ''' </summary>
                <XmlAttribute()> _
                Public Property chill() As Integer
                    Get
                        Return _chill
                    End Get
                    Set(ByVal value As Integer)
                        _chill = value
                    End Set
                End Property

                Private _direction As Integer
                ''' <summary>
                '''  wind direction, in degrees 
                ''' </summary>
                <XmlAttribute()> _
                Public Property direction() As Integer
                    Get
                        Return _direction
                    End Get
                    Set(ByVal value As Integer)
                        _direction = value
                    End Set
                End Property

                Private _speed As String
                ''' <summary>
                '''  wind speed, in the units specified in the speed attribute of the units element (mph or kph). 
                ''' </summary>
                <XmlAttribute()> _
                Public Property speed() As String
                    Get
                        Return _speed
                    End Get
                    Set(ByVal value As String)
                        _speed = value
                    End Set
                End Property

            End Class
        End Class
    End Class
End Class
