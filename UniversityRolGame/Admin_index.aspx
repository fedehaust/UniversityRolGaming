<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_index.aspx.cs" Inherits="UniversityRolGame.Admin_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>| University Rol Game | - Admin Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="btnCargaAlu" Text="Cargar Alumno"/><br/>
        <asp:Button runat="server" ID="btnCargaQuest" Text="Cargar Quest"/><br/>
        <asp:Button runat="server" ID="btnCargaItem" Text="Cargar Item"/><br/>
        <asp:Button runat="server" ID="btnEliminarAlumno" Text="Eliminar Alumno"/><br/>
        <asp:Button runat="server" ID="btnEditarAlumno" Text="Editar Alumno"/><br/>
    </div>
        <div runat="server" visible="true" id="cAlumno">
    Usuario <asp:TextBox id="txtUsuarioA" runat="server"></asp:TextBox><br/>
    Contraseña <asp:TextBox id="txtContraseniaA" runat="server"></asp:TextBox><br/>
    Nombre <asp:TextBox id="txtNombreA" runat="server"></asp:TextBox><br/>
    Apellido <asp:TextBox id="txtApellidoA" runat="server"></asp:TextBox><br/>
    Legajo <asp:TextBox id="txtLegajoA" runat="server"></asp:TextBox><br/>
    Categoria <asp:DropDownList ID="ddlCategoriaA" runat="server">
        <asp:ListItem Text="Alumno" Value="0"/>
        <asp:ListItem Text="Profesor" Value="1"/>
        </asp:DropDownList><br/>
    Curso <asp:DropDownList ID="ddlCursoA" runat="server">
        <asp:ListItem Text="2W1" Value="0"/>
        <asp:ListItem Text="2W2" Value="1"/>
        </asp:DropDownList><br/>
            <asp:Button ID="btnCargarAlumno" runat="server" Text="Guardar"/>
            </div>
        <div runat="server" visible="true" id="cProfesor">
                Usuario <asp:TextBox id="txtUsuarioP" runat="server"></asp:TextBox><br/>
                Contraseña <asp:TextBox id="txtContraseniaP" runat="server"></asp:TextBox><br/>
                Nombre <asp:TextBox id="txtNombreP" runat="server"></asp:TextBox><br/>
                Apellido <asp:TextBox id="txtApellidoP" runat="server"></asp:TextBox><br/>
                Legajo <asp:TextBox id="txtLegajoP" runat="server"></asp:TextBox><br/>
                Categoria <asp:DropDownList ID="ddlCategoriaP" runat="server">
                    <asp:ListItem Text="Alumno" Value="0"/>
                    <asp:ListItem Text="Profesor" Value="1"/>
                    </asp:DropDownList><br/>
                Curso <asp:DropDownList ID="ddlCursoP" runat="server">
                    <asp:ListItem Text="2W1" Value="0"/>
                    <asp:ListItem Text="2W2" Value="1"/>
                    </asp:DropDownList><br/>
                        <asp:Button ID="btnCargarProfesor" runat="server" Text="Guardar"/>
               </div>
        <div runat="server" visible="true" id="cQuest">
            Nombre <asp:TextBox ID="txtNombreQ" runat="server"/>
            Descripcion <asp:TextBox ID="txtDescripcionQ" runat="server"/>
            Oro <asp:TextBox ID="txtOroQ" runat="server"/>
            Xp <asp:TextBox ID="txtXpQ" runat="server"/>
            <asp:Button ID="btnCargarMision" runat="server" Text="Guardar"/>
        </div>
        <div runat="server" visible="true" id="cItem">
            Nombre <asp:TextBox id="txtNombreI" runat="server"/>
            Oro <asp:TextBox ID="txtOroI" runat="server"/>
            Xp <asp:TextBox ID="txtXpI" runat="server"/>
            <asp:Button ID="btnCargarItems" runat="server" Text="Guardar"/>
        </div>
        <div runat="server" visible="true" id="eAlumno">
            <asp:Label ID="lblEliminar" runat="server" Text="Colocar legajo del alumno a eliminar."/>
            Legajo <asp:TextBox ID="txtLegEliminar" runat="server"/>
            <asp:Button ID="btnDeleteAlumno" runat="server" text="Eliminar"/>
        </div>
        <div runat="server" visible="true" id="edAlumno">
            <asp:Label ID="lblEditar" runat="server" Text="Colocar legajo del alumno a editar."/>
            Legajo <asp:TextBox ID="txtLegEditar" runat="server"/>
            <asp:Button ID="btnEditAlumno" runat="server" Text="Editar"/>
        </div>
    </form>
</body>
</html>
