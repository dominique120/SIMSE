<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarTipodePlanos.aspx.cs" Inherits="WEB_GUI.Consultas.ListarTipodePlanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Listar Tipos de Planos</p>
    <table style="width: 60%">
        <tr>
            <td style="width: 183px">Escoge el Tipo de Plano: </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:HyperLink ID="HyperLink1" runat="server">Retornar</asp:HyperLink>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Consultar" />
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="277px" Width="674px">
            <Columns>
                <asp:BoundField DataField="nom_plano" HeaderText="Nombre de Plano" />
                <asp:BoundField DataField="tipo_plano" HeaderText="Tipo de Plano" />
                <asp:BoundField DataField="fecha_creacion" DataFormatString="{0:d}" HeaderText="Fecha de Creacion" />
                <asp:BoundField DataField="fecha_revision" DataFormatString="{0:d}" HeaderText="Fecha de Revision" />
                <asp:BoundField DataField="fecha_envio" DataFormatString="{0:d}" HeaderText="Fecha de Envio" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </p>
</asp:Content>
