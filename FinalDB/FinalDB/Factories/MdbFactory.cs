using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalDB.DataAccess;

namespace FinalDB.Factories
{
    public class MdbFactory
    {
       public static IMdbRepo createRepo()
        {
            return new MySqlRepo();
        }
    }
}
