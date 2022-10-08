using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeLib
{
    public class VideoThumbnail
    {
        public string URL { get; }
        public int Width { get; }
        public int Height { get; }

        public VideoThumbnail(string url, int width, int height)
        {
            URL = url;
            Width = width;
            Height = height;
        }
    }
}
