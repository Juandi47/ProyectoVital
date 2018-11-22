<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaClientesAdmin.aspx.cs" Inherits="UI.ListaClientesAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="admin_estilos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <form runat="server" style="padding-left:2%">

        <h1 id="Label1" runat="server">asds</h1>
       <%-- <asp:Literal ID="Literal1" runat="server" ></asp:Literal>--%>
        <asp:Table ID="tablaClientes" CssClass="table-responsive" runat="server">
            
        </asp:Table>
        <asp:Button ID="addBTN" runat="server" Text="Finalizar" OnClick="addBTN_Click"/>
        <asp:Label ID="ListaTotal" runat="server"></asp:Label>


    </form>

</asp:Content>
