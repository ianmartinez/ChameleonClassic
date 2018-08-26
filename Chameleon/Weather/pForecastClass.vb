Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Partial Class pItemClass
                Public Class pForecastClass
                    Private _day As String
                    ''' <summary>
                    '''   The day of the week to which this forecast applies. Possible values are Mon Tue Wed Thu Fri Sat Sun 
                    ''' </summary>
                    <XmlAttribute()> _
                    Public Property day() As String
                        Get
                            Return _day
                        End Get
                        Set(ByVal value As String)
                            _day = value
                        End Set
                    End Property

                    Private _date As String
                    ''' <summary>
                    '''  The date to which this forecast applies. The date is in "dd Mmm yyyy" format, for example "30 Nov 2005"
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

                    Private _low As Integer
                    ''' <summary>
                    '''  The forecasted low temperature for this day, in the units specified by the units element 
                    ''' </summary>
                    <XmlAttribute()> _
                    Public Property low() As Integer
                        Get
                            Return _low
                        End Get
                        Set(ByVal value As Integer)
                            _low = value
                        End Set
                    End Property

                    Private _high As Integer
                    ''' <summary>
                    '''  The forecasted high temperature for this day, in the units specified by the units element  
                    ''' </summary>
                    <XmlAttribute()> _
                    Public Property high() As Integer
                        Get
                            Return _high
                        End Get
                        Set(ByVal value As Integer)
                            _high = value
                        End Set
                    End Property

                    Private _text As String
                    ''' <summary>
                    '''  A textual description of conditions, for example, "Partly Cloudy"
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

                End Class
            End Class
        End Class
    End Class
End Class
