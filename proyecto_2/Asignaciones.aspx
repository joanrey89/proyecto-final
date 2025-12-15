<%@ Page Language="C#" AutoEventWireup="true"CodeFile="Asignaciones.aspx.cs"Inherits="Asignaciones" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Asignaciones</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>Asignar Técnico</h2>

    Reparación:
    <asp:TextBox ID="txtReparacion" runat="server" />
    <br /><br />

    Técnico:
    <asp:TextBox ID="txtTecnico" runat="server" />
    <br /><br />

    <asp:Button ID="btnAsignar" runat="server"
        Text="Asignar"
        OnClick="btnAsignar_Click" />

    <hr />

    <asp:GridView ID="gvAsignaciones" runat="server" AutoGenerateColumns="true" />

</form>
</body>
</html>
