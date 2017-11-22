<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormExercicioNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormExercicioNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="idExercicio" HeaderText="idExercicio" SortExpression="idExercicio" />
                <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                <asp:BoundField DataField="questao" HeaderText="questao" SortExpression="questao" />
                <asp:BoundField DataField="idMateria" HeaderText="idMateria" SortExpression="idMateria" />
                <asp:ButtonField CommandName="Editar" Text="Editar" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
                <asp:ButtonField CommandName="Addcorreta" Text="Adicionar alternativa correta" />
                <asp:ButtonField CommandName="Addalterna" Text="Adicionar alternativas" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Exercicio" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAllIdMateria" TypeName="WebApplicationWhatIF.DAL.DALExercicio" UpdateMethod="Update">
            <SelectParameters>
                <asp:QueryStringParameter Name="idMateria" QueryStringField="idMateria" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <h1>Inserir Exercício</h1>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Título"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Questão"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="200px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Imagem da questão"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Image ID="Image1" runat="server" />
                    <br />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Preview" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Salvar" />
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
        </table>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormMateriaNew.aspx">Voltar</asp:HyperLink>
    </div>
    </form>
</body>
</html>
