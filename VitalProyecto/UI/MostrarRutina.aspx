<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarRutina.aspx.cs" Inherits="UI.MostrarRutina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%@ PreviousPageType VirtualPath="~/BancoRutinas.aspx" %>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <form id="form2" runat="server" style="background-color: lightgray">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                     <asp:GridView ID="grdEjercicios" runat="server" class="table-responsive-lg table-bordered text-center" BackColor="Silver" AutoGenerateColumns="False" HeaderStyle-Font-Size="130%" RowStyle-Height="50px">
                        <Columns>
                            <asp:BoundField DataField="Ejercicio" HeaderText="EJERCICIO" ItemStyle-VerticalAlign="Middle" />
                            <asp:BoundField DataField="Repeticiones" HeaderText="REPETICIONES" ItemStyle-VerticalAlign="Middle"  />
                            <asp:BoundField DataField="Series" HeaderText="SERIES" ItemStyle-VerticalAlign="Middle"  />

                        </Columns>
                        <HeaderStyle BackColor="#999999" BorderStyle="Double" Font-Bold="True" />
                    </asp:GridView>

                </div>
            </div>
        </div>
    </form>
</asp:Content>
