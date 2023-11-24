namespace Lessons
{
    public class Program
    {
        static int[] GenerateGrowingArrayWithInputValidation()
        {
            ReadRangeWithHandlings(out int start, out int end);

            int[] result = new int[end - start + 1];

            int check = start;

            int countPlaces = result.Length - 2;

            for (int i = 1; i < result.Length - 1; i++)
            {
                result[0] = start;

                result[^1] = end;

                while (true)
                {
                    try
                    {
                        Console.Write($"Введи число більше за {check}: ");

                        int temp = int.Parse(Console.ReadLine());

                        if (end - temp < countPlaces)
                        {
                            Console.WriteLine("Завелике число, невистачає ячейок для наступного введення!");
                            continue;
                        }
                        else
                            --countPlaces;

                        if (temp <= check)
                        {
                            Console.WriteLine($"\nВведене число менше або дорівнює: {check}");
                            ++countPlaces;
                            continue;
                        }
                        if (temp >= end)
                        {
                            Console.WriteLine($"\nВведене число, більше або дорівнює: {end}");
                            ++countPlaces;
                            continue;
                        }
                        check = temp;
                        result[i] = temp;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ти не правий! Введи число!");
                        continue;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ти не правий! Введи число!");
                        continue;
                    }
                    break;
                }
            }
            return result;
        }

        private static void ReadRangeWithHandlings(out int start, out int end)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введіть перше число діапазону: ");

                    start = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("\nВвели не число, або зайві символи! Повторіть ввід");
                    continue;
                }
                break;
            }

            while (true)
            {
                try
                {
                    Console.Write("\nВведіть останнє число діапазону, має бути більше за перше!: ");

                    end = 0;
                    end = int.Parse(Console.ReadLine());

                    if (end <= start)
                    {
                        Console.WriteLine("\nДруге число має бути більше першого!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ввели не число, або зайві символи! Повторіть ввід");
                    continue;
                }
                break;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = GenerateGrowingArrayWithInputValidation();

            for (int i = 0; i < arr.Length; i++)
            {
                int item = arr[i];
                Console.WriteLine($"Ячейка масиву {i} = {item}");
            }
        }

    }
}


