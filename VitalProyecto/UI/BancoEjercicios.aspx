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
    <style>
        #div1 {
            overflow: scroll;
            height: 600px;
        }
    </style>
    <form id="form1" runat="server" style="background-color: lightgray">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <br />
                    <br />
                    <div class="input-group">

                        <asp:TextBox ID="txtNuevoEjercicio" runat="server" Width="300px" Height="45px" Wrap="False" placeholder="NUEVO EJERCICIO" BackColor="WhiteSmoke"></asp:TextBox>

                        <asp:Button ID="btnAgregarEjercicio" runat="server" Font-Size="Small" Text="Agregar Ejercicio" class="button input-group-addon" OnClick="btnAgregarEjercicio_Click" ValidationGroup="txtVacio" />
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtNuevoEjercicio" runat="server" SetFocusOnError="true" ErrorMessage="Debe escribir el nombre de la rutina" ValidationGroup="txtVacio"></asp:RequiredFieldValidator>
                    <div>
                        <asp:Label ID="VerificadorExistencia" runat="server" Text="Este ejercicio ya existe" ForeColor="Red" Visible="false"></asp:Label>
                    </div>
                    <br />
                    <asp:Label ID="lbBuscarEjercicio" runat="server" Text="Buscar: " Font-Bold="true"></asp:Label>
                    <div>
                        <asp:TextBox ID="txtBuscarEjercicio" onkeyup="buscarEjercicio()" class="form-control" runat="server" Width="500px" Wrap="False" placeholder="EJERCICIO"></asp:TextBox>

                    </div>
                    
                    <div id="div1">
                        <asp:GridView ID="grdEjercicios" runat="server" class="table table-bordered text-center" BackColor="Silver" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Ejercicio" HeaderText="EJERCICIO" ItemStyle-VerticalAlign="Middle" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnEliminar" Text="ELIMINAR" runat="server" CommandArgument='<%#Eval("Ejercicio")%>' OnClick="btnEliminar_Click" ForeColor="RoyalBlue" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Wrap="false" />
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle BackColor="#999999" BorderStyle="Double" Font-Bold="True" />
                        </asp:GridView>
                    </div>
                </div>
                <div class="col-md-1">
                </div>
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
                    td = tr[i].getElementsByTagName("td")[0];
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
