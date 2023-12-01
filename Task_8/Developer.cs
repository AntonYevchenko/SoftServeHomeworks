using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_8
{
    enum DeveloperLevel
    {
        Trainee = 0,
        Junior,
        Middle,
        Senior
    }
    class Developer(string name, DeveloperLevel level, int salary)
             :Staff(name, Department.It, salary)
    {
        public DeveloperLevel Level { get; private set; } = level;

        public static void UpLevelingDeveloper(Developer developer, DeveloperLevel newLevel)
        {
            if (developer.Level is < DeveloperLevel.Trainee
                                or > DeveloperLevel.Senior)
            {
                throw new Exception("Nonexistent skill level");
            }
            else if (newLevel == developer.Level)
            {
                throw new Exception("The new skill level is equal to the current one");
            }
            else
                developer.Level++;
        }

        public override string Print()
        {
            return $"Developer name is: {Name}\n" +
                   $"Developer {Name} level is: {Level}\n";
        }
        public override string ToString()
        {
            return $"{Name} {Department} {Level} {Salary}";
        }
    }
}