using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica3_MF0493.Models
{
    public class CourseManager
    {
        public List<Course> getAll(){
            try
            {
                List<Course> lst = new List<Course>();
                
                return lst;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            
        }
    }
}