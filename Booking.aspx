<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Details of Selected Vehicle"></asp:Label>
            <br />
        </div>
        <asp:DataList ID ="vdetail" runat="server">
            <ItemTemplate>
                 <img src="<%#Eval("image1") %>"" height="250" width="500" />
                <table> 
                    <tr>
                        <td >Make and Model</td>
                        <td><%#Eval("make") %> <%#Eval("model") %></td>
                    </tr>
                    <tr>                        
                        <td>Color</td>
                        <td><%#Eval("color") %><br /></td>
                    </tr>
                    <tr>
                        <td>Transmission Mode</td> 
                        <td><%#Eval("transmode") %> </td>
                    </tr>
                    <tr>
                        <td> Capacity</td>
                        <td><%#Eval("capacity") %></td>
                    </tr>
                    <tr>
                        <td>Price</td>
                        <td>$<%#Eval("price") %>/day</td>
                    </tr>
                    <tr>
                        <td>Type</td>
                        <td><%#Eval("type") %> </td>
                    </tr>
                     <tr>
                        <td>Mileage </td>
                         <td>Unlimted </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        

        <asp:Button ID="btn_Guest" runat="server" OnClick="btn_Guest_Click" Text="Continue as Guest" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Login" runat="server" OnClick="btn_Login_Click" Text="Login" Width="103px" />
&nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="lnk_Register" runat="server" NavigateUrl="~/Register.aspx">Create Account</asp:HyperLink>
    </form>
</body>
</html>
