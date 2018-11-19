<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="BancoRutinas.aspx.cs" Inherits="UI.BancoRutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <link href="admin_estilos.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <script>
        function guardarNombre(nombre) {
            __doPostBack("Nombre", nombre);
        }
    </script>
    <form id="form1" runat="server">

        <div class="container">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8">


                    <asp:Button ID="BtnCrearRutina" runat="server" Text="Crear Rutina" OnClick="BtnCrearRutina_Click" class="button" BackColor="darkolivegreen"/>

                    <asp:Table ID="Rutinas" runat="server" class="table table-bordered text-center table-hover">
                    </asp:Table>

                </div>
                <div class="col-md-2"></div>
            </div>
        </div>
    </form>
</asp:Content>
