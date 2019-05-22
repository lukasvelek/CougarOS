using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Windows;


using io = cos_api_io;
using math = cos_api_math;
using display = cos_api_display;
using sys = cos_api_system;
using usr = cos_api_user;
using apps = cos_apps;

namespace CougarOS
{
    class Program
    {
        static string currentUserUsername;
        static string currentUserPassword;
        static string currentUserUsernameLarge;
        static string currentLocation = "/home/";
        static string currentPermission = "user";

        static bool hasBootedUp = false;

        static string log_file_path = @"c:\temp\";
        static string user_file_path = @"c:\temp\";

        static string log_filename = "cos_logfile.log";
        static string user_filename = "cos_user.db";

        //static Commands

        static Commands commands = new Commands();

        static math.SimpleMath mathsm = new math.SimpleMath();

        static io.File iofile = new io.File();

        static display.Boot displayboot = new display.Boot();
        static display.Login displaylogin = new display.Login();

        static sys.Thread systhread = new sys.Thread();
        static sys.Terminal systerminal = new sys.Terminal();

        static usr.NormalUser usrnu = new usr.NormalUser();

        // APP DECLARATION

        static apps.Calculator appCalculator = new apps.Calculator();
        static apps.Help appHelp = new apps.Help();

        // END OF APP DECLARATION

        static void Main()
        {
            if (!hasBootedUp)
            {
                //iofile.checkLogFile(log_file_path, log_filename);
                BootUp();
            }
            else
            {
                Login();
            }
        }

        private static void BootUp()
        {
            //iofile.log(log_file_path, log_filename, "Starting system");
            displayboot.drawLogo();
            systhread.sleep(5);

            hasBootedUp = true;
            Main();
        }

        private static void Login(string error = null)
        {
            if(error == null)
            {
                Console.Clear();
                displaylogin.drawForm();
                currentUserUsername = displaylogin.getUsername();
                currentUserPassword = displaylogin.getPassword();

                if (iofile.checkUserData(user_file_path, user_filename, currentUserUsername, currentUserPassword))
                {
                    //iofile.log(log_file_path, log_filename, "User has successfully logged in!");
                    currentLocation = "/home/";

                    if(iofile.checkAdmin(user_file_path, user_filename, currentUserUsername, currentUserPassword))
                    {
                        currentPermission = "admin";
                    }
                    else
                    {
                        currentPermission = "user";
                    }

                    Desktop();
                }
                else
                {
                    //iofile.log(log_file_path, log_filename, "User has not successfully logged in!");
                    Login("CannotLogin");
                }
            }
            else
            {
                switch (error)
                {
                    case "CannotLogin":
                        Console.WriteLine("Sorry, but we can't log you in. Please press enter to try again.");
                        Console.ReadKey();
                        Login();
                        break;
                }
            }
        }

        private static void Desktop()
        {
            Console.Write(currentUserUsername + "@" + currentLocation + "$ ");
            
            string cmd = Console.ReadLine();

            // FOR NORMAL USERS
            switch (cmd)
            {
                case "calculator":
                    commands.calculator();
                    break;
                case "help":
                    commands.help();
                    break;
                case "clear":
                    commands.clear();
                    break;
                case "su":
                    if(currentPermission == "admin")
                    {
                        // isn't needed
                        currentUserUsernameLarge = currentUserUsername + "^su";
                        currentPermission = "admin";
                    }
                    else
                    {
                        if (systerminal.checkPassword(currentUserUsername))
                        {
                            currentUserUsernameLarge = currentUserUsername + "^su";
                            currentPermission = "admin";
                        }
                        else
                        {
                            Console.WriteLine("Entered password isn't right. Please try again!");
                            Desktop();
                        }
                    }
                    break;
                case "desu":
                    if(currentPermission == "admin" && currentUserUsername == "root")
                    {
                        currentUserUsernameLarge = currentUserUsername;
                        currentPermission = "user";
                    }
                    else
                    {
                        Console.Write("You are not an administrator!");
                    }
                    break;
                case "config":
                    if(currentPermission == "admin")
                    {

                    }
                    else
                    {
                        if (currentPermission == "admin")
                        {
                            // isn't needed
                            currentUserUsernameLarge = currentUserUsername + "^su";
                            currentPermission = "admin";
                        }
                        else
                        {
                            if (systerminal.checkPassword(currentUserUsername))
                            {
                                currentUserUsernameLarge = currentUserUsername + "^su";
                                currentPermission = "admin";
                            }
                            else
                            {
                                Console.WriteLine("Entered password isn't right. Please try again!");
                                Desktop();
                            }
                        }
                    }
                    break;
                default:
                    Desktop();
                    break;
            }

            Desktop();
        }
    }
}
