<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormIndex.aspx.cs" Inherits="WebApplicationWhatIF.WebFormIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>What IF</title>
    <style type="text/css">
        #header {
            background-color: #DDDDDD;
            width: 100%;
            height: 60px;
        }
        .auto-style2 {
            width: 80%;
        }
        .auto-style3 {
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
    <form id="form1" runat="server">

    <div style="height: 229px">
        <div id="header">
        <table style="width: 100%; height: 60px;">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td align="center" class="auto-style2">
                    <img class="auto-style6" src="Images/Logo.jpg" style="width:55px; height:55px;" /></td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Logout_Click" style="margin-right: 15px;margin-left:23px;"/>
                </td>
            </tr>
        </table>
        <br />
        </div>
        <br />
        <div id="div1" runat="server"></div>
        <br />
        <br />
    </div>
    </form>
</body>
</html>
