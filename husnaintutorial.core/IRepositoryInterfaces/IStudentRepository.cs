using husnaintutorial.core.Dtos;

namespace husnaintutorial.core.IRepositoryInterfaces
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(StudentDto student);
        Task UpdateStudentAsync(StudentDto student);
        Task DeleteStudentAsync(int id);
    }
}
