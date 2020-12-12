using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDB.Models
{
    public class Band
    {
        public int id { get; set; }
        public string bandName { get; set; }
        public string yearFounded { get; set; }
        public bool stillTogether { get; set; }
        public int releases { get; set; }
        public string genre { get; set; }

        public Band()
        {
            stillTogether = false;
        }
    }
}
