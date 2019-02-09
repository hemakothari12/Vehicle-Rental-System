<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vehicle.aspx.cs" Inherits="webapp1.Vehicle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 647px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 920px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Min Passenger Capacity"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Vehicle Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Text="All" Value="all"></asp:ListItem>
            <asp:ListItem Text="Car" Value="Car"></asp:ListItem>
            <asp:ListItem Text="Vans" Value="Vans"></asp:ListItem>
            <asp:ListItem Text="SUVs" Value="SUVs"></asp:ListItem>
            <asp:ListItem Text="Truck" Value="Truck"></asp:ListItem>
            <asp:ListItem Text="Minivan" Value="Minivan"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem Text="All" Value="1"></asp:ListItem>
            <asp:ListItem Text="$1-$10" Value="2"></asp:ListItem>
            <asp:ListItem Text="$11-$30" Value="3"></asp:ListItem>
            <asp:ListItem Text="$31-$50" Value="4"></asp:ListItem>
            <asp:ListItem Text="$51-$100" Value="5"></asp:ListItem>
            <asp:ListItem Text="$101-$200" Value="6"></asp:ListItem>
            <asp:ListItem Text="$200 and above" Value="7"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Transmission Mode"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem Text="All" Value ="All"></asp:ListItem>
            <asp:ListItem Text="Automatic" Value ="Automatic"></asp:ListItem>
            <asp:ListItem Text="Manual" Value="Manual"></asp:ListItem>
            <asp:ListItem Text="Semi-Automatic" Value="SemiAutomatic"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Filter"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="true" OnSelectedIndexChanged="filter_indexchanged">
            <asp:ListItem Text="Price:Low to High" Value="1"></asp:ListItem>
            <asp:ListItem Text="Price:High to Low" Value="2"></asp:ListItem>
        </asp:DropDownList>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:GridView ID ="gvvehicle" runat="server" AutoGenerateColumns="False" Height="50%" BorderColor="White">
            <Columns>
                <asp:ImageField DataImageUrlField="image1" ControlStyle-Height ="250" ControlStyle-Width ="500">
                    <ControlStyle Height="250px" Width="500px"></ControlStyle>
                </asp:ImageField>
                <asp:BoundField DataField="make" />
                <asp:BoundField DataField="model" />
                <asp:BoundField DataField="price" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkBook" Text="Book" runat="server" CommandArgument='<%# Eval("RegNo") %>' OnClick="lnkBook_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
