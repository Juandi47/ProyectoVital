<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UI.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gimnasio & Nutricion Vital</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="description" content="" />
    <meta name="keywords" content="" />
    <!--[if lte IE 8]><script src="css/ie/html5shiv.js"></script><![endif]-->
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.dropotron.min.js"></script>
    <script src="js/skel.min.js"></script>
    <script src="js/skel-layers.min.js"></script>
    <script src="js/init.js"></script>
    <script src="js/main.js"></script>
    <script src="js/util.js"></script>
    <noscript>
			<link rel="stylesheet" href="css/skel.css" />
			<link rel="stylesheet" href="css/style.css" />
            <link rel="stylesheet" href="css/main.css" />
            <link rel="stylesheet" href="css/ie9.css" />
		</noscript>
    <!--[if lte IE 8]><link rel="stylesheet" href="css/ie/v8.css" /><![endif]-->
</head>
<body>

    <!-- Header Wrapper -->
    <div class="wrapper style1">

        <!-- Header -->
        <div id="header">
            <div class="container">

                <!-- Logo -->
                <h1><a href="#" id="logo">Vital</a></h1>

                <!-- Nav -->
                <nav id="nav">
                    <ul>
                        <li class="active"><a href="index.html">Inicio</a></li>
                        <li>
                            <a href="">Servicios</a>
                            <ul>
                                <li><a href="#">Clases funcionales</a></li>
                                <li><a href="#">Clases de boxeo</a></li>
                                <li><a href="#">Servicio de nutrición</a></li>
                                <li>
                                    <a href="">Otros</a>
                                    <ul>
                                        <li><a href="#">Yoga</a></li>
                                        <li><a href="#">Clases de baile</a></li>
                                        <li><a href="#">Phasellus consequat</a></li>
                                        <li><a href="#">Magna phasellus</a></li>
                                        <li><a href="#">Etiam dolore nisl</a></li>
                                        <li><a href="#">Veroeros feugiat</a></li>
                                    </ul>
                                </li>

                            </ul>
                        </li>
                        <%--									<li><a href="left-sidebar.html">Sobre nosotros</a></li>--%>
                        <li><a href="right-sidebar.html">Ingresar</a></li>
                        <%--<li><a href="no-sidebar.html">Contactenos</a></li>--%>
                    </ul>
                </nav>

            </div>
        </div>

        <!-- Banner -->
        <div id="banner">
            <section class="container">
                <h2>Vital</h2>
                <span>Gimnasio & Nutrición</span>
                <p>Bienvenidas/os a Vital, salud y bienestar a su servicio .</p>
            </section>
        </div>

    </div>

    <!-- Section One -->
    <%--<div class="wrapper style2">
				<section class="container">
					<div class="row double">
						<div class="6u">
							<header class="major">
								<h2>Pellentesque viverra vulputate enim. Aliquam volutpat. Pellentesque tristique Risus</h2>
								<span class="byline">In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula. Pellentesque viverra vulputate enim. Donec pulvinar ullamcorper metus.</span>
							</header>
						</div>
						<div class="6u">
							<h3>Suspendisse dictum porta</h3>
							<p>Donec leo. Vivamus fermentum nibh in augue. Praesent a lacus at urna congue rutrum. Nulla enim eros, porttitor eu, tempus id, varius non, nibh. Vestibulum imperdiet, magna nec eleifend semper augue mattis wisi maecenas ligula nunc lectus vestibulum euismod lacinia quam nisl.</p>
							<a href="#" class="button">Nulla aluctus eleifend</a>
						</div>
					</div>
				</section>
			</div>--%>
   <div class="container">
    <div class="row">
        <div class="col-sm-6 col-md-7" style="align-items:center">
            <section class="container"> 
                <h4>Servicios</h4>
                </section> 
        </div>
        <div class="col-sm-4 col-md-5" style="align-items:center">
                        <section class="container"> 
                <h4>Noticias</h4>
                </section> 

        </div>
    </div>
</div>

    <!-- Section Two -->
    <div class="wrapper style3">
        <section class="container">
            <header class="major">
                <h2>Cras vitae metus aliNuam</h2>
            </header>
            <p>Pellentesque pede. Donec pulvinar ullamcorper metus. In eu odio at lectus pulvinar mollis. Vestibulum sem magna, elementum vestibulum arcu.</p>
            <a href="#" class="button alt">Nulla aluctus eleifend</a>
        </section>
    </div>

    <!-- Section Three -->
    <div class="wrapper style4">
        <section class="container">
            <header class="major">
                <h2>Cras vitae metus aliNuam</h2>
                <span class="byline">pulvinar mollis. Vestibulum sem magna, elementum vestibulum arcu.</span>
            </header>
            <div class="row flush">
                <div class="4u">
                    <ul class="special-icons">
                        <li>
                            <span class="fa fa-cogs"></span>
                            <h3>Nulla luctus eleifend</h3>
                            <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>
                        </li>
                        <li>
                            <span class="fa fa-wrench"></span>
                            <h3>Etiam posuere augue</h3>
                            <p>Maecenas ligula. Pellentesque viverra vulputate enim. Aliquam erat volutpat liguala.</p>
                        </li>
                        <li>
                            <span class="fa fa-leaf"></span>
                            <h3>Fusce ultrices fringilla</h3>
                            <p>Maecenas pede nisl, elementum eu, ornare ac, malesuada at, erat. Proin gravida orci porttitor.</p>
                        </li>
                    </ul>
                </div>
                <div class="4u">
                    <ul class="special-icons">
                        <li>
                            <span class="fa fa-cogs"></span>
                            <h3>Nulla luctus eleifend</h3>
                            <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>
                        </li>
                        <li>
                            <span class="fa fa-wrench"></span>
                            <h3>Etiam posuere augue</h3>
                            <p>Maecenas ligula. Pellentesque viverra vulputate enim. Aliquam erat volutpat liguala.</p>
                        </li>
                        <li>
                            <span class="fa fa-leaf"></span>
                            <h3>Fusce ultrices fringilla</h3>
                            <p>Maecenas pede nisl, elementum eu, ornare ac, malesuada at, erat. Proin gravida orci porttitor.</p>
                        </li>
                    </ul>
                </div>
                <div class="4u">
                    <ul class="special-icons">
                        <li>
                            <span class="fa fa-cogs"></span>
                            <h3>Nulla luctus eleifend</h3>
                            <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>
                        </li>
                        <li>
                            <span class="fa fa-wrench"></span>
                            <h3>Etiam posuere augue</h3>
                            <p>Maecenas ligula. Pellentesque viverra vulputate enim. Aliquam erat volutpat liguala.</p>
                        </li>
                        <li>
                            <span class="fa fa-leaf"></span>
                            <h3>Fusce ultrices fringilla</h3>
                            <p>Maecenas pede nisl, elementum eu, ornare ac, malesuada at, erat. Proin gravida orci porttitor.</p>
                        </li>
                    </ul>
                </div>
            </div>
        </section>
    </div>

    <!-- Team -->
    <div class="wrapper style5">
        <section id="team" class="container">
            <header class="major">
                <h2>Cras vitae metus aliNuam</h2>
                <span class="byline">pulvinar mollis. Vestibulum sem magna, elementum vestibulum arcu</span>
            </header>
            <div class="row">
                <div class="3u">
                    <a href="#" class="image">
                        <img src="images/placeholder.png" alt=""></a>
                    <h3>Molly Millions</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
                <div class="3u">
                    <a href="#" class="image">
                        <img src="images/placeholder.png" alt=""></a>
                    <h3>Henry Dorsett Case</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
                <div class="3u">
                    <a href="#" class="image">
                        <img src="images/placeholder.png" alt=""></a>
                    <h3>Willis Corto</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
                <div class="3u">
                    <a href="#" class="image">
                        <img src="images/placeholder.png" alt=""></a>
                    <h3>Linda Lee</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
            </div>
        </section>
    </div>

    <!-- Footer -->
    <div id="footer">
        <section class="container">
            <header class="major">
                <h2>Contáctenos</h2>
                <span class="byline">Será un gusto atenderle</span>
            </header>
            <ul class="icons">
                <li class="active"><a href="#" class="fa fa-facebook"><span>Facebook</span></a></li>
                <li><a href="#" class="fa fa-twitter"><span>Twitter</span></a></li>
                <li><a href="#" class="fa fa-dribbble"><span>Pinterest</span></a></li>
                <li><a href="#" class="fa fa-google-plus"><span>Google+</span></a></li>
            </ul>
            <hr />
        </section>

        <!-- Copyright -->
        <div id="copyright">
            Design: <a href="http://templated.co">TEMPLATED</a> Images: <a href="http://unsplash.com">Unsplash</a> (<a href="http://unsplash.com/cc0">CC0</a>)
        </div>
    </div>

</body>
</html>
