<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="ListarMateriales.aspx.cs" Inherits="WEB.Consultas.ListarMateriales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
        <div id="resultados">
    <h2>Listar Listas de Materiales</h2>
    <table style="width: 100%">
        <tr>
            <td style="width: 167px">Proyecto:</td>
            <td>
            <asp:DropDownList ID="cboProyecto" runat="server" Width="250px">
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 167px">&nbsp;</td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </td>
        </tr>
    </table>
    <p>
        <asp:GridView ID="grvListas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="288px" Width="709px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_documento" HeaderText="Id Documento" />
                <asp:BoundField DataField="fecha_pedida" DataFormatString="{0:d}" HeaderText="Fecha Pedida">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="fecha_aprobada" DataFormatString="{0:d}" HeaderText="Fecha Aprobada" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="aprobadoPor" HeaderText="Aprobado Por" />
                <asp:BoundField DataField="ingresadoPor" HeaderText="Ingresado Por" />
                <asp:BoundField DataField="aprobado" HeaderText="Aprobado" />
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
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
</div>
</asp:Content>
