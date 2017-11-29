<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormModuloNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModuloNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
            <style>
                .auto-style1 {
                    width: 80%;
                }
                .auto-style2 {
                    width: 10%;
                }
                .auto-style4 {
                    width: 299px;
                }
                .auto-style5 {
                    width: 299px;
                    height: 20px;
                }
                .auto-style6 {
                    width: 206px;
                    height: 29px;
                }
                .auto-style8 {
                    height: 20px;
                }
                .auto-style11 {
                    width: 299px;
                    height: 26px;
                }
                .auto-style12 {
                    height: 26px;
                }
                </style>
        </head>
        <body>
            <div class="corpoNormal">
                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> INSERIR MODULO </h2>
                    <hr />
                </td>
                <table>
                    <tr>
                        <td class="auto-style11">Título</td>
                        <td class="auto-style12">
                            <asp:TextBox ID="TituloId" runat="server" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Descrição</td>
                        <td>
                            <asp:TextBox ID="DescricaoId" runat="server" Width="300px" Height="46px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">DisciplinaID (Português - 1; Matemática - 2)</td>
                        <td>
                            <asp:TextBox ID="DisciplinaId" runat="server" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td class="auto-style8">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Adicionar" />
                        </td>
            
                    <tr>
                        <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TituloId" ErrorMessage="*Informe o título"></asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style8">
                            &nbsp;</td>
            
                    </tr>
                    <tr>
                        <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DescricaoId" ErrorMessage="*Preencha a descrição"></asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style8">
                            &nbsp;</td>
            
                    </tr>
                    <tr>
                        <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DisciplinaId" ErrorMessage="*Informe o ID da Disciplina"></asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style8">
                        &nbsp;</td>
                    </tr>
                </table>
            </div>
        </body>
        </html>
    </div>
</asp:Content>