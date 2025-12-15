<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reportes.aspx.cs" Inherits="Reportes" %>

<h2>📊 Reportes</h2>

<ul>
    <li>Total Usuarios: <%= CL_Reportes.Total("Usuarios") %></li>
    <li>Total Equipos: <%= CL_Reportes.Total("Equipos") %></li>
    <li>Total Reparaciones: <%= CL_Reportes.Total("Reparaciones") %></li>
</ul>
