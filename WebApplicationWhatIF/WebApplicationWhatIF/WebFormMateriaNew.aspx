<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormMateriaNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormMateriaNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
            <style type="text/css">
                .auto-style1 {
                    width: 110px;
                }
                .auto-style2 {
                    width: 110px;
                    height: 23px;
                }
                .auto-style3 {
                    height: 23px;
                }
            </style>
        </head>
        <body>
            <div class="corpoNormal">
                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> LISTA DE MATERIAS </h2>
                    <hr />
                </td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="2px" CellPadding="20" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="Both" OnRowCommand="GridView1_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="idMateria" HeaderText="idMateria" SortExpression="idMateria" ReadOnly="True" />
                        <asp:BoundField DataField="titulo" HeaderText="Título" SortExpression="titulo" />
                        <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                        <asp:BoundField DataField="idModulo" HeaderText="idModulo" SortExpression="idModulo" ReadOnly="True" />
                        <asp:ButtonField CommandName="Editar" Text="Editar" />
                        <asp:ButtonField CommandName="Excluir" Text="Excluir" />
                        <asp:ButtonField CommandName="Gerenciarexercicios" Text="Gerenciar Exercícios" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Materia" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAllIdModulo" TypeName="WebApplicationWhatIF.DAL.DALMateria" UpdateMethod="Update">
                    <SelectParameters>
                        <asp:SessionParameter Name="idModulo" SessionField="idModulo" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Text="Título" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:TextBox ID="TextBox1" runat="server" MaxLength="60" Width="352px"></asp:TextBox>
                            <asp:Label ID="Label4" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" Text="Descrição" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Height="534px" MaxLength="7500" TextMode="MultiLine" Width="537px"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label5" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label3" runat="server" Text="Foto da matéria" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:Image ID="Image1" runat="server" />
                            <br />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Salvar" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Segoe UI Light" NavigateUrl="~/WebFormModulo.aspx">Voltar</asp:HyperLink>
            </div>
        </body>
        </html>
    </div>
</asp:Content>