<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" CodeBehind="ConsultarNutricion.aspx.cs" Inherits="UI.Nutricion.ConsultarNutricion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="/css/tabla.css" />

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
                            <asp:Label ID="Fecha" Text="Fecha:" runat="server"></asp:Label>
                            <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
                            <asp:ScriptManager ID="sp" runat="server"></asp:ScriptManager>
                            <asp:Timer ID="timerTest" runat="server" Interval="1000" OnTick="timerTest_Tick"></asp:Timer>
                            <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <%--<asp:Literal runat="server" ID="t"></asp:Literal>--%>
                                    <%--<asp:Button ID="Button3" CssClass="button button2" runat="server" Text="Text" OnClick="Page_Load"/>--%>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="timerTest" EventName="tick" />
                                </Triggers>
                            </asp:UpdatePanel>

                            <div class="row">
                                <div class="col-10">
                                    <label class="form-label" for="sCedula">Busqueda: </label>
                                    <asp:TextBox ID="sBusqueda" runat="server" Width="100"></asp:TextBox>
                                    <asp:Button ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click" />
                                    <asp:Button ID="btnAtras" Text="Atrás" runat="server" OnClick="btnAtras_Click" Visible="false" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-75">
                                    <div id="div1">
                                        <table>
                                            <asp:Literal ID="LitConsultar" runat="server"></asp:Literal>
                                        </table>
                                    </div>
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
                                                alert("" + info.d);
                                                $('#lblVer').text(info.d);
                                            },
                                            error: function (XMLHttpRequest, textStatus, errorThrown) {
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
                                                alert("Cliente Eliminado");
                                            },
                                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                                alert("Acción Denegada");
                                            }
                                        });
                                    }

                                </script>

                            </div>
                            <div class="row">
                                <div id="lblVer">
                                    <%--<p style="border: ridge #0f0fef 1px;" id="lblVer"></p>--%>
                                </div>
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
