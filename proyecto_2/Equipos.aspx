<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Equipos.aspx.cs" Inherits="Equipos" %>

<form runat="server">
<h2>💻 Equipos</h2>

<asp:GridView ID="gvEquipos" runat="server" AutoGenerateColumns="false"
    DataKeyNames="EquipoID" OnRowDeleting="gvEquipos_RowDeleting">
    <Columns>
        <asp:BoundField DataField="EquipoID" HeaderText="ID" />
        <asp:BoundField DataField="NombreEquipo" HeaderText="Equipo" />
        <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
        <asp:CommandField ShowDeleteButton="true" />
    </Columns>
</asp:GridView>

<h3>➕ Nuevo Equipo</h3>
Nombre equipo:
<asp:TextBox ID="txtEquipo" runat="server" /><br />
Usuario:
<asp:DropDownList ID="ddlUsuarios" runat="server" /><br />
<asp:Button Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
</form>
