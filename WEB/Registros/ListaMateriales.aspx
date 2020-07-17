<%@ Page Title="" Language="C#" MasterPageFile="~/Registros/MPRegistros.master" AutoEventWireup="true" CodeBehind="ListaMateriales.aspx.cs" Inherits="WEB.Registros.Materiales" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register
    Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <caption>
                    <h2 class="tituloForm" style="width: 783px">Registro de Lista de Materiales</h2>
                </caption>


                <tr>
                    <td class="auto-style16" style="width: 189px">Seleccione Proyecto:</td>
                    <td class="auto-style15" colspan="2">
                        <asp:DropDownList ID="cboProyecto" runat="server" Width="192px">
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style16" style="width: 189px; height: 26px;">Pedido por:</td>
                    <td class="auto-style15" colspan="2" style="height: 26px">
                        <asp:DropDownList ID="cboPedidoPor" runat="server" Width="192px">
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style16" style="width: 189px; height: 26px;">Ingresado por:</td>
                    <td class="auto-style15" colspan="2" style="height: 26px">
                        <asp:DropDownList ID="cboIngresadoPor" runat="server" Width="192px">
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style16" style="width: 189px">Aprobado por:</td>
                    <td class="auto-style15" colspan="2">
                        <asp:DropDownList ID="cboAprobado" runat="server" Width="192px">
                        </asp:DropDownList>
                    </td>
                </tr>


                <tr>
                    <td class="labelContenido" style="width: 189px">Ingrese fecha Creacion:</td>
                    <td style="width: 100px; height: 21px" colspan="2">
                        <asp:TextBox ID="dtpCreacion" runat="server" Width="96px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="dtpCreacion_CalendarExtender" runat="server" Enabled="True" TargetControlID="dtpCreacion"></ajaxToolkit:CalendarExtender>
                    </td>
                </tr>

                <tr>
                    <td class="labelContenido" style="height: 26px; width: 189px;">Ingrese fecha Aprobacion:</td>
                    <td style="width: 100px; height: 26px;" colspan="2">
                        <asp:TextBox ID="dtpAprobacion" runat="server" Width="96px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="dtpAprobacion_CalendarExtender" runat="server" Enabled="True" TargetControlID="dtpAprobacion"></ajaxToolkit:CalendarExtender>
                    </td>
                </tr>

                <tr>
                    <td align="left" class="auto-style7" style="width: 189px">Notas:
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtNotas" runat="server" Width="600px" Style="margin-left: 0px"></asp:TextBox>
                        &nbsp;</td>
                </tr>


                <tr>
                    <td class="auto-style13" style="width: 189px">&nbsp;</td>
                    <td style="width: 100px" colspan="2">&nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style20" style="width: 189px">
                        <asp:Button ID="btnAgregar" runat="server" CssClass="boton2" Text="Agregar Detalle" Width="150px" OnClick="btnAgregar_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="btnGrabar" runat="server" CssClass="boton2" Text="Grabar" Width="150px" OnClick="btnGrabar_Click" />
                        <ajaxToolkit:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" BehaviorID="btnGrabar_ConfirmButtonExtender" ConfirmText="Seguro de grabar?" TargetControlID="btnGrabar" />
                    </td>
                    <td class="auto-style21">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td colspan="3">&nbsp;<asp:GridView ID="grDetalles" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="936px" ShowHeaderWhenEmpty="True" OnRowCommand="grDetalles_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Image" CommandName="Eliminar" ImageUrl="~/imagenes/Cancelar.png" Text="Eliminar" />
                            <asp:BoundField DataField="id_item" HeaderText="Articulo" />
                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
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
                    </td>
                </tr>


                <tr>
                    <td class="auto-style13" style="width: 189px; height: 23px;"></td>
                    <td style="width: 700px; height: 23px;" colspan="2">&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td style="height: 23px"></td>
                </tr>

                <tr>
                    <td colspan="3">
                        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" NavigateUrl="~/Registros/MPRegistros.master">Retornar Menu </asp:HyperLink>
                    </td>
                </tr>

            </table>

            <%-- Aqui va el popup de Detalle con su codigo--%>
            <%--el link button o cualquiero otro control para el manejo del modal--%>
            <asp:LinkButton Text="" ID="btnPopupDetalle" runat="server" />

            <%--El modalpoput extender : vease el TargetControl que apunta al linkbutton y el popuconttol ID que apunhta al panel--%>
            <ajaxToolkit:ModalPopupExtender ID="PopDetalle" runat="server" BackgroundCssClass="FondoAplicacion"
                TargetControlID="btnPopupDetalle" PopupControlID="PanelDetalle">
            </ajaxToolkit:ModalPopupExtender>

            <asp:Panel ID="PanelDetalle" runat="server" CssClass="auto-style19" align="center" Style="display: table" Width="403px">

                <table style="border: Solid 3px #D55500;"
                    cellpadding="0" cellspacing="0">
                    <tr style="background-color: darkred">
                        <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                            align="center">Registrar Detalle
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="auto-style5"></td>
                        <td align="left" class="auto-style6"></td>
                    </tr>
                    <tr>
                        <td align="right" class="auto-style17">Seleccione Producto:</td>
                        <td align="left" class="auto-style18">
                            <asp:DropDownList ID="cboProducto" runat="server" Width="192px" CssClass="DropDownList">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="auto-style7" style="height: 26px">Cantidad Pedida:
                        </td>
                        <td align="left" class="auto-style8" style="height: 26px">
                            <asp:TextBox ID="txtCantidad" runat="server" Width="70px"></asp:TextBox>
                            &nbsp;</td>
                    </tr>

                    <tr>
                        <td colspan="2" class="auto-style9">
                            <asp:Label ID="lblMensajeDetalle" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style8">&nbsp;</td>
                        <td class="auto-style8">&nbsp;</td>
                    </tr>

                    <tr>
                        <td class="auto-style22">
                            <asp:Button ID="btnGrabarDetalle" runat="server" Text="Grabar" Width="100px" CssClass="boton2" OnClick="btnGrabarDetalle_Click" />
                        </td>
                        <td class="auto-style22">
                            <asp:Button ID="btnCancelarDetalle" runat="server" Text="Cancelar" Width="100px" CssClass="boton-new" OnClick="btnCancelarDetalle_Click" />
                        </td>
                    </tr>

                </table>

            </asp:Panel>


            <%--Este es el panel  que contiene los mensajes de error--%>
            <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>
            <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje"
                PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" />

            <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500">
                <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color: darkred; color: #FFFFFF;">
                    <tr>
                        <td align="center" class="auto-style11">
                            <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                        </td>
                        <td width="12%" class="auto-style11">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/Cancelar.png" Style="vertical-align: top;"
                                ImageAlign="Right" />
                        </td>
                    </tr>

                </table>
                <div>
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="Black" />
                </div>
                <div>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="boton-new" OnClick="btnAceptar_Click" />
                </div>
            </asp:Panel>



        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
