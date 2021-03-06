﻿using Practica3_MF0493.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica3_MF0493
{
    public partial class persona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView1.DataSource = PersonManager.getAll();
                this.GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string codigo = e.Values["PersonID"].ToString();

            PersonManager.remove(Convert.ToInt32(codigo));
          
            this.GridView1.DataSource = PersonManager.getAll();
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.GridView1.DataSource = PersonManager.getAll();
            this.GridView1.DataBind();
        }

    }
}