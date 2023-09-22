using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    public class Student
    {
        private int stt;
        private string id;
        private string fullname;
        private string khoa;
        private float diem;

        public int Stt { get => stt; set => stt = value; }
        public string Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public float Diem { get => diem; set => diem = value; }
        
    }
}
