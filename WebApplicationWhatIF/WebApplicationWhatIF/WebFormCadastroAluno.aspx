<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"   AutoEventWireup="true" CodeBehind="WebFormCadastroAluno.aspx.cs" Inherits="WebApplicationWhatIF.WebFormCadastroAluno" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
    <div style="margin-top:5%;">
		
        <table id="cadastro"  style="margin:auto; width:20%; border-width:2px;border-style:dashed;border-color:#008000;background-color:#EDFBF1;">

            <tr>
                
                <td colspan="2" align="center" class="auto-style2"><h2 style="font-family:'Segoe UI Light'">CADASTRO</h2>
					<hr />
					</td>
             
            </tr>
            <tr>
                <td class="auto-style2">Nome</td>
                <td class="auto-style3"> <asp:TextBox ID="TextBoxNome" runat="server" size="20" MaxLength="100" placeholder="Justus da Silva" Width="200px"></asp:TextBox>
					</td>
            </tr>
            <tr>
                <td class="auto-style1">Senha</td>
                <td class="auto-style4"> <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password" size="10" MaxLength="10" Width="200px" placeholder="Senha entre 6 e 10 caracteres" MinLength="6"></asp:TextBox>
					</td>
            </tr>
            <tr>
                <td>Confirmar Senha</td>
                <td class="auto-style5">
                <asp:TextBox ID="TextBoxConfirmarSenha" runat="server" TextMode="Password" MaxLength="10" Width="200px" MinLength="6"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>Email</td>
                <td class="auto-style5"> <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" MaxLength="100" Width="200px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>Escola</td>
                <td align="right" class="auto-style5">
                <asp:DropDownList ID="DropDownListEscola" runat="server" Width="100px">
                    <asp:ListItem Value="true">Pública</asp:ListItem>
                    <asp:ListItem Value="false">Privado</asp:ListItem>
                </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td colspan="2" align="center"><asp:Button ID="ButtonEnviar" runat="server" Text="Enviar" OnClick="ButtonEnviar_Click" />
                    <table style="width:100%;">
                        <tr>
                            <td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxNome" ErrorMessage="Nome é obrigatório."></asp:RequiredFieldValidator>
					        </td>
                          
                        </tr>
                        <tr>
                            <td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxSenha" ErrorMessage="Senha é obrigatória."></asp:RequiredFieldValidator>
					        </td>
                         
                        
                        </tr>
                        <tr>
                            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxSenha" ControlToValidate="TextBoxConfirmarSenha" ErrorMessage="Senhas diferentes"></asp:CompareValidator>
					        </td>
                           
                         
                        </tr>
                        <tr>
                            <td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxConfirmarSenha" ErrorMessage="Confirmar a senha é obrigatório."></asp:RequiredFieldValidator>
					        </td>
                         
                      
                        </tr>
                        <tr>
                            <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email é obrigatório"></asp:RequiredFieldValidator>
                            </td>
                       
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
</asp:Content>

