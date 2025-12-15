<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Usuarios.aspx.cs" Inherits="Usuarios" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gestión de Usuarios</title>
</head>
<body>
<form runat="server">

<h2>👥 Gestión de Usuarios</h2>

<asp:GridView ID="gvUsuarios" runat="server"
    AutoGenerateColumns="false"
    DataKeyNames="UsuarioID"
    OnRowEditing="gvUsuarios_RowEditing"
    OnRowDeleting="gvUsuarios_RowDeleting">
    
    <Columns>
        <asp:BoundField DataField="UsuarioID" HeaderText="ID" ReadOnly="true" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo" />
        <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
        <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
    </Columns>
</asp:GridView>

<h3>➕ Nuevo Usuario</h3>

Nombre:
<asp:TextBox ID="txtNombre" runat="server" /><br />
Correo:
<asp:TextBox ID="txtCorreo" runat="server" /><br />
Teléfono:
<asp:TextBox ID="txtTelefono" runat="server" /><br />
Clave:
<asp:TextBox ID="txtClave" runat="server" TextMode="Password" /><br />

<asp:Button ID="btnAgregar" runat="server" Text="Agregar"
    OnClick="btnAgregar_Click" />

</form>
</body>
</html>
