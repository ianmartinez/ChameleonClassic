Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Public Class pUnitsClass
                Private _temperature As String
                ''' <summary>
                '''  Degree units used, f for Fahrenheit or c for Celsius
                ''' </summary>
                <XmlAttribute()> _
                Public Property temperature() As String
                    Get
                        Return _temperature
                    End Get
                    Set(ByVal value As String)
                        _temperature = value
                    End Set
                End Property

                Private _distance As String
                ''' <summary>
                '''  Units for distance, mi for miles or km for kilometers
                ''' </summary>
                <XmlAttribute()> _
                Public Property distance() As String
                    Get
                        Return _distance
                    End Get
                    Set(ByVal value As String)
                        _distance = value
                    End Set
                End Property

                Private _pressure As String
                ''' <summary>
                '''  Units of barometric pressure, in for pounds per square inch or mb for millibars
                ''' </summary>
                <XmlAttribute()> _
                Public Property pressure() As String
                    Get
                        Return _pressure
                    End Get
                    Set(ByVal value As String)
                        _pressure = value
                    End Set
                End Property

                Private _speed As String
                ''' <summary>
                '''  Units of speed, mph for miles per hour or kph for kilometers per hour 
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

