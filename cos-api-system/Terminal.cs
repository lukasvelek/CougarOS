using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using io = cos_api_io;

namespace cos_api_system
{
    public class Terminal
    {

        io.File iofile = new io.File();

        public bool checkPassword(string username)
        {
            Console.WriteLine("Password: ");

            string subpassword = Console.ReadLine();

            if (iofile.checkPassword(username, subpassword))
            {
                // password is ok
                return true;
            }

            return false;
        }

    }
}
