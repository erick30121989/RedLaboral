<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListarOfertas.aspx.cs" Inherits="Form_OfertaLaboral_ListarOfertas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 259px;
        }
        .auto-style4 {
            width: 95px;
        }
        .auto-style5 {
            width: 307px;
        }
        .auto-style6 {
            width: 90px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">

    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">



    <table class="auto-style1">
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <strong>Puesto</strong></td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="160px">
                </asp:DropDownList>
            </td>
            <td class="auto-style4">
                <strong>Tipo de Contrato</strong></td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList2" runat="server" Height="19px" Width="161px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="6">
                <asp:GridView ID="GridView1" runat="server" Height="150px" Width="484px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>



    <br />

</asp:Content>

