<%@ Page Title="" Language="C#" MasterPageFile="~/Registros/MPRegistros.master" AutoEventWireup="true" CodeBehind="Cotizacion.aspx.cs" Inherits="WEB.Registros.OrdenCompra" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table>
                     <caption>
                       <h2 class="tituloForm" style="width: 783px">
                            Registro de Cotización </h2>
                      </caption>

                    
            <tr>
                <td class="auto-style16" style="width: 171px">
                    Seleccione Proyecto:</td>
                <td class="auto-style15" colspan="2">
                    <asp:DropDownList ID="cboProyecto" runat="server"  Width="192px">
                    </asp:DropDownList>
                </td>
            </tr>

                    <tr>
                <td class="auto-style16" style="width: 171px">
                    Seleccione Encargado:</td>
                <td class="auto-style15" colspan="2">
                    <asp:DropDownList ID="cboEncargado" runat="server"  Width="192px">
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td class="auto-style16" style="width: 171px">
                     Aprobado por:</td>
                <td class="auto-style15" colspan="2">
                    <asp:DropDownList ID="cboAprobadoPor" runat="server"  Width="192px">
                    </asp:DropDownList>
                </td>
            </tr>

                <tr>
                <td class="auto-style16" style="width: 171px">
                    Enviar a:</td>
                <td class="auto-style15" colspan="2">
                    <asp:DropDownList ID="cboEnviar" runat="server"  Width="192px">
                    </asp:DropDownList>
                </td>
            </tr>

                    <tr>
                <td class="labelContenido" style="width: 171px">
                    Ingrese fecha Aprobación:</td>
                <td style="width: 100px; height: 21px" colspan="2">
                    <asp:TextBox ID="dtpAprobacion" runat="server" Width="96px"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="dtpAprobacion_CalendarExtender" runat="server" Enabled="True" TargetControlID="dtpAprobacion">
                    </ajaxToolkit:CalendarExtender>
                </td>
            </tr>

            <tr>
                <td class="labelContenido" style="height: 26px; width: 171px;">
                    Ingrese fecha Creación:</td>
                <td style="width: 100px; height: 26px;" colspan="2">
                    <asp:TextBox ID="dtpCreacion" runat="server" Width="96px"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="dtpCreacion_CalendarExtender" runat="server" Enabled="True" TargetControlID="dtpCreacion">
                    </ajaxToolkit:CalendarExtender>
                </td>
            </tr>

            <tr>
                <td class="labelContenido" style="height: 26px; width: 171px;">
                    Ingrese fecha Envio:</td>
                <td style="width: 100px; height: 26px;" colspan="2">
                    <asp:TextBox ID="dtpEnvio" runat="server" Width="96px"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="dtpEnvio_CalendarExtender" runat="server" Enabled="True" TargetControlID="dtpEnvio">
                    </ajaxToolkit:CalendarExtender>
                </td>
            </tr>

            <tr>
                    <td align="left" class="auto-style7" style="width: 171px">
                        Notas:
                    </td>
                    <td align="left" style="width: 601px">
                        <asp:TextBox ID="txtNotas" runat="server" Width="550px"></asp:TextBox>
                        &nbsp;</td>
            </tr>
                                <tr>
                    <td align="left" class="auto-style7" style="width: 171px">
                        Ubicacion:
                    </td>
                    <td align="left" style="width: 601px">
                        <asp:TextBox ID="txtPath" runat="server" Width="298px"></asp:TextBox>
                        &nbsp;</td>
            </tr>


            <tr>
                <td class="auto-style13" style="height: 23px; width: 171px">
                    </td>
                <td style="width: 100px; height: 23px;" colspan="2">
                    </td>
            </tr>

            <tr>
                <td class="auto-style20" style="width: 171px">
                    <asp:Button ID="btnAgregarDetalleCotizacion" runat="server" Text="Agregar Detalle" Width="182px" OnClick="btnAgregar_Click" />
                </td>
                <td style="width: 601px">
                    <asp:Button ID="btnGrabarCotizacion" runat="server" onclick="btnGrabarCotizacion_Click" Text="Grabar" Width="171px" />
                </td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>

             <tr>
                <td colspan="3">
                    &nbsp;<asp:GridView ID="grDetalles" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical"  Width="936px" ShowHeaderWhenEmpty="True">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Image" CommandName="Eliminar" ImageUrl="~/imagenes/Cancelar.png" Text="Eliminar" />
                            <asp:BoundField DataField="nom_item" HeaderText="Articulo" />
                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                            <asp:BoundField DataField="descuento" HeaderText="Descuento" />
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
                <td class="auto-style13" style="width: 171px">
                    &nbsp;</td>
                <td style="width: 700px" colspan="2">
                    &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    </td>
            </tr>

            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" NavigateUrl="~/Registros/MPRegistros.master">Retornar Menu </asp:HyperLink>
                </td>
            </tr>

                 </table>
    
            <%-- Aqui va el popup de Detalle con su codigo--%>
            <%--el link button o cualquiero otro control para el manejo del modal--%>
           <asp:LinkButton Text="" ID = "btnPopupDetalle" runat="server" />

             <%--El modalpoput extender : vease el TargetControl que apunta al linkbutton y el popuconttol ID que apunhta al panel--%> 
             <ajaxToolkit:ModalPopupExtender ID="PopDetalle" runat="server" BackgroundCssClass="FondoAplicacion"  
             TargetControlID="btnPopupDetalle" PopupControlID="PanelDetalle"  >
            </ajaxToolkit:ModalPopupExtender>

                <asp:Panel ID="PanelDetalle" runat="server" CssClass="auto-style19" align="center" Style="display:table; background-color: white;" Width="403px">
          
            <table style="border: Solid 3px cadetblue;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkcyan">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Registrar Detalle
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style5" style="width: 186px" >
                        </td>
                      <td align="left" class="auto-style6">
                          </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style17" style="width: 186px">Seleccione Producto:</td>
                    <td align="left" class="auto-style18">
                        <asp:DropDownList ID="cboProducto" runat="server"  Width="192px" CssClass="DropDownList">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style7" style="width: 186px">
                        Cantidad Pedida:
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtCantidad" runat="server" Width="70px"></asp:TextBox>
                        <ajaxToolkit:FilteredTextBoxExtender ID="txtCantidad_FilteredTextBoxExtender" runat="server" BehaviorID="txtCantidad_FilteredTextBoxExtender" FilterType="Numbers" TargetControlID="txtCantidad" />
                        &nbsp;</td>
                </tr>

                <tr>
                    <td align="right" class="auto-style7" style="width: 186px">
                        Descuento:
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtDescuento" runat="server" Width="96px"></asp:TextBox>
                        <ajaxToolkit:FilteredTextBoxExtender ID="txtDescuento_FilteredTextBoxExtender" runat="server" BehaviorID="txtDescuento_FilteredTextBoxExtender" FilterType="Numbers" TargetControlID="txtDescuento" />
                        &nbsp;</td>
                </tr>

                <tr>
                    <td colspan="2" class="auto-style9">
                        <asp:Label ID="lblMensajeDetalle" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                    </td>
                </tr>
               
                     <tr>
                         <td class="auto-style8" style="width: 186px">
                             &nbsp;</td>
                         <td class="auto-style8">
                             &nbsp;</td>
                </tr>
              
                <tr>
                    <td class="auto-style22" style="text-align: center; width: 186px;">
                        <asp:Button ID="btnGrabarDetalle" runat="server"  Text="Grabar" Width="100px" CssClass="boton2" OnClick="btnGrabarDetalle_Click" />
                    </td>
                    <td class="auto-style22" style="text-align: center">
                        <asp:Button ID="btnCancelarDetalle" runat="server" Text="Cancelar" Width="100px" CssClass="boton-new" OnClick="btnCancelarDetalle_Click" />
                    </td>
                </tr>
              
            </table>
                        
        </asp:Panel>


        <%--Este es el panel  que contiene los mensajes de error--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
               <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />

        <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0 " width="500px" style="margin: 0px; padding: 0px; background-color:darkcyan ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center" class="auto-style11" > 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="auto-style11"> 
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table> 
                    <div> 
                        <asp:Label ID="lblMensaje" runat="server" ForeColor ="Black" /> 
                    </div> 
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="boton-new" OnClick="btnCancelarDetalle_Click" /> 
                    </div> 
                </asp:Panel> 



            </ContentTemplate>
            

            </asp:UpdatePanel>

</asp:Content>
