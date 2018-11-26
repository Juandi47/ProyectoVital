<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientePrincipal.aspx.cs" Inherits="UI.ClientePrincipal" %>

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

	<link rel="stylesheet" href="css/tabla.css" />
</head>

<body>
	<style>
		#div1 {
			overflow: scroll;
			width: 800px;
		}
	</style>

	<form id="form1" runat="server">

		<!-- Header -->
		<div id="header">
			<div class="container">
				<div id="logo">
					<h1><a style="text-decoration: none;" href="ClientePrincipal.aspx">Vital</a></h1>
				</div>
				<div>
					<nav id="nav">
						<ul>
							<li><a href="ModificarCuentaUsuario.apsx">Modificar perfil</a></li>
							<li><a href="PagInicio.aspx">Cerrar Sesión</a></li>
						</ul>
					</nav>
				</div>
			</div>
		</div>

		<div style="background-color: gainsboro;">
			<img src="../images/banner_admin01.jpg" style="width: 100%" />
		</div>

		
			<div class="container" >
				<div class="row">
					<div class="col-md-4"></div>
					<div class="col-md-4">
						<asp:TextBox ID="txtTitulo" BackColor="DarkOliveGreen" Text="Expediente del cliente" runat="server" Font-Overline="False" Font-Size="Medium" ForeColor="White" ></asp:TextBox>
						<asp:Button ID="btnExpediente" Text="Ver mi expediente" runat="server" OnClick="btnExpediente_Click" />
                        <br />
						<br />
					</div>
					<div class="col-md-4"></div>
				</div>
			</div>


			<div class="container">
				<div class="row">
					<div class="col-md-2"></div>
					<div class="col-md-8" style="background-color:silver">
						<asp:Label ID="lbNomCompleto" runat="server" Text="Label"></asp:Label>
						
						<br />
						Cédula:
						<asp:Label ID="lbCedula" runat="server" Text="Label"></asp:Label>
						<br />
						Correo:
						<asp:Label ID="lbCorreo" runat="server" Text="Label"></asp:Label>
						
						<br />
						Fecha de nacimiento:
						<asp:Label ID="lbNacim" runat="server" Text="Label"></asp:Label>
						<br />
						Teléfono:
						<asp:Label ID="lbTel" runat="server" Text="Label"></asp:Label>
						<br />
						Observaciones:
						<asp:Label ID="lbObs" runat="server" Text="Label"></asp:Label>
						<br />
						Fecha de mensualidad:
						<asp:Label ID="lbMens" runat="server" Text="Label"></asp:Label>
						
					</div>
					<div class="col-md-2">
						<br />
						<br />
					</div>
				</div>
			</div>

		<div class="container" >
				<div class="row">
					<div class="col-md-4"></div>
					<div class="col-md-4">
						<br /><br /><br />
						<asp:TextBox ID="txtMedidas" BackColor="DarkOliveGreen" Text="Medidas del cliente" runat="server" Font-Overline="False" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
						<br />
					</div>
					<div class="col-md-4"></div>
				</div>
			</div>

		<div class="container">
				<div class="row">
					<div class="col-md-2"></div>
					<div class="col-md-8" style="background-color:silver">
						
						<div id="div1">
						<table>
								<asp:Literal ID="tablaExped" runat="server"></asp:Literal>


						</table>
							</div>
					
						
			
					</div>
					<div class="col-md-2">
						<br />
						<br />
					</div>
				</div>


		</div>

	</form>

<footer class="footer">
		Vital San Ramón, mas que un gimnasio es tu espacio.
	</footer>
	<p>
		&nbsp;</p>
</body>
</html>

