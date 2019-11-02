using System;
using io = cos_api_io;
using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_api_system
{
    public class Terminal
    {
        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        /*string language;

        string[] lang = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");

        public Terminal()
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

        string subpassword;       

        io.File iofile = new io.File();
        lng.Translator translator = new lng.Translator();

        public bool checkPassword(string username)
        {
            Console.WriteLine("Password: ");

            /*string subpassword = Console.ReadLine();

            if (iofile.checkPassword(username, subpassword))
            {
                // password is ok
                return true;
            }*/

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    subpassword += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && subpassword.Length > 0)
                    {
                        subpassword = subpassword.Substring(0, (subpassword.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            if (iofile.checkPassword(username, subpassword))
            {
                return true;
            }

            return false;
        }

        public bool checkSudoPassword()
        {
            Console.WriteLine("{0}: ", translator.Translate(cfgapisys.Language, "terminal_yourpassword"));

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    subpassword += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && subpassword.Length > 0)
                    {
                        subpassword = subpassword.Substring(0, (subpassword.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            if(iofile.checkPassword("root", subpassword))
            {
                return true;
            }

            return false;
        }

    }
}
