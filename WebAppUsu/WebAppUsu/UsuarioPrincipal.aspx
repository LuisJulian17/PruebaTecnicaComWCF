<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioPrincipal.aspx.cs" Inherits="WebAppUsu.UsuarioPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="container">
            <div class="d-inline-flex p-2">
                <asp:Label ID="Label3" runat="server" Text="Nombre :"></asp:Label>
            </div>
            <div class="d-inline-flex p-2">
                <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>
            <div class="d-inline-flex p-2">
                <asp:Label ID="Label4" runat="server" Text="Fecha Nacimiento:"></asp:Label>
            </div>
            <div class="d-inline-flex p-2">
                <asp:TextBox TextMode="Date" ID="txtfecha" runat="server"></asp:TextBox>
            </div>
            <div class="d-inline-flex p-2">
                <asp:Label ID="Label6" runat="server" Text="Sexo:"></asp:Label>
            </div>
            <div class="d-inline-flex p-2">
                <asp:DropDownList CssClass="btn btn-info dropdown-toggle" ID="DropSexo" runat="server">
                    <asp:ListItem>M</asp:ListItem>
                    <asp:ListItem>F</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="Button2" runat="server" class="btn btn-success" OnClick="Button2_Click" Text="Agregar Usuario" />
                <asp:Button ID="Button6" runat="server" class="btn btn-warning" OnClick="Button6_Click" Text="Ir a Usuario Consulta" />
            </div>
            <div class="d-flex flex-row-reverse">
                <asp:Label ID="lblMensaje" CssClass="fw-bolder" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
