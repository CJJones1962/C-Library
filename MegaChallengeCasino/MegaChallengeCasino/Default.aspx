<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeCasino.Default" %>

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
    
        <span class="auto-style1">Mega Slot Machine</span><br />
        <br />
        <br />
        <asp:Image ID="randomImage1" runat="server" Height="150px" Width="150px" />
&nbsp;
        <asp:Image ID="randomImage2" runat="server" Height="150px" Width="150px" />
&nbsp;
        <asp:Image ID="randomImage3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Your Bet:&nbsp; <asp:TextBox ID="yourbetTextBox" runat="server"></asp:TextBox>
&nbsp;
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="youbetLabel" runat="server"></asp:Label>
&nbsp;<br />
        <br />
        <asp:Label ID="playersmoneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry - x2 Your Bet<br />
        2 Cherries- x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        <br />
        HOWEVER!...If there&#39;s even one bar you win nothing!<br />
    
    </div>
    </form>
</body>
</html>
