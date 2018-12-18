<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="UI.Nutricion.CambiarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="/css/tabla.css" />
    <script src="js/alertify.min.js"></script>
    <link rel="stylesheet" href="/css/alertify.min.css" />
    <link rel="stylesheet" href="/css/semantic.min.css" />
    <script src="/alertify.js"></script>
    <script src="/mensaje.js"></script>

    <script type="text/javascript">
        function mensaje() {
            alertify.success("Nutricionista modificado correctamente");
        }
    </script>

    <script type="text/javascript">
        function error() {
            alertify.error("Error");
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <div class="container">

        <h1 class="title">Modificar Nutricionista</h1>

        <div class="form-container">
            <form runat="server">
                <br />
                Contraseña:
                <asp:TextBox class="form-control" Width="500px" ID="tclave" runat="server" TextMode="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tclave" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <br />
                Confirmar contraseña:
                <asp:TextBox class="form-control" Width="500px" ID="tclave2" runat="server" TextMode="Password" placeholder="Ejm: Cla.123"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tclave2" SetFocusOnError="true" ForeColor="red" runat="server" ErrorMessage="Se deben completar todos los espacios" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:Label ID="ValidadorClaves" runat="server" Visible="false" Text="Las claves no coinciden" ForeColor="Red"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary3" runat="server" ShowMessageBox="True" ValidationGroup="AllValidators" />

                <br />
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="True" ValidationGroup="AllValidators" />
                <br />
                <asp:Button ID="btnModificar" Text="Modificar" runat="server" OnClick="btnModificar_Click" Font-Size="Small" ValidationGroup="validaciones" />
                <br />
                <br />
            </form>
            <br />
        </div>

        <br />
    </div>

</asp:Content>
