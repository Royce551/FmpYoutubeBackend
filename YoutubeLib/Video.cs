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

        public static async Task<Stream[]> GetStreamsAsync()
        {

        }
    }
}
