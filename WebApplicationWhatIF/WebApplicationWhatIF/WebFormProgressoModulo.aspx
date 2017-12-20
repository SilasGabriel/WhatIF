<%@ Page Language="C#"  MasterPageFile="~/MasterPageAluno.Master" AutoEventWireup="true" CodeBehind="WebFormProgressoModulo.aspx.cs" Inherits="WebApplicationWhatIF.WebFormProgressoModulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <div style="margin-top:5%;">
    <h1>Acompanhar progresso do Módulo-
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        
        </h1>
        <p>
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Quantidade de questões certas:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Quantidade de questões erradas:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormProgresso.aspx">Voltar</asp:HyperLink>
        </p>
    </div>
</body>
</html>
    </asp:Content>