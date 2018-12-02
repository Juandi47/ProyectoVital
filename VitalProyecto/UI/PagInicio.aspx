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


	<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway"/>


</head>
<body style="background-color:silver">

	<style>
		body, h1, h2, h3, h4, h5 {
			font-family: "Raleway", sans-serif;
		}

	</style>

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


	<div id="banner" style="background-color: silver">


		<div>
		
			<div id="myCarousel" style="background-color:darkolivegreen" class="container carousel slide" data-ride="carousel">
				
				<!-- Wrapper for slides -->
				<div class="carousel-inner">
					<div class="item active">
						<img src="images/a.jpg" />
					</div>

					<div class="item">
						<img src="images/b.jpg"/>
					</div>

					<div class="item">
						<img src="images/c.jpg"/>
					</div>
					
					<div class="item">
						<img src="images/d.jpg"/>
					</div>

					<div class="item">
						<img src="images/e.jpg"/>
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

	<div class="container" style="background-color:darkolivegreen">
		<br /><br /><br />
		<h3 style="text-align:center; color:white">Si eres cliente de nuestro gimnasio y no te has registrado, haz click <u><a style="color:white" href="CrearCuenta.aspx">aquí</a></u></h3>
		<br /><br /><br /><br />
	</div>

	<div class="container">
		<br /><br />
	</div>

	<div class="container" style="background-color:white">
<!-- Grid -->
<div class="w3-row">

<!-- Blog entries -->
<div class="w3-col l8 s12">
  <!-- Blog entry -->
  <div class="w3-card-4 w3-margin w3-white">
    <img src="/images/not.jpeg" alt="Nature" style="width:100%"/>
    <div class="w3-container">
      <h3><b>HACER EJERCICIO ALARGA LA VIDA</b></h3>
      <h5>Title description, <span class="w3-opacity">April 7, 2014</span></h5>
    </div>

    <div class="w3-container">
      <p>Mauris neque quam, fermentum ut nisl vitae, convallis maximus nisl. Sed mattis nunc id lorem euismod placerat. Vivamus porttitor magna enim, ac accumsan tortor cursus at. Phasellus sed ultricies mi non congue ullam corper. Praesent tincidunt sed
        tellus ut rutrum. Sed vitae justo condimentum, porta lectus vitae, ultricies congue gravida diam non fringilla.</p>
      <div class="w3-row">
        <div class="w3-col m8 s12">
          <p><button class="w3-button w3-padding-large w3-white w3-border"><b>READ MORE »</b></button></p>
        </div>
        <div class="w3-col m4 w3-hide-small">
          <p><span class="w3-padding-large w3-right"><b>Comments  </b> <span class="w3-tag">0</span></span></p>
        </div>
      </div>
    </div>
  </div>
  <hr/>

  <!-- Blog entry -->
  <div class="w3-card-4 w3-margin w3-white">
  <img src="/images/plan.jpg" alt="Norway" style="width:100%"/>
    <div class="w3-container">
      <h3><b>RETO PLANCHA</b></h3>
      <h5>Title description, <span class="w3-opacity">April 2, 2014</span></h5>
    </div>

    <div class="w3-container">
      <p>Mauris neque quam, fermentum ut nisl vitae, convallis maximus nisl. Sed mattis nunc id lorem euismod placerat. Vivamus porttitor magna enim, ac accumsan tortor cursus at. Phasellus sed ultricies mi non congue ullam corper. Praesent tincidunt sed
        tellus ut rutrum. Sed vitae justo condimentum, porta lectus vitae, ultricies congue gravida diam non fringilla.</p>
      <div class="w3-row">
        <div class="w3-col m8 s12">
          <p><button class="w3-button w3-padding-large w3-white w3-border"><b>READ MORE »</b></button></p>
        </div>
        <div class="w3-col m4 w3-hide-small">
          <p><span class="w3-padding-large w3-right"><b>Comments  </b> <span class="w3-badge">2</span></span></p>
        </div>
      </div>
    </div>
  </div>
<!-- END BLOG ENTRIES -->
</div>

<!-- Introduction menu -->
<div class="w3-col l4">
  <!-- About Card -->
  <div class="w3-card w3-margin w3-margin-top">
  <img src="/images/cerrado.jpg" style="width:100%"/>
    <div class="w3-container w3-white">
      <h4><b>CERRADO POR DIAS FESTIVOS</b></h4>
      <p>Just me, myself and I, exploring the universe of uknownment. I have a heart of love and a interest of lorem ipsum and mauris neque quam blog. I want to share my world with you.</p>
    </div>
  </div><hr/>
  
  <!-- Posts -->
  <div class="w3-card w3-margin">
    <div class="w3-container w3-padding">
      <h4>Popular Posts</h4>
    </div>
    <ul class="w3-ul w3-hoverable w3-white">
      <li class="w3-padding-16">
        <img src="/w3images/workshop.jpg" alt="Image" class="w3-left w3-margin-right" style="width:50px"/>
        <span class="w3-large">Lorem</span><br/>
        <span>Sed mattis nunc</span>
      </li>
      <li class="w3-padding-16">
        <img src="/w3images/gondol.jpg" alt="Image" class="w3-left w3-margin-right" style="width:50px"/>
        <span class="w3-large">Ipsum</span><br/>
        <span>Praes tinci sed</span>
      </li> 
      <li class="w3-padding-16">
        <img src="/w3images/skies.jpg" alt="Image" class="w3-left w3-margin-right" style="width:50px"/>
        <span class="w3-large">Dorum</span><br/>
        <span>Ultricies congue</span>
      </li>   
      <li class="w3-padding-16 w3-hide-medium w3-hide-small">
        <img src="/w3images/rock.jpg" alt="Image" class="w3-left w3-margin-right" style="width:50px"/>
        <span class="w3-large">Mingsum</span><br/>
        <span>Lorem ipsum dipsum</span>
      </li>  
    </ul>
  </div>
  <hr/> 
 
  <!-- Labels / tags -->
  <div class="w3-card w3-margin">
    <div class="w3-container w3-padding">
      <h4>Tags</h4>
    </div>
    <div class="w3-container w3-white">
    <p>
		<br />
    </p>
    </div>
  </div>
  
<!-- END Introduction Menu -->
</div>

<!-- END GRID -->
</div><br/>


	</div>

	<div>
		<br /><br /><br />
	</div>

	<footer class="footer" style="position: relative">
		<h1 class="title">Gimnasio Vital y Nutrición</h1>
        Vital San Ramón, mas que un gimnasio es tu espacio.
    </footer>

</body>
</html>
