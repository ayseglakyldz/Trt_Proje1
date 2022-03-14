<%@ Page Language="C#" CodePage="28599" AutoEventWireup="true" CodeBehind="KullaniciListesi.aspx.cs" Inherits="Trt_Proje1.Kullanici" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title></title>
    <link href="css/Kullanici.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
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
                            <asp:Button ID="UrunBtn" runat="server" Text="Ürünler" Font-Bold="true" OnClick="UrunBtn_Click" />
                        </td>
                         <td>
                            <asp:Button ID="StokBtn" runat="server" Text="Stok" Font-Bold="True" OnClick="StokBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="KullaniciBtn" runat="server" Text="Kullanıcılar" Font-Bold="True" />

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
                <asp:Panel ID="Panel1" runat="server" BorderStyle="Inset">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı" ForeColor="Black" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="AraTxt" runat="server" Font-Size="14pt" Width="140px" Height="25px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="AraBtn" runat="server" Text="Ara" Height="25px" OnClick="AraBtn_Click" Width="50px" Font-Bold="True" />
                            </td>
                        </tr>

                    </table>
                </asp:Panel>
                <table>

                    <tr>
                        <td>
                            <div id="Datadiv" style="overflow: auto; border: double; width: 300px; height: 300px;">
                                <asp:GridView ID="UserListesi" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AutoGenerateSelectButton="True" OnPageIndexChanging="UserListesi_PageIndexChanging" PageSize="3" Style="width: 150px; overflow: scroll" OnSelectedIndexChanged="UserListesi_SelectedIndexChanged">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCC99" />
                                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                    <PagerSettings Mode="NumericFirstLast" PageButtonCount="3" />
                                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                    <RowStyle BackColor="#F7F7DE" />
                                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                    <SortedAscendingHeaderStyle BackColor="#848384" />
                                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                    <SortedDescendingHeaderStyle BackColor="#575357" />
                                </asp:GridView>
                            </div>

                        </td>
                    </tr>
                </table>
            </div>
            <!-- End Left Column -->
            <!-- Begin Right Column -->
            <div id="rightcolumn">
                <asp:Panel ID="PanelKul" runat="server" BorderColor="#0000CC" BorderStyle="Groove" BorderWidth="5px">
                    <asp:Label ID="Label7" runat="server" Text="KULLANICI BİLGİLERİ" Font-Bold="True" ForeColor="#333333"></asp:Label>
                    <table id="Kbilgi">
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="IDtxt" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Adı"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Adtxt" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Soyadı"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="SoyadTxt" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Kullanıcı Adı"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="KadTxt" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Şifre"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="SifreTxt" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>


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
                            <asp:Button ID="DuzenBtn" runat="server" Text="Düzenle" Font-Bold="True" OnClick="DuzenBtn_Click" />
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
            <div id="footer">
                2018 TRT BİLGİ TEKNOLOJİLERİ DAİRESİ BAŞKANLIĞI 
            </div>
            <!-- End Footer -->
        </div>
        <!-- End Wrapper -->
    </form>
</body>
</html>
