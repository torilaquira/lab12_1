using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardLab.Models
{
    public class Root
    {

        public bool success { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public bool shuffled { get; set; }
        public int deck_count { get; set; }
        public List<Cards> cards { get; set; }
    }

    public class Cards
    {
        public bool success { get; set; }
        public List<string> cards { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
    }

}
