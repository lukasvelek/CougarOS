using System;

using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_apps
{
    public class About
    {
        public string AppVersion { get; private set; }

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        string[] systemInfo = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\SystemInfo.cfg");
        string systemVersion;
        string systemCodename;
        string systemBuild;

        public About()
        {
            AppVersion = "1.0";

            systemVersion = systemInfo[0];
            systemCodename = systemInfo[1];
            systemBuild = systemInfo[2];
        }

        public void ShowAbout()
        {
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_name"), "CougarOS");
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_version"), systemVersion);
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_build"), systemBuild);
            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_about_system_codename"), systemCodename);
            return;
        }

    }
}
