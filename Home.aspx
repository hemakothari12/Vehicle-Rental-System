<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="webapp1.Home" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       #form1 {
               
                /*height: 1334px;
                width: 1213px;*/
                top: 4px;
                left: 5px;
                position: absolute;
                margin-top: 0px;
            }
            .auto-style1 {
                margin-left: 1120px;
            }
            .auto-style2 h1{
            font: caption;
            font-family: Georgia, "Times New Roman", Times, serif;
            font-size: xx-large;
            color: #EE4E00;
            font-style: italic;
            text-align: center;
            font-weight: bold;
            text-transform: uppercase;
        }
            .auto-style2 img {
                float: left;
                width: 100px;
                height: 100px;
                

            }
            </style>
</head>
<body style="background-image: url('/Images/Home.JPG'); background-size:100%;">
    <form id="form1" runat="server">
        <div class="auto-style1">
             <table>
                 <tr>
                 <td>
                        <asp:HyperLink ID="login" runat="server" NavigateUrl="~/Admin.aspx" ForeColor="White">Login</asp:HyperLink>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx" ForeColor="White">Register</asp:HyperLink>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>
                         <asp:HyperLink ID="viewbook" runat="server" NavigateUrl="~/ViewBooking.aspx" ForeColor="White">View_Booking</asp:HyperLink>
                        
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div class ="auto-style2">
           <img src="Images/logo.jpg" alt="logo"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <h1>Shokite Vehicle Rental</h1>
</div>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="Rent a Vehicle" ForeColor="White"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Date From" ForeColor="White"></asp:Label>
            <asp:TextBox ID="date1" runat="server"></asp:TextBox>
            <asp:Button ID="bcal1" runat="server" OnClick="bcal1_Click" Text=".." />
            <asp:Calendar ID="Calendar1" runat="server" Visible="false" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="196px" NextPrevFormat="ShortMonth" Width="230px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#CCCCCC" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
            </asp:Calendar>
            <asp:Label ID="Label7" runat="server" Text="Date To" ForeColor="White"></asp:Label>
            <asp:TextBox ID="date2" runat="server"></asp:TextBox>
            <asp:Button ID="bcal2" runat="server" OnClick="bcal2_Click" Text=".." />
            <asp:Calendar ID="Calendar2" runat="server" Visible="false" OnDayRender="Calendar2_DayRender" OnSelectionChanged="Calendar2_SelectionChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="198px" NextPrevFormat="ShortMonth" Width="229px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#CCCCCC" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
            </asp:Calendar>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Location" ForeColor="White"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="VoiceButton" runat="server" OnClick="VoiceButton_Click" Text="Speak" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<br />
            <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click" />
            <br />
    </form>
</body>
</html>
