using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;
using System.Linq;
using System.Web.Security;





namespace Trt_Proje1
{
    public class NewUsers
    {
        static public int kayit = 0;
        static public int s = 0;

        public SqlConnection Baglan()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Proje;User id=sa;Password=1234qqQ";
            conn.Open();
            return conn;
        }

        public DataTable TabloGetir(string cumle)
        {
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand(cumle, Baglan());
            SqlDataAdapter sqlda = new SqlDataAdapter(komut);
            sqlda.Fill(dt);
            Baglan().Close();
            return dt;
        }

        public bool KullaniciGetir(string Kad, string Sifre)
        {
            bool result = false;
            SqlCommand komut = new SqlCommand("SELECT * FROM KullaniciTable WHERE KullaniciAdi='" + Kad + "' AND Sifre='" + Sifre + "'", Baglan());
            var oku = komut.ExecuteReader();
            if (oku.Read())
            {
                result = true;
            }
            Baglan().Close();
            return result;
        }

        public bool TanimliUser(string Kullad)
        {
            bool result = false;
            SqlCommand komut = new SqlCommand("SELECT KullaniciAdi FROM KullaniciTable WHERE KullaniciAdi='" + Kullad + "'", Baglan());
            var oku = komut.ExecuteReader();

            if (oku.Read())
            {
                result = true;
            }
            Baglan().Close();
            return result;
        }

        public int UserEkle(string kad, string sifre, string ad, string soyad)
        {
            string query = "INSERT INTO  KullaniciTable (Adi,Soyadi,KullaniciAdi,Sifre) values (@ad,@soyad,@kad,@sifre)";
            SqlCommand komut = new SqlCommand(query, Baglan());
            komut.Parameters.AddWithValue("@kad", kad);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            s = komut.ExecuteNonQuery();
            return s;
        }
        public int UserGuncelle(string kid, string kad, string sifre, string ad, string soyad)
        {
            string sorgu = "UPDATE KullaniciTable set Adi=@ad,Soyadi=@soyad,KullaniciAdi=@kad,Sifre=@sifre where ID=@kid";
            SqlCommand komut = new SqlCommand(sorgu, Baglan());
            komut.Parameters.AddWithValue("@kad", kad);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@kid", kid);
            s = komut.ExecuteNonQuery();
            return s;
        }

        public int Sil(string SilTxt)
        {
            string sorgu = "DELETE FROM KullaniciTable WHERE ID=@kid";
            SqlCommand komut = new SqlCommand(sorgu, Baglan());
            komut.Parameters.AddWithValue("@kid", SilTxt);
            s = komut.ExecuteNonQuery();
            return s;
        }
    }
}
