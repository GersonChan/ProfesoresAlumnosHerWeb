<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="ProfesoresAlumnosHerWeb.Update" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Actualizar</h1>
        </div>
        <p>
            Carnet:
        </p>
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar alumno" OnClick="btnBuscar_Click" />
        </p>
        <p>
            Nombre:
        </p>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <p>
            Apellido:</p>
        <p>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Alumo" OnClick="btnActualizar_Click" />

</asp:Content>