using System;
using cfg = cos_api_config;

namespace cos_api_files
{
    public class Browser
    {

        /*
        
            All the files being contained in a directory are being listed in a same called file

            /home/ - base directory of users
            /home/root/ - base directory of user 'root'
             
        */

        cfg.System cfgapisys = new cfg.System();

        public string directory { get; set; }
        public string directoryShort { get; set; }

        public Browser()
        {
            directory = "/home/";
            directoryShort = "home";
        }

        public void ChangeDirectory(string newDir)
        {
            directory = newDir;
            directoryShort = newDir.Replace("/", "-");
            cfgapisys.CurrentLocation = directoryShort;
            cfgapisys.CurrentLocationLong = directory;
            return;
        }

        public void ListContentOfDirectory(string dir)
        {
            // for example: /home/
            string dirSuper = dir.Replace("/","\\");

            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@"FILESYSTEM" + dirSuper);
            System.IO.FileInfo[] Files = d.GetFiles("*.*");

            string[] directories = System.IO.Directory.GetDirectories(@"FILESYSTEM" + dirSuper);

            foreach(string f in directories)
            {
                Console.WriteLine(f);
            }
        }

    }
}
