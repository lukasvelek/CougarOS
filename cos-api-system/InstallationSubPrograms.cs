using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lng = cos_languages;
using d = cos_api_display;
using cfg = cos_api_config;

namespace cos_api_system
{
    public class InstallationSubPrograms
    {
        FactoryReset fr = new FactoryReset();

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        d.InstallationScreen dis = new d.InstallationScreen();

        string RootPassword = null;
        string Username = null;
        string Userpassword = null;

        public bool CheckForFiles()
        {
            if(System.IO.File.Exists(@"FILESYSTEM\sys\cos_user.db") || System.IO.File.Exists(@"FILESYSTEM\sys\config\Color.cfg") || System.IO.File.Exists(@"FILESYSTEM\sys\config\Language.cfg"))
            {
                return false;
            }
            else
            {
                return true;
            }

            return true;
        }

        public bool RemoveFiles()
        {
            try
            {
                if (fr.RemoveFiles())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void InstallationProcess()
        {
            dis.BootUp(true, 1000); // boot up logo, will wait for 1000 ms = 1 s

            RootPassword = dis.RootSet(); // get root password 

            string mix = dis.UserCreation(); // create a normal user
            string[] mixa = mix.Split('-');
            Username = mixa[0];
            Userpassword = mixa[1];

            string userconfig = dis.Personalization(); // let the user personalize
            string[] uc = userconfig.Split('-');
            // language, bgcolor, fgcolor

            System.IO.File.WriteAllText(@"FILESYSTEM\sys\cos_user.db", "root-" + RootPassword + "-admin\n" + Username + "-" + Userpassword + "-normal");
            System.IO.File.WriteAllText(@"FILESYSTEM\sys\config\Language.cfg", uc[0]);
            System.IO.File.WriteAllText(@"FILESYSTEM\sys\config\Color.cfg", uc[1] + "\n" + uc[2]);

            CreateUserFolder(Username);

            dis.Welcome(); // welcome the user with a message
        }

        public void CreateUserFolder(string username)
        {
            System.IO.Directory.CreateDirectory(@"FILESYSTEM\home\root\");
            System.IO.Directory.CreateDirectory(@"FILESYSTEM\home\root\Desktop\");
            System.IO.Directory.CreateDirectory(@"FILESYSTEM\home\root\Documents\");
            System.IO.Directory.CreateDirectory(@"FILESYSTEM\home\" + username);
            System.IO.Directory.CreateDirectory(@"FILESYSTEM\home\" + username + "\\Desktop\\");
            System.IO.Directory.CreateDirectory(@"FILESYSTEM\home\" + username + "\\Documents\\");
        }

        private void WriteUser(string name, string password, bool isAdmin = false)
        {
            string admin = null;

            if (!isAdmin)
            {
                admin = "normal";
            }
            else
            {
                admin = "admin";
            }

            List<string> text = new List<string>();
            text.Add("\"" + name + "\"" + "-" + "\"" + password + "\"" + "-" + admin);

            System.IO.File.WriteAllLines(@"FILESYSTEM\sys\cos_user.db", text);
        }

        private void WriteLanguage(string language)
        {
            List<string> text = new List<string>();

            text.Add(language);

            System.IO.File.WriteAllLines(@"FILESYSTEM\sys\config\Language.cfg", text);
        }

        private void WriteColor(string value)
        {
            List<string> text = new List<string>();

            text.Add(value);

            System.IO.File.WriteAllLines(@"FILESYSTEM\sys\config\Color.cfg", text);
        }
    }
}