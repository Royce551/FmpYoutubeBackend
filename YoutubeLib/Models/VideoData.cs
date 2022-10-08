using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeLib.Models
{
    public class VideoData
    {
        public Context context { get; set; }
        public Playbackcontext playbackContext { get; set; }
        public string videoId { get; set; }
    }

    public class Context
    {
        public Client client { get; set; }
    }

    public class Client
    {
        public string clientName { get; set; }
        public string clientVersion { get; set; }
    }

    public class Playbackcontext
    {
        public Contentplaybackcontext contentPlaybackContext { get; set; }
    }

    public class Contentplaybackcontext
    {
        public int signatureTimestamp { get; set; }
    }

}
