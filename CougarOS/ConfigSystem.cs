using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lng = cos_languages;
using sys = cos_api_system;

namespace CougarOS
{
    public class ConfigSystem
    {
        sys.FactoryReset sfr = new sys.FactoryReset();

        lng.Translator translator = new lng.Translator();

        //string[] lng = System.IO.File.ReadAllLines(@"Language.cfg");
        string[] lng = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");
        string language;

        public ConfigSystem()
        {
            if (lng[0].ToLower() == "czech")
            {
                language = "Czech";
            }
            else
            {
                language = "English";
            }
        }

        public void Main()
        {
            Console.Clear();
            Console.WriteLine("{0}", translator.Translate(language, "cfgmenu_system_title"));
            Console.WriteLine("1/ {0}", translator.Translate(language, "cfgmenu_system_about"));
            Console.WriteLine("2/ {0}", translator.Translate(language, "cfgmenu_system_factoryreset"));
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    About();
                    break;
                case "2":
                    FactoryReset();
                    break;
                case "0":
                    return;
                default:
                    Main();
                    break;
            }
        }

        public void FactoryReset()
        {
            Console.Clear();
            Console.WriteLine("{0}", translator.Translate(language, "cfgmenu_system_factoryreset_title"));
            Console.WriteLine("{0}", translator.Translate(language, "cfgmenu_system_factoryreset_message"));
            Console.WriteLine("Y/ {0}", translator.Translate(language, "yes"));
            Console.WriteLine("N/ {0}", translator.Translate(language, "no"));
            string option = Console.ReadLine();

            option.ToLower();

            switch (option)
            {
                case "y":
                    if (!sfr.CheckPassword())
                    {
                        FactoryReset();
                    }
                    else
                    {
                        sfr.Main();
                    }
                    break;

                case "yes":
                    if (!sfr.CheckPassword())
                    {
                        FactoryReset();
                    }
                    else
                    {
                        sfr.Main();
                    }
                    break;


                case "n":
                    return;

                case "no":
                    return;
            }
        }

        public void About()
        {
            //string[] lines = System.IO.File.ReadAllLines(@"SystemInfo.cfg");
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\SystemInfo.cfg");

            // system version
            // version codename
            // system build

            Console.Clear();
            Console.WriteLine("{0}", translator.Translate(language, "cfgmenu_system_about_title"));
            Console.WriteLine("{0}: {1}", translator.Translate(language, "cfgmenu_system_about_systemversion"), lines[0]);
            Console.WriteLine("{0}: {1}", translator.Translate(language, "cfgmenu_system_about_versioncodename"), lines[1]);
            Console.WriteLine("{0}: {1}", translator.Translate(language, "cfgmenu_system_about_systembuild"), lines[2]);
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    Main();
                    break;
                default:
                    About();
                    break;
            }
        }

    }
}
