<%@ Page Language="C#" MasterPageFile="~/MasterPageAluno.Master"   AutoEventWireup="true" CodeBehind="WebFormExercicioUsuario.aspx.cs" Inherits="WebApplicationWhatIF.WebFormExercicioUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <!DOCTYPE html>
    <div style="margin-top:5%;">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title></title>
            <style type="text/css">
                .auto-style1 {
                    width: 251px;
                }
                .auto-style2 {
                    width: 250px;
                }
                .auto-style3 {
                    width: 245px;
                }
                .auto-style4 {
                    width: 10px;
                }
                .auto-style6 {
                    width: 10px;
                    height: 25px;
                }
                .auto-style7 {
                    height: 25px;
                }
                .qwe {
                    background-color: #EDFBF1;
                }
            </style>
        </head>
        <body>
            <div class="corpoNormal">
                <div class="qwe">
                <asp:Table ID="Table1" runat="server">
                </asp:Table>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label1" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButton ID="RadioButton1" runat="server" EnableTheming="True" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label2" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label3" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label4" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label5" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="alternativas" Visible="False" />
                        </td>
                    </tr>
                </table>
                <asp:Label ID="Label26" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                <br />
                </div>
                <div class="qwe">
                <asp:Table ID="Table2" runat="server">
                </asp:Table>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label6" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButton ID="RadioButton6" runat="server" EnableTheming="True" GroupName="alternativas1" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label7" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style7">
                            <asp:RadioButton ID="RadioButton7" runat="server" GroupName="alternativas1" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label8" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton8" runat="server" GroupName="alternativas1" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label9" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton9" runat="server" GroupName="alternativas1" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label10" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton10" runat="server" GroupName="alternativas1" Visible="False" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="Label27" runat="server" Font-Names="Segoe UI Light"></asp:Label>
            </div>
            <div class="qwe">
                <asp:Table ID="Table3" runat="server">
                </asp:Table>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label11" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButton ID="RadioButton11" runat="server" EnableTheming="True" GroupName="alternativas2" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label12" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton12" runat="server" GroupName="alternativas2" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label13" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton13" runat="server" GroupName="alternativas2" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label14" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton14" runat="server" GroupName="alternativas2" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label15" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton15" runat="server" GroupName="alternativas2" Visible="False" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="Label28" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                </div>
                <div class="qwe">
                <asp:Table ID="Table4" runat="server">
                </asp:Table>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label16" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButton ID="RadioButton16" runat="server" EnableTheming="True" GroupName="alternativas3" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label17" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton17" runat="server" GroupName="alternativas3" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label18" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton18" runat="server" GroupName="alternativas3" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label19" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton19" runat="server" GroupName="alternativas3" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label20" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton20" runat="server" GroupName="alternativas3" Visible="False" />
                        </td>
                    </tr>
                </table>
    

                <br />
                <asp:Label ID="Label29" runat="server" Font-Names="Segoe UI Light"></asp:Label>
            </div>
        <div class="qwe">
                <asp:Table ID="Table5" runat="server">
                </asp:Table>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label21" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButton ID="RadioButton21" runat="server" EnableTheming="True" GroupName="alternativas4" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label22" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton22" runat="server" GroupName="alternativas4" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label23" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton23" runat="server" GroupName="alternativas4" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label24" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton24" runat="server" GroupName="alternativas4" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label25" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton25" runat="server" GroupName="alternativas4" Visible="False" />
                        </td>
                    </tr>
                </table>
                <asp:Label ID="Label30" runat="server" Font-Names="Segoe UI Light"></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Responder" OnClick="Button1_Click" class="butaoEnviar"/>
            </div>
            </div>
        </body>
        </html>
    </div>
</asp:Content>