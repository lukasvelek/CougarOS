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
                            Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
                            break;
                        case "-":
                            Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
                            break;
                        case "*":
                            Console.WriteLine("{0} = {1}", m.Value, value1 * value2);
                            break;
                        case "/":
                            Console.WriteLine("{0} = {1:N2}", m.Value, value1 / value2);
                            break;
                    }
                }
            }

            return 0;
        }

    }
}
