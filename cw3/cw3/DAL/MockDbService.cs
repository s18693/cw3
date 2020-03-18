using cw3.Models;
using System.Collections.Generic;


namespace cw3.DAL
{
    public class MockDbService : IDbService
    {

        private static IEnumerable<Student> _students;
        
        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent = 1, FirstName="Janek", LastName="Kowalczyk"},
                new Student{IdStudent = 2, FirstName="Jola", LastName="Monola"},
                new Student{IdStudent = 3, FirstName="Adam", LastName="Nowak"},

            };
        }


        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
