﻿<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormAdministrador.aspx.cs" Inherits="WebApplicationWhatIF.WebFormAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 264px;
            height: 30px;
        }
        .auto-style2 {
            width: 1799px;
            height: 30px;
        }
        .auto-style3 {
            height: 30px;
        }
        #header {
            background-color: #DDDDDD;
            width: 100%;
            height: 60px;
        }
        .auto-style4 {
            width: 80%;
        }
        .auto-style5 {
            width: 10%;
        }
        body {
            margin:0;
            padding:0;
            border:0;
        }
        
    </style>
</head>
<body>
    <div style="margin-top:5%;">
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style2" style="width:80%">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Images/iaula.jpg" Height="150px" OnClick="ImageButton1_Click" Width="150px" />
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="Images/idesafio.jpg" Height="150px" OnClick="ImageButton2_Click1" Width="150px"/>
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="Images/ialuno.png" Height="150px" OnClick="ImageButton4_Click1" Width="150px"/>

                    <asp:HyperLink ID="CrudModulo" runat="server" NavigateUrl="~/WebFormModulo.aspx">CRUDs de Aula</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebFormDesafio.aspx">CRUD Desafio</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormListaDeAlunos.aspx">Lista de Alunos</asp:HyperLink>
                </td>
                <td class="auto-style1" align:"center" style="width:10%">&nbsp;</td>
                <td class="auto-style3" align:"center" style="width:10%">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
    </div>
</body>
</html>
    </asp:Content>