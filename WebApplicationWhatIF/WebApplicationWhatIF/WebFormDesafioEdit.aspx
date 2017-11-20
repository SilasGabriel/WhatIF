<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDesafioEdit.aspx.cs" Inherits="WebApplicationWhatIF.WebFormDesafioEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <script>
        function ConfirmaExclusao() {
            return confirm('Deseja realmente excluir este registro?');
        }
    </script>

<body>
    <form id="form1" runat="server">
    <div>
    <h1>Editar Desafio</h1>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="ObjectDataSource1" GridLines="Horizontal" Height="124px" Width="262px" OnItemCommand="DetailsView1_ItemCommand">
            <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "HandlerDesafio2.ashx?idDesafio=" + Eval("idDesafio") %>' Height="100px" Width="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="idDesafio" HeaderText="idDesafio" SortExpression="idDesafio" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                <asp:BoundField DataField="questao" HeaderText="questao" SortExpression="questao" />
                <asp:CommandField ShowEditButton="True" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            </Fields>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Desafio" InsertMethod="Insert" SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALDesafio" UpdateMethod="Update" DeleteMethod="DeleteTeste">
            <SelectParameters>
                <asp:SessionParameter Name="idDesafio" SessionField="idDesafio" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormDesafio.aspx">Voltar</asp:HyperLink>
    </div>
    </form>
</body>
</html>
