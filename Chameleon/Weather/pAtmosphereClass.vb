Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Public Class pAtmosphereClass
                Private _humidity As Integer
                ''' <summary>
                '''  Humidity, in percent 
                ''' </summary>
                <XmlAttribute()> _
                Public Property humidity() As Integer
                    Get
                        Return _humidity
                    End Get
                    Set(ByVal value As Integer)
                        _humidity = value
                    End Set
                End Property

                Private _visibility As Double
                ''' <summary>
                '''   In the units specified by the distance attribute of the units element (mi or km). Note that the visibility is specified as the actual value * 100. For example, a visibility of 16.5 miles will be specified as 1650. A visibility of 14 kilometers will appear as 1400. 
                ''' </summary>
                <XmlAttribute()> _
                Public Property visibility() As Double
                    Get
                        Return _visibility
                    End Get
                    Set(ByVal value As Double)
                        _visibility = value
                    End Set
                End Property

                Private _pressure As Double
                ''' <summary>
                '''  Barometric pressure, in the units specified by the pressure attribute of the units element (in or mb).
                ''' </summary>
                <XmlAttribute()> _
                Public Property pressure() As Double
                    Get
                        Return _pressure
                    End Get
                    Set(ByVal value As Double)
                        _pressure = value
                    End Set
                End Property


                Private _rising As Integer
                ''' <summary>
                '''  The State of the barometric pressure,   steady = 0, rising = 1, falling = 2
                ''' </summary>
                <XmlAttribute()> _
                Public Property rising() As Integer
                    Get
                        Return _rising
                    End Get
                    Set(ByVal value As Integer)
                        _rising = value
                    End Set
                End Property

            End Class
        End Class
    End Class
End Class
