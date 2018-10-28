<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="BancoRutinas.aspx.cs" Inherits="UI.BancoRutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">



    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <asp:Table ID="Rutinas" runat="server">
                    </asp:Table>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>



    </form>



</asp:Content>
