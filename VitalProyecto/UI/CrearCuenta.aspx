<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="UI.CrearCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Gimnasio Vital y Nutrición</title>

	<meta http-equiv="content-type" content="text/html; charset=utf-8" />
	<meta name="description" content="" />
	<meta name="keywords" content="" />

	
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
	
		<link rel="stylesheet" href="css/style.css" />

	<link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>

	<!-- Header -->

	<div id="header">

		<div class="container">
			<!-- Logo -->
			<div id="logo">

				<h1><a style="text-decoration:none;" href="PagInicio.aspx">Vital</a></h1>

			</div>

			<!-- Nav -->
			<nav id="nav">
				<ul>
					<li><a href="#">Noticias</a></li>
					<li><a href="SobreNosotros.html">Sobre nosotros</a></li>
					<li><a href="Contactenos.html">Contactenos</a></li>
				</ul>
			</nav>

		</div>
	</div>

	<div   style="background-color: gainsboro; ">
        <img src="../images/banner_admin01.jpg" style="width:100%"/>
	</div>

	<div>
		<div class="container">
			<div class="row">
				<div class="col-md-3"></div>
				<div class="col-md-5" style="border-style:solid; border-width:3px; border-color:olivedrab; margin:40px; border-radius:10px">

			

					<br />
					Correo eléctronico:<asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox>
					<br />
					Contraseña:<asp:TextBox ID="txtContra" runat="server" TextMode="Password" Font-Size="Small"></asp:TextBox>
					<br />
					Repetir contraseña:<asp:TextBox ID="txtRepetir" runat="server" TextMode="Password" Font-Size="Small"></asp:TextBox>
					<br />


					<%--<asp:Button class="btn btn-success" ID="btnIngresar" runat="server" Height="45px" Text="Ingresar" Width="120px" OnClick="btnIngresar_Click" CssClass="alert-success" Font-Size="Small" />
					<br />
					<asp:Label ID="lblIncorrecto" runat="server"></asp:Label>
					<br />
					<br />--%>
					<asp:Button ID="btnCrearCuenta" runat="server" Font-Size="Small" OnClick="btnCrearCuenta_Click" Text="Crear Cuenta" />
					<br />
					<br />

			

				</div>
				<div class="col-md-4"></div>
			</div>
		</div>

	
	</div>


    </form>

	   <footer class="footer" style="position: relative">
		<h1 class="title">Gimnasio Vital y Nutrición</h1>
        Vital San Ramón, mas que un gimnasio es tu espacio.
    </footer>

</body>


</html>
