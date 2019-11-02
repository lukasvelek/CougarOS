using System;
using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_api_user
{
    public class SuperUserCommands
    {
        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.English l_english = new lng.English();
        lng.Translator translator = new lng.Translator();

        /*string language;

        string[] lang = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");

        public SuperUserCommands()
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

        public void Null()
        {

        }

        public void Update()
        {
            for (int i = 0; i < 255; i++)
            {
                Console.Clear();
                Console.WriteLine("{0}", translator.Translate(cfgapisys.Language, "su_sudo_update_checkingforupdates"));
                Console.WriteLine("{0}: {1}/{2}", translator.Translate(cfgapisys.Language, "su_sudo_update_checkingserver"), i, 255);

            }

            Console.WriteLine("{0}", translator.Translate(cfgapisys.Language, "su_sudo_update_possibleserveroutage"));
            Console.WriteLine("{0}", translator.Translate(cfgapisys.Language, "su_sudo_update_noupdatesfound"));
            return;
        }

    }
}
