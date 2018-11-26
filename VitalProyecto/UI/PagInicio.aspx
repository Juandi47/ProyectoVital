<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagInicio.aspx.cs" Inherits="UI.PagInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

	<title>Gimnasio Vital y Nutrición </title>
  <meta charset="utf-8"/>
	
		<link rel="stylesheet" href="css/style.css" />
	<link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

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

	<div id="banner" class="admin-banner" style="background-color: silver; background-size:cover">


		<div class="container">
		
			<div id="myCarousel" class="carousel slide" data-ride="carousel">
				<!-- Indicators -->
				<ol class="carousel-indicators">
					
				</ol>

				<!-- Wrapper for slides -->
				<div class="carousel-inner">
					<div class="item active">
						<img src="images/a.jpg"  style="width: 100%;"/>
					</div>

					<div class="item">
						<img src="images/b.jpg" style="width: 100%;"/>
					</div>

					<div class="item">
						<img src="images/c.jpg" style="width: 100%;"/>
					</div>
					
					<div class="item">
						<img src="images/d.jpg" style="width: 100%;"/>
					</div>

					<div class="item">
						<img src="images/e.jpg" style="width: 100%;"/>
					</div>
				</div>

				<!-- Left and right controls -->
				<a class="left carousel-control" href="#myCarousel" data-slide="prev">
					<span class="glyphicon glyphicon-chevron-left"></span>
					<span class="sr-only">Previous</span>
				</a>
				<a class="right carousel-control" href="#myCarousel" data-slide="next">
					<span class="glyphicon glyphicon-chevron-right"></span>
					<span class="sr-only">Next</span>
				</a>
			</div>
		</div>



	</div>

	<div>
		<br /><br /><br />
		<h3 style="text-align:center">Si eres cliente de nuestro gimnasio y no te has registrado, haz click <u><a style="color:darkolivegreen" href="CrearCuenta.aspx">aquí</a></u></h3>
		<br /><br /><br /><br />
	</div>

	<footer class="footer">
		Vital San Ramón, mas que un gimnasio es tu espacio.
	</footer>

</body>
</html>
