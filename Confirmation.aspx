<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Confirmation.aspx.cs" Inherits="Confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style  type="text/css">
        .auto-style1 {
            margin-left: 880px;
        }
    </style>
</head>
<body  style="background-image: url('/Images/confirm1.gif'); background-size: 100%">
    <form id="form1" runat="server" >
    <div class="auto-style1">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
         &nbsp;&nbsp;
         <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Logout.aspx">Logout</asp:HyperLink>
    </div>
    <div class="form-style-5">
        <asp:Label ID="Label1" runat="server" Text ="Booking ID : "></asp:Label>
        <asp:Label ID="TextBox1" runat="server" Enabled="false"></asp:Label>
    </div>
    </form>
    <div style="width: 927px; font-size: x-large; font-family: Georgia, 'Times New Roman', Times, serif; font-style: normal;">
        <marquee direction="left"><strong> Thanks for choosing Shokite Vehicle rentals. Enjoy your Ride!!!</strong><font="yellow"> </font></marquee>
    </div>
</body>
</html>
