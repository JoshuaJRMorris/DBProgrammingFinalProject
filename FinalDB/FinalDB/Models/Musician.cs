using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDB
{
    public class Musician
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string instrument { get; set; }
        public string roleInBand { get; set; }

        public Musician()
        {

        }

        public Musician(string firstName, string lastName, string instrument, string roleInBand)
        {

        }

    }
}
