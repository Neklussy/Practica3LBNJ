using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica3_MF0493;
using System.Collections.Generic;
using Practica3_MF0493.Models;

namespace PruebasUnitarias
{
    [TestClass]
    public class PersonManagerTest
    {
        /// <summary>
        /// Testea el metodo getAll de la clase PersonManager. Comprobamos que el numero de resultados obtenidos se incrementa en uno al insertar. Y baja en uno al eliminar.
        /// </summary>
        [TestMethod]
        public void getAllTest()
        {
            List<Person> pers = new List<Person>();
            pers = PersonManager.getAll();
            int numero = pers.Count;

            Person p = new Person();
            p.FirstName = "laura";
            p.LastName = "rodriguez";
            int id = PersonManager.add(p);

            pers = PersonManager.getAll();
            int numero2 = pers.Count;
            Assert.AreEqual(numero+1,numero2);

            bool elimina = PersonManager.remove(id);
            pers = PersonManager.getAll();
            int numero3 = pers.Count;
            Assert.AreEqual(numero, numero3);

        }

        /// <summary>
        /// Testea el metodo get de la clase PersonManager. Comprobamos que devuelve la persona correcta indicandole su identificador.
        /// </summary>
        [TestMethod]
        public void getTest() {
            Person per = new Person();
            per= PersonManager.get(1);
            Assert.AreEqual(per.FirstName, "Kim");
        }

        /// <summary>
        /// Testea el metodo add de la clase  PersonManager. Comprobamos que al crear una persona no devuelve error. Lo eliminamos despues para que el test no afecte a la base de datos.
        /// </summary>
        [TestMethod]
        public void addTest() { 
            
            Person p = new Person();
            p.FirstName = "laura";
            p.LastName = "rodriguez";
            int id = PersonManager.add(p);
            Assert.AreNotEqual(id, -1);

            bool elimina = PersonManager.remove(id);
            
        }

        /// <summary>
        /// Testea el metodo remove de la clase PersonManager. Comprueba que el metodo devuelve true al eliminar. Antes se crea un usuario, para poder borrarlo y que no altere la base de datos.
        /// </summary>
        [TestMethod]
        public void removeTest(){
            Person p = new Person();
            p.FirstName = "laura";
            p.LastName = "rodriguez";
            int id = PersonManager.add(p);
            
            bool elimina = PersonManager.remove(id);
            Assert.AreEqual(elimina,true);
        }
        
    }
}
