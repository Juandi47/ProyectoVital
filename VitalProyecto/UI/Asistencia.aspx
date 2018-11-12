<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Asistencia.aspx.cs" Inherits="UI.Asistencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="admin_estilos.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <style>
        .tablaAsistencia {
           
            margin: 10px 10px 10px 10px;
        }

        .encabezadoTablaAsistencia {
            /*background-color: rgba(76, 175, 80, 0.65);*/
            align-content: center;
            font: bold 15px 'Open Sans', sans-serif;
            text-align: left;
            border-right: 2px solid black;
            margin-bottom: 50px;
        }

        .filaTablaAsistencia {
            border-top: 2px solid rgba(128, 128, 128, 0.79);
        }
        .cell {
        text-align: left;
        padding: 5px 0px 5px 0px;
        /*border: 2px solid rgba(0, 0, 0, 0.69);*/
        }

    </style>
    <h1>Listado de clientes:</h1>
    <asp:Table ID="TablaClientes" runat="server" CssClass="tablaAsistencia"></asp:Table>

</asp:Content>
