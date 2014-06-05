<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevaPersona.aspx.cs" Inherits="Practica3_MF0493.nuevaPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Practica MF0493_3</title>
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-datepicker.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap-datepicker.js"></script>
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
                    <a class="navbar-brand" runat="server" href="~/">Índice</a>
                </div>
                <div class="navbar-collapse collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="persona.aspx">Listado de Alumnos</a></li>
                        <li><a runat="server" href="Default.aspx">Volver</a></li>
                    </ul>
                </div>
            </div>
        </div>
         <div class="container body-content">
              <h1>Nuevo Alumno</h1>
             <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
             <table>
             <tr><td>Apellidos: </td><td><asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
             <tr><td>Nombre: </td><td><asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
             <tr><td>Fecha de ingreso: </td><td><asp:TextBox ID="txtFechaIngreso" data-provide="datepicker" data-date-format="dd/mm/yyyy" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
             <tr><td>Fecha de inscripción: </td><td><asp:TextBox ID="txtFechaInscripcion" data-provide="datepicker" data-date-format="dd/mm/yyyy" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
             <tr><td><asp:Button ID="Button1" runat="server" Text="Alta" OnClick="btnADDPersona" CssClass="btn btn-default" /></td></tr>
             </table>
       
    </div>

        <footer>
            <p style="text-align: center">&copy; Proyecto MF0493_3 </p>
        </footer>
    </form>
</body>
</html>
