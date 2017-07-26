<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAutenticar.aspx.cs" Inherits="WebApplicationWhatIF.WebFormAutenticar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Login
    <br /><br />Nome: <asp:TextBox ID="TextBoxLogin" runat="server" size="100" placeholder="Justus da Silva"></asp:TextBox>
	<br /><br />Senha: <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password" size="10"></asp:TextBox>
    <br /><br /><asp:Label ID="teste" runat="server"></asp:Label>
    <br /><asp:Button ID="ButtonEntrar" runat="server" Text="Entrar" OnClick="ButtonEntrar_Click" />
    <br /><br />  <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormCadastroAluno.aspx">Criar novo usuário</asp:HyperLink>
    </div>
    </form>
</body>
</html>
