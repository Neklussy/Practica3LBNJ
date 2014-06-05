using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    interface IPersonaManager
    {
        public List<Person> getAll();
        public Person get(int ID);
        public int add(Person p);
        public int remove(int iD);
    }
}
