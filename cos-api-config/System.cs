using sys = System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_api_config
{
    public class System
    {

        public string Language { get; set; }
        public string TextColor { get; set; }
        public string BackgroundColor { get; set; }
        public string CurrentLocation { get; set; }
        public string SystemBuild { get; private set; }
        public string SystemVersionCodename { get; private set; }

        public bool HasBootedUp { get; set; }

        public string SystemVersion { get; private set; }


        public void SystemVersionGet()
        {
            string[] lines = sys.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\SystemInfo.cfg");

            SystemVersion = lines[0];
            SystemVersionCodename = lines[1];
            SystemBuild = lines[2];
        }

    }
}
