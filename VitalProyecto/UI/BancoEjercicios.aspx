<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="BancoEjercicios.aspx.cs" Inherits="UI.BancoEjercicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <link href="admin_estilos.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <form id="form1" runat="server" style="background-color:lightgray">
        <div class="container">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <div class="input-group">
                        <asp:TextBox ID="txtNuevoEjercicio" runat="server" Width="300px" Wrap="False" placeholder="NUEVO EJERCICIO" ></asp:TextBox>
                        <asp:Button ID="btnAgregarEjercicio" runat="server" Text="Agregar Ejercicio" class="button input-group-addon" OnClick="btnAgregarEjercicio_Click" BackColor="darkolivegreen" />
                    </div>                        


                    <asp:GridView ID="grdEjercicios" runat="server" class="table table-bordered text-center" BackColor="Silver" Font-Size="X-Large">
                        <Columns>
                            <asp:ButtonField HeaderText="ACCIÓN" Text="ELIMINAR" />
                        </Columns>
                        <HeaderStyle BackColor="#999999" BorderStyle="Double" Font-Bold="True" Font-Size="X-Large" />
                    </asp:GridView>

                </div>
                <div class="col-md-2">
                </div>
            </div>
        </div>
    </form>
</asp:Content>
