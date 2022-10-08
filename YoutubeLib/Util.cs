using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YoutubeLib.Models;

namespace YoutubeLib
{
    internal class Util
    {
        private static Dictionary<string, ClientData> cachedPlayerData = new Dictionary<string, ClientData>();
        private static Dictionary<string, ClientData> cachedPlayerDataTVClient = new Dictionary<string, ClientData>();
        private static Dictionary<string, string> cachedPlayerHTML = new Dictionary<string, string>();
        private static Dictionary<string, string> cachedPlayerJS = new Dictionary<string, string>();

        private static HttpClient httpClient;

        static Util()
        {
            httpClient = new HttpClient();
        }

        public static async Task<ClientData> GetPlayerData(string videoID, bool useTVClient = false)
        {
            if (useTVClient)
            {
                if (cachedPlayerDataTVClient.TryGetValue(videoID, out ClientData videoData)) return videoData;
            }
            else
            {
                if (cachedPlayerData.TryGetValue(videoID, out ClientData videoData)) return videoData;
            }

            var signatureTimeStamp = await GetSignatureTimeStampAsync(videoID);
            VideoData data;
            if (useTVClient)
            {
                data = new VideoData()
                {
                    context = new Context()
                    {
                        client = new Client()
                        {
                            clientName = "TVHTML5_SIMPLY_EMBEDDED_PLAYER",
                            clientVersion = "2.0",
                        }
                    },
                    playbackContext = new Playbackcontext()
                    {
                        contentPlaybackContext = new Contentplaybackcontext()
                        {
                            signatureTimestamp = signatureTimeStamp
                        }
                    },
                    videoId = videoID
                };
            }
            else
            {
                data = new VideoData()
                {
                    context = new Context()
                    {
                        client = new Client()
                        {
                            clientName = "WEB",
                            clientVersion = "2.20221006.00.00",
                        }
                    },
                    playbackContext = new Playbackcontext()
                    {
                        contentPlaybackContext = new Contentplaybackcontext()
                        {
                            signatureTimestamp = signatureTimeStamp
                        }
                    },
                    videoId = videoID
                };
            }

            var response = await PostAPIAsync("https://www.youtube.com/youtubei/v1/player?key=AIzaSyAO_FJ2SlqU8Q4STEHLGCilw_Y9_11qcW8", JsonConvert.SerializeObject(data));
            var responseJson = JsonConvert.DeserializeObject<ClientData>(response);

            if (useTVClient) cachedPlayerDataTVClient.Add(videoID, responseJson);
            else cachedPlayerData.Add(videoID, responseJson);
            return responseJson;
        }

        private static async Task<string> PostAPIAsync(string endpoint, string body)
        {
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(endpoint, content);

            return await response.Content.ReadAsStringAsync();
        }

        private static async Task<int> GetSignatureTimeStampAsync(string videoID)
        {
            var playerJS = await GetPlayerJSAsync(videoID);
            var signatureTimeStampExpression = new Regex(@"(?<=\.sts="")[0-9]+(?="")");
            var x = signatureTimeStampExpression.Match(playerJS).Value;
            return int.Parse(x);
        }

        private static async Task<string> GetPlayerJSAsync(string videoID)
        {
            if (cachedPlayerJS.TryGetValue(videoID, out string playerJS)) return playerJS;

            var html = await GetPlayerHTMLAsync(videoID);
            var jsExpression = new Regex(@"\/s\/player\/[A-z0-9-_.\/]+\/base\.js");
            var jsURL = jsExpression.Match(html).Value;

            var js = await httpClient.GetStringAsync($"https://www.youtube.com{jsURL}");
            cachedPlayerJS.Add(videoID, js);
            return js;
        }

        private static async Task<string> GetPlayerHTMLAsync(string videoID)
        {
            if (cachedPlayerHTML.TryGetValue(videoID, out string playerHTML)) return playerHTML;

            var html = await httpClient.GetStringAsync($"https://www.youtube.com/watch?v={videoID}");
            cachedPlayerHTML.Add(videoID, html);
            return html;
        }
    }
}
