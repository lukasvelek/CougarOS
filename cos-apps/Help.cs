using System;

namespace cos_apps
{
    public class Help
    {

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
