<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ActualizacionCliente.aspx.cs" Inherits="UI.ActualizacionCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
     <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen">
    <script src="js/alertify.min.js"></script>
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
						Frecuencia cardiaca
						<asp:TextBox BackColor="White" ID="tfrecCard" class="form-control" runat="server" Width="500px"></asp:TextBox>
						Peso(Kg)
						<asp:TextBox class="form-control" ID="tPeso" TextMode="Number" runat="server" Width="500px"></asp:TextBox>
						Porcentaje grasa(%)
						<asp:TextBox class="form-control" ID="tpercentGrasa" runat="server" TextMode="Number" Width="500px"></asp:TextBox>
						IMC
						<asp:TextBox class="form-control" ID="tImc" runat="server" TextMode="Number" Width="500px"></asp:TextBox>
						
						<br />
					</div>

					<div class="col-md-6">
						<br /><br />
						Cintura(cm)
						<asp:TextBox class="form-control" ID="tcintura" runat="server" TextMode="Number" Width="500px"></asp:TextBox>
						Abdomen(cm)
						<asp:TextBox ID="tabdomen" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
						Cadera(cm)<asp:TextBox ID="tCadera" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
						Muslo(cm)<asp:TextBox ID="tMuslo" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
						Estatura(cm)<asp:TextBox ID="tEstatura" runat="server" TextMode="Number" Width="500px" class="form-control"></asp:TextBox>
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