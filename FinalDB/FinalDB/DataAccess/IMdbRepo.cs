using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalDB.Models;

namespace FinalDB.DataAccess
{
    public interface IMdbRepo
    {
        public abstract DataTable GetData(string sql);

        //reimplement these to be useful
        public abstract DataTable GetBands();
        public abstract DataTable GetMusicians();
        public abstract DataTable GetBand(string id);
        public abstract DataTable GetRelationship(int bandId);

        void CreateMusician(Musician musician);
        void CreateBand(Band band);
        void CreateRelationship(MusicianBand musicianBand);

        



    }
}
