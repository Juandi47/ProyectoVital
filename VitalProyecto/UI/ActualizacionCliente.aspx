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

    <h1 class="title" style="text-align:center">Actualización de cliente</h1>

    <div class="form-container" style="background-color: #086668">

        <%--<div class="row">
              <div class="col-25">
                  <a href="#" style="color:papayawhip; text-decoration:none; font: bold 20px 'Open Sans', sans-serif">Ver anterior</a>
              </div>
              <div class="col-50" style="text-align:center; vertical-align:central; padding:0; margin:0;">
                  <h1 style="position:center; color:papayawhip">Octubre</h1>
              </div>
              <div class="col-25">
                  <a href="#"style="color:papayawhip; text-decoration:none; font: bold 20px 'Open Sans', sans-serif; float:right;">Ver siguiente</a>
              </div>
			<br /><br /><br /><br /><br />
        </div>--%>


        <form id="form1" runat="server">

			<div class="container">
				<div class="row">
					<div class="col-md-6">
						<br /><br /><br />
						<label class="form-label2" for="tfrec">Cédula </label>
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:TextBox ID="txtCed" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						<label class="form-label2" for="tfrec">Frecuencia cardiaca </label>&nbsp;
						<asp:TextBox ID="tfrec" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						<label class="form-label2" for="tweigth">Peso(Kg)</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:TextBox ID="tweigth" runat="server" TextMode="Number"></asp:TextBox>
						&nbsp;<br />
						<label class="form-label2" for="tpercentWeigth">Porcentaje grasa(%)</label>
						<asp:TextBox ID="tpercentWeigth" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						<label class="form-label2" for="timc">IMC</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:TextBox ID="timc" runat="server" TextMode="Number"></asp:TextBox>
						<br />

					</div>

					<div class="col-md-6">
						<br /><br /><br />
						<label class="form-label2" for="tabdomen">Abdomen(cm)</label>
						<asp:TextBox ID="tabdomen" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						<label class="form-label2" for="thip">Cadera(cm)</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:TextBox ID="thip" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						<label class="form-label2" for="tthigth">Muslo(cm)</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:TextBox ID="tthigth" runat="server" TextMode="Number"></asp:TextBox>
						<br />
						<label class="form-label2" for="theigth">Estatura(cm)</label>&nbsp;&nbsp;
						<asp:TextBox ID="theigth" runat="server" TextMode="Number"></asp:TextBox>
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