using StudentPortal.DataAccess.Abstract;
using StudentPortal.Models;

namespace StudentPortal.DataAccess
{
    public class StudentRepository : IStudentRepository
    {
        #region Private Fields
        private static List<Student> _students = new List<Student> {
            new Student { Id = 1, Name = "Ali", DateOfBirth = new DateOnly(2008, 1, 1) }, 
            new Student { Id = 2, Name = "Ahmad", DateOfBirth = new DateOnly(2004, 1, 1) }
        };

        #endregion

        /// <summary>
        /// Adds New Student.
        /// </summary>
        /// <param name="student">Student returns from UI.</param>
        public void Add(Student student)
        {
            //Adding ...etc
            student.Name += "_Student";
            _students.Add(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }
    }
}
