<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="Trt_Proje1.Urunler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Urunler.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
<!-- Begin Wrapper -->
<div id="wrapper">
  <!-- Begin Header -->
  <div id="header">
         <img id="banner" src="css/images.png" />
  </div>
  <!-- End Header -->
  <!-- Begin Navigation -->
  <div id="navigation"> 
    <table>
                    <tr>
                        <td>
                            <asp:Button ID="AnaBtn" runat="server" Text="Anasayfa" Font-Bold="True" OnClick="AnaBtn_Click" />
                        </td>
                           <td>
                            <asp:Button ID="FaturaBtn" runat="server" Text="Fatura" Font-Bold="True" OnClick="FaturaBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="FirmaBtn" runat="server" Text="Firma Bilgisi" Font-Bold="True" OnClick="FirmaBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="UrunBtn" runat="server" Text="Ürünler" Font-Bold="true" />
                        </td>
                         <td>
                            <asp:Button ID="StokBtn" runat="server" Text="Stok" Font-Bold="True" OnClick="StokBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="KullaniciBtn" runat="server" Text="Kullanıcılar" Font-Bold="True" OnClick="KullaniciBtn_Click" />

                        </td>
                     
                        <td>
                            <asp:Button ID="CikisBtn" runat="server" Text="Çıkış" Font-Bold="true" OnClick="CıkısBtn_Click" />
                        </td>
                    </tr>

                </table>
      </div>
  <!-- End Navigation -->
  <!-- Begin Left Column -->
  <div id="leftcolumn"> 
      <asp:GridView ID="UrunGrid" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="UrunGrid_SelectedIndexChanged" PageSize="3">
          <AlternatingRowStyle BackColor="White" />
          <EditRowStyle BackColor="#7C6F57" />
          <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
          <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
          <RowStyle BackColor="#E3EAEB" />
          <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
          <SortedAscendingCellStyle BackColor="#F8FAFA" />
          <SortedAscendingHeaderStyle BackColor="#246B61" />
          <SortedDescendingCellStyle BackColor="#D4DFE1" />
          <SortedDescendingHeaderStyle BackColor="#15524A" />
      </asp:GridView>
  </div>
  <!-- End Left Column -->
  <!-- Begin Right Column -->
  <div id="rightcolumn"> 
      <table>
          <tr>
              <td>
                  <asp:Label ID="ID" runat="server" Text="Urun ID"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="IdTxt" runat="server"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label2" runat="server" Text="Ürün Adı"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="UrunAdTxt" runat="server"></asp:TextBox>
              </td>
          </tr>
      </table>
     <table>
                    <tr>
                        <td>
                            <asp:Label ID="Mesaj" runat="server" Font-Size="12pt"></asp:Label>
                        </td>
                        </tr>
         </table>
                  
                 <table id="BtnTable">
                   
                    <tr>
                        <td>
                            <asp:Button ID="KaydetBtn" runat="server" Text="Kaydet" Font-Bold="True" OnClick="KaydetBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="DuzenBtn" runat="server" Text="Düzenle" Font-Bold="True" OnClick="DuzenBtn_Click"  />
                        </td>
                        <td>
                            <asp:Button ID="SilBtn" runat="server" Text="Sil" Font-Bold="True" OnClick="SilBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="iptalBtn" runat="server" Text="İptal" Font-Bold="True" OnClick="iptalBtn_Click" />
                        </td>
                    </tr>
                </table>
  </div>
  <!-- End Right Column -->
  <!-- Begin Footer -->
  <div id="footer"> This is the Footer </div>
  <!-- End Footer -->
 </div>
<!-- End Wrapper -->
        </form>
</body>

</html>
