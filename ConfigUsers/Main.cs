using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUsers
{
    public class Main
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
                    
                    break;
                case "0":
                    Config();
                    break;
                default:
                    ConfigUsers();
                    break;
            }

}
}
