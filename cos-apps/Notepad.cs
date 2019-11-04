using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_apps
{
    public class Notepad
    {
        public string AppVersion { get; private set; }

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        public Notepad()
        {
            AppVersion = "1.0";
        }

        public void Main()
        {
            Console.WriteLine("Name of the file: ");
            string filename = Console.ReadLine();

            Console.Clear();

            string text = "";
            List<string> fulltext = new List<string>();

            do
            {
                text = Write();
                fulltext.Add(text);
            } while (text != "END");

            // SAVE INTO FILE

            System.IO.File.WriteAllLines(@"FILESYSTEM\home\root\Documents\" + filename + ".document", fulltext);
        }

        public string Write()
        {
            string text = Console.ReadLine();
            return text;
        }

    }
}
