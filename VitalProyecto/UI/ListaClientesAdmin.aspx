<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaClientesAdmin.aspx.cs" Inherits="UI.ListaClientesAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <style>
        .radio-eli {
            font: 10px;
            border-radius: 5%;
        }

        .radio-mod {
            font: 10px;
            border-radius: 5%;
        }

        tablaClientes:only-child {
            border-bottom: 5px solid gray;
            background-color: red;
        }

        .fila1 {
        width:20%;
        background-color:#ffd800;
        }
    </style>
    <%--  <script>
        function salvarID(id) {
            _doPostBack("id", id);
        }
    </script>--%>
    <%--<div class="col-md-1"></div>
    <div class="col-md-10">--%>

	 <asp:Label ID="labelTitulo" runat="server" CssClass="title">Lista de clientes:</asp:Label>
             	<br />
	<br />
    <div class="form-container" runat="server">
       <br /><br />
        <asp:Label ID="labelAlerta" runat="server" CssClass="labelAlerta"></asp:Label>
       
		<div class="form-container">
		 <form runat="server">
                  <asp:TextBox class="form-control" runat="server" ID="txbFiltrar" placeholder="Escriba para filtrar"></asp:TextBox>
				   <br />
				   <asp:Table ID="tablaClientes" CssClass="table-responsive table-bordered text-center" runat="server">
                  </asp:Table>
                  <script src="js/jquery.quicksearch.js"></script>
                  <script src="js/jquery-1.4.1.min.js"></script>     
                  <script type="text/javascript">         
                      $(document).ready(function () {
                          $('input#<%=txbFiltrar.ClientID%>').quicksearch('table#<%=tablaClientes.ClientID%> tbody tr');
                      });</script>
              </form>
			</div>
    </div>
</asp:Content>
