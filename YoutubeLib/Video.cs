using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeLib
{
    public class Video
    {
        public string VideoId { get; }
        public string Title { get; }
        public string Description { get; }
        public TimeSpan Duration { get; }
        public float ViewCount { get; }
        public string ChannelName { get; }
        public string ChannelUrl { get; }
        public string ChannelId { get; }
        public string Category { get; }
        public bool AreRatingsAllowed { get; }
        public bool IsPrivate { get; }
        public bool IsUnlisted { get; }
        public bool IsFamilySafe { get; }
        public VideoThumbnail[] Thumbnails { get; }

        public Video(string videoId, string title, string description, TimeSpan duration, float viewCount, string channelName, string channelUrl, string channelId, string category, bool areRatingsAllowed, bool isPrivate, bool isUnlisted, bool isFamilySafe, VideoThumbnail[] thumbnails)
        {
            VideoId = videoId;
            Title = title;
            Description = description;
            Duration = duration;
            ViewCount = viewCount;
            ChannelName = channelName;
            ChannelUrl = channelUrl;
            ChannelId = channelId;
            Category = category;
            AreRatingsAllowed = areRatingsAllowed;
            IsPrivate = isPrivate;
            IsUnlisted = isUnlisted;
            Thumbnails = thumbnails;
        }

        public static async Task<Video> FromVideoIDAsync(string videoID)
        {
            var data = await Util.GetPlayerData(videoID);

            return new Video(
                videoID,
                data.videoDetails.title,
                data.videoDetails.shortDescription,
                TimeSpan.FromSeconds(float.Parse(data.videoDetails.lengthSeconds)),
                float.Parse(data.videoDetails.viewCount),
                data.videoDetails.author,
                data.microformat.playerMicroformatRenderer.ownerProfileUrl,
                data.videoDetails.channelId,
                data.microformat.playerMicroformatRenderer.category,
                data.videoDetails.allowRatings, data.videoDetails.isPrivate,
                data.microformat.playerMicroformatRenderer.isUnlisted,
                data.microformat.playerMicroformatRenderer.isFamilySafe,
                data.videoDetails.thumbnail.thumbnails.Select(x => new VideoThumbnail(x.url, x.width, x.height)).ToArray()
                );
        }

        public async Task<Stream[]> GetStreamsAsync()
        {
            var streams = new List<Stream>();

            var data = await Util.GetPlayerData(VideoId);
            if (data.playabilityStatus.status != "OK")
                data = await Util.GetPlayerData(VideoId, true);
            var streamingData = data.streamingData;

            var formats = streamingData.formats;
            foreach (var format in formats)
            {
                var url = format.url ?? await Util.DecypherSignatureUrlAsync(VideoId, format.signatureCipher);
                var mimeType = format.mimeType;
                var width = format.width;
                var height = format.height;
                var fps = format.fps;
                VideoQuality videoQuality = default;
                switch (format.quality)
                {
                    case "tiny":
                        videoQuality = VideoQuality.Tiny;
                        break;
                    case "small":
                        videoQuality = VideoQuality.Small;
                        break;
                    case "medium":
                        videoQuality = VideoQuality.Medium;
                        break;
                    case "large":
                        videoQuality = VideoQuality.Large;
                        break;
                    case "hd720":
                        videoQuality = VideoQuality.HD720;
                        break;
                    case "hd1080":
                        videoQuality = VideoQuality.HD1080;
                        break;
                }
                AudioQuality audioQuality = default;
                switch (format.audioQuality)
                {
                    case "AUDIO_QUALITY_LOW":
                        audioQuality = AudioQuality.Low;
                        break;
                    case "AUDIO_QUALITY_MEDIUM":
                        audioQuality = AudioQuality.Medium;
                        break;
                }
                var mimeTypeSplit = mimeType.Split('/')[1];
                var container = mimeTypeSplit.Split(';')[0];
                var codecs = mimeType.Split('"')[1].Split(',');
                var videoCodec = codecs[0];
                var audioCodec = codecs[1].Trim();
                streams.Add(new MuxedStream(url, width, height, fps, videoQuality, audioQuality, container, videoCodec, audioCodec));
            }
            foreach (var format in streamingData.adaptiveFormats)
            {
                var url = format.url ?? await Util.DecypherSignatureUrlAsync(VideoId, format.signatureCipher);
                var mimeType = format.mimeType;
                var mimeTypeSplit = mimeType.Split('/');
                var type = mimeTypeSplit[0];
                var mimeTypeSplit2 = mimeTypeSplit[1];
                var container = mimeTypeSplit2.Split(';')[0];
                var codec = mimeType.Split('"')[1];
                Stream stream = null;
                switch (type)
                {
                    case "audio":
                        AudioQuality quality = default;
                        switch (format.audioQuality)
                        {
                            case "AUDIO_QUALITY_LOW":
                                quality = AudioQuality.Low;
                                break;
                            case "AUDIO_QUALITY_MEDIUM":
                                quality = AudioQuality.Medium;
                                break;
                        }
                        stream = new AudioStream(url, quality, container, codec);
                        break;
                    case "video":
                        var width = format.width;
                        var height = format.height;
                        var fps = format.fps;
                        VideoQuality qualityx = default;
                        switch (format.quality)
                        {
                            case "tiny":
                                qualityx = VideoQuality.Tiny;
                                break;
                            case "small":
                                qualityx = VideoQuality.Small;
                                break;
                            case "medium":
                                qualityx = VideoQuality.Medium;
                                break;
                            case "large":
                                qualityx = VideoQuality.Large;
                                break;
                            case "hd720":
                                qualityx = VideoQuality.HD720;
                                break;
                            case "hd1080":
                                qualityx = VideoQuality.HD1080;
                                break;
                        }
                        stream = new VideoStream(url, width, height, fps, qualityx, container, codec);
                        break;
                }
                streams.Add(stream);
            }

            return streams.ToArray();
        }
    }
}
