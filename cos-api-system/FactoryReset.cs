using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_api_system
{
    public class FactoryReset
    {

        public bool CheckPassword()
        {
            Console.WriteLine("Enter sudo password: ");
            string password = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

            foreach(string line in lines)
            {
                string[] l = line.Split('-');

                // 0 name, 1 password, 2 permissions
                if(password == l[1] && l[2] == "admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\resources\os_logo.resource");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("Installer Worker is working...");
            if (!RemoveFiles())
            {
                Main();
            }
            if (!RemoveFile(@"FILESYSTEM\sys\POST_INSTALLATION.sys"))
            {
                Main();
            }

        }

        private bool RemoveFile(string path)
        {
            try
            {
                System.IO.File.Delete(@path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveFiles()
        {
            try
            {
                System.IO.File.Delete(@"FILESYSTEM\sys\cos_user.db");
                System.IO.File.Delete(@"FILESYSTEM\sys\config\Color.cfg");
                System.IO.File.Delete(@"FILESYSTEM\sys\config\Language.cfg");

                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"FILESYSTEM\home\");

                foreach(System.IO.FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                foreach(System.IO.DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
