using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_apps
{
    public class Notepad
    {
        public string AppVersion { get; private set; }

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        public Notepad()
        {
            AppVersion = "1.1";
        }

        public void Main()
        {
            /*Console.WriteLine("Name of the file: ");
            string filename = Console.ReadLine();

            Console.Clear();

            string text = "";
            List<string> fulltext = new List<string>();

            do
            {
                text = Write();
                fulltext.Add(text);
            } while (text != "END");

            // SAVE INTO FILE

            System.IO.File.WriteAllLines(@"FILESYSTEM\home\root\Documents\" + filename + ".document", fulltext);*/
        }

        public void NewFile()
        {
            Console.WriteLine("Name of the file: ");
            string filename = Console.ReadLine();

            Console.Clear();

            string text = "";
            List<string> fulltext = new List<string>();

            do
            {
                text = Write();
                fulltext.Add(text);
            } while (text != "END");

            // SAVE INTO FILE

            System.IO.File.WriteAllLines(@"FILESYSTEM\home\root\Documents\" + filename + ".document", fulltext);
        }

        public void OpenFile(string file)
        {
            if (System.IO.File.Exists(@file))
            {

            }
            else
            {
                Console.WriteLine("File doesn't exist!");
                return;
            }
        }

        public string Write()
        {
            string text = Console.ReadLine();
            return text;
        }

        public void Read(string file)
        {
            
        }


        private bool FileEixsts(string file, string dir = null)
        {
            if(dir == null)
            {
                // all

                string[] directories = System.IO.Directory.GetDirectories("");

                string dirSuper = dir.Replace("/", "\\");

                System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@"FILESYSTEM" + dirSuper);
                System.IO.FileInfo[] Files = d.GetFiles("*.*");

                string[] directories = System.IO.Directory.GetDirectories(@"FILESYSTEM" + dirSuper);

                foreach (string f in directories)
                {
                    //Console.WriteLine(f);

                    if (file == f)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                string dirSuper = dir.Replace("/", "\\");

                System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@"FILESYSTEM" + dirSuper);
                System.IO.FileInfo[] Files = d.GetFiles("*.*");

                string[] directories = System.IO.Directory.GetDirectories(@"FILESYSTEM" + dirSuper);

                foreach (string f in directories)
                {
                    //Console.WriteLine(f);

                    if (file == f)
                    {
                        return true;
                    }
                }
            }
        }
    }
}
