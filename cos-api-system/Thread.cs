using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_api_system
{
    public class Thread
    {

        public void sleep(int time /* time in seconds */)
        {
            System.Threading.Thread.Sleep(time * 1000);
        }

    }
}
