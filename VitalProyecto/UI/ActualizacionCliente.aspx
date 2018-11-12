<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ActualizacionCliente.aspx.cs" Inherits="UI.ActualizacionCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
     <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <h1 class="title">Actualización de cliente</h1>



    <div class="form-container" style="background-color: #086668">

        <div class="row">
              <div class="col-25">
                  <a href="#" style="color:papayawhip; text-decoration:none; font: bold 20px 'Open Sans', sans-serif; background-color:#32a800">Ver anterior</a>
              </div>
              <div class="col-50" style="text-align:center; vertical-align:central; padding:0; margin:0;">
                  <h1 style="position:center; color:papayawhip">Octubre</h1>
              </div>
              <div class="col-25">
                  <a href="#"style="color:papayawhip; text-decoration:none; font: bold 20px 'Open Sans', sans-serif; background-color:#32a800; float:right;">Ver siguiente</a>
              </div>

           <%-- <ul class="pager">
                <li class="previous"><a href="#" style="color:papayawhip; text-decoration:none; font: bold 20px 'Open Sans', sans-serif; background-color:#32a800">Ver anterior</a></li>
                
                <li class="next"><a href="#"style="color:papayawhip; text-decoration:none; font: bold 20px 'Open Sans', sans-serif; background-color:#32a800; float:right;">Ver siguiente</a></li>
            </ul>--%>
           <%-- <h1 style="position:center; color:papayawhip">Octubre</h1>--%>

        </div>

        <form id="form1" runat="server">

            <div class="row">
                <div class="col-25">
                    <label class="form-label2" for="tfrec">Frecuencia cardiaca</label>
                </div>
                 <div class="col-30">
                         <asp:TextBox ID="tfrec" runat="server" BackColor="White"></asp:TextBox>
                 </div>
            </div>

            <div class="row">
                <div class="col-75">
                    <label class="form-label2" for="tweigth">Peso(Kg)</label>
                </div>
                <div class="col-35">
                    <asp:TextBox ID="tweigth" runat="server" TextMode="Number"></asp:TextBox>
                 </div>
            </div>

            <div class="row">
                <div class="col-25">
                    <label class="form-label2" for="tpercentWeigth">Porcentaje grasa(%)</label>
                </div>
                 <div class="col-30">
                         <asp:TextBox ID="tpercentWeigth" runat="server" TextMode="Number"></asp:TextBox>
                 </div>
            </div>

            <div class="row">
                <div class="col-25">
                    <label class="form-label2" for="timc">IMC</label>
                </div>
                 <div class="col-30">
                         <asp:TextBox ID="timc" runat="server" TextMode="Number"></asp:TextBox>
                 </div>
            </div>

            <div class="row">
                <div class="col-25">
                    <label class="form-label2" for="tabdomen">Abdomen(cm)</label>
                </div>
                 <div class="col-30">
                         <asp:TextBox ID="tabdomen" runat="server" TextMode="Number"></asp:TextBox>
                 </div>               
            </div>

            <div class="row">
                <div class="col-25">
                    <label class="form-label2" for="thip">Cadera(cm)</label>
                </div>
                 <div class="col-30">
                         <asp:TextBox ID="thip" runat="server" TextMode="Number"></asp:TextBox>
                 </div>
            </div>


            <div class="row">
                <div class="col-25">
                    <label class="form-label2" for="tthigth">Muslo(cm)</label>
                </div>
                <div class="col-30">
                         <asp:TextBox ID="tthigth" runat="server"  TextMode="Number"></asp:TextBox>
                 </div>
            </div>

            <div class="row">
                <div class="col-25">
                    <label class="form-label2" for="theigth">Estatura(cm)</label>
                </div>
                 <div class="col-30">
                         <asp:TextBox ID="theigth" runat="server" TextMode="Number"></asp:TextBox>
                         <br />
                         <br />
                         <br />
                         <br />
             <%--<label class="form-label2" for="theigth">--%>     
                <asp:Button id="btnAñadirExpediente" Text="Añadir a expediente" runat="server" OnClick="btnAñadirExpediente_Click" Height="51px" Width="216px" Font-Size="Small"/>
                         <%--</label>--%>
                         <br />
                 </div>
            </div>

           
                <%--<button type="button" class="btn btn-success btn-form">Añadir a expediente</button>--%>
            
        </form>
    </div>


</asp:Content>
