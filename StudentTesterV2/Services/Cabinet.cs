using StudentTesterV3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //T: trinh, type: lần đầu tiền trái thanh long có trong mỳ tôm
    //               : lần đầu tiên ta còn chưa biết datatype nào, ta sẽ chơi với datatype là tham số
    // value là tham số F(int x)
    // data type là tham số F(T x)
    // xài sao???;
    //Cabinet<Student> tuSE = new Cabinet<Student>();
    //Cabinet<Lecturer> tuGVSE = new();
    
    public class Cabinet<T> where T : IIdentifiable
    {
        //private Lecturer[] _arr;
        private T[] _arr;
        // T có thể là student, lecture...

        private int _count = 0;

        public Cabinet(int size) 
        {
            if (size < 1)
                _arr = new T[69];
            else
                _arr = new T[size];
        }

        public void Add(string id, string name, int yob, double gpa)
        {
            if (_count < _arr.Length)
                _arr[_count++] = item;
            else
                Console.WriteLine("Cabinet is full, cannot add more items.");
        }

        public void PrintLList()
        {
            Console.WriteLine($"There is/are {_count} object in the list:");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        public int? FindObjectByID(string id)
        {
            if (_count == 0)
                return null;

            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id == id)
                    return i;
            }

            return null;
        }

        public void UpdateObjectByID(string id, string? newName, int? newYob, double? newGpa )
        {
            int? pos = FindObjectByID(id);
            if (pos != null)
            {
                if (newName != null)
                    _arr[(int)pos].Name = newName;
                if (newYob != null)
                    _arr[(int)pos].Yob = (int)newYob;
                if (newGpa != null)
                    _arr[(int)pos].Gpa = (int)newGpa;
            }

        }

        public void DeleteObjectByID(string id) {
            int? pos = FindObjectByID(id);
            if (pos != null)
            {
                for (int i = (int)pos; i < _count; i++)
                    _arr[i] = _arr[i + 1];
                _count--;
            }
        }
    }
}
// BTVN số 3: hoàn tất nốt class này và code main() thử nghiệm 