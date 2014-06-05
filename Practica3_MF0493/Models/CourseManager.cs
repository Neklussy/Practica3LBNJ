using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practica3_MF0493.Models
{
    public class CourseManager: ICourseManager
    {
        /// <summary>
        /// metodo para listar los cursos
        /// </summary>
        /// <returns>devuelve una lista de cursos</returns>
        public List<Course> getAll()
        {
            List<Course> lst = new List<Course>();
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    var consulta = from tabla in db.Course
                                   select tabla;

                    Course curso;
                    foreach (Course c in consulta)
                    {
                        curso = new Course();
                        curso.CourseID = c.CourseID;
                        curso.Title = c.Title;
                        curso.Credits = c.Credits;
                        curso.DepartmentID = c.DepartmentID;
                        
                        lst.Add(curso);
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lst;
        }

        /// <summary>
        /// metodo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Course get(int ID)
        {
            Course curso = new Course();
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    var consulta = from tabla in db.Course
                                   where tabla.CourseID == ID
                                   select tabla;

                    curso = consulta.First();
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return curso;
        }

        public int Add(Course c)
        {
            try
            {
                if (c != null)
                {
                    using(SchoolEntities db = new SchoolEntities()) {
                        db.Course.Add(c);
                        db.SaveChanges();
                        return c.CourseID;
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException sqlex)
            {
                return -1;
            }
            catch (Exception ex)
            {

                return -1;
            }
            
        }
        public bool Remove(int ID)
        {

            return false;
        }
    }
}