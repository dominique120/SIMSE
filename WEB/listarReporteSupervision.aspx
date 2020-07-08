<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="listarReporteSupervision.aspx.cs" Inherits="WEB.Consultas.listarReporteSupervision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h2> Listar reporte supervision</h2>
<table style="width: 70%">
    <tr>
        <td style="width: 139px">Seleccione Proyecto:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 139px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Buscar" />
        </td>
    </tr>
</table>
<p> 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="217px" Width="409px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="nom_proyecto" HeaderText="Nombre de Proyecto" />
            <asp:BoundField DataField="Supervisor" HeaderText="Supervisor" />
            <asp:BoundField DataField="fecha_reporte" DataFormatString="{0:d}" HeaderText="Fecha de Reporte">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="detalles_reporte" HeaderText="Detalles de Reporte" />
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
</p>
<p> &nbsp;</p>
</asp:Content>
