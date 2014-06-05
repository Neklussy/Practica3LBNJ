using Practica3_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3_MF0493
{
    public partial class nuevoCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnADDCurso_Click(object sender, EventArgs e)
        {
            Course curso = new Course();

            curso.CourseID = Convert.ToInt32(this.txtID.Text);
            curso.Credits = Convert.ToInt32(this.txtCreditos.Text);
            curso.Title = this.txtNombre.Text;
            curso.DepartmentID = Convert.ToInt32(this.txtDepartamento.Text);

            CourseManager.Add(curso);
            Response.Redirect("cursos.aspx");
        }
    }
}