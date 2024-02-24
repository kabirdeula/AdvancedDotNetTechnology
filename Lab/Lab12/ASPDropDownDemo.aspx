<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPDropDownDemo.aspx.cs" Inherits="Lab12.ASPDropDownDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET List Controls Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>ASP.NET List Controls Demo</h2>
            
            <asp:DropDownList ID="ddlOptions" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOptions_SelectedIndexChanged">
                <asp:ListItem Text="Option 1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Option 2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Option 3" Value="3"></asp:ListItem>
            </asp:DropDownList><br />
            
            <asp:ListBox ID="lbSelections" runat="server" SelectionMode="Multiple" Rows="4"></asp:ListBox><br />
            
            <asp:Button ID="btnAdd" runat="server" Text="Add to List" OnClick="btnAdd_Click" />
       
        </div>
    </form>
</body>
</html>
