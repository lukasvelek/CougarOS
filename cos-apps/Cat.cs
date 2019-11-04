using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cfg = cos_api_config;

namespace cos_apps
{
    public class Cat
    {

        cfg.System cfgapisys = new cfg.System();

        public void Main()
        {
            Console.WriteLine("Filename (or 0 to leave): ");
            string filename = Console.ReadLine();

            if (System.IO.File.Exists(@cfgapisys.CurrentLocation + filename))
            {

            }
            else
            {
                if(filename == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Doesn't exist!");
                    Main();
                }
            }
        }

    }
}
