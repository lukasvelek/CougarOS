using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace cos_api_system
{
    public class Terminal
    {


        public string send(string cmd)
        {
            string[] lines = File.ReadAllLines(@"Apps.lf");

            foreach(string line in lines)
            {
                if(line == ("[App-\"" + cmd + "\" /]"){
                    return calculator;
                }
                else
                {
                    //break;

                }
            }

            Console.ReadKey();

            return null;
        }

    }
}
