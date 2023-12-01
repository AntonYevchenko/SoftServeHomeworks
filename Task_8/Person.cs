using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }
        public virtual string Print()
        {
            return $"Person name is: {Name}\n";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
