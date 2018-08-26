Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Private _title As String
            ''' <summary>
            '''  The title of the feed, which includes the location city. For example "Yahoo! Weather - Sunnyvale, CA" 
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
            '''  The URL for the Yahoo! Weather page of the forecast for this location. For example http://us.rd.yahoo.com/dailynews/rss/weather/ Sunnyvale__CA/ *http://xml.weather.yahoo.com/ forecast/94089_f.html
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

            Private _language As String
            ''' <summary>
            '''  The language of the weather forecast, for example, en-us for US English. 
            ''' </summary>
            <XmlElement()> _
            Public Property language() As String
                Get
                    Return _language
                End Get
                Set(ByVal value As String)
                    _language = value
                End Set
            End Property

            Private _description As String
            ''' <summary>
            '''  The overall description of the feed including the location, for example "Yahoo! Weather for Sunnyvale, CA" 
            ''' </summary>
            <XmlElement()> _
            Public Property description() As String
                Get
                    Return _description
                End Get
                Set(ByVal value As String)
                    _description = value
                End Set
            End Property

            Private _lastBuildDate As String
            ''' <summary>
            '''  The last time the feed was updated. The format is in the date format defined by RFC822 Section 5, for example Mon, 256 Sep 17:25:18 -0700.
            ''' </summary>
            <XmlElement()> _
            Public Property lastBuildDate() As String
                Get
                    Return _lastBuildDate
                End Get
                Set(ByVal value As String)
                    _lastBuildDate = value
                End Set
            End Property

            Private _ttl As String
            ''' <summary>
            '''  Time to Live; how long in minutes this feed should be cached. 
            ''' </summary>
            <XmlElement()> _
            Public Property ttl() As String
                Get
                    Return _ttl
                End Get
                Set(ByVal value As String)
                    _ttl = value
                End Set
            End Property

            Private _location As pLocationClass
            ''' <summary>
            '''  The location of this forecast.
            ''' </summary>
            <XmlElement()> _
            Public Property location() As pLocationClass
                Get
                    Return _location
                End Get
                Set(ByVal value As pLocationClass)
                    _location = value
                End Set
            End Property

            Private _units As pUnitsClass
            ''' <summary>
            '''  Units for various aspects of the forecast.
            ''' </summary>
            <XmlElement()> _
            Public Property units() As pUnitsClass
                Get
                    Return _units
                End Get
                Set(ByVal value As pUnitsClass)
                    _units = value
                End Set
            End Property

            Private _wind As pWindClass
            ''' <summary>
            '''  Forecast information about wind.
            ''' </summary>
            <XmlElement()> _
            Public Property wind() As pWindClass
                Get
                    Return _wind
                End Get
                Set(ByVal value As pWindClass)
                    _wind = value
                End Set
            End Property

            Private _atmosphere As pAtmosphereClass
            ''' <summary>
            '''  Forecast information about current atmospheric pressure, humidity, and visibility.
            ''' </summary>
            <XmlElement()> _
            Public Property atmosphere() As pAtmosphereClass
                Get
                    Return _atmosphere
                End Get
                Set(ByVal value As pAtmosphereClass)
                    _atmosphere = value
                End Set
            End Property

            Private _astronomy As pAstronomyClass
            ''' <summary>
            '''  Forecast information about current astronomical conditions.
            ''' </summary>
            <XmlElement()> _
            Public Property astronomy() As pAstronomyClass
                Get
                    Return _astronomy
                End Get
                Set(ByVal value As pAstronomyClass)
                    _astronomy = value
                End Set
            End Property

            Private _image As pImageClass
            ''' <summary>
            '''  The image used to identify this feed
            ''' </summary>
            <XmlElement()> _
            Public Property image() As pImageClass
                Get
                    Return _image
                End Get
                Set(ByVal value As pImageClass)
                    _image = value
                End Set
            End Property

            Private _item As pItemClass
            ''' <summary>
            '''  The local weather conditions and forecast for a specific location.
            ''' </summary>
            <XmlElement()> _
            Public Property item() As pItemClass
                Get
                    Return _item
                End Get
                Set(ByVal value As pItemClass)
                    _item = value
                End Set
            End Property
        End Class
    End Class
End Class