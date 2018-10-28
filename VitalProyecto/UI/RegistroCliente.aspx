<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="UI.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <%-- GENERALES --%>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="admin_estilos.css" rel="stylesheet" />

    <%-- NECESARIOS PARA USO DE CALENDAR --%>
    <script src="js/pikaday.js" type="text/javascript"></script>
    <link href="css/pikaday.css" rel="stylesheet" type="text/css" />
    <link href="css/theme.css" rel="stylesheet" type="text/css" />
    <link href="css/triangle.css" rel="stylesheet" type="text/css" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <h1 class="title">Registro de cliente</h1>

    <div class="form-container" runat="server">

        <%-- CEDULA --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="lblCed" CssClass="form-label" runat="server" Text="Cedula"></asp:Label>
            </div>
            <div class="col-75">
               <%-- <asp:Table ID="Table2" runat="server">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server">--%>
                            <asp:TextBox ID="txbced" runat="server"></asp:TextBox>
                       <%-- </asp:TableCell>--%>
                       <%-- <asp:TableCell runat="server">
                          
                        </asp:TableCell>--%>
                  <%--  </asp:TableRow>
                </asp:Table>--%>
                <asp:LinkButton ID="btnFiltro" runat="server" OnClick="btnFiltro_Click">
                  Filtrar
                </asp:LinkButton>
            </div>
        </div>

        <%-- NOMBRE --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="lblnombre" CssClass="form-label" runat="server" Text="Nombre"></asp:Label>
            </div>
            <div class="col-75">
                <asp:TextBox ID="txbnombre" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- APELLIDO1 --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="lblape1" CssClass="form-label" runat="server" Text="Primer apellido"></asp:Label>
            </div>
            <div class="col-75">
                <asp:TextBox ID="txbape1" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- APELLIDO2 --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="lblpae2" CssClass="form-label" runat="server" Text="Segundo apellido"></asp:Label>
            </div>
            <div class="col-75">
                <asp:TextBox ID="txbape2" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- TELEFONO --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="lbltelefono" CssClass="form-label" runat="server" Text="Telefono"></asp:Label>
            </div>
            <div class="col-75">
                <asp:TextBox ID="txbtelefono" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- CORREO --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="lblcorreo" CssClass="form-label" runat="server" Text="Correo"></asp:Label>
            </div>
            <div class="col-75">
                <asp:TextBox ID="txbcorreo" runat="server"></asp:TextBox>
            </div>
        </div>

        <%-- OBSERVACIONES --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="lblobs" CssClass="form-label" runat="server" Text="Observaciones"></asp:Label>
            </div>
            <div class="col-75">
                <asp:TextBox ID="txbobs" runat="server" Height="150px"></asp:TextBox>
            </div>
        </div>

        <%-- FECHA NACIMIENTO --%>
        <div class="row">
            <div class="col-25">
                <asp:Label ID="Label1" CssClass="form-label" runat="server" Text="Fecha nacimiento"></asp:Label>
            </div>
            <div class="col-75">

                <br />

                <asp:Table ID="Table1" runat="server">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server">
                             <asp:DropDownList ID="DLAnno" runat="server"></asp:DropDownList>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:DropDownList ID="DlMes" runat="server" ></asp:DropDownList>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                             <asp:DropDownList ID="DlDia" runat="server"></asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

                <br />
            </div>
            <br />
        </div>

    </div>
    <br/>
    <asp:Button ID="btnRegistrar" runat="server" Text="REGISTRAR" CssClass="center-block" Width="150px" OnClick="btnRegistrar_Click"/>
    <br />
    <br />
    <br />



</asp:Content>
