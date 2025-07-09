using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Human
    {
        public string Name { get; private set; }
        public int Age { get; protected set; }
        public string Gender { get; private set; }

        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, int age): this(name)
        {
            Age = age;
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

    }
}
