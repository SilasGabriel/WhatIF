<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormModuloNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModuloNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Inserir Módulo"></asp:Label>
        <hr />
        Título<br />
        <asp:TextBox ID="TituloId" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TituloId" ErrorMessage="*Preencha o campo"></asp:RequiredFieldValidator>
        <br />
        Descrição<br />
        <asp:TextBox ID="DescricaoId" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DescricaoId" ErrorMessage="*Preencha o campo"></asp:RequiredFieldValidator>
        <br />
        Disciplina<br />
        <asp:TextBox ID="DisciplinaId" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DisciplinaId" ErrorMessage="*Preencha o campo"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Adicionar" />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormModulo.aspx">Voltar</asp:HyperLink>
        <br />
    
    </div>
    </form>
</body>
</html>
