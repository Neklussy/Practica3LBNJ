using Practica3_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3_MF0493
{
    public partial class nuevaPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnADDPersona(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                this.Validate();
                if (this.IsValid)
                {
                    Person p = new Person();
                    p.LastName = this.txtApellidos.Text;
                    p.FirstName = this.txtNombre.Text;
                    p.HireDate = Convert.ToDateTime(this.txtFechaIngreso.Text);
                    p.EnrollmentDate = Convert.ToDateTime(this.txtFechaInscripcion.Text);

                    int id = PersonManager.add(p);

                    Response.Redirect("persona.aspx");
                }
            }
        }
    }
}