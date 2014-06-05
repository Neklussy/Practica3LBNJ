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

                using (SchoolEntities db = new SchoolEntities())
                {
                }
            }
            catch (SqlException ex)
            {
                
            }
            catch (Exception ex)
            {
                

            }
        }
        public Person get(int ID);
        public int add(Person p);
        public int remove(int iD);
    }
}