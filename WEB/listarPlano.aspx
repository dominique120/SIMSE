<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MPConsultas.master" AutoEventWireup="true" CodeBehind="listarPlano.aspx.cs" Inherits="WEB.Consultas.listarPlano" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h2>Listar Planos</h2>
    <table style="width: 70%">
        <tr>
            <td style="width: 151px">Seleccione el Proyecto:</td>
            <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 151px">Nombre de Plano: </td>
            <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="250px">
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 151px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Buscar" />
            </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="236px" Width="514px">
        <Columns>
            <asp:BoundField DataField="nom_proyecto" HeaderText="Nombre del Proyecto" />
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
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <br />
    <table style="width: 60%">
    </table>
    <p>&nbsp;</p>
</asp:Content>
