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

        // END OF APP DECLARATION

        public void calculator()
        {
            Console.WriteLine(appCalculator.loadNumbers());
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

        public void Manual()
        {
            string[] lines = System.IO.File.ReadAllLines(@"SystemManual");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            return;
        }

        public void About()
        {
            string[] lines = System.IO.File.ReadAllLines(@"About");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            return;
        }

        public bool AmIRoot(string status)
        {

            if(status == "user")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
