using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cos_apps
{
    public class Help
    {

        public string allHelp()
        {
            string[] lines = System.IO.File.ReadAllLines("Help_AllCommands");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            return null;
        }

    }
}
