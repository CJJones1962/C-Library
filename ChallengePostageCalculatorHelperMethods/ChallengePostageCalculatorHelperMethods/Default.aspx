<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostageCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1">Postal Calculator</span><br />
        <br />
        Width:&nbsp;
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChanged"></asp:TextBox>
&nbsp;<br />
        Height:&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" Height="22px" OnTextChanged="handleChanged"></asp:TextBox>
&nbsp;
        <br />
        Length:&nbsp;
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChanged"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="PostalRadioButton" OnCheckedChanged="handleChanged" Text="Ground" />
&nbsp;<br />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="PostalRadioButton" OnCheckedChanged="handleChanged" Text="Air" />
&nbsp;<br />
        <br />
        <asp:RadioButton ID="nextdayRadioButton" runat="server" AutoPostBack="True" GroupName="PostalRadioButton" OnCheckedChanged="handleChanged" Text="Next Day" />
&nbsp;<br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
&nbsp;<br />
        <br />
    
    </div>
    </form>
</body>
</html>
