using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practica3_MF0493.Models
{
    public class PersonManager: IPersonaManager
    {
        /// <summary>
        /// Metodo que devuelve la lista de personas almacenadas en la base de datos
        /// </summary>
        /// <returns>Devuelve un List de Person</returns>
        public static List<Person> getAll() 
        {
            List<Person> lstPersonas = new List<Person>();
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    var consulta = from e in db.Person
                                   select e;

                    Person per;
                    foreach (Person p in consulta)
                    {
                        per = new Person();
                        per.PersonID = p.PersonID;
                        per.FirstName = p.FirstName;
                        per.LastName = p.LastName;
                        per.HireDate = p.HireDate;
                        per.EnrollmentDate = p.EnrollmentDate;
                        lstPersonas.Add(per);
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
            return lstPersonas;
        }
        /// <summary>
        /// Metodo que obtiene los datos de la persona que se corresponde con le id que se pasa por parametro.
        /// </summary>
        /// <param name="ID">Id de la persona que queremos obtener. Es un int</param>
        /// <returns>Devuelve un objeto de tipo Person</returns>
        public static Person get(int ID) {
            Person per = new Person();
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    var consulta = from e in db.Person
                                   where e.PersonID == ID
                                   select e;

                    per = consulta.First();
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
            return per;
        }
        /// <summary>
        /// Metodo para añadir una nueva persona. Devuelve el id de la persona insertada.
        /// </summary>
        /// <param name="p">Objeto Person que contiene todos los datos de la persona que se quiere insertar excepto el id que se genera automatico al insertar. </param>
        /// <returns>Devuelve el id de la persona insertada si todo va bien y -1 si no se inserta</returns>
        public static int add(Person p) {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {

                        db.Person.Add(p);
                        db.SaveChanges();

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
            return p.PersonID;

        }
        /// <summary>
        /// Metodo para eliminar la persona que se correpsonde con el id que se pasa por parametro.
        /// </summary>
        /// <param name="ID">id de la persona a eliminar de tipo int</param>
        /// <returns>devuelve true si se realizo correctamente y false si hubo algun problema</returns>
        public static bool remove(int ID) 
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    var resultado = from e in db.Person
                                    where e.PersonID == ID
                                    select e;
                    Person per = resultado.First();
                    db.Person.Remove(per);
                    db.SaveChanges();
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
            return true;
        }
    }
}