using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CougarOS
{
    class UserConfig
    {

        public int Main()
        {
            Console.Clear();
            Console.WriteLine("Config/Users");
            Console.WriteLine("1/ Add a user");
            Console.WriteLine("2/ List all users");
            Console.WriteLine("3/ User security");
            Console.WriteLine("0/ Back");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    return 1;
                case "0":
                    //Config();
                    return 0;
                default:
                    return -1;
            }
        }

        public void ListAllUsers()
        {

        }

    }
}
