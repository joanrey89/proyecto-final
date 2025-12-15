<%@ Page Language="C#" AutoEventWireup="true"CodeFile="Reparaciones.aspx.cs"Inherits="proyecto_2.Reparaciones" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reparaciones</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Gestión de Reparaciones</h2>

       
        <asp:GridView ID="gvReparaciones" runat="server"
            AutoGenerateColumns="False"
            OnRowCommand="gvReparaciones_RowCommand">

            <Columns>
                <asp:BoundField DataField="ReparacionID" HeaderText="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />

                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>

                        <asp:Button ID="btnAsignar" runat="server"
                            Text="Asignar"
                            CommandName="Asignar"
                            CommandArgument='<%# Eval("ReparacionID") %>' />

                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

    </form>
</body>
</html>
