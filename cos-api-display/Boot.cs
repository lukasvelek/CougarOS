using System;
using System.IO;

namespace cos_api_display
{
    public class Boot
    {

        public void drawLogo()
        {
            /*Console.WriteLine("--------------------");
            Console.WriteLine("- C O U G A R  O S -");
            Console.WriteLine("--------------------");
            Console.WriteLine("Copyright (c) 2019 Lukas Velek");*/
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\resources\os_logo.resource");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
        }

        public void updateFolderContents()
        {
            string[] cnt;

            // /home/ directory
            cnt = Directory.GetFiles(@"FILESYSTEM\home\", "*.*");

            System.IO.File.WriteAllLines(@"FILESYSTEM/home/home", cnt);

            // /home/root/ directory
            cnt = Directory.GetFiles(@"FILESYSTEM\home\root\", "*.*");

            System.IO.File.WriteAllLines(@"FILESYSTEM/home/root/root", cnt);

            // /home/root/Documents/ directory
            cnt = Directory.GetFiles(@"FILESYSTEM\home\root\Documents\", "*.*");

            System.IO.File.WriteAllLines(@"FILESYSTEM/home/root/Documents/Documents", cnt);    
        }
    } 
}
