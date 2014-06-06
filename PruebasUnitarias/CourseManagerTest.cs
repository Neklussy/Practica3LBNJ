using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica3_MF0493.Models;
using Practica3_MF0493;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class CourseManagerTest
    {
        /// <summary>
        /// Testea el metodo getAll de la clase CourseManager. Comprobamos que el numero de resultados obtenidos se incrementa en uno al insertar. Y baja en uno al eliminar.
        /// </summary>
        [TestMethod]
        public void getAllTest()
        {
            List<Course> lista = CourseManager.getAll();
            int numero = lista.Count;

            Course c = new Course();
            c.CourseID = 5000;
            c.Title = "berna";
            c.Credits = 4;
            c.DepartmentID = 7;
            int id = CourseManager.Add(c);

            lista = CourseManager.getAll();
            int numero2 = lista.Count;
            Assert.AreEqual(numero + 1, numero2);

            bool elimina = CourseManager.Remove(id);
            lista = CourseManager.getAll();
            int numero3 = lista.Count;
            Assert.AreEqual(numero, numero3);

            
        }

        /// <summary>
        /// Testea el metodo get de la clase CourseManager. Comprobamos que devuelve el curso correcto indicandole su identificador.
        /// </summary>
        [TestMethod]
        public void getTest()
        {
            Course c = CourseManager.get(1045);
            Assert.AreEqual(c.Title, "Calculus");

        }

        /// <summary>
        /// Testea el metodo add de la clase  CourseManager. Comprobamos que al crear un curso no devuelve error. Lo eliminamos despues para que el test no afecte a la base de datos.
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            Course c = new Course();
            c.CourseID = 5000;
            c.Title = "berna";
            c.Credits = 4;
            c.DepartmentID = 7;
            int id = CourseManager.Add(c);
            Assert.AreNotEqual(id, -1);
             
            bool elimina = CourseManager.Remove(id);
            
        }

        /// <summary>
        /// Testea el metodo remove de la clase CouseManager. Comprueba que el metodo devuelve true al eliminar. Antes se crea un curso, para poder borrarlo y que no altere la base de datos.
        /// </summary>
        [TestMethod]
        public void RemoveTest()
        {
            Course c = new Course();
            c.CourseID = 5000;
            c.Title = "berna";
            c.Credits = 4;
            c.DepartmentID = 7;
            int id = CourseManager.Add(c);

            bool elimina = CourseManager.Remove(id);
            Assert.AreEqual(elimina, true);
        }
    }
}
