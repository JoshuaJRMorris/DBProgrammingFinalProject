using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDB.Models
{
    public class MusicianBand
    {
        public int id { get; set; }
        public int musicianId { get; set; }
        public int bandId { get; set; }
        public string joinedBand { get; set; }
        public string leftBand { get; set; }
        public bool playedOnRelease { get; set; }

        public MusicianBand()
        {
            playedOnRelease = false;
        }
    }
}
