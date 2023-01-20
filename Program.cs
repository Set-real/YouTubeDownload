using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace YouTubeDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, что бы вы хотели сделать, скачать видео или полуить по нему информацию?\n " +
                "Для получения информации по видед нажмите 1, для запуска скачивания нажмите 2");
            string resalt = Console.ReadLine();

            var sender = new Sender();
            var reciver = new Receiver();

            var CommandGetInfo = new CommandGetInfo(reciver);

            sender.SetCommand(CommandGetInfo);

            while (true)
            {
                switch (resalt)
                {
                    case "1":
                        {
                            sender.ShowInfo();
                        }
                        break;
                    case "2":
                        {
                            sender.Downloade();
                        }
                        break;
                }

            }
        }
    }
}
