using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.ClosedCaptions;
using YoutubeExplode.Videos.Streams;

namespace YouTubeDownload
{
    /// <summary>
    /// Адресат комманды
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Метод для получения информации по видео
        /// </summary>
        /// <returns></returns>
        public async Task Informatoins()
        {
            Console.WriteLine("Введите ссылку на скачиваемое видео для получения информации");
            string videoUrl = Console.ReadLine();

            var youTube = new YoutubeClient();

            var video = await youTube.Videos.GetAsync(videoUrl);

            var title = video.Title;
            var author = video.Author.ChannelTitle;
            var duration = video.Duration;
            Console.WriteLine($"Название видео: {title}\n,Автор: {author}\n,Длительность: {duration}");
        }
        /// <summary>
        /// Метод для скачивания видно
        /// </summary>
        /// <returns></returns>
        public async Task DownloadVideo()
        {
            Console.WriteLine("Введите ссылку на скачиваемое видео для скачивания видео");
            string videoUrl = Console.ReadLine();
            //Указываю удобный мне путь
            string parth = "D:\\SkillFactory\\Video.mp4";

            var youTube = new YoutubeClient();
            var streamManifest = await youTube.Videos.Streams.GetManifestAsync(videoUrl);

            var streamInfo = streamManifest
                .GetVideoOnlyStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();
            var stream = await youTube.Videos.Streams.GetAsync(streamInfo);

            if (File.Exists(parth))
            {
                File.Delete(parth);
                Console.WriteLine("Старый файл удален!");
            }
            if (!File.Exists(parth))
            {
                await youTube.Videos.Streams.DownloadAsync(streamInfo, parth);
            }
        }

    }
}
