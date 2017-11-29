<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormAlternativaDesafioNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormAlternativaDesafioNew" %>
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
                <asp:Table ID="Table1" runat="server"></asp:Table>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ForeColor="#333333"  Height="239px" Width="430px" OnRowCommand="GridView1_RowCommand" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="2px" CellPadding="20">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="idAlternativa" HeaderText="idAlternativa" SortExpression="idAlternativa" ReadOnly="True" />
                        <asp:BoundField DataField="texto" HeaderText="texto" SortExpression="texto" />
                        <asp:CheckBoxField DataField="correta" HeaderText="correta" SortExpression="correta" ReadOnly="True" />
                        <asp:BoundField DataField="idDesafio" HeaderText="idDesafio" SortExpression="idDesafio" ReadOnly="True" />
                        <asp:TemplateField ShowHeader="False">
                            <EditItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Atualizar"></asp:LinkButton>
                                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:ButtonField CommandName="Excluir" Text="Excluir" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALAlternativaDesafio" DataObjectTypeName="WebApplicationWhatIF.Modelo.alternativaDesafio" DeleteMethod="Delete" UpdateMethod="Update">
                    <SelectParameters>
                        <asp:SessionParameter Name="idDesafio" SessionField="idDesafio" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Height="91px" TextMode="MultiLine" Width="505px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Adicionar" />
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormDesafio.aspx">Voltar</asp:HyperLink>
            </div>
        </body>
        </html>
    </div>
</asp:Content>