﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" CodeBehind="IngresoNutricion.aspx.cs" Inherits="UI.Nutricion.IngresoNutricion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
   <link rel="stylesheet" href="../css/tabla.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
     <div class="container">
        <h1 class="title">Historial Nutrición Anamnesis</h1>
         <asp:Label ID="Fecha" Text="Fecha:" runat="server"></asp:Label>
        <div class="form-container">
            <form runat="server">
        <h3>Datos Personales:</h3>
                 <div class="row">
                     <div class="col-10">
                        <label class="form-label" for="tCedula">Cedula</label>
                       <asp:TextBox ID="tCedula" runat="server" TextMode="Number" placeholder="Cédula" Width="100"></asp:TextBox>
                    </div>
                    <div class="col-10">
                        <label class="form-label" for="tnombre">Nombre</label>
                       <asp:TextBox ID="tnombre" runat="server"  placeholder="Nombre" Width="150"></asp:TextBox>
                    </div>
                     <div class="col-15">
                         <label class="form-label" for="tApellid1">Apellido 1</label>
                       <asp:TextBox ID="tApellid1" runat="server"  placeholder="Apellido 1" Width="150"></asp:TextBox>
                    </div>
                 <div class="col-15">
                         <label class="form-label" for="tApellid2">Apellido 2</label>
                       <asp:TextBox ID="tApellid2" runat="server"  placeholder="Apellido 2" Width="150"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                     <div class="col-10">
                        <label class="form-label" for="tFechNac">Fecha Nacimiento</label>
                      </div>
                     <div class="col-35">
                         <asp:TextBox ID="tFechNac" runat="server" TextMode="Date"></asp:TextBox>
                     </div>
                      <div class="col-15">
                          <label class="form-label" for="tEdad">Edad</label>
                    </div>
                    <div class="col-35">
                       <asp:TextBox ID="tEdad" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    
                    <div class="col-10">
                        <label class="form-label" for="tTelef">Telefono</label>
                        <asp:TextBox ID="tTelef" runat="server" TextMode="Phone"></asp:TextBox>
                    </div>
                </div>
               
               
                 <div class="row">
                    <div class="col-15">
                        <label class="form-label" for="tSexo">Sexo</label>
                        <asp:DropDownList ID="tSex" runat="server" Height="45px"></asp:DropDownList>
                  </div>
                  <div class="col-10">
                        <label class="form-label" for="tEstCivil">Estado Civil</label>
                        <asp:DropDownList ID="tEstCivil" runat="server" Width="150px" Height="45px"></asp:DropDownList>
                    </div>
                
                    
                      <div class="col-10">
                        <label class="form-label" for="tResid">Residencia</label>
                        <asp:TextBox ID="tResid" runat="server"></asp:TextBox>
                    </div>
                    
                </div>

                <h3>Datos Socioeconómicos:</h3>
                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tOcupacion">Ocupación</label>
                    </div>
                    <div class="col-10">
                        <asp:TextBox ID="tOcupacion" runat="server"></asp:TextBox>
                    </div>
                    
                </div>
                <h3>Historial Médico:</h3>
                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tAnteced">Antecedentes Familiares</label>
                    </div>
                     <div class="col-35">
                        <asp:TextBox ID="tAnteced" runat="server"></asp:TextBox>
                    </div>  
                     <div class="col-25">
                        <label class="form-label" for="tPatolog">Patologías que padece</label>
                    </div>
                     <div class="col-35">
                        <asp:TextBox ID="tPatolog" runat="server"></asp:TextBox>
                    </div> 
                </div>
                <div class="row">
                    <div class="col-10">
                        <label class="form-label" for="tConsLicor">Consumo de Licor</label>
                         </div>
                    <div class="col-10">
                         <asp:DropDownList ID="tConsLicr" runat="server"></asp:DropDownList>
                      </div>
                        <div class="col-10">
                             <asp:TextBox ID="tFrecLicor" runat="server" placeholder="Frecuencia"></asp:TextBox>
                        </div>
                </div>
                <div class="row">
                    <div class="col-10">
                        <label class="form-label" for="tConsFuma">Fuma</label>
                    </div>
                    <div class="col-10">
                        <asp:DropDownList ID="tConsFum" runat ="server"></asp:DropDownList>
                    </div>
                      <div class="col-10">
                           <asp:TextBox ID="tFrecFuma" runat="server" placeholder="Frecuencia"></asp:TextBox>
                      </div>
                </div>

                <h3>Medicamentos o suplementos que consume:</h3>
                 <div class="row">
                     <div class="col-20">
                         <asp:TextBox ID="tNomMed" runat="server" placeholder="Nombre"></asp:TextBox>
                     </div>
                     <div class="col-20">
                         <asp:TextBox ID="tMotvMed" runat="server" placeholder="Motivo"></asp:TextBox>
                     </div>
                     <div class="col-20">
                         <asp:TextBox ID="tFrecMed" runat="server" placeholder="Frecuencia"></asp:TextBox>
                     </div>
                     <div class="col-20">
                         <asp:TextBox ID="tDosisMed" runat="server" placeholder="Dosis"></asp:TextBox>
                     </div>
                    <div class="col-20">
                    <%--    <asp:ScriptManager id="ScriptManager1" runat="server"> </asp:ScriptManager>
                    <asp:UpdatePanel id="UpdatePanel1" runat="server">
                        <ContentTemplate>--%>
                          <asp:Button ID="btnAgreg" Text="Agregar" runat="server" OnClick="BtnAgreg_Click" />
                        <%--</ContentTemplate>
                    </asp:UpdatePanel>--%>
                     </div>
                </div>
               
                <div class="row">
                    <table>
                        <asp:Literal ID="tSuplementoMedico" runat="server"></asp:Literal>
                    </table>     
                </div>
                <div class="row">
                    <div class="col-55">
                        <label class="form-label" for="tFech">Fecha de últimos exámenes de sangre o revisión médica</label>
                    </div>
                     <div class="col-20">
                         <asp:TextBox ID="tFechRevis" runat="server" TextMode="Date"></asp:TextBox>
                     </div>
                </div>
                <h2>Actividad Física</h2>
                <div class="row">
                    <div class="col-70">
                         <asp:TextBox ID="ActFisica" runat="server"></asp:TextBox>
                    </div>
                </div>
                <h2>Habitos Alimentarios</h2>
                 <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="VecesComid">¿Cuántas veces come al día?</label>
                    </div>
                    <div class="col-70">
                         <asp:TextBox ID="VecesComid" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="CostHordia">¿Acostumbra a comer a las horas al día?</label>
                    </div>
                    <div class="col-70">
                        <asp:DropDownList ID="CostHorDia" runat="server"> </asp:DropDownList>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="cuanExpress">¿Cuántas veces a la semana come fuera o pide un express?</label>
                    </div>
                    <div class="col-70" aria-valuemin="0">
                         <asp:TextBox ID="cuanExpress" runat="server" TextMode="Number" ></asp:TextBox>
                        <asp:RegularExpressionValidator ID="valPassword" runat="server"
                               ControlToValidate="cuanExpress"
                               ErrorMessage="Deben ser números positivos"
                               ValidationExpression="^[0-9]*" />
                    </div>
                </div>
                  <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="queComeAfuera">¿Generalmente que come fuera de la casa?</label>
                    </div>
                    <div class="col-70" aria-valuemin="0">
                         <asp:TextBox ID="queComeAfuera" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="CuantAzucar">¿Cuánta azucar le agrega a las bebidas?</label>
                    </div>
                    <div class="col-70" aria-valuemin="0">
                         <asp:TextBox ID="CuantAzucar" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="cocinaElabora">¿Los alimentos que cocina los elabora generalmente?</label>
                    </div>
                    <div class="col-70" aria-valuemin="0">
                         <asp:DropDownList ID="cocinaElabora" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="aguAlDia">¿Cuántos vasos de agua toma al día?</label>
                    </div>
                    <div class="col-70" aria-valuemin="0">
                         <asp:TextBox ID="aguAlDia" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="Aderezos">¿Agrega salsa de tomate, mayonesa, mantequilla o natilla a la comida?</label>
                    </div>
                    <div class="col-70">
                        <asp:DropDownList ID="Aderezos" runat="server"> </asp:DropDownList>
                    </div>
                </div>
                  <div class="row">
                    <div class="col-30">
                        <label class="form-label" for="GustosComida">Le gustan la mayoría de: </label>
                    </div>
                    <div class="col-70">
                        <asp:CheckBoxList runat="server" ID="checkListGustos" RepeatColumns="3" TextAlign="Right"> </asp:CheckBoxList>
                    </div>
                </div>

                 <h3>Recordatorio 24 Horas</h3>
                 <div class="row">
                     <div class="col-20">
                         <asp:TextBox ID="r24TiempoComida" runat="server" placeholder="Tiempo de Comida"></asp:TextBox>
                     </div>
                     <div class="col-20">
                         <asp:TextBox ID="r24Alimento" runat="server" placeholder="Alimento"></asp:TextBox>
                     </div>
                     <div class="col-20">
                         <asp:TextBox ID="r24Cantidad" runat="server" placeholder="Cantidad"></asp:TextBox>
                     </div>
                     <div class="col-20">
                         <asp:TextBox ID="r24Descripcion" runat="server" placeholder="Descripcion"></asp:TextBox>
                     </div>
                    <div class="col-20">
                    <%--    <asp:ScriptManager id="ScriptManager1" runat="server"> </asp:ScriptManager>
                    <asp:UpdatePanel id="UpdatePanel1" runat="server">
                        <ContentTemplate>--%>
                          <asp:Button ID="r24Agrega" Text="Agregar" runat="server" OnClick="R24Agrega_Click"/>
                        <%--</ContentTemplate>
                    </asp:UpdatePanel>--%>
                     </div>
                </div>
               
                <div class="row">
                    <table>
                        <asp:Literal ID="r24Tabla" runat="server"></asp:Literal>
                    </table>     
                </div>

                 <h3>Antropometría</h3>
                <div class="row">
                <div class="col-25">
                 <div class="col-15">
                        <label class="form-label" for="tEdad">Edad</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tEdadNut" runat="server" TextMode="Number"></asp:TextBox>
                     </div>
                 <div class="col-15">
                        <label class="form-label" for="tPesoActual">Peso Actual</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tPesoActual" runat="server" TextMode="Number"></asp:TextBox>
                  </div>
                 <div class="col-15">
                        <label class="form-label" for="tPesoMaxTeoria">Peso máximo en teoría</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tPesoMaxTeoria" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-15">
                             <label class="form-label" for="tPesoMeta">Peso Meta o Ideal</label>
                         </div>
                        <div class="col-35">
                            <asp:TextBox ID="tPesoMeta" runat="server"></asp:TextBox>
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
                         <label class="form-label" for="tAgua">Agua</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-15">
                         <label class="form-label" for="tComplexión">Complexión</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </div>
                     <div class="col-15">
                         <label class="form-label" for="tObservacion">Observacion</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tObservacion" runat="server"></asp:TextBox>
                    </div>
                    </div>

                <div class="col-25">
                    <div class="col-15">
                            <p>
                             <label class="form-label" for="tAbdomen">Abdomen</label> </p>
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
                         <label class="form-label" for="tTalla">Talla</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tTalla" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-15">
                         <label class="form-label" for="tCircunfMun">Circunferencia muñeca</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tCircunfMun" runat="server"></asp:TextBox>
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
                         <label class="form-label" for="tAgua">Agua</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tAgua" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-15">
                         <label class="form-label" for="tComplexión">Complexión</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tComplexión" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="col-25">
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
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
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
                <div class="col-25">
                    <div class="col-15">
                         <label class="form-label" for="tPorcGAnalizador">% Grasa Analizador</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tPorcGAnalizador" runat="server"></asp:TextBox>
                    </div>
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
                         <label class="form-label" for="tBascPI">PI</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tBascPI" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-15">
                         <label class="form-label" for="tMuscTronco">Tronco</label> 
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="tMuscTronco" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>

                <h3>GEB:</h3>
                 <div class="row">
                     <div class="col-15">
                         <asp:Label CssClass="form-label" runat="server" ID="GEBLblMujer" Text="Mujer: "></asp:Label>
                    </div>
                    <div class="col-10">
                        <asp:TextBox ID="GEBPI" runat="server" placeholder="PI"></asp:TextBox>
                    </div>
                     <div class="col-10">
                        <asp:TextBox ID="GEBTcm" runat="server" placeholder="T(cm)"></asp:TextBox>
                     </div>
                     <div class="col-10">
                        <asp:TextBox ID="GEBEdad" runat="server" placeholder="Edad"></asp:TextBox>
                     </div>
                     <div class="col-10">
                        <asp:Button ID="GEBMujer" Text="Calcular" runat="server" OnClick="GEBMujer_Click"/>
                    </div>
                 </div>
                 <div class="row">
                     <div class="col-15">
                         <asp:Label CssClass="form-label" runat="server" ID="GEBlblHomb" Text="Hombre: "></asp:Label>
                    </div>
                    <div class="col-10">
                        <asp:TextBox ID="GEBHomPI" runat="server" placeholder="PI"></asp:TextBox>
                    </div>
                     <div class="col-10">
                        <asp:TextBox ID="GEBHomTcm" runat="server" placeholder="T(cm)"></asp:TextBox>
                     </div>
                     <div class="col-10">
                        <asp:TextBox ID="GEBHomEdad" runat="server" placeholder="Edad"></asp:TextBox>
                     </div>
                     <div class="col-10">
                        <asp:Button ID="GEBHombre" Text="Calcular" runat="server" OnClick="GEBHombre_Click"/>
                    </div>
                 </div>
                 <div class="row">
                     <div class="col-15">
                         <asp:Label CssClass="form-label" runat="server" ID="GEBlblMenores" Text="Menores de 10 años: "></asp:Label>
                    </div>
                    <div class="col-10">
                        <asp:TextBox ID="GEBMenorPI" runat="server" placeholder="PI"></asp:TextBox>
                    </div>
                     <div class="col-10">
                        <asp:TextBox ID="GEBMenorTcm" runat="server" placeholder="T(cm)"></asp:TextBox>
                     </div>
                     <div class="col-10">
                        <asp:Button ID="GEBMenores" Text="Calcular" runat="server" OnClick="GEBMenores_Click"/>
                    </div>
                 </div>
                
                <h3>GET:</h3>
                 <div class="row">
                     <div class="col-15">
                         <asp:Label CssClass="form-label" runat="server" ID="GETlbl" Text=" kcal= "></asp:Label>
                    </div>
                    <div class="col-10">
                        <asp:TextBox ID="GETkcal" runat="server" placeholder="Kcal"></asp:TextBox>
                        <label class="form-label" for="GETkcal">x FTA (1.1) x FA (</label> 
                        <asp:TextBox ID="GETFA" runat="server" placeholder="FA"></asp:TextBox>
                        <label class="form-label" for="GetFA">) </label> 
                    </div>
                     <div class="col-10">
                        <asp:Button ID="GETBoton" Text="Calcular" runat="server" OnClick="GETBoton_Click"/>
                    </div>
                 </div>

            <div class="row">
                <table>
                    <tr>
                        <th>Macronutrientes</th>
                        <th>%</th>
                        <th>Gramos</th>
                        <th>kcal</th>
                    </tr>
                    <tr>
                        <td>CHO</td>
                        <td><asp:TextBox ID="PorcCHO" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                        <td><asp:TextBox ID="GramCHO" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                        <td><asp:TextBox ID="kcalCHO" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Proteínas</td>
                        <td><asp:TextBox ID="PorcProteinas" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                        <td><asp:TextBox ID="GramProteinas" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                        <td><asp:TextBox ID="kcalProteinas" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Grasas</td>
                        <td><asp:TextBox ID="PorcGrasas" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                        <td><asp:TextBox ID="GramGrasas" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                        <td><asp:TextBox ID="kcalGrasas" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                    </tr>
                </table>

            </div>

            <h3>Porciones:</h3>
                <div class="row">
                       <div class="col-15">
                        <label class="form-label" for="pLeche">Leche:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pLeche" runat="server"></asp:TextBox>
                     </div>
                        <div class="col-15">
                        <label class="form-label" for="pVegetales">Vegetales:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pVegetales" runat="server"></asp:TextBox>
                     </div>
                        <div class="col-15">
                        <label class="form-label" for="pFrutas">Frutas:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pFrutas" runat="server"></asp:TextBox>
                     </div>
                          <div class="col-15">
                        <label class="form-label" for="pHarinas">Harinas:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pHarinas" runat="server"></asp:TextBox>
                     </div>
                       <div class="col-15">
                        <label class="form-label" for="pCarnes">Carnes:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pCarnes" runat="server"></asp:TextBox>
                     </div>
                        <div class="col-15">
                        <label class="form-label" for="pGrasas">Grasas:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pGrasas" runat="server"></asp:TextBox>
                     </div>
                        <div class="col-15">
                        <label class="form-label" for="pAzúcares">Azúcares:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pAzúcares" runat="server"></asp:TextBox>
                     </div>
                     <div class="col-15">
                        <label class="form-label" for="pSuplemento">Suplemento:</label>
                    </div>
                    <div class="col-35">
                        <asp:TextBox ID="pSuplemento" runat="server"></asp:TextBox>
                     </div>
                </div>

                <h3>Distribución de porciones entregadas</h3>
                <div class="row">
                    <table>
                        <tr>
                            <th>Tiempo de Comida</th>
                            <th>Porciones</th>
                        </tr>
                        <tr>
                            <td>Ayunas</td>
                            <td><asp:TextBox ID="TCAyunas" runat="server"  BorderColor="Transparent"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Desayuno</td>
                            <td><asp:TextBox ID="TCDesayuno" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Media Mañana</td>
                            <td><asp:TextBox ID="TCMediaMa" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Almuerzo</td>
                            <td><asp:TextBox ID="TCAlmuerzo" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Media Tarde</td>
                            <td><asp:TextBox ID="TCMediaTard" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Cena</td>
                            <td><asp:TextBox ID="TCCena" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Colación Nocturna</td>
                            <td><asp:TextBox ID="TCColacNocturna" runat="server" BorderColor="Transparent"></asp:TextBox></td>
                        </tr>
                    </table>
                </div>
                <div class="row">
                    <div class="col-25">
                        <asp:Button id="btnCrear" Text="Crear" runat="server" OnClick="btnCrear_Click"/>
                    </div>
                </div>
            </form>
        </div>    
   </div>

</asp:Content>
