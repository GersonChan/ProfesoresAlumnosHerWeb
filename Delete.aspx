<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="ProfesoresAlumnosHerWeb.Delete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <h1>Eliminar</h1>
        </div>
        <p>
            Carnet:</p>
        <p>
            <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar alumno" OnClick="btnBuscar_Click" />
        </p>
        <p>
            Nombre:</p>
        <p>
            <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p>
            Apellido:</p>
        <p>
            <asp:TextBox ID="txtApellido" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <asp:Button ID="btnAlumno" runat="server" Text="Eliminar alumno" OnClick="btnAlumno_Click" />
</asp:Content>