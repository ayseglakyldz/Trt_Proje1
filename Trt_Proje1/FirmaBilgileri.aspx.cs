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
    public partial class FirmaBilgileri : System.Web.UI.Page
    {
        UrunFirma Class = new UrunFirma();
        protected void Page_Load(object sender, EventArgs e)
        {
            string getir = "SELECT * FROM FirmaTable";
            FirmaGrid.DataSource = Class.TabloGetir(getir);
            FirmaGrid.DataBind();
        }

        protected void CıkısBtn_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }

        protected void AnaBtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("Anasayfa.aspx");
        }

        protected void FaturaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fatura.aspx");
        }

        protected void UrunBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Urunler.aspx");
        }

        protected void KullaniciBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciListesi.aspx");
        }

        protected void FirmaGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTxt.Text = HttpUtility.HtmlDecode(FirmaGrid.SelectedRow.Cells[1].Text);

            FirmaAdTxt.Text = HttpUtility.HtmlDecode(FirmaGrid.SelectedRow.Cells[2].Text);

            AdresTxt.Text = HttpUtility.HtmlDecode(FirmaGrid.SelectedRow.Cells[3].Text);

            TelTxt.Text = HttpUtility.HtmlDecode(FirmaGrid.SelectedRow.Cells[4].Text);

            VergiTxt.Text = HttpUtility.HtmlDecode(FirmaGrid.SelectedRow.Cells[5].Text);
        }

        protected void KaydetBtn_Click(object sender, EventArgs e)
        {
            string Ad = HttpUtility.HtmlDecode(FirmaAdTxt.Text);

            string Adres = HttpUtility.HtmlDecode(AdresTxt.Text);

            string Tel = HttpUtility.HtmlDecode(TelTxt.Text);

            string VergiNo = HttpUtility.HtmlDecode(VergiTxt.Text);
            SqlParameter Prm1 = new SqlParameter("@P1", Ad);
            SqlParameter Prm2 = new SqlParameter("@P2", Adres);
            SqlParameter Prm3 = new SqlParameter("@P3", Tel);
            SqlParameter Prm4 = new SqlParameter("@P4", VergiNo);

            string sorgu = "INSERT INTO  FirmaTable (FirmaAdi,Adres,Tel,VergiNo) values (@P1,@P2,@P3,@P4)";

            int s = 0;

            if (FirmaAdTxt.Text!= "" && AdresTxt.Text!=""&& TelTxt.Text!="" && VergiTxt.Text!="")
            {
                s = Class.SqlCalistir(sorgu, Prm1,Prm2,Prm3,Prm4);
            }

            if (s == 1)
            {
                Mesaj.Text = "Firma Bilgileri Tanımlanmıştır";
            }
        }

        protected void DuzenBtn_Click(object sender, EventArgs e)
        {
            string Id = HttpUtility.HtmlDecode(IdTxt.Text);
            string Ad = HttpUtility.HtmlDecode(FirmaAdTxt.Text);

            string Adres = HttpUtility.HtmlDecode(AdresTxt.Text);

            string Tel = HttpUtility.HtmlDecode(TelTxt.Text);

            string VergiNo = HttpUtility.HtmlDecode(VergiTxt.Text);
            SqlParameter Prm1 = new SqlParameter("@P1", Id);
            SqlParameter Prm2 = new SqlParameter("@P2", Ad);
            SqlParameter Prm3 = new SqlParameter("@P3", Adres);
            SqlParameter Prm4 = new SqlParameter("@P4", Tel);
            SqlParameter Prm5 = new SqlParameter("@P5", VergiNo);

            string sorgu = "UPDATE  FirmaTable set FirmaAdi=@P2,Adres=@P3,Tel=@P4,VergiNo=@P5 WHERE FirmaID=@P1";

            int s = 0;

            if (IdTxt.Text != "")
            {
                s = Class.SqlCalistir(sorgu, Prm1, Prm2,Prm3,Prm4,Prm5);
            }

            if (s == 1)
            {
                Mesaj.Text = "Bilgiler Güncellenmiştir";
            }
        }

        protected void SilBtn_Click(object sender, EventArgs e)
        {
            string Id = HttpUtility.HtmlDecode(IdTxt.Text);
            string Ad = HttpUtility.HtmlDecode(FirmaAdTxt.Text);
            string Adres = HttpUtility.HtmlDecode(AdresTxt.Text);
            string Tel = HttpUtility.HtmlDecode(TelTxt.Text);
            string VergiNo = HttpUtility.HtmlDecode(VergiTxt.Text);
            SqlParameter Prm1 = new SqlParameter("@P1", Id);
            SqlParameter Prm2 = new SqlParameter("@P2", Ad);
            SqlParameter Prm3 = new SqlParameter("@P3", Adres);
            SqlParameter Prm4 = new SqlParameter("@P4", Tel);
            SqlParameter Prm5 = new SqlParameter("@P5", VergiNo);
            string sorgu = "DELETE  FirmaTable WHERE FirmaID=@P1";

            int s = 0;

            if (IdTxt.Text != "")
            {
                s = Class.SqlCalistir(sorgu, Prm1, Prm2,Prm3,Prm4,Prm5);
            }

            if (s == 1)
            {
                Mesaj.Text = "Veriler Silinmiştir";
            }
        }

        protected void iptalBtn_Click(object sender, EventArgs e)
        {
            IdTxt.Text = "";
            FirmaAdTxt.Text = "";
            AdresTxt.Text = "";
            TelTxt.Text = "";
            VergiTxt.Text = "";
        }

        protected void StokBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stok.aspx");
        }

       

       

       
    }
}