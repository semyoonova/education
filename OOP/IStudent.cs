using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IStudent
    {
        void Study();
        public string Name { get; }
        public int Age { get; }
        public TypeOfStudy TypeOfStudy { get; init; }
        public int StudyLvl { get; }
    }
}
