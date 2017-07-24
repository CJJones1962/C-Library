<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CJ_Conditional_Radio_Button_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1"><strong>Your Note Taking Prefrences</strong></span><br />
        <br />
        <asp:RadioButton ID="pencilRadioButton" runat="server" Text="Pencil" />
        <br />
        <br />
    
    </div>
        <asp:RadioButton ID="penRadioButton" runat="server" Text="Pen" />
        <br />
        <br />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Phone" />
        <br />
        <br />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
