<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Sistema_de_Farmacia.Administrador" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="styles.css" type="text/css" />
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css" />
    <title>Administracion</title>
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
                    <li>&nbsp; <a href="Administrador.aspx" style="font-family: Arial; font-size: 16px">Usuarios</a></li>
                    <li>&nbsp; <a href="Categoria.aspx" style="font-family: Arial; font-size: 16px">Categoria</a></li>
                     <li>&nbsp; <a href="Proveedores.aspx" style="font-family: Arial; font-size: 16px">Proveedores</a></li>
                    <li>
                        <asp:Button ID="Button1" runat="server" Text="Cerrar sesion" OnClick="Button1_Click1" margin-left="none" outline="none" BackColor="#222833" BorderColor="#222833" ForeColor="White" BorderStyle="None" Font-Names="Arial" Font-Size="16px" Width="105px" />
                    </li>
                   
                </ul>
            </nav>

            <div class="container">
                <h2>USUARIOS</h2>
                 <div class="container-table">
                    <div class="acciones">
                        <asp:Button ID="btnNuevo" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Nuevo" OnClick="btnNuevo_Click" />

                        <div>

                            <asp:Button ID="btnBuscar" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Buscar" OnClick="btnBuscarClick" />
                            <asp:TextBox ID="txtBuscar" runat="server" Width="121px"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div style="margin: 20px">
                        <div style="width: 100%; height: 350px; overflow: scroll">
                            <asp:GridView ID="GridViewAdmin" runat="server" AutoGenerateColumns="False" DataKeyNames="usuarioId" DataSourceID="SqlDataSourceAdmin" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:CommandField ShowEditButton="True" />
                                    <asp:BoundField DataField="usuarioId" HeaderText="usuarioId" InsertVisible="False" ReadOnly="True" SortExpression="usuarioId"></asp:BoundField>
                                    <asp:BoundField DataField="cedula" HeaderText="cedula" SortExpression="cedula"></asp:BoundField>
                                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre"></asp:BoundField>
                                    <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido"></asp:BoundField>
                                    <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono"></asp:BoundField>
                                    <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado"></asp:BoundField>
                                    <asp:BoundField DataField="mail" HeaderText="mail" SortExpression="mail"></asp:BoundField>
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSourceAdmin" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" DeleteCommand="DELETE FROM [usuario] WHERE [usuarioId] = @usuarioId" InsertCommand="INSERT INTO [usuario] ([cedula], [nombre], [apellido], [telefono], [estado], [mail]) VALUES (@cedula, @nombre, @apellido, @telefono, @estado, @mail)" SelectCommand="SELECT [usuarioId], [cedula], [nombre], [apellido], [telefono], [estado], [mail] FROM [usuario]" UpdateCommand="UPDATE [usuario] SET [cedula] = @cedula, [nombre] = @nombre, [apellido] = @apellido, [telefono] = @telefono, [estado] = @estado, [mail] = @mail WHERE [usuarioId] = @usuarioId">
                                <DeleteParameters>
                                    <asp:Parameter Name="usuarioId" Type="Int32" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="cedula" Type="String" />
                                    <asp:Parameter Name="nombre" Type="String" />
                                    <asp:Parameter Name="apellido" Type="String" />
                                    <asp:Parameter Name="telefono" Type="String" />
                                    <asp:Parameter Name="estado" Type="String" />
                                    <asp:Parameter Name="mail" Type="String" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="cedula" Type="String" />
                                    <asp:Parameter Name="nombre" Type="String" />
                                    <asp:Parameter Name="apellido" Type="String" />
                                    <asp:Parameter Name="telefono" Type="String" />
                                    <asp:Parameter Name="estado" Type="String" />
                                    <asp:Parameter Name="mail" Type="String" />
                                    <asp:Parameter Name="usuarioId" Type="Int32" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
                        </div>
                    </div>
                </div>
            </div>
        </main>
    </form>
</body>
</html>
