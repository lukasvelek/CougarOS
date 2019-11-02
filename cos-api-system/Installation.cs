using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_api_system
{
    public class Installation
    {
        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        InstallationSubPrograms isp = new InstallationSubPrograms();

        /*string[] lng = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");
        string language;

        public Installation()
        {
            if (lng[0].ToLower() == "czech")
            {
                language = "Czech";
            }
            else
            {
                language = "English";
            }
        }*/

        public void Main()
        {
            /*
             
             HIERARCHY OF INSTALLATION:
                #1 Check for files that are being made during installation
                    - cos_user.db
                    - Color.cfg
                    - Language.cfg
                #2 Remove files that are being made during installation
                #3 Get a root password
                #4 Create a normal user
                #5 Let user personalize the OS
                #6 Welcome him
                #7 Boot the OS
             
             */

            if (!isp.CheckForFiles())
            {
                if (!isp.RemoveFiles())
                {
                    Main();
                }
                else
                {
                    isp.InstallationProcess();
                    System.IO.File.WriteAllText(@"FILESYSTEM\sys\POST_INSTALLATION.sys", "SUCCESS");
                }
            }

            return;
        }

    }
}
