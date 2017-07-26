<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormModuloNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModuloNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #header {
            background-color: #DDDDDD;
            width: 100%;
            height: 60px;
        }
        .auto-style1 {
            width: 651px;
        }
        .auto-style2 {
            width: 70px;
        }
        .auto-style3 {
            width: 206px;
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
                <td class="auto-style2">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormModulo.aspx">Voltar</asp:HyperLink>
                </td>
                <td align="center" class="auto-style1">
                    <img class="auto-style6" src="Images/Logo.jpg" style="width:55px; height:55px;" /></td>
                <td>
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" style="margin-left: 0px" />
                </td>
            </tr>
        </table>
        <br />
        </div>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Inserir Módulo"></asp:Label>
        <hr />
        <table style="width:100%;border-width:2px;border-style:dashed;border-color:#008000";>
            <tr>
                <td>Título</td>
                <td class="auto-style3">
        <asp:TextBox ID="TituloId" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TituloId" ErrorMessage="*Preencha o campo"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Descrição</td>
                <td class="auto-style3">
        <asp:TextBox ID="DescricaoId" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DescricaoId" ErrorMessage="*Preencha o campo"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>DisciplinaID</td>
                <td class="auto-style3">
        <asp:TextBox ID="DisciplinaId" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DisciplinaId" ErrorMessage="*Preencha o campo"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Adicionar" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
