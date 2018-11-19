<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ActualizacionCliente.aspx.cs" Inherits="UI.ActualizacionCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
     <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <h2 style="text-align:center">Actualización de cliente</h2>

    <div class="form-container" >

        <form id="form1" runat="server">

			<div class="container">
				<div class="row">
					<div class="col-md-6">
						<br /><br />
						Cédula
						<asp:TextBox ID="txtCed" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						Frecuencia cardiaca
						<asp:TextBox ID="tfrec" runat="server" BackColor="White" Height="10px" Width="180px" BorderColor="Silver"></asp:TextBox>
						<br />
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
						Peso(Kg)
						<asp:TextBox ID="tweigth" runat="server" TextMode="Number"></asp:TextBox>
						&nbsp;<br />
						<br />
						Porcentaje grasa(%)<asp:TextBox ID="tpercentWeigth" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<br />
						IMC
						<asp:TextBox ID="timc" runat="server" TextMode="Number"></asp:TextBox>
						<br />

					</div>

					<div class="col-md-6">
						<br /><br /><br />
						&nbsp;<br />
						Abdomen(cm)
						<asp:TextBox ID="tabdomen" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<br />
						Cadera(cm)<asp:TextBox ID="thip" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<br />
						Muslo(cm)<asp:TextBox ID="tthigth" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						&nbsp;&nbsp;
						<br />
						Estatura(cm)<asp:TextBox ID="theigth" runat="server" TextMode="Number"></asp:TextBox>
						<br />
					</div>
				</div>
			</div>
			<div class="container">
				<div class="row">
					<div class="col-md-3"></div>
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