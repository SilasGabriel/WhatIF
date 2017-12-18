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
    <div>
        <h1>Editar Desafio</h1>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Título"></asp:Label>
                </td>
                <td>
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            &nbsp;<asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("titulo") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="TextBox3" ErrorMessage="O desafio deve possuir um título"></asp:RequiredFieldValidator>
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALDesafio">
                        <SelectParameters>
                            <asp:SessionParameter Name="idDesafio" SessionField="idDesafio" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Questão"></asp:Label>
                </td>
                <td>
                    <asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource2">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Height="200px" 
                                Text='<%# Eval("questao") %>' TextMode="MultiLine" Width="500px"></asp:TextBox>
                            <br />
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="TextBox4" 
                                ErrorMessage="O desafio deve possuir uma questão (enunciado)"></asp:RequiredFieldValidator>
                            <br />
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                        SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALDesafio">
                        <SelectParameters>
                            <asp:SessionParameter Name="idDesafio" SessionField="idDesafio" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Imagem da questão"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/HandlerDesafio3.ashx" />
                    <br />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Dificuldade</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        DataSourceID="ObjectDataSource3" DataTextField="grau" 
                        DataValueField="idDificuldade">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
                        SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALDificuldade">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Atualizar" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancelar" />
                </td>
            </tr>
        </table>
    
    </div>
        </body>
        </html>
    </div>
</asp:Content>