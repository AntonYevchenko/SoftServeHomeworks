/*Enter a sequence of positive integers (to the first negative). Calculate the arithmetic average of the entered positive numbers. //1,6,3,9,-8 -> (1+6+3+9)/4*/

namespace SoftServeHomeWorks
{
    internal class Task_3
    {
        public static void Main(string[] args)
        {
            int positiveCount = 0;

            int accamulate = 0;

            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput < 0)
                    break;

                else
                {
                    positiveCount++;
                    accamulate += userInput;
                }
            }
            Console.WriteLine((double) accamulate / positiveCount);



            var accamulate2 = new List<int>();

            while (true)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < 0)
                    break;
                else 
                    accamulate2.Add(input);
            }
            Console.WriteLine((double) accamulate2.Sum() / accamulate2.Count);
        }
    }
}
