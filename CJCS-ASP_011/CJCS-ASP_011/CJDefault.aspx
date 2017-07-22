<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CJDefault.aspx.cs" Inherits="CJCS_ASP_011.CJDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is:&nbsp;
        <asp:TextBox ID="IsTextBox" runat="server"></asp:TextBox>
&nbsp; equal to:
        <asp:TextBox ID="EqualTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="CoolCheckBox" runat="server" Checked="True" Font-Names="Arial Black" OnCheckedChanged="CoolCheckBox_CheckedChanged" Text="Are you cool?" />
        <br />
        <br />
        <asp:Button ID="Button" runat="server" OnClick="Button_Click" Text="Okay" />
        <br />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
