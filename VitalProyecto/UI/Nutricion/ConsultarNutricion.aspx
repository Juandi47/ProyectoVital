<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" CodeBehind="ConsultarNutricion.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="UI.Nutricion.ConsultarNutricion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="/css/tabla.css" />
    <script src="js/alertify.min.js"></script>
    <link rel="stylesheet" href="/css/alertify.min.css" />
    <link rel="stylesheet" href="/css/semantic.min.css" />
    <script src="/alertify.js"></script>
    <script src="/mensaje.js"></script>

    <script type="text/javascript">
        function mensaje() {
            alertify.success("Se eliminó el registro exitosamente");
        }
    </script>
    <script type="text/javascript">
        function error() {
            alertify.error("Registro no se eliminó correctamente");
        }
    </script>
    <style>
        #div1 {
            overflow: scroll;
            height: 250px;
            width: 75%;
        }

        table {
            font-family: arial, sans-serif;
            border-collapse: inherit;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 10px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>

    <link rel="stylesheet" href="css/style.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div class="container">
        <div class="tab-content">
            <form runat="server">
                <div id="Consultar" class="tab-pane fade in active">
                    <div class="container">
                        <div class="form-container">
                            <h3>Lista Clientes de Nutrición:</h3>

                            <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
                            <asp:ScriptManager ID="sp" runat="server"></asp:ScriptManager>
                            <asp:Timer ID="timerTest" runat="server" Interval="1000" OnTick="timerTest_Tick"></asp:Timer>
                            <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Label ID="Fecha" Text="Fecha:" runat="server"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="timerTest" EventName="tick" />
                                </Triggers>
                            </asp:UpdatePanel>
                            <br />
                            <div class="row">
                                <div class="col-10">
                                    <label class="form-label" for="sCedula">Busqueda: </label>
                                    <asp:TextBox ID="sBusqueda" runat="server" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <p></p>
                                    <asp:Button ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click" Font-Size="X-Small" />
                                    <asp:Button ID="btnAtras" Text="Atrás" runat="server" OnClick="btnAtras_Click" Visible="false" Font-Size="X-Small" />
                                </div>
                            </div>
                            <div class="row">

                                <div class="col-60" id="div1">
                                    <table>
                                        <asp:Literal ID="LitConsultar" runat="server"></asp:Literal>
                                    </table>
                                </div>

                                <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
                                <script type="text/javascript">   
                                    function Ver_Click(num) {
                                        $.ajax({
                                            type: "POST",
                                            url: '../Nutricion/ConsultarNutricion.aspx/VerDetalleCliente',
                                            data: '{ced:' + num + '}',
                                            contentType: "application/json; charset=utf-8",
                                            dataType: "json",
                                            async: true,
                                            success: function (info) {
                                                $('#M').html(info.d);
                                            },
                                            error: function () {
                                                alert("Acción Denegada");
                                            }
                                        });
                                    }
                                </script>


                                <script type="text/javascript">   
                                    function Eliminar_Click(num) {
                                        $.ajax({
                                            type: "POST",
                                            url: '../Nutricion/ConsultarNutricion.aspx/EliminarCliente',
                                            data: '{ced:' + num + '}',
                                            contentType: "application/json; charset=utf-8",
                                            dataType: "json",
                                            async: true,
                                            success: function () {
                                                mensaje;
                                            },
                                            error: function () {
                                                error;
                                            }
                                        });
                                    }

                                </script>

                            </div>
                             <div id="M" class="row">
                                    <asp:Literal runat="server"></asp:Literal>
                             </div>
                        </div>
                    </div>
                </div>
            </form>
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
