<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastroAluno.aspx.cs" Inherits="WebApplicationWhatIF.WebFormCadastroAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css" >
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 207px;
        }
        .auto-style4 {
            height: 23px;
            width: 207px;
        }
        .auto-style5 {
            width: 207px;
        }
        #cadastro {
            margin:auto;
            width:525px;
            border-width: 2px;
            border-color:#008000;
            border-style:dashed;
        }
        #header {
            background-color: #E6FFE6;
            width: 100%;
            height: 60px;
        }
        .auto-style6 {
            width: 1280px;
            height: 1280px;
        }
                body {
            margin:0;
            padding:0;
            border:0;
        }
        .auto-style7 {
            width: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div >
		<div id="header" style="background-color: #DDDDDD">
                    <table style="width: 100%; height: 60px;">
                        <tr>
                            <td>&nbsp;</td>
                            <td align="center">
                                <img class="auto-style6" src="Images/Logo.jpg" style="width:55px; height:55px;" /></td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    </div>
					<br /><br />
        <table id="cadastro" >
            <tr>
                
                <td colspan="2" align="center" class="auto-style2"> Cadastro
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
    </form>
</body>
</html>
