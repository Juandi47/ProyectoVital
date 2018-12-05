<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="Noticia.aspx.cs" Inherits="UI.Noticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
     <link rel="StyleSheet" href="admin_estilos.css" type="text/css" media="screen">
    <link rel="stylesheet" href="css/Noticia.css" />
	<script src="js/alertify.min.js"></script>
	<link rel="stylesheet" href="/css/alertify.min.css" />
	<link rel="stylesheet" href="/css/semantic.min.css" />
	<script src="/alertify.js"></script>
	<script src="/mensaje.js"></script>

	<script type="text/javascript">
		function mensaje(){	
			alertify.success("El expediente ha sido actualizado");     
		}
	</script>

		<script type="text/javascript">
		function error(){	
			alertify.error("El expediente no se ha podido actualizar");     
		}
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <div class="form-container">

        <form id="form1" runat="server">

            <div class="container">
                <div class="row">
                    <div class="25">
                    </div>
                </div>


                <h1>DSVC Membership</h1>
                <div class="pill">
                    <input type="checkbox" id="pill__swap">
                    <label class="pill__label" for="pill__swap">
                        <span class="pill__label__option pill__label__option--ind">Individuals</span>
                        <span class="pill__label__option pill__label__option--org">Organizations</span>
                    </label>
                </div>
                <div class="table">
                    <div class="table__row">
                        <div class="tier">
                            <h2 class="tier__title tier__color--1">Visitor</h2>
                            <div class="tier__price tier__price--visitor">$0<span class="tier__price__duration">/yr</span></div>
                            <ul class="benefits">
                                <li class="benefits__blt benefits__blt--description">Visitors pay no membership fees, but pay admission to all events at full-price.</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--visitor">$20</span> Monthly Meetings</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--visitor">$45</span> Working Lunches</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--visitor">$150</span>  Job Postings</li>
                                <li class="benefits__blt">No Profile on DSVC.org</li>
                                <li class="benefits__blt">Full-Price Dallas Show Entries</li>
                            </ul>
                            <a class="tier__cta tier__cta--disabled tier__color--1" href="#" disabled>Register</a>
                        </div>
                        <div class="tier">
                            <h2 class="tier__title tier__color--2">Student</h2>
                            <div class="tier__price">$50<span class="tier__price__duration">/yr</span></div>
                            <ul class="benefits">
                                <li class="benefits__blt benefits__blt--description">Student Members enjoy all membership benefits on a student-sized budget.</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--free">Free</span> Monthly Meetings</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$25</span> Working Lunches</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$75</span> Job Postings</li>
                                <li class="benefits__blt">Custom Profile on DSVC.org</li>
                                <li class="benefits__blt">Discounted Dallas Show Entries</li>
                            </ul>
                            <a class="tier__cta tier__color--2" href="#">Sign Up</a>
                        </div>
                        <div class="tier">
                            <h2 class="tier__title tier__color--3">Junior</h2>
                            <div class="tier__price">$85<span class="tier__price__duration">/yr</span></div>
                            <ul class="benefits">
                                <li class="benefits__blt benefits__blt--description">Junior Members in the industry for less than 2 years enjoy all membership benefits on a starting salary.</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--free">Free</span> Monthly Meetings</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$25</span> Working Lunches</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$75</span> Job Postings</li>
                                <li class="benefits__blt">Custom Profile on DSVC.org</li>
                                <li class="benefits__blt">Discounted Dallas Show Entries</li>
                            </ul>
                            <a class="tier__cta tier__color--3" href="#">Sign Up</a>
                        </div>
                        <div class="tier">
                            <h2 class="tier__title tier__color--4">Professional</h2>
                            <div class="tier__price">$150<span class="tier__price__duration">/yr</span></div>
                            <ul class="benefits">
                                <li class="benefits__blt benefits__blt--description">Professional Members in the industry for more than 2 years enjoy all membership benefits.</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--free">Free</span> Monthly Meetings</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$25</span> Working Lunches</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$75</span> Job Postings</li>
                                <li class="benefits__blt">Custom Profile on DSVC.org</li>
                                <li class="benefits__blt">Discounted Dallas Show Entries</li>
                            </ul>
                            <a class="tier__cta tier__color--4" href="#">Sign Up</a>
                        </div>
                        <div class="tier tier--org">
                            <h2 class="tier__title tier__color--2">Corporate</h2>
                            <div class="tier__price">$900<span class="tier__price__duration">/yr</span></div>
                            <ul class="benefits">
                                <li class="benefits__blt benefits__blt--description">Corporate Memberships cover up to 5 employees. Addional individuals may be added for $150 each.</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--free">Free</span> Monthly Meetings</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$25</span> Working Lunches</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$75</span> Job Postings</li>
                                <li class="benefits__blt">Custom Profiles on DSVC.org for team members</li>
                                <li class="benefits__blt">Discounted Dallas Show Entries</li>
                                <li class="benefits__blt">Transferable Tickets</li>
                            </ul>
                            <a class="tier__cta tier__color--2" href="#">Sign Up</a>
                        </div>
                        <div class="tier tier--org">
                            <h2 class="tier__title tier__color--3">Sustaining</h2>
                            <div class="tier__price">$350<span class="tier__price__duration">/yr</span></div>
                            <ul class="benefits">
                                <li class="benefits__blt benefits__blt--description">Sustaining Memberships generously support the DSVC and the community.</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--free">Free</span> Monthly Meetings</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$25</span> Working Lunches</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$75</span> Job Postings</li>
                                <li class="benefits__blt">Custom Profiles on DSVC.org for team members</li>
                                <li class="benefits__blt">Discounted Dallas Show Entries</li>
                                <li class="benefits__blt">Transferable Tickets</li>
                            </ul>
                            <a class="tier__cta tier__color--3" href="#">Sign Up</a>
                        </div>
                        <div class="tier tier--org">
                            <h2 class="tier__title tier__color--4">Institutional</h2>
                            <div class="tier__price">$350<span class="tier__price__duration">/yr</span></div>
                            <!--<input class="tier__range" type="range" min="3" max="10" step="1" value="3">-->
                            <ul class="benefits">
                                <li class="benefits__blt benefits__blt--description">Institutional Memberships cover up to 3 professors. Additional individuals may be added for $120 each.</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--free">Free</span> Monthly Meetings</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$25</span> Working Lunches</li>
                                <li class="benefits__blt"><span class="benefits__blt__pricing benefits__blt__pricing--premium">$75</span> Job Postings</li>
                                <li class="benefits__blt">Custom Profiles on DSVC.org for team members</li>
                                <li class="benefits__blt">Discounted Dallas Show Entries</li>
                                <li class="benefits__blt">Transferable Tickets</li>
                            </ul>
                            <a class="tier__cta tier__color--4" href="#">Sign Up</a>
                        </div>
                    </div>
                </div>




            </div>
        </form>
    </div>
</asp:Content>
