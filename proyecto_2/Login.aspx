<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="proyecto_2.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f4f6f9;
        }

        .login-box {
            width: 350px;
            margin: 120px auto;
            background: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 0 12px rgba(0,0,0,.15);
        }

        h2 {
            text-align: center;
            margin-bottom: 25px;
        }

        input, .textbox {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            box-sizing: border-box;
        }

        .btn {
            width: 100%;
            padding: 10px;
            background: #0275d8;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            font-size: 16px;
        }

        /* Estilo para el mensaje de error */
        .mensaje-error {
            color: #d9534f;
            background-color: #f2dede;
            border: 1px solid #ebccd1;
            padding: 10px;
            border-radius: 4px;
            margin-top: 15px;
            text-align: center;
            display: block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-box">
            <h2>Iniciar Sesión</h2>

            <asp:TextBox ID="txtUsuario" runat="server"
                CssClass="textbox"
                Placeholder="Correo electrónico" />

            <asp:TextBox ID="txtClave" runat="server"
                TextMode="Password"
                CssClass="textbox"
                Placeholder="Contraseña" />

            <asp:Button ID="btnIngresar" runat="server"
                Text="Ingresar"
                CssClass="btn"
                OnClick="btnIngresar_Click" />
            
            <!-- AGREGAR ESTA LÍNEA (SOLUCIÓN AL ERROR) -->
            <asp:Label ID="lblMensaje" runat="server" 
                CssClass="mensaje-error" 
                Visible="false"
                EnableViewState="false">
            </asp:Label>
        </div>
    </form>
</body>
</html>