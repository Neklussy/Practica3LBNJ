<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="persona.aspx.cs" Inherits="Practica3_MF0493.persona" %>

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
                        <li><a runat="server" href="../Default.aspx">Cerrar sessión</a></li>
                        <li><a runat="server" href="nuevo.aspx">Nuevo Alumno</a></li>
                    </ul>
                </div>
            </div>
        </div>
         <div class="container body-content">
            <h1>Listado de Alumnos</h1>
         <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" CellPadding="4" EmptyDataText="No hay empresas en ese sector." BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" GridLines="None" ForeColor="Black" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
                </ContentTemplate>
                </asp:UpdatePanel>
        </div>

        <footer>
            <p style="text-align: center">&copy; Proyecto MF0493_3 </p>
        </footer>
    </form>
</body>
</html>
