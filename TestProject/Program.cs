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
            var x = await Video.FromVideoIDAsync("J3DZVg_3niE");
            Console.WriteLine($"{x.Title}");
            Console.ReadLine();
        }
    }
}
