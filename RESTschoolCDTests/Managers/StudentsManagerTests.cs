using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTschoolCD.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using RESTschoolCD.Models;

namespace RESTschoolCD.Managers.Tests
{
    [TestClass()]
    public class StudentsManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            StudentsManager manager = new StudentsManager();
            List<Student> allStudents = manager.GetAll();
            Assert.AreEqual(1, allStudents.Count);
            Assert.AreEqual("Anders", allStudents[0].Name);
        }
    }
}