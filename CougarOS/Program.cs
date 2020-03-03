using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using apps = cos_apps;
using cfg = cos_api_config;
using display = cos_api_display;
using files = cos_api_files;
using io = cos_api_io;
using lng = cos_languages;
using math = cos_api_math;
using sys = cos_api_system;
using usr = cos_api_user;

namespace CougarOS
{
    class Program
    {
        // MODULES DECLARATION

        static Commands commands = new Commands();

        static math.SimpleMath mathsm = new math.SimpleMath();

        static io.File iofile = new io.File();
        static io.Folder iofolder = new io.Folder();

        static display.Boot displayboot = new display.Boot();
        static display.Login displaylogin = new display.Login();

        static sys.Thread systhread = new sys.Thread();
        static sys.Terminal systerminal = new sys.Terminal();
        static sys.Register sysregister = new sys.Register();
        static sys.Installation sysinstall = new sys.Installation();
        static sys.Boot sysboot = new sys.Boot();
        static sys.Update sysupdate = new sys.Update();

        static usr.NormalUser usrnu = new usr.NormalUser();
        static usr.SuperUser usrsu = new usr.SuperUser();

        static files.Browser fbrowser = new files.Browser();

        // END OF MODULES DECLARATION

        // MASTER CONFIG API DECLARATION

        static cfg.System cfgapisys = new cfg.System();
        static cfg.User cfgapiusr = new cfg.User();

        // END OF MASTER CONFIG API DECLARATION

        // CONFIG DECLARATION

        static ConfigUsers cfgusers = new ConfigUsers();
        static ConfigPersonalization cfgperson = new ConfigPersonalization();
        static ConfigLanguage cfglang = new ConfigLanguage();
        static ConfigSystem cfgsys = new ConfigSystem();

        // END OF CONFIG DECLARATION

        // APP DECLARATION - isn't needed though

        static apps.Calculator appCalculator = new apps.Calculator();
        static apps.Help appHelp = new apps.Help();
        static apps.Clock appClock = new apps.Clock();

        // END OF APP DECLARATION

        // LANGUAGE DECLARATION

        static lng.Translator translator = new lng.Translator();

        static lng.English l_english = new lng.English();
        static lng.Czech l_czech = new lng.Czech();

        // END OF LANGUAGE DECLARATION

        static void Main()
        {
            if (!System.IO.File.Exists(@"FILESYSTEM\sys\POST_INSTALLATION.sys"))
            {
                sysinstall.Main();
                Main();
            }

            if (System.IO.File.Exists(@"FILESYSTEM\sys\UPDATING.sys"))
            {
                sysupdate.Install();
            }

            BootUp();
            Login();
        }

        private static void BootUp()
        {
            // CONFIGURATION LOADING

            string[] lng = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");
            string[] colors = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Color.cfg");

            cfgapisys.TextColor = colors[1];
            cfgapisys.BackgroundColor = colors[0];
            if (lng[0].ToLower() == "czech")
            {
                cfgapisys.Language = "Czech";
            }
            else
            {
                cfgapisys.Language = "English";
            }

            switch (cfgapisys.TextColor)
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

            switch (cfgapisys.BackgroundColor)
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

            cfgapisys.SystemVersionGet();

            sysboot.PreConfigLoad();
            sysboot.PostConfigLoad();

            cfgapisys.HasBootedUp = true;
            //Main();
        }

        private static void Login(string error = null)
        {
            if (error == null)
            {
                Console.Clear();
                displaylogin.drawForm();
                cfgapiusr.CurrentUserUsername = displaylogin.getUsername();
                cfgapiusr.CurrentUserPassword = displaylogin.getPassword();

                if (iofile.checkUserData(@"FILESYSTEM\sys\", "cos_user.db", cfgapiusr.CurrentUserUsername, cfgapiusr.CurrentUserPassword))
                {
                    cfgapisys.CurrentLocation = "/home/";
                    cfgapisys.CurrentLocationLong = "FILESYSTEM" + cfgapisys.CurrentLocation;

                    if (iofile.checkAdmin(@"FILESYSTEM\sys\", "cos_user.db", cfgapiusr.CurrentUserUsername, cfgapiusr.CurrentUserPassword))
                    {
                        cfgapiusr.CurrentUserPermission = "admin";
                    }
                    else
                    {
                        cfgapiusr.CurrentUserPermission = "user";
                    }

                    Console.Clear();
                    Desktop();
                }
                else
                {
                    Login("CannotLogin");
                }
            }
            else
            {
                switch (error)
                {
                    case "CannotLogin":
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_cannotLogin"));

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
            Console.WriteLine("{0}/", translator.Translate("English", "cfgmenu_title"));
            Console.WriteLine("");
            Console.WriteLine("1/ {0}", translator.Translate(cfgapisys.Language, "cfgmenu_users"));
            Console.WriteLine("2/ {0}", translator.Translate(cfgapisys.Language, "cfgmenu_personalization"));
            Console.WriteLine("3/ {0}", translator.Translate(cfgapisys.Language, "cfgmenu_language"));
            Console.WriteLine("4/ {0}", translator.Translate(cfgapisys.Language, "cfgmenu_system"));
            Console.WriteLine("0/ {0}", translator.Translate(cfgapisys.Language, "cfgmenu_back"));
            string x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    cfgusers.Main();
                    Config();
                    break;
                case "2":
                    cfgperson.Main();
                    Config();
                    break;
                case "3":
                    cfglang.Main();
                    Config();
                    break;
                case "4":
                    cfgsys.Main();
                    break;
                case "0":
                    Desktop();
                    Config();
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
            }
            catch (Exception)
            {
                Console.WriteLine(translator.Translate(cfgapisys.Language, "err_cannotconnecttopinghost"));
                Desktop();
            }

            return;
        }

        private static void Desktop()
        {
            if (cfgapiusr.CurrentUserPermission == "admin")
            {
                cfgapiusr.CurrentUserUsernameLarge = cfgapiusr.CurrentUserUsername + "^su";

                Console.Write(cfgapiusr.CurrentUserUsernameLarge + "@" + cfgapisys.CurrentLocation + "$ ");
            }
            else
            {
                Console.Write(cfgapiusr.CurrentUserUsername + "@" + cfgapisys.CurrentLocation + "$ ");
            }

            string cmd = Console.ReadLine();

            string[] filesInCurrentDirectory = System.IO.Directory.GetFiles(@cfgapisys.CurrentLocationLong);

            /*foreach(string f in filesInCurrentDirectory)
            {
                Console.WriteLine(f);
            }*/

            switch (cmd)
            {
                case "mf":
                    Console.WriteLine("Filename: ");
                    string name = Console.ReadLine();
                    
                    iofile.createFile(name, cfgapisys.CurrentLocation);

                    break;
                case "md":
                    Console.WriteLine("Folder name: ");
                    string folder = Console.ReadLine();

                    iofolder.createFolder(folder, cfgapisys.CurrentLocation);

                    break;
                case "dir":
                    Console.WriteLine("New directory: ");
                    string newDir = Console.ReadLine();
                    fbrowser.ChangeDirectory(newDir);

                    break;
                case "ls":
                    fbrowser.ListContentOfDirectory(cfgapisys.CurrentLocation);

                    break;
                case "clear":
                    commands.clear();
                    break;
                case "config":
                    if (cfgapiusr.CurrentUserPermission == "admin")
                    {
                        Config();
                    }
                    else
                    {
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_isnotadministrator"));
                    }
                    break;
                case "logout":
                    Login();
                    break;
                case "exit":
                    Exit();
                    break;
                case "ping":
                    Console.WriteLine(translator.Translate(cfgapisys.Language, "cmd_ping_destination"));
                    string ip = Console.ReadLine();
                    PingIp(ip);
                    break;
                case "changelog":
                    commands.changelog();
                    break;

                // SU && DESU
                case "su":
                    if (cfgapiusr.CurrentUserPermission == "admin")
                    {
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_alreadyadministrator"));
                    }
                    else
                    {
                        if (systerminal.checkSudoPassword())
                        {
                            cfgapiusr.CurrentUserUsernameLarge = cfgapiusr.CurrentUserUsername + "^su";
                            cfgapiusr.CurrentUserPermission = "admin";
                        }
                        else
                        {
                            Console.WriteLine(translator.Translate(cfgapisys.Language, "err_badpassword"));
                            Desktop();
                        }
                    }
                    break;
                case "desu":
                    if (cfgapiusr.CurrentUserPermission == "admin" && cfgapiusr.CurrentUserUsername != "root")
                    {
                        cfgapiusr.CurrentUserUsernameLarge = cfgapiusr.CurrentUserUsername;
                        cfgapiusr.CurrentUserPermission = "user";
                    }
                    else if (cfgapiusr.CurrentUserUsername == "root")
                    {
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_rootcannotlosepermissions"));
                    }
                    else
                    {
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_isnotadministrator"));
                    }
                    break;

                // SUDO
                case "sudo":
                    if (cfgapiusr.CurrentUserPermission == "admin")
                    {
                        usrsu.Sudo();
                    }
                    else
                    {
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_isnotadministrator"));
                    }
                    break;
                case "sudo -update":
                    if (cfgapiusr.CurrentUserPermission == "admin")
                    {
                        usrsu.Sudo("update");
                    }
                    else
                    {
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_isnotadministrator"));
                    }
                    break;
                case "sudo -register":
                    if (cfgapiusr.CurrentUserPermission == "admin")
                    {
                        sysregister.Main();
                    }
                    else
                    {
                        Console.WriteLine(translator.Translate(cfgapisys.Language, "err_isnotadministrator"));
                    }
                    break;

                // APPS
                case "about":
                    commands.about();
                    break;
                case "calculator":
                    commands.calculator();
                    break;
                case "help":
                    commands.help();
                    break;
                case "clock":
                    commands.clock();
                    break;
                case "notepad":
                    commands.notepad();
                    break;
                case "textbrowser":
                    commands.textbrowser();
                    break;
                case "yes":
                    commands.yes();
                    break;
                case "cat":
                    commands.cat();
                    break;

                default:
                    Console.WriteLine("{0}: '{1}'", translator.Translate(cfgapisys.Language, "err_nocommandfoundfor"), cmd);
                    Desktop();
                    break;
            }

            Desktop();
        }
    }
}
