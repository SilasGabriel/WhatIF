<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"  AutoEventWireup="true" CodeBehind="WebFormModuloEdit.aspx.cs" Inherits="WebApplicationWhatIF.WebFormModuloEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
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
            <div class="corpoNormal">
                <td colspan="2" align="center"><h2 style="font-family:'Segoe UI Light'"> EDITAR MODULO </h2>
                    <hr />
                </td>
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="20" DataKeyNames="idModulo" DataSourceID="ObjectDataSource1" GridLines="Both" Height="150px" Width="350px" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="3px">
                    <EditRowStyle BackColor="White" ForeColor="#000000" BorderColor="#2ecc71" BorderStyle="Solid" BorderWidth="3px"/>
                    <Fields>
                        <asp:BoundField DataField="idModulo" HeaderText="idModulo" ReadOnly="True" SortExpression="idModulo" />
                        <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                        <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" />
                        <asp:TemplateField HeaderText="disciplina">
                            <ItemTemplate>
                                <asp:DataList runat="server" DataSourceID="ObjectDataSource3">
                                    <ItemTemplate>
                                        <asp:Label ID="disciplinaLabel" runat="server" Text='<%# Eval("disciplina.nome") %>' />
                                    </ItemTemplate>
                                </asp:DataList> 
                                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALModulo">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="idModulo" SessionField="idModulo" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="nome" DataValueField="idDisciplina" SelectedValue='<%# Bind("idDisciplina") %>' style="height: 22px; width: 88px"  >
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="WebApplicationWhatIF.DAL.DALDisciplina"></asp:ObjectDataSource>
                                <br /><asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Atualizar" ForeColor="#000000"></asp:LinkButton>
                                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" ForeColor="#000000"></asp:LinkButton>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert" Text="Inserir"></asp:LinkButton>
                                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar" ForeColor="#000000"></asp:LinkButton>
                                &nbsp;&nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Excluir" OnClientClick="javascript:return ConfirmaExclusao();" ForeColor="#000000"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Fields>
                    <FooterStyle BackColor="#EDFBF1" ForeColor="#000000" />
                    <HeaderStyle BackColor="#2ecc71" Font-Bold="True" ForeColor="#FFFFFF" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000000" />
                </asp:DetailsView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Modulo" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALModulo" UpdateMethod="Update">
                    <SelectParameters>
                        <asp:SessionParameter Name="idModulo" SessionField="idModulo" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
    
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormModulo.aspx">Voltar para lista de módulos</asp:HyperLink>
    
            </div>
        </body>
        </html>
    </div>
</asp:Content>