<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDesafio.aspx.cs" Inherits="WebApplicationWhatIF.WebFormDesafio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Desafios</h1>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Vertical" OnRowCommand="GridView1_RowCommand" Width="427px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="idDesafio" HeaderText="id" SortExpression="idDesafio" />
                <asp:BoundField DataField="titulo" HeaderText="Título" SortExpression="titulo" />
                <asp:BoundField DataField="questao" HeaderText="Questão" SortExpression="questao" />
                <asp:ButtonField CommandName="Editar" Text="Editar" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Desafio" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALDesafio" UpdateMethod="Update"></asp:ObjectDataSource>
    <br />

    </div>
    </form>
</body>
</html>
