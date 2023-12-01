using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Task_8
{
    enum Department
    {
        It = 1,
        Education,
        Financial
    }
    class Staff(string name, Department department, int salary)
        :Person(name)
    {
        public Department Department { get; private set; } = department;

        public int Salary { get; private set; } = salary;

        public static void ChangeDepartment(Staff staff, Department newDepartment)
        {
            staff.Department = newDepartment;
        }
        public override string ToString()
        {
            return $"{Name} {Department} {Salary}";
        }
    }
}