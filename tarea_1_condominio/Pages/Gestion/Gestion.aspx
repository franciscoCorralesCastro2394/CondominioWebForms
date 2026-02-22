<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="Gestion.aspx.cs"
    Inherits="tarea_1_condominio.Pages.Gestion.Gestion"
    MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">

    <asp:Label ID="lblMensaje" runat="server" />


    <div id="divActividades" runat="server" visible="false">
    <asp:Button ID="btnIrActividades" 
        runat="server" 
        Text="Gestión de mensajes" 
        PostBackUrl="~/Pages/Actividades/Actividades.aspx" />
</div>


    <div class="card">


        <h2>Información del Usuario</h2>

        <div class="info">
            <span class="label">Tipo ID:</span>
            <asp:Label ID="lblTipoId" runat="server" />
        </div>

        <div class="info">
            <span class="label">Identificación:</span>
            <asp:Label ID="lblIdentificacion" runat="server" />
        </div>

        <div class="info">
            <span class="label">Nombre:</span>
            <asp:Label ID="lblNombre" runat="server" />
        </div>

        <div class="info">
            <span class="label">Apellidos:</span>
            <asp:Label ID="lblApellidos" runat="server" />
        </div>

        <div class="info">
            <span class="label">Fecha Nacimiento:</span>
            <asp:Label ID="lblFechaNacimiento" runat="server" />
        </div>

        <div class="info">
            <span class="label">Filial:</span>
            <asp:Label ID="lblFilial" runat="server" />
        </div>

        <div class="info">
            <span class="label">Tiene Construcción:</span>
            <asp:Label ID="lblConstruccion" runat="server" />
        </div>

        <div class="info">
            <span class="label">Correo:</span>
            <asp:Label ID="lblCorreo" runat="server" />
        </div>

        <br />
    </div>
    <asp:Button ID="btnCerrarSesion" runat="server"
        Text="Cerrar Sesión"
        OnClick="btnCerrarSesion_Click" />




</asp:Content>
