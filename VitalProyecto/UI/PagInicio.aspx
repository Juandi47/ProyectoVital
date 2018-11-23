<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagInicio.aspx.cs" Inherits="UI.PagInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Gimnasio Vital y Nutrición</title>
	
	<meta http-equiv="content-type" content="text/html; charset=utf-8" />
	<meta name="description" content="" />
	<meta name="keywords" content="" />

	<script src="js/jquery.min.js"></script>
	<script src="js/jquery.dropotron.min.js"></script>
	<script src="js/skel.min.js"></script>
	<script src="js/skel-layers.min.js"></script>
	<script src="js/init.js"></script>
	
		<link rel="stylesheet" href="css/skel.css" />
		<link rel="stylesheet" href="css/style.css" />

	<link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>

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
					<li><a href="IniciarSesion.aspx">Iniciar sesión</a></li>
					<li><a href="SobreNosotros.html">Sobre nosotros</a></li>
					<li><a href="Contactenos.html">Contactenos</a></li>
				</ul>
			</nav>

		</div>
	</div>

	<div id="banner" class="admin-banner" style="background-color: gainsboro; background-size:cover">
		
	</div>

	<div>
		<br /><br /><br />
		<h1 style="text-align:center">Si eres cliente de nuestro gimnasio y no te has registrado, haz click <u><a style="color:darkolivegreen" href="CrearCuenta.aspx">aquí</a></u></h1>
		<br /><br /><br /><br />
	</div>

	<footer class="footer">
	</footer>

</body>
</html>
