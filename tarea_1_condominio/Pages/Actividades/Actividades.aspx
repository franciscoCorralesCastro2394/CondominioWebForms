<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Actividades.aspx.cs"
    Inherits="tarea_1_condominio.Pages.Actividades.Actividades"
    MasterPageFile="~/Site.Master" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Activiades</h2>
    <asp:Button
        ID="btnVolver"
        runat="server"
        Text="Volver a Gestion"
        OnClick="btnVolver_Click"
        CssClass="form-control" />

    <br />

    <%-- Selector de actividades  --%>

    <div class="form-group">
        <label>Tipo de Actividad</label>
        <asp:DropDownList
            ID="ddlTipoActividad"
            runat="server"
            ClientIDMode="Static" CssClass="form-control">
            <asp:ListItem Text="Seleccione..." Value="" />
            <asp:ListItem Text="Reunión" Value="Reunion" />
            <asp:ListItem Text="Actividad social" Value="Social" />
            <asp:ListItem Text="Recordatorio" Value="Recordatorio" />
        </asp:DropDownList>
    </div>


    <%-- Campos generales  --%>
    <h3>Campos Generales</h3>

    <label>Titulo</label>
    <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"
        ClientIDMode="Static" placeholder="Título" />

    <br />

    <asp:CheckBox ID="chkTodos" runat="server" CssClass="form-control"
        ClientIDMode="Static"
        Text="Enviar a todos los condóminos" />

    <br />
    <label>Fecha Publicación</label>

    <asp:TextBox ID="txtFechaPublicacion" CssClass="form-control"
        runat="server"
        TextMode="DateTimeLocal"
        ClientIDMode="Static" />
    <br />

    <label>Fecha Cierre</label>
    <asp:TextBox ID="txtFechaCierre" CssClass="form-control"
        runat="server"
        TextMode="DateTimeLocal"
        ClientIDMode="Static" />

    <%-- Reunionses  --%>

    <div id="panelReunion" style="display: none;">

        <h3>Datos de Reunión</h3>

        <label>Fecha Reunión </label>
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
        <label>Fecha Inicio</label>

        <asp:TextBox ID="txtFechaInicio" CssClass="form-control"
            runat="server"
            TextMode="DateTimeLocal"
            ClientIDMode="Static" />
        <br />

        <label>Fecha Fin</label>

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

    <asp:Button ID="btnRegistrar" runat="server"
        Text="Registrar Actividad"
        CssClass="btn btn-primary"
        OnClick="btnRegistrar_Click"
        ClientIDMode="Static" />

    <asp:Label ID="lblMensaje" runat="server" />


    <br />
    <br />
    <br />

    <h2>Reuniones</h2>
    <asp:GridView ID="gvReuniones" runat="server" CssClass="form-control"
        AutoGenerateColumns="false"
        DataKeyNames="Id"
        OnRowCommand="gvReuniones_RowCommand"
       >

        <Columns>

            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="FechaHoraReunion" HeaderText="Fecha Reunión" />
            <asp:BoundField DataField="DuracionEstimada" HeaderText="Duración" />
            <asp:BoundField DataField="Agenda" HeaderText="Agenda" />
            <asp:BoundField DataField="UbicacionPresencial" HeaderText="Ubicacion Presencial" />

            <asp:TemplateField HeaderText="Detalles">
                <ItemTemplate>
                    <asp:Button
                        ID="Detalles"
                        runat="server"
                        Text="Detalles"
                        CommandName="Detalles"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>

                    <asp:Button
                        ID="btnEditar"
                        runat="server"
                        Text="Editar"
                        CommandName="Editar"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Eliminar">
                <ItemTemplate>
                    <asp:Button
                        ID="btnEliminar"
                        runat="server"
                        Text="Eliminar"
                        CommandName="Eliminar"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />

                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


    <h2>Actividades Sociales</h2>
    <asp:GridView ID="gvSociales" runat="server" AutoGenerateColumns="false" CssClass="form-control"
        DataKeyNames="Id"
        OnRowCommand="gvActividad_RowCommand"
       >
        <Columns>
            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="TipoActividad" HeaderText="Tipo Actividad" />
            <asp:BoundField DataField="Ubicacion" HeaderText="Ubicacion" />
            <asp:BoundField DataField="Formato" HeaderText="Formato" />

            <asp:TemplateField HeaderText="Detalles">
                <ItemTemplate>
                    <asp:Button
                        ID="Detalles"
                        runat="server"
                        Text="Detalles"
                        CommandName="Detalles"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>

                    <asp:Button
                        ID="btnEditar"
                        runat="server"
                        Text="Editar"
                        CommandName="Editar"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Eliminar">
                <ItemTemplate>
                    <asp:Button
                        ID="btnEliminar"
                        runat="server"
                        Text="Eliminar"
                        CommandName="Eliminar"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />

                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>




    <h2>Recordatorios</h2>
    <asp:GridView ID="gvRecordatorios" runat="server" AutoGenerateColumns="false" CssClass="form-control"
        DataKeyNames="Id"
        OnRowCommand="gvRecordatorio_RowCommand"
        >

        <Columns>
            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />

            <asp:TemplateField HeaderText="Detalles">
                <ItemTemplate>
                    <asp:Button
                        ID="Detalles"
                        runat="server"
                        Text="Detalles"
                        CommandName="Detalles"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>

                    <asp:Button
                        ID="btnEditar"
                        runat="server"
                        Text="Editar"
                        CommandName="Editar"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Eliminar">
                <ItemTemplate>
                    <asp:Button
                        ID="btnEliminar"
                        runat="server"
                        Text="Eliminar"
                        CommandName="Eliminar"
                        CommandArgument='<%# Eval("Id") %>'
                        CssClass="form-control" />

                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src='<%= ResolveUrl("~/Scripts/actividades.js") %>'></script>
</asp:Content>
