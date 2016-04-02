<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="UniversityRolGame.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>| University Rol Game | - Registro</title>
</head>
<body>
    <form id="registrar" runat="server">
    <div>
    Usuario <asp:TextBox id="txtUsuario" runat="server"></asp:TextBox><br/>
    Contraseña <asp:TextBox id="txtContrasenia" runat="server"></asp:TextBox><br/>
    Nombre <asp:TextBox id="txtNombre" runat="server"></asp:TextBox><br/>
    Apellido <asp:TextBox id="txtApellido" runat="server"></asp:TextBox><br/>
    Legajo <asp:TextBox id="txtLegajo" runat="server"></asp:TextBox><br/>
    Curso <asp:DropDownList ID="ddlCurso" runat="server">
        <asp:ListItem Text="2W1" Value="0"/>
        <asp:ListItem Text="2W2" Value="1"/>
        </asp:DropDownList><br/>
    <asp:Button runat="server" id="btnRegistrar" Text="Guardar" OnClick="btnGuardar_Click"/>
    </div>
    </form>
</body>
</html>
