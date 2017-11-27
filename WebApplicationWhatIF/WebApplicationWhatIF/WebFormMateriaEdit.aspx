<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormMateriaEdit.aspx.cs" Inherits="WebApplicationWhatIF.WebFormMateriaEdit" %>
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
                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> EDITAR MATERIA </h2>
                    <hr />
                </td>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Font-Names="Segoe UI Light" Text="Título"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("titulo") %>' MaxLength="60"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="A matéria deve possuir um título"></asp:RequiredFieldValidator>
                                </ItemTemplate>
                            </asp:DataList>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectData" TypeName="WebApplicationWhatIF.DAL.DALMateria">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="idMateria" QueryStringField="idMateria" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" Font-Names="Segoe UI Light" Text="Descrição"></asp:Label>
                        </td>
                        <td>
                            <asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource2">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Height="534px" MaxLength="7500" TextMode="MultiLine" Width="537px" Text='<%# Eval("descricao") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="A matéria deve possuir uma descrição" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                                </ItemTemplate>
                            </asp:DataList>
                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectData" TypeName="WebApplicationWhatIF.DAL.DALMateria">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="idMateria" QueryStringField="idMateria" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label3" runat="server" Font-Names="Segoe UI Light" Text="Foto da matéria"></asp:Label>
                        </td>
                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/HandlerMateria2.ashx" />
                            <br />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Atualizar" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancelar" />
                        </td>
                    </tr>
                </table>
            </div>
        </body>
        </html>
    </div>
</asp:Content>