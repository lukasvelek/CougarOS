using System;

namespace cos_apps
{
    public class Help
    {
        public string AppVersion { get; private set; }

        public Help()
        {
            AppVersion = "1.0";
        }

        public string allHelp()
        {
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\Help_AllCommands");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            return null;
        }

    }
}
