<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="SeguimSemanal.aspx.cs" Inherits="UI.Nutricion.SeguimSemanal" %>

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
            height: 350px;
            width: 100%;
        }

        table {
            font-family: arial, sans-serif;
            border-collapse: initial;
            width: 50%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 6px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div class="container">
        <div class="tab-content">
            <form runat="server">
                <div id="SeguimientoSemanal" class="tab-pane fade in active">
                    <div class="container">

                        <div class="form-container">
                            <h3>Seguimiento de pesaje semanal:</h3>
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
                                <div class="col-15">
                                    <label class="form-label" for="sCedula">Buscador Historial del Cliente: </label>
                                    <br />
                                    <asp:TextBox ID="sCedula" runat="server" textMode="Number" placeholder="Cédula del Cliente" Width="250"></asp:TextBox>
                                </div>
                                 <div class="col-10">
                                     <p></p>
                                    <asp:Button ID="btnBuscar" Text="Buscar" runat="server"  OnClick="btnBuscar_Click" Font-Size="X-Small" />
                                </div>
                            </div>
                            <div class="row">

                                <div class="col-15">
                                    <label class="form-label" for="sPeso">Peso</label>
                                    <asp:TextBox ID="sPeso" runat="server" placeholder="Peso" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="sOreja">Oreja</label>
                                    <asp:TextBox ID="sOreja" runat="server" placeholder="Oreja" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="sEjercicio">Ejercicio</label>
                                    <asp:TextBox ID="sEjercicio" runat="server" placeholder="Ejercicio" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <p></p>
                                    <asp:Button ID="btnAgreg" Text="Agregar" runat="server" OnClick="btnAgreg_Click" Font-Size="X-Small"/>

                                </div>
                            </div>
                            <br />
                            <br />
                            <div id="div1">

                                <table>
                                    <asp:Literal ID="LitSeguimiento" runat="server"></asp:Literal>
                                </table>

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
