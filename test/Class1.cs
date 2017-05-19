using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace test
{
    class Class1
    {
        public void connect(SqlConnection conn)
        {

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        }
    }
}
