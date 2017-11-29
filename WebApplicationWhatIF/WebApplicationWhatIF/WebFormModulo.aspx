<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormModulo.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
            <style >
                #header {
                    background-color: #DDDDDD;
                    width: 100%;
                    height: 60px;
                }
                .auto-style1 {
                    width: 80%;
                }
                .auto-style2 {
                    width: 10%;
                }
                        body {
                    margin:0;
                    padding:0;
                    border:0;
                }
            </style>
        </head>
        <body>
            <div class="corpoNormal">
                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> LISTA DE MODULOS </h2>
                    <hr />
                </td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="2px" CellPadding="20" DataSourceID="ObjectDataSource1" PageSize="5"  OnRowCommand="GridView1_RowCommand" Width="500px" GridLines="Both">
                    <Columns>
                        <asp:BoundField DataField="idModulo" HeaderText="idModulo" SortExpression="idModulo" />
                        <asp:BoundField DataField="titulo" HeaderText="Título" SortExpression="titulo" />
                        <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                        <asp:BoundField DataField="disciplina.nome" HeaderText="Disciplina" SortExpression="idDisciplina" />
                        <asp:ButtonField CommandName="Editar" Text="Editar" />
                        <asp:ButtonField CommandName="Excluir" Text="Excluir" />
                        <asp:ButtonField CommandName="Gerenciarmaterias" Text="Gerenciar Matérias" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Modulo" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALModulo" UpdateMethod="Update"></asp:ObjectDataSource>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormModuloNew.aspx">Adicionar novo módulo</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebFormAdministrador.aspx">Voltar</asp:HyperLink>
            </div>
        </body>
        </html>
    </div>
</asp:Content>