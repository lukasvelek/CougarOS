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
            /*XmlDocument doc = new XmlDocument();

            doc.Load(@"Apps.xml");

            XmlNodeList normalUserApps = doc.SelectNodes("/Apps/UserAccess");

            foreach(XmlNode app in normalUserApps)
            {
                if(cmd.ToLower() == app.InnerText.ToLower())
                {
                    Console.WriteLine(app.InnerText);
                    //return cmd.ToLower();
                }
                else
                {
                    Console.WriteLine("No app named '" + cmd + "' was found. Please try again!");
                    return null;
                }
            }*/

            using(XmlReader reader = XmlReader.Create(@"Apps.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Title":
                                break;
                            case "Version":
                                break;
                        }
                    }
                }
            }

            Console.ReadKey();

            return null;
        }

    }
}
