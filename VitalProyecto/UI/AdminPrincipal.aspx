<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="~/AdminPrincipal.aspx.cs" Inherits="UI.AdminPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
	<form id="form1" runat="server">
		<div>



			<br />

			<div class="container">
				<div class="row">
					<div class="col-sm-4"></div>
					<div class="col-md-4">
						<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#333300" Text="¡Hola! Bienvenido su sitio de trabajo"></asp:Label>

						<br />
						<br />
						<asp:Button ID="btnSalir" runat="server" Font-Size="Small" Text="Cerrar Sesión" OnClick="btnSalir_Click" />
					</div>
					<div class="col-md-4"></div>
				</div>

				<br />
						<br />

				<div class="row"></div>
			</div>

			

		</div>
    </form>
</asp:Content>
