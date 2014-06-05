using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    interface ICourseManager
    {
        public List<Course> getAll();
        public Course get(int ID);
        public int Add(Course c);
        public bool Remove(int ID);
    }
}
