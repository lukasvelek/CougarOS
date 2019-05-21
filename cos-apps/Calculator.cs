using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace cos_apps
{
    public class Calculator
    {

        public double loadNumbers()
        {
            Console.Clear();
            Console.WriteLine("Number 1: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Function (+,-,*,/): ");
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
