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
    public partial class Urunler : System.Web.UI.Page
    {
        NewUsers Clas = new NewUsers();
        UrunFirma Class = new UrunFirma();
        protected void Page_Load(object sender, EventArgs e)
        {
            string getir = "SELECT * FROM UrunTable";
            UrunGrid.DataSource = Class.TabloGetir(getir);
            UrunGrid.DataBind();
        }

        protected void AnaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");
        }

        protected void FaturaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fatura.aspx");
        }

        protected void FirmaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirmaBilgileri.aspx");
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

        protected void UrunGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTxt.Text = HttpUtility.HtmlDecode(UrunGrid.SelectedRow.Cells[1].Text);

            UrunAdTxt.Text = HttpUtility.HtmlDecode(UrunGrid.SelectedRow.Cells[2].Text);
        }

        protected void KaydetBtn_Click(object sender, EventArgs e)
        {
            string Ad = HttpUtility.HtmlDecode(UrunAdTxt.Text);
            SqlParameter Prm1 = new SqlParameter("@P1", Ad);

            string sorgu = "INSERT INTO  UrunTable (UrunAdi) values (@P1)";

            int s = 0;

            if (UrunAdTxt.Text != "")
            {
                s = Class.SqlCalistir(sorgu, Prm1);
            }

            if (s == 1)
            {
                Mesaj.Text = "Ürün Tanımlanmıştır";
            }

        }
        protected void DuzenBtn_Click(object sender, EventArgs e)
        {
            string Id = HttpUtility.HtmlDecode(IdTxt.Text);
            string Ad = HttpUtility.HtmlDecode(UrunAdTxt.Text);
            SqlParameter Prm1 = new SqlParameter("@P1", Id);
            SqlParameter Prm2 = new SqlParameter("@P2", Ad);
            string sorgu = "UPDATE  UrunTable set UrunAdi=@P2 WHERE UrunID=@P1";

            int s = 0;

            if (IdTxt.Text != "")
            {
                s = Class.SqlCalistir(sorgu, Prm1,Prm2);
            }

            if (s == 1)
            {
                Mesaj.Text = "Bilgiler Güncellenmiştir";
            }
        }
        protected void iptalBtn_Click(object sender, EventArgs e)
        {
            IdTxt.Text = "";
            UrunAdTxt.Text = "";
            
        }

        protected void SilBtn_Click(object sender, EventArgs e)
        {
            string Id = HttpUtility.HtmlDecode(IdTxt.Text);
            string Ad = HttpUtility.HtmlDecode(UrunAdTxt.Text);
            SqlParameter Prm1 = new SqlParameter("@P1", Id);
            SqlParameter Prm2 = new SqlParameter("@P2", Ad);
            string sorgu = "DELETE  UrunTable WHERE UrunID=@P1";

            int s = 0;

            if (IdTxt.Text != "")
            {
                s = Class.SqlCalistir(sorgu, Prm1, Prm2);
            }

            if (s == 1)
            {
                Mesaj.Text = "Veriler Silinmiştir";
            }
        }

        protected void StokBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stok.aspx");
        }
    }
}