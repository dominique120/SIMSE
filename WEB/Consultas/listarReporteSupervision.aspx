<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="listarReporteSupervision.aspx.cs" Inherits="WEB.Consultas.listarReporteSupervision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
        <div id="resultados">
    <h2> Listar Reporte Supervision</h2>
<table style="width: 70%">
    <tr>
        <td style="width: 139px">Proyecto:</td>
        <td>
            <asp:DropDownList ID="cboProyecto" runat="server" Width="250px">
            </asp:DropDownList>
        </td>
    </tr>
        <tr>
        <td style="width: 139px">Empleado</td>
        <td>
            <asp:DropDownList ID="cboEmpleado" runat="server" Width="250px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 139px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
        </td>
    </tr>
</table>
<p> 
    <asp:GridView ID="grvReportes" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="217px" Width="683px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_documento" HeaderText="Id Documento" />
            <asp:BoundField DataField="supervisor" HeaderText="Supervisor" />
            <asp:BoundField DataField="fecha_reporte" DataFormatString="{0:d}" HeaderText="Fecha de Reporte">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="detalles_reporte" HeaderText="Detalles de Reporte" />
            <asp:BoundField DataField="path_scan_reporte" HeaderText="Path" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
</p>
    <p> 
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
</p>
            </div>
</asp:Content>
