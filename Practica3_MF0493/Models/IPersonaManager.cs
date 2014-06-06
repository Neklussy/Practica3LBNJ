using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_MF0493.Models
{
    interface IPersonaManager
    {
        /// <summary>
        /// Metodo que devuelve la lista de personas almacenadas en la base de datos
        /// </summary>
        /// <returns>Devuelve un List de Person</returns>
        List<Person> getAll();

        /// <summary>
        /// Metodo que obtiene los datos de la persona que se corresponde con le id que se pasa por parametro.
        /// </summary>
        /// <param name="ID">Id de la persona que queremos obtener. Es un int</param>
        /// <returns>Devuelve un objeto de tipo Person</returns>
        Person get(int ID);

        /// <summary>
        /// Metodo para añadir una nueva persona. Devuelve el id de la persona insertada.
        /// </summary>
        /// <param name="p">Objeto Person que contiene todos los datos de la persona que se quiere insertar excepto el id que se genera automatico al insertar.</param>
        /// <returns>Devuelve el id de la persona insertada si todo va bien y -1 si no se inserta</returns>
        int add(Person p);

        /// <summary>
        /// Metodo para eliminar la persona que se correpsonde con el id que se pasa por parametro.
        /// </summary>
        /// <param name="ID">id de la persona a eliminar de tipo int</param>
        /// <returns>devuelve true si se realizo correctamente y false si hubo algun problema</returns>
        bool remove(int ID);
    }
}
