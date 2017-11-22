<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormExercicioEdit.aspx.cs" Inherits="WebApplicationWhatIF.WebFormExercicioEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Editar Exercício</h1>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Título"></asp:Label>
                </td>
                <td>
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("titulo") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="O exercício deve possuir um título"></asp:RequiredFieldValidator>
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectData" TypeName="WebApplicationWhatIF.DAL.DALExercicio">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="idExercicio" QueryStringField="idExercicio" Type="Int32" />
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
                            <asp:TextBox ID="TextBox2" runat="server" Height="200px" TextMode="MultiLine" Width="500px" Text='<%# Eval("questao") %>'></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="O exercício deve possuir uma questão (enunciado)" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectData" TypeName="WebApplicationWhatIF.DAL.DALExercicio">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="idExercicio" QueryStringField="idExercicio" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Imagem da questão"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/HandlerExercicio2.ashx" />
                    <br />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
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
    </form>
</body>
</html>
