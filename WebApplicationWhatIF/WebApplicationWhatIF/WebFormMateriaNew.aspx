<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMateriaNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormMateriaNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="idMateria" HeaderText="idMateria" SortExpression="idMateria" ReadOnly="True" />
                <asp:BoundField DataField="titulo" HeaderText="Título" SortExpression="titulo" />
                <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                <asp:BoundField DataField="idModulo" HeaderText="idModulo" SortExpression="idModulo" ReadOnly="True" />
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
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Materia" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALMateria" UpdateMethod="Update"></asp:ObjectDataSource>
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
    </form>
</body>
</html>
