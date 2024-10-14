using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    public class Lecturer
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public override string? ToString() => $"{Id} {Name} {Yob} {Salary}";
    }
}
// ta lại cần 1 cái tủ đựng hồ sơ giảng viên
// nước sông kh phạm nước giếng, mỗi class giải quyết công chuyện của mình - SOLID - SINGLE RESPONSIBILITY
// class lecturecabinet xuất hiện, code y chang