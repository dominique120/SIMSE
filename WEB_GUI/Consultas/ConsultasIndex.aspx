<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultasIndex.aspx.cs" Inherits="WEB_GUI.Consultas.ConsultasIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: #CC0000">CONSULTAS DE LA EMPRESA GRUBAL</span></p>
    <table style="width: 70%">
        <tr>
            <td style="height: 24px; width: 437px">
                <asp:Image ID="Image1" runat="server" Height="218px" ImageUrl="~/Images/grubal.jpg" Width="433px" />
            </td>
            <td style="height: 24px">
                <asp:TreeView ID="TreeView1" runat="server" Height="82px" ImageSet="BulletedList3" ShowExpandCollapse="False">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Listar Proyecto" Value="Listar Proyecto"></asp:TreeNode>
                        <asp:TreeNode Text="Listar Tipo de Planos" Value="Listar Tipo de Planos"></asp:TreeNode>
                        <asp:TreeNode Text="Listar Cliente" Value="Listar Cliente"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>
