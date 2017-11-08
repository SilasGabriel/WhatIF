<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormListaDeAlunos.aspx.cs" Inherits="WebApplicationWhatIF.WebFormListaDeAlunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Todos os Usuários</h2>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand" Width="600px">
            <Columns>
                <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                <asp:CheckBoxField DataField="escolaPublica" HeaderText="Escola Pública" SortExpression="escolaPublica" />
                <asp:CheckBoxField DataField="administrador" HeaderText="Administrador" SortExpression="administrador" />
                <asp:ButtonField CommandName="Visualizar" Text="Visualizar Aluno" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALAluno"></asp:ObjectDataSource>
    
    </div>
        <h2>Usuários Administradores</h2>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Height="131px" Width="597px">
            <Columns>
                <asp:BoundField DataField="idAluno" HeaderText="idAluno" SortExpression="idAluno" />
                <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                <asp:BoundField DataField="senha" HeaderText="senha" SortExpression="senha" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:CheckBoxField DataField="escolaPublica" HeaderText="escolaPublica" SortExpression="escolaPublica" />
                <asp:CheckBoxField DataField="administrador" HeaderText="administrador" SortExpression="administrador" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAdm" TypeName="WebApplicationWhatIF.DAL.DALAluno"></asp:ObjectDataSource>
    </form>
</body>
</html>
