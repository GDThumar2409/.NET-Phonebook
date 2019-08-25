<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="PhoneBookWeb.Input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">All</asp:ListItem>
                <asp:ListItem Value="1">Name</asp:ListItem>
                <asp:ListItem Value="2">Name &amp; City</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        </div>
    </form>
</body>
</html>
