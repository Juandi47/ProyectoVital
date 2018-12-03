<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Asistencia.aspx.cs" Inherits="UI.Asistencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
 <%--   <link href="admin_estilos.css" rel="stylesheet" />--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <style>

        .encabezadoTablaAsistencia {
            /*background-color: rgba(76, 175, 80, 0.65);*/
            align-content: center;
            font: bold 15px 'Open Sans', sans-serif;
            text-align: left;
            border-right: 2px solid black;
             border-left: 2px solid black;
              border-top: 2px solid black;
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
        .cell2 {
            /*background-color:rgba(128, 128, 128, 0.48);*/
        text-align: center;
        padding: 5px 0px 5px 0px;
        
        /*border: 2px solid rgba(0, 0, 0, 0.69);*/
        }

            .cell2:single-button {
            border-radius:15px;
            }

        .asistenciaBTN {
            margin:4px;
           
        }

    </style>
	 <asp:Label ID="labelTitulo" runat="server" CssClass="title">Listado de clientes:</asp:Label>
	<br />
	<br />
	<div class="form-container">
			<br />
	<br />
    <form runat="server" class="container">
    <asp:Table ID="TablaClientes" runat="server" CssClass="table-responsive tab"></asp:Table>
    </form>
		</div>
	<div>

	</div>
</asp:Content>
