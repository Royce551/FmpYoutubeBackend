using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeLib.Models
{

    public class ClientData
    {
        public Responsecontext responseContext { get; set; }
        public Playabilitystatus playabilityStatus { get; set; }
        public Streamingdata streamingData { get; set; }
        public Playerad[] playerAds { get; set; }
        public Playbacktracking playbackTracking { get; set; }
        public Captions captions { get; set; }
        public Videodetails videoDetails { get; set; }
        public Annotation[] annotations { get; set; }
        public Playerconfig playerConfig { get; set; }
        public Storyboards storyboards { get; set; }
        public Microformat microformat { get; set; }
        public Cards cards { get; set; }
        public string trackingParams { get; set; }
        public Attestation attestation { get; set; }
        public Videoqualitypromosupportedrenderers videoQualityPromoSupportedRenderers { get; set; }
        public Message1[] messages { get; set; }
        public Adplacement[] adPlacements { get; set; }
        public Frameworkupdates frameworkUpdates { get; set; }
    }

    public class Responsecontext
    {
        public string visitorData { get; set; }
        public Servicetrackingparam[] serviceTrackingParams { get; set; }
        public Mainappwebresponsecontext mainAppWebResponseContext { get; set; }
        public Webresponsecontextextensiondata webResponseContextExtensionData { get; set; }
    }

    public class Mainappwebresponsecontext
    {
        public bool loggedOut { get; set; }
    }

    public class Webresponsecontextextensiondata
    {
        public bool hasDecorated { get; set; }
    }

    public class Servicetrackingparam
    {
        public string service { get; set; }
        public Param[] _params { get; set; }
    }

    public class Param
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Playabilitystatus
    {
        public string status { get; set; }
        public bool playableInEmbed { get; set; }
        public Miniplayer miniplayer { get; set; }
        public string contextParams { get; set; }
    }

    public class Miniplayer
    {
        public Miniplayerrenderer miniplayerRenderer { get; set; }
    }

    public class Miniplayerrenderer
    {
        public string playbackMode { get; set; }
    }

    public class Streamingdata
    {
        public string expiresInSeconds { get; set; }
        public Format[] formats { get; set; }
        public Adaptiveformat[] adaptiveFormats { get; set; }
    }

    public class Format
    {
        public int itag { get; set; }
        public string url { get; set; }
        public string mimeType { get; set; }
        public int bitrate { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string lastModified { get; set; }
        public string quality { get; set; }
        public int fps { get; set; }
        public string qualityLabel { get; set; }
        public string projectionType { get; set; }
        public string audioQuality { get; set; }
        public string approxDurationMs { get; set; }
        public string audioSampleRate { get; set; }
        public int audioChannels { get; set; }
    }

    public class Adaptiveformat
    {
        public int itag { get; set; }
        public string url { get; set; }
        public string mimeType { get; set; }
        public int bitrate { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Initrange initRange { get; set; }
        public Indexrange indexRange { get; set; }
        public string lastModified { get; set; }
        public string contentLength { get; set; }
        public string quality { get; set; }
        public int fps { get; set; }
        public string qualityLabel { get; set; }
        public string projectionType { get; set; }
        public int averageBitrate { get; set; }
        public string approxDurationMs { get; set; }
        public Colorinfo colorInfo { get; set; }
        public bool highReplication { get; set; }
        public string audioQuality { get; set; }
        public string audioSampleRate { get; set; }
        public int audioChannels { get; set; }
        public float loudnessDb { get; set; }
    }

    public class Initrange
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Indexrange
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Colorinfo
    {
        public string primaries { get; set; }
        public string transferCharacteristics { get; set; }
        public string matrixCoefficients { get; set; }
    }

    public class Playbacktracking
    {
        public Videostatsplaybackurl videostatsPlaybackUrl { get; set; }
        public Videostatsdelayplayurl videostatsDelayplayUrl { get; set; }
        public Videostatswatchtimeurl videostatsWatchtimeUrl { get; set; }
        public Ptrackingurl ptrackingUrl { get; set; }
        public Qoeurl qoeUrl { get; set; }
        public Atrurl atrUrl { get; set; }
        public int[] videostatsScheduledFlushWalltimeSeconds { get; set; }
        public int videostatsDefaultFlushIntervalSeconds { get; set; }
    }

    public class Videostatsplaybackurl
    {
        public string baseUrl { get; set; }
    }

    public class Videostatsdelayplayurl
    {
        public string baseUrl { get; set; }
    }

    public class Videostatswatchtimeurl
    {
        public string baseUrl { get; set; }
    }

    public class Ptrackingurl
    {
        public string baseUrl { get; set; }
    }

    public class Qoeurl
    {
        public string baseUrl { get; set; }
    }

    public class Atrurl
    {
        public string baseUrl { get; set; }
        public int elapsedMediaTimeSeconds { get; set; }
    }

    public class Captions
    {
        public Playercaptionstracklistrenderer playerCaptionsTracklistRenderer { get; set; }
    }

    public class Playercaptionstracklistrenderer
    {
        public Captiontrack[] captionTracks { get; set; }
        public Audiotrack[] audioTracks { get; set; }
        public Translationlanguage[] translationLanguages { get; set; }
        public int defaultAudioTrackIndex { get; set; }
    }

    public class Captiontrack
    {
        public string baseUrl { get; set; }
        public Name name { get; set; }
        public string vssId { get; set; }
        public string languageCode { get; set; }
        public bool isTranslatable { get; set; }
        public string kind { get; set; }
    }

    public class Name
    {
        public string simpleText { get; set; }
    }

    public class Audiotrack
    {
        public int[] captionTrackIndices { get; set; }
        public int defaultCaptionTrackIndex { get; set; }
        public string visibility { get; set; }
        public bool hasDefaultTrack { get; set; }
        public string captionsInitialState { get; set; }
    }

    public class Translationlanguage
    {
        public string languageCode { get; set; }
        public Languagename languageName { get; set; }
    }

    public class Languagename
    {
        public string simpleText { get; set; }
    }

    public class Videodetails
    {
        public string videoId { get; set; }
        public string title { get; set; }
        public string lengthSeconds { get; set; }
        public string channelId { get; set; }
        public bool isOwnerViewing { get; set; }
        public string shortDescription { get; set; }
        public bool isCrawlable { get; set; }
        public Thumbnail thumbnail { get; set; }
        public bool allowRatings { get; set; }
        public string viewCount { get; set; }
        public string author { get; set; }
        public bool isPrivate { get; set; }
        public bool isUnpluggedCorpus { get; set; }
        public bool isLiveContent { get; set; }
    }

    public class Thumbnail
    {
        public Thumbnail1[] thumbnails { get; set; }
    }

    public class Thumbnail1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Playerconfig
    {
        public Audioconfig audioConfig { get; set; }
        public Streamselectionconfig streamSelectionConfig { get; set; }
        public Mediacommonconfig mediaCommonConfig { get; set; }
        public Webplayerconfig webPlayerConfig { get; set; }
    }

    public class Audioconfig
    {
        public float loudnessDb { get; set; }
        public float perceptualLoudnessDb { get; set; }
        public bool enablePerFormatLoudness { get; set; }
    }

    public class Streamselectionconfig
    {
        public string maxBitrate { get; set; }
    }

    public class Mediacommonconfig
    {
        public Dynamicreadaheadconfig dynamicReadaheadConfig { get; set; }
    }

    public class Dynamicreadaheadconfig
    {
        public int maxReadAheadMediaTimeMs { get; set; }
        public int minReadAheadMediaTimeMs { get; set; }
        public int readAheadGrowthRateMs { get; set; }
    }

    public class Webplayerconfig
    {
        public Webplayeractionsporting webPlayerActionsPorting { get; set; }
    }

    public class Webplayeractionsporting
    {
        public Getsharepanelcommand getSharePanelCommand { get; set; }
        public Subscribecommand subscribeCommand { get; set; }
        public Unsubscribecommand unsubscribeCommand { get; set; }
        public Addtowatchlatercommand addToWatchLaterCommand { get; set; }
        public Removefromwatchlatercommand removeFromWatchLaterCommand { get; set; }
    }

    public class Getsharepanelcommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata commandMetadata { get; set; }
        public Webplayershareentityserviceendpoint webPlayerShareEntityServiceEndpoint { get; set; }
    }

    public class Commandmetadata
    {
        public Webcommandmetadata webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Webplayershareentityserviceendpoint
    {
        public string serializedShareEntity { get; set; }
    }

    public class Subscribecommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata1 commandMetadata { get; set; }
        public Subscribeendpoint subscribeEndpoint { get; set; }
    }

    public class Commandmetadata1
    {
        public Webcommandmetadata1 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata1
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Subscribeendpoint
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Unsubscribecommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata2 commandMetadata { get; set; }
        public Unsubscribeendpoint unsubscribeEndpoint { get; set; }
    }

    public class Commandmetadata2
    {
        public Webcommandmetadata2 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata2
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Unsubscribeendpoint
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Addtowatchlatercommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata3 commandMetadata { get; set; }
        public Playlisteditendpoint playlistEditEndpoint { get; set; }
    }

    public class Commandmetadata3
    {
        public Webcommandmetadata3 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata3
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Playlisteditendpoint
    {
        public string playlistId { get; set; }
        public Action[] actions { get; set; }
    }

    public class Action
    {
        public string addedVideoId { get; set; }
        public string action { get; set; }
    }

    public class Removefromwatchlatercommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata4 commandMetadata { get; set; }
        public Playlisteditendpoint1 playlistEditEndpoint { get; set; }
    }

    public class Commandmetadata4
    {
        public Webcommandmetadata4 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata4
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Playlisteditendpoint1
    {
        public string playlistId { get; set; }
        public Action1[] actions { get; set; }
    }

    public class Action1
    {
        public string action { get; set; }
        public string removedVideoId { get; set; }
    }

    public class Storyboards
    {
        public Playerstoryboardspecrenderer playerStoryboardSpecRenderer { get; set; }
    }

    public class Playerstoryboardspecrenderer
    {
        public string spec { get; set; }
    }

    public class Microformat
    {
        public Playermicroformatrenderer playerMicroformatRenderer { get; set; }
    }

    public class Playermicroformatrenderer
    {
        public Thumbnail2 thumbnail { get; set; }
        public Embed embed { get; set; }
        public Title title { get; set; }
        public Description description { get; set; }
        public string lengthSeconds { get; set; }
        public string ownerProfileUrl { get; set; }
        public string externalChannelId { get; set; }
        public bool isFamilySafe { get; set; }
        public string[] availableCountries { get; set; }
        public bool isUnlisted { get; set; }
        public bool hasYpcMetadata { get; set; }
        public string viewCount { get; set; }
        public string category { get; set; }
        public string publishDate { get; set; }
        public string ownerChannelName { get; set; }
        public string uploadDate { get; set; }
    }

    public class Thumbnail2
    {
        public Thumbnail3[] thumbnails { get; set; }
    }

    public class Thumbnail3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Embed
    {
        public string iframeUrl { get; set; }
        public string flashUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string flashSecureUrl { get; set; }
    }

    public class Title
    {
        public string simpleText { get; set; }
    }

    public class Description
    {
        public string simpleText { get; set; }
    }

    public class Cards
    {
        public Cardcollectionrenderer cardCollectionRenderer { get; set; }
    }

    public class Cardcollectionrenderer
    {
        public Card[] cards { get; set; }
        public Headertext headerText { get; set; }
        public Icon icon { get; set; }
        public Closebutton closeButton { get; set; }
        public string trackingParams { get; set; }
        public bool allowTeaserDismiss { get; set; }
        public bool logIconVisibilityUpdates { get; set; }
    }

    public class Headertext
    {
        public string simpleText { get; set; }
    }

    public class Icon
    {
        public Infocardiconrenderer infoCardIconRenderer { get; set; }
    }

    public class Infocardiconrenderer
    {
        public string trackingParams { get; set; }
    }

    public class Closebutton
    {
        public Infocardiconrenderer1 infoCardIconRenderer { get; set; }
    }

    public class Infocardiconrenderer1
    {
        public string trackingParams { get; set; }
    }

    public class Card
    {
        public Cardrenderer cardRenderer { get; set; }
    }

    public class Cardrenderer
    {
        public Teaser teaser { get; set; }
        public Cuerange[] cueRanges { get; set; }
        public string trackingParams { get; set; }
    }

    public class Teaser
    {
        public Simplecardteaserrenderer simpleCardTeaserRenderer { get; set; }
    }

    public class Simplecardteaserrenderer
    {
        public Message message { get; set; }
        public string trackingParams { get; set; }
        public bool prominent { get; set; }
        public bool logVisibilityUpdates { get; set; }
        public Ontapcommand onTapCommand { get; set; }
    }

    public class Message
    {
        public string simpleText { get; set; }
    }

    public class Ontapcommand
    {
        public string clickTrackingParams { get; set; }
        public Changeengagementpanelvisibilityaction changeEngagementPanelVisibilityAction { get; set; }
    }

    public class Changeengagementpanelvisibilityaction
    {
        public string targetId { get; set; }
        public string visibility { get; set; }
    }

    public class Cuerange
    {
        public string startCardActiveMs { get; set; }
        public string endCardActiveMs { get; set; }
        public string teaserDurationMs { get; set; }
        public string iconAfterTeaserMs { get; set; }
    }

    public class Attestation
    {
        public Playerattestationrenderer playerAttestationRenderer { get; set; }
    }

    public class Playerattestationrenderer
    {
        public string challenge { get; set; }
        public Botguarddata botguardData { get; set; }
    }

    public class Botguarddata
    {
        public string program { get; set; }
        public Interpretersafeurl interpreterSafeUrl { get; set; }
        public int serverEnvironment { get; set; }
    }

    public class Interpretersafeurl
    {
        public string privateDoNotAccessOrElseTrustedResourceUrlWrappedValue { get; set; }
    }

    public class Videoqualitypromosupportedrenderers
    {
        public Videoqualitypromorenderer videoQualityPromoRenderer { get; set; }
    }

    public class Videoqualitypromorenderer
    {
        public Triggercriteria triggerCriteria { get; set; }
        public Text text { get; set; }
        public Endpoint endpoint { get; set; }
        public string trackingParams { get; set; }
        public Snackbar snackbar { get; set; }
    }

    public class Triggercriteria
    {
        public string[] connectionWhitelist { get; set; }
        public int joinLatencySeconds { get; set; }
        public int rebufferTimeSeconds { get; set; }
        public int watchTimeWindowSeconds { get; set; }
        public int refractorySeconds { get; set; }
    }

    public class Text
    {
        public Run[] runs { get; set; }
    }

    public class Run
    {
        public string text { get; set; }
        public bool bold { get; set; }
    }

    public class Endpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata5 commandMetadata { get; set; }
        public Urlendpoint urlEndpoint { get; set; }
    }

    public class Commandmetadata5
    {
        public Webcommandmetadata5 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata5
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Urlendpoint
    {
        public string url { get; set; }
        public string target { get; set; }
    }

    public class Snackbar
    {
        public Notificationactionrenderer notificationActionRenderer { get; set; }
    }

    public class Notificationactionrenderer
    {
        public Responsetext responseText { get; set; }
        public Actionbutton actionButton { get; set; }
        public string trackingParams { get; set; }
    }

    public class Responsetext
    {
        public Run1[] runs { get; set; }
    }

    public class Run1
    {
        public string text { get; set; }
    }

    public class Actionbutton
    {
        public Buttonrenderer buttonRenderer { get; set; }
    }

    public class Buttonrenderer
    {
        public Text1 text { get; set; }
        public Navigationendpoint navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text1
    {
        public Run2[] runs { get; set; }
    }

    public class Run2
    {
        public string text { get; set; }
    }

    public class Navigationendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata6 commandMetadata { get; set; }
        public Urlendpoint1 urlEndpoint { get; set; }
    }

    public class Commandmetadata6
    {
        public Webcommandmetadata6 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata6
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Urlendpoint1
    {
        public string url { get; set; }
        public string target { get; set; }
    }

    public class Frameworkupdates
    {
        public Entitybatchupdate entityBatchUpdate { get; set; }
    }

    public class Entitybatchupdate
    {
        public Mutation[] mutations { get; set; }
        public Timestamp timestamp { get; set; }
    }

    public class Timestamp
    {
        public string seconds { get; set; }
        public int nanos { get; set; }
    }

    public class Mutation
    {
        public string entityKey { get; set; }
        public string type { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public Offlineabilityentity offlineabilityEntity { get; set; }
    }

    public class Offlineabilityentity
    {
        public string key { get; set; }
        public string addToOfflineButtonState { get; set; }
    }

    public class Playerad
    {
        public Playerlegacydesktopwatchadsrenderer playerLegacyDesktopWatchAdsRenderer { get; set; }
    }

    public class Playerlegacydesktopwatchadsrenderer
    {
        public Playeradparams playerAdParams { get; set; }
        public Gutparams gutParams { get; set; }
        public bool showCompanion { get; set; }
        public bool showInstream { get; set; }
        public bool useGut { get; set; }
    }

    public class Playeradparams
    {
        public bool showContentThumbnail { get; set; }
        public string enabledEngageTypes { get; set; }
    }

    public class Gutparams
    {
        public string tag { get; set; }
    }

    public class Annotation
    {
        public Playerannotationsexpandedrenderer playerAnnotationsExpandedRenderer { get; set; }
    }

    public class Playerannotationsexpandedrenderer
    {
        public Featuredchannel featuredChannel { get; set; }
        public bool allowSwipeDismiss { get; set; }
        public string annotationId { get; set; }
    }

    public class Featuredchannel
    {
        public string startTimeMs { get; set; }
        public string endTimeMs { get; set; }
        public Watermark watermark { get; set; }
        public string trackingParams { get; set; }
        public Navigationendpoint1 navigationEndpoint { get; set; }
        public string channelName { get; set; }
        public Subscribebutton subscribeButton { get; set; }
    }

    public class Watermark
    {
        public Thumbnail4[] thumbnails { get; set; }
    }

    public class Thumbnail4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Navigationendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata7 commandMetadata { get; set; }
        public Browseendpoint browseEndpoint { get; set; }
    }

    public class Commandmetadata7
    {
        public Webcommandmetadata7 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata7
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint
    {
        public string browseId { get; set; }
    }

    public class Subscribebutton
    {
        public Subscribebuttonrenderer subscribeButtonRenderer { get; set; }
    }

    public class Subscribebuttonrenderer
    {
        public Buttontext buttonText { get; set; }
        public bool subscribed { get; set; }
        public bool enabled { get; set; }
        public string type { get; set; }
        public string channelId { get; set; }
        public bool showPreferences { get; set; }
        public Subscribedbuttontext subscribedButtonText { get; set; }
        public Unsubscribedbuttontext unsubscribedButtonText { get; set; }
        public string trackingParams { get; set; }
        public Unsubscribebuttontext unsubscribeButtonText { get; set; }
        public Serviceendpoint[] serviceEndpoints { get; set; }
        public Subscribeaccessibility subscribeAccessibility { get; set; }
        public Unsubscribeaccessibility unsubscribeAccessibility { get; set; }
        public Signinendpoint signInEndpoint { get; set; }
    }

    public class Buttontext
    {
        public Run3[] runs { get; set; }
    }

    public class Run3
    {
        public string text { get; set; }
    }

    public class Subscribedbuttontext
    {
        public Run4[] runs { get; set; }
    }

    public class Run4
    {
        public string text { get; set; }
    }

    public class Unsubscribedbuttontext
    {
        public Run5[] runs { get; set; }
    }

    public class Run5
    {
        public string text { get; set; }
    }

    public class Unsubscribebuttontext
    {
        public Run6[] runs { get; set; }
    }

    public class Run6
    {
        public string text { get; set; }
    }

    public class Subscribeaccessibility
    {
        public Accessibilitydata accessibilityData { get; set; }
    }

    public class Accessibilitydata
    {
        public string label { get; set; }
    }

    public class Unsubscribeaccessibility
    {
        public Accessibilitydata1 accessibilityData { get; set; }
    }

    public class Accessibilitydata1
    {
        public string label { get; set; }
    }

    public class Signinendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata8 commandMetadata { get; set; }
    }

    public class Commandmetadata8
    {
        public Webcommandmetadata8 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata8
    {
        public string url { get; set; }
    }

    public class Serviceendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata9 commandMetadata { get; set; }
        public Subscribeendpoint1 subscribeEndpoint { get; set; }
        public Signalserviceendpoint signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata9
    {
        public Webcommandmetadata9 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata9
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Subscribeendpoint1
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Signalserviceendpoint
    {
        public string signal { get; set; }
        public Action2[] actions { get; set; }
    }

    public class Action2
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction openPopupAction { get; set; }
    }

    public class Openpopupaction
    {
        public Popup popup { get; set; }
        public string popupType { get; set; }
    }

    public class Popup
    {
        public Confirmdialogrenderer confirmDialogRenderer { get; set; }
    }

    public class Confirmdialogrenderer
    {
        public string trackingParams { get; set; }
        public Dialogmessage[] dialogMessages { get; set; }
        public Confirmbutton confirmButton { get; set; }
        public Cancelbutton cancelButton { get; set; }
        public bool primaryIsCancel { get; set; }
    }

    public class Confirmbutton
    {
        public Buttonrenderer1 buttonRenderer { get; set; }
    }

    public class Buttonrenderer1
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text2 text { get; set; }
        public Serviceendpoint1 serviceEndpoint { get; set; }
        public Accessibility accessibility { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text2
    {
        public Run7[] runs { get; set; }
    }

    public class Run7
    {
        public string text { get; set; }
    }

    public class Serviceendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata10 commandMetadata { get; set; }
        public Unsubscribeendpoint1 unsubscribeEndpoint { get; set; }
    }

    public class Commandmetadata10
    {
        public Webcommandmetadata10 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata10
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Unsubscribeendpoint1
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Accessibility
    {
        public string label { get; set; }
    }

    public class Cancelbutton
    {
        public Buttonrenderer2 buttonRenderer { get; set; }
    }

    public class Buttonrenderer2
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text3 text { get; set; }
        public Accessibility1 accessibility { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text3
    {
        public Run8[] runs { get; set; }
    }

    public class Run8
    {
        public string text { get; set; }
    }

    public class Accessibility1
    {
        public string label { get; set; }
    }

    public class Dialogmessage
    {
        public Run9[] runs { get; set; }
    }

    public class Run9
    {
        public string text { get; set; }
    }

    public class Message1
    {
        public Mealbarpromorenderer mealbarPromoRenderer { get; set; }
        public Tooltiprenderer tooltipRenderer { get; set; }
    }

    public class Mealbarpromorenderer
    {
        public Messagetext[] messageTexts { get; set; }
        public Actionbutton1 actionButton { get; set; }
        public Dismissbutton dismissButton { get; set; }
        public string triggerCondition { get; set; }
        public string style { get; set; }
        public string trackingParams { get; set; }
        public Impressionendpoint[] impressionEndpoints { get; set; }
        public bool isVisible { get; set; }
        public Messagetitle messageTitle { get; set; }
    }

    public class Actionbutton1
    {
        public Buttonrenderer3 buttonRenderer { get; set; }
    }

    public class Buttonrenderer3
    {
        public string style { get; set; }
        public string size { get; set; }
        public Text4 text { get; set; }
        public string trackingParams { get; set; }
        public Command command { get; set; }
    }

    public class Text4
    {
        public Run10[] runs { get; set; }
    }

    public class Run10
    {
        public string text { get; set; }
    }

    public class Command
    {
        public string clickTrackingParams { get; set; }
        public Commandexecutorcommand commandExecutorCommand { get; set; }
    }

    public class Commandexecutorcommand
    {
        public Command1[] commands { get; set; }
    }

    public class Command1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata11 commandMetadata { get; set; }
        public Urlendpoint2 urlEndpoint { get; set; }
        public Feedbackendpoint feedbackEndpoint { get; set; }
    }

    public class Commandmetadata11
    {
        public Webcommandmetadata11 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata11
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Urlendpoint2
    {
        public string url { get; set; }
        public string target { get; set; }
    }

    public class Feedbackendpoint
    {
        public string feedbackToken { get; set; }
        public Uiactions uiActions { get; set; }
    }

    public class Uiactions
    {
        public bool hideEnclosingContainer { get; set; }
    }

    public class Dismissbutton
    {
        public Buttonrenderer4 buttonRenderer { get; set; }
    }

    public class Buttonrenderer4
    {
        public string style { get; set; }
        public string size { get; set; }
        public Text5 text { get; set; }
        public string trackingParams { get; set; }
        public Command2 command { get; set; }
    }

    public class Text5
    {
        public Run11[] runs { get; set; }
    }

    public class Run11
    {
        public string text { get; set; }
    }

    public class Command2
    {
        public string clickTrackingParams { get; set; }
        public Commandexecutorcommand1 commandExecutorCommand { get; set; }
    }

    public class Commandexecutorcommand1
    {
        public Command3[] commands { get; set; }
    }

    public class Command3
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata12 commandMetadata { get; set; }
        public Feedbackendpoint1 feedbackEndpoint { get; set; }
    }

    public class Commandmetadata12
    {
        public Webcommandmetadata12 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata12
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Feedbackendpoint1
    {
        public string feedbackToken { get; set; }
        public Uiactions1 uiActions { get; set; }
    }

    public class Uiactions1
    {
        public bool hideEnclosingContainer { get; set; }
    }

    public class Messagetitle
    {
        public Run12[] runs { get; set; }
    }

    public class Run12
    {
        public string text { get; set; }
    }

    public class Messagetext
    {
        public Run13[] runs { get; set; }
    }

    public class Run13
    {
        public string text { get; set; }
    }

    public class Impressionendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata13 commandMetadata { get; set; }
        public Feedbackendpoint2 feedbackEndpoint { get; set; }
    }

    public class Commandmetadata13
    {
        public Webcommandmetadata13 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata13
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Feedbackendpoint2
    {
        public string feedbackToken { get; set; }
        public Uiactions2 uiActions { get; set; }
    }

    public class Uiactions2
    {
        public bool hideEnclosingContainer { get; set; }
    }

    public class Tooltiprenderer
    {
        public Promoconfig promoConfig { get; set; }
        public string targetId { get; set; }
        public Text6 text { get; set; }
        public Detailstext detailsText { get; set; }
        public Dismissbutton1 dismissButton { get; set; }
        public Suggestedposition suggestedPosition { get; set; }
        public Dismissstrategy dismissStrategy { get; set; }
        public string dwellTimeMs { get; set; }
        public string trackingParams { get; set; }
        public string triggerCondition { get; set; }
    }

    public class Promoconfig
    {
        public string promoId { get; set; }
        public Impressionendpoint1[] impressionEndpoints { get; set; }
        public Acceptcommand acceptCommand { get; set; }
        public Dismisscommand dismissCommand { get; set; }
    }

    public class Acceptcommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata14 commandMetadata { get; set; }
        public Feedbackendpoint3 feedbackEndpoint { get; set; }
    }

    public class Commandmetadata14
    {
        public Webcommandmetadata14 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata14
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Feedbackendpoint3
    {
        public string feedbackToken { get; set; }
        public Uiactions3 uiActions { get; set; }
    }

    public class Uiactions3
    {
        public bool hideEnclosingContainer { get; set; }
    }

    public class Dismisscommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata15 commandMetadata { get; set; }
        public Feedbackendpoint4 feedbackEndpoint { get; set; }
    }

    public class Commandmetadata15
    {
        public Webcommandmetadata15 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata15
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Feedbackendpoint4
    {
        public string feedbackToken { get; set; }
        public Uiactions4 uiActions { get; set; }
    }

    public class Uiactions4
    {
        public bool hideEnclosingContainer { get; set; }
    }

    public class Impressionendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata16 commandMetadata { get; set; }
        public Feedbackendpoint5 feedbackEndpoint { get; set; }
    }

    public class Commandmetadata16
    {
        public Webcommandmetadata16 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata16
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Feedbackendpoint5
    {
        public string feedbackToken { get; set; }
        public Uiactions5 uiActions { get; set; }
    }

    public class Uiactions5
    {
        public bool hideEnclosingContainer { get; set; }
    }

    public class Text6
    {
        public Run14[] runs { get; set; }
    }

    public class Run14
    {
        public string text { get; set; }
    }

    public class Detailstext
    {
        public Run15[] runs { get; set; }
    }

    public class Run15
    {
        public string text { get; set; }
    }

    public class Dismissbutton1
    {
        public Buttonrenderer5 buttonRenderer { get; set; }
    }

    public class Buttonrenderer5
    {
        public string size { get; set; }
        public Text7 text { get; set; }
        public string trackingParams { get; set; }
        public Command4 command { get; set; }
    }

    public class Text7
    {
        public Run16[] runs { get; set; }
    }

    public class Run16
    {
        public string text { get; set; }
    }

    public class Command4
    {
        public string clickTrackingParams { get; set; }
        public Commandexecutorcommand2 commandExecutorCommand { get; set; }
    }

    public class Commandexecutorcommand2
    {
        public Command5[] commands { get; set; }
    }

    public class Command5
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata17 commandMetadata { get; set; }
        public Feedbackendpoint6 feedbackEndpoint { get; set; }
    }

    public class Commandmetadata17
    {
        public Webcommandmetadata17 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata17
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Feedbackendpoint6
    {
        public string feedbackToken { get; set; }
        public Uiactions6 uiActions { get; set; }
    }

    public class Uiactions6
    {
        public bool hideEnclosingContainer { get; set; }
    }

    public class Suggestedposition
    {
        public string type { get; set; }
    }

    public class Dismissstrategy
    {
        public string type { get; set; }
    }

    public class Adplacement
    {
        public Adplacementrenderer adPlacementRenderer { get; set; }
    }

    public class Adplacementrenderer
    {
        public Config config { get; set; }
        public Renderer renderer { get; set; }
    }

    public class Config
    {
        public Adplacementconfig adPlacementConfig { get; set; }
    }

    public class Adplacementconfig
    {
        public string kind { get; set; }
        public Adtimeoffset adTimeOffset { get; set; }
        public bool hideCueRangeMarker { get; set; }
    }

    public class Adtimeoffset
    {
        public string offsetStartMilliseconds { get; set; }
        public string offsetEndMilliseconds { get; set; }
    }

    public class Renderer
    {
        public Adbreakservicerenderer adBreakServiceRenderer { get; set; }
    }

    public class Adbreakservicerenderer
    {
        public string prefetchMilliseconds { get; set; }
        public string getAdBreakUrl { get; set; }
    }

}
