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
        [TestMethod]
        public void getAllTest()
        {
            List<Course> lista = CourseManager.getAll();
            Assert.AreEqual(lista.Count, 10);
        }

        [TestMethod]
        public void getTest()
        {
            Course c = CourseManager.get(1045);
            Assert.AreEqual(c.Title, "Calculus");

        }

        [TestMethod]
        public void AddTest()
        {
            Course c = new Course();
            c.CourseID = 1045;
            c.Title = "berna";
            c.Credits = 4;
            c.DepartmentID = 7;
            int id = CourseManager.Add(c);
            Assert.AreEqual(id, -1);


            c = new Course();
            c.CourseID = 4062;
            c.Title = "berna";
            c.Credits = 4;
            c.DepartmentID = 7;
            id = CourseManager.Add(c);
            Assert.AreNotEqual(id,-1);
        }

        
    }
}
