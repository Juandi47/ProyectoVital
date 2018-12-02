<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Crear_Admin.aspx.cs" Inherits="UI.Crear_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
	<div class="container">

        <h1 class="title">Registro de Administrador</h1>

        <div class="form-container">
            <form runat="server">

               
						Cédula:
                        <asp:TextBox class="form-control" Width="500px" ID="tced" runat="server" placeholder="(Sin espacios) Ej: 202220555" MaskedTextBox="0-000-000" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tced" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios"></asp:RequiredFieldValidator>
                        <asp:Label ID="ValidadorCedulaExistente" runat="server" Visible="false" Text="Ya existe esta cédula" ForeColor="Red"></asp:Label>
                        <asp:Label ID="ValidadorCedulaFormato" runat="server" Visible="false" Text="Formato cédula inválido" ForeColor="Red"></asp:Label>
						<br />
						Nombre:
                        <asp:TextBox class="form-control" Width="500px" ID="tname" runat="server" placeholder="María" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tname" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ForeColor="Red"
                            ControlToValidate="tname" runat="server"
                            ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z ]*$" Font-Bold="True">
                                        Sólo se admiten letras
                        </asp:RegularExpressionValidator>
					<br />
						Primer apellido:
                        <asp:TextBox class="form-control" Width="500px" ID="tlname1" runat="server" placeholder="Arias" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tlname1" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ForeColor="Red"
                            ControlToValidate="tlname1" runat="server"
                            ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z ]*$" Font-Bold="True">
                                        Sólo se admiten letras
                        </asp:RegularExpressionValidator>
           <br />
						Segundo apellido:
                        <asp:TextBox class="form-control" Width="500px" ID="tlname2" runat="server" placeholder="Rojas" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="tlname2" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" ForeColor="Red"
                            ControlToValidate="tlname2" runat="server"
                            ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z ]*$" Font-Bold="True">
                                        Sólo se admiten letras
                        </asp:RegularExpressionValidator>
               <br />
						Contraseña:
                        <asp:TextBox class="form-control" Width="500px" ID="tclave" runat="server" placeholder="Ejm: Cla.123" TextMode="Password" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="tclave" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios"></asp:RequiredFieldValidator>
              <br />
						Confirmar contraseña:
                        <asp:TextBox class="form-control" Width="500px" ID="tclave2" runat="server" placeholder="Ejm: Cla.123" TextMode="Password" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="tclave2" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios"></asp:RequiredFieldValidator>
                        <asp:Label ID="ValidadorClaves" runat="server" Visible="false" Text="Las claves no coinciden" ForeColor="Red"></asp:Label>
          <br />
						Correo:<br />
                        <asp:TextBox class="form-control" Width="500px" ID="temail" runat="server" placeholder="Ejm: maria.rojas@gmail.com" TextMode="Email" ValidationGroup="AllValidators" MaxLength="50"></asp:TextBox>
                        <asp:Label ID="ValidadorExistenciaCorreo" runat="server" Visible="false" Text="Este correo ya existe" ForeColor="Red"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="temail" ErrorMessage="Se deben completar todos los espacios">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="temail" Display="Dynamic" ErrorMessage="Las direcciones de correo electrónico deben estar en el formato nombre@dominio.xyz." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators" ForeColor="Red" Font-Bold="True">Formato no válido.</asp:RegularExpressionValidator>
            
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="AllValidators" />
  <br /><br />
                <asp:Button ID="btnCrear" Text="Crear" runat="server" OnClick="BtnRegistrar_Click" Font-Size="Small" />
				<br />
            </form>
			<br />
        </div>

		<br />
    </div>


</asp:Content>
