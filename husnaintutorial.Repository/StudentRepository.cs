using husnaintutorial.core.Dtos;
using husnaintutorial.core.IRepositoryInterfaces;
using husnaintutorial.Repository.Entities;

namespace husnaintutorial.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public Task AddStudentAsync(StudentDto student)
        {
            Student student1 = new Student();
            student1.Name = student.Name;
            student1.FatherName = student.FatherName;
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(StudentDto student)
        {
            throw new NotImplementedException();
        }
    }
}
