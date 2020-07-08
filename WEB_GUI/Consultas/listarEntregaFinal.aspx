<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="listarEntregaFinal.aspx.cs" Inherits="WEB.Consultas.listarEntregaFinal" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2> Listar Entrega Final</h2>
<table style="width: 70%">
    <tr>
        <td style="width: 140px">Escoger Proyecto:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 140px">Fecha de Entrega:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="TextBox1">
            </ajaxToolkit:CalendarExtender>
        </td>
    </tr>
    <tr>
        <td style="width: 140px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
<p> 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="253px" style="margin-right: 31px" Width="410px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_documento" HeaderText="Id Documento" />
            <asp:BoundField DataField="id_proyecto" HeaderText="Id Proyecto" />
            <asp:BoundField DataField="nom_proyecto" HeaderText="Nombre del Proyecto" />
            <asp:BoundField DataField="Encargado" HeaderText="Encargado" />
            <asp:BoundField DataField="fecha" DataFormatString="{0:d}" HeaderText="Fecha de Entrega">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    </p>
</asp:Content>
