Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Public Class pAstronomyClass
                Private _sunrise As String
                ''' <summary>
                '''  Today's sunrise time. The time is a string in a local time format of "h:mm am/pm", for example "7:02 am" 
                ''' </summary>
                <XmlAttribute()> _
                Public Property sunrise() As String
                    Get
                        Return _sunrise
                    End Get
                    Set(ByVal value As String)
                        _sunrise = value
                    End Set
                End Property

                Private _sunset As String
                ''' <summary>
                '''  Today's sunset time. The time is a string in a local time format of "h:mm am/pm", for example "4:51 pm"
                ''' </summary>
                <XmlAttribute()> _
                Public Property sunset() As String
                    Get
                        Return _sunset
                    End Get
                    Set(ByVal value As String)
                        _sunset = value
                    End Set
                End Property

            End Class
        End Class
    End Class
End Class
