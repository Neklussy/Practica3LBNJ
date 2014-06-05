<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica3_MF0493.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Practica MF0493_3</title>
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
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
                        <li><a runat="server" href="#">Proyecto Grupal</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container body-content">
           <div class="col-md-4"></div>
    <div class="col-md-4">
        <div class="panel panel-primary">
            <div class="panel-heading">
                Menu principal
            </div>
            <div class="panel-body">
                <a href="cursos.aspx" class="btn btn-block btn-lg btn-warning">Listado de Cursos</a>
                <a href="nuevaPersona.aspx" class="btn btn-block btn-lg btn-warning">Nuevo Alumno</a>
                <a href="persona.aspx" class="btn btn-block btn-lg btn-warning">Listado de Alumnos</a>
                <a href="nuevoCurso.aspx" class="btn btn-block btn-lg btn-warning">Nuevo Curso</a>
                
            </div>
        </div>
     </div>
    <div class="col-md-4"></div>
        </div>
        <footer>
            <p style="text-align: center">&copy; Proyecto MF0493_3 </p>
        </footer>
</body>
</html>
