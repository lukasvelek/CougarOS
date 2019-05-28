using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_api_display
{
    public class Login
    {

        public void drawForm()
        {
            Console.WriteLine("---------");
            Console.WriteLine("- LOGIN -");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public string getUsername()
        {
            Console.WriteLine("Your username: ");
            return Console.ReadLine();
        }

        public string getPassword()
        {
            string pass = "";
            Console.WriteLine("Your password: ");
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }
            while (key.Key != ConsoleKey.Enter);

            return pass;
            //return Console.ReadLine();
        }

    }
}
