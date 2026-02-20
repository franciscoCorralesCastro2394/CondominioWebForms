<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Actividades.aspx.cs"
    Inherits="tarea_1_condominio.Pages.Actividades.Actividades"
    MasterPageFile="~/Site.Master" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">
    <h2>Activiades</h2>


    <%-- Selector de actividades  --%>
    <asp:DropDownList
        ID="ddlTipoActividad"
        runat="server"
        ClientIDMode="Static" CssClass="form-control">
        <asp:ListItem Text="Seleccione..." Value="" />
        <asp:ListItem Text="Reunión" Value="Reunion" />
        <asp:ListItem Text="Actividad social" Value="Social" />
        <asp:ListItem Text="Recordatorio" Value="Recordatorio" />
    </asp:DropDownList>

    <%-- Campos generales  --%>
    <h3>Campos Generales</h3>

    <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"
        ClientIDMode="Static" placeholder="Título" />

    <br />

    <asp:CheckBox ID="chkTodos" runat="server" CssClass="form-control"
        ClientIDMode="Static"
        Text="Enviar a todos los condóminos" />

    <br />

    <asp:TextBox ID="txtFechaPublicacion" CssClass="form-control"
        runat="server"
        TextMode="DateTimeLocal"
        ClientIDMode="Static" />
      <br />
    <asp:TextBox ID="txtFechaCierre" CssClass="form-control"
        runat="server"
        TextMode="DateTimeLocal"
        ClientIDMode="Static" />

    <%-- Reunionses  --%>

    <div id="panelReunion" style="display: none;">

        <h3>Datos de Reunión</h3>

        <asp:TextBox ID="txtFechaReunion" CssClass="form-control"
            runat="server"
            TextMode="DateTimeLocal"
            ClientIDMode="Static" />
      <br />

        <asp:TextBox ID="txtDuracion" CssClass="form-control"
            runat="server"
            ClientIDMode="Static"
            placeholder="Duración estimada" />
      <br />

        <asp:TextBox ID="txtAgenda" CssClass="form-control"
            runat="server"
            TextMode="MultiLine"
            ClientIDMode="Static"
            placeholder="Agenda" />
      <br />

        <asp:TextBox ID="txtUbicacionPresencial" CssClass="form-control"
            runat="server"
            ClientIDMode="Static"
            placeholder="Ubicación presencial" />
      <br />

        <asp:TextBox ID="txtEnlaceVirtual" CssClass="form-control"
            runat="server"
            ClientIDMode="Static"
            placeholder="Enlace virtual" />

    </div>

    <%-- Actividad Social  --%>

    <div id="panelSocial" style="display: none;">

        <h3>Actividad Social</h3>

        <asp:TextBox ID="txtFechaInicio" CssClass="form-control"
            runat="server"
            TextMode="DateTimeLocal"
            ClientIDMode="Static" />
      <br />

        <asp:TextBox ID="txtFechaFin" CssClass="form-control"
            runat="server"
            TextMode="DateTimeLocal"
            ClientIDMode="Static" />
      <br />

        <asp:TextBox ID="txtUbicacionSocial" CssClass="form-control"
            runat="server"
            ClientIDMode="Static"
            placeholder="Ubicación" />
      <br />

        <asp:DropDownList ID="ddlFormato" CssClass="form-control"
            runat="server"
            ClientIDMode="Static">
            <asp:ListItem Text="Formal" />
            <asp:ListItem Text="Informal" />
        </asp:DropDownList>
      <br />

        <asp:TextBox ID="txtInstrucciones" CssClass="form-control"
            runat="server"
            TextMode="MultiLine"
            ClientIDMode="Static"
            placeholder="Instrucciones" />

    </div>


    <%-- Recordatorio --%>

    <div id="panelRecordatorio" style="display: none;">

        <h3>Recordatorio</h3>
      <br />

        <asp:TextBox ID="txtDescripcionRecordatorio" CssClass="form-control"
            runat="server"
            TextMode="MultiLine"
            ClientIDMode="Static"
            placeholder="Descripción" />

    </div>
      <br />

        <asp:Button ID="btnAuth" runat="server"
        Text="Registrar Actividad"
        CssClass="btn btn-primary"
        OnClick="btnRegistrar_Click"
        ClientIDMode="Static" />

     <asp:Label ID="lblMensaje" runat="server" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src='<%= ResolveUrl("~/Scripts/actividades.js") %>'></script>
</asp:Content>
