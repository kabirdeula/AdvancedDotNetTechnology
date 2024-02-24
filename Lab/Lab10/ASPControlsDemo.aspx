<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPControlsDemo.aspx.cs" Inherits="Lab10.ASPControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>ASP.NET Controls Demo</h2>
             <asp:TextBox ID="txtName" runat="server" placeholder="Enter your name"></asp:TextBox><br />
            
            
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
            
            <asp:DropDownList ID="ddlOptions" runat="server">
                <asp:ListItem Text="Option 1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Option 2" Value="2"></asp:ListItem>
            </asp:DropDownList><br />
            
            <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ColumnName" HeaderText="Column Header" />
                </Columns>
            </asp:GridView><br />
            <asp:RadioButtonList ID="rblOptions" runat="server">
                <asp:ListItem Text="Option 1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Option 2" Value="2"></asp:ListItem>
            </asp:RadioButtonList><br />
            
            <asp:CheckBox ID="chkOption" runat="server" Text="Option"></asp:CheckBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br />
        </div>
    </form>
</body>
</html>
