using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Trt_Proje1
{
    public partial class Kullanıcı : System.Web.UI.Page
    {
        NewUsers Clas = new NewUsers();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Kaydet_Btn_Click(object sender, EventArgs e)
        {
            string KulAd = HttpUtility.HtmlDecode(Kad_TextBox.Text);
            string Sifre = HttpUtility.HtmlDecode(Sifre_TextBox.Text);
            string Onay = HttpUtility.HtmlDecode(Onay_TextBox.Text);
            string Adi = HttpUtility.HtmlDecode(Ad_TextBox.Text);
            string Soyadi = HttpUtility.HtmlDecode(Soyad_TextBox.Text);

            if (!(Clas.TanimliUser(KulAd)))
            {
                if (Onay == Sifre)
                {
                    if (Ad_TextBox.Text != "" && Sifre != "" && Soyad_TextBox.Text != "" && Kad_TextBox.Text != "")
                    {
                        Clas.UserEkle(KulAd, Sifre, Adi, Soyadi);

                        if (NewUsers.s == 1)
                        {
                            Response.Redirect("Login.aspx");
                        }
                        else
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Warning!", "<Script> alert ('Tüm Alanları Doldurun!');</Script>");
                        }

                    }
                    else Label4.Text = "Şifre eşleşmedi";
                }
            }
            else Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Warning!", "<Script> alert ('Kullanıcı Adı Tanımlı!');</Script>");

        }
    }
}