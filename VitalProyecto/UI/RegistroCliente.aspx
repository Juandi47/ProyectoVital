<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="UI.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div>
        <h1 class="title">Registro de cliente</h1>
        <div class="form-container">
            <form action="/action_page.php">
                <div class="row">
                    <div class="col-25">
                        <label for="fname">Nombre</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="fname" name="firstname" placeholder="Your name..">
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="lname">Apellidos</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="lname" name="lastname" placeholder="Your last name..">
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="country">Genero</label>
                    </div>
                    <div class="col-75">
                        <select id="country" name="country">
                            <option value="australia">Femenino</option>
                            <option value="canada">Masculino</option>
                            <option value="usa">Otros</option>
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="subject">Observaciones</label>
                    </div>
                    <div class="col-75">
                        <textarea id="subject" name="subject" placeholder="Write something.." style="height: 200px"></textarea>
                    </div>
                </div>
                <div class="row">
                     <button type="button" class="btn btn-success btn-form" style=" padding: 3px 4px 3px 4px; text-align:center; margin:15px 0px 0px 94%;">Registrar</button>
                </div>
            </form>
        </div>

    </div>
</asp:Content>
