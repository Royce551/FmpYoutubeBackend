using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeLib
{
    public class AudioStream : Stream
    {
        public AudioQuality Quality { get; }
        public string Container { get; }
        public string Codec { get; }

        public AudioStream(string url, AudioQuality quality, string container, string codec) : base(url)
        {
            Quality = quality;
            Container = container;
            Codec = codec;
        }
    }
}
