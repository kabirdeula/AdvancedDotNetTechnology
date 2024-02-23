<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesDemo.aspx.cs" Inherits="Lab06.CookiesDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookies Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select your Favorite Anime"></asp:Label>
            <br /><br />
            <asp:CheckBox ID="naruto" runat="server" Text="Naruto" />
            <br />
            <asp:CheckBox ID="one_piece" runat="server" Text="One Piece" />
            <br />
            <asp:CheckBox ID="bleach" runat="server" Text="Bleach" />
            <br />
            <asp:CheckBox ID="dragonball" runat="server" Text="Dragonball" />
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
