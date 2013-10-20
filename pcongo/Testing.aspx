<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Testing.aspx.cs" Inherits="pcongo.Testing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        sign up - username <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>Password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" />
        <br />
        <br />
        Login -  username <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>password <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Logout" OnClick="Button3_Click" />
    </div>
    </form>
</body>
</html>
