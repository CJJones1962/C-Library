<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Days_Between_Dates_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How many days have elasped?<br />
        <br />
        Chose one date:<br />
        <br />
        <asp:Calendar ID="myCalendar1" runat="server"></asp:Calendar>
        <br />
        <br />
        Chose a second date:<br />
        <br />
        <asp:Calendar ID="myCalendar2" runat="server"></asp:Calendar>
&nbsp;<br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
&nbsp;
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
&nbsp;<br />
        <br />
    
    </div>
    </form>
</body>
</html>
