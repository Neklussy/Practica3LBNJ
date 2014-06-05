using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practica3_MF0493.Models
{
    public class PersonManager: IPersonaManager
    {
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
        public Person get(int ID) {
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
        public int add(Person p);
        public int remove(int iD);
    }
}