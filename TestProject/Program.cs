using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeLib;

namespace TestProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var url = Console.ReadLine();
            var x = await Video.FromVideoIDAsync(url);
            var y = await x.GetStreamsAsync();
            foreach (var z in y)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine($"{z.URL}");
                if (z is AudioStream aus)
                    Console.WriteLine($"codec - {aus.Codec}  container - {aus.Container}");
                else if (z is VideoStream vis)
                    Console.WriteLine($"codec - {vis.Codec}  container - {vis.Container}");
            }
            Console.ReadLine();
        }
    }
}
