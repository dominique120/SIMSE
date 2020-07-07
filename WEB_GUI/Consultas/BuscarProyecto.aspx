<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarProyecto.aspx.cs" Inherits="WEB_GUI.Consultas.BuscarProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Buscar Proyecto</p>
    <table style="width: 60%">
        <tr>
            <td style="width: 206px; height: 29px">Seleccione Proyecto:</td>
            <td style="height: 29px">
                <asp:DropDownList ID="cboProyecto" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 206px">
                <asp:HyperLink ID="HyperLink1" runat="server">Retornar</asp:HyperLink>
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
            </td>
        </tr>
        <tr>
            <td style="width: 206px">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="205px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="882px">
        <Columns>
            <asp:BoundField DataField="id_proyecto" HeaderText="ID Proyecto" />
            <asp:BoundField DataField="nom_cli" HeaderText="Nom. Cliente" />
            <asp:BoundField DataField="Division" HeaderText="Division" />
            <asp:BoundField DataField="Direccion1" HeaderText="Division1" />
            <asp:BoundField DataField="fec_ini" HeaderText="Fecha de Inicio" />
            <asp:BoundField DataField="fec_fin" HeaderText="Fecha de Fin" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    <p>
        &nbsp;</p>
</asp:Content>
