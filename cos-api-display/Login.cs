using System;

using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_api_display
{
    public class Login
    {
        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        public void drawForm()
        {
            Console.WriteLine("---------");
            Console.WriteLine("- LOGIN -");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public string getUsername()
        {
            Console.WriteLine(translator.Translate(cfgapisys.Language, "login_yourusername") + ": ");

            return Console.ReadLine();
        }

        public string getPassword()
        {
            Console.WriteLine(translator.Translate(cfgapisys.Language, "login_yourpassword") + ": ");

            string pass = "";

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            Console.WriteLine();

            return pass;
        }

    }
}
