<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CJDefault.aspx.cs" Inherits="CS_ASP_009.CJDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        <br />
        <br />
    
    </div>
        <asp:Button runat="server" OnClick="Button1_Click" Text="Go" />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
