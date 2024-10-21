using husnaintutorial.core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husnaintutorial.core.IServiceInterface
{
    public interface IStudentService
    {
        Task AddStudentAsync(StudentDto student);
        Task UpdateStudentAsync(StudentDto student);
        Task DeleteStudentAsync(int id);
    }
}
