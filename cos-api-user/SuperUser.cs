using lng = cos_languages;
using cfg = cos_api_config;
using sys = cos_api_system;

namespace cos_api_user
{
    public class SuperUser
    {
        SuperUserCommands suc = new SuperUserCommands();

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.English l_english = new lng.English();
        lng.Translator translator = new lng.Translator();

        sys.Update sysupdate = new sys.Update();

        /*string language;

        string[] lang = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");

        public SuperUser()
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

        public void Su(string currentPermission)
        {

        }

        public void Desu()
        {

        }

        public void Sudo(string arg = null)
        {
            switch (arg)
            {
                case "null":
                    suc.Null();
                    break;
                case "update":
                    sysupdate.Main();
                    break;
            }
        }

    }
}
