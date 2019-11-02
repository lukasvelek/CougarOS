using System;
using System.Collections.Generic;

using lng = cos_languages;

namespace CougarOS
{
    public class ConfigUsers
    {

        lng.English l_english = new lng.English();
        lng.Translator translator = new lng.Translator();

        string language;

        string[] lang = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");

        public ConfigUsers()
        {
            if (lang[0].ToLower() == "czech")
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
            Console.WriteLine("{0}/{1}/", translator.Translate(language, "cfgmenu_title"), translator.Translate(language, "cfgmenu_users_title"));
            Console.WriteLine("");
            Console.WriteLine("1/ {0}", translator.Translate(language, "cfgmenu_users_listallusers"));
            Console.WriteLine("2/ {0}", translator.Translate(language, "cfgmenu_users_addauser"));
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ListAllUsers();
                    Main();
                    break;
                case "2":
                    AddAUser();
                    Main();
                    break;
                case "0":
                    return;
                default:
                    Main();
                    break;
            }
        }

        private void AddAUser()
        {
            return;
        }

        private void ListAllUsers()
        {
            Console.Clear();
            Console.WriteLine("{0}/{1}/{2}/", translator.Translate(language, "cfgmenu_title"), translator.Translate(language, "cfgmenu_users_title"), translator.Translate(language, "cfgmenu_users_listallusers_title"));
            Console.WriteLine();

            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");
            int count = 1;

            foreach (string line in lines)
            {
                //Console.WriteLine("#" + count + line);
                string[] parts = line.Split('-');

                Console.WriteLine("#" + count + " " + parts[0]);
                count++;
            }

            Console.WriteLine();
            Console.WriteLine("1/ {0}", translator.Translate(language, "cfgmenu_users_listallusers_selectauser"));
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("{0}: ", translator.Translate(language, "cfgmenu_users_listallusers_enternumber"));
                    string n = Console.ReadLine();

                    int i = 0;

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('-');

                        if (i == (Int32.Parse(n) + 1))
                        {
                            ShowUserInfo(parts[0]);
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    break;
                case "0":
                    return;
                default:
                    ListAllUsers();
                    break;
            }

        }

        public void ShowUserInfo(string name)
        {
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");
            List<string> names = new List<string>();

            foreach(string line in lines)
            {
                string[] parts = line.Split('-');

                names.Add(parts[0]);
            }

            foreach(string nname in names)
            {
                if(name == nname)
                {
                    string permissions = null;
                    foreach(string line in lines)
                    {
                        string[] parts = line.Split('-');

                        if(name == parts[0])
                        {
                            permissions = parts[2];
                        }
                    }

                    Console.WriteLine("{0}: {1}", translator.Translate(language, "cfgmenu_users_listallusers_username"), name);
                    Console.WriteLine("{0}: {1}", translator.Translate(language, "cfgmenu_users_listallusers_permissions"), permissions);
                    Console.WriteLine();
                    Console.WriteLine("1/ {0}", translator.Translate(language, "cfgmenu_users_listallusers_changepermissions"));
                    Console.WriteLine("2/ {0}", translator.Translate(language, "cfgmenu_users_listallusers_deleteuser"));
                    Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "0":
                            return;
                        case "1":
                            ChangePermissions(name);
                            break;
                        case "2":
                            DeleteUser(name);
                            break;
                        default:
                            ShowUserInfo(name);
                            break;
                    }
                }
                else
                {
                }
            }
        }

        public void ChangePermissions(string username)
        {
            string[] lines;
            List<string> original = new List<string>();
            int i = 0;

            Console.WriteLine("1/ {0}", translator.Translate(language, "usr_admin")); // 1/ admin
            Console.WriteLine("2/ {0}", translator.Translate(language, "usr_normal")); // 2/ normal user
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

                    i = 0;

                    foreach(string line in lines)
                    {
                        string[] parts = line.Split('-');

                        if(username != parts[0])
                        {
                            original.Add(line);
                        }

                        i++;
                    }

                    foreach(string line in lines)
                    {
                        string[] parts = line.Split('-');

                        if(username == parts[0])
                        {
                            string toadd = parts[0] + "-" + parts[1] + "-admin";

                            original.Add(toadd);
                        }
                    }

                    System.IO.File.Delete(@"FILESYSTEM\sys\cos_user.db");
                    System.IO.File.WriteAllLines(@"FILESYSTEM\sys\cos_user.db", original);

                    break;
                case "2":
                    lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

                    i = 0;

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('-');

                        if (username != parts[0])
                        {
                            original.Add(line);
                        }

                        i++;
                    }

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('-');

                        if (username == parts[0])
                        {
                            string toadd = parts[0] + "-" + parts[1] + "-normal";

                            original.Add(toadd);
                        }
                    }

                    System.IO.File.Delete(@"FILESYSTEM\sys\cos_user.db");
                    System.IO.File.WriteAllLines(@"FILESYSTEM\sys\cos_user.db", original);

                    break;
                case "0":
                    return;
            }
        }

        public void DeleteUser(string username)
        {
            Console.WriteLine("{0} {1}?", translator.Translate(language, "cfgmenu_users_listallusers_deleteuser_message"), username);
            Console.WriteLine("{0}: ", translator.Translate(language, "cfgmenu_users_listallusers_password"));
            string password = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

            foreach(string line in lines)
            {
                string[] parts = line.Split('-');

                if(parts[1] == password && parts[2] == "admin")
                {
                    List<string> defaultlines = new List<string>();

                    string[] todeletelinesfile = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

                    foreach (string tdlf in todeletelinesfile)
                    {
                        defaultlines.Add(tdlf);
                    }

                    int i = 0;

                    foreach(string df in defaultlines)
                    {
                        string like = parts[0] + "-" + parts[1] + "-" + parts[2];

                        if(like == df)
                        {
                            defaultlines.RemoveAt(i);
                        }

                        i++;
                    }

                    System.IO.File.Delete(@"FILESYSTEM\sys\cos_user.db");
                    System.IO.File.WriteAllLines(@"FILESYSTEM\sys\cos_user.db", defaultlines);
                }
                else
                {
                    Console.WriteLine("{0}", translator.Translate(language, "err_badpassword"));
                    Console.ReadKey();
                    DeleteUser(username);
                }
            }
        }

    }
}
