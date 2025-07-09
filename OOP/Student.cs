using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student : Human, IStudent 
    {
        public required TypeOfStudy TypeOfStudy { get; init; }
        public int StudyLvl { get; private set; }

        public Student(string name, int age):base(name, age)
        {
        }
        public Student(string name, TypeOfStudy typeOfStudy):base(name)
        {
            TypeOfStudy = typeOfStudy;
        }
        public void PassExam()
        {
            if (StudyLvl >= 50)
            {
                Console.WriteLine("Вы перешли на следующий курс!!!");
                Age++;
            }
        }
        public void Study()
        {
            StudyLvl = new Random().Next(1, 100);
        }
       
    }
}
