using System;

using lng = cos_languages;
using cfg = cos_api_config;

namespace cos_apps
{
    public class Calculator
    {
        public string AppVersion { get; private set; }

        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        lng.Translator translator = new lng.Translator();

        public Calculator()
        {
            AppVersion = "1.0";
        }

        public void Main()
        {
            double a, b;
            string op;
            bool cont;

            do
            {
                // ALPHA DESIGN

                cont = false;
                Console.WriteLine("{0}: ", translator.Translate(cfgapisys.Language, "app_calculator_number"));
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0} (+, -, *, /): ", translator.Translate(cfgapisys.Language, "app_calculator_operation"));
                op = Console.ReadLine();
                Console.WriteLine("{0}: ", translator.Translate(cfgapisys.Language, "app_calculator_number"));
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0}?", translator.Translate(cfgapisys.Language, "app_calculator_continue"));
                Console.WriteLine("1/ {0}", translator.Translate(cfgapisys.Language, "app_calculator_yes"));
                Console.WriteLine("2/ {0}", translator.Translate(cfgapisys.Language, "app_calculator_no"));
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        switch (op)
                        {
                            case "+":
                                a += b;
                                break;
                            case "-":
                                a -= b;
                                break;
                            case "*":
                                a *= b;
                                break;
                            case "/":
                                a /= b;
                                break;
                            default:
                                a += b;
                                break;
                        }
                        continue;
                    case "2":
                        break;
                    default:
                        continue;
                }

            } while (cont);

            double result;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    result = 0.0;
                    break;
            }

            Console.WriteLine("{0}: {1}", translator.Translate(cfgapisys.Language, "app_calculator_theresultis"), result); // the result is: result
            Console.WriteLine("{0}", translator.Translate(cfgapisys.Language, "app_calculator_pressentertogoback")); // press enter to go back to desktop
            Console.ReadLine();
            return;

            // END OF ALPHA DESIGN

        }

        /*public double loadNumbers()
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
            string pattern = @"(\d+)\s+([-+*//*])\s+(\d+)";
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
        }*/

    }
}
