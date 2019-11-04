using System;
using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_apps
{
    public class Clock
    {
        public string AppVersion { get; private set; }

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();
        
        public Clock()
        {
            AppVersion = "1.0";
        }

        public void Main()
        {
            Console.Clear();

            /*
             
                    1) Current time
                    2) Set Alarm
                    3) Back
             
             */

            Console.WriteLine("1/ {0}", translator.Translate(cfgapisys.Language, "app_clock_currenttime"));
            Console.WriteLine("2/ {0}", translator.Translate(cfgapisys.Language, "app_clock_setalarm"));
            Console.WriteLine("0/ {0}", translator.Translate(cfgapisys.Language, "app_clock_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CurrentTime();
                    break;
                case "2":
                    SetAlarm();
                    break;
                case "0":
                    return;

                default:
                    Main();
                    break;
            }
        }

        public void CurrentTime()
        {
            DateTime dt = DateTime.Now;

            Console.Clear();
            Console.WriteLine("{0}: {1}:{2}:{3}", translator.Translate(cfgapisys.Language, "app_clock_currenttime"), dt.Hour, dt.Minute, dt.Second);
            Console.WriteLine("");
            return;
        }

        public void SetAlarm()
        {

        }

    }
}
