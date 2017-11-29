<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"   AutoEventWireup="true" CodeBehind="WebFormDesafioNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormDesafio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <div>
    <h1>Inserir Desafio</h1>
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
                    <asp:Button ID="Button2" runat="server" Text="Preview" OnClick="Button2_Click" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormDesafio.aspx">Voltar</asp:HyperLink>
    </div>
</body>
</html>
    </asp:Content>