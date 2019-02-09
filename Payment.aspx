<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 48px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <br />
            <asp:Label ID="Label1" runat="server" Text="Details of Booking" ForeColor="Black" Font-Bold="true"></asp:Label>
            <br />
        </div>
        <table>
            <tr>
                <td class="auto-style1" >
        <asp:Label ID="lname" runat="server" Text="Name" Width="200"></asp:Label></td>
        <td><asp:Label ID="tname" runat="server" Enabled="false"></asp:Label>
                    </td>
                </tr>
            <tr>
         <td class="auto-style1">
        <asp:Label ID="lemail" runat="server" Text="Email" Width="200"></asp:Label>
        </td><td class="auto-style2"><asp:Label ID="temail" runat="server" Enabled="false"></asp:Label>
         </td>
                </tr>
            <tr>
                <td class="auto-style1">
        <asp:Label ID="lphone" runat="server" Text="Phone" Width="200"></asp:Label>
        </td><td><asp:Label ID="tphone" runat="server" Enabled="false"></asp:Label>
                    </td>
           </tr>
                </table>

                <asp:DataList ID ="vdetail" runat="server">
            <ItemTemplate>
                        <img src="<%#Eval("image1") %>"" height="250" width="500" />
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
                        <td> Capacity</td><td><%#Eval("capacity") %><br /></td>
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

         <asp:Label ID="lamount" runat="server" Text="Amount" ForeColor="Black"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="tamount" runat="server" Enabled="false" ForeColor="Black"></asp:Label>
        <br />

        <asp:Label ID="Label2" runat="server" Text="DateFrom" ForeColor="Black"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="tdatefrom" runat="server" Enabled="false" ForeColor="Black"></asp:Label>
         <br />
        <asp:Label ID="Label3" runat="server" Text="DateTo" ForeColor="Black"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="tdateto" runat="server" Enabled="false" ForeColor="Black"></asp:Label>

        <fieldset>
                <legend><span class="number" style="color:black"> Payment</span></legend>
                <table>
                    <tr>
                        <td>
                             <asp:Label ID="lcardname" runat="server" Text="Name on Card *"></asp:Label>
                   
                    &nbsp;
                   
                    <asp:TextBox ID="cardname" runat="server"></asp:TextBox>
                   <asp:Label ID="lcardno" runat="server" Text="Card Number *"></asp:Label>
                    <asp:TextBox ID="cardno" runat="server" TextMode="Number"></asp:TextBox>
                    <br />
                       </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>
                <asp:Label ID="ledate" runat="server" Text="Expiration Date *"></asp:Label>
                <asp:TextBox ID="edate" runat="server" TextMode="Number"></asp:TextBox>
                <asp:Label ID="lcvv" runat="server" Text="CVV *"></asp:Label>
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <asp:TextBox ID="cvv" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="cvv1" runat="server" Text="(Security Code)"></asp:Label>
                            </td>
                        </tr>
                    </table>
            </fieldset>
            <asp:Button ID="bconfirm" runat="server" Text="Confirm" OnClick="bconfirm_Click" />
    </form>
</body>

</html>