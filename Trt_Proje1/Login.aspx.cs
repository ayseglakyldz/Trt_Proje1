using System;
using System.Collections.Generic;
using System.Web.Security;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Trt_Proje1
{

    public partial class Login : System.Web.UI.Page
    {
        NewUsers Clas = new NewUsers();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (NewUsers.kayit == 1)
            {
                NewUsers.kayit = 0;
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Bir Kullanıcı Tanımlanmıştır');</script>");
            }
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session.Timeout =3;
           
        }
        protected void Giris_Btn_Click(object sender, EventArgs e)
        {
            string Kad, sifre;
            Kad = KullanAd_TextBox.Text;
            sifre = Sifre_TextBox.Text;
            bool dr = Clas.KullaniciGetir(Kad,sifre);
            if (dr==true)
            {
                Session.Add("Kullanıcı", Kad);
                Clas.Baglan().Close();
                KullanAd_TextBox.Text = "";
                Sifre_TextBox.Text = "";
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                KullanAd_TextBox.Text = "";
                Sifre_TextBox.Text = "";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Kullanıcı veya Şifre Yanlış');</script>");
            }
        }

        protected void Yeni_Btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }
    }
}