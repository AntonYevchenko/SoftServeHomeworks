using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Task_8
{
    public enum GroupNumber
    {
        Group1 = 1,
        Group2 = 2,
        Group3 = 3
    }
    class Student(string name, GroupNumber groupNumber)
          :Person(name)
    {
        public GroupNumber GroupNumber { get; } = groupNumber;

        public override string Print()
        {
            return $"Student name is: {Name}\n" +
                   $"Student`s group number is: {GroupNumber}\n";
        }
        public override string ToString()
        {
            return $"{Name} {GroupNumber}";
        }
    }
}