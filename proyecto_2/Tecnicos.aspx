<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tecnicos.aspx.cs" Inherits="Tecnicos" %>

<form runat="server">
<h2>🔧 Técnicos</h2>

<asp:GridView ID="gvTecnicos" runat="server" AutoGenerateColumns="false"
    DataKeyNames="TecnicoID" OnRowDeleting="gvTecnicos_RowDeleting">
    <Columns>
        <asp:BoundField DataField="TecnicoID" HeaderText="ID" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
        <asp:CommandField ShowDeleteButton="true" />
    </Columns>
</asp:GridView>

<h3>➕ Nuevo Técnico</h3>
Nombre: <asp:TextBox ID="txtNombre" runat="server" /><br />
Especialidad: <asp:TextBox ID="txtEspecialidad" runat="server" /><br />
<asp:Button Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
</form>
