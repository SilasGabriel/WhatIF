<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormIndex.aspx.cs" Inherits="WebApplicationWhatIF.WebFormIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title>What IF</title>
            <style type="text/css">
                #header
                {
                    background-color: #DDDDDD;
                    width: 100%;
                    height: 60px;
                }
                .auto-style2
                {
                    width: 80%;
                }
                .auto-style3
                {
                    width: 10%;

                }
                body
                {
                    margin:0;
                    padding:0;
                    border:0;
                }
                #asd
                {
                    position:absolute;
                    left : 10%;
                    width: 500px;
                }
            </style>
        </head>
        <body>
            <div class="corpoNormal">
                <div id="div1" runat="server">
                </div>
                <center>
                    <div style="height: 20%">
                    <img id="Img1" src="Images/logo.png" style="height:20%; width:20%" runat="server" />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormProgresso.aspx">Acompanhar progresso detalhado</asp:HyperLink>
                    </div>
                    <center>
                    <table style="width:50%;">
                        <center>

                        <tr>
                            <td></td>
                            <td>PORCENTAGEM DE CONCLUSÃO</td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
                            
                        </tr>
                        <tr>
                            <td>FÁCIL</td>
                            <td>MÉDIO</td>
                            <td>DIFICIL</td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                            <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                            <td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                        </tr>
                            </center>
                    </table>
                        </center>
                </center>
            </div>
        </body>
        </html>
    </div>
</asp:Content>

