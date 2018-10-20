<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Crear_Admin.aspx.cs" Inherits="UI.Crear_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div>
        <h1 class="title">Registro de Administrador</h1>

        <div class="form-container">
            <form action="/action_page.php">

                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tced">Cédula</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="tced" name="tced" placeholder="(Sin espacios) Ej: 2 225 055">
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tname">Nombre</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="tname" name="tname" placeholder="Juan">
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tlname1">Primer apellido</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="tlname1" name="tlname1" placeholder="Arias">
                    </div>
                </div>

                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tlname2">Segundo apellido</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="tlname2" name="tlname" placeholder="Rojas">
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tphone">Clave</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="tclave" name="tclave" placeholder="Ejm: Cla.123"> 
                    </div>
                </div>

                  <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="temail">Correo</label>
                    </div>
                    <div class="col-75">
                        <input type="email" id="temail" name="temail">
                    </div>
                </div>

                <div >
                  <button type="button" class="btn btn-success btn-form">Registrar</button>
                </div>
            </form>
        </div>

    </div>
</asp:Content>
