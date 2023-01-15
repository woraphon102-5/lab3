using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Student
    {
        public string name;
        public string id;
        public int birth;
        public string height;
        public double grade;
        public string major;


        public Student(string name,  string id, int birth, string height, double grade, string major)
        {

            this.name = name;
            this.id = id;
            this.birth = birth;
            this.height = height;
            this.grade = grade;
            this.major = major;

        }
        public string ชื่อ
        {
            get { return name; }
        }
        public string รหัสนักศึกษา
        {
            get { return this.id; }
        }
        public int ปีเกิด
        {
            get { return this.birth; }
        }
        public string ส่วนสูง
        {
            get { return this.height; }
        }
        public double GPA
        {
            get { return this.grade; }
        }
        public string สาขา
        {
            get { return this.major; }
        }
    }
}
