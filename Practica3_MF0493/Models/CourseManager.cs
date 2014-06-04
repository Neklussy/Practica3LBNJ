using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica3_MF0493.Models
{
    public class CourseManager
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

        public CourseManager()
        {
            this.Title = "curso";
            this.Credits = 1;
        }
    }
}