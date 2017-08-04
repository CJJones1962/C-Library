<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mega_Casino_Challenge_2._0.Default" %>

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
    
        <strong><span class="auto-style1">Mega Slot Machine</span></strong><br />
        <br />
        <asp:Image ID="randomImage1" runat="server" Height="150px" Width="150px" />
&nbsp;
        <asp:Image ID="randomImage2" runat="server" Height="150px" Width="150px" />
&nbsp;
        <asp:Image ID="randomImage3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Your Bet: <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="youbetLabel" runat="server"></asp:Label>
&nbsp;<br />
        <br />
        <asp:Label ID="playermoneyLabel" runat="server"></asp:Label>
&nbsp;<br />
        <br />
        1Cherry - x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        HOWEVER... If there&#39;s even one bar you win nothing!<br />
    
    </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
