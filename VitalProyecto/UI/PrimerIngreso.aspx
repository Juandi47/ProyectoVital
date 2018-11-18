<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PrimerIngreso.aspx.cs" Inherits="UI.Nutricion.PrimerIngreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: initial;
            width: 15%;
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
    <%--<a href="PrimerIngreso.aspx.designer.cs">PrimerIngreso.aspx.designer.cs</a>--%>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div class="container">
        <h1 class="title">Historial Nutrición Anamnesis</h1>
         <asp:Label ID="Fecha" Text="Fecha:" runat="server"></asp:Label>
        <div class="form-container">
            <form runat="server">
        <h2>Datos Personales:</h2>
                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tnombre">Nombre</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tnombre" runat="server"  placeholder="Nombre Completo"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tFechNac">Fecha de nacimiento</label>
                    </div>
                    <div class="col-25">
                        <asp:TextBox ID="tFechNac" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="col-10">
                        <label class="form-label" for="tEdad">Edad</label>
                    </div>
                    <div class="col-30">
                         <asp:TextBox ID="tEdad" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tSexo">Sexo</label>
                    </div>
                    <div class="col-25">
                        <asp:DropDownList ID="tSex" runat="server"></asp:DropDownList>
                    </div>
                      <div class="col-25">
                        <label class="form-label" for="tEstCivil">Estado Civil</label>
                    </div>
                    <div class="col-25">
                        <asp:DropDownList ID="tEstCivil" runat="server" Width="200px"></asp:DropDownList>
                    </div>
                </div>
                  <div class="row">
                    <div class="col-10">
                        <label class="form-label" for="tTelef">Telefono</label>
                    </div>
                    <div class="col-25">
                         <asp:TextBox ID="tTelef" runat="server" TextMode="Phone"></asp:TextBox>
                    </div>
                      <div class="col-10">
                        <label class="form-label" for="tResid">Residencia</label>
                    </div>
                    <div class="col-55">
                        <asp:TextBox ID="tResid" runat="server"></asp:TextBox>
                    </div>
                </div>

                <h2>Datos Socioeconómicos:</h2>
                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tOcupacion">Ocupación</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tOcupacion" runat="server"></asp:TextBox>
                    </div>
                </div>
                <h2>Historial Médico:</h2>
                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tAnteced">Antecedentes Familiares</label>
                    </div>  
                     <div class="col-75">
                        <asp:TextBox ID="tAnteced" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tPatolog">Patologías que padece</label>
                    </div>  
                     <div class="col-75">
                        <asp:TextBox ID="tPatolog" runat="server"></asp:TextBox>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tConsLicor">Consumo de Licor</label>
                    </div>
                    <div class="col-15">
                        <asp:DropDownList ID="tConsLicr" runat="server"></asp:DropDownList>
                    </div>
                      <div class="col-60">
                           <asp:TextBox ID="tFrecLicor" runat="server" placeholder="Frecuencia"></asp:TextBox>
                      </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tConsFuma">Fuma</label>
                    </div>
                    <div class="col-15">
                        <asp:DropDownList ID="tConsFum" runat ="server"></asp:DropDownList>
                    </div>
                      <div class="col-60">
                           <asp:TextBox ID="tFrecFuma" runat="server" placeholder="Frecuencia"></asp:TextBox>
                      </div>
                </div>
                <h2>Medicamentos o suplementos que consume:</h2>
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
                          <asp:Button ID="btnAgreg" Text="Agregar" runat="server" OnClick="btnAgreg_Click"/>
                     </div>
                </div>
               
                <div class="row">
                         <table>
                          <tr>
                              <th>Nombre</th>
                              <th>Motivo</th>
                              <th>Frecuencia</th>
                              <th>Dosis</th>
                          </tr>
                          <tr>
                              <td>1</td>
                              <td>2</td>
                              <td>3</td>
                              <td>4</td>
                          </tr>
                             <tr>
                              <td>5</td>
                              <td>6</td>
                              <td>7</td>
                              <td>8</td>
                          </tr>
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
                        <asp:DropDownList ID="CostHorDia" runat="server">
                            <asp:ListItem Text ="Sí" Value="1" />
                            <asp:ListItem Text ="No" Value="2" />
                        </asp:DropDownList>
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
                        <label class="form-label" for="Aderesos">¿Agrega salsa de tomate, mayonesa, mantequilla o natilla a la comida?</label>
                    </div>
                    <div class="col-70">
                        <asp:DropDownList ID="Aderesos" runat="server">
                            <asp:ListItem Text ="Sí" Value="1" />
                            <asp:ListItem Text ="No" Value="2" />
                        </asp:DropDownList>
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

                  <%--<asp:Button id="btnCrear" Text="Crear" runat="server" OnClick="btnAgreg_Click"/>--%>
            </form>
        </div>
        
       
       
   </div>
</asp:Content>
