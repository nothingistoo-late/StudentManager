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
            Console.WriteLine("A[0] before connecting to b = " + a[0]);
            Console.WriteLine("A size before connecting to b = " + a.Length);
            a = b;// 2 chàng 1 nàng, mãng của của a gồm 1 2 3 4 5 bị mồ côi, bị CTMTDT dọn dẹp, bộ gom rác của runtime
            Console.WriteLine("A[0] after connecting to b = " + a[0]);
            Console.WriteLine("A size after connecting to b = " + a.Length);

            // tên mảng là biến than chiếu trỏ vùng new 
            // một lần nữa, 2 biến object bằng nhau nghĩa là trỏ trùng, 2 chàng 1 nàng, 
            // nếu tên mảng, tên biến object đưa qua tham số hàm, chẳng qua cũng là 2 chàng 1 nàng, trỏ cùng luôn
            // void F(Student[] a) cũng chính là mai mốt a = trỏ vào cùng mảng đưa vào hàm 

            // cho tao trỏ với, kh phải đưa vào!!!
            // mảng đã xin thì kh thay đổi kích thước đc
            // muốn thay đổi, trỏ mảng mới 

            a = new int[500];
            // a trỏ mảng mới 500 viến int bằng 0 default
            // hạn chế của mảng: - fix kích thước
            //                   - đổi kích thước là sang mảng khác
            //                   - phải đi kèm biến count, phá count là phá mảng
            // COLLECTION trong JAVA, C# giải quyết các hạn chế này
            // JAVA:
            // C#: giống và khác nhau
            // COLLECTIONS TRONG JAVA VÀ C# ĐỀU LÀ NHỮNG DẠNG CLASS GIỐNG NHƯ CÁI CABINET MÌNH ĐÃ VIẾT TỨC LÀ SINH RA NHỮNG CLASS NÀY ĐỂ CHỨA NHỮNG OBJECT KHÁC, NHƯNG NÓ LINH HOẠT HƠN MẢNG, CO GIÃN VỀ KÍCH THƯỚC, MUỐN THÊM THÌ NỚI, MUỐN BỚT THÌ THU HẸP
            // ĐICH ĐẾN CHƯA NHIỀU OBJECT

            // 99% CÁC CLASS NAYUF ĐC THIẾT KẾ ĐỂ CHỨA NHIỀU OBJECT, VÌ VẬY NÓ PHẢI LOOSE COUPLING, TỨC LÀ NÓ HẦU HẾT LÀ GENERIC
            // MUỐN XÀI NÓ THÌ PHẢI NÓI RẰNG CHƯA OBJECT GÌ
            // TỨC LÀ <??> <DATA TYPE MÚN CHỨA!!>
            
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
