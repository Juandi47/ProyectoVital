<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Gestion_Admin.aspx.cs" Inherits="UI.Gestion_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">



    <script>
        function mostrarDatosUsuario(cedula, nombre, correo, id) {
            if (document.getElementById) { //se obtiene el id
                var el = document.getElementById('Cuerpo_' + id); //se define la variable "el" igual a nuestro div
                el.style.display = (el.style.display == 'none') ? 'block' : 'none'; //damos un atributo display:none que oculta el div
            }

            document.getElementById('Cuerpo_LabelCedula').textContent = cedula;
            document.getElementById('Cuerpo_LabelNombre').textContent = nombre;
            document.getElementById('Cuerpo_LabelCorreo').textContent = correo;
        }

    </script>
	<br /><br />
    <%-- DIV DE DESPLIEGUE DE INGRESO DE CREDENCIALES --%>
    <div id="datosUsuario" class="col-sm-5 datosUsuario" runat="server" style="display: none">
        <asp:Label ID="Label8" runat="server" Text="Label" CssClass="h3">Información de usuario</asp:Label>
        <asp:Table runat="server" CssClass="tablaRes">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelCedula" CssClass="form-label" runat="server" Text="Cedula  :"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelNombre" CssClass="form-label" runat="server" Text="Nombre  :"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelCorreo" CssClass="form-label" runat="server" Text="Correo  :"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <%--<asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btnCred small" OnClick="btnAceptar_Click" />--%>
    </div>

    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <asp:Table ID="Administrador" runat="server" class="table table-bordered text-center table-hover-cells">
                    </asp:Table>
                </div>
                <div class="col-md-1"></div>
            </div>
        </div>
    </form>


</asp:Content>
