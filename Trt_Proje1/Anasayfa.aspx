<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="Trt_Proje1.Anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Anasayfa.css" rel="stylesheet" />
 
</head>
<body>
    <form id="formana" runat="server">
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
                            <asp:Button ID="AnaBtn" runat="server" Text="Anasayfa" Font-Bold="True" />
                        </td>
                           <td>
                            <asp:Button ID="FaturaBtn" runat="server" Text="Fatura" Font-Bold="True" OnClick="FaturaBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="FirmaBilBtn" runat="server" Text="Firma Bilgisi" Font-Bold="True" OnClick="FirmaBilBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="UrunBtn" runat="server" Text="Ürünler" Font-Bold="true" OnClick="UrunBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="StokBtn" runat="server" Text="Stok" Font-Bold="True" OnClick="StokBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="KullaniciBtn" runat="server" Text="Kullanıcılar" Font-Bold="True" OnClick="KullaniciBtn_Click"/>

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
                <img id="logo" src="css/trt%20logo.png" />
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="BİLGİ TEKNOLOJİLERİ DAİRESİ BAŞKANLIĞI" Font-Bold="True" Font-Size="Medium"></asp:Label>

                        </td>
                    </tr>
                </table>
            </div>
            <!-- End Left Column -->
            <!-- Begin Right Column -->
            <div id="rightcolumn">
                Kullanıcı giriş otomasyon programı TRT Bilgi Teknolojileri Dairesi Başkanlığı Yayın ve Üretim Müdürlüğü 
                Müdür Sayın İlhan NALBANT kontrol ve desteğinde 2018 Bahar Dönemi üniversite stajyeri Ayşegül Akyıldız yapmıştır.
                <br />
                İlhan NALBANT a Teşekkürler...</div>
            <!-- End Right Column -->
            <!-- Begin Footer -->
            <div id="footer">  2018 TRT BİLGİ TEKNOLOJİLERİ DAİRESİ BAŞKANLIĞI </div>
            <!-- End Footer -->
        </div>
        <!-- End Wrapper -->
    </form>
</body>
</html>
