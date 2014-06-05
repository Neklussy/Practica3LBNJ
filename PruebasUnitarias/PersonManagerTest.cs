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
            Assert.AreEqual(pers.Count,35);
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

            Assert.AreEqual(p.PersonID, 39);
        }
        [TestMethod]
        public void removeTest(){
            bool elimina = PersonManager.remove(39);
            Assert.AreEqual(elimina,true);
        }
        
    }
}
