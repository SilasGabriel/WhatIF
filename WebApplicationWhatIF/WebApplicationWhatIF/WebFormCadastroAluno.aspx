<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastroAluno.aspx.cs" Inherits="WebApplicationWhatIF.WebFormCadastroAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Cadastro
					<br />Nome: <asp:TextBox ID="TextBoxNome" runat="server" size="20" MaxLength="100" placeholder="Justus da Silva"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxNome" ErrorMessage="Nome é obrigatório."></asp:RequiredFieldValidator>
					<br /><br />Senha: <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password" size="10" MaxLength="10"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxSenha" ErrorMessage="Senha é obrigatória."></asp:RequiredFieldValidator>
					<br />
                <br />
                Confirmar Senha:
                <asp:TextBox ID="TextBoxConfirmarSenha" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxSenha" ControlToValidate="TextBoxConfirmarSenha" ErrorMessage="Senhas diferentes"></asp:CompareValidator>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxConfirmarSenha" ErrorMessage="Confirmar a senha é obrigatório."></asp:RequiredFieldValidator>
					<br /><br /> Email: <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" MaxLength="100"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email é obrigatório"></asp:RequiredFieldValidator>
                    <br /><br />Escola:
                <asp:DropDownList ID="DropDownListEscola" runat="server">
                    <asp:ListItem Value="1">Pública</asp:ListItem>
                    <asp:ListItem Value="0">Privado</asp:ListItem>
                </asp:DropDownList>
                    <br /><br /><asp:Button ID="ButtonEnviar" runat="server" Text="Enviar" OnClick="ButtonEnviar_Click" />
    </div>
    </form>
</body>
</html>
