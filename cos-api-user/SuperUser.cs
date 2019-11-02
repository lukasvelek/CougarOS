using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_api_user
{
    public class SuperUser
    {
        SuperUserCommands suc = new SuperUserCommands();

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.English l_english = new lng.English();
        lng.Translator translator = new lng.Translator();

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
                    //Null();
                    suc.Null();
                    break;
                case "update":
                    //Update();
                    suc.Update();
                    break;
            }
        }

    }
}
