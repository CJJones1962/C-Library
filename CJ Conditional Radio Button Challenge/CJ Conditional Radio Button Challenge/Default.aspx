<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CJ_Conditional_Radio_Button_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your Note Taking Prefrences
        <br />
        <br />
        <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="CJNoteGroup" Text="Pencil" />
&nbsp;<br />
        <br />
        <asp:RadioButton ID="penRadioButton" runat="server" GroupName="CJNoteGroup" Text="Pen" />
&nbsp;<br />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="CJNoteGroup" Text="Phone" />
&nbsp;<br />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="CJNoteGroup" Text="Tablet" />
&nbsp;<br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
&nbsp;<br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" ImageUrl="c:cjschoolstuff/c-library/cjconditionalbuttonchallenge/cjconditionalbuttonchallenge" />
    
    </div>
    </form>
</body>
</html>
