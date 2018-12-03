<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ActualizacionCliente.aspx.cs" Inherits="UI.ActualizacionCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
     <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen">
    <script src="js/alertify.min.js"></script>



	<link rel="stylesheet" href="/css/alertify.min.css" />
	<link rel="stylesheet" href="/css/semantic.min.css" />
	<script src="/alertify.js"></script>
	<script src="/mensaje.js"></script>

	<script type="text/javascript">
		function mensaje(){	
			alertify.success("El expediente ha sido actualizado");     
		}
	</script>

		<script type="text/javascript">
		function error(){	
			alertify.error("El expediente no se ha podido actualizar");     
		}
	</script>



</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

	 <asp:Label ID="labelTitulo" runat="server" CssClass="title">Actualización de clientes:</asp:Label>
		<br />
	<br />
    <div class="form-container" >

        <form id="form1" runat="server">

			<div class="container">
				<div class="row">
					<div class="col-md-6">
						<br /><br />
						Cédula
						<asp:TextBox BackColor="White" class="form-control" ID="txtCed" runat="server" Width="500px"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfCed" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtCed"></asp:RequiredFieldValidator>
						<asp:Label ID="lbCedMala" runat="server" ForeColor="#FF3300"></asp:Label>
						<br />Frecuencia cardiaca
						<asp:TextBox BackColor="White" ID="tfrecCard" class="form-control" runat="server" Width="500px"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfFrec" runat="server" ControlToValidate="tfrecCard" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />Peso(Kg)
						<asp:TextBox class="form-control" ID="tPeso" TextMode="Number" runat="server" Width="500px"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfPeso" runat="server" ControlToValidate="tPeso" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />Porcentaje grasa(%)
						<asp:TextBox class="form-control" ID="tpercentGrasa" runat="server" TextMode="Number" Width="500px"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfGrasa" runat="server" ControlToValidate="tpercentGrasa" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />IMC
						<asp:TextBox class="form-control" ID="tImc" runat="server" TextMode="Number" Width="500px"></asp:TextBox>
						
						<asp:RequiredFieldValidator ID="rfimc" runat="server" ControlToValidate="tImc" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						
						<br />
					</div>

					<div class="col-md-6">
						<br /><br />
						Cintura(cm)
						<asp:TextBox class="form-control" ID="tcintura" runat="server" TextMode="Number" Width="500px"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfCint" runat="server" ControlToValidate="tcintura" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />Abdomen(cm)
						<asp:TextBox ID="tabdomen" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfAbdom" runat="server" ControlToValidate="tabdomen" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />Cadera(cm)<asp:TextBox ID="tCadera" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfCad" runat="server" ControlToValidate="tCadera" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />Muslo(cm)<asp:TextBox ID="tMuslo" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfMuslo" runat="server" ControlToValidate="tMuslo" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />Estatura(cm)<asp:TextBox ID="tEstatura" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfEst" runat="server" ControlToValidate="tEstatura" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
						<br />
					</div>
				</div>
			</div>
			<div class="container">
				<div class="row">
					<div class="col-md-4"></div>
					<div class="col-md-4">
						<br /><br /><br />
						<asp:Button id="btnAñadirExpediente" Text="Añadir a expediente" runat="server" OnClick="btnAñadirExpediente_Click" Height="51px" Width="216px" Font-Size="Small"/>
					</div>
					<div class="col-md-4"></div>
				</div>
			</div>
             
        </form>
    </div>


</asp:Content>