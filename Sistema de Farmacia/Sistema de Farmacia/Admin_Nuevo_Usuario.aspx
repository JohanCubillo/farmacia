<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Nuevo_Usuario.aspx.cs" Inherits="Sistema_de_Farmacia.Administracion_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="styles.css" type="text/css" />
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css" />
    <title>Administracion Nuevo Usuario</title>
    <style type="text/css">
        .auto-style1 {
            width: 471px;
            text-align: left;
        }

        .Estilo {
            font-size: 15px;
            color: red;
        }

        .auto-style2 {
            width: 471px;
            text-align: left;
            height: 23px;
        }

        .auto-style4 {
            width: 471px;
            text-align: left;
            height: 93px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <main>
            <header>
                <h1>Sistema Web de Farmacia</h1>
                <button class="btn-header"><i class="uil uil-user-circle"></i></button>

            </header>
            <nav>
                <div class="info-user">
                    <button class="btn-info"><i class="uil uil-user-circle"></i></button>
                    <div class="info">
                        <h3>
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre de usuario"></asp:Label>

                        </h3>
                        <h4>Administrador</h4>
                    </div>



                </div>
                <ul>
                    <li><a href="Administrador.aspx" style="font-family: Arial; font-size: 16px">Usuarios</a></li>
                  
                </ul>
            </nav>
            <div class="container">
                <h2>NUEVO USUARIO</h2>
                <h2 class="Estilo">TODOS LOS CAMPOS SON OBLIGATORIOS</h2>



                <div class="container-table">

                    <table>

                        <tr>
                            <td class="auto-style2">Identificación</td>
                            <td class="auto-style2">Contraseña</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtId" runat="server" Width="180px"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtId" ErrorMessage="Ingrese un ID Valido" ValidationExpression="\d{1}-\d{4}-\d{4}" ForeColor="Red">*</asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="ValidaciónID" runat="server" ControlToValidate="txtId" ErrorMessage="Debe ingresar un Nombre" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtContrasena" runat="server" Width="179px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="validacionContrasena" runat="server" ControlToValidate="txtContrasena" ErrorMessage="Este campo es requerido" ForeColor="#FF3300"> *</asp:RequiredFieldValidator>
                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style1">Nombres</td>
                            <td class="auto-style1">Apellidos</td>
                        </tr>

                        <tr>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtNombres" runat="server" Width="180px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ValidacionName" runat="server" ControlToValidate="txtNombres" ErrorMessage="Debe ingresar un Nombre" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtApellidos" runat="server" Width="180px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ValidacionApellido" runat="server" ControlToValidate="txtApellidos" ErrorMessage="Debe ingresar apellidos" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Telefono</td>
                            <td class="auto-style1">Email</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtTelefono" runat="server" Width="180px"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Ingrese un Telefono Valido" ValidationExpression="\d{4}-\d{4}" ForeColor="Red">*</asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="ValidacionCel" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Debe ingresar un numero de celular" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtEmail" runat="server" Width="180px"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingrese un correo Valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red">*</asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="Validacioncorreo" runat="server" ControlToValidate="txtEmail" ErrorMessage="Debe ingresar el correo" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Tipo de Usuario</td>
                            <td class="auto-style1">Estado</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:ListBox ID="ListBoxTU" runat="server" Width="180px" CausesValidation="True" ValidationGroup="X">
                                    <asp:ListItem>Usuario</asp:ListItem>
                                    <asp:ListItem>Dependiente</asp:ListItem>
                                    <asp:ListItem>Cajero</asp:ListItem>
                                   
                                </asp:ListBox>
                                <asp:RequiredFieldValidator ID="ValidacionTU" runat="server" ControlToValidate="ListBoxTU" ErrorMessage="Debe seleccionar un Tipo de usuario" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style4">
                                <asp:ListBox ID="ListBoxE" runat="server" Width="180px" CausesValidation="True" ValidationGroup="Y">
                                    <asp:ListItem>Inactivo</asp:ListItem>
                                    <asp:ListItem>Activo</asp:ListItem>
                                    
                                </asp:ListBox>
                                <asp:RequiredFieldValidator ID="ValidacionE" runat="server" ControlToValidate="ListBoxE" ErrorMessage="Debe seleccionar un estado" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="2" style="text-align: center" rowspan="1">
                                <asp:Button ID="btnCrear" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Crear" OnClick="btnCrear_Click" BorderColor="#5B639C" />
                                <asp:Button ID="btnLimpiar" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Limpiar" OnClick="btnLimpiar_Click" BorderColor="#5B639C" />
                                <asp:Button ID="btnCerrar" runat="server" BackColor="Red" ForeColor="White" Width="80px" Height="30PX" Text="Cerrar" OnClick="btnCerrar_Click" BorderColor="Red" />
                                 <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" />
                            </td>
                        </tr>

                    </table>
                </div>
            </div>
        </main>
    </form>
</body>
</html>

