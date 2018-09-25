<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Notificacion.aspx.cs" Inherits="UI.Notificacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:Button CssClass="btn btn-light" ID="Button" runat="server" OnClick="Button_Click" Text="Enviar MSJ" />
    <a href="https://wa.me/50683955544?text=esto%20es%20una%20prueba%20para%20la%20api%20de%20whatsapp">Whatsapp</a>
</asp:Content>
