<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioConsulta.aspx.cs" Inherits="WebAppUsu.UsuarioConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row mb-3 mt-3">
                <div class="col-10">
                    <asp:Label ID="Label4" runat="server" CssClass="justify-content-md-start" Text="Escriba el ID"></asp:Label>
                    <asp:TextBox ID="txtID" placeholder="ID de la persona a consultar o eliminar" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Buscar" />
                </div>
            </div>
            <div class="d-inline-flex p-2">
                <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>

            </div>
            <div class="d-inline-flex p-2">
                <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>
            <div class="d-inline-flex p-2">
                <asp:Label ID="Label5" runat="server" Text="Fecha Nacimiento:"></asp:Label>
            </div>
            <div class="d-inline-flex p-2">
                <asp:TextBox TextMode="Date" ID="txtfecha" runat="server"></asp:TextBox>
            </div>
            <div class="d-inline-flex p-2">
                <asp:Label ID="Label2" runat="server" Text="Sexo:"></asp:Label>
            </div>
            <div class="d-inline-flex p-2">
                <asp:DropDownList CssClass="btn btn-info dropdown-toggle" ID="DropSexo" runat="server">
                    <asp:ListItem>M</asp:ListItem>
                    <asp:ListItem>F</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="d-inline-flex p-2">
                <asp:Button ID="Button3" runat="server" class="btn btn-success" OnClick="Button3_Click" Text="Editar" />
            </div>
            <div class="d-inline-flex p-2">
                <asp:Button ID="Button4" runat="server" class="btn btn-danger" OnClick="Button4_Click" Text="Eliminar" />
            </div>
            <div>
                <asp:Button ID="Button5" runat="server" class="btn btn-success" OnClick="Button5_Click" Text="Actualizar Tabla" />
                <asp:Button ID="Button6" runat="server" class="btn btn-warning" OnClick="Button6_Click" Text="Volver" />
            </div>
            <div class="d-flex flex-row-reverse">
                <asp:Label ID="lblMensaje" CssClass="fw-bolder" runat="server"></asp:Label>
            </div>
            <div class="row">
                <div class="col-12">
                    <div>
                        <asp:GridView class="table table-striped table-dark" ID="gvDatos" runat="server">
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</html>
