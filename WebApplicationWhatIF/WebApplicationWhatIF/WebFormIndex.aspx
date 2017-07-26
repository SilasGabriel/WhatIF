<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormIndex.aspx.cs" Inherits="WebApplicationWhatIF.WebFormIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 654px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 229px">
        <div style="width:100%;">
        <asp:Button ID="Logout" runat="server"  Text="Logout" OnClick="Logout_Click" />
        </div>
        <br />
        <div id="div1" runat="server"></div>
        <br />
        <br />
    </div>
    </form>
</body>
</html>
