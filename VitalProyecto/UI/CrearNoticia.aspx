<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="CrearNoticia.aspx.cs" Inherits="UI.CrearNoticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen">
    <link rel="stylesheet" href="css/Noticia.css" />
    <link rel="stylesheet" href="css/tabla.css" />
    <script src="js/alertify.min.js"></script>
    <link rel="stylesheet" href="/css/alertify.min.css" />
    <link rel="stylesheet" href="/css/semantic.min.css" />
    <script src="/alertify.js"></script>
    <script src="/mensaje.js"></script>

    <script type="text/javascript">
        function mensaje() {
            alertify.success("La noticia se guardó correctamente");
        }
    </script>
    <script type="text/javascript">
        function error() {
            alertify.error("La noticia no se guardó correctamente");
        }
    </script>
    <script type="text/javascript">
        function errorVacio() {
            alertify.error("No pueden haber campos vacíos");
        }
    </script>
    <script type="text/javascript">
        function borro() {
            alertify.success("La noticia se eliminó correctamente");
        }
    </script>
    <script type="text/javascript">
        function errorBorrar() {
            alertify.error("La noticia no se eliminó correctamente");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="form-container">
        <form id="form1" runat="server">

            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#CrearNoticia">Crear Noticia</a></li>
                <li><a data-toggle="tab" href="#EliminarNoticia">Eliminar Noticia</a></li>
            </ul>
            <div class="tab-content">
                <div id="CrearNoticia" class="tab-pane fade in active">
                    <div class="container">
                        <h3 class="title">Crear Noticias</h3>
                        <div class="col-lg-3">
                            <div class="tableR">
                                <div class="table__row">
                                    <div class="tier">
                                        <h2 class="tier__title tier__color--1">Principal</h2>
                                        <asp:TextBox ID="EncabPrincipal" CssClass="tier__price" runat="server" placeholder="Titulo Noticia"></asp:TextBox>
                                        <asp:TextBox ID="TextoPrincipal" CssClass="tier__price" runat="server" placeholder="Descripcion"></asp:TextBox>
                                        <asp:Button ID="BtnPrincipal" CssClass="tier__cta " runat="server" OnClick="BtnPrincipal_Click" Text="Guardar Noticia" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3">
                            <div class="tableR">
                                <div class="table__row">
                                    <div class="tier">
                                        <h2 class="tier__title tier__color--1">Importante</h2>
                                        <asp:TextBox ID="EncabImportante" CssClass="tier__price" runat="server" placeholder="Titulo Noticia"></asp:TextBox>
                                        <asp:TextBox ID="TextoImportante" CssClass="tier__price" runat="server" placeholder="Descripcion"></asp:TextBox>
                                        <asp:Button ID="BtnImportante" CssClass="tier__cta " runat="server" OnClick="BtnImportante_Click" Text="Guardar Noticia" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3">
                            <div class="tableR">
                                <div class="table__row">
                                    <div class="tier">
                                        <h2 class="tier__title tier__color--1">Info Recientes</h2>
                                        <asp:TextBox ID="EncabReciente" CssClass="tier__price" runat="server" placeholder="Titulo Noticia"></asp:TextBox>
                                        <asp:TextBox ID="TextoReciente" CssClass="tier__price" runat="server" placeholder="Descripcion"></asp:TextBox>
                                        <asp:Button ID="BtnReciente" CssClass="tier__cta " runat="server" OnClick="BtnReciente_Click" Text="Guardar Noticia" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3">
                            <div class="tableR">
                                <div class="table__row">
                                    <div class="tier">
                                        <h2 class="tier__title tier__color--1">Notas</h2>
                                        <asp:TextBox ID="EncabNotas" CssClass="tier__price" runat="server" placeholder="Titulo Noticia"></asp:TextBox>
                                        <asp:TextBox ID="TextoNotas" CssClass="tier__price" runat="server" placeholder="Descripcion"></asp:TextBox>
                                        <asp:Button ID="BtnNotas" CssClass="tier__cta " runat="server" OnClick="BtnNotas_Click" Text="Guardar Noticia" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-75">
                                <h3>Seleccione la imágen para la noticia</h3>
                            </div>
                        </div>

                    </div>
                </div>
                <div id="EliminarNoticia" class="tab-pane fade">
                    <div class="container">
                        <h3 class="title">Eliminar Noticias</h3>
                        <div class="form-container">
                            <table>
                                <asp:Literal ID="TablaEliminar" runat="server"></asp:Literal>
                            </table>
                            <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
                             <script type="text/javascript">   
                                 function Eliminar_Click(num) {
                                        $.ajax({
                                            type: "POST",
                                            url: '../CrearNoticia.aspx/EliminarNoticia',
                                            data: '{clave:' + num + '}',
                                            contentType: "application/json; charset=utf-8",
                                            dataType: "json",
                                            async: true,
                                            success: function () {
                                                alertify.success("La noticia se eliminó correctamente");
                                                location.reload();
                                            },
                                            error: function () {
                                                alertify.error("La noticia no se eliminó correctamente");
                                            }
                                        });
                                 }
                                </script>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>

</asp:Content>
