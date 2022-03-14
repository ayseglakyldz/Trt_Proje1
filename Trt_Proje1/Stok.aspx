<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stok.aspx.cs" Inherits="Trt_Proje1.Stok" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Stok.css" rel="stylesheet" />
</head>
<body>
        <form id="form1" runat="server">
            <!-- Begin Wrapper -->
            <div id="wrapper">
                <!-- Begin Header -->
                <div id="header">
                    <img id="banner" src="css/images.png" /></div>
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
                                <asp:Button ID="UrunBtn" runat="server" Text="Ürünler" Font-Bold="true" OnClick="UrunBtn_Click" />
                            </td>
                            <td>
                                <asp:Button ID="StokBtn" runat="server" Text="Stok" Font-Bold="True"/>
                            </td>
                            <td>
                                <asp:Button ID="KullaniciBtn" runat="server" Text="Kullanıcılar" Font-Bold="True" OnClick="KullaniciBtn_Click" />

                            </td>

                            <td>
                                <asp:Button ID="CikisBtn" runat="server" Text="Çıkış" Font-Bold="true" OnClick="CıkısBtn_Click"/>
                            </td>
                        </tr>

                    </table>
                </div>
                <!-- End Navigation -->
                <!-- Begin Left Column -->
                <div id="leftcolumn">
                </div>
                <!-- End Left Column -->
                <!-- Begin Right Column -->
                <div id="rightcolumn">
                    
                </div>
                <!-- End Right Column -->
                <!-- Begin Footer -->
                <div id="footer">This is the Footer </div>
                <!-- End Footer -->
            </div>
            <!-- End Wrapper -->
        </form>
</body>
</html>
