<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPDemo.aspx.cs" Inherits="Lab11.ASPDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET Controls Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>ASP.NET Controls Demo</h2>
            
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
            
            <asp:TextBox ID="txtInput" runat="server" placeholder="Enter your name"></asp:TextBox><br />
            
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
      
        </div>
    </form>
</body>
</html>
