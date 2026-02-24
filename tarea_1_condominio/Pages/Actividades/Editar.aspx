<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Editar.aspx.cs"
    Inherits="tarea_1_condominio.Pages.Actividades.Editar"
    MasterPageFile="~/Site.Master"
    %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">


    <h2>Editar Actividad</h2>

    <asp:HiddenField ID="hfId" runat="server" />

    <div>
        <label>Título:</label>
        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" />
    </div>

    <div>
        <label>Fecha Publicación:</label>
        <asp:TextBox ID="txtPublicacion" runat="server" TextMode="Date" CssClass="form-control"/>
    </div>

    <div>
        <label>Fecha Cierre:</label>
        <asp:TextBox ID="txtCierre" runat="server" TextMode="Date" CssClass="form-control"/>
    </div>
    <br/>
    <asp:Button ID="btnGuardar" runat="server"
        Text="Guardar Cambios"
        OnClick="btnGuardar_Click" CssClass="form-control"/>
    <br/>

    <asp:Button ID="btnVolver" runat="server"
        Text="Volver"
        PostBackUrl="~/Pages/Actividades/Actividades.aspx" CssClass="form-control"/>

     <asp:Label ID="lblMensaje" runat="server" />
</asp:Content>
