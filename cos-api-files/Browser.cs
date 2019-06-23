using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace cos_api_files
{
    public class Browser
    {

        /*
        
            The whole filesystem is saved in the 'FILESYSTEM.zip' file and is compressed.
             
        */

        private string filesystemFile = @"FILESYSTEM.zip";

        public string directory { get; set; }
        public string directoryShort { get; set; }

        public Browser()
        {
            directory = "/home/";
            directoryShort = "home";
        }
        
        public void ListContentOfDirectory(string dir)
        {
            switch (dir)
            {
                case "/home/":
                    
                    break;
            }
        }

    }
}
