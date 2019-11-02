using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cos_api_display;

namespace cos_api_system
{
    public class Boot
    {

        cos_api_display.Boot dispboot = new cos_api_display.Boot();
        Thread thread = new Thread();

        public void PreConfigLoad()
        {
            if(CheckForFiles() != "null")
            {
                Repair();
            }

            dispboot.drawLogo();
            dispboot.updateFolderContents();
        }

        public void PostConfigLoad()
        {
            thread.sleep(3);
        }

        public string CheckForFiles()
        {
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\SYSTEMFILES.list");

            foreach(string line in lines)
            {
                if (System.IO.File.Exists(@"FILESYSTEM\" + line))
                {
                    continue;
                }
                else
                {
                    return "FILESYSTEM\\" + line;
                }
            }

            return "null";
        }

        public void Repair()
        {
            System.IO.File.Delete(@"FILESYSTEM\sys\POST_INSTALLATION.sys");
        }

    }
}
