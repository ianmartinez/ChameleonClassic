Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Public Class pWeatherForecast
    Public Enum conditionCode
        tornado = 0
        tropical_storm = 1
        hurricane = 2
        severe_thunderstorms = 3
        thunderstorms = 4
        mixed_rain_and_snow = 5
        mixed_rain_and_sleet = 6
        mixed_snow_and_sleet = 7
        freezing_drizzle = 8
        drizzle = 9
        freezing_rain = 10
        showers = 11
        showers_ = 12
        snow_flurries = 13
        light_snow_showers = 14
        blowing_snow = 15
        snow = 16
        hail = 17
        sleet = 18
        dust = 19
        foggy = 20
        haze = 21
        smoky = 22
        blustery = 23
        windy = 24
        cold = 25
        cloudy = 26
        mostly_cloudy_night = 27
        mostly_cloudy_day = 28
        partly_cloudy_night = 29
        partly_cloudy_day = 30
        clear_night = 31
        sunny = 32
        fair_night = 33
        fair_day = 34
        mixed_rain_and_hail = 35
        hot = 36
        isolated_thunderstorms = 37
        scattered_thunderstorms = 38
        scattered_thunderstorms_ = 39
        scattered_showers = 40
        heavy_snow = 41
        scattered_snow_showers = 42
        heavy_snow_ = 43
        partly_cloudy = 44
        thundershowers = 45
        snow_showers = 46
        isolated_thundershowers = 47
        not_available = 3200
    End Enum

    Enum temperatureUnit
        Fahrenheit
        Celsius
    End Enum
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Location">The location to get the weather for</param>
    ''' <param name="Unit">Units for temperature.  f: Fahrenheit   c: Celsius</param>
    ''' <remarks></remarks>
    Sub New(ByVal Location As String, ByVal Unit As temperatureUnit)
        Dim doc As New System.Xml.XmlDocument()
        Dim Units As String
        If Unit = temperatureUnit.Celsius Then
            Units = "c"
        Else
            Units = "f"
        End If
        Dim RSSUrl As String = String.Format("http://xml.weather.yahoo.com/forecastrss?q={0}&u={1}", Location, Units)
        Dim RssData As pRssClass
        'Load data   
        doc.Load(RSSUrl)
        RSSUrl = doc.OuterXml


        'XmlSerializer could not Serialize XML with this Elements so i just replace them with Null String!
        RSSUrl = RSSUrl.Replace("yweather:", "")
        RSSUrl = RSSUrl.Replace("geo:", "")

        Dim memoryStream As New IO.MemoryStream()




        Dim RSSStringReader As New IO.StringReader(RSSUrl)


        Dim xs As New XmlSerializer(GetType(pRssClass))

        RssData = CType(xs.Deserialize(RSSStringReader), pRssClass)

        rss = RssData

    End Sub

    Private _rss As pRssClass
    <XmlElement()> _
    Public Property rss() As pRssClass
        Get
            Return _rss
        End Get
        Set(ByVal value As pRssClass)
            _rss = value
        End Set
    End Property
End Class

