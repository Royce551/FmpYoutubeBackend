using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeLib
{
    public class VideoStream : Stream
    {
        public int Width { get; }
        public int Height { get; }
        public int FPS { get; }
        public VideoQuality Quality { get; }
        public string Container { get; }
        public string Codec { get; }

        public VideoStream(string url, int width, int height, int fPS, VideoQuality quality, string container, string codec) : base(url)
        {
            Width = width;
            Height = height;
            FPS = fPS;
            Quality = quality;
            Container = container;
            Codec = codec;
        }
    }
}
