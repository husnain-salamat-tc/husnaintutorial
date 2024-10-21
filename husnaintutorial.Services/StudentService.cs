using husnaintutorial.core.Dtos;
using husnaintutorial.core.IRepositoryInterfaces;
using husnaintutorial.core.IServiceInterface;
using husnaintutorial.Repository;

namespace husnaintutorial.Services
{
    public class StudentService : IStudentService
    {
        public async Task AddStudentAsync(StudentDto student)
        {
            IStudentRepository studentRepository = new StudentRepository();
            await studentRepository.AddStudentAsync(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            IStudentRepository studentRepository = new StudentRepository();
            await studentRepository.DeleteStudentAsync(id);
        }

        public async Task UpdateStudentAsync(StudentDto student)
        {
            IStudentRepository studentRepository = new StudentRepository();
            await studentRepository.UpdateStudentAsync(student);
        }
    }
}
