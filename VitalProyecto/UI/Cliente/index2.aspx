﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="UI.index2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vital</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="description" content="" />
    <meta name="keywords" content="" />
    <!--[if lte IE 8]><script src="css/ie/html5shiv.js"></script><![endif]-->
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.dropotron.min.js"></script>
    <script src="js/skel.min.js"></script>
    <script src="js/skel-layers.min.js"></script>
    <script src="js/init.js"></script>
   
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
   
   
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
         <link href="estilos.css" rel="stylesheet" />
    <link href="../css/skel.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    


</head>

<body class="homepage">

    <!-- Header Wrapper -->
    <div class="wrapper style1">

        <!-- Header -->
        <div id="header">
            <div class="container">

                <!-- Logo -->
                <h1><a href="#" id="logo">Solarize</a></h1>

                <!-- Nav -->
                <nav id="nav">
                    <ul>
                        <li class="active"><a href="index2.aspx">Inicio</a></li>
                        <%-- <li>
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
                        </li>--%>

                        <li><a href="left-sidebar.html">Sobre nosotros</a></li>
                        <li><a href="login.aspx">Ingresar</a></li>
                        <li><a href="no-sidebar.html">Contactenos</a></li>
                    </ul>
                </nav>

            </div>
        </div>

        <!-- Banner -->
        <div id="banner">
            <section class="container">
                <h2>Vital</h2>
                <span>Gimnasio para  mujeres</span>
                <p>Pellentesque pede. Donec pulvinar ullamcorper metus. In eu odio at lectus pulvinar mollis. Vestibulum sem magna.</p>
            </section>
        </div>
    </div>

    <%-------------------------------------------------- SECCION 1 --------------------------------------------------------%>



    <div class="container row">
        <div class="left col-s-4">
             <header class="major">
          <h2 class="h2">Noticias</h2>
                </header>
                    <h2>02 Oct</h2>
                    <p>Chania is a city on the island of Crete.</p>
                    <h2>06 Oct</h2>
                    <p>Crete is a Greek island in the Mediterranean Sea.</p>
                    <h2>24 Nov</h2>
                    <p>You can reach Chania airport from all over Europegggg.</p>
        </div>

         <div class="center col-s-4">
  
               <h2 class="h2">Servicios</h2>

                   <h1>Servicio 1</h1>
                    <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>

                    <button type="button" class="btn btn-success" style="margin-left:1em;">Ver mas</button>
        </div>

              

                      
  
            <div class="right col-s-4">
                <img  class="image" alt="" src="../images/pic02.jpg" />
        </div>
       

        </div>

    <%--<div class="wrapper style4" style="background-color:yellowgreen">
        <div class="row sec1" style="background-color:cornflowerblue">--%>
    <%-- Noticias --%>
    <%--   <div class="col-3 col-s-3 aside2" style="background-color:red">
                <header class="major">
                <h2 class="h2">Noticias</h2>
                </header>
                    <h2>02 Oct</h2>
                    <p>Chania is a city on the island of Crete.</p>
                    <h2>06 Oct</h2>
                    <p>Crete is a Greek island in the Mediterranean Sea.</p>
                    <h2>24 Nov</h2>
                    <p>You can reach Chania airport from all over Europegggg.</p>

            </div>--%>

    <%-- Servicios --%>
    <%-- s1 --%>
    <%--    <div class="col-5 col-s-12 right-div" runat="server" style="background-color:brown">

               <header class="major">
                <h2 class="h2">Servicios</h2>
                </header>
                
                <div  class="col-5 col-s-12 column1">
                   <h1>Servicio 1</h1>
                    <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>
                </div>
                <div  class="col-6 col-s-12 column2"  ">
                    <img  class="image" alt="" src="images/pic02.jpg" />

                    <button type="button" class="btn btn-success" style="margin-left:1em; position:;">Ver mas</button>--%>
    <%-- <a href="#" style="color:#042c09" class="btn btn-info" role="button">Ver mas</a>--%>
    <%--  </div>

            </div>--%>

    <%-- s2 --%>
    <%-- <div class=" right-div" runat="server">

                <div  class="col-5 col-s-12 column1" >
                   <h1>Servicio 2</h1>
                    <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>
                </div>
                <div  class="col-6 col-s-12 column2"  ">
                    <img  class="image" alt="" src="images/pic02.jpg" />
                </div>

            </div>--%>
    <%-- s3 --%>
    <%--   <div class="col-7 col-s-12 right-div" runat="server">

                <div  class="col-5 col-s-12 column1" >
                   <h1>Servicio 3</h1>
                    <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>
                </div>
                <div  class="col-6 col-s-12 column2"  ">
                    <img  class="image" alt="" src="images/pic02.jpg" />
                </div>

            </div>--%>
    <%-- s4 --%>
    <%-- <div class="col-7 col-s-12 right-div" runat="server">

                <div  class="col-5 col-s-12 column1" >
                   <h1>Servicio 5</h1>
                    <p>In posuere eleifend odio. Quisque semper augue mattis wisi. Maecenas ligula pellentesque.</p>
                </div>
                <div  class="col-6 col-s-12 column2"  ">
                    <img  class="image" alt="" src="../images/pic02.jpg" />
                </div>

            </div>--%>



    <%--        </div>--%>


    <!-----------------------------------  <%-- SECCION 2 --%> --------------------------------------->

    <section class="container">
        <header class="major">
            <h2>Seccion 2</h2>
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
    

    <!-----------------------------------  <%-- SECCION 3 --%> --------------------------------------->


    <div class="wrapper style5">
        <section id="team" class="container">
            <header class="major">
                <h2>Seccion 3</h2>
                <span class="byline">pulvinar mollis. Vestibulum sem magna, elementum vestibulum arcu</span>
            </header>
            <div class="row">
                <div class="3u">
                    <a href="#" class="image">
                      <img src="../images/placeholder.png" alt=""/></a>
                    <h3>Molly Millions</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
                <div class="3u">
                    <a href="#" class="image">
                       <img src="../images/placeholder.png" alt=""/></a>
                    <h3>Henry Dorsett Case</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
                <div class="3u">
                    <a href="#" class="image">
                       <img src="../images/placeholder.png" alt=""/></a>
                    <h3>Willis Corto</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
                <div class="3u">
                    <a href="#" class="image">
                        <img src="../images/placeholder.png" alt=""/></a>
                    <h3>Linda Lee</h3>
                    <p>In posuere eleifend odio quisque semper augue wisi ligula.</p>
                </div>
            </div>
        </section>
    </div>

    <!------------------------------ Footer ------------------------------------->

    <div id="footer">
        <section class="container">
            <header class="major">
                <h2>Contáctenos</h2>
                <span class="byline">La fuerza del pirucho</span>
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
