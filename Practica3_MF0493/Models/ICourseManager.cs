using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    public interface ICourseManager
    {
         List<Course> getAll();
         Course get(int ID);
         int Add(Course c);
         bool Remove(int ID);
    }
}
