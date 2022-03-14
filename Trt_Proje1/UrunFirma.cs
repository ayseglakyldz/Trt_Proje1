using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Trt_Proje1
{
    public class UrunFirma
    {
        int s = 0;
        SqlConnection baglanti = new SqlConnection();
        DataTable datatbl = new DataTable();
        public void baglan()
        {
            string cumle ="Data Source=.\\SQLEXPRESS;Initial Catalog=Proje;User id=sa;Password=1234qqQ";
            baglanti.ConnectionString = cumle;
          
        }

        public int SqlCalistir(string sql, params SqlParameter[] prms)
        {
            SqlCommand komut = new SqlCommand(sql, baglanti);
            if (prms != null)
            {
                komut.Parameters.AddRange(prms);
            }

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            try
            {
                s = komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
            return s;
        }
        public DataTable TabloGetir(string sql)
        {
            baglan();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            try
            {
                SqlCommand komut = new SqlCommand(sql, baglanti);
                SqlDataAdapter veritasi = new SqlDataAdapter(komut);
                veritasi.Fill(datatbl);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                baglanti.Close();
            }
            return datatbl;
        }
    }
}