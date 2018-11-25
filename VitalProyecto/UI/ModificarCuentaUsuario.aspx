<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarCuentaUsuario.aspx.cs" Inherits="UI.ModificarCuentaUsuario" %>

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
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="css/skel.css" />
    <link rel="stylesheet" href="css/style.css" />
    <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen" />
</head>

<body>
    <form id="form1" runat="server">

        <!-- Header -->
        <div id="header">
            <div class="container">
                <div id="logo">
                    <h1><a style="text-decoration: none;" href="ClientePrincipal.aspx">Vital</a></h1>
                </div>
                <div>
                    <nav id="nav">
                    </nav>
                </div>
            </div>
        </div>

        <div style="background-color: gainsboro;">
            <img src="../images/banner_admin01.jpg" style="width: 100%" />
        </div>


        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTitulo" BackColor="DarkOliveGreen" Text="Mi perfil" runat="server" Font-Overline="False" Font-Size="Medium" ForeColor="White"></asp:TextBox>
                    <br />
                    <br />
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>

        <div class="container">

            <h1 class="title">Modificar Mi cuenta</h1>

            <div class="form-container">

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tnombre">Nombre</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tnombre" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tcedula">Cedula</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tcedula" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tcorreo">Correo</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tcorreo" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tfehcaN">Fecha de nacimiento</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tfehcaN" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tTelefono">Teléfono</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tTelefono" runat="server" TextMode="Number" placeholder="Ejm: 83978140"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tclave"> Ingrese su nueva contraseña </label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tclave" runat="server" TextMode="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tclave2">Confirme clave </label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tclave2" runat="server" TextMode="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
                    </div>
                </div>

                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="AllValidators" />
            </div>
            <asp:Button ID="btnModificar" Text="Modificar" runat="server" OnClick="btnModificar_Click" />

        </div>

    </form>

    <%-- <footer class="footer" style="position: page">
        <h1 class="title">
			<br /><br /><br />
        </h1>
    </footer>--%>
    <p>
        &nbsp;
    </p>
</body>
</html>
