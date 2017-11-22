<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormEditarPerfil.aspx.cs" Inherits="WebApplicationWhatIF.WebFormEditarPerfil" %>

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
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <div  style="margin-top:5%;">
    
        <table style="margin:auto; width:20%; border-width:2px;border-style:dashed;border-color:#008000;background-color:#EDFBF1;">
            <tr>
           
                    <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'">EDITAR PERFIL</h2>
                        <hr />
        </td>
               
                </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                </td>
                <td class="auto-style2">
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" Height="74px" Width="148px">
            <ItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("nome") %>'></asp:TextBox>
            </ItemTemplate>
        </asp:DataList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectData" TypeName="WebApplicationWhatIF.DAL.DALAluno">
            <SelectParameters>
                <asp:SessionParameter Name="nome" SessionField="Nome" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource2">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("email") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectData" TypeName="WebApplicationWhatIF.DAL.DALAluno">
                        <SelectParameters>
                            <asp:SessionParameter Name="nome" SessionField="Nome" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">

                    <asp:Label ID="Label4" runat="server" Text="Escola"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownListEscola" runat="server" Width="200px" Height="16px">
                    <asp:ListItem Value="true">Pública</asp:ListItem>
                    <asp:ListItem Value="false">Privado</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Foto de Perfil"></asp:Label>
                </td>
                <td>
    
        <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="HandlerAluno.ashx" Width="100px" />
                    <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Salvar" />
    
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    
    </div>
</body>
</html>
    </asp:Content>

