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




			<%--<div class="container">
				<div class="row">
					<div class="col-md-2"></div>
					<div class="col-md-8" style="background-color:silver">
						<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
						<br />
						<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
						<br />
						<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
						<br />
						<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
						<br />
						<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
						<br />

						<asp:Table runat="server" CssClass="table-responsive estiloFila">
	
							<asp:TableRow>
								<asp:TableCell>
									<asp:Label ID="lbNombre" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									<asp:Label ID="lbApe1" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									<asp:Label ID="lbApe2" runat="server"></asp:Label>
								</asp:TableCell>
							</asp:TableRow>

							<asp:TableRow>
								<asp:TableCell>
									Fecha de nacimiento: <asp:Label ID="lbFecNac" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									Fecha de mensualidad: <asp:Label ID="lbFecMens" runat="server"></asp:Label>
								</asp:TableCell>
								
							</asp:TableRow>

							<asp:TableRow>
								<asp:TableCell>
									Observaciones: <asp:Label ID="lbObserva" runat="server"></asp:Label>
								</asp:TableCell>
							</asp:TableRow>

						</asp:Table>

						<asp:TextBox ID="txtMedidas" BackColor="DarkOliveGreen" Text="Medidas del cliente" runat="server" Font-Overline="False" Font-Size="Medium" ForeColor="White" Width="200px"></asp:TextBox>
						<br />
						<asp:Label ID="lbNoMedidas" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
						<asp:Table runat="server">
							<asp:TableRow>
								<asp:TableCell>
									Frecuencia cardiaca: <asp:Label ID="lbFrec" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									Peso: <asp:Label ID="lbPeso" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									Porcentaje Grasa: <asp:Label ID="lbGrasa" runat="server"></asp:Label>
								</asp:TableCell>
							</asp:TableRow>

							<asp:TableRow>
								<asp:TableCell>
									IMC: <asp:Label ID="lbIMC" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									Cintura: <asp:Label ID="lbCintura" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									Abdomen: <asp:Label ID="lbAbdomen" runat="server"></asp:Label>
								</asp:TableCell>

								<asp:TableCell>
									Cadera: <asp:Label ID="lbCadera" runat="server"></asp:Label>
								</asp:TableCell>
							</asp:TableRow>

							<asp:TableRow>
								<asp:TableCell>
									Muslo: <asp:Label ID="lbMuslo" runat="server"></asp:Label>
								</asp:TableCell>
								<asp:TableCell>
									Estatura: <asp:Label ID="lbEstatura" runat="server"></asp:Label>
								</asp:TableCell>
							</asp:TableRow>
						</asp:Table>--%>			<%--			<br />
						<br />
						<br />
						<br />
					</div>
					<div class="col-md-2"></div>
				</div>
			</div>--%>


	</form>

	<%-- <footer class="footer" style="position: page">
        <h1 class="title">
			<br /><br /><br />
        </h1>
    </footer>--%>
	<p>
		&nbsp;</p>
</body>
</html>

