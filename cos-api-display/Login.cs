using System;
using System.IO;

using lng = cos_languages;

namespace cos_api_display
{
    public class Login
    {
        lng.Translator translator = new lng.Translator();

        string[] lng = System.IO.File.ReadAllLines(@"Language.cfg");
        string language;

        public Login()
        {
            if(lng[0].ToLower() == "czech")
            {
                language = "Czech";
            }
            else
            {
                language = "English";
            }
        }

        public void drawForm()
        {
            Console.WriteLine("---------");
            Console.WriteLine("- LOGIN -");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public string getUsername()
        {
            Console.WriteLine(translator.Translate(language, "login_yourusername") + ": ");
            return Console.ReadLine();
        }

        public string getPassword()
        {
            Console.WriteLine(translator.Translate(language, "login_yourpassword") + ": ");
            return Console.ReadLine();
        }

    }
}
