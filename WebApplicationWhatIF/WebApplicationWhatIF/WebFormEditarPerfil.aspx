<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEditarPerfil.aspx.cs" Inherits="WebApplicationWhatIF.WebFormEditarPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="HandlerAluno.ashx" Width="100px" />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Salvar" />
    
    </div>
    </form>
</body>
</html>
