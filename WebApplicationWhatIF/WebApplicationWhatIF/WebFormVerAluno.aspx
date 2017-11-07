<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormVerAluno.aspx.cs" Inherits="WebApplicationWhatIF.WebFormVerAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="300px">
            <Fields>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "HandlerAluno2.ashx?Nome=" + Eval("nome") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="idAluno" HeaderText="idAluno" ReadOnly="True" SortExpression="idAluno" />
                <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" ReadOnly="True" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" ReadOnly="True" />
                <asp:CheckBoxField DataField="escolaPublica" HeaderText="escolaPublica" SortExpression="escolaPublica" ReadOnly="True" />
                <asp:CheckBoxField DataField="administrador" HeaderText="administrador" SortExpression="administrador" />
                <asp:CommandField EditText="Tornar Adm" HeaderText="Tornar Adm" ShowEditButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Aluno" SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALAluno" UpdateMethod="UpdateDetailsView">
            <SelectParameters>
                <asp:SessionParameter Name="nome" SessionField="nomeAluno" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    <div>
    
    </div>
    </form>
</body>
</html>
