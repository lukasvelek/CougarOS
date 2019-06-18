using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CougarOS
{
    public class ConfigLanguage
    {
        public void Main()
        {

            Console.Clear();
            Console.WriteLine("Config/Language/");
            Console.WriteLine("");
            Console.WriteLine("Choose a language: ");
            Console.WriteLine("1/ English");
            Console.WriteLine("2/ Czech");
            Console.WriteLine("0/ Back");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    //ListAllUsers();
                    ChangeLanguage("english");
                    break;
                case "2":
                    ChangeLanguage("czech");
                    break;
                case "0":
                    return;
                default:
                    Main();
                    break;
            }
        }

        private void ChangeLanguage(string language)
        {
            System.IO.File.WriteAllText(@"Language.cfg", language.ToUpper());
            return;
        }

    }
}
