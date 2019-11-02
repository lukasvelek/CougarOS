using System;
using lng = cos_languages;

namespace CougarOS
{
    public class ConfigPersonalization
    {
        lng.Translator translator = new lng.Translator();
        lng.English l_english = new lng.English();

        string[] lng = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Language.cfg");
        string language;

        public ConfigPersonalization()
        {
            if (lng[0].ToLower() == "czech")
            {
                language = "Czech";
            }
            else
            {
                language = "English";
            }
        }

        public void Main()
        {
            Console.Clear();
            Console.WriteLine("{0}/{1}/", translator.Translate(language, "cfgmenu_title"), translator.Translate(language, "cfgmenu_personalization_title"));
            Console.WriteLine("");
            Console.WriteLine("1/ {0}", translator.Translate(language, "cfgmenu_personalization_colors"));
            Console.WriteLine("2/ {0}", translator.Translate(language, "cfgmenu_personalization_titles"));
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    //ListAllUsers();
                    Colors();
                    break;
                case "2":
                    //AddAUser();
                    break;
                case "0":
                    return;
                default:
                    Main();
                    break;
            }
        }

        private void Colors()
        {
            Console.Clear();
            Console.WriteLine("{0}/{1}/{2}/", translator.Translate(language, "cfgmenu_title"), translator.Translate(language, "cfgmenu_personalization_title"), translator.Translate(language, "cfgmenu_personalization_colors_title"));
            Console.WriteLine("");
            Console.WriteLine("1/ {0}", translator.Translate(language, "cfgmenu_personalization_colors_textcolor"));
            Console.WriteLine("2/ {0}", translator.Translate(language, "cfgmenu_personalization_colors_backgroundcolor"));
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ColorText();
                    break;
                case "2":
                    ColorBackground();
                    break;
                case "0":
                    break;
                default:
                    Colors();
                    break;
            }
        }

        private void ColorText()
        {
            Console.Clear();
            Console.WriteLine("{0}/{1}/{2}/{3}/", l_english.cfgmenu_title, l_english.cfgmenu_personalization_title, l_english.cfgmenu_personalization_colors_title, l_english.cfgmenu_personalization_colors_textcolor_title);
            Console.WriteLine("");
            Console.WriteLine("{0}: ", l_english.cfgmenu_personalization_colors_textcolor_chooseacolor);
            Console.WriteLine("1/ {0}", l_english.color_green); // green
            Console.WriteLine("2/ {0}", l_english.color_black); // black
            Console.WriteLine("3/ {0}", l_english.color_blue); // blue
            Console.WriteLine("4/ {0}", l_english.color_white); // white
            Console.WriteLine("5/ {0}", l_english.color_yellow); // yellow
            Console.WriteLine("6/ {0}", l_english.color_red); // red
            Console.WriteLine("7/ {0}", l_english.color_magenta); // magenta
            Console.WriteLine("0/ {0}", l_english.cfgmenu_back);
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    TextChangeColor("green");
                    break;
                case "2":
                    TextChangeColor("black");
                    break;
                case "3":
                    TextChangeColor("blue");
                    break;
                case "4":
                    TextChangeColor("white");
                    break;
                case "5":
                    TextChangeColor("yellow");
                    break;
                case "6":
                    TextChangeColor("red");
                    break;
                case "7":
                    TextChangeColor("magenta");
                    break;
                case "0":
                    Colors();
                    break;
                default:
                    ColorText();
                    break;
            }
        }

        private void ColorBackground()
        {
            Console.Clear();
            Console.WriteLine("{0}/{1}/{2}/{3}/", translator.Translate(language, "cfgmenu_title"), translator.Translate(language, "cfgmenu_personalization_title"), translator.Translate(language, "cfgmenu_personalization_colors_title"), translator.Translate(language, "cfgmenu_personalization_colors_backgroundcolor_title")); // cfg, person, clr, bg
            Console.WriteLine("");
            Console.WriteLine("{0}: ", translator.Translate(language, "cfgmenu_personalization_colors_backgroundcolor_chooseacolor"));
            Console.WriteLine("1/ {0}", translator.Translate(language, "color_green")); // green
            Console.WriteLine("2/ {0}", translator.Translate(language, "color_black")); // black
            Console.WriteLine("3/ {0}", translator.Translate(language, "color_blue")); // blue
            Console.WriteLine("4/ {0}", translator.Translate(language, "color_white")); // white
            Console.WriteLine("5/ {0}", translator.Translate(language, "color_yellow")); // yellow
            Console.WriteLine("6/ {0}", translator.Translate(language, "color_red")); // red
            Console.WriteLine("7/ {0}", translator.Translate(language, "color_magenta")); // magenta
            Console.WriteLine("0/ {0}", translator.Translate(language, "cfgmenu_back"));
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BackgroundChangeColor("green");
                    break;
                case "2":
                    BackgroundChangeColor("black");
                    break;
                case "3":
                    BackgroundChangeColor("blue");
                    break;
                case "4":
                    BackgroundChangeColor("white");
                    break;
                case "5":
                    BackgroundChangeColor("yellow");
                    break;
                case "6":
                    BackgroundChangeColor("red");
                    break;
                case "7":
                    BackgroundChangeColor("magenta");
                    break;
                case "0":
                    Colors();
                    break;
                default:
                    ColorBackground();
                    break;
            }
        }

        // Color Changing Functions
        private void TextChangeColor(string color)
        {
            switch (color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }

            //System.IO.File.WriteAllText(@"TextColor.cfg", color);

            // fg1, bg0
            string[] colors = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Color.cfg");
            string bg = colors[0];
            string fg = color;

            string[] newColors = { bg, fg };

            System.IO.File.WriteAllLines(@"FILESYSTEM\sys\config\Color.cfg", newColors);

            ColorText();
        }

        private void BackgroundChangeColor(string color)
        {
            switch (color)
            {
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
            }

            string[] colors = System.IO.File.ReadAllLines(@"FILESYSTEM\sys\config\Color.cfg");
            string bg = color;
            string fg = colors[1];

            string[] newColors = { bg, fg };

            System.IO.File.WriteAllLines(@"FILESYSTEM\sys\config\Color.cfg", newColors);

            ColorBackground();
        }
    }
}
