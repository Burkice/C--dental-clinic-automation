using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;

namespace dental_clinic_automation
{
    class Hastalar
    {
        public void HastaEkle(string query)
        {
            ConnectionString MyConnection =new ConnectionString();
            SqlConnection baglantı = MyConnection.GetCon();
            SqlCommand komut= new SqlCommand();
            komut.Connection = baglantı;
            baglantı.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglantı.Close();

        }
        public void HastaSil(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection baglantı = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglantı;
            baglantı.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        public DataSet ShowHasta(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection baglantı = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglantı;
            komut.CommandText = query;
            SqlDataAdapter sda=new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
