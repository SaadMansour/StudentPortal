using StudentPortal.Models;

namespace StudentPortal.DataAccess.Abstract
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();

        void Add(Student student);
    }
}
