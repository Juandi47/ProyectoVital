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
    <%--<script src="js/pikaday.js" type="text/javascript"></script>
    <link href="css/pikaday.css" rel="stylesheet" type="text/css" />
    <link href="css/theme.css" rel="stylesheet" type="text/css" />
    <link href="css/triangle.css" rel="stylesheet" type="text/css" />--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <%--<h1 id="tituloH1" accesskey="tituloH1" class="title">Registro de cliente</h1>--%>
    <asp:Label ID="tituloH1" CssClass="title" runat="server" Text="Registro de cliente"></asp:Label>

    <div class="form-container" runat="server">
        <form id="form1" runat="server">




            <div class="con">

                <div class="col-md-4" style="; height:80px";>
                     <asp:Label ID="lblCed" CssClass="form-label" runat="server" Text="Cédula"></asp:Label>
                            <asp:TextBox ID="txbced" runat="server"></asp:TextBox>
                </div>
                 <div class="col-md-4" >
                       <asp:Button ID="btnBusqueda" runat="server" Text="Consultar" OnClick="btnFiltro_Click" CssClass="small btnn" />
                </div>

                <asp:Table ID="Table2" runat="server" CssClass="table-responsive">
                    <asp:TableRow runat="server">
                    </asp:TableRow>

                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server">
                            <asp:Label ID="Label2" CssClass="form-label" runat="server" Text="Nombre"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:Label ID="Label3" CssClass="form-label" runat="server" Text="1er Apellido"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:Label ID="Label4" CssClass="form-label" runat="server" Text="2do Apellido"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server">
                            <asp:TextBox ID="txbnombre" runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:TextBox ID="txbape1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:TextBox ID="txbape2" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>

                </asp:Table>

            </div>

            <div>
                <asp:Table runat="server">
                    <asp:TableHeaderRow>
                        <asp:TableCell>
                            <asp:Label ID="Label5" CssClass="form-label" runat="server" Text="Telefono"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Label ID="Label6" CssClass="form-label" runat="server" Text="Correo"></asp:Label>
                        </asp:TableCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox ID="txbtelefono" runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txbcorreo" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>

            <div class="row" style="padding:0px 10px 0px 10px">

                <div class="col-md-5" style=" height: inherit">
                    <asp:TableHeaderRow>
                        <asp:TableCell>
                            <asp:Label ID="Label7" CssClass="form-label" runat="server" Text="Observaciones"></asp:Label>
                        </asp:TableCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox ID="txbobs" runat="server" Rows="10" TextMode="MultiLine" ToolTip="Observaciones" Wrap="False" Height="110px"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </div>

                <div class="col-md-3" style="; height: 130px">
                    <asp:Label ID="Label1" CssClass="form-label" runat="server" Text="Fecha nacimiento"></asp:Label>
                    <asp:Table ID="Table1" runat="server">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">
                                  <asp:DropDownList ID="DlDia" runat="server"></asp:DropDownList>                             
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:DropDownList ID="DlMes" runat="server"></asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                               <asp:DropDownList ID="DLAnno" runat="server"></asp:DropDownList>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>

                </div>
                 <div class="col-md-3" height: 130px;">
                      <asp:Button ID="btnModificar" runat="server" Text="REGISTRAR" CssClass="btnn2" OnClick="btnRegistrar_Click" />
                 </div>
            </div>
        </form>
    </div>


</asp:Content>
