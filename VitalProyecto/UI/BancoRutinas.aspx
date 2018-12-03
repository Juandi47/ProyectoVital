<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="BancoRutinas.aspx.cs" Inherits="UI.BancoRutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <%--<link href="admin_estilos.css" rel="stylesheet" />--%>

	 <script src="js/alertify.min.js"></script>
	<link rel="stylesheet" href="/css/alertify.min.css" />
	<link rel="stylesheet" href="/css/semantic.min.css" />
	<script src="/alertify.js"></script>
	<script src="/mensaje.js"></script>
	
	<script type="text/javascript">
		function mensaje() {
			alertify.success("Rutina eliminada");
		}
	</script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <style>
        #div1 {
            overflow: scroll;
            width: 800px;
        }
    </style>

    <script>
        function guardarNombre(nombre, boton) {
            __doPostBack("NombreYBoton", nombre + ";" + boton);
        }
    </script>
    <form id="form1" runat="server" style="background-color: lightgray">

        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">

					<br /><br />
                    <asp:Button ID="BtnCrearRutina" Font-Size="Small" Width="250px" Height="55px" runat="server" Text="Crear Rutina" OnClick="BtnCrearRutina_Click"/>

                    <asp:Button ID="btnRutinaAleatoria" Font-Size="Small" Width="250px" Height="55px" runat="server" Text="Rutina Aleatoria" OnClick="btnRutinaAleatoria_Click"/>
					<br /><br /><br />
                    <asp:Table ID="Rutinas" runat="server" class="table table-bordered text-center table-hover ">
                    </asp:Table>

                </div>
                <div class="col-md-1"></div>
            </div>
        </div>
    </form>
</asp:Content>
