using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_clinic_automation
{
    class Tedaviler
    {
        public void HastaEkle(string query)
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

        public void HastaGuncelle(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection baglantı = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglantı;
            komut.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
           
        }
        public DataSet ShowHasta(string query)
        {


            ConnectionString MyConnection = new ConnectionString();
            SqlConnection baglantı = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglantı;
            komut.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;




        }
    }
}
