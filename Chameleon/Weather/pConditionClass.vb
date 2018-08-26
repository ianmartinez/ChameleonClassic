Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Partial Class pItemClass
                Public Class pConditionClass
                    Private _text As String
                    ''' <summary>
                    '''  The textual description of conditions, for example, "Partly Cloudy"  
                    ''' </summary>
                    <XmlAttribute()> _
                    Public Property [text]() As String
                        Get
                            Return _text
                        End Get
                        Set(ByVal value As String)
                            _text = value
                        End Set
                    End Property

                    Private _code As Integer
                    ''' <summary>
                    '''  The condition code for this forecast. You could use this code to choose a text description or image for the forecast.
                    ''' </summary>
                    <XmlAttribute()> _
                    Public Property code() As Integer
                        Get
                            Return _code
                        End Get
                        Set(ByVal value As Integer)
                            _code = value
                        End Set
                    End Property

                    <XmlIgnore()> _
                    Public ReadOnly Property codeEnum() As conditionCode
                        Get
                            Return Me.code
                        End Get
                    End Property

                    Private _temp As Integer
                    ''' <summary>
                    '''  The current temperature, in the units specified by the units element 
                    ''' </summary>
                    <XmlAttribute()> _
                    Public Property temp() As Integer
                        Get
                            Return _temp
                        End Get
                        Set(ByVal value As Integer)
                            _temp = value
                        End Set
                    End Property

                    Private _date As String
                    ''' <summary>
                    '''  The current date and time for which this forecast applies. The date is in RFC822 Section 5 format, for example "Wed, 30 Nov 2005 1:56 pm PST" 
                    ''' </summary>
                    <XmlAttribute()> _
                    Public Property [date]() As String
                        Get
                            Return _date
                        End Get
                        Set(ByVal value As String)
                            _date = value
                        End Set
                    End Property

                End Class
            End Class
        End Class
    End Class
End Class
