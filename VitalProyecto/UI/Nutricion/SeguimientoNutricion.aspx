<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="SeguimientoNutricion.aspx.cs" Inherits="UI.Nutricion.SeguimientoNutricion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="css/tabla.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div class="container">
        <form runat="server">
            <h2>Seguimientos nutricionales</h2>
            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#SeguimientosNutri">Seguimiento Nutricional</a></li>
                <li><a data-toggle="tab" href="#Antropometría">Antropometría</a></li>
            </ul>

            <div class="tab-content">

                <div id="SeguimientosNutri" class="tab-pane fade in active">
                    <div class="container">
                        <h3>Seguimiento Mensual:</h3>
                        <div class="form-container">
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
                                    <label class="form-label" for="tCedula">Cedula</label><br />
                                    <asp:TextBox ID="tCedula" runat="server" TextMode="Number" placeholder="Cédula" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tDiasEjer">Días de ejercicio semanales:</label>
                                    <asp:TextBox ID="tDiasEjer" runat="server" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tComExtras">Comidas extras:</label>
                                    <asp:TextBox ID="tComExtras" runat="server" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tNivelAnsiedad">Niveles de Ansiedad semanal y tiempo de comida en donde lo siente</label>
                                    <asp:TextBox ID="tNivelAnsiedad" runat="server"  Width="250"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <h4>Recordatorio 24 Horas</h4>
                            <div class="row">
                                <div class="col-10">
                                    <asp:TextBox ID="r24TiempoComida" runat="server" placeholder="Tiempo de Comida"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="r24Descripcion" runat="server" placeholder="Descripcion"></asp:TextBox>
                                </div>
                                <div class="col-10">

                                    <asp:Button ID="r24Agrega" Text="Agregar" runat="server" OnClick="r24Agrega_Click" Font-Size="X-Small"/>

                                </div>
                            </div>

                            <div class="row">
                                <div class="col-75">
                                     <table>
                                    <asp:Literal ID="r24Tabla" runat="server"></asp:Literal>
                                </table>
                                </div>
                               
                            </div>
                            <br />
                            <br />
                            <br />
                        </div>

                    </div>
                </div>

                <%--Seccion Antropometría--%>
                <div id="Antropometría" class="tab-pane fade">
                    <div class="container">
                        <div class="row">
                            <h3>Antropometría:</h3>
                        </div>
                        <div class="form-container">


                            <div class="row">
                                <%-- Columna 1--%>
                                <div class="col-25">
                                    <div class="col-15">
                                        <label class="form-label" for="tTalla">Talla</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tTalla" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPesoIdeal">Peso Meta o Ideal</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPesoIdeal" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tEdad">Edad</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tEdadNut" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPMB">PMB</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPMB" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPeso">Peso</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPeso" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tIMC">IMC</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tIMC" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuslo">Muslo</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuslo" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tBrazo">Brazo</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tBrazo" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- Columna 2--%>
                                <div class="col-25">
                                    <div class="col-15">
                                        <label class="form-label" for="tPorcGAnalizador">% Grasa Analizador</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGAnalizador" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPorcGBascula">% Grasa Báscula</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGBascula" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascBI">BI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascBI" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascBD">BD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascBD" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascPD">PD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascPD" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascPI">PI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascPI" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascTronco">Tronco</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascTronco" runat="server"></asp:TextBox>
                                    </div>

                                </div>
                                <%-- Columna 3--%>
                                <div class="col-25">

                                    <div class="col-15">
                                        <label class="form-label" for="tPorcGVisceral">% Grasa Visceral</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGVisceral" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPorcMusculo">% Músculo</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGMusculo" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscBI">BI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscBI" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscBD">BD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscBD" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscPD">PD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscPD" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscPI">PI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscPI" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscTronco">Tronco</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscTronco" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-25">
                                    <div class="col-15">
                                        <label class="form-label" for="tAguaNut">Agua Corporal</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tAguaNut" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMasaOsea">Masa ósea</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMasaOsea" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tComplexión">Complexión</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tComplexión" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tEdadMetabolica">Edad Metabolica</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tEdadMetabolica" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tCintura">Cintura</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tCintura" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tAbdomen">Abdomen</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tAbdomen" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tCadera">Cadera</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tCadera" runat="server"></asp:TextBox>
                                    </div>
                                    

                                    <div class="col-15">
                                        <label class="form-label" for="tObservacion">Observacion</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tObservacion" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-25">
                                <asp:Button ID="btnCrear" Text="Crear" runat="server" OnClick="btnCrear_Click" Font-Size="Smaller"/>
                            </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
