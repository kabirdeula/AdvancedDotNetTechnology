<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionDemo.aspx.cs" Inherits="Lab07.SessionDemo" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>Session Demo</title>
        <style type="text/css">
            .wh-50 {
                width: 50%;
            }

            .wh-55 {
                width: 55%;
            }
        </style>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <p>Provide Following Details</p>
                <table class="wh-50">
                    <tr>
                        <td class="wh-55">Email</td>
                        <td>
                            <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="wh-55">Password</td>
                        <td>
                            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </form>
    </body>

    </html>