<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ModificarAdmin.aspx.cs" Inherits="UI.ModificarAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
 <script src="js/alertify.min.js"></script>
	<link rel="stylesheet" href="/css/alertify.min.css" />
	<link rel="stylesheet" href="/css/semantic.min.css" />
	<script src="/alertify.js"></script>
	<script src="/mensaje.js"></script>
	
	<script type="text/javascript">
		function mensaje() {
			alertify.success("Administrador modificado correctamente");
		}
	</script>

	<script type="text/javascript">
		function error() {
			alertify.error("Error");
		}
	</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="container">

        <h1 class="title">Modificar Administrador</h1>

        <div class="form-container">
            <form runat="server">

                <br />
                   Cédula: <asp:TextBox class="form-control" Width="500px"  ID="tced" runat="server" MaskedTextBox="0-000-000" Enabled="false"></asp:TextBox>
                  <br />
                       Nombre: <asp:TextBox class="form-control" Width="500px" ID="tname" runat="server"  placeholder="María"></asp:TextBox>
                   <br />
                        Primer apellido: <asp:TextBox class="form-control" Width="500px" ID="tlname1" runat="server"  placeholder="Arias"></asp:TextBox>
                   <br />
                        Segundo apellido: <asp:TextBox class="form-control" Width="500px" ID="tlname2" runat="server"  placeholder="Rojas"></asp:TextBox>
                  <br />
                       Contraseña: <asp:TextBox class="form-control" Width="500px" ID="tclave" runat="server" TextMode ="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
                    <br />
                      Confirmar contraseña: <asp:TextBox class="form-control" Width="500px" ID="tclave2" runat="server" TextMode ="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
                   <br />
                       Correo: <asp:TextBox class="form-control" Width="500px" ID="temail" runat="server"  placeholder="Ejm: maria.rojas@gmail.com" TextMode ="Email" Enabled="false" ValidationGroup="AllValidators"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="temail" Display="Dynamic" ErrorMessage="Se requiere la dirección de correo electrónico" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="temail" Display="Dynamic" ErrorMessage="Las direcciones de correo electrónico deben estar en el formato nombre@dominio.xyz." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators">Formato no válido.</asp:RegularExpressionValidator>
                <br />
                      <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="AllValidators" />
             <br />
                <asp:Button id="btnModificar" Text="Modificar" runat="server" OnClick="BtnModificar_Click" Font-Size="Small" />
                <br /><br />
            </form>
			<br />
        </div>
            
            <br />        
    </div>

</asp:Content>
