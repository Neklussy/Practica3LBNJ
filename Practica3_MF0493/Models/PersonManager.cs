using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practica3_MF0493.Models
{
    public class PersonManager: IPersonaManager
    {
        public List<Person> getAll() 
        {
            try
            {
                List<Person> lstPersonas = new List<Person>();
                using (SchoolEntities db = new SchoolEntities())
                {
                    var consulta = from e in db.Person
                                   select e;

                    per = new Person();

                    
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
        }
        public Person get(int ID);
        public int add(Person p);
        public int remove(int iD);
    }
}