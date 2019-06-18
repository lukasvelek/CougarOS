﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lng = cos_languages;

namespace CougarOS
{
    public class ConfigUsers
    {

        lng.English l_english = new lng.English();

        public void Main()
        {
            Console.Clear();
            Console.WriteLine("{0}/{1}/", l_english.cfgmenu_title, l_english.cfgmenu_users_title);
            Console.WriteLine("");
            Console.WriteLine("1/ {0}", l_english.cfgmenu_users_listallusers);
            Console.WriteLine("2/ {0}", l_english.cfgmenu_users_addauser);
            Console.WriteLine("0/ {0}", l_english.cfgmenu_back);
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

        private void AddAUser()
        {
            return;
        }

        private void ListAllUsers()
        {
            Console.Clear();
            Console.WriteLine("{0}/{1}/{2}/", l_english.cfgmenu_title, l_english.cfgmenu_users_title, l_english.cfgmenu_users_listallusers_title);
            Console.WriteLine();

            string[] lines = System.IO.File.ReadAllLines(@"cos_user.db");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("1/ {0}", l_english.cfgmenu_users_listallusers_selectauser);
            Console.WriteLine("0/ {0}", l_english.cfgmenu_back);
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("{0}: ", l_english.cfgmenu_users_listallusers_enterusername);
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
                        Console.WriteLine("{0}/{1}/{2}/" + name, l_english.cfgmenu_title, l_english.cfgmenu_users_title, l_english.cfgmenu_users_listallusers_title);
                        Console.WriteLine();
                        Console.WriteLine("{0}: ", l_english.cfgmenu_users_listallusers_username);
                        Console.WriteLine();
                        Console.WriteLine("0/ {0}", l_english.cfgmenu_back);
                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "0":
                                return;
                                //break;
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
