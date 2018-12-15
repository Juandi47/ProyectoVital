<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="IngresoNutricion.aspx.cs" Inherits="UI.Nutricion.IngresoNutricion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="css/tabla.css" />
    <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen">
     <script src="js/alertify.min.js"></script>
    <link rel="stylesheet" href="/css/alertify.min.css" />
    <link rel="stylesheet" href="/css/semantic.min.css" />
    <script src="/alertify.js"></script>
    <script src="/mensaje.js"></script>

    <script type="text/javascript">
        function mensaje() {
            alertify.success("Se creó el cliente exitosamente");
        }
    </script>
    <script type="text/javascript">
        function error() {
            alertify.error("Cliente no se registró correctamente");
        }
     </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
	<div class="container">
        <form runat="server">
            <h2>Crear Clientes</h2>
            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#DatosPersonales">Datos Personales</a></li>
                <li><a data-toggle="tab" href="#HistorialMedico">Historial Médico</a></li>
                <li><a data-toggle="tab" href="#HabitosAlimentarios">Habitos Alimentarios</a></li>
                <li><a data-toggle="tab" href="#Antropometría">Antropometría</a></li>
            </ul>

            <div class="tab-content">
                <div id="DatosPersonales" class="tab-pane fade in active">
                    <div class="container">
                        <h3 class="title">Historial Nutrición Anamnesis</h3>
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

                            <h3>Datos Personales:</h3>
                            <div class="row">
                                <div class="col-10">
                                    <label class="form-label" for="tCedula">Cedula</label>
                                    <br />
                                    <asp:TextBox ID="tCedula" runat="server" TextMode="Number" placeholder="Cédula" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tnombre">Nombre</label>
                                    <asp:TextBox ID="tnombre" runat="server" placeholder="Nombre" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tApellid1">Apellido 1</label>
                                    <asp:TextBox ID="tApellid1" runat="server" placeholder="Apellido 1" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tApellid2">Apellido 2</label>
                                    <asp:TextBox ID="tApellid2" runat="server" placeholder="Apellido 2" Font-Size="Small"></asp:TextBox>
                                </div>

                                <div class="col-10">
                                    <label class="form-label" for="tFechNac">Fecha Nacimiento</label>
                                    <br />
                                    <asp:TextBox ID="tFechNac" runat="server" TextMode="Date" OnTextChanged="tFechNac_TextChanged" Font-Size="Medium"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-10">
                                    <label class="form-label" for="tTelef">Telefono</label>
                                    <br />
                                    <asp:TextBox ID="tTelef" runat="server" TextMode="Phone" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tSexo">Sexo</label>
                                    <br />
                                    <asp:DropDownList ID="tSex" runat="server" Font-Size="Small"></asp:DropDownList>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tEstCivil">Estado Civil</label>
                                    <br />
                                    <asp:DropDownList ID="tEstCivil" runat="server" Font-Size="Small"></asp:DropDownList>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tResid">Residencia</label>
                                    <asp:TextBox ID="tResid" runat="server" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tEdad">Edad</label>
                                    <br />
                                    <asp:TextBox ID="tEdad" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                            </div>
                        <h3>Datos Socioeconómicos:</h3>
                        <div class="row">
                            <div class="col-25">
                                <label class="form-label" for="tOcupacion">Ocupación</label>
                                <asp:TextBox ID="tOcupacion" runat="server" Font-Size="Small"></asp:TextBox>
                            </div>
                        </div>
                        <h3>Actividad Física</h3>
                        <div class="row">
                            <div class="col-25">
                                <asp:TextBox ID="ActFisica" runat="server" Font-Size="Small"></asp:TextBox>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
                <div id="HistorialMedico" class="tab-pane fade">
                    <div class="container">
                        <h3>Historial Médico:</h3>
                        <div class="form-container">

                            <div class="row">
                                <div class="col-10">
                                    <label class="form-label" for="tAnteced">Antecedentes Familiares</label>
                                    <asp:TextBox ID="tAnteced" runat="server" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tPatolog">Patologías que padece</label>
                                    <asp:TextBox ID="tPatolog" runat="server" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tConsLicor">Licor:</label>
                                    <br />
                                    <asp:DropDownList ID="tConsLicr" runat="server" Font-Size="Small"></asp:DropDownList>
                                </div>
                                <div class="col-10">
                                    <br />
                                    <asp:TextBox ID="tFrecLicor" runat="server" placeholder="Frecuencia" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tConsFuma">Fuma</label>
                                    <br />
                                    <asp:DropDownList ID="tConsFum" runat="server" Font-Size="Small"></asp:DropDownList>
                                </div>
                                <div class="col-10">
                                    <br />
                                    <asp:TextBox ID="tFrecFuma" runat="server" placeholder="Frecuencia" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="tFech">Fecha de últimos exámenes de sangre o revisión médica</label>
                                    <br />
                                    <asp:TextBox ID="tFechRevis" runat="server" TextMode="Date" Font-Size="Medium"></asp:TextBox>
                                </div>
                            </div>
                            <h3>Medicamentos o suplementos que consume:</h3>
                            <div class="row">
                                <div class="col-20">
                                    <asp:TextBox ID="tNomMed" runat="server" placeholder="Nombre" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-20">
                                    <asp:TextBox ID="tMotvMed" runat="server" placeholder="Motivo" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-20">
                                    <asp:TextBox ID="tFrecMed" runat="server" placeholder="Frecuencia" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-20">
                                    <asp:TextBox ID="tDosisMed" runat="server" placeholder="Dosis" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-20">

                                    <asp:Button ID="btnAgreg" Text="Agregar" runat="server" OnClick="BtnAgreg_Click" Font-Size="X-Small" />

                                </div>
                            </div>

                            <div class="row">
                                <table>
                                    <asp:Literal ID="tSuplementoMedico" runat="server"></asp:Literal>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="HabitosAlimentarios" class="tab-pane fade">
                    <div class="container">
                        <h3>Habitos Alimentarios</h3>
                        <div class="form-container">
                            <div class="row">
                                <div class="col-15">
                                    <label class="form-label" for="CostHordia">¿Acostumbra a comer a las horas al día?</label>
                                    <br />
                                    <asp:DropDownList ID="CostHorDia" runat="server" Font-Size="Small"></asp:DropDownList>
                                </div>

                                <div class="col-35">
                                    <label class="form-label" for="cuanExpress">¿Cuántas veces a la semana come fuera o pide un express?</label>
                                    <br />
                                    <asp:TextBox ID="cuanExpress" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="CuantAzucar">¿Cuánta azucar le agrega a las bebidas?</label>
                                    <br />
                                    <asp:TextBox ID="CuantAzucar" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-15">
                                    <label class="form-label" for="queComeAfuera">¿Generalmente que come fuera de la casa?</label>
                                    <br />
                                    <asp:TextBox ID="queComeAfuera" runat="server" Font-Size="Small"></asp:TextBox>
                                </div>

                                <div class="col-35">
                                    <label class="form-label" for="cocinaElabora">¿Los alimentos que cocina los elabora generalmente?</label>
                                    <br />
                                    <asp:DropDownList ID="cocinaElabora" runat="server" Font-Size="Small"></asp:DropDownList>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="aguAlDia">¿Cuántos vasos de agua toma al día?</label>
                                    <br />
                                    <asp:TextBox ID="aguAlDia" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>


                            </div>


                            <div class="row">
                                <div class="col-15">
                                    <label class="form-label" for="VecesComid">¿Cuántas veces come al día?</label>
                                    <br />
                                    <asp:TextBox ID="VecesComid" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-35">
                                    <label class="form-label" for="Aderezos">¿Agrega salsa de tomate, mayonesa, mantequilla o natilla a la comida?</label>
                                    <br />
                                    <asp:DropDownList ID="Aderezos" runat="server" Font-Size="Small"></asp:DropDownList>
                                </div>

                            </div>


                            <div class="row">
                                <div class="col-30">
                                    <label class="form-label" for="GustosComida">Le gustan la mayoría de: </label>
                                </div>
                                <div class="col-70">
                                    <asp:CheckBoxList runat="server" ID="checkListGustos" RepeatColumns="3" TextAlign="Right" ></asp:CheckBoxList>
                                </div>
                            </div>

                            <h3>Recordatorio 24 Horas</h3>
                            <div class="row">
                                <div class="col-10">
                                    <asp:TextBox ID="r24TiempoComida" runat="server" placeholder="Tiempo de Comida" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="r24Alimento" runat="server" placeholder="Alimento" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="r24Cantidad" runat="server" placeholder="Cantidad" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="r24Descripcion" runat="server" placeholder="Descripcion" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:Button ID="r24Agrega" Text="Agregar" runat="server" OnClick="R24Agrega_Click" Font-Size="X-Small" />
                                </div>
                            </div>

                            <div class="row">
                                <table class="div1">
                                    <asp:Literal ID="r24Tabla" runat="server"></asp:Literal>
                                </table>
                            </div>
                            <br />
                            <br />
                        </div>
                    </div>
                </div>
                <div id="Antropometría" class="tab-pane fade">
                    <div class="container">
                        <div class="row">
                            <h3>Antropometría:</h3>

                        </div>
                        <div class="form-container">
                            <div class="row">
                                <div class="col-25">
                                    <div class="col-15">
                                        <label class="form-label" for="tEdad">Edad</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tEdadNut" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPesoActual">Peso Actual</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPesoActual" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPesoMaxTeoria">Peso máximo en teoría</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPesoMaxTeoria" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPesoMeta">Peso Meta o Ideal</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPesoMeta" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tEdadMetabolica">Edad Metabolica</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tEdadMetabolica" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tAguaNut">Agua</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tAguaNut" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tComplexión">Complexión</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tComplexión" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tObservacion">Observacion</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tObservacion" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-25">
                                    <div class="col-15">
                                        <label class="form-label" for="tAbdomen">Abdomen</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tAbdomen" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tCadera">Cadera</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tCadera" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tTalla">Talla</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tTalla" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tCircunfMun">Circunferencia muñeca</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tCircunfMun" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tIMC">IMC</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tIMC" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuslo">Muslo</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuslo" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPMB">PMB</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPMB" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tCBM">CBM</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tCBM" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-25">
                                    <div class="col-15">
                                        <label class="form-label" for="tCintura">Cintura</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tCintura" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMasaOsea">Masa ósea</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMasaOsea" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPorcGBascula">% Grasa Báscula</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGBascula" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascBI">BI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascBI" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascBD">BD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascBD" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascPD">PD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascPD" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascPI">PI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascPI" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tGBascTronco">Tronco</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tGBascTronco" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-25">
                                    <div class="col-15">
                                        <label class="form-label" for="tPorcGAnalizador">% Grasa Analizador</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGAnalizador" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPorcGVisceral">% Grasa Visceral</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGVisceral" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tPorcMusculo">% Músculo</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tPorcGMusculo" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscBI">BI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscBI" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscBD">BD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscBD" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscPD">PD</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscPD" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscPI">PI</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscPI" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                    <div class="col-15">
                                        <label class="form-label" for="tMuscTronco">Tronco</label>
                                    </div>
                                    <div class="col-35">
                                        <asp:TextBox ID="tMuscTronco" runat="server" Font-Size="Small"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <h3>GEB:</h3>
                            <div class="row">
                                <div class="col-15">
                                    <asp:Label CssClass="form-label" runat="server" ID="GEBLblMujer" Text="Mujer:  "></asp:Label>
                                    <br />
                                </div>
                                <div class="col-20">
                                    <asp:TextBox ID="GEBPI" runat="server" placeholder="PI" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="GEBTcm" runat="server" placeholder="T(cm)" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="GEBEdad" runat="server" placeholder="Edad" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:Button ID="GEBMujer" Text="Calcular" runat="server" OnClick="GEBMujer_Click" Font-Size="X-Small" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-15">
                                    <asp:Label CssClass="form-label" runat="server" ID="GEBlblHomb" Text="Hombre: "></asp:Label>
                                    <br />
                                </div>
                                <div class="col-20">
                                    <asp:TextBox ID="GEBHomPI" runat="server" placeholder="PI" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="GEBHomTcm" runat="server" placeholder="T(cm)" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="GEBHomEdad" runat="server" placeholder="Edad" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:Button ID="GEBHombre" Text="Calcular" runat="server" OnClick="GEBHombre_Click" Font-Size="X-Small" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-15">
                                    <asp:Label CssClass="form-label" runat="server" ID="GEBlblMenores" Text="Menores de 10 años: "></asp:Label>
                                </div>
                                <div class="col-20">
                                    <asp:TextBox ID="GEBMenorPI" runat="server" placeholder="PI" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="GEBMenorTcm" runat="server" placeholder="T(cm)" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <asp:Button ID="GEBMenores" Text="Calcular" runat="server" OnClick="GEBMenores_Click" Font-Size="X-Small" />
                                </div>
                            </div>

                            <h3>GET:</h3>
                            <div class="row">
                                <div class="col-15">
                                    <asp:Label CssClass="form-label" runat="server" ID="GETlbl" Text=" kcal= "></asp:Label>

                                </div>
                                <div class="col-20">
                                    <asp:TextBox ID="GETkcal" runat="server" placeholder="Kcal" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="GETkcal">x FTA (1.1) x FA (</label>
                                </div>
                                <div class="col-10">
                                    <asp:TextBox ID="GETFA" runat="server" placeholder="FA" Font-Size="Small"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="GetFA">) </label>
                                </div>
                                <div class="col-10">
                                    <asp:Button ID="GETBoton" Text="Calcular" runat="server" OnClick="GETBoton_Click" Font-Size="X-Small" />
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-75">
                                    <table>
                                        <tr>
                                            <th>Macronutrientes</th>
                                            <th>%</th>
                                            <th>Gramos</th>
                                            <th>kcal</th>
                                        </tr>
                                        <tr>
                                            <td>CHO</td>
                                            <td>
                                                <asp:TextBox ID="PorcCHO" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                            <td>
                                                <asp:TextBox ID="GramCHO" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                            <td>
                                                <asp:TextBox ID="kcalCHO" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Proteínas</td>
                                            <td>
                                                <asp:TextBox ID="PorcProteinas" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                            <td>
                                                <asp:TextBox ID="GramProteinas" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                            <td>
                                                <asp:TextBox ID="kcalProteinas" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Grasas</td>
                                            <td>
                                                <asp:TextBox ID="PorcGrasas" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                            <td>
                                                <asp:TextBox ID="GramGrasas" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                            <td>
                                                <asp:TextBox ID="kcalGrasas" runat="server" BorderColor="Transparent" Font-Size="Small"></asp:TextBox></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>

                            <h3>Porciones:</h3>
                            <div class="row">
                                <div class="col-15">
                                    <label class="form-label" for="pLeche">Leche:</label>
                                    <br />
                                    <asp:TextBox ID="pLeche" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="pVegetales">Vegetales:</label>
                                    <br />
                                    <asp:TextBox ID="pVegetales" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="pFrutas">Frutas:</label>
                                    <br />
                                    <asp:TextBox ID="pFrutas" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="pHarinas">Harinas:</label>
                                    <br />
                                    <asp:TextBox ID="pHarinas" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-15">
                                    <label class="form-label" for="pCarnes">Carnes:</label>
                                    <br />
                                    <asp:TextBox ID="pCarnes" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="pGrasas">Grasas:</label>
                                    <br />
                                    <asp:TextBox ID="pGrasas" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="pAzúcares">Azúcares:</label>
                                    <br />
                                    <asp:TextBox ID="pAzúcares" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="pSuplemento">Suplemento:</label>
                                    <br />
                                    <asp:TextBox ID="pSuplemento" runat="server" TextMode="Number" Font-Size="Medium"></asp:TextBox>
                                </div>
                            </div>

                            <h3>Distribución de porciones entregadas</h3>
                            <div class="row">
                                <div class="col-75">
                                    <table>
                                        <tr>
                                            <th>Tiempo de Comida</th>
                                            <th>Porciones</th>
                                        </tr>
                                        <tr>
                                            <td>Ayunas</td>
                                            <td>
                                                <asp:TextBox ID="TCAyunas" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Desayuno</td>
                                            <td>
                                                <asp:TextBox ID="TCDesayuno" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Media Mañana</td>
                                            <td>
                                                <asp:TextBox ID="TCMediaMa" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Almuerzo</td>
                                            <td>
                                                <asp:TextBox ID="TCAlmuerzo" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Media Tarde</td>
                                            <td>
                                                <asp:TextBox ID="TCMediaTard" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Cena</td>
                                            <td>
                                                <asp:TextBox ID="TCCena" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>Colación Nocturna</td>
                                            <td>
                                                <asp:TextBox ID="TCColacNocturna" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <div class="col-25">
                                <asp:Button ID="btnCrear" Text="Crear" runat="server" OnClick="btnCrear_Click" Font-Size="Small" Width="100" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>

</asp:Content>
