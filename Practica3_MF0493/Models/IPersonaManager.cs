using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    interface IPersonaManager
    {
        public static List<Person> getAll();
        public static Person get(int ID);
        public static int add(Person p);
        public static bool remove(int ID);
    }
}
