using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Trt_Proje1
{
    public partial class FaturaClas : System.Web.UI.Page
    {
        BillClas Clas = new BillClas();
        protected void Page_Load(object sender, EventArgs e)
        {
            string getir = "SELECT FirmaID,FirmaAdi FROM FirmaTable";
            FirmaDDL.DataSource = Clas.TabloGetir(getir);
            FirmaDDL.DataTextField = "FirmaID";
            FirmaDDL.DataValueField = "FirmaAdi";
            FirmaDDL.DataBind();
        }
        protected void AnaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");
        }

        protected void FirmaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirmaBilgileri.aspx");
        }

        protected void UrunBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Urunler.aspx");
        }

        protected void KullaniciBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciListesi.aspx");
        }

        protected void CıkısBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }

        protected void StokBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stok.aspx");
        }

        protected void FirmaDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FirmaID.Text = HttpUtility.HtmlDecode(FirmaDDL.);

        }
    }
}