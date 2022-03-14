<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Trt_Proje1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css/LoginStyle.css" rel="stylesheet" />
</head>
<body>
    <img src="css/arkaplan.jpg" />
    <form id="form1" runat="server" defaultbutton="Giris_Btn">
        <div id="Anacerceve">
            <img src="css/login-system.png" style="height: 171px; width: 167px" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Kad_Lbl" runat="server" Text="Kullanıcı Adı" ForeColor="White" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="KullanAd_TextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Sifre_Lbl" runat="server" Text="Şifre" ForeColor="White" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Sifre_TextBox" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td id="BtnYeniSatir">
                        <asp:Button ID="Yeni_Btn" runat="server" Text="Yeni Kullanıcı" Font-Bold="True" OnClick="Yeni_Btn_Click" />
                    </td>
                    <td id="BtnSatir">
                        <asp:Button ID="Giris_Btn" runat="server" Text="Oturum Aç" BorderColor="#009999" Font-Bold="True" OnClick="Giris_Btn_Click"/>
                    </td>
                </tr>
            </table>
         

        </div>
    </form>
</body>
</html>
