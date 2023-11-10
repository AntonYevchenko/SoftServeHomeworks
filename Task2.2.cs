//Enter double  number  and get the first 2 digits after the point of this number and output the sum of these numbers.
//For example: 3.456 -> 4+5=9

class Task
{
    public static void Main()
    {
        double input = double.Parse(Console.ReadLine());   

        string str = input.ToString().Split(',')[1];

        int result = (str[0] - '0') + (str[1] - '0');


        //Second variant
        result = input.ToString().Split(',')[1].Take(2).Sum(c => c - '0'); 

    }
}
