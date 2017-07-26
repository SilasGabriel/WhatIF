<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAutenticar.aspx.cs" Inherits="WebApplicationWhatIF.WebFormAutenticar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 32px;
        }
        .auto-style2 {
            width: 307px;
        }
        .auto-style3 {
            width: 307px;
            height: 44px;
        }
        .auto-style4 {
            width: 32px;
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />
        <table style="margin:auto; width:40%; border-width:2px;border-style:dashed;border-color:#008000">
            <tr>
           
                <td colspan="2" align="center">Login
                    <hr />
    </td>
               
            </tr>
            <tr>
                <td class="auto-style2">Nome</td>
                <td class="auto-style1"> <asp:TextBox ID="TextBoxLogin" runat="server" size="100" placeholder="Justus da Silva" MaxLength="100" Width="300px"></asp:TextBox>
	            </td>
              
            </tr>
            <tr>
                <td class="auto-style2">Senha</td>
                <td class="auto-style1"> <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password" Width="300px" MaxLenght="10" MinLength="6"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2"><asp:Label ID="teste" runat="server"></asp:Label>
                </td>
                <td class="auto-style1"><asp:Button ID="ButtonEntrar" runat="server" Text="Entrar" OnClick="ButtonEntrar_Click" Width="75px" />
                </td>
               
            </tr>
            <tr>
                
                <td class="auto-style4" colspan="2" align="center">  <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/WebFormCadastroAluno.aspx" Width="150px">Criar novo usuário</asp:HyperLink>
                </td>
               
            </tr>
        </table>
    <br /><br />  
    </div>
    </form>
</body>
</html>
