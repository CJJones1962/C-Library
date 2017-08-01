<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epic_Spies_Asset_Tracker_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 146px;
            height: 150px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <strong class="newStyle1"><span class="auto-style2">Asset Performance Tracker<br />
        </span></strong>
    <div>
    
        Asset Name:&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        Elections Rigged:&nbsp;
        <asp:TextBox ID="riggedTextBox" runat="server"></asp:TextBox>
&nbsp;
        <br />
        <br />
        Acts of Subterfuge Performed:&nbsp;
        <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
&nbsp;<br />
        <br />
        <asp:Label ID="totalLabel" runat="server"></asp:Label>
&nbsp;
        <br />
        <br />
        <asp:Label ID="avgLabel" runat="server"></asp:Label>
&nbsp;
        <br />
        <br />
        <asp:Label ID="lastLabel" runat="server"></asp:Label>
&nbsp;<br />
        <br />
    
    </div>
    </form>
</body>
</html>
