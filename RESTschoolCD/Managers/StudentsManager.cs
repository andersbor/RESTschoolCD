using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTschoolCD.Models;

namespace RESTschoolCD.Managers
{
    public class StudentsManager
    {
        private static int _nextId = 1;
        private static readonly List<Student> Data = new List<Student>()
        {
            new Student() {Id = _nextId++, Name = "Anders"}
        };

        public List<Student> GetAll()
        {
            return new List<Student>(Data);
        }

        public Student GetById(int id)
        {
            return Data.FirstOrDefault(student => student.Id == id);
        }
    }
}
