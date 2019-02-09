<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Review.aspx.cs" Inherits="Review" %>

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
                <legend><span class="number">1</span> Booking Confirmation<br />
                </legend>
                <asp:Label ID="lfname" runat="server" Text="Your Name *"></asp:Label>
                <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                <asp:Label ID="lemail" runat="server" Text="Your Email *"></asp:Label>
                <asp:TextBox ID="email" runat="server" TextMode="Email" ></asp:TextBox>
                <asp:Label ID="lphone" runat="server" Text="Your Phone *"></asp:Label>
                <asp:TextBox ID="phone" runat="server" TextMode="Number" ></asp:TextBox>
            </fieldset>
            <fieldset>
                <legend><span class="number">2</span> Payment</legend>
                <asp:Label ID="lcardname" runat="server" Text="Name on Card *"></asp:Label>
                <asp:TextBox ID="cardname" runat="server"></asp:TextBox>
                <asp:Label ID="lcardno" runat="server" Text="Card Number *"></asp:Label>
                <asp:TextBox ID="cardno" runat="server" TextMode="Number"></asp:TextBox>
                <asp:Label ID="ledate" runat="server" Text="Expiration Date *"></asp:Label>
                <asp:TextBox ID="edate" runat="server" TextMode="Number"></asp:TextBox>
                <asp:Label ID="lcvv" runat="server" Text="CVV *"></asp:Label>
                <asp:Label ID="cvv1" runat="server" Text="(Security code)"></asp:Label>
                <asp:TextBox ID="cvv" runat="server" TextMode="Password"></asp:TextBox>
                <br />
            </fieldset>
            <asp:Button ID="bconfirm" runat="server" Text="CONFIRM" OnClick="bconfirm_Click" ForeColor="Black" />
            </form>
    </div>
     
</body>
</html>

<style type="text/css">
.form-style-5{
    max-width: 500px;
    padding: 10px 20px;
    padding: 20px;
    margin: 10px auto;
    background: #fff;
    border-radius: 8px;
    font-family: Georgia, "Times New Roman", Times, serif;
}
.form-style-5 fieldset{
        border: none;
        color: #8a97a0;
        font-family: Georgia, "Times New Roman", Times, serif;
        font-size: 16px;
    }
.form-style-5 legend {
    font-size: 1.4em;
    margin-bottom: 10px;
}
.form-style-5 label {
    display: block;
    margin-bottom: 8px;
}
.form-style-5 input[type="text"],
.form-style-5 input[type="date"],
.form-style-5 input[type="datetime"],
.form-style-5 input[type="email"],
.form-style-5 input[type="number"],
.form-style-5 input[type="search"],
.form-style-5 input[type="time"],
.form-style-5 input[type="url"],
.form-style-5 textarea,
.form-style-5 select {
    font-family: Georgia, "Times New Roman", Times, serif;
    background: rgba(255,255,255,.1);
    border: none;
    border-radius: 4px;
    font-size: 16px;
    margin: 0;
    outline: 0;
    padding: 7px;
    width: 100%;
    box-sizing: border-box; 
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box; 
    background-color: #e8eeef;
    color:#8a97a0;
    -webkit-box-shadow: 0 1px 0 rgba(0,0,0,0.03) inset;
    box-shadow: 0 1px 0 rgba(0,0,0,0.03) inset;
    margin-bottom: 30px;
    
}
.form-style-5 input[type="text"]:focus,
.form-style-5 input[type="date"]:focus,
.form-style-5 input[type="datetime"]:focus,
.form-style-5 input[type="email"]:focus,
.form-style-5 input[type="number"]:focus,
.form-style-5 input[type="search"]:focus,
.form-style-5 input[type="time"]:focus,
.form-style-5 input[type="url"]:focus,
.form-style-5 textarea:focus,
.form-style-5 select:focus{
    background: #d2d9dd;
}
.form-style-5 select{
    height:35px;
}
    -webkit-appearance: menulist-button;
.form-style-5 .number {
    background: #1abc9c;
    color: #fff;
    height: 30px;
    width: 30px;
    display: inline-block;
    font-size: 0.8em;
    margin-right: 4px;
    line-height: 30px;
    text-align: center;
    text-shadow: 0 1px 0 rgba(255,255,255,0.2);
    border-radius: 15px 15px 15px 0px;
}

.form-style-5 input[type="submit"],
.form-style-5 input[type="button"]
{
        position: relative;
        display: block;
        padding: 19px 39px 18px 39px;
        color: #008000;
        margin: 0 auto;
        font-size: large;
        text-align: center;
        font-style: normal;
        width: 100%;
        border: 1px solid #16a085;
        border-width: 1px 1px 3px;
        margin-bottom: 10px;
        font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        font-weight: bold;
        line-height: normal;
    }
</style>