using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_apps
{
    public class TextBrowser
    {
        public string AppVersion { get; private set; }

        string filename = "";

        public TextBrowser()
        {
            AppVersion = "1.0";
        }

        public void Main()
        {
            Console.WriteLine("Name of the file: ");
            filename = Console.ReadLine();

            Browse();
            return;
        }

        public void Browse()
        {
            if (System.IO.File.Exists(@"FILESYSTEM\home\root\Documents\" + filename + ".document"))
            {
                Console.WriteLine(System.IO.File.ReadAllText(@"FILESYSTEM\home\root\Documents\" + filename + ".document"));
                Console.ReadKey();
                return;
            }
            else
            {
                return;
            }
        }

    }
}
