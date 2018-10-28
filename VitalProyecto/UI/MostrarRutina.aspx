<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarRutina.aspx.cs" Inherits="UI.MostrarRutina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%@ PreviousPageType VirtualPath="~/BancoRutinas.aspx" %> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">

    <form id="form1" runat="server">
        <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
    </form>

</asp:Content>
