<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="CrearRutina.aspx.cs" Inherits="UI.CrearRutina" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <script src="js/jquery.quicksearch.js"></script>
    <script src="js/jquery-1.4.1.min.js"></script>
    <script  type="text/javascript">
        $(document).ready(function () {
            $('input#<%=txtBuscarEjercicio.ClientID%>').quicksearch('table#<%=grdEjercicios.ClientID%> tbody tr');
        });
    </script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">


    <script>
        function valida(esto, checkbox) {

            var rowscount = document.getElementById('<%=grdEjercicios.ClientID%>').rows.length;

            var id = checkbox.id;

            var primerNum = 0;


            for (i = -1; i > rowscount * -1; i--) {
                if (/^([0-9])*$/.test(id.substr(i))) {
                    primerNum = id.substr(i);
                } else {
                    i = rowscount * -1;
                }
            }

            document.getElementById('Cuerpo_grdEjercicios_txtRepeticiones_' + primerNum).disabled = !esto;
            document.getElementById('Cuerpo_grdEjercicios_txtSeries_' + primerNum).disabled = !esto;
            document.getElementById('Cuerpo_grdEjercicios_GuardarLinea_' + primerNum).disabled = !esto;

            if (!checkbox.checked) {
                document.getElementById('Cuerpo_grdEjercicios_txtRepeticiones_' + primerNum).value = "";
                document.getElementById('Cuerpo_grdEjercicios_txtSeries_' + primerNum).value = "";
            }
        }

        function txtRepeticionesZipOnChange(txt) {

            var rowscount = document.getElementById('<%=grdEjercicios.ClientID%>').rows.length;

            var id = txt.id;

            var primerNum = 0;


            for (i = -1; i > rowscount * -1; i--) {
                if (/^([0-9])*$/.test(id.substr(i))) {
                    primerNum = id.substr(i);
                } else {
                    i = rowscount * -1;
                }
            }

            // get the validator and check if it is valid
            var val = document.getElementById('Cuerpo_grdEjercicios_RegularExpressionValidator1_' + primerNum);
            if (val.isvalid == false) {
                document.getElementById('Cuerpo_grdEjercicios_txtRepeticiones_' + primerNum).value = "";
                //document.getElementById('Cuerpo_grdEjercicios_txtSeries_' + primerNum).text = "";
            }
        }

        function SeriesZipOnChange(text) {

            var rowscount = document.getElementById('<%=grdEjercicios.ClientID%>').rows.length;

            var id = text.id;

            var primerNum = 0;


            for (i = -1; i > rowscount * -1; i--) {
                if (/^([0-9])*$/.test(id.substr(i))) {
                    primerNum = id.substr(i);
                } else {
                    i = rowscount * -1;
                }
            }

            // get the validator and check if it is valid
            var val = document.getElementById('Cuerpo_grdEjercicios_RegularExpressionValidator2_' + primerNum);
            if (val.isvalid == false) {
                //document.getElementById('Cuerpo_grdEjercicios_txtRepeticiones_' + primerNum).value = "";
                document.getElementById('Cuerpo_grdEjercicios_txtSeries_' + primerNum).value = "";
            }
        }


    </script>
    <form id="form1" runat="server" style="background-color: lightgray">

        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="input-group">
                        <asp:TextBox ID="txtNuevaRutina" runat="server" Width="300px" Height="45px" Wrap="False" placeholder="NOMBRE RUTINA" BackColor="WhiteSmoke"></asp:TextBox>
                        <asp:Button ID="btnCrearRutina" runat="server" Font-Size="Medium" Text="GUARDAR RUTINA" Width="250px" Height="55px" BackColor="darkolivegreen" OnClick="btnCrearRutina_Click" />
                    </div>
                    <div>
                        <br />
                        <asp:Label ID="lbBuscarEjercicio" runat="server" Text="BUSCAR:" Font-Bold="true"></asp:Label>
                        <div class="input-group">
                            <asp:TextBox ID="txtBuscarEjercicio" class="form-control" runat="server" Width="300px" Height="45px" Wrap="False" placeholder="EJERCICIO" BackColor="WhiteSmoke"></asp:TextBox>
                            <asp:Button ID="btnBuscar" runat="server" Font-Size="Medium" Text="BUSCAR" Width="100px" Height="45px" BackColor="darkolivegreen" OnClick="btnBuscar_Click" />
                        </div>

                    </div>
                    <asp:GridView ID="grdEjercicios" runat="server" class="table-responsive-lg table-bordered text-center" BackColor="Silver" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField HeaderText="SELECCIÓN">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkSeleccion" runat="server" onClick="javascript:valida(this.checked, this)" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Wrap="false" Width="55px" VerticalAlign="Middle" />
                            </asp:TemplateField>

                            <asp:BoundField DataField="Ejercicio" HeaderText="Ejercicio" ItemStyle-VerticalAlign="Middle" />

                            <asp:TemplateField HeaderText="REPETICIONES">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtRepeticiones" Enabled="false" runat="server" onClick="validarRegularExpresion1(this)" onChange="txtRepeticionesZipOnChange(this);" Width="55px" Height="25px" Wrap="false" BackColor="WhiteSmoke" MaxLength="3" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                        ControlToValidate="txtRepeticiones" runat="server"
                                        ErrorMessage="Solo números permitidos"
                                        ValidationExpression="\d+">
                                    </asp:RegularExpressionValidator>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Wrap="false" Width="55px" />
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="SERIES">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtSeries" Enabled="false" runat="server" onClick="validarRegularExpresion2(this)" onChange="SeriesZipOnChange(this);" Width="55px" Height="25px" Wrap="false" BackColor="WhiteSmoke" MaxLength="3" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                        ControlToValidate="txtSeries" runat="server"
                                        ErrorMessage="Solo números permitidos"
                                        ValidationExpression="\d+">
                                    </asp:RegularExpressionValidator>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Wrap="false" Width="55px" />
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button Enabled="false" ForeColor="LightGreen" Font-Size="Small" BackColor="#98989a" runat="server" CommandArgument='<%# Container.DataItemIndex  %>' OnClick="GuardarLinea_Click" Width="100px" Height="35px" Wrap="false" ID="GuardarLinea" Text="Guardar" />
                                    <asp:Button Enabled="true" Visible="false" ForeColor="Red" Font-Size="Small" BackColor="#98989a" runat="server" CommandArgument='<%# Container.DataItemIndex  %>' OnClick="DescartarLinea_Click" Width="100px" Height="35px" Wrap="false" ID="DescartarLinea" Text="Descartar" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Wrap="false" Width="55px" />
                            </asp:TemplateField>

                        </Columns>
                        <HeaderStyle BackColor="#999999" BorderStyle="Double" Font-Bold="True" />
                    </asp:GridView>

                </div>
                <div class="col-md-1">
                </div>
            </div>
        </div>
    </form>
</asp:Content>
