Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    <XmlRoot("rss")> _
    Public Class pRssClass
        Private _channel As pChannelClass

        <XmlElement()> _
        Public Property channel() As pChannelClass
            Get
                Return _channel
            End Get
            Set(ByVal value As pChannelClass)
                _channel = value
            End Set
        End Property
    End Class
End Class
