<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">

        #ventanaLogin{
        }

        .lblUsuario{

        }

        .auto-style1 {
            width: 473px;
        }
        .auto-style7 {
            width: 473px;
            height: 25px;
        }
        .auto-style8 {
            height: 10%;
            width: 473px;
        }
        .btnIngresar {
            width: 473px;
            height: 73px;
        }
        .auto-style9 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div id="ventanaLogin">
            <table style="border: Solid 3px #1a79ca; background-color:#e6e0e3"
                cellpadding="0" cellspacing="0" border="0"  >


                <tr style="background-color: #1a79ca">
                    <td colspan="2" style="color: White; font-weight: bold; font-size: larger"
                        align="center" class="auto-style8">
                        INGRESAR
                    </td>
                </tr>

                 <tr>
                         <td class="auto-style7">
                             </td>
                         
                </tr>

                <tr>
                    
                      <td align="center" class="lblUsuario"  style="font-weight: bold; font-family:'Meiryo UI'">
                          Usuario:
                          </td>
                </tr>
                
                <tr>
                    
                    <td align="center" class="auto-style1">
                        <asp:TextBox ID="txtUsuario" runat="server" Width="200px" Height="30px" CssClass="auto-style9"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                        
                         <td class="auto-style7">
                             </td>
                </tr>
                <tr>
                         
                         <td align="center" class="password" style="font-weight: bold; font-family:'Meiryo UI'" >
                             Password: 

                             &nbsp;</td>
                </tr>

                <tr>
                    
                    <td align="center" class="txtPassword">
                        <asp:TextBox ID="txtPassword" runat="server" Width="200px" Height="30px" TextMode="Password">*</asp:TextBox>
                        &nbsp;</td>
                </tr>

               
               
                <tr>
                         <td class="auto-style7">
                             <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                             </td>
                         
                </tr>
              
                <tr>
                    
                    <td class="btnIngresar" align="center">
                        <asp:Button ID="btnIngresar" runat="server"  Text="Iniciar Sesión" Width="300px" Height="40px" CssClass="boton2" OnClick="btnIngresar_Click" />
                    </td>
                </tr>
              
            </table>
        </div>
    </form>
</body>
</html>
