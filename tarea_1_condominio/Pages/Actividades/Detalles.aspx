<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Detalles.aspx.cs"
    Inherits="tarea_1_condominio.Pages.Actividades.Detalles"
    MasterPageFile="~/Site.Master" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">

    <asp:Button 
    ID="btnVolver" 
    runat="server" 
    Text="Volver a Actividades" 
    OnClick="btnVolver_Click" 
    CssClass="form-control"     
        />

    <br/>
    <br/>


    <h2>Detalle de la Actividad</h2>

    <p><b>Título:</b>
        <asp:Label ID="lblTitulo" runat="server" /></p>
    <p><b>Fecha Publicación:</b>
        <asp:Label ID="lblPublicacion" runat="server" /></p>
    <p><b>Fecha Cierre:</b>
        <asp:Label ID="lblCierre" runat="server" /></p>
    <p><b>Creado Por:</b>
        <asp:Label ID="lblCreadoPor" runat="server" /></p>

    <asp:Panel ID="pnlReunion" runat="server" Visible="false">
        <p><b>Fecha Reunión:</b>
            <asp:Label ID="lblFechaReunion" runat="server" /></p>
    </asp:Panel>

    <asp:Panel ID="pnlSocial" runat="server" Visible="false">
        <p><b>Fecha Inicio:</b>
            <asp:Label ID="lblInicio" runat="server" /></p>
        <p><b>Fecha Fin:</b>
            <asp:Label ID="lblFin" runat="server" /></p>
    </asp:Panel>

    <asp:Panel ID="pnlRecordatorio" runat="server" Visible="false">
        <p><b>Descripción:</b>
            <asp:Label ID="lblDescripcion" runat="server" /></p>
    </asp:Panel>

</asp:Content>
