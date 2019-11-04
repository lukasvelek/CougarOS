using System;
using apps = cos_apps;
using display = cos_api_display;
using io = cos_api_io;
using math = cos_api_math;
using sys = cos_api_system;
using usr = cos_api_user;

namespace CougarOS
{
    public class Commands
    {

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
        static apps.About appAbout = new apps.About();
        static apps.Clock appClock = new apps.Clock();
        static apps.Notepad appNotepad = new apps.Notepad();
        static apps.TextBrowser appTextBrowser = new apps.TextBrowser();
        static apps.Yes appYes = new apps.Yes();
        static apps.Cat appCat = new apps.Cat();

        // END OF APP DECLARATION

        public void changelog()
        {
            string[] changelog = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\CHANGELOG");

            int max = changelog.Length;

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(changelog[i]);
            }

            return;
        }

        public void cat()
        {
            appCat.Main();
            return;
        }

        public void yes()
        {
            appYes.Main();
            return;
        }

        public void textbrowser()
        {
            appTextBrowser.Main();
            return;
        }

        public void notepad()
        {
            appNotepad.Main();
            return;
        }

        public void clock()
        {
            appClock.Main();
            return;
        }

        public void about()
        {
            appAbout.ShowAbout();
            return;
        }

        public void calculator()
        {
            //Console.WriteLine(appCalculator.loadNumbers());
            appCalculator.Main();
            return;
        }

        public void help()
        {
            Console.WriteLine(appHelp.allHelp());
            return;
        }

        public void clear()
        {
            Console.Clear();
            return;
        }

    }
}
