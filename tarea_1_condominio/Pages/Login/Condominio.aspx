<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Condominio.aspx.cs" Inherits="tarea_1_condominio.Pages.Login.Condominio" 
    MasterPageFile="~/Site.Master"
    %>

 <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">
    <h2>Login para Condómino</h2>

     <div class="form-group">
    <label>Correo electrónico</label>
    <asp:TextBox ID="CondCorreo" runat="server" CssClass="form-control" ClientIDMode="Static"/>
</div>

<div class="form-group">
    <label>Contraseña</label>
    <asp:TextBox ID="CondPassword" runat="server" TextMode="Password" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

     <asp:Button ID="btnAuth" runat="server"
Text="Login"
CssClass="btn btn-primary"
OnClick="btnAuth_Click"
ClientIDMode="Static"/>

     <asp:Label ID="lblMensaje" runat="server" />

          <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src='<%= ResolveUrl("~/Scripts/login.js") %>'></script>
</asp:Content>
