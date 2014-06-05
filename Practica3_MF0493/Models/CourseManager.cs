using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica3_MF0493.Models
{
    public class CourseManager: ICourseManager
    {
        public List<Course> getAll()
        {
            List<Course> lst = new List<Course>();
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    
                }
            }
            catch
            {

            }
            return null;
        }
        public Course get(int ID)
        {
            return null;
        }
        public int Add(Course c)
        {
            return -1;
        }
        public bool Remove(int ID)
        {
            return false;
        }
    }
}