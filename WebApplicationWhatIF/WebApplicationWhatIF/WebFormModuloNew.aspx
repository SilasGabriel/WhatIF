<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormModuloNew.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModuloNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #header {
            background-color: #DDDDDD;
            width: 100%;
            height: 60px;
        }
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            width: 10%;
        }
        body {
            margin:0;
            padding:0;
            border:0;
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
    <form id="form1" runat="server">
    <div>
        <div id="header">
        <table style="width: 100%; height: 60px;">
            <tr>
                <td class="auto-style2">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormModulo.aspx">Voltar</asp:HyperLink>
                </td>
                <td align="center" class="auto-style1">
                    <img class="auto-style6" src="Images/Logo.jpg" style="width:55px; height:55px;" /></td>
                <td class="auto-style2">
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" style="margin-right: 15px;margin-left:23px;"/>
                </td>
            </tr>
        </table>
        <br />
        </div>
        <br /><br />
        <table style="width:600px;border-width:2px;border-style:dashed;border-color:#008000;margin:auto">
            <tr>
                <td class="auto-style11" colspan="2">
        <asp:Label ID="Label1" runat="server" Text="Inserir Módulo"></asp:Label>
                </td>
          
            </tr>
            <tr>
                <td class="auto-style11" colspan="2">
        <hr style="width: 600px" />
                </td>

          
            </tr>
            <tr>
                <td class="auto-style11">Título</td>
                <td class="auto-style12">
        <asp:TextBox ID="Titulo" runat="server" Width="300px"></asp:TextBox>
                </td>
          
            </tr>
            <tr>
                <td class="auto-style4">Descrição</td>
                <td>
        <asp:TextBox ID="Descricao" runat="server" Width="300px" Height="46px" TextMode="MultiLine"></asp:TextBox>
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
    </form>
</body>
</html>
