<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Form_Login_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Red Laboral</title>
    <link href='https://fonts.googleapis.com/css?family=Play:400,700' rel='stylesheet' type='text/css'/>
    <link href="../../Css/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    
   <div id="container">

        <header id="header"><h1>Red Laboral</h1></header>

            <h2 style="text-align:center;margin-top:10%;position:absolute;margin-left:32%;font-size:48px; color:white; text-shadow:2px 4px 3px rgba(0,0,0,0.3);">Toda la información laboral <br />disponible en segundos.</h2>
           <%-- <form id="form1" runat="server">--%>
                <div id="form1">
    
                  
                      <input type="button" value="Empezar" ID="Button_Home""/>
    
                </div>
        <%--  </form>--%>

    </div>
        
    <div id="popup_box">
      

        <div id="popup_login">
              <h2>Bienvenidos</h2>
              <span id="btn_salir"><a href="#"> X</a></span>
            <form id="Form2" runat="server">
                <%-- <input type="text" placeholder="Correo"  class="texbox_1 texbox_popup"/><br />
                 <input type="password" placeholder="Contraseña" class="texbox_1 texbox_popup"/><br />
                 <input type="button" value="Ingresar" class="button_1 button_popup"/><br />
                 <input type="button" value="Registrarse" class="button_1 button_popup"/>--%>

                 <asp:TextBox ID="txt_correo" placeholder="Usuario"  runat="server" class="texbox_1 texbox_popup"></asp:TextBox><br />
                 <asp:TextBox ID="txt_contrasena" placeholder="Contraseña" runat="server" TextMode="Password" class="texbox_1 texbox_popup"></asp:TextBox><br />
                 <asp:Button ID="btn_ingresar" runat="server" Text="Ingresar" class="button_1 button_popup" OnClick="btn_ingresar_Click1"  /><br />
                 <asp:Button ID="btn_registrarse" runat="server" Text="Registrarse" class="button_1 button_popup" OnClick="btn_registrarse_Click1" />
                                 

            </form>

         </div>

    </div>       
    <script src="../../Js/jquery-1.11.1.min.js"></script>
     <script src="../../Js/jscode.js"></script>
</body>
</html>
