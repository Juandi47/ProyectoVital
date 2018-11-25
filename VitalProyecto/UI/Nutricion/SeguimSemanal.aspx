<%@ Page Title="" Language="C#" MasterPageFile="~/Nutricion/NutricionMaster.Master" AutoEventWireup="true" CodeBehind="SeguimSemanal.aspx.cs" Inherits="UI.Nutricion.SeguimSemanal" %>

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
                <div id="DatpsPersonales" class="tab-pane fade in active">
                    <div class="container">
                        <h3>Seguimiento de pesaje semanal:</h3>
                        <asp:Label ID="Fecha" Text="Fecha:" runat="server"></asp:Label>
                        <div class="form-container">
                            <div class="row">
                                <div class="col-10">
                                    <label class="form-label" for="sCedula">Cedula</label>
                                    <asp:TextBox ID="sCedula" runat="server" TextMode="Number" placeholder="Cédula" Width="100"></asp:TextBox>
                                </div>
                                <div class="col-10">
                                    <label class="form-label" for="sPeso">Peso</label>
                                    <asp:TextBox ID="sPEso" runat="server" placeholder="Pesp" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="sOreja">Oreja</label>
                                    <asp:TextBox ID="sOreja" runat="server" placeholder="Oreja" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-15">
                                    <label class="form-label" for="sEjercicio">Ejercicio</label>
                                    <asp:TextBox ID="sEjercicio" runat="server" placeholder="Ejercicio" Width="150"></asp:TextBox>
                                </div>
                                <div class="col-20">
                                    <asp:Button ID="btnAgreg" Text="Agregar" runat="server" OnClick="btnAgreg_Click" />

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
            </form>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>

   
</asp:Content>
