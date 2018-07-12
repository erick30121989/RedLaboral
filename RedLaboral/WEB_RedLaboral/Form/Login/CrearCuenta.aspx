<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrearCuenta.aspx.cs" Inherits="Form_Login_CrearCuenta" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css?family=Play:400,700" rel="stylesheet" type="text/css" /><link href="Content/StyleSheet.css" rel="stylesheet" />

    <style type="text/css">

        *{
            margin:0px;
            padding:0px;
            font-family: 'Play', sans-serif;
        }
        .auto-style1 {
            width: 100%;
        }

        .fondo_oscuro
        {

               background-color: rgba(15, 15, 15, 0.50);
        }
        .auto-style2 {
            width: 164px;
        }
        .auto-style3 {
            width: 163px;
        }
        .auto-style4 {
            width: 142px;
        }
        .auto-style6 {
            width: 64px;
        }
        .auto-style7 {
            height: 25px;
        }
        .auto-style9 {
            height: 25px;
            width: 231px;
        }
        .auto-style10 {
            width: 231px;
        }
        .auto-style11 {
            height: 26px;
        }
        .auto-style13 {
            height: 26px;
            width: 230px;
        }
                header {
            color:white;
            background-color:#3957ab;
            font-family: 'Play', sans-serif;
            padding:20px 20px;
        }

        .auto-style15 {
            width: 230px;
        }
        .auto-style16 {
            height: 25px;
            width: 230px;
        }
        .auto-style17 {
            width: 226px;
        }
        .auto-style18 {
            height: 25px;
            width: 226px;
        }

    </style>
</head>
<body>
    
    
          <header>
            <h1  style="width:100%; height:40px; background-color:#3957ab">Red Laboral
              </h1>
        </header>              

    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">

            <ContentTemplate>

    
        <!-- Panel Cuenta de persona -->
        <asp:Panel ID="Panel2" runat="server">





        <table class="auto-style1">
            <tr>
                <td colspan="7">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Datos Personales"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">*Nombres:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">*Apellido Paterno:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">*Apellido Materno:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">*Dni:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">*Fecha Nacimiento:</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
                    <cc1:CalendarExtender ID="TextBox5_CalendarExtender" runat="server" BehaviorID="TextBox5_CalendarExtender" TargetControlID="TextBox5" Format="yyyy-MM-dd" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">Telefono:</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">Celular:</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">*Correo Electronico:</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">Direccion:</td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">*Departamento:</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style17">*Provincia:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">*Distrito:</td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="200px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Crear Contraseña"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">Contraseña:</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">Repetir Contraseña:</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Button ID="Button4" runat="server" Text="Grabar" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Regresar" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

        </asp:Panel>
        <!-- Fin Panel Cuenta de persona  -->


        <!-- Panel Cuenta de Empresa -->
        <asp:Panel ID="Panel3" runat="server">
         
            <table class="auto-style1">
                <tr>
                    <td colspan="7">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Datos Empresa"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">*Razon Social:</td>
                    <td>
                        <asp:TextBox ID="TextBox12" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">*Ruc:</td>
                    <td>
                        <asp:TextBox ID="TextBox13" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">*Correo Electronico:</td>
                    <td>
                        <asp:TextBox ID="TextBox14" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style15">*Departamento:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList4" runat="server" Width="200px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">*Provincia:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList5" runat="server" Width="200px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">*Distrito:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList6" runat="server" Width="200px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Crear Contraseña"></asp:Label>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style15">Contraseña:</td>
                    <td>
                        <asp:TextBox ID="TextBox15" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">Repetir Contraseña:</td>
                    <td>
                        <asp:TextBox ID="TextBox16" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Button ID="Button5" runat="server" Text="Grabar" />
                    </td>
                    <td>
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Regresar" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        
        </asp:Panel>

    
    <asp:Panel ID="Panel1" runat="server" BackColor="white" Width="600">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="X" />
            </td>
        </tr>
        <tr>
            <td colspan="6" style="text-align:center;">
                <asp:Label ID="Label1" runat="server" Text="Elija una opcion"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6" >
                <asp:Button ID="Button2" runat="server" Text="Persona"  style="margin:auto;display:block;" OnClick="Button2_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="6" >
                <asp:Button ID="Button3" runat="server" Text="Empresa" style="margin:auto;display:block;" OnClick="Button3_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    </asp:Panel>




    <cc1:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1" TargetControlID="lbl_control_pu" BackgroundCssClass="fondo_oscuro">
    </cc1:ModalPopupExtender>

        <asp:Label ID="lbl_control_pu" runat="server" Text=""></asp:Label>

            </ContentTemplate>

        </asp:UpdatePanel>

    </form>
</body>
</html>
