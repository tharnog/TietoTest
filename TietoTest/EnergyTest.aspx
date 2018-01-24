<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnergyTest.aspx.cs" Inherits="TietoTest.EnergyTest" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="Scripts/StyleJs.js" type="text/javascript"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tieto Client contracts</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="mediumScreen">
        <label>Medium Screen</label>
        <div class="left">
            <h1>Heat Contract Name : <asp:Label runat="server" ID="lblHeatTop"></asp:Label></h1>           
            <p><label>Price: <asp:Label runat="server" ID="lblPriceTop"></asp:Label> EUR</label></p>           
            <p><label>Choose Temperature: <asp:TextBox runat="server" ID="numberBox1" Text="0" AutoPostBack="true"></asp:TextBox>°C </label></p>
        </div>
        <div class="right">
            <h1>Electricity Contract Name : <asp:Label runat="server" ID="lbl2"></asp:Label></h1>
            <p><label>Price: <asp:Label runat="server" ID="lblPrice1"></asp:Label> EUR</label></p>
            <p><label>Building Type: <asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="true" ViewStateMode="Enabled" EnableViewState="true" ></asp:DropDownList> </label></p>
        </div>

    </div>
    <div class="smallScreen">
        <label>Small Screen</label>
        <div class="top-left">
            <h3>Heat Contract Name : <asp:Label runat="server" ID="lblHeatBottom"></asp:Label></h3>
             <br />
            <label>Price: <asp:Label runat="server" ID="lblPriceBottom"></asp:Label> EUR</label>
            <br />
            <label>Choose Temperature: <asp:TextBox runat="server" ID="numberBox2" Text="0" AutoPostBack="true"></asp:TextBox>°C </label>
        </div>
        <div class="bottom-left">
             <h3>Electricity Contract Name : <asp:Label runat="server" ID="Label1"></asp:Label></h3>
            <br />
            <label>Price: <asp:Label runat="server" ID="Label2"></asp:Label> EUR</label>
            <br />
            <label>Building Type: <asp:DropDownList runat="server" ID="DropDownList2" AutoPostBack="true" ViewStateMode="Enabled" EnableViewState="true" ></asp:DropDownList> </label>
        </div>
    </div>
       </form> 
    
</body>
</html>
