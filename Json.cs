﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabComparison
{
    /// <summary>
    /// JT> What is the purpose of this class?
    /// </summary>
    class Json
    {
        public class Rootobject
        {
            public Item[] items { get; set; }
        }

        public class Item
        {
            public string barcode { get; set; }
            public DateTime date_of_birth { get; set; }
        }

    }
}
