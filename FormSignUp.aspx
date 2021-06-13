<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormSignUp.aspx.cs" Inherits="SignUp.FormSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>   
            <asp:HiddenField ID="hfIDUser" runat ="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label Text ="First Name :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbFirstName" runat ="server" />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text ="Last Name :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbLastName" runat ="server" />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text ="Nomor Telepon :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbNomor" runat ="server" />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text ="Email :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbEmail" runat ="server" />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text ="Alamat :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbAlamat" runat ="server" TextMode ="MultiLine" />
                    </td>
                </tr>
                <tr>
                    <td colspan ="3">
                        <hr />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text ="Username :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbUsername" runat ="server" />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text ="Password :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbPassword" runat ="server" TextMode =" Password" />
                        <asp:Label Text="*" runat ="server" Forecolor="BlueViolet" />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text ="Konfirmasi Password :" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="tbKonfirmasi" runat ="server" TextMode ="Password" />
                        <asp:Label Text="*" runat ="server" Forecolor="BlueViolet" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan ="3">
                       <asp:Button Text="Sign Up" ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan ="2">
                       <asp:Label Text="" ID="lblBerhasil" runat="server" ForeColor="DarkSeaGreen" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan ="2">
                        <asp:Label Text="" ID="lblGagal" runat="server" ForeColor ="OrangeRed" />
                    </td>
                </tr>
            </table>
              <p>
                    <asp:Button ID="btn_Login" runat="server" OnClick="btnLogin_click" Text="Sudah punya akun? Login" />
             </p>
        </div>
       
    </form>
</body>
</html>
