﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielleRodriguez_CPT_206_Project
{
    internal class DnDClassConnection
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Result
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Root
        {
            public int count { get; set; }
            public List<Result> results { get; set; }
        }
    }
}
