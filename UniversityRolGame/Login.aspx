<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UniversityRolGame.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>University Rol Game - Login</title>
</head>
<body>
    <form id="login" runat="server">
     Usuario <asp:TextBox ID="txtLogUser" runat="server"/><br/>
     Contraseña <asp:TextBox ID="txtLogPass" runat="server"/><br/>
     <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click"/>
            <div>
    
    </div>
    </form>
</body>
</html>
