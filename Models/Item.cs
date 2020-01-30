using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusterPoint.Models
{
    public class Item
    {
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemCost { get; set; }
        public Array ItemProfiles { get; set; }
    }
}
