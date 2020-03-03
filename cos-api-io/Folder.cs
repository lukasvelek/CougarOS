using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_api_io
{
    public class Folder
    {

        public void createFolder(string name, string path)
        {
            string fullpath = path + name;

            System.IO.Directory.CreateDirectory(@fullpath);
        }

    }
}
