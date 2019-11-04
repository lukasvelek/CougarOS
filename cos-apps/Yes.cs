using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_apps
{
    public class Yes
    {

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
