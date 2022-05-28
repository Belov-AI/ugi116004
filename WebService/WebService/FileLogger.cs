using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebService
{
    public class FileLogger : Logger
    {
        private string fileName;

        public FileLogger(string fileName)
        {
            this.fileName = fileName;
        }

        public override void Register(string message)
        {
            using (var file = new StreamWriter(fileName, true))
            {
                file.WriteLine($"{DateTime.Now.ToShortDateString()} " +
                    $"{DateTime.Now.ToLongTimeString()} {message}");
            }
        }
    }
}
