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
        [TestMethod]
        public void getAllTest()
        {
            List<Person> pers = new List<Person>();
            pers = PersonManager.getAll();
            Assert.AreEqual(pers.Count,44);
        }
        [TestMethod]
        public void getTest() {
            Person per = new Person();
            per= PersonManager.get(1);
            Assert.AreEqual(per.FirstName, "Kim");
        }
        [TestMethod]
        public void addTest() { 
            
            Person p = new Person();
            p.FirstName = "laura";
            p.LastName = "rodriguez";
            
            int id = PersonManager.add(p);

            Assert.AreEqual(p.PersonID, 49);
        }
        [TestMethod]
        public void removeTest(){
            bool elimina = PersonManager.remove(49);
            Assert.AreEqual(elimina,true);
        }
        
    }
}
