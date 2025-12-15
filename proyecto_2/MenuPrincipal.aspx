<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="MenuPrincipal.aspx.cs"
    Inherits="MenuPrincipal" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Menú Principal</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f4f6f9;
            margin: 0;
            padding: 20px;
        }

        .contenedor {
            max-width: 900px;
            margin: 0 auto;
        }

        h1 {
            text-align: center;
            margin-bottom: 40px;
            color: #333;
        }

        .menu {
            display: grid;
            grid-template-columns: repeat(2, 1fr);
            gap: 25px;
        }

        /* Estilo para LinkButton */
        .btn-menu {
            background: white;
            padding: 30px;
            text-align: center;
            border-radius: 10px;
            box-shadow: 0 0 12px rgba(0,0,0,.1);
            cursor: pointer;
            transition: transform 0.2s, box-shadow 0.2s;
            border: none;
            display: block;
            width: 100%;
            text-decoration: none;
            color: inherit;
            font-family: Arial;
        }

        .btn-menu:hover {
            transform: scale(1.03);
            box-shadow: 0 0 15px rgba(0,0,0,.15);
            background: #f9f9f9;
            text-decoration: none;
        }

        .icono {
            font-size: 40px;
            margin-bottom: 10px;
        }

        .titulo {
            font-size: 18px;
            font-weight: bold;
            color: #333;
        }

        .btn-salir {
            margin-top: 40px;
            text-align: center;
        }

        .btn-salir .btn {
            padding: 12px 30px;
            background: #d9534f;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            font-size: 16px;
            transition: background 0.3s;
        }

        .btn-salir .btn:hover {
            background: #c9302c;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="contenedor">
        <h1>📋 Menú Principal</h1>

        <div class="menu">
            <!-- LinkButton permite contenido HTML -->
            <asp:LinkButton ID="lnkAsignaciones" runat="server"
                CssClass="btn-menu"
                OnClick="IrAsignaciones">
                <span class="icono">📝</span>
                <span class="titulo">Asignaciones</span>
            </asp:LinkButton>

            <asp:LinkButton ID="lnkEquipo" runat="server"
                CssClass="btn-menu"
                OnClick="IrEquipo">
                <span class="icono">💻</span>
                <span class="titulo">Equipo</span>
            </asp:LinkButton>

            <asp:LinkButton ID="lnkReparaciones" runat="server"
                CssClass="btn-menu"
                OnClick="IrReparaciones">
                <span class="icono">🔧</span>
                <span class="titulo">Reparaciones</span>
            </asp:LinkButton>

            <asp:LinkButton ID="lnkUsuarios" runat="server"
                CssClass="btn-menu"
                OnClick="IrUsuarios">
                <span class="icono">👥</span>
                <span class="titulo">Usuarios</span>
            </asp:LinkButton>
        </div>

        <div class="btn-salir">
            <asp:Button ID="btnSalir" runat="server"
                Text="Cerrar sesión"
                CssClass="btn"
                OnClick="btnSalir_Click" />
        </div>
    </div>
</form>
</body>
</html>