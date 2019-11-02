using System;

using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_apps
{
    public class About
    {
        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        /*string[] lng = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");
        string language;*/

        string[] systemInfo = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\SystemInfo.cfg");
        string systemVersion;
        string systemCodename;
        string systemBuild;

        public About()
        {
            /*if (lng[0].ToLower() == "czech")
            {
                language = "Czech";
            }
            else
            {
                language = "English";
            }*/

            systemVersion = systemInfo[0];
            systemCodename = systemInfo[1];
            systemBuild = systemInfo[2];
        }

        public void ShowAbout()
        {
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_name"), "CougarOS");
            /*Console.WriteLine(translator.Translate(language, "app_about_system_version"));
            Console.WriteLine(translator.Translate(language, "app_about_system_build"));
            Console.WriteLine(translator.Translate(language, "app_about_system_codename"));*/
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_version"), systemVersion);
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_build"), systemBuild);
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_codename"), systemCodename);
            return;
        }

    }
}
