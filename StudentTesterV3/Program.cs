using StudentTesterV3.Entities;
using StudentTesterV3.Services;

namespace StudentTesterV3
{
    internal class Program
    {
        // svm + tab la tao ham main
        static void Main(string[] args)
        {
            // hiểu thêm về mảng, và biến tham chiếu, biến con trỏ
            int[] a = { 1, 2, 3, 4, 5 };// 5 biến in, 5 giá trị int 
            int[] b = { 5, 10, 15, 20, 25, 30, 35, 40 }; // 8 biến int, 8 value
        }
        static void PllayWithGeneric(string[] args)
        {
            // đi mua tủ đựng hồ sơ sinh viên, hồ sơ giảng viên mỗi nhóm 1 tủ khác nhau
            // JAVA
            // ArrayList<Student> list = new ArrayList<Student>()
            Cabinet<Student> arr = new Cabinet<Student>(500);

            Cabinet<Lecturer> arr2 = new Cabinet<Lecturer>(500);
            //          Student item 
            arr.AddItem(new Student() { Id = "SE1", Name = "An Nguyen", Yob = 2004, Gpa = 8.6 });
            arr.AddItem(new Student() { Id = "SE2", Name = "Binh Le", Yob = 2004, Gpa = 8.7 });
            // hậu trường của hàm: _arr[count] = new Student() ở trên,
            //                                   new trực tiếp 

            // new lẻ trước 
            Student s = new Student() {Id = "SE3", Name = "Cuong Vo", Yob = 2004, Gpa = 8.8 };
            arr.AddItem(s);
            // hậu trường _arr[count] = s = new bên ngoài - 2 chàng 1 nàng
            // hàm nhận vào (Student Item) Ite = s bên ngoài 
            // biến object này mà bằng biến object kia, nghĩa là truyền thái y style tham chiếu - 2 chàng 1 nàng
            // _ARR[i] = ITEM = S = new let thằng SE3

            arr.PrintList();

        }
    }
}
