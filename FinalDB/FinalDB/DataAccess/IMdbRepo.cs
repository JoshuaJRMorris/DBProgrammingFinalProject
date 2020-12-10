using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDB.DataAccess
{
    public interface IMdbRepo
    {
        public abstract DataTable GetData(string sql);

        //reimplement these to be useful
        public abstract DataTable GetSuppliers();
        public abstract DataTable GetProducts(int id);

        void CreateMusician(Musician musician);

    }
}
