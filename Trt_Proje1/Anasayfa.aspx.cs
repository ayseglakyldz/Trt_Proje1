using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;


namespace Trt_Proje1
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void CıkısBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }
        protected void FaturaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fatura.aspx");
        }
        protected void KullaniciBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciListesi.aspx");
        }
        protected void UrunBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Urunler.aspx");
        }
        protected void FirmaBilBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirmaBilgileri.aspx");
        }
        protected void StokBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stok.aspx");
        }
    }
}