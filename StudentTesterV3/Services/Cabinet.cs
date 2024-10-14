using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Services
{
    // class Cabinet nếu design chỉ chơi với Student hoặc Lecture hoặc Pet... -> gọi là TIGHT COUPLING 
    // tuy nhiên code của chúng tương đồng nhau, vậy tại sao lại phải làm nhiều class mà code tương đồng nhau, hãy để class Cabinet kh chơi với 1 class cụ thể nào, hãy buông các class mà nên hứa hẹn là: tui Cabinet sẽ chơi với dc nhiều class khác nhau -> kh gắn kết chặt chẽ -> LOOSE COUPLING -> giúp cho class hoạt động linh hoạt, dễ dàng mở rộng, dễ dàng thích ứng với nhiều tình huống 
    // RED LABEL, BLUE LABEL, CHIVAS, HENNESSY súc miệng vì hiểu solution architect
    //class Cabinet có thể làm việc với đủ dạng class khác nhau, nếu ta chỉ cần CRUD trên các object của các class này 
    public class Cabinet<T> // T:trinh, type, có thể là Student, Lecturer - loose coupling
    {
        private T[] _arr;
        private int _count = 0;

        public Cabinet(int size)
        {
            if(size < 1)
                throw new ArgumentOutOfRangeException("INVALID SIZE. SIZE MUST BE <= 1!!");
            _arr = new T[size];
        }

        public void AddItem(T obj) // Student object, Lecturer obj, Pet obj 
        {
            // add vào vị trí thứ [i] = giá trị nào đó, vùng new nào đó
            if (_count == _arr.Length)
            {
                Console.WriteLine("THE LIST IS FULL, NO MORE SPACE TO ADD ITEMS !!");
                return;
            }
            _arr[_count++] = obj;
        }

        public void PrintList()
        {
            if (_count == 0)
            {
                Console.WriteLine("THERE IS NO ITEMS IN THE LIST, PLEASE ADD AN ITEM FIRST!!");
                return;
            }
            Console.WriteLine($"THE IS/ARE {_count} ITEM(S) IN THE LIST := ");
            for (int i = 0; i < _count; i++)
                Console.WriteLine(_arr[i].ToString());
            // cấm tuyệt đối for đến length, vì phần con lại bằng null
        }



    }
}
