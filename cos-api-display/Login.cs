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
            Console.WriteLine("Your password: ");
            return Console.ReadLine();
        }

    }
}
