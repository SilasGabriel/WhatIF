<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormExercicioNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormExercicioNew" %>
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
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="2px" CellPadding="20">
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Exercicio" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAllIdMateria" TypeName="WebApplicationWhatIF.DAL.DALExercicio" UpdateMethod="Update">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="idMateria" QueryStringField="idMateria" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <hr /><h2 style="font-family:'Segoe UI Light'"> ADICIONAR EXERCICIO </h2>
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
        </body>
        </html>
    </div>
</asp:Content>