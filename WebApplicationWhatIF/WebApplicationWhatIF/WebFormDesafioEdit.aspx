<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormDesafioEdit.aspx.cs" Inherits="WebApplicationWhatIF.WebFormDesafioEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
        </head>
            <script>
                function ConfirmaExclusao() {
                    return confirm('Deseja realmente excluir este registro?');
                }
            </script>

        <body>
            <div class="corpoNormal">
                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> EDITAR DESAFIO </h2>
                    <hr />
                </td>
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="3px" CellPadding="20" DataSourceID="ObjectDataSource1" GridLines="Both" Height="150px" Width="700px" OnItemCommand="DetailsView1_ItemCommand">
                    <EditRowStyle BackColor="White" ForeColor="#000000" BorderColor="#2ecc71" BorderStyle="Solid" BorderWidth="3px"/>
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
                    <FooterStyle BackColor="#EDFBF1" ForeColor="#000000" />
                    <HeaderStyle BackColor="#2ecc71" Font-Bold="True" ForeColor="#FFFFFF" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000000" />
                </asp:DetailsView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Desafio" InsertMethod="Insert" SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALDesafio" UpdateMethod="Update" DeleteMethod="DeleteTeste">
                    <SelectParameters>
                        <asp:SessionParameter Name="idDesafio" SessionField="idDesafio" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormDesafio.aspx">Voltar</asp:HyperLink>
            </div>
        </body>
        </html>
    </div>
</asp:Content>