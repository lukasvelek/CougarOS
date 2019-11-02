using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_api_system
{
    public class Register
    {
        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        // Language
        /*string language;

        string[] lang = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");

        public Register()
        {
            if (lang[0].ToLower() == "czech")
            {
                language = "Czech";
            }
            else
            {
                language = "English";
            }
        }*/

        // Color
        //string[] colors = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Color.cfg"); // 1 fg, 0 bg

        // Output
        public void Main()
        {
            Console.Clear();
            Console.WriteLine("Language: {0}", cfgapisys.Language);
            Console.WriteLine("Foreground color: {0}", cfgapisys.TextColor /*colors[1]*/);
            Console.WriteLine("Background color: {0}", cfgapisys.BackgroundColor /*colors[0]*/);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("0/ Back");
            string option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    return;
                default:
                    Main();
                    break;
            }
        }

    }
}
