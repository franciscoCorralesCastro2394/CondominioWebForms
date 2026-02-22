<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tarea_1_condominio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <asp:HyperLink ID="lnkRegistro" runat="server"
            NavigateUrl="~/Pages/Registro/Registro.aspx">
            Registrarse
        </asp:HyperLink>

        <asp:HyperLink ID="HyperLink1" runat="server"
            NavigateUrl="~/Pages/Login/Condominio.aspx">
      Login Condominio 
        </asp:HyperLink>

    </main>

</asp:Content>
