using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_apps
{
    public class Yes
    {
        public string AppVersion { get; private set; }

        public Yes()
        {
            AppVersion = "1.0";
        }

        public void Main()
        {
            Console.WriteLine("Count: ");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Text: ");
            string text = Console.ReadLine();

            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine(text);
            }

            return;
        }

    }
}
