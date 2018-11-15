<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Notificacion.aspx.cs" Inherits="UI.Notificacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
     <script src="http://ajax.googleapis.com/ajax/libs/jquery/x.x.x/jquery.min.js"></script>
    <script src="jquery.bpopup-x.x.x.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <form runat="server">   
         <%--<asp:Button  ID="Button" runat="server" OnClick="Button_Click" Text="Enviar MSJ" />
            $('Button').bPopup({
            autoClose: 1000 //Auto closes after 1000ms/1sec
        });--%>
             
    </form>
   <%-- <a href="https://wa.me/50683955544?text=esto%20es%20una%20prueba%20para%20la%20api%20de%20whatsapp">Whatsapp</a>--%>

    <div class="w3-container" id="listaPed">
    <asp:literal runat="server" ID="Notif"></asp:literal> 
    </div>
   

 <%-- <table class="w3-table-all w3-hoverable" >
    <thead>
      <tr class="w3-light-grey">
        <th>First Name</th>
        <th>Last Name</th>
        <th>Points</th>
      </tr>
    </thead>--%>
   <%-- <tr>
      <td>Jill</td>
      <td>Smith</td>
      <td>50</td>
    </tr>
    <tr>
      <td>Eve</td>
      <td>Jackson</td>
      <td>94</td>
    </tr>
    <tr>
      <td>Adam</td>
      <td>Johnson</td>
      <td>67</td>
    </tr>
  </table>
</div>--%>

</asp:Content>
