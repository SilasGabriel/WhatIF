<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormModuloEdit.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModuloEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <script>
        function ConfirmaExclusao() {
            return confirm('Deseja realmente excluir este registro?');
        }
    </script>
    <style>
        #header {
            background-color: #DDDDDD;
            width: 100%;
            height: 60px;
        }
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            width: 10%;
        }
                body {
            margin:0;
            padding:0;
            border:0;
        }
    </style>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="header">
        <table style="width: 100%; height: 60px;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td align="center" class="auto-style1">
                    <img class="auto-style6" src="Images/Logo.jpg" style="width:55px; height:55px;" /></td>
                <td class="auto-style2">
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" style="margin-right: 15px;margin-left:23px;"/>
                </td>
            </tr>
        </table>
        <br />
        </div>
        
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="idModulo" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Height="150px" Width="310px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
            <EditRowStyle BackColor="#7C6F57" />
            <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="idModulo" HeaderText="idModulo" InsertVisible="False" ReadOnly="True" SortExpression="idModulo" />
                <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" />
                <asp:BoundField DataField="disciplina.idDisciplina" HeaderText="idDisciplina" />
                <asp:TemplateField ShowHeader="False">
                  <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Atualizar"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                    </EditItemTemplate>

                    <InsertItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert" Text="Inserir"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar"></asp:LinkButton>
                        &nbsp;&nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Excluir" OnClientClick="javascript:return ConfirmaExclusao();"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Fields>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Modulo" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALModulo" UpdateMethod="Update">
            <SelectParameters>
                <asp:SessionParameter Name="idModulo" SessionField="idModulo" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormModulo.aspx">Voltar para lista de módulos</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
