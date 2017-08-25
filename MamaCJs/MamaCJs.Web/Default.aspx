<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MamaCJs.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class ="container ">
        <div class =" page-header">
        <h1>Mama CJ's Pizza</h1>
        <p class =" lead">Pizza to Code By</p>
    </div>
        <div class =" form-group">
            <label>Size: </label>

        <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass =" form-control" AutoPostBack ="true"></asp:DropDownList>
      </div>

      <div class =" form-group">
            <label>Crust: </label>
        <asp:DropDownList ID="crustDropDownList" runat="server" CssClass =" form-control" AutoPostBack ="true"></asp:DropDownList>
      </div>

        <div class ="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack ="true"/> Sausage</label></div>
        <div class ="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack ="true"/> Pepperoni</label></div>
        <div class ="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack ="true"/> Onions</label></div>
        <div class ="checkbox"><label><asp:CheckBox ID="greenpeppersCheckBox" runat="server" AutoPostBack ="true"/> Green Peppers</label></div>
    


        <h3>Deliver To: </h3>

        <div class =" form-group">
            <label> Name: </label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass ="form-control"></asp:TextBox>
        </div>


        <div class =" form-group">
            <label> Address:</label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass ="form-control"></asp:TextBox>
        </div>

        <div class =" form-group">
            <label> Zip:</label>
            <asp:TextBox ID="zipTextBox" runat="server" CssClass ="form-control"></asp:TextBox>
        </div>

        <div class =" form-group">
            <label> Phone:</label>
             <asp:TextBox ID="phoneTextBox" runat="server" CssClass ="form-control"></asp:TextBox>
        </div>
               
       

        <h3>Payment: </h3>

        
        <div class ="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName=" PaymentGroup"/> Cash:</label></div>
        <div class ="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName ="PaymentGroup"/> Credit: </label></div>

        <asp:Button ID="orderButton" runat="server" Text="Order" CssClass =" btn btn-lg btn-primary"/>

        <h3>Total Cost: <asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>

        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>

    </div>
    </form>
    <script src="scripts/jquery-1.9.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</body>
</html>
