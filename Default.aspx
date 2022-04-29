<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProfesoresAlumnosHerWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    </div>

    <div class="row">
        
        &nbsp;Universidad:<br />
        <br />
        Universidad&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="131px">
            <asp:ListItem>Mesoamericana</asp:ListItem>
            <asp:ListItem>Landivar</asp:ListItem>
            <asp:ListItem>San Carlos</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        sede&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Quetzaltenango</asp:ListItem>
            <asp:ListItem>Guatemala</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Alumno:<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        &nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
        &nbsp;<asp:TextBox ID="txtApellido" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Carnet"></asp:Label>
        &nbsp;<asp:TextBox ID="txtCarnet" runat="server"></asp:TextBox>
        <br />
        <br />
        Notas:<br />
        <br />
        &nbsp;Curso
        <asp:TextBox ID="txtCurso" runat="server"></asp:TextBox>
        <br />
        <br />
        
    &nbsp;<asp:Label ID="Label4" runat="server" Text="Nota"></asp:Label>
        &nbsp;&nbsp;<asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
        
        &nbsp;
        <asp:Button ID="btnIngresarNota" runat="server" Text="Ingresar nota al alumno" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Button ID="btnIngresarAlumno" runat="server" OnClick="Button2_Click" Text="Ingresar alumno a la Univierdiad" />
        
        <br />
        <br />
        <asp:Button ID="btnGuardarUniversidad" runat="server" OnClick="Button4_Click" Text="Guardar Universidad" />
        
        <br />
        <br />
        <br />
        <br />
        <br />
        
    </div>

</asp:Content>
