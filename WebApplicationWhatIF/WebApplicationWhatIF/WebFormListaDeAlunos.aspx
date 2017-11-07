<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormListaDeAlunos.aspx.cs" Inherits="WebApplicationWhatIF.WebFormListaDeAlunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
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
    </form>
</body>
</html>
