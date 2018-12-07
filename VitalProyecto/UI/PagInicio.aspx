<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagInicio.aspx.cs" Inherits="UI.PagInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Gimnasio Vital y Nutrición </title>
    <meta charset="utf-8" />

    <link rel="stylesheet" href="css/style.css" />
    <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway" />


</head>
<body style="background-color: silver">

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

                <h1><a style="text-decoration: none;" href="PagInicio.aspx">Vital</a></h1>

            </div>

            <!-- Nav -->
            <nav id="nav">
                <ul>
                    <li><a href="IniciarSesion.aspx">Iniciar sesión</a></li>
                    <li><a href="SobreNosotros.html">Sobre nosotros</a></li>
                    <li><a href="Contactenos.html">Contactenos</a></li>
                </ul>
            </nav>

        </div>
    </div>


    <div id="banner" style="background-color: silver">


        <div>

            <div id="myCarousel" style="background-color: darkolivegreen" class="container carousel slide" data-ride="carousel">

                <!-- Wrapper for slides -->
                <div class="carousel-inner">
                    <div class="item active">
                        <img src="images/a.jpg" />
                    </div>

                    <div class="item">
                        <img src="images/b.jpg" />
                    </div>

                    <div class="item">
                        <img src="images/c.jpg" />
                    </div>

                    <div class="item">
                        <img src="images/d.jpg" />
                    </div>

                    <div class="item">
                        <img src="images/e.jpg" />
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

    <div class="container" style="background-color: darkolivegreen">
        <br />
        <br />
        <br />
        <h3 style="text-align: center; color: white">Si eres cliente de nuestro gimnasio y no te has registrado, haz click <u><a style="color: white" href="CrearCuenta.aspx">aquí</a></u></h3>
        <br />
        <br />
        <br />
        <br />
    </div>

    <div class="container">
        <br />
        <br />
    </div>

    <div class="container" style="background-color: white">
        <div class="w3-row">
            <div class="w3-col l8 s12">
                <asp:Literal ID="Blogs" runat="server"></asp:Literal>
            </div>
            <div class="w3-col l4">
                <asp:Literal ID="MiniNoticia" runat="server"></asp:Literal>

                <div class="w3-card w3-margin">
                    <div class="w3-container w3-padding">
                        <h4>Más Recientes</h4>
                    </div>
                    <ul class="w3-ul w3-hoverable w3-white">
                        <asp:Literal ID="NotReciente" runat="server"></asp:Literal>
                    </ul>
                </div>
                <hr />
                <div class="w3-card w3-margin">
                    <asp:Literal ID="Notas" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
        <br />


    </div>

    <div>
        <br />
        <br />
        <br />
    </div>

    <footer class="footer" style="position: relative">
        <h1 class="title">Gimnasio Vital y Nutrición</h1>
        Vital San Ramón, mas que un gimnasio es tu espacio.
    </footer>

</body>
</html>
