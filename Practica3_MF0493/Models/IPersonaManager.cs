using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    interface IPersonaManager
    {
        List<Person> getAll();
        Person get(int ID);
        int add(Person p);
        bool remove(int ID);
    }
}
