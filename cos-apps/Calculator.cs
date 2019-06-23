using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using lng = cos_languages;

namespace cos_apps
{
    public class Calculator
    {

        lng.Translator translator = new lng.Translator();

        string[] lng = System.IO.File.ReadAllLines(@"Language.cfg");
        string language;

        public Calculator()
        {
            if(lng[0].ToLower() == "czech")
            {
                language = "Czech";
            }
            else
            {
                language = "English";
            }
        }

        public double loadNumbers()
        {
            Console.Clear();
            Console.WriteLine("{0}: ", translator.Translate(language, "app_calculator_number1"));
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0}: ", translator.Translate(language, "app_calculator_number2"));
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} (+,-,*,/): ", translator.Translate(language, "app_calculator_function"));
            string f = Console.ReadLine();

            switch (f)
            {
                case "+":
                    return (double)x + (double)y;
                case "-":
                    return (double)x - (double)y;
                case "*":
                    return (double)x * (double)y;
                case "/":
                    return (double)x / (double)y;
                default:
                    loadNumbers();
                    break;
            }

            loadNumbers();
            return 0.0;
        }

        public int straightResponse(string text)
        {
            string pattern = @"(\d+)\s+([-+*/])\s+(\d+)";
            foreach (var expression in text)
            {
                foreach (Match m in Regex.Matches(text, pattern))
                {
                    int value1 = Int32.Parse(m.Groups[1].Value);
                    int value2 = Int32.Parse(m.Groups[3].Value);
                    switch (m.Groups[2].Value)
                    {
                        case "+":
                            return value1 + value2;
                        case "-":
                            return value1 - value2;
                        case "*":
                            return value1 * value2;
                        case "/":
                            return value1 / value2;
                    }
                }
            }

            return 0;
        }

    }
}
