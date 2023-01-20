using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    public class Sender
    {
        Command command;
        public void SetCommand(Command command) 
        {
            this.command = command;
        }
        public void ShowInfo()
        {
            command.ShowInfo();
        }
        public void Downloade()
        {
            command.Downloade();
        }
    }
}
