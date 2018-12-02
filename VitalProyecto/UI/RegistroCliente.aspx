﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true"  CodeBehind="RegistroCliente.aspx.cs" Inherits="UI.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <%-- GENERALES --%>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="admin_estilos.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <asp:Label ID="tituloH1" CssClass="title" runat="server" Text="Registro de cliente"></asp:Label>
		<br />
	<br />
    <div class="form-container" runat="server">
          <%-- LABEL PARA MENSAJES DE ALERTA --%>
                <asp:Label  ID="labelAlerta" runat="server" CssClass="labelAlerta"></asp:Label>
        <form id="form1" runat="server">
            
            <%-- DIV DE DESPLIEGUE DE INGRESO DE CREDENCIALES --%>
            <div id="ingresoDIV" class="col-sm-5 ingresoDiv" runat="server">

                <asp:Label ID="LabelCredenciales" runat="server" Text="Label" CssClass="h3">Credenciales de ingreso</asp:Label>

                <asp:Table runat="server" CssClass="table-responsive">

                    <asp:TableRow CssClass="tablerow">
                        <asp:TableCell>
                            <asp:Label ID="LabelCorreo" CssClass="form-label" runat="server" Text="Correo"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="TextBoxCorreo2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server"
                                ControlToValidate="txbcorreo" Display="Dynamic"
                                ErrorMessage="Formato de correo invalido"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                ValidationGroup="AllValidators" ForeColor="Red" Font-Bold="True">
                                    Formato no válido.
                            </asp:RegularExpressionValidator>
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelC" CssClass="form-label" runat="server" Text="Contraseña"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="pass2" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="pass2"
                                ID="RegularExpressionValidator6" ValidationExpression="^[\s\S]{4,}$" runat="server"
                                ErrorMessage="La contraseña debe tener mínimo 4 caracteres.">
                            </asp:RegularExpressionValidator>
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="Label9" CssClass="form-label" runat="server" Text="Confirmar contraseña"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="pass1" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="pass1"
                                ID="RegularExpressionValidator7" ValidationExpression="^[\s\S]{4,}$" runat="server"
                                ErrorMessage="La contraseña debe tener mínimo 4 caracteres.">
                            </asp:RegularExpressionValidator>
                        </asp:TableCell>
                    </asp:TableRow>

                </asp:Table>

                <asp:Button ID="btnCredenciales" runat="server" Text="Finalizar registro" CssClass="btnCred small" OnClick="btnRegistrarConCuenta_Click" />
            </div>

            <%-- DIV CON TODOS LOS CAMPOS DE REGISTRO --%>
            <div id="principalDiv" runat="server" class="con">
              
                <asp:Table runat="server" CssClass="table-responsive">

                    <asp:TableRow CssClass="tablerow">
                        <asp:TableCell CssClass="cellIzqP">
                            <asp:Label ID="lblCed" CssClass="form-label" runat="server" Text="Cédula"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>

                      <asp:TableRow CssClass="tablerow">
                        <asp:TableCell>
                            <asp:TextBox ID="txbced" runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btnBusqueda" runat="server" Text="Consultar" OnClick="btnFiltro_Click" CssClass="small btnn" />
                        </asp:TableCell>
                    </asp:TableRow>

                </asp:Table>

                <div class="row" style="margin-bottom: 5px">
                    <div class="col-md-1" style="text-align: left">
                        <asp:Label ID="Label10" CssClass="form-label" runat="server" Text="Nombre"></asp:Label>
                    </div>
                    <div class="col-md-6">
                        <br><asp:TextBox ID="txbnombre" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ControlToValidate="txbnombre" ErrorMessage="*Ingrese solo letras"
                            ForeColor="Red"
                            ValidationExpression="^[A-Za-z]*$">
                        </asp:RegularExpressionValidator>
                    </div>
                </div>

                <asp:Table ID="Table2" runat="server" CssClass="table-responsive">

                    <asp:TableRow runat="server" CssClass="tablerow">
                        <asp:TableCell runat="server">
                            <asp:Label ID="Label3" CssClass=" form-label " runat="server" Text="Primer Apellido"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:Label ID="Label4" CssClass="form-label" runat="server" Text="Segundo Apellido"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>

                     <asp:TableRow CssClass="tablerow">
                        <asp:TableCell runat="server">
                            <asp:TextBox ID="txbape1" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                                ControlToValidate="txbape1" ErrorMessage="*Ingrese solo letras"
                                ForeColor="Red"
                                ValidationExpression="^[A-Za-z]*$">
                            </asp:RegularExpressionValidator>
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:TextBox ID="txbape2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                ControlToValidate="txbape2" ErrorMessage="*Ingrese solo letras"
                                ForeColor="Red"
                                ValidationExpression="^[A-Za-z]*$">
                            </asp:RegularExpressionValidator>
                        </asp:TableCell>
                    </asp:TableRow>

                </asp:Table>

                <div>
                    <asp:Table runat="server" CssClass="table-responsive">

                        <asp:TableRow CssClass="tablerow">
                            <asp:TableCell>
                                <asp:Label ID="Label5" CssClass="form-label" runat="server" Text="Telefono"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="Label6" CssClass="form-label" runat="server" Text="Correo"></asp:Label>

                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow CssClass="tablerow">
                            <asp:TableCell>
                                <asp:TextBox ID="txbtelefono" runat="server" MaxLength="8" ViewStateMode="Enabled"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                    ControlToValidate="txbtelefono" ErrorMessage="*Ingrese Valores Numericos"
                                    ForeColor="Red"
                                    ValidationExpression="^[0-9]*">
                                </asp:RegularExpressionValidator>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txbcorreo" runat="server"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server"
                                    ControlToValidate="txbcorreo" Display="Dynamic"
                                    ErrorMessage="Formato de correo invalido"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    ValidationGroup="AllValidators" ForeColor="Red" Font-Bold="True">
                                    Formato no válido.
                                </asp:RegularExpressionValidator>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>

                    <div id="divExtra" accesskey="divExtra" class="row" style="margin-bottom: 5px" runat="server">
                        <div class="col-md-1" style="text-align: left; padding-top: 7px">
                            <asp:Label ID="Label2" CssClass="form-label" runat="server" Text="Contraseña"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="textBoxClave" runat="server" TextMode="Password" ViewStateMode="Enabled"></asp:TextBox>
                            <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="textBoxClave"
                                ID="MyPassordMinLengthValidator" ValidationExpression="^[\s\S]{4,}$" runat="server"
                                ErrorMessage="La contraseña debe tener mínimo 4 caracteres.">
                            </asp:RegularExpressionValidator>
                        </div>
                    </div>

                </div>

                <div class="row" style="padding: 0px 10px 0px 10px">

                    <div class="col-md-5" style="height: inherit">

                        <asp:TableHeaderRow>
                            <asp:TableCell>
                                <asp:Label ID="Label7" CssClass="form-label" runat="server" Text="Observaciones"></asp:Label>
                            </asp:TableCell>
                        </asp:TableHeaderRow>

                      <asp:TableRow CssClass="tablerow">
                            <asp:TableCell>
                                <asp:TextBox ID="txbobs" runat="server" Rows="10" TextMode="MultiLine" ToolTip="Observaciones" Height="110px" ViewStateMode="Disabled"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                    </div>

                    <div class="col-md-3" style="height: 130px">
                        <asp:Label ID="Label1" CssClass="form-label" runat="server" Text="Fecha nacimiento"></asp:Label>

                        <asp:Table ID="Table1" runat="server" CssClass="table-responsive">
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
                    <div class="col-md-3">
                        <asp:Button ID="btnCrearCuenta" runat="server" Text="Crear cuenta" CssClass="small btnn2 " OnClick="habilitarCredenciales_Click" />
                        <asp:Button ID="btnModificar" runat="server" Text="Finalizar registro" CssClass="small btnn2 " OnClick="btnRegistrar_Click" />
                    </div>
                </div>

            </div>
        </form>
    </div>
</asp:Content>
