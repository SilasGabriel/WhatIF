<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAdministrador.aspx.cs" Inherits="WebApplicationWhatIF.WebFormAdministrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 264px;
            height: 30px;
        }
        .auto-style2 {
            width: 1799px;
            height: 30px;
        }
        .auto-style3 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2" style="width:80%">
        <asp:HyperLink ID="CrudModulo" runat="server" NavigateUrl="~/WebFormModulo.aspx">CRUD módulo</asp:HyperLink>
                </td>
                <td class="auto-style1" align:"center" style="width:10%"><asp:HyperLink ID="Back" runat="server" NavigateUrl="~/WebFormIndex.aspx">Voltar</asp:HyperLink>
                </td>
                <td class="auto-style3" align:"center" style="width:10%">
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
