<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" CodeBehind="ConsultarNutricion.aspx.cs" Inherits="UI.Nutricion.ConsultarNutricion" %>

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
        <div class="tab-content">
            <form runat="server">
                <div id="Consultar" class="tab-pane fade in active">
                    <div class="container">
                        <div class="form-container">
                            <h3>Lista Clientes de Nutrición:</h3>
                            <asp:Label ID="Fecha" Text="Fecha:" runat="server"></asp:Label>
                            <div class="row">
                                <div class="col-10">
                                    <label class="form-label" for="sCedula">Ingrese la Cedula del Cliente: </label>
                                    <asp:TextBox ID="sCedula" runat="server" TextMode="Number" placeholder="Cédula" Width="100"></asp:TextBox>
                                    <asp:Button ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click" />
                                </div>
                            </div>
                            <div class="row">
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
                </div>
            </form>
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
