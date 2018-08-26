Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Imports System.Text.RegularExpressions
Partial Class pWeatherForecast
    Partial Class pRssClass
        Partial Class pChannelClass
            Public Class pItemClass
                Private _title As String
                ''' <summary>
                '''  The forecast title and time, for example "Conditions for New York, NY at 1:51 pm EST" 
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
                '''  The Yahoo! Weather URL for this forecast. 
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

                Private _description As String
                ''' <summary>
                '''  A simple summary of the current conditions and two-day forecast, in HTML format, including a link to Yahoo! Weather for the full forecast.
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


                Public ReadOnly Property ImageURL() As String
                    Get
                        'Dim regex As New Text.RegularExpressions.Regex("")
                        'Return regex.Replace(_description, "(?<=<img\s+[^>]*?src=(?<q>['""]))(?<url>.+?)(?=\k<q>)")
                        Dim srcRegEx As New Regex("src=['|""](?<url>.*?)['|""]", RegexOptions.IgnoreCase Or RegexOptions.CultureInvariant Or RegexOptions.IgnorePatternWhitespace Or RegexOptions.Compiled)
                        ' Return srcRegEx.Replace(_description, New MatchEvaluator(AddressOf ConvertToRelative))
                        Return srcRegEx.Match(_description).Value.Substring(5).Replace("""", "").Replace("'", "")

                    End Get

                End Property

                Private Function ConvertToRelative(ByVal input As Match) As String
                    Dim tempUri As New Uri(input.Groups("url").Value)
                    Return String.Format("src='{0}'", tempUri.LocalPath)
                End Function

                Private _guid As String
                ''' <summary>
                '''  Unique identifier for the forecast, made up of the location ID, the date, and the time. The attribute isPermaLink is false. 
                ''' </summary>
                <XmlElement()> _
                Public Property guid() As String
                    Get
                        Return _guid
                    End Get
                    Set(ByVal value As String)
                        _guid = value
                    End Set
                End Property

                Private _pubDate As String
                ''' <summary>
                '''  The date and time this forecast was posted, in the date format defined by RFC822 Section 5, for example Mon, 25 Sep 17:25:18 -0700. 
                ''' </summary>
                <XmlElement()> _
                Public Property pubDate() As String
                    Get
                        Return _pubDate
                    End Get
                    Set(ByVal value As String)
                        _pubDate = value
                    End Set
                End Property

                Private _lat As String
                ''' <summary>
                '''  The latitude of the location.
                ''' </summary>
                <XmlElement()> _
                Public Property lat() As String
                    Get
                        Return _lat
                    End Get
                    Set(ByVal value As String)
                        _lat = value
                    End Set
                End Property


                Private _long As String
                ''' <summary>
                '''  The longitude of the location
                ''' </summary>
                <XmlElement()> _
                Public Property [long]() As String
                    Get
                        Return _long
                    End Get
                    Set(ByVal value As String)
                        _long = value
                    End Set
                End Property

                Private _condition As pConditionClass
                ''' <summary>
                '''  The longitude of the location
                ''' </summary>
                <XmlElement()> _
                Public Property condition() As pConditionClass
                    Get
                        Return _condition
                    End Get
                    Set(ByVal value As pConditionClass)
                        _condition = value
                    End Set
                End Property

                Private _forecast As pForecastClass
                ''' <summary>
                '''  The longitude of the location
                ''' </summary>
                <XmlElement()> _
                Public Property forecast() As pForecastClass
                    Get
                        Return _forecast
                    End Get
                    Set(ByVal value As pForecastClass)
                        _forecast = value
                    End Set
                End Property


            End Class
        End Class
    End Class
End Class
