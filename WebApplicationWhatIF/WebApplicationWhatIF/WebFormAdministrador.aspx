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
        #header {
            background-color: #DDDDDD;
            width: 100%;
            height: 60px;
        }
        .auto-style4 {
            width: 670px;
        }
        .auto-style5 {
            width: 69px;
        }
        body {
            margin:0;
            padding:0;
            border:0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="header">
        <table style="width: 100%; height: 60px;">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td align="center" class="auto-style4">
                    <img class="auto-style6" src="Images/Logo.jpg" style="width:55px; height:55px;" /></td>
                <td>
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" style="margin-left: 0px" />
                </td>
            </tr>
        </table>
        <br />
        </div>
        
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style2" style="width:80%">
        <asp:HyperLink ID="CrudModulo" runat="server" NavigateUrl="~/WebFormModulo.aspx">CRUD módulo</asp:HyperLink>
                </td>
                <td class="auto-style1" align:"center" style="width:10%"><asp:HyperLink ID="Back" runat="server" NavigateUrl="~/WebFormIndex.aspx">Voltar</asp:HyperLink>
                </td>
                <td class="auto-style3" align:"center" style="width:10%">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
