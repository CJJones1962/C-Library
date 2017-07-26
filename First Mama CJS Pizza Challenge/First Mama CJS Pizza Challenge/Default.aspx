<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="First_Mama_CJS_Pizza_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: x-large;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1"><strong style="font-family: Arial, Helvetica, sans-serif">Mama CJ&#39;s Pizza and Software</strong></span><br />
        <br />
        <asp:Image ID="resultImage" runat="server" />
&nbsp;
        <br />
        <br />
        <asp:RadioButton ID="babyRadioButton" runat="server" GroupName="Size" Text="Baby CJ Size (10&quot;) -$10" />
&nbsp;<br />
        <asp:RadioButton ID="mamaRadioButton" runat="server" GroupName="Size" Text="Mama CJ Size (13&quot;) -$13" />
        <br />
        <asp:RadioButton ID="papaRadioButton" runat="server" GroupName="Size" Text="Papa CJ Size (16&quot;)-$16" />
        <br />
        <br />
        <br />
        <asp:RadioButton ID="tRadioButton" runat="server" GroupName="Crust" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="dRadioButton" runat="server" GroupName="Crust" Text="Deep Crust (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="oCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="gpCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="rpCheckBox" runat="server" Text="Red Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="aCheckBox" runat="server" Text="Anchovies (+$2.00)" />
        <br />
        <br />
        <asp:Label ID="mamaLabel" runat="server" CssClass="auto-style2" Text="Mama CJ'S"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="SpLabel" runat="server" ForeColor="#CC0000" style="font-size: x-large; font-weight: 700" Text="Special Deal"></asp:Label>
        <br />
        <br />
        Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Red Peppers and Onions to your pizza.<br />
        <br />
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
&nbsp;
        <br />
        <br />
        Total: <asp:Label ID="resultLabel" runat="server"></asp:Label>
&nbsp;<br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only ... We need a better website!</div>
    </form>
</body>
</html>
