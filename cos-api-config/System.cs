using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_api_config
{
    public class System
    {

        public string Language { get; set; }
        public string TextColor { get; set; }
        public string BackgroundColor { get; set; }
        public string CurrentLocation { get; set; }

        public bool HasBootedUp { get; set; }

    }
}
