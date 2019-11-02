using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_apps
{
    public class TextBrowser
    {

        string filename = "";

        public TextBrowser()
        {

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
