using StudentTesterV3.Entities;
using StudentTesterV2.Services;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo Cabinet cho Student
            Cabinet<Student> studentCabinet = new Cabinet<Student>(10);
            studentCabinet.Add("S001", "Alice", 2000, 3.8);
            studentCabinet.Add("S002", "Bob", 1999, 3.5);

            studentCabinet.PrintLList();

            // Tạo Cabinet cho Lecturer
            Cabinet<Lecturer> lecturerCabinet = new Cabinet<Lecturer>(5);
            lecturerCabinet.Add(new Lecturer("L001", "Dr. Smith", 1975, 5000.0));
            lecturerCabinet.Add(new Lecturer("L002", "Prof. Johnson", 1980, 6000.0));

            lecturerCabinet.PrintLList();
        }
    }
}
