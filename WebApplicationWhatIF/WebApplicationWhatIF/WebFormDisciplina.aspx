<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormDisciplina.aspx.cs" Inherits="WebApplicationWhatIF.WebFormDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
            <style>
            </style>
        </head>
        <body>
            <div class="corpoCaminho">
                <h2 style="font-family:Calibri">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </h2>
            </div>
            <div>
                <asp:Table ID="Table1" runat="server" class="corpoNormal">
                </asp:Table>
            </div>
        </body>
        </html>
    </div>
</asp:Content>