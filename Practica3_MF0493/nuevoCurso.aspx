<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevoCurso.aspx.cs" Inherits="Practica3_MF0493.nuevoCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Practica MF0493_3</title>
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
      <style type="text/css">
        input {
        margin: 10px 3px;
        }
    </style>
</head>
<body style="margin-top: 70px;">
    <form id="form1" runat="server">
     <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Practica MF0493_3</a>
                </div>
                <div class="navbar-collapse collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="cursos.aspx">Listado de cursos</a></li>
                        <li><a runat="server" href="Default.aspx">Volver</a></li>
                    </ul>
                </div>
            </div>
        </div>
         <div class="container body-content">
              <h1>Nuevo curso</h1>
             <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
             <table>
             <tr><td>Nombre: </td><td><asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
             <tr><td>Creditos: </td><td><asp:TextBox ID="txtFechaIngreso" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
             <tr><td>Departamento: </td><td><asp:TextBox ID="txtFechaInscripcion" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
             <tr><td><asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" CssClass="btn btn-default" /></td></tr>
             
             </table>
       <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_DataBinding"></asp:CustomValidator>
    </div>

        <footer>
            <p style="text-align: center">&copy; Proyecto MF0493_3 </p>
        </footer>
    </form>
</body>
</html>
