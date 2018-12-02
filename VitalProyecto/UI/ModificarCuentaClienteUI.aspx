<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarCuentaClienteUI.aspx.cs" Inherits="UI.ModificarCuentaClienteUI" %>

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
   <%-- <link rel="stylesheet" href="css/skel.css" />
    <link rel="stylesheet" href="css/style.css" />--%>
    <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen" />
</head>

<body>
    <form id="form1" runat="server">

        <script> 
         function txtRepeticionesZipOnChange(txt) {

            var id = txt.id;

            var primerNum = 0;


           

            // get the validator and check if it is valid
            var val = document.getElementById('<%=RegularExpressionValidator1.ClientID%>');
            if (val.isvalid == false) {
                document.getElementById('<%=tTelefono.ClientID%>').value = "";
                //document.getElementById('Cuerpo_grdEjercicios_txtSeries_' + primerNum).text = "";
            }
        }

    </script>
        
        
         
        <!-- Header -->
        <div id="header">
            <div class="container">
                <div id="logo">
                    <h1><a style="text-decoration: none;" href="ClientePrincipal.aspx">Vital</a></h1>
                </div>
                <div>
                    <nav id="nav">
                        <ul>

                            <li><a href="PagInicio.aspx">Cerrar Sesión</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>

        <div style="background-color: gainsboro;">
            <img src="../images/banner_admin01.jpg" style="width: 100%" />
        </div>

        &nbsp;&nbsp;&nbsp;&nbsp;
		<br /><br />
        <div class="container">
        <asp:Button ID="Button1" Text="Regresar" runat="server" OnClick="Button1_Click" Font-Size="Small" />

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
				<br />
				Nombre:
				<asp:TextBox class="form-control" Width="500px" ID="tnombre" runat="server" Enabled="false"></asp:TextBox>
				<br />
				Cédula:
				<asp:TextBox class="form-control" Width="500px" ID="tcedula" runat="server" Enabled="false"></asp:TextBox>
				<br />
				Correo:
				<asp:TextBox class="form-control" Width="500px" ID="tcorreo" runat="server" Enabled="false"></asp:TextBox>
				<br />
				Fecha de nacimiento: 
				<asp:TextBox class="form-control" Width="500px" ID="tfehcaN" runat="server" Enabled="false"></asp:TextBox>
				<br />
				Teléfono:  
				<asp:TextBox class="form-control" Width="500px" ID="tTelefono" runat="server" placeholder="Ejm: 83978140" onClick="validarRegularExpresion1(this)" onChange="txtRepeticionesZipOnChange(this);"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tTelefono" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                            ControlToValidate="tTelefono" runat="server"
                                            ErrorMessage="Números"
                                            SetFocusOnError="true"
                                            ForeColor="red"
                                            ValidationExpression="\d+">
                </asp:RegularExpressionValidator>
				<br />
				Contraseña: 
				<asp:TextBox class="form-control" Width="500px" ID="tclave" runat="server" TextMode="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tclave" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
				<br />
				Confirmar contraseña:   
				<asp:TextBox class="form-control" Width="500px" ID="tclave2" runat="server" TextMode="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tclave2" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
				<asp:Label ID="ValidadorClaves" runat="server" Visible="false" Text="Las claves no coinciden" ForeColor="Red"></asp:Label>
				<asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="AllValidators" />
			</div>
			<br />
            <asp:Button ID="btnModificar" Text="Modificar" runat="server" OnClick="btnModificar_Click" Font-Size="Small" ValidationGroup="validaciones" />
			<br />
		</div>
		<br />
    </form>

  <footer class="footer" style="position: relative">
		<h1 class="title">Gimnasio Vital y Nutrición</h1>
        Vital San Ramón, mas que un gimnasio es tu espacio.
    </footer>

</body>
</html>
