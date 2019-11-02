using System;

using lng = cos_languages;

namespace CougarOS
{
    public class ConfigLanguage
    {
        lng.Translator translator = new lng.Translator();

        string[] lng = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");
        string language;

        public ConfigLanguage()
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
            Console.WriteLine("{0}/{1}/", translator.Translate(language, "cfgmenu_title"), translator.Translate(language, "cfgmenu_language_title"));
            Console.WriteLine("");
            Console.WriteLine("{0}: ", translator.Translate(language, "cfgmenu_language_choosealanguage"));
            Console.WriteLine("1/ {0}", translator.Translate(language, "cfgmenu_language_english"));
            Console.WriteLine("2/ {0}", translator.Translate(language, "cfgmenu_language_czech"));
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    //ListAllUsers();
                    ChangeLanguage("english");
                    break;
                case "2":
                    ChangeLanguage("czech");
                    break;
                case "0":
                    return;
                default:
                    Main();
                    break;
            }
        }

        private void ChangeLanguage(string language)
        {
            System.IO.File.WriteAllText(@"FILESYSTEM\sys\config\Language.cfg", language.ToUpper());
            return;
        }

    }
}
