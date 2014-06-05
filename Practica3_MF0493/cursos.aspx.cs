using Practica3_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3_MF0493
{
    public partial class cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            this.GridView1.DataSource = CourseManager.getAll();
            this.GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = e.Values["CourseID"].ToString();
            bool eliminado = CourseManager.Remove(Convert.ToInt32(id));

            this.GridView1.DataSource = CourseManager.getAll();
            this.GridView1.DataBind();
        }
    }
}