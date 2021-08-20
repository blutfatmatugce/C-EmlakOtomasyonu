using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace emlakotomasyonu
{
    class bag
    {
        public SqlConnection pcbaglanti()
        {

            using (SqlConnection asusbaglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=emlakDB;Integrated Security=True"))
            {
              //  asusbaglanti.Open();
                return asusbaglanti;
            }

        }

    }
}
