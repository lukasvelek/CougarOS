using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml;

namespace cos_api_system
{
    public class Terminal
    {
        public string send(string cmd)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(@"Apps.xml");

            

            /*foreach(string app in apps)
            {
                if(cmd.ToLower() == app.ToLower())
                {
                    return cmd.ToLower();
                }
                else
                {
                    Console.WriteLine("No app named '" + cmd + "' was found. Please try again!");
                    return null;
                }
            }*/

            Console.ReadKey();

            return null;
        }

    }
}
