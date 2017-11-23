<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormQuestãoDesafio.aspx.cs" Inherits="WebApplicationWhatIF.WebFormQuestãoDesafio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
            <style type="text/css">
                .auto-style1
                {
                    height: 21px;
                }
                .auto-style2
                {
                    height: 21px;
                    width: 336px;
                }
                .auto-style3
                {
                    width: 336px;
                }
            </style>
        </head>
        <body>
            <div class="corpoNormal">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="titulo" DataValueField="idDesafio">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Escolher"/>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALDesafio"></asp:ObjectDataSource>
                <asp:Table ID="Table1" runat="server">
                </asp:Table>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButton ID="RadioButton1" runat="server" EnableTheming="True" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label3" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label4" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label5" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="Label6" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                <br />
                <asp:Button ID="Button2" runat="server" Text="Responder" OnClick="Button2_Click" class="butaoEnviar"/>
            </div>
        </body>
        </html>
    </div>
</asp:Content>