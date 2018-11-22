<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Crear_Admin.aspx.cs" Inherits="UI.Crear_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div class="container">

        <h1 class="title">Registro de Administrador</h1>

        <div class="form-container">
            <form runat="server">

                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tced">Cédula</label>
                    </div>
                    <div class="col-75">
                   <asp:TextBox ID="tced" runat="server"  placeholder="(Sin espacios) Ej: 2225055" TextMode="Number" MaskedTextBox="0-000-000"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tced" Display="Dynamic" ErrorMessage="Espacio obligatorio" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                   </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tname">Nombre</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tname" runat="server"  placeholder="María"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tlname1">Primer apellido</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tlname1" runat="server"  placeholder="Arias"></asp:TextBox>
                    </div>
                </div>

                 <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tlname2">Segundo apellido</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tlname2" runat="server"  placeholder="Rojas"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tclave">Clave</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tclave" runat="server"  placeholder="Ejm: Cla.123" TextMode ="Password"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="tclave">Confirmar clave</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="tclave2" runat="server"  placeholder="Ejm: Cla.123" TextMode ="Password"></asp:TextBox>
                    </div>
                </div>

                  <div class="row">
                    <div class="col-25">
                        <label class="form-label" for="temail">Correo</label>
                    </div>
                    <div class="col-75">
                        <asp:TextBox ID="temail" runat="server"  placeholder="Ejm: maria.rojas@gmail.com" TextMode ="Email" ValidationGroup="AllValidators"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="temail" Display="Dynamic" ErrorMessage="Se requiere la dirección de correo electrónico" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="temail" Display="Dynamic" ErrorMessage="Las direcciones de correo electrónico deben estar en el formato nombre@dominio.xyz." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators">Formato no válido.</asp:RegularExpressionValidator>
                    </div>
                      <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="AllValidators" />
                </div>
                <asp:Button id="btnCrear" Text="Crear" runat="server" OnClick="BtnRegistrar_Click"/>
                
            </form>

        </div>
            
                    
    </div>


</asp:Content>
