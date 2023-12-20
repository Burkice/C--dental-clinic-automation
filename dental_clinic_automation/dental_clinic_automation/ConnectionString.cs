using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dental_clinic_automation
{
    class ConnectionString
    {
       public SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-925472U\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True";
            return con;

        }
    }
}
