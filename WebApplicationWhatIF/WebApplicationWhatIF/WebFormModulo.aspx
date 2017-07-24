<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormModulo.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Lista de Módulos"></asp:Label>
        <hr />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="idModulo" DataSourceID="SqlDataSource1" PageSize="5" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="idModulo" HeaderText="idModulo" InsertVisible="False" ReadOnly="True" SortExpression="idModulo" />
                <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" />
                <asp:BoundField DataField="idDisciplina" HeaderText="idDisciplina" SortExpression="idDisciplina" />
                <asp:ButtonField CommandName="Editar" Text="Editar" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:2017WhatIFConnectionString %>" SelectCommand="SELECT * FROM [Modulo]"></asp:SqlDataSource>
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormModuloNew.aspx">Adicionar novo módulo</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
