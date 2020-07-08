<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="listarReporteTecnico.aspx.cs" Inherits="WEB.Consultas.listarReporteTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    
    <h2>Listar Reporte Tecnico</h2>
<table style="width: 70%">
    <tr>
        <td style="width: 125px">Escoger proyecto:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 125px">Tecnico:</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 125px; height: 23px"></td>
        <td style="height: 23px">
            <asp:Button ID="Button1" runat="server" Text="Buscar" />
        </td>
    </tr>
</table>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="187px" Width="404px">
        <Columns>
            <asp:BoundField DataField="nom_proyecto" HeaderText="Nombre del Proyecto" />
            <asp:BoundField DataField="Tecnico" HeaderText="Nombre del Tecnico" />
            <asp:BoundField DataField="fecha_reporte" DataFormatString="{0:d}" HeaderText="Fecha de Reporte">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="detalle_reporte" HeaderText="Detalles del Reporte" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
</p>
<p>&nbsp;</p>
</asp:Content>
