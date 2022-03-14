<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Trt_Proje1.Kullanıcı" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/NewUserStyle.css" rel="stylesheet" />
</head>
<body>
    <img src="css/arkaplan.jpg" />
    <form id="NewUser" runat="server">
        <div id="Anacerceve">
            <img id="logo" src="css/13698448141519590102add_user-12.png" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Adı" ForeColor="White" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Ad_TextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Soyadı" ForeColor="White" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Soyad_TextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Kad_Lbl" runat="server" Text="Kullanıcı Adı" ForeColor="White" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Kad_TextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Sifre_Lbl" runat="server" Text="Şifre" ForeColor="White" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Sifre_TextBox" runat="server" TextMode="Password" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Şifre Onay" ForeColor="White" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Onay_TextBox" runat="server" TextMode="Password" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Font-Italic="True" ForeColor="White"></asp:Label>
                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td id="BtnSatir">
                        <asp:Button ID="Kaydet_Btn" runat="server" Text="Kaydet" OnClick="Kaydet_Btn_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
