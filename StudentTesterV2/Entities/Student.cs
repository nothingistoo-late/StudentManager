using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    public class Student : IIdentifiable
    {
     public string Id {  get; set; }
        public string? Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString() => $"{Id} {Name} {Yob} {Gpa}";
        
    }
}

// ta cần lưu trữ nhiều hồ sơ sinh viên
// lưu trữ nhiều hồ sơ sinh viên thì cần khai báo mảng 

// Student[] arr = new Student[500];
// Int Count = 0;// Count++ theo dần những hồ sơ được cất vào

// câu hỏi: mảng và biến count khai báo ở đâu
// Nguyên lí S trong SOLID: mỗi class chỉ làm tròn việc của mình, Class Student đã làm tròn việc: lưu trữ hồ sơ từng bạn, tức new Student() trong ram

// Chỗ nào cất nhiều hồ sơ -> kh phải câu chuyện của class Student
// cái tủ đựng nhiều hồ sơ

// nó có đủ cái khái CRUD hồ sơ: Create/ Insert: thêm
//                               Retrive/ Read: lấy toàn bộ, in sao kê
//                               Update
//                               Delete

// tủ đựng hồ sơ, tủ đựng balo giỏ xách ở siêu thị, -> quầy dịch vụ khách hàng -> Service 


