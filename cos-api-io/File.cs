using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace cos_api_io
{
    public class File
    {
        public void checkLogFile(string log_file_path, string filename)
        {
            if (System.IO.File.Exists(log_file_path + filename))
            {
                string zipFileName = "cos_logfile_" + DateTime.Now.ToString("MM.dd.yyyy_hh.mm.ss") + ".log.zip";

                Directory.CreateDirectory(log_file_path + "log");

                try
                {
                    System.IO.File.Move(log_file_path + filename, log_file_path + @"log\" + filename);
                }
                catch
                {
                    System.IO.File.Delete(log_file_path + @"log\" + filename);
                }

                try
                {
                    ZipFile.CreateFromDirectory(log_file_path + @"log\", log_file_path + zipFileName);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void log(string log_file_path, string filename, string text, bool sendDate = true)
        {
            bool _continue;

            try
            {
                FileStream fs = System.IO.File.Create(log_file_path + filename, 1000, FileOptions.WriteThrough);
                _continue = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                _continue = false;
            }

            if (!_continue)
            {
                Console.WriteLine("FATAL ERROR!");
                Console.ReadKey();
                return;
            }
            else
            {
                if (sendDate)
                {
                    FileStream fs = System.IO.File.Open(log_file_path + filename, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);

                    //Console.WriteLine("[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "] " + text);
                    AddText(fs, ("[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "] " + text));
                }
                else
                {
                    FileStream fs = System.IO.File.Open(log_file_path + filename, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);

                    //Console.WriteLine(text);
                    AddText(fs, text);
                }
            }
        }

        public bool checkAdmin(string user_file_path, string user_filename, string username, string password)
        {
            //string[] lines = System.IO.File.ReadAllLines(@"cos_user.db");
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

            foreach (string line in lines)
            {
                if (line == "\"" + username + "\"-\"" + password + "\"-normal")
                {
                    // normal user

                    return false;
                }
                else if (line == "\"" + username + "\"-\"" + password + "\"-admin")
                {
                    // administrator

                    return true;
                }
            }

            return false;
        }

        public bool checkPassword(string username, string password)
        {
            //string[] lines = System.IO.File.ReadAllLines(@"cos_user.db");
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

            foreach (string line in lines)
            {
                /*if(line == "\"" + username + "\"-\"" + password + "\"-admin"){
                    return true;
                }
                else if(line == "\"" + username + "\"-\"" + password + "\"-normal")
                {
                    return true;
                }
                else
                {
                    continue;
                }*/

                string[] mix = line.Split('-');
                string cname = mix[0];
                string cpass = mix[1];
                string cperm = mix[2];

                if (username == cname && password == cpass)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            return false;
        }

        public bool checkUserData(string user_file_path, string user_filename, string username, string password)
        {
            //string[] lines = System.IO.File.ReadAllLines(@"cos_user.db");
            string[] lines = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\cos_user.db");

            foreach (string line in lines)
            {
                /*if (line == ("\"" + username + "\"-\"" + password + "\"-admin") || line == ("\"" + username + "\"-\"" + password + "\"-normal"))
                {
                    return true;
                }
                else
                {
                    continue;
                }*/

                // name-password-perm

                string[] mix = line.Split('-');
                string cname = mix[0];
                string cpassword = mix[1];
                string cperm = mix[2];

                string eusername = username;
                string epassword = password;

                if (eusername == cname && epassword == cpassword)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            return false;
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
