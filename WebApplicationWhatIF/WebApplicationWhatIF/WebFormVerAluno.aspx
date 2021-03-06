﻿<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master" AutoEventWireup="true" CodeBehind="WebFormVerAluno.aspx.cs" Inherits="WebApplicationWhatIF.WebFormVerAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<!DOCTYPE html>
    <div style="margin-top:5%">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
        </head>
        <body>
            <div class="corpoNormal">
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="150px" Width="700px" BackColor="White" BorderColor="#EDFBF1" BorderStyle="Solid" BorderWidth="3px" CellPadding="20">
                    <Fields>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "HandlerAluno2.ashx?Nome=" + Eval("nome") %>' Height="100px" Width="100px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="idAluno" HeaderText="idAluno" ReadOnly="True" SortExpression="idAluno" />
                        <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" ReadOnly="True" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" ReadOnly="True" />
                        <asp:CheckBoxField DataField="escolaPublica" HeaderText="escolaPublica" SortExpression="escolaPublica" ReadOnly="True" />
                        <asp:CheckBoxField DataField="administrador" HeaderText="administrador" SortExpression="administrador" />
                        <asp:CommandField EditText="Tornar Adm" HeaderText="Tornar Adm" ShowEditButton="True" />
                    </Fields>
                    <FooterStyle BackColor="#EDFBF1" ForeColor="#000000" />
                    <HeaderStyle BackColor="#2ecc71" Font-Bold="True" ForeColor="#FFFFFF" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000000" />
                </asp:DetailsView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebApplicationWhatIF.Modelo.Aluno" SelectMethod="Select" TypeName="WebApplicationWhatIF.DAL.DALAluno" UpdateMethod="UpdateDetailsView">
                    <SelectParameters>
                        <asp:SessionParameter Name="nome" SessionField="nomeAluno" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </body>
        </html>
    </div>
</asp:Content>