<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="webapp1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('/Images/Untitled.JPG'); background-size: 100%;">
    <form id="form1" runat="server">
        <div style="margin-left: 600px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx" ForeColor="White">Home</asp:HyperLink>
        </div>

        <p style="margin-left: 40px">
            <asp:Label ID="Label3" runat="server" Text="Login" ForeColor="White"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="UserName" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="usernametxt" runat="server" ForeColor="Black" Height="16px" Rows="1" Width="168px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Password" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Password_txt" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <p style="margin-left: 40px">
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="New User/Register" />
        </p>
    </form>
</body>
</html>
