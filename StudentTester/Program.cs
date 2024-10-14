using StudentTesterV3.Entities;
using StudentTesterV3.Services;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet tuSE = new(500);
            Cabinet tuIA = new(500);
            tuSE.AddStudent("SE1", "An Nguyen", 2004, 8.6);
            tuSE.AddStudent("SE2", "Binh  Le", 2004, 8.7);
            tuSE.AddStudent(new Student() { Id="SE3", Name="Cuong Vo", Yob=2004, Gpa=8.8 });

            tuIA.AddStudent("SE4", "Dung Pham", 2006, 8.6);
            Student s = new Student() { Id = "SE5", Name = "Chi Trung", Yob = 2004, Gpa = 8.9 };
            tuIA.AddStudent(s);
            
            Console.WriteLine("The List Of IA Students := ");
            tuIA.PrintStudentList();

            Console.WriteLine("The List Of SE Students := ");
            tuSE.PrintStudentList();
            tuSE.DeleteStudent("SE5");
            Console.WriteLine("The List Of SE Students After Delete SE5 := ");
            tuSE.PrintStudentList();

            // đổi tên cu cường 

            //tuSE.UpdateStudent("SE3","Negav Anh Trai Say Good Bye", null, null);
            //Console.WriteLine("After Updating SE3's Name := ");
            //tuSE.PrintStudentList();
        }
    }
}
