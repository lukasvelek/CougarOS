using System;
using System.Configuration;
using System.Net.NetworkInformation;
using apps = cos_apps;
using display = cos_api_display;
using io = cos_api_io;
using math = cos_api_math;
using sys = cos_api_system;
using usr = cos_api_user;
using lng = cos_languages;

namespace CougarOS
{
    class Program
    {
        static string language;
        static string textColor;
        static string backgroundColor;

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

        // CONFIG DECLARATION

        static ConfigUsers cfgusers = new ConfigUsers();
        static ConfigPersonalization cfgperson = new ConfigPersonalization();
        static ConfigLanguage cfglang = new ConfigLanguage();

        // END OF CONFIG DECLARATION

        // APP DECLARATION

        static apps.Calculator appCalculator = new apps.Calculator();
        static apps.Help appHelp = new apps.Help();

        // END OF APP DECLARATION

        // LANGUAGE DECLARATION

        static lng.English l_english = new lng.English();
        static lng.Czech l_czech = new lng.Czech();

        // END OF LANGUAGE DECLARATION

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

        //[Obsolete]
        private static void BootUp()
        {
            //iofile.log(log_file_path, log_filename, "Starting system");
            displayboot.drawLogo();

            // CONFIGURATION LOADING

            // language, textColor, backgroundColor

            string[] bg = System.IO.File.ReadAllLines("BackgroundColor.cfg");
            string[] fg = System.IO.File.ReadAllLines("TextColor.cfg");
            string[] lng = System.IO.File.ReadAllLines("Language.cfg");

            textColor = fg[0];
            backgroundColor = bg[0];
            language = lng[0];

            switch (textColor)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }

            switch (backgroundColor)
            {
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
            }

            // END OF CONFIGURATION LOADING

            systhread.sleep(5);

            hasBootedUp = true;
            Main();
        }

        private static void Login(string error = null)
        {
            if (error == null)
            {
                Console.Clear();
                displaylogin.drawForm();
                currentUserUsername = displaylogin.getUsername();
                currentUserPassword = displaylogin.getPassword();

                if (iofile.checkUserData(user_file_path, user_filename, currentUserUsername, currentUserPassword))
                {
                    //iofile.log(log_file_path, log_filename, "User has successfully logged in!");
                    currentLocation = "/home/";

                    if (iofile.checkAdmin(user_file_path, user_filename, currentUserUsername, currentUserPassword))
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
                        //Console.WriteLine("Sorry, but we can't log you in. Please press enter to try again.");
                        //Console.WriteLine(l_english.err_cannotLogin);
                        switch(language)
                        {
                            case "Czech":
                                Console.WriteLine(l_czech.err_cannotLogin);
                                break;
                            case "English":
                                Console.WriteLine(l_english.err_cannotLogin);
                                break;
                        }
                        Console.ReadKey();
                        Login();
                        break;
                }
            }
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }

        private static void Config()
        {
            Console.Clear();
            Console.WriteLine("{0}/", l_english.cfgmenu_title); // title
            Console.WriteLine("");
            Console.WriteLine("1/ {0}", l_english.cfgmenu_users); // users
            Console.WriteLine("2/ {0}", l_english.cfgmenu_personalization); // personalization
            Console.WriteLine("3/ {0}", l_english.cfgmenu_language); // language
            Console.WriteLine("0/ {0}", l_english.cfgmenu_back); // back
            string x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    //ConfigUsers();
                    cfgusers.Main();
                    break;
                case "2":
                    cfgperson.Main();
                    break;
                case "3":
                    cfglang.Main();
                    break;
                default:
                    Config();
                    break;
            }
        }

        private static void PingIp(string ip)
        {
            Ping ping = new Ping();
            try
            {
                PingReply pingresult = ping.Send(ip);
            }catch(Exception e)
            {
                //Console.WriteLine("There was an error while processing your request!");
                Console.WriteLine(l_english.err_cannotconnecttopinghost);
                Desktop();
            }

            return;
        }

        private static void Desktop()
        {
            if (currentPermission == "admin")
            {
                currentUserUsernameLarge = currentUserUsername + "^su";

                Console.Write(currentUserUsernameLarge + "@" + currentLocation + "$ ");
            }
            else
            {
                Console.Write(currentUserUsername + "@" + currentLocation + "$ ");
            }

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
                    if (currentPermission == "admin")
                    {
                        // isn't needed
                        /*currentUserUsernameLarge = currentUserUsername + "^su";
                        currentPermission = "admin";*/
                        //Console.WriteLine("You already are an administrator!");
                        Console.WriteLine(l_english.err_alreadyadministrator);
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
                            //Console.WriteLine("Entered password isn't right. Please try again!");
                            Console.WriteLine(l_english.err_badpassword);
                            Desktop();
                        }
                    }
                    break;
                case "desu":
                    if (currentPermission == "admin" && currentUserUsername != "root")
                    {
                        currentUserUsernameLarge = currentUserUsername;
                        currentPermission = "user";
                    }
                    else if (currentUserUsername == "root")
                    {
                        //Console.WriteLine("User 'root' can't lose their permissions! Please log in as different user!");
                        Console.WriteLine(l_english.err_rootcannotlosepermissions);
                    }
                    else
                    {
                        //Console.Write("You are not an administrator!");
                        Console.WriteLine(l_english.err_isnotadministrator);
                    }
                    break;
                case "config":
                    if (currentPermission == "admin")
                    {
                        Config();
                    }
                    else
                    {
                        // isn't admin
                        // maybe wouldn't be able to configurate the os?
                    }
                    break;
                case "logout":
                    Login();
                    break;
                case "exit":
                    Exit();
                    break;
                case "ping":
                    //Console.WriteLine("Destination IP: ");
                    Console.WriteLine(l_english.cmd_ping_destinationip);
                    string ip = Console.ReadLine();
                    PingIp(ip);
                    break;

                default:
                    Desktop();
                    break;
            }

            Desktop();
        }
    }
}
