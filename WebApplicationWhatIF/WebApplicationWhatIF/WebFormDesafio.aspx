<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormDesafio.aspx.cs" Inherits="WebApplicationWhatIF.WebFormDesafio1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
        </head>
        <body>
            <div class="corpoNormal">
                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> DESAFIOS</h2>
                    <hr />
                </td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="2px" CellPadding="20" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Both" OnRowCommand="GridView1_RowCommand" Width="539px" Height="704px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="idDesafio" HeaderText="id" SortExpression="idDesafio" />
                        <asp:BoundField DataField="titulo" HeaderText="Título" SortExpression="titulo" />
                        <asp:BoundField DataField="questao" HeaderText="Questão" SortExpression="questao" />
                        <asp:ButtonField CommandName="Editar" Text="Editar" />
                        <asp:ButtonField CommandName="Addcorreta" Text="Adicionar alternativa correta" />
                        <asp:ButtonField CommandName="Addalterna" Text="Adicionar alternativas" />
                        <asp:ButtonField CommandName="Excluir" Text="Excluir" />
                    </Columns>
                    <FooterStyle BackColor="#EDFBF1" ForeColor="#000000" />
                    <HeaderStyle BackColor="#2ecc71" Font-Bold="True" ForeColor="#FFFFFF" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000000" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Desafio" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALDesafio" UpdateMethod="Update"></asp:ObjectDataSource>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormDesafioNew.aspx">Adicionar desafios</asp:HyperLink>
            <br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebFormAdministrador.aspx">Voltar</asp:HyperLink>
            </div>
        </body>
        </html>
    </div>
</asp:Content>
