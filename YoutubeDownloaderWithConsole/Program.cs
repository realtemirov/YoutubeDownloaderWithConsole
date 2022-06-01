using System;
using System.IO;
using System.Linq;
using VideoLibrary;

namespace YoutubeDownloaderWithConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            var youtube = YouTube.Default;
            var allVidoes = youtube.GetAllVideos(url);
            var videos = allVidoes.FirstOrDefault(x => (x.Resolution == 720) && (x.Format == VideoFormat.Mp4));

            byte[] bytres = videos.GetBytes();
            File.WriteAllBytes("c:\\" + videos.FullName + "-" + videos.Resolution + ".mp4", bytres);
        }
    }
}
