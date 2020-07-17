<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB.Login" %>

<!DOCTYPE html>
<!--
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

        #ventanaLogin {
    display: flex;
    position: relative;
    margin: auto;
    padding-top: 30px;
}
    </style>
</head>
<body style="width: 600px;">
    <form id="form1" runat="server" style="display: flex; position: relative;">
        
        <div id="ventanaLogin"  style="" >
            <table style="border: Solid 3px #1a79ca; background-color:#e6e0e3; "
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
                         <td class="auto-style7" align="center">
                        <img src="imagenes/logo.jpg" alt="Girl in a jacket" width="100" height="70" >

                             </td>
                         
                </tr>
                
                <tr>

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
                             <asp:Label ID="lblMensaje2" runat="server"></asp:Label>
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
-->
<html>

<head>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/css/materialize.min.css">
    <style>
        body {
            display: flex;
            min-height: 100vh;
            flex-direction: column;
        }
        
        main {
            flex: 1 0 auto;
        }
        
        body {
            background: #fff;
        }
        
        .input-field input[type=date]:focus+label,
        .input-field input[type=text]:focus+label,
        .input-field input[type=email]:focus+label,
        .input-field input[type=password]:focus+label {
            color: #e91e63;
        }
        
        .input-field input[type=date]:focus,
        .input-field input[type=text]:focus,
        .input-field input[type=email]:focus,
        .input-field input[type=password]:focus {
            border-bottom: 2px solid #e91e63;
            box-shadow: none;
        }
    </style>
</head>

<body>
    <div class="section"></div>
    <main>
        <center>


            <h5 class="indigo-text">G R U B A L </h5>
            <div class="section"></div>

            <div class="container">
                <div class="z-depth-1 grey lighten-4 row" style="display: inline-block; padding: 32px 48px 0px 48px; border: 1px solid #EEE;">

                    <form class="col s12" method="post">
                        <div class='row'>
                            <div class='col s12'>
                            </div>
                        </div>

                        <div class='row'>
                            <div class='input-field col s12'>
                                <input class='validate' type='email' name='email' id='email' />
                                <label for='email'>Usuario</label>
                            </div>
                        </div>

                        <div class='row'>
                            <div class='input-field col s12'>
                                <input class='validate' type='password' name='password' id='password' />
                                <label for='password'>Contraseña</label>
                            </div>
                            <label style='float: right;'>
								<a style="color:#f5f5f5" href='#'><b>Forgot Password?</b></a>
							</label>
                        </div>
                        <br />

                        <div>
                             <td class="auto-style7">
                             <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                             </td>
                         
                         </div>

                        <br />
                        <center>
                            <div class='row'>
                                <button type='submit' name='btn_login' class='col s12 btn btn-large waves-effect indigo'>Login</button>
                            </div>
                        </center>
                    </form>
                </div>
            </div>
        </center>

        <div class="section"></div>
        <div class="section"></div>
    </main>

    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.1/jquery.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/js/materialize.min.js"></script>
</body>

</html>