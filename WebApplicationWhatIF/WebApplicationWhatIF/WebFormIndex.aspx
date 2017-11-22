<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormIndex.aspx.cs" Inherits="WebApplicationWhatIF.WebFormIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
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
        <div style="margin-top:5%;">
            <div id="div1" runat="server">
            </div>
            <div style="height: 229px">
                <img src="Images/logo.png" runat="server" />
            </div>
        </div>
    </body>
    </html>
</asp:Content>

