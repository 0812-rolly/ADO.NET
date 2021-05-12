using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2v
{
    class Student: Man
    {
        private int year;
        private int course;
        private int gr_num;

        public Student(string name, int age, int weight, int height,
            int year, int course, int gr_num) : base(name, age, weight, height)
        {
            this.year = year;
            this.course = course;
            this.gr_num = gr_num;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        public int Course
        {
            get => course;
            set => course = value;
        }

        public int GroupNum
        {
            get => gr_num;
            set => gr_num = value;
        }

        public override string ToString()
        {
            string result = "Имя: " + Name + '\n';
            result += "Возраст: " + Age + '\n';
            result += "Вес: " + Weight + '\n';
            result += "Рост: " + Height + '\n';
            result += "Год поступления: " + Year + '\n';
            result += "Курс: " + Course + '\n';
            result += "Номер группы: " + GroupNum + '\n';
            return result;
        }
    }
}
