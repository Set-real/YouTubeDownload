using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload
{
    /// <summary>
    /// Конкретная реализация команды
    /// </summary>
    public class CommandGetInfo : Command
    {
        Receiver Receiver;
        public CommandGetInfo(Receiver receiver)
        {
            Receiver = receiver;
        }
        public override void ShowInfo()
        {
            Receiver.Informatoins();
        }
        public override void Downloade()
        {
            Receiver.DownloadVideo();
        }
    }

}

