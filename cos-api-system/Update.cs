using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

using cfg = cos_api_config;
using Update;

namespace cos_api_system
{
    public class Update
    {

        cfg.System cfgapisys = new cfg.System();

        //Update update = new Update();

        // cos_update_x.y.pack

        string updateFileNameSmall;
        string updateFileNameBig;

        bool unpacked = false;

        public void Main()
        {
            updateFileNameBig = "cos_update.pack";
            updateFileNameSmall = "cos_patch.pack";

            if(System.IO.Directory.GetFiles(@"FILESYSTEM\usr\updates\") == null)
            {
                string[] files = System.IO.Directory.GetFiles(@"FILESYSTEM\usr\updates\");

                foreach (string file in files)
                {
                    string[] fp = file.Split('\\');

                    if (fp[4] == updateFileNameBig)
                    {
                        if(System.IO.Directory.Exists(@"FILESYSTEM\usr\updates\update\"))
                        {
                            System.IO.Directory.Delete(@"FILESYSTEM\usr\updates\update\");
                        }

                        Unpack(updateFileNameBig, @"FILESYSTEM\usr\updates\update\", updateFileNameBig);
                        unpacked = true;
                    }
                    else if (fp[4] == updateFileNameSmall)
                    {
                        if (System.IO.Directory.Exists(@"FILESYSTEM\usr\updates\update\"))
                        {
                            System.IO.Directory.Delete(@"FILESYSTEM\usr\updates\update\");
                        }

                        Unpack(updateFileNameSmall, @"FILESYSTEM\usr\updates\update\", updateFileNameSmall);
                        unpacked = true;
                    }
                    else
                    {
                        Console.WriteLine("No update files found!");
                        return;
                    }
                }

                if (unpacked)
                {
                    InstallUpdate(@"FILESYSTEM\usr\updates\update\");
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("No update files found!");
            }
        }

        private void Unpack(string path, string unpackTo, string filename)
        {
            try
            {
                try
                {
                    System.IO.Directory.CreateDirectory(@"FILESYSTEM\usr\updates\" + filename);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                //ZipFile.ExtractToDirectory(@cfgapisys.CurrentLocationLong + path, unpackTo);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public void Install()
        {
            InstallUpdate(@"FILESYSTEM\usr\updates\update\", true);
        }

        private void InstallUpdate(string path, bool finish=false)
        {
            string[] lines = System.IO.File.ReadAllLines(@path + "UpdateInfo.cfg");

            /*
             * Update Version
             * Update Version Codename
             * Update Build
             */



            // UPDATE ITSELF

            //cfgapisys.IsUpdating = true;

            Main();
            Environment.Exit(0);

            // END OF UPDATE ITSELF


            // POST UPDATE

            //cfgapisys.SystemVersionUpdate(lines[0], lines[1], lines[2]);

            // END OF POST UPDATE
        }

    }
}
