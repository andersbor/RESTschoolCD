using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RESTschoolCD.Models;

namespace RESTschoolCD.Managers.Tests
{
    [TestClass()]
    public class StudentsManagerTests
    {
        private readonly StudentsManager _manager = new StudentsManager();

        [TestMethod()]
        public void GetAllTest()
        {
            List<Student> allStudents = _manager.GetAll();
            Assert.AreEqual(1, allStudents.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {

        }
    }
}