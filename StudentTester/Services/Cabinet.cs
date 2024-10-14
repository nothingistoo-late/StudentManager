using StudentTesterV3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Services
{
    // 1 cái tủ thì chứa hiều hồ sơ
    // có thể bổ sing thêm, bớt đi, sắp xếp... -> CRUD method
    // muốn chứa nhiều hồ sơ, ta cần 1 mảng
    // mảng đi kèm bến Count để biết tủ đầu chưa
    // giống như anh chàng ở quầy dịch vị giữ chỗ, nhìn số chìa khóa cắm trên tủ, biết tủ full chưa

    public class Cabinet
    {

        private Student[] _arr;
        private int _count = 0;

        //public Cabinet(int size)
        //{ 
        //    if (size < 0) throw new ArgumentOutOfRangeException("size");
        //    throw new NotImplementedException();
        //    // giết, không cho tạo object
        //    _arr = new Student[size];
        //}
        public Cabinet(int size)
        {
            if (size < 1)
                size = 69;
            _arr = new Student[size];
        }


        // mở rộng: có cst là new vô tận số object
        //             cst mà ném ra ngoại lệ, thì tình huống đó kh new dc object, kh tạo dc object 
        //          nếu muốn trong ram chỉ có duy nhất 1 object tạo ra,  
        // không nhiều hơn 1 vùng new => SINGLETON!! (phải hiểu static)
        // DESIGN PATTERNS : các mẫu thiết kế class - sách của GoF - Gang Of Four
        // bà con với thằng SOLID
        // nó là kiến thức nền của nghề, vị trí tuyển dụng SA - Solution Architect - cỏe ra các class/interface để giúp app dễ dàng phát triển, tích hợp và mở rộng
        // mức lương 5k đô/month
        // search website: edward thiên hoàng (wordpress)
        // cuốn sách design patterns ở trên: 23 mẫu thiết kế class/interface ứng với từng dạng bài toán => kh cần phải hiểu hết ngay, áp dụng tất cả ngay ( vì khó, khó hiểu, khiến app cồng kềnh với nhiều class dự phòng cho việc mở rộng app sau này..)
        // linh hoạt tùy ngữ cảnh khi học design partterns 
        // AI: computer visionn - thị giác máy tính 
        // học cách áp dụng thuật toán là đc rồi 

        // count tăng dần ++ khi thêm từng hồ sơ vào vị trí thứ count của mảng, ban đầu là 0, 1, 2, 3....
        // đến khi mảng full
        // hàm CRUD !!! hồ sơ sinh viên
        // câu hỏi về nhà suy nghĩ:
        // tại sao tôi không làm property mà lại dùng _FILED
        // mảng này fix 365, ở ngoài đời đóng tủ  đa dạng kích thước, có thể theo yêu cầu, vậy tui phải làm sao để tủ đóng theo yêu cầu
        // coi như cái tủ đã đóng xong qua việc NEW CABINET(500)
        // ta đang có mảng 500/ hoặc size phần tử
        // Student[] _arr = new Student[500/size]

        // giờ là lúc _arr[i] = new Student();

        // hàm add student, cái tủ mở cánh cửa ra, đổ hồ sơ vào
        // ui console, web form/ window có mấy ô nhập:id, name, yob, gpa, có nút nhấm, new Student(){} đẩy xuống 
        public void AddStudent(Student s)
        {
            if (_arr.Length == _count)
                Console.WriteLine("Cabinet Is Full!!");
            else
            {
                _arr[_count] = s; // phần tử [i] là 1 biến con trỏ trỏ 
                                  // vùng new Student() {...}
                _count++;
            }
        }

        // hàm overloading 
        // todo: check mảng có full không mới add dc.

        public void AddStudent(string id, string name, int yob, double gpa)
        {
            if (_arr.Length == _count)
                Console.WriteLine("Cabinet Is Full!!");
            else
                _arr[_count++] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
        }
        // viết thanh expression bodied/body
        // đã có ds sv, có thể chưa full, in danh sách 
        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} Student(s) in the list:");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        //hàm xóa và sửa
        // xóa tại vị trí thứ i, và xóa theo id 
        // mảng có nhược điểm: fix kích thước khi đã new
        // nghĩa là mảng 500 thì sẽ là 500, xóa kh dc 
        // vậy xóa làm sao: xóa là lừa đảo, dồn chỗ lên thoi 
        // giảm count-- nhưng kích thước mảng vẫn như cũ
        // vị trí [0]  [1]  [2]  [3]  [4]
        //         5    10   15   20   25
        // tui muốn xóa số 15 
        // dồn 20 lên chỗ 15, dồn 25 lên chỗ 20 cũ,
        // [2] = [3]
        //       [3] = [4]
        //             [i] = [i+1]
        public void DeleteStudent(string id)
        {
            // có id thì tìm ra vị trí 
            int? pos = SearchStudentByID(id);
            if (pos.HasValue)
            {
                for (int i = (int)pos; i < _count; i++)
                    _arr[i] = _arr[i + 1];
                _count--;
            }
        }
        //update theo id, kh sửa id, mà chỉ sửa name, yob, gpa 
        // có id tìm ra vị trí cần sửa
        // 

        public void UpdateStudent(string id, string? newName, int? newYob, double? newGpa)
        {
            // muốn sửa vị trí muốn sửa theo id
            int? pos = SearchStudentByID(id);

            if (pos.HasValue)// if pos != null
            {
                if (newName != null)
                    _arr[(int)pos].Name = newName;
                if (newYob != null)
                    _arr[(int)pos].Yob = (int)newYob;
                if (newGpa != null)
                    _arr[(int)pos].Gpa = (double)newGpa;
                // todo at home: thêm câu if để check nếu ta đưa vào null của name, yob, gpa giữ như cũ, kh đổi, khác null mới đổi 
                // if (NAME != null) thì mới đổi như trên
                // if YOB != null thì mới [pos].Yob = newYob;
            }
        }





        // phát sinh hàm tìm vị trí theo id
        // chuỗi String/string trong java/C# đều là biến object
        // biến chuỗi trỏ vùng new String s1 = "Hello"; s2="hello";
        // thì s1 chắc chắn khác s2 do 2 con trỏ trỏ 2 vùng new khác nhau,
        // không bao giờ kiểu s1 == s2 hay không do đang so sánh 2 đụa chỉ, 2 con trỏ
        // java: s1.equalIgnoreCase(s2) gọi hàm lấy chuỗi vùng ram mà so 
        // C# cho phép dùng == để so sánh 2 chuỗi do nó đã override lại toán tử == của số cho biến object 
        // tuy nhiên, java và C# đều phân biệt hoa thường do mã ascii khác nhau 
        // khi so sánh, ta hay đổi lại cùng chữ hoa hay thường để so
        public int? SearchStudentByID(string id)
        {
            // quét mảng từ đầu tới count, coi mỗi đứa [I] có bằng id đang tìm kh, nếu có trả về vị trí, còn nếu không trả về vị trí null (pro hơn trả về -1)
            if (_count == 0)
                return null;
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                    return i;
            }
            // hết for mà kh bằng thì tức là kh thấy 
            return null;
        }

    }
}

// Viết ra giấy : thứ 2 tuần sau (14/10/2024) nộp bài 
// Cột điểm đó em iu !!

// BTVN:
// 1. hoàn tất nốt hàm xóa phần tử của mảng (dời chỗ trỏ của [i]    [j]) 
// 2. hoàn tất nốt update 1 phần tử của mảng (if nốt thôi)
// 3. 

