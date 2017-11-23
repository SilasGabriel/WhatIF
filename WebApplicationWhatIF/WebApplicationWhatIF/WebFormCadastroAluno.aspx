<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"   AutoEventWireup="true" CodeBehind="WebFormCadastroAluno.aspx.cs" Inherits="WebApplicationWhatIF.WebFormCadastroAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div style="margin-top:42px;">
        <!DOCTYPE html>

        <html xmlns="http://www.w3.org/1999/xhtml">

        <body>
            <div>
                <!-- <table id="cadastro"  style="margin:auto; width:20%; border-width:2px;border-style:dashed;border-color:#008000;background-color:#EDFBF1;"> -->
                <table class="corpoCadastro">
                    <tr>
                        <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'">CADASTRO</h2>
					        <hr />
				        </td>
                    </tr>
                    <tr>
                        <td class="auto">Nome</td>
                        <td class="auto"> <asp:TextBox ID="TextBoxNome" class="dadosCadastro" runat="server" size="20" MaxLength="100" placeholder="Justus da Silva"></asp:TextBox>
				        </td>
                    </tr>
                    <tr>
                        <td class="auto">Senha</td>
                        <td class="auto"> <asp:TextBox ID="TextBoxSenha" class="dadosCadastro" runat="server" TextMode="Password" size="10" MaxLength="10" placeholder="Senha entre 6 e 10 caracteres" MinLength="6"></asp:TextBox>
				        </td>
                    </tr>
                    <tr>
                        <td class="auto">Confirmar Senha</td>
                        <td class="auto">
                        <asp:TextBox ID="TextBoxConfirmarSenha" runat="server" class="dadosCadastro" TextMode="Password" MaxLength="10" MinLength="6"></asp:TextBox>
                        </td>
                
                    </tr>
                    <tr>
                        <td class="auto">Email</td>
                        <td class="auto"> <asp:TextBox ID="TextBoxEmail" class="dadosCadastro" runat="server" TextMode="Email" MaxLength="100"></asp:TextBox>
                        </td>
                    </tr>
                    <tr
                        <br />
                        <br />
                        <td class="auto">Escola</td>
                        <td align="right" class="">
                        <asp:DropDownList ID="DropDownListEscola" class="dadosCadastro" runat="server" style="margin-right: 22px">
                            <asp:ListItem Value="true">Pública</asp:ListItem>
                            <asp:ListItem Value="false">Privado</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <br />
                        <br />
                    </tr>
                    <tr style="height:20px">
                        <td colspan="2" align="center"><asp:Button ID="ButtonEnviar" class="butaoCadastro" runat="server" Text="Enviar" OnClick="ButtonEnviar_Click" /></td>
                            <!--<table style="width:100%; height:10%">--></tr>
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
                            <!--></table><-->
                </table>
            </div>
        </body>
        </html>
    </div>
</asp:Content>

