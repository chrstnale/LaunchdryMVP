<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SignUp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLogin" runat="server" Font-Size="X-Large" Text="LOGIN"></asp:Label>
        <p>
            <asp:Label ID="lblUsername" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPassword" runat="server" Text="Password :" ></asp:Label>
        <asp:TextBox ID="tbPassword" runat="server" TextMode =" Password"></asp:TextBox>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" Text="Login Gagal! Silahkan Coba Lagi!" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btn_SignUp" runat="server" OnClick="btnSignUp_click" Text="Belum punya akun? Sign Up" />
        </p>
    </form>
</body>
</html>
