<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewBooking.aspx.cs" Inherits="ViewBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="margin-left: 880px">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
    </div>
    <div class="form-style-5">
        <form id="form1" runat="server">
            <fieldset>
                <legend><span class="number" style="color:black"> View Booking </span><br />
                </legend>
                <asp:Label ID="lbook" runat="server" Text="Enter Booking ID: " ForeColor="Black"></asp:Label>
                <asp:TextBox ID="tbook" runat="server"></asp:TextBox>
                <br />
                </fieldset>
            <asp:Button ID="viewbook" runat="server" Text="View Booking" OnClick="viewbook_Click" />

            <br />
            <br />

        <div>
            <asp:Label ID="Label1" runat="server" Text="Details of Booking" BackColor="YellowGreen"></asp:Label>
            <br />
        </div>
            
             <asp:DataList ID ="bdetails" runat="server">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>Name</td><td><%#Eval("name") %></td>
                    </tr>
                    <tr>
                        <td>Email</td><td> <%#Eval("email") %> </td>
                    </tr>
                    <tr>
                        <td>Phone</td><td> <%#Eval("phone") %> </td>
                    </tr>
                    <tr>
                        <td>Date From</td><td><%#Eval("DateFrom") %></td>
                    </tr>
                    <tr>                        
                        <td>Date To</td><td> <%#Eval("DateTo") %><br /></td>
                    </tr>
                    <tr>
                        <td>Location From</td><td> <%#Eval("LocationFrom") %> </td>
                    </tr>
                    <tr>
                        <td> Location To</td><td> <%#Eval("LocationTo") %><br /></td>
                    </tr>  
                    <tr>
                        <td> Total Amount</td><td>$<%#Eval("Amount") %><br /></td>
                    </tr>  
                </table>
            </ItemTemplate>
        </asp:DataList>



        <asp:DataList ID ="vdetail" runat="server">
            <ItemTemplate>
                <img src="<%#Eval("image1") %>"" height="300" width="500" />
                 <table>       
                    <tr>
                        <td>Make and Model</td><td> <%#Eval("make") %> <%#Eval("model") %></td>
                    </tr>
                    <tr>                        
                        <td>Color</td><td> <%#Eval("color") %><br /></td>
                    </tr>
                    <tr>
                        <td>Transmission Mode</td><td> <%#Eval("transmode") %> </td>
                    </tr>
                    <tr>
                        <td> Capacity</td><td> <%#Eval("capacity") %><br /></td>
                    </tr>
                    <tr>
                        <td>Price</td><td> $<%#Eval("price") %>/day</td>
                    </tr>
                    <tr>
                        <td>Type</td><td> <%#Eval("type") %> </td>
                    </tr>
                    <tr>
                        <td>Mileage</td><td> Unlimted </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>           
        </form>
    </div>
</body>
</html>
