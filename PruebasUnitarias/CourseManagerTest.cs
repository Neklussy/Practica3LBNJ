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
            Assert.AreEqual(lista.Count, 12);
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
            c.CourseID = 4064;
            c.Title = "berna";
            c.Credits = 4;
            c.DepartmentID = 7;
            id = CourseManager.Add(c);
            Assert.AreNotEqual(id,-1);
        }

        [TestMethod]
        public void RemoveTest()
        {
            bool c = CourseManager.Remove(1);
            Assert.AreEqual(c, false);

            c = CourseManager.Remove(4064);
            Assert.AreEqual(c, true);
        }
    }
}
