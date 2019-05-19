using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static bool hasBootedUp = false;

        static string log_file_path = @"c:\temp\";
        static string user_file_path = @"c:\temp\";

        static string log_filename = "cos_logfile.log";
        static string user_filename = "cos_user.db";

        static math.SimpleMath mathsm = new math.SimpleMath();

        static io.File iofile = new io.File();

        static display.Boot displayboot = new display.Boot();
        static display.Login displaylogin = new display.Login();

        static sys.Thread systhread = new sys.Thread();
        static sys.Terminal systerminal = new sys.Terminal();

        static usr.NormalUser usrnu = new usr.NormalUser();

        // APP DECLARATION

        static apps.Calculator appCalculator = new apps.Calculator();

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
            Console.Clear();

            string cmd = Console.ReadLine();

            // FOR NORMAL USERS
            switch (systerminal.send(cmd))
            {
                case "calculator":
                    
                    break;
                case null:
                    break;
                default:
                    break;
            }
        }
    }
}
