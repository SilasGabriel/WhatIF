<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormAutenticar.aspx.cs" Inherits="WebApplicationWhatIF.WebFormAutenticar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div style="margin-top:5%;">
        <!DOCTYPE html>

        <html xmlns="http://www.w3.org/1999/xhtml">

        <body>
            <div>
                <!-- <table style="margin:auto; width:30%; border-width:2px;border-style:dashed;border-color:#008000;background-color:#EDFBF1;"> -->
                <table class="corpoAutenticar">
                    <tr>
                        <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'">LOGIN</h2>
                            <hr />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto">Nome: </td>
                        <td class="auto"> <asp:TextBox ID="TextBoxLogin" class="dadosCadastro" runat="server" size="100" placeholder="Justus da Silva" MaxLength="100"></asp:TextBox>
	                    </td>
                    </tr>
                    <tr>
                        <td class="auto">Senha: </td>
                        <td class="auto"> <asp:TextBox ID="TextBoxSenha" class="dadosCadastro" runat="server" TextMode="Password" MaxLenght="10" MinLength="6"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto"><asp:Label ID="teste" runat="server"></asp:Label>
                        </td>
                        <td class="auto"><asp:Button ID="ButtonEntrar" class="butaoCadastro" runat="server" Text="Entrar" OnClick="ButtonEntrar_Click" />
                        </td>
                    </tr>
                    <tr>
                        <center><td class="auto-style4" colspan="2" align="center"> <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/WebFormCadastroAluno.aspx" Width="167px" Font-Names="Calibri" Font-Size="16px" Height="22px">Criar novo usuário</asp:HyperLink>
                        </td></center>
                    </tr>
                </table>
            <br /><br />  
            </div>
        </body>
        </html>
    </div>
</asp:Content>

