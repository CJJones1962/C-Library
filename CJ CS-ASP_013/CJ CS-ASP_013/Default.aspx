<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CJ_CS_ASP_013.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="isTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="comparisonTypeLabel" runat="server"></asp:Label>
&nbsp;<asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp; ?<br />
        <br />
        <asp:CheckBox ID="ICheckBox" runat="server" Text="I am checked" />
&nbsp;
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
&nbsp;
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
&nbsp;
        <br />
    
    </div>
    </form>
</body>
</html>
