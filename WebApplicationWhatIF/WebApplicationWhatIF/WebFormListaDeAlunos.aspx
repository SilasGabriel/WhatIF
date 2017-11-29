<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormListaDeAlunos.aspx.cs" Inherits="WebApplicationWhatIF.WebFormListaDeAlunos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
        </head>
        <body>
            <div class="corpoNormal">
                <div>
                    <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> TODOS OS USUARIOS </h2>
                        <hr />
                    </td>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand" Width="600px" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="2px" CellPadding="20" ForeColor="#333333">
                        <Columns>
                            <asp:BoundField DataField="idAluno" HeaderText="idAluno" SortExpression="idAluno" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                            <asp:BoundField DataField="senha" HeaderText="Senha" SortExpression="senha" />
                            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                            <asp:CheckBoxField DataField="escolaPublica" HeaderText="Escola Pública" SortExpression="escolaPublica" />
                            <asp:CheckBoxField DataField="administrador" HeaderText="Administrador" SortExpression="administrador" />
                            <asp:ButtonField CommandName="Visualizar" Text="Visualizar aluno" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#EDFBF1" ForeColor="#000000" />
                        <HeaderStyle BackColor="#2ecc71" Font-Bold="True" ForeColor="#FFFFFF" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000000" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALAluno"></asp:ObjectDataSource>
                </div>

                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> USUARIOS ADMINISTRADORES </h2>
                    <hr />
                </td>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Height="131px" Width="597px" ForeColor="#333333" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="2px" CellPadding="20">
                    <Columns>
                        <asp:BoundField DataField="idAluno" HeaderText="idAluno" SortExpression="idAluno" />
                        <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                        <asp:BoundField DataField="senha" HeaderText="senha" SortExpression="senha" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:CheckBoxField DataField="escolaPublica" HeaderText="escolaPublica" SortExpression="escolaPublica" />
                        <asp:CheckBoxField DataField="administrador" HeaderText="administrador" SortExpression="administrador" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#EDFBF1" ForeColor="#000000" />
                    <HeaderStyle BackColor="#2ecc71" Font-Bold="True" ForeColor="#FFFFFF" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000000" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAdm" TypeName="WebApplicationWhatIF.DAL.DALAluno"></asp:ObjectDataSource>
            </div>
        </body>
        </html>
    </div>
</asp:Content>