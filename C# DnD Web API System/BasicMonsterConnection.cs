using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielleRodriguez_CPT_206_Project
{
    public class BasicMonsterConnection
    {
        public class root
        {
            public List<results> results { get; set; }
        }
        public class results
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
    }
}
