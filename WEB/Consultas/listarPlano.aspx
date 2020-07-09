<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="listarPlano.aspx.cs" Inherits="WEB.Consultas.listarPlano" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
        <div id="resultados">
    <h2>Listar Planos</h2>
    <table style="width: 70%">
        <tr>
            <td style="width: 151px">Proyecto:</td>
            <td>
            <asp:DropDownList ID="cboProyecto" runat="server" Width="250px">
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 151px">Tipo de Plano: </td>
            <td>
            <asp:DropDownList ID="cboTipoPlano" runat="server" Width="250px">
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 151px">&nbsp;</td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="grvPlanos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Height="236px" Width="858px" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_documento" HeaderText="Id Documento" />
            <asp:BoundField DataField="revision" HeaderText="Revision" />
            <asp:BoundField DataField="nom_plano" HeaderText="Nombre de Plano" />
            <asp:BoundField DataField="nom_tipo_plano" HeaderText="Tipo de Plano" />
            <asp:BoundField DataField="fecha_creacion" DataFormatString="{0:d}" HeaderText="Fecha de creacion">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="fecha_revision" DataFormatString="{0:d}" HeaderText="Fecha de revision">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="fecha_envio" DataFormatString="{0:d}" HeaderText="Fecha de envio">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="dibujadoPor" HeaderText="Dibujado Por" />
            <asp:BoundField DataField="revisadoPor" HeaderText="Revisado Por" />
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
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
</div>
</asp:Content>
