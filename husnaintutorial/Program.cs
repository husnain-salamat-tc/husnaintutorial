using husnaintutorial.core.IServiceInterface;
namespace husnaintutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            IStudentService studentService = new StudentService();


        }
    }
}
