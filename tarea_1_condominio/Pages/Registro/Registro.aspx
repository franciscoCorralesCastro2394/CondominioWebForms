<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Registro.aspx.cs" 
    Inherits="tarea_1_condominio.Pages.Registro.Registro" 
    MasterPageFile="~/Site.Master" %>


   
 <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">
    <h2>Registro de Condómino</h2>

<div class="form-group">
    <label>Tipo de Identificación</label>
    <asp:DropDownList ID="ddlTipoId" runat="server" CssClass="form-control" ClientIDMode="Static" required="required">
        <asp:ListItem Text="Seleccione..." Value="" />
        <asp:ListItem Text="Física" Value="Fisica" />
        <asp:ListItem Text="DIMEX" Value="DIMEX" />
        <asp:ListItem Text="Pasaporte" Value="Pasaporte" />
    </asp:DropDownList>
</div>

    <div class="form-group">
    <label>Identificación</label>
    <asp:TextBox ID="txtIdentificacion" runat="server" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

<div class="form-group">
    <label>Nombre</label>
    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

<div class="form-group">
    <label>Apellidos</label>
    <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

<div class="form-group">
    <label>Fecha de Nacimiento</label>
    <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date" CssClass="form-control" ClientIDMode="Static"/>
</div>

    <div class="form-group">
    <label>Número de Filial</label>
    <asp:TextBox ID="txtFilial" runat="server" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

<div class="form-group">
    <asp:CheckBox ID="chkConstruccion" runat="server" Text="Tiene construcción" ClientIDMode="Static"/>
</div>

<div class="form-group">
    <label>Correo electrónico</label>
    <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

<div class="form-group">
    <label>Contraseña</label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

    <div class="form-group">
    <label>Confirmar contraseña</label>
    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="form-control" ClientIDMode="Static" required="required"/>
</div>

<div class="form-group">
    <asp:CheckBox ID="chkTerminos" runat="server" 
    Text="Acepto términos y condiciones" ClientIDMode="Static"/>
</div>

    <br />

<asp:Button ID="btnRegistrar" runat="server"
Text="Registrarse"
CssClass="btn btn-primary"
OnClick="btnRegistrar_Click"
ClientIDMode="Static"/>

<br /><br />

<asp:Label ID="lblMensaje" runat="server" />

     <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src='<%= ResolveUrl("~/Scripts/registro.js") %>'></script>
</asp:Content>

