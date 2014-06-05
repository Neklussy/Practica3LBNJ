using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    interface ICourseManager
    {
        public static List<Course> getAll();
        public static Course get(int ID);
        public static int Add(Course c);
        public static bool Remove(int ID);
    }
}
