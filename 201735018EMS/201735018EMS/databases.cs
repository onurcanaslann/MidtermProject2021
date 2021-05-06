using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201735018EMS
{
    class databases
    {
        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DBems;Integrated Security=True");

    }
}
