<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="CrearRutina.aspx.cs" Inherits="UI.CrearRutina" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>

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
    <style>
        #div1 {
            overflow: scroll;
            height: 500px;
            width: 1090px;
        }
    </style>
    <form id="form1" runat="server" style="background-color: lightgray">

        <div class="container">
            <div class="row">
                <%--<div class="col-md-1"></div>--%>
                <div class="col-md-11">
                    <br />
                    <br />
                    <div>

                        <asp:Label ID="Label1" runat="server" Text="Nombre de la nueva rutina: " Font-Bold="true"></asp:Label>

                        <br />
                        <asp:TextBox Width="500px" ID="txtNuevaRutina" runat="server" Wrap="False" placeholder="NOMBRE RUTINA" class="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="VerificadorExistencia" runat="server" Text="Ya existe esta rutina" ForeColor="Red" Visible="false"></asp:Label>
                    <div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtNuevaRutina" runat="server" SetFocusOnError="true" ErrorMessage="Debe escribir el nombre de la rutina" ValidationGroup="txtVacio"></asp:RequiredFieldValidator>

                        <br />
                        <asp:Label ID="lbBuscarEjercicio" runat="server" Text="Buscar: " Font-Bold="true"></asp:Label>
                        <div class="input-group">
                            <asp:TextBox ID="txtBuscarEjercicio" onkeyup="buscarEjercicio()" class="form-control" runat="server" Width="500px" Wrap="False" placeholder="EJERCICIO"></asp:TextBox>
                            <br />
                            <br />
                        </div>
                        <br />
                    </div>
                    <div id="div1">
                        <asp:GridView Width="1070px" ID="grdEjercicios" runat="server" class="table-responsive-lg table-bordered text-center" BackColor="Silver" AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateField HeaderText="SELECCIÓN">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkSeleccion" runat="server" onClick="javascript:valida(this.checked, this)" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Wrap="false" Width="55px" VerticalAlign="Middle" />
                                </asp:TemplateField>

                                <asp:BoundField DataField="Ejercicio" HeaderText="EJERCICIO" ItemStyle-VerticalAlign="Middle" />

                                <asp:TemplateField HeaderText="REPETICIONES">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtRepeticiones" Enabled="false" runat="server" onClick="validarRegularExpresion1(this)" onChange="txtRepeticionesZipOnChange(this);" Width="60px" Height="35px" Wrap="false" BackColor="WhiteSmoke" MaxLength="3" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                            ControlToValidate="txtRepeticiones" runat="server"
                                            ErrorMessage="Números"
                                            SetFocusOnError="true"
                                            ForeColor="red"
                                            ValidationExpression="\d+">
                                        </asp:RegularExpressionValidator>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Wrap="false" Width="55px" VerticalAlign="Middle" />
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="SERIES">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtSeries" Enabled="false" runat="server" onClick="validarRegularExpresion2(this)" onChange="SeriesZipOnChange(this);" Width="60px" Height="35px" Wrap="false" BackColor="WhiteSmoke" MaxLength="3" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                            ForeColor="red"
                                            ControlToValidate="txtSeries" runat="server"
                                            ErrorMessage="Números"
                                            ValidationExpression="\d+">
                                        </asp:RegularExpressionValidator>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Wrap="false" Width="55px" />
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button Enabled="false" Font-Size="Small" runat="server" CommandArgument='<%# Container.DataItemIndex  %>' OnClick="GuardarLinea_Click" Width="100px" Height="40px" Wrap="false" ID="GuardarLinea" Text="Agregar" />
                                        <asp:Button Enabled="true" Visible="false" ForeColor="Red" Font-Size="Small" BackColor="#98989a" runat="server" CommandArgument='<%# Container.DataItemIndex  %>' OnClick="DescartarLinea_Click" Width="100px" Height="40px" Wrap="false" ID="DescartarLinea" Text="Devolver" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Wrap="false" Width="25px" />
                                </asp:TemplateField>

                            </Columns>
                            <HeaderStyle BackColor="#999999" BorderStyle="Double" Font-Bold="True" />
                        </asp:GridView>
                    </div>
                    <br />
                    <asp:Button ID="btnCrearRutina" runat="server" Font-Size="Small" Text="GUARDAR RUTINA" OnClick="btnCrearRutina_Click" ValidationGroup="txtVacio" />
                    <br />
                    <br />
                </div>
                <%-- <div class="col-md-1">
                </div>--%>
            </div>
        </div>
        <script>
            function buscarEjercicio() {
                // Declare variables 
                var input, filter, table, tr, td, i, txtValue;
                input = document.getElementById('<%=txtBuscarEjercicio.ClientID%>');
                filter = input.value.toUpperCase();
                table = document.getElementById('<%=grdEjercicios.ClientID%>');
                tr = table.getElementsByTagName("tr");

                // Loop through all table rows, and hide those who don't match the search query
                for (i = 0; i < tr.length; i++) {
                    td = tr[i].getElementsByTagName("td")[1];
                    if (td) {
                        txtValue = td.textContent || td.innerText;
                        if (txtValue.toUpperCase().indexOf(filter) > -1) {
                            tr[i].style.display = "";
                        } else {
                            tr[i].style.display = "none";
                        }
                    }
                }
            }
        </script>
    </form>
</asp:Content>
