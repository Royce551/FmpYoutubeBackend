using FRESHMusicPlayer.Backends;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FmpYoutubeBackend
{
    [Export(typeof(IAudioBackend))]
    public class FmpYoutubeBackend : IAudioBackend
    {
        public TimeSpan CurrentTime { get; set; }
        public TimeSpan TotalTime { get; }
        public float Volume { get; set; }

        public event EventHandler<EventArgs> OnPlaybackStopped;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IMetadataProvider> GetMetadataAsync(string file)
        {
            throw new NotImplementedException();
        }

        public Task<BackendLoadResult> LoadSongAsync(string file)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
