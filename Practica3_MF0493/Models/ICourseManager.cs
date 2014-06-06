using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    public interface ICourseManager
    {
        /// <summary>
        /// Metodo que devuelve la lista de cursos almacenados en la base de datos
        /// </summary>
        /// <returns>Devuelve un List de Course</returns>
         List<Course> getAll();

        /// <summary>
         /// Metodo que obtiene los datos del curso que se corresponde con le id que se pasa por parametro.
        /// </summary>
         /// <param name="ID">Id del curso que queremos obtener. Es un int</param>
         /// <returns>Devuelve un objeto de tipo Course</returns>
         Course get(int ID);

        /// <summary>
         /// Metodo para añadir un nuevo curso. Devuelve el id del curso insertado.
        /// </summary>
         /// <param name="c">Objeto Course que contiene todos los datos del curso que se quiere insertar</param>
         /// <returns>Devuelve el id del curso insertado si todo va bien y -1 si no se inserta</returns>
         int Add(Course c);

        /// <summary>
         /// Metodo para eliminar el curso que se correpsonde con el id que se pasa por parametro.
        /// </summary>
         /// <param name="ID">id del curso a eliminar de tipo int</param>
         /// <returns>devuelve true si se realizo correctamente y false si hubo algun problema</returns>
         bool Remove(int ID);
    }
}
