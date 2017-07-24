<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CJDefault.aspx.cs" Inherits="CJCS_ASP_12.CJDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="IsTextBox" runat="server"></asp:TextBox>
&nbsp; Equal To<asp:TextBox ID="EqualTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
        <br />
        <asp:CheckBox ID="oldCheckBox" runat="server" Text="Are You Old?" />
        <br />
        <br />
        <asp:Button ID="Button" runat="server" OnClick="Button1_Click" Text="Ok" />
&nbsp;
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
