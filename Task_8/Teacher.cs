using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Task_8
{
    enum Subject
    {
        Math = 1,
        English,
        Law
    }
    class Teacher(string name, Subject subject, int salary)
           :Staff(name, Department.Education, salary)
    {
        Subject Subject { get; } = subject;

        public override string Print()
        {
            return $"Teacher name is: {Name}\n" +
                   $"Teacher {Name} subject is: {Subject}\n";
        }
        public override string ToString()
        {
            return $"{Name} {Department} {Salary}";
        }
    }
}