<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormAlternativaDesafioNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormAlternativaDesafioNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Height="239px" Width="430px" OnRowCommand="GridView1_RowCommand">
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
    </asp:Content>