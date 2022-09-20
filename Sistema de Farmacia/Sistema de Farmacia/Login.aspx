<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_de_Farmacia.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css" />
    <style type="text/css">
        </style>
    <link rel="stylesheet" href="styles.css" type="text/css" />
</head>

<body>
    <asp:Panel  ID="PanelFondo" runat="server" CssClass="wrapper">
        <asp:Panel ID="Panel1" runat="server" CssClass="wrapper-content">
            <h1 style="color: white">SISTEMA WEB DE FARMACIA </h1>
            <form id="form1" runat="server">
                <h2><i class="uil uil-user"></i>INICIAR SESION</h2>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="input" placeholder="Email"></asp:TextBox>
                <asp:TextBox ID="txtPass" runat="server" CssClass="input" OnTextChanged="TextBox3_TextChanged" placeholder="Contraseña" MaxLength="8" TextMode="Password"></asp:TextBox>
                <asp:Panel CssClass="grid" runat="server">
                    <asp:CheckBox ID="CBRecordarContraseña" runat="server" OnCheckedChanged="CBRecordarContraseña_CheckedChanged" Text="Recordar Contraseña" CssClass="checked" />
                    <asp:Button ID="Button1" runat="server" Text="Verificar" CssClass="button" OnClick="Button1_Click" />
                </asp:Panel>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RecuperarContraseña.aspx">¿Olvidaste tu contraseña?</asp:HyperLink>
                <asp:Label ID="mensajeError" runat="server" Text=""></asp:Label>
            </form>
        </asp:Panel>
    </asp:Panel>
</body>
</html>
