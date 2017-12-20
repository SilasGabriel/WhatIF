<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormProgressoDisciplina.aspx.cs" Inherits="WebApplicationWhatIF.WebFormProgressoDisciplina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Acompanhar progresso da Disciplina-
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
    </div>
    </form>
</body>
</html>
