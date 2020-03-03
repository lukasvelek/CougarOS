using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update
{
    public class Program
    {

        public static void Main(string[] args)
        {
            MoveFiles();
            GenerateFiles();
        }

        private static void MoveFiles()
        {

        }

        private static void GenerateFiles()
        {
            System.IO.File.WriteAllText(@"FILESYSTEM\sys\UPDATING.sys", "UPDATING=true");
        }

    }
}
