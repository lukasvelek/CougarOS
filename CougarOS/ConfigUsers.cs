using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CougarOS
{
    public class ConfigUsers
    {

        public void Main()
        {
            Console.Clear();
            Console.WriteLine("Config/Users/");
            Console.WriteLine("");
            Console.WriteLine("1/ List all users");
            Console.WriteLine("2/ Add a user");
            Console.WriteLine("0/ Back");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ListAllUsers();
                    break;
                case "2":
                    AddAUser();
                    break;
                case "0":
                    return;
                default:
                    Main();
                    break;
            }
        }

        public void AddAUser()
        {

        }

        public void ListAllUsers()
        {
            Console.Clear();
            Console.WriteLine("Config/Users/List all users/");
            Console.WriteLine();

            string[] lines = System.IO.File.ReadAllLines(@"cos_user.db");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("1/ Select a user");
            Console.WriteLine("0/ Back");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("Enter the username: ");
                    string username = Console.ReadLine();

                    foreach(string line in lines)
                    {
                        string[] splitLines = line.Split('-');

                        foreach(string sline in splitLines)
                        {
                            if(username == sline)
                            {
                                
                            }
                        }

                    }
                    break;
                case "0":
                    break;
                default:
                    ListAllUsers();
                    break;
            }

        }

        public void ShowUserInfo(string name)
        {
            string[] lines = System.IO.File.ReadAllLines(@"cos_user.db");

            foreach(string line in lines)
            {
                string[] splitLines = line.Split('-');

                foreach(string sline in splitLines)
                {
                    if(name == sline)
                    {
                        Console.Clear();
                        Console.WriteLine("Config/User/List all users/" + name);
                        Console.WriteLine();
                        Console.WriteLine("Username: ");
                        Console.WriteLine();
                        Console.WriteLine("0/ Back");
                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "0":
                                return;
                                break;
                            default:
                                ShowUserInfo(name);
                                break;
                        }

                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

    }
}
