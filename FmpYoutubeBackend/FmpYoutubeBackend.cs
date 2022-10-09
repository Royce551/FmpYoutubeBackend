using FRESHMusicPlayer.Backends;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Composition;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YoutubeLib;

namespace FmpYoutubeBackend
{
    [Export(typeof(IAudioBackend))]
    public class FmpYoutubeBackend : IAudioBackend
    {
        public WaveOutEvent OutputDevice;

        public event EventHandler<EventArgs> OnPlaybackStopped;

        public AudioFileReader AudioFile { get; set; }

        public float Volume
        {
            get => AudioFile.Volume;
            set => AudioFile.Volume = value;
        }
        public TimeSpan CurrentTime
        {
            get => AudioFile.CurrentTime;
            set => AudioFile.CurrentTime = value;
        }
        public TimeSpan TotalTime => AudioFile.TotalTime;

        public FmpYoutubeBackend()
        {
            if (OutputDevice is null)
            {
                OutputDevice = new WaveOutEvent();
                OutputDevice.PlaybackStopped += (object o, StoppedEventArgs e) =>
                {
                    OnPlaybackStopped.Invoke(null, EventArgs.Empty);
                };
            }
        }

        public void Dispose()
        {
            OutputDevice?.Dispose();
            AudioFile?.Dispose();
        }

        public async Task<IMetadataProvider> GetMetadataAsync(string file)
        {
            var id = new Regex(@"https\:\/\/www\.youtube\.com\/watch\?v=([\w-]{11})").Match(file).Groups[1].Value;
            var video = await Video.FromVideoIDAsync(id);
            var ytm = new YoutubeMetadataProvider(video);
            await ytm.Initialize();
            return ytm;
        }

        public async Task<BackendLoadResult> LoadSongAsync(string file)
        {
            var match = new Regex(@"https\:\/\/www\.youtube\.com\/watch\?v=([\w-]{11})").Match(file);
            if (!match.Success) return BackendLoadResult.Invalid;
            var id = match.Groups[1].Value;
            var video = await Video.FromVideoIDAsync(id);
            var streams = await video.GetStreamsAsync();

            string selectedURL = null;

            foreach (var stream in streams)
            {
                if (stream is AudioStream audioStream)
                {
                    if (audioStream.Container == "mp4" && audioStream.Codec == "mp4a.40.2")
                        selectedURL = stream.URL;
                }
            }

            if (AudioFile != null) AudioFile.Dispose();
            try
            {
                await Task.Run(() =>
                {
                    AudioFile = new AudioFileReader(selectedURL);
                    OutputDevice.Init(AudioFile);
                });
            }
            catch (ArgumentException)
            {
                return BackendLoadResult.Invalid;
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                return BackendLoadResult.Invalid;
            }
            catch (FormatException)
            {
                return BackendLoadResult.Corrupt;
            }
            catch (InvalidOperationException)
            {
                return BackendLoadResult.Invalid;
            }
            return BackendLoadResult.OK;
        }

        public void Pause()
        {
            OutputDevice.Pause();
        }

        public void Play()
        {
            OutputDevice.Play();
        }
    }

    public class YoutubeMetadataProvider : IMetadataProvider
    {
        public string Title { get; set; }
        public string[] Artists { get; set; }
        public string Album { get; set; }
        public byte[] CoverArt { get; set; }
        public string[] Genres { get; set; }
        public int Year { get; set; }
        public int TrackNumber { get; set; }
        public int TrackTotal { get; set; }
        public int DiscNumber { get; set; }
        public int DiscTotal { get; set; }
        public int Length { get; set; }

        private HttpClient httpClient = new HttpClient();
        private Video video;
        public YoutubeMetadataProvider(Video video)
        {
            this.video = video;
        }

        public async Task Initialize()
        {
            Title = video.Title;
            Artists = new string[] { video.ChannelName };
            Album = string.Empty;
            foreach (var thumbnail in video.Thumbnails)
            {
                var response = await httpClient.GetAsync(thumbnail.URL);
                var imageData = await response.Content.ReadAsStreamAsync();
                using (var memoryStream = new MemoryStream())
                {
                    await imageData.CopyToAsync(memoryStream);
                    CoverArt = memoryStream.ToArray();
                }
            }
            Genres = new string[] { video.Category };
            Year = 0;
            TrackNumber = 0;
            DiscNumber = 0;
            DiscTotal = 0;
            Length = (int)Math.Round(video.Duration.TotalSeconds);
        }
    }
}
