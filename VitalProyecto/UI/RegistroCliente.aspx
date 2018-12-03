<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="UI.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <%-- GENERALES --%>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="admin_estilos.css" rel="stylesheet" />

	 <script src="js/alertify.min.js"></script>
	<link rel="stylesheet" href="/css/alertify.min.css" />
	<link rel="stylesheet" href="/css/semantic.min.css" />
	<script src="/alertify.js"></script>
	<script src="/mensaje.js"></script>
	
	<script type="text/javascript">
		function mensaje() {
			alertify.success("Cliente creado correctamente");
		}
	</script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <style>
        .caja {
            height: 70px;
            /*background-color:#ff6a00;*/
            padding-bottom: 0%;
        }

        .caja2 {
            margin-left: 0%;
            background-color: #808080;
        }

        .cajaTexto {
            height: 25px;
            margin-bottom: 0%
        }

        .crearBTN {
            margin-top: 0%;
            width: 175px;
            margin-bottom: 10%;
        }

        .labelAlerta2 {
            margin-top: 5px;
            color: darkred;
            /*font-size: 25px;*/
            /*font-family: Verdana, Geneva, Tahoma, sans-serif;*/
            text-align: right;
            text-shadow: 20px 12px 2px rgba(0, 0, 0, 0.26);
            font: bold 2.3vw Tahoma, sans-serif;
            margin-right:0%;
        }
    </style>

    <asp:Label ID="tituloH1" CssClass="title" runat="server" Text="Registro de cliente"></asp:Label>

    <%--  <div class="row" style="height:10px" runat="server">--%>
    <%-- <asp:Label ID="labelAlerta" runat="server" CssClass="labelAlerta"></asp:Label>--%>
    <%--   <h3 id="labelAlerta2" runat="server"></h3>--%>
    <br>
    <%--</div>--%>

    <div class=" form-container" runat="server">

        <%-- DIV PARA MENSAJES DE ALERTA --%>
        <div class="col-md-2" style="float: right;  width: 90%; text-align:right;" runat="server">
            <asp:Label ID="labelAlerta" runat="server" CssClass="labelAlerta2" ></asp:Label>
        </div>

        <form id="form1" runat="server">
            <%-- DIV DE DESPLIEGUE DE INGRESO DE CREDENCIALES --%>
            <div id="ingresoDIV" class="col-sm-5 ingresoDiv " runat="server">

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
            <div id="principalDiv" runat="server" class="con table">

                <%--  <label ID="lblCed" >Cédula</label>--%>
                Cédula
                <div class="row" style="margin-top: 0%;">

                    <div class="col-md-4" runat="server" style="height: 30px">

                        <asp:TextBox ID="txbced" runat="server" CssClass="cajaTexto" ToolTip="Ejm: 20458036"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server"
                            ControlToValidate="txbced" ErrorMessage="*Ingrese una cédula válida"
                            ForeColor="Red"
                            ValidationExpression="^[0-9]{9,9}">
                        </asp:RegularExpressionValidator>
                    </div>
                    <div class="col-md-2 ">
                        <asp:Button ID="btnBusqueda" runat="server" Text="Consultar" OnClick="btnFiltro_Click" CssClass="small" />
                    </div>
                </div>


                <%-- <asp:Table runat="server" CssClass="table-responsive">

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

                </asp:Table>--%>

                <div class="row">
                    <div class="col-md-4 caja" style="padding-top: 0px;">
                        Nombre
                        <asp:TextBox ID="txbnombre" runat="server" CssClass="cajaTexto"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ControlToValidate="txbnombre" ErrorMessage="*Ingrese solo letras"
                            ForeColor="Red"
                            ValidationExpression="^[A-Z a-z]*$">
                        </asp:RegularExpressionValidator>
                    </div>

                    <div class="col-md-4 caja" style="padding-top: 0px;">
                        Teléfono
                        <asp:TextBox ID="txbtelefono" runat="server" MaxLength="8" ViewStateMode="Enabled" CssClass="cajaTexto"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="txbtelefono" ErrorMessage="*Ingrese Valores Numericos"
                            ForeColor="Red"
                            ValidationExpression="^[0-9]*">
                        </asp:RegularExpressionValidator>
                    </div>

                </div>

                <div class="row">
                    <div class="col-md-4 caja" style="padding-top: 0px;">
                        Primer apellido
                      <asp:TextBox ID="txbape1" runat="server" CssClass="cajaTexto"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                            ControlToValidate="txbape1" ErrorMessage="*Ingrese solo letras"
                            ForeColor="Red"
                            ValidationExpression="^[A-Za-z]*$">
                        </asp:RegularExpressionValidator>
                    </div>

                    <div class="col-md-4 caja" style="padding-top: 0px;">
                        Segundo apellido
                         <asp:TextBox ID="txbape2" runat="server" CssClass="cajaTexto"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                            ControlToValidate="txbape2" ErrorMessage="*Ingrese solo letras"
                            ForeColor="Red"
                            ValidationExpression="^[A-Za-z]*$">
                        </asp:RegularExpressionValidator>
                    </div>

                </div>

                <div class="row">
                    <div class="col-md-4 caja" style="padding-top: 0px;">
                        Correo
                        <asp:TextBox ID="txbcorreo" runat="server" CssClass="cajaTexto"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server"
                            ControlToValidate="txbcorreo" Display="Dynamic"
                            ErrorMessage="Formato de correo invalido"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ValidationGroup="AllValidators" ForeColor="Red" Font-Bold="True">
                                    Formato no válido.
                        </asp:RegularExpressionValidator>
                    </div>

                    <div class="col-md-3 caja" style="padding-top: 0px;">
                        Fecha nacimiento
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

                </div>

                <%--  <div class="row">
                      <asp:TextBox ID="txbnombre" runat="server" CssClass="small"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ControlToValidate="txbnombre" ErrorMessage="*Ingrese solo letras"
                            ForeColor="Red"
                            ValidationExpression="^[A-Za-z]*$">
                        </asp:RegularExpressionValidator>
                </div>--%>

                <%--  <asp:Table ID="Table2" runat="server" CssClass="table-responsive">--%>

                <%--    <asp:TableRow runat="server" CssClass="tablerow">
                            <asp:TableCell runat="server">
                                  <asp:Label ID="Label10" CssClass="form-label" runat="server" Text="Nombre"></asp:Label>
                            </asp:TableCell>
                      </asp:TableRow>
                     <asp:TableRow runat="server" CssClass="tablerow">
                          <asp:TableCell runat="server">
                               <asp:TextBox ID="txbnombre" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ControlToValidate="txbnombre" ErrorMessage="*Ingrese solo letras"
                            ForeColor="Red"
                            ValidationExpression="^[A-Za-z]*$">
                        </asp:RegularExpressionValidator>
                            </asp:TableCell>
                      </asp:TableRow>--%>

                <%-- <asp:TableRow runat="server" CssClass="tablerow">
                        <asp:TableCell runat="server">
                            <asp:Label ID="Label3" CssClass=" form-label " runat="server" Text="Primer Apellido"></asp:Label>
                            <asp:Label ID="Label4" CssClass="form-label" runat="server" Text="Segundo Apellido"></asp:Label>
                        </asp:TableCell>--%>
                <%--   <asp:TableCell runat="server">
                            <asp:Label ID="Label4" CssClass="form-label" runat="server" Text="Segundo Apellido"></asp:Label>
                        </asp:TableCell>--%>
                <%-- </asp:TableRow>

                    <asp:TableRow CssClass="tablerow">
                        <asp:TableCell runat="server">--%>
                <%--<asp:TextBox ID="txbape1" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                                ControlToValidate="txbape1" ErrorMessage="*Ingrese solo letras"
                                ForeColor="Red"
                                ValidationExpression="^[A-Za-z]*$">
                            </asp:RegularExpressionValidator>--%>
                <%-- <asp:TextBox ID="txbape2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                ControlToValidate="txbape2" ErrorMessage="*Ingrese solo letras"
                                ForeColor="Red"
                                ValidationExpression="^[A-Za-z]*$">
                            </asp:RegularExpressionValidator>--%>
                <%-- </asp:TableCell>--%>
                <%--  <asp:TableCell runat="server">
                            <asp:TextBox ID="txbape2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                ControlToValidate="txbape2" ErrorMessage="*Ingrese solo letras"
                                ForeColor="Red"
                                ValidationExpression="^[A-Za-z]*$">
                            </asp:RegularExpressionValidator>
                        </asp:TableCell>--%>
                <%-- </asp:TableRow>

                </asp:Table>--%>

                <%--  <div>--%>
                <%--       <asp:Table runat="server" CssClass="table-responsive">

                        <asp:TableRow CssClass="tablerow">--%>
                <%--<asp:TableCell>
                                <asp:Label ID="Label5" CssClass="form-label" runat="server" Text="Telefono"></asp:Label>
                            </asp:TableCell>--%>
                <%-- <asp:TableCell>
                                <asp:Label ID="Label6" CssClass="form-label" runat="server" Text="Correo"></asp:Label>

                            </asp:TableCell>--%>
                <%--    </asp:TableRow>

                        <asp:TableRow CssClass="tablerow">--%>
                <%--  <asp:TableCell>--%>
                <%--<asp:TextBox ID="txbtelefono" runat="server" MaxLength="8" ViewStateMode="Enabled"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                    ControlToValidate="txbtelefono" ErrorMessage="*Ingrese Valores Numericos"
                                    ForeColor="Red"
                                    ValidationExpression="^[0-9]*">
                                </asp:RegularExpressionValidator>--%>
                <%--  </asp:TableCell>--%>
                <%-- <asp:TableCell>
                                <asp:TextBox ID="txbcorreo" runat="server"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server"
                                    ControlToValidate="txbcorreo" Display="Dynamic"
                                    ErrorMessage="Formato de correo invalido"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    ValidationGroup="AllValidators" ForeColor="Red" Font-Bold="True">
                                    Formato no válido.
                                </asp:RegularExpressionValidator>
                            </asp:TableCell>--%>
                <%--   </asp:TableRow>
                    </asp:Table>--%>



                <%-- </div>--%>

                <div id="divExtra" accesskey="divExtra" class="row" runat="server" style="margin-top: 20px;">
                    <div class="col-md-3" runat="server" style="padding-top: 0px;">
                        Contraseña
                            <asp:TextBox ID="textBoxClave" runat="server" TextMode="Password" ViewStateMode="Enabled" CssClass="cajaTexto"></asp:TextBox>
                        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="textBoxClave"
                            ID="MyPassordMinLengthValidator" ValidationExpression="^[\s\S]{4,}$" runat="server"
                            ErrorMessage="La contraseña debe tener mínimo 4 caracteres.">
                        </asp:RegularExpressionValidator>
                    </div>

                    <div class="col-md-3 caja" runat="server" style="padding-top: 0px;">
                        Confirmar contraseña
                            <asp:TextBox ID="textBoxClave2" runat="server" TextMode="Password" ViewStateMode="Enabled" CssClass="cajaTexto"></asp:TextBox>
                        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="textBoxClave2"
                            ID="RegularExpressionValidator9" ValidationExpression="^[\s\S]{4,}$" runat="server"
                            ErrorMessage="La contraseña debe tener mínimo 4 caracteres.">
                        </asp:RegularExpressionValidator>
                    </div>

                </div>

                <div class="row" style="margin-top: 10px;">

                    <div class="col-md-5" style="padding-top: 0%">

                        <asp:TableHeaderRow>
                            <asp:TableCell>
                                <asp:Label ID="Label7" CssClass="form-label" runat="server" Text="Observaciones"></asp:Label>
                            </asp:TableCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow CssClass="tablerow">
                            <asp:TableCell>
                                <asp:TextBox ID="txbobs" runat="server" Rows="10" TextMode="MultiLine" ToolTip="Observaciones" Height="160px" ViewStateMode="Disabled"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>


                        <%-- <div id="divExtra" accesskey="divExtra" class="" style="margin-bottom: 5px; margin-top:20px" runat="server">--%>

                        <%--</div>--%>
                    </div>



                    <%--  <div class="col-md-3" style="height: 130px">
                        <asp:Label ID="Label1" CssClass="form-label" runat="server" Text="Fecha nacimiento"></asp:Label>--%>

                    <%-- <asp:Table ID="Table1" runat="server" CssClass="table-responsive">
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
                        </asp:Table>--%>

                    <%-- </div>--%>
                    <div class="col-md-3" style="height: inherit">
                        <asp:Button ID="btnCrearCuenta" runat="server" Text="Crear cuenta" CssClass="small crearBTN " OnClick="habilitarCredenciales_Click" />
                        <asp:Button ID="btnModificar" runat="server" Text="Finalizar registro" CssClass="small  " OnClick="btnRegistrar_Click" />
                    </div>
                </div>

            </div>
        </form>
    </div>
</asp:Content>
