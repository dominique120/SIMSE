<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="listarEntregaFinal.aspx.cs" Inherits="WEB.Consultas.listarEntregaFinal" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
        <div id="resultados">
    <h2> Listar Entrega Final</h2>

<table style="width: 70%">
    <tr>
        <td style="width: 140px">Fecha de Inicio</td>
        <td>
            <asp:TextBox ID="txtFInicio" runat="server"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="txtFInicio_CalendarExtender" runat="server" BehaviorID="txtFInicio_CalendarExtender" TargetControlID="txtFInicio" />
        </td>
    </tr>
    <tr>
        <td style="width: 140px">Fecha de Fin:</td>
        <td>
            <asp:TextBox ID="txtFFIN" runat="server"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="txtFFIN_CalendarExtender" runat="server" BehaviorID="txtFFIN_CalendarExtender" TargetControlID="txtFFIN" />
        </td>
    </tr>
    <tr>
        <td style="width: 140px">&nbsp;</td>
        <td>
            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
        </td>
    </tr>
</table>
<p> 
    <asp:GridView ID="grvEntregas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="253px" style="margin-right: 31px" Width="682px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_documento" HeaderText="Id Documento" />
            <asp:BoundField DataField="nom_proyecto" HeaderText="Proyecto" />
            <asp:BoundField DataField="encargado" HeaderText="Encargado" />
            <asp:BoundField DataField="fecha" DataFormatString="{0:d}" HeaderText="Fecha de Entrega">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="path_scan_reporte" HeaderText="Scan" />
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
