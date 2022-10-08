using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeLib
{
    public class MuxedStream : Stream
    {
        public int Width { get; }
        public int Height { get; }
        public int FPS { get; }
        public VideoQuality VideoQuality { get; }
        public AudioQuality AudioQuality { get; }
        public string Container { get; }
        public string VideoCodec { get; }
        public string AudioCodec { get; }

        public MuxedStream(string url, int width, int height, int fPS, VideoQuality videoQuality, AudioQuality audioQuality, string container, string videoCodec, string audioCodec) : base(url)        {
            Width = width;
            Height = height;
            FPS = fPS;
            VideoQuality = videoQuality;
            AudioQuality = audioQuality;
            Container = container;
            VideoCodec = videoCodec;
            AudioCodec = audioCodec;
        }

    }
}
