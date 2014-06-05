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
        /// <returns>devuelve una lista de todos los cursos</returns>
        public static List<Course> getAll()
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
        /// metodo que devulve un curso dado su identificador
        /// </summary>
        /// <param name="ID">identificador del curso que buscamos</param>
        /// <returns>devulve el curso si existe</returns>
        public static Course get(int ID)
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

        /// <summary>
        /// metodo que añade un curso nuevo
        /// </summary>
        /// <param name="c">curso a añadir</param>
        /// <returns>devulve el identificador del nuevo curso o -1 si no se puede añadir</returns>
        public static int Add(Course c)
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

        /// <summary>
        /// metodo que elimina un curso dado su ID
        /// </summary>
        /// <param name="ID">identificador del curso a eliminar</param>
        /// <returns>verdadero o falso segun si tuvo exito o no</returns>
        public static bool Remove(int ID)
        {

            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    var consulta = from tabla in db.Course where tabla.CourseID == ID select tabla;
                    Course curso = consulta.First();
                    db.Course.Remove(curso);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (SqlException sqlex)
            {
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
            
        }
    }
}