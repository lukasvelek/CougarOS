using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_api_display
{
    public class InstallationScreen
    {

        public void BootUp(bool wait, int ms=1000)
        {
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\resources\os_logo.resource");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            if (wait)
            {
                System.Threading.Thread.Sleep(ms);
            }
            else
            {
                return;
            }
        }

        public string RootSet()
        {
            Console.WriteLine();

            Console.WriteLine("Root creation");
            Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter password again: ");
            string passcheck = Console.ReadLine();

            if(pass == passcheck)
            {
                return pass;
            }
            else
            {
                Console.Clear();
                BootUp(false);
                Console.WriteLine();
                Console.WriteLine("Error: Bad password! Please try again!");
                RootSet();
            }

            return null;
        }

        public string UserCreation()
        {
            Console.Clear();
            BootUp(false);
            Console.WriteLine();

            Console.WriteLine("User creation");
            Console.WriteLine("User name: ");
            string name = Console.ReadLine();
            Console.WriteLine("User password: ");
            string pass = Console.ReadLine();
            Console.WriteLine("User password again: ");
            string passcheck = Console.ReadLine();

            if(pass == passcheck)
            {
                string mix = name + "-" + pass;
                return mix;
            }
            else
            {
                Console.Clear();
                BootUp(false);
                Console.WriteLine();
                Console.WriteLine("Error: Bad password! Please try again!");
                UserCreation();
            }

            return null;
        }

        public string Personalization()
        {
            Console.Clear();
            BootUp(false);
            Console.WriteLine();

            Console.WriteLine("Personalization");
            Console.WriteLine("Language: ");
            Console.WriteLine("1/ English (default)");
            Console.WriteLine("2/ Czech (work in progress)");
            string language = Console.ReadLine();

            int l = Int32.Parse(language);

            if (l > 2 || l < 1)
            {
                Personalization();
            }

            Console.WriteLine("Background color: ");
            Console.WriteLine("1/ Green");
            Console.WriteLine("2/ Black");
            Console.WriteLine("3/ Blue");
            Console.WriteLine("4/ White");
            Console.WriteLine("5/ Yellow");
            Console.WriteLine("6/ Red");
            Console.WriteLine("7/ Magenta");
            string bgcolor = Console.ReadLine();

            int bc = Int32.Parse(bgcolor);

            if(bc > 7 || bc < 1)
            {
                Personalization();
            }

            Console.WriteLine("Text color: ");
            Console.WriteLine("1/ Green");
            Console.WriteLine("2/ Black");
            Console.WriteLine("3/ Blue");
            Console.WriteLine("4/ White");
            Console.WriteLine("5/ Yellow");
            Console.WriteLine("6/ Red");
            Console.WriteLine("7/ Magenta");
            string fgcolor = Console.ReadLine();

            int fc = Int32.Parse(fgcolor);

            if(fc > 7 || fc < 1)
            {
                Personalization();
            }

            string rt = language + "-" + bgcolor + "-" + fgcolor;
            return rt;
        }

        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("The installation has been finished!");
            //string[] lines = System.IO.File.ReadAllLines(@"WelcomeUserAfterInstallation.screen");
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\resources\WelcomeUserAfterInstallation.resource");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter if you are ready to boot up!");
            Console.ReadKey();
        }
    }
}
