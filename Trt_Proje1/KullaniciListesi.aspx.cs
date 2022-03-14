using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trt_Proje1
{
    public partial class Kullanici : System.Web.UI.Page
    {
        NewUsers Clas = new NewUsers();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Kullanıcı"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            string getir = "SELECT ID as[No], Adi as[Adı], Soyadi as [Soyadı], KullaniciAdi as [Kullanıcı Adı], Sifre as [Şifre] from KullaniciTable";
            UserListesi.DataSource = Clas.TabloGetir(getir);
            UserListesi.DataBind();
        }

        protected void CıkısBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }

        protected void AraBtn_Click(object sender, EventArgs e)
        {
            string ara = "SELECT ID as[No], Adi as[Adı], Soyadi as [Soyadı], KullaniciAdi as [Kullanıcı Adı], Sifre as [Şifre] from KullaniciTable where Adi like '%" + AraTxt.Text + "%'";
            UserListesi.DataSource = Clas.TabloGetir(ara);
            UserListesi.DataBind();
        }

        protected void UserListesi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            UserListesi.PageIndex = e.NewPageIndex;
            string ara = "SELECT ID as[No], Adi as[Adı], Soyadi as [Soyadı], KullaniciAdi as [Kullanıcı Adı], Sifre as [Şifre] from KullaniciTable where Adi like '%" + AraTxt.Text + "%'";
            UserListesi.DataSource = Clas.TabloGetir(ara);
            UserListesi.DataBind();
        }

        protected void UserListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

            IDtxt.Text = HttpUtility.HtmlDecode(UserListesi.Rows[UserListesi.SelectedIndex].Cells[1].Text);

            Adtxt.Text = HttpUtility.HtmlDecode(UserListesi.SelectedRow.Cells[2].Text);

            SoyadTxt.Text = HttpUtility.HtmlDecode(UserListesi.SelectedRow.Cells[3].Text);

            KadTxt.Text = HttpUtility.HtmlDecode(UserListesi.SelectedRow.Cells[4].Text);

            SifreTxt.Text = HttpUtility.HtmlDecode(UserListesi.SelectedRow.Cells[5].Text);
        }

        protected void AnaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");
        }

        protected void SilBtn_Click(object sender, EventArgs e)
        {
            string Id = HttpUtility.HtmlDecode(IDtxt.Text);
            int s;
            if (IDtxt.Text != "")
            {
                s = Clas.Sil(Id);
                if (s == 1)
                {
                    Mesaj.Text = "Kullanıcı Silinmiştir";
                    IDtxt.Text = "";
                    Adtxt.Text = "";
                    SoyadTxt.Text = "";
                    KadTxt.Text = "";
                    SifreTxt.Text = "";
                    string getir = "SELECT * From KullaniciTable";
                    UserListesi.DataSource = Clas.TabloGetir(getir);
                    UserListesi.DataBind();

                }
            }
        }

        protected void DuzenBtn_Click(object sender, EventArgs e)
        {
            string Id = HttpUtility.HtmlDecode(IDtxt.Text);
            string Ad = HttpUtility.HtmlDecode(Adtxt.Text);
            string Sad = HttpUtility.HtmlDecode(SoyadTxt.Text);
            string kad = HttpUtility.HtmlDecode(KadTxt.Text);
            string sifre = HttpUtility.HtmlDecode(SifreTxt.Text);
            int s = 0;

            if (Adtxt.Text != "" && SoyadTxt.Text != "" && KadTxt.Text != "" && SifreTxt.Text != "")
            {
                s = Clas.UserGuncelle(Id, kad, sifre, Ad, Sad);
            }
            if (s == 1)
            {
                Mesaj.Text = "Kullanıcı Güncellenmiştir";
                string getir = "SELECT * From KullaniciTable";
                UserListesi.DataSource = Clas.TabloGetir(getir);
                UserListesi.DataBind();
                
            }
        }

        protected void iptalBtn_Click(object sender, EventArgs e)
        {
            IDtxt.Text = "";
            Adtxt.Text = "";
            SoyadTxt.Text = "";
            KadTxt.Text = "";
            SifreTxt.Text = "";
        }

        protected void FaturaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fatura.aspx");
        }

        protected void FirmaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirmaBilgileri.aspx");
        }

        protected void UrunBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Urunler.aspx");
        }

        protected void KaydetBtn_Click(object sender, EventArgs e)
        {
            string Ad = HttpUtility.HtmlDecode(Adtxt.Text);
            string Sad = HttpUtility.HtmlDecode(SoyadTxt.Text);
            string kad = HttpUtility.HtmlDecode(KadTxt.Text);
            string sifre = HttpUtility.HtmlDecode(SifreTxt.Text);
            int s = 0;

            if (!Clas.TanimliUser(kad))
            {
                if (IDtxt.Text == "" && Adtxt.Text != "" && SoyadTxt.Text != "" && KadTxt.Text != "" && SifreTxt.Text != "")
                {
                    s = Clas.UserEkle(kad, sifre, Ad, Sad); ;
                }
            }
            else
                Mesaj.Text = "Kullanıcı Adı Tanımlı";
            if (s == 1)
            {
                Mesaj.Text = "Kullanıcı Tanımlanmıştır";
                string getir = "SELECT * From KullaniciTable";
                UserListesi.DataSource = Clas.TabloGetir(getir);
                UserListesi.DataBind();
            }
        }

        protected void StokBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stok.aspx");
        }
    }
}