using StudentTesterV3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Services
{
    public class LectureCabinet
    {
        private Lecturer[] _arr; // kh new ngay, cho size vao
        private int _count = 0;// bắt đầu gán vị trí count 0 tăng dần

        // cst hàng độ size đưa vào, chủ yếu size cà chớn
        // hoặc set default
        public LectureCabinet(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("Invalid size! The size must be >=1");
            _arr = new Lecturer[size]; // new mảng size hợp lệ
        }

        // hàm CRUD
        public void AddLecturer(Lecturer lecturer)
        {
            // convert  qua expression body
            _arr[_count] = lecturer;
            // to do: về nhà check tràn mảng
        }

        public int? SearchLecturerById(string id) { 
            if (_count == 0) return null;
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                    return i;
            }
            // đi hết vòng for kh tìm thấy thì return null
            return null;


        }





    }
}
