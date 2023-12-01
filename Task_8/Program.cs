using Task_8;

internal class Program
{
    private static void Main(string[] args)
    {
        var people = new List<Person>()
        {
            new("Bobby"),
            new("Alice"),
            new Teacher("John", Subject.Math, 500),
            new Teacher("Anna", Subject.English,700),

            new Student("Garry", GroupNumber.Group3),
            new Student("Lola", GroupNumber.Group1),

            new Developer("Bob", DeveloperLevel.Junior, 1000),
            new Developer("Eva", DeveloperLevel.Senior, 5000)
        };

        foreach (var human in people)
        {
            Console.WriteLine(human.Print());
        }

        FoundAndPrint(people);

        SaveSortedByNameInFile(people);

        var employees = new List<Staff>();

        foreach (var person in people)
        {
            if (person is Staff staff)
            {
                employees.Add(staff);
            }
        }
        employees = [.. employees.OrderBy(x => x.Salary)];

        static void FoundAndPrint(List<Person> people)
        {
            Console.WriteLine("Enter the name of the person you are looking for");

            string parsePersonName = Console.ReadLine();

            Console.WriteLine();

            bool foundPerson = false;

            foreach (var item in people)
            {
                if (item.Name.ToLower() == parsePersonName.ToLower())
                {
                    Console.WriteLine($"Found this information about person: {parsePersonName}");
                    Console.WriteLine(item.Print());
                    foundPerson = true;
                }
            }
            if (!foundPerson)
            {
                Console.WriteLine($"Don't found any information about this person: {parsePersonName}");
            }
        }

        static void SaveSortedByNameInFile(List<Person> people)
        {
            using (var sw = new StreamWriter("SortedListOfPersons.txt"))
            {
                people.OrderBy(p => p.Name)
                      .ToList()
                      .ForEach(p => sw.WriteLine(p.Print()));
            }
        }
    }
}