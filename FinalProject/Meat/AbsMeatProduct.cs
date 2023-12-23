using System.Text.Json.Serialization;
using System.Text.Json;
using Serilog;
using Serilog.Sinks.File;

namespace FinalProject.Meat
{
    public enum MeatType
    {
        Chicken,
        Beef,
        Pork,
        Turkey,
        Veal,
        Fat,
        MeatByProducts,
        Other
    }
    public enum Sort
    {
        HigherGrade,
        FirstGrade
    }
    public enum MeatProcessingType
    {
        Raw,
        Smoked,
        RawSmoked,
        Dried,
        RawDried
    }
    public struct MeatComposition
    {
        public MeatType Type { get; set; }
        public int Percentage { get; set; }
    }
    public abstract class AbsMeatProduct:IProduct
    {
        public Sort Sort { get; }
        public int Quantity { get; private set; }
        public int Cost { get; private set; }
        public int Article { get; }
        public string Name { get; }
        public int Weight { get; }

        public List<MeatComposition> MeatComposition { get; }
        public MeatProcessingType ProcessingType { get; }
        public DateTime ManufacturedDate { get; } = DateTime.Now;

        static AbsMeatProduct()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt")
                .CreateLogger();
        }

        protected AbsMeatProduct(
            string name,
            int quantity,
            int cost,
            Sort sort,
            int article,
            int weight,
            List<MeatComposition> meatComposition,
            MeatProcessingType processingType)
        {
            Name = name;
            Quantity = quantity;
            Cost = cost;
            Sort = sort;
            Article = article;
            Weight = weight;
            MeatComposition = meatComposition;
            ProcessingType = processingType;

            Log.Information($"Created {nameof(AbsMeatProduct)}: {Name}, Article: {Article}");
        }


        protected static readonly JsonSerializerOptions writeOptions = new()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };


       

        public void IncreaseQuantity()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Quantity: {Quantity}. Enter the arrival of the goods");

                    int newArrival = int.Parse(Console.ReadLine());

                    if (newArrival > 1)
                    {
                        Quantity += newArrival;
                        Log.Information($"Increased quantity of {Name} by {newArrival}. New quantity: {Quantity}");
                        break;
                    }
                    else
                        Console.WriteLine("You have entered a zero quantity or less!\n" +
                                          "Please enter a number greater than zero");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You have entered an invalid character!\n" +
                                      "Please enter a number greater than zero");

                    Log.Error(ex, "You have entered an invalid character!\n" +
                                  "Please enter a number greater than zero");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Unexpected exception");
                    Log.Error(ex, "Unexpected exception");
                }
            }
        }

        public void IncreaseQuantity(int newArrival)
        {
            while (true)
            {
                try
                {               

                    if (newArrival > 1)
                    {
                        Quantity += newArrival;
                        Log.Information($"Increased quantity of {Name} by {newArrival}. New quantity: {Quantity}");
                        break;
                    }
                    else
                        Console.WriteLine("You have entered a zero quantity or less!\n" +
                                          "Please enter a number greater than zero");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You have entered an invalid character!\n" +
                                      "Please enter a number greater than zero");

                    Log.Error(ex, "You have entered an invalid character!\n" +
                                  "Please enter a number greater than zero");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Unexpected exception");
                    Log.Error(ex, "Unexpected exception");
                }
            }
        }

        public void DecreaseQuantity()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Quantity: {Quantity}. Enter quantity of goods to be written off");

                    int decreaseQuantity = int.Parse(Console.ReadLine());

                    if (decreaseQuantity > 1 && Quantity - decreaseQuantity > -1)
                    {
                        Quantity -= decreaseQuantity;
                        Log.Information($"Decreased quantity of {Name} by {decreaseQuantity}. New quantity: {Quantity}");
                        break;
                    }
                    else
                        Console.WriteLine("You have entered a zero quantity or less, or the remaining goods are not enough for the transaction!\n" +
                                          "Please enter a number greater than zero");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You have entered an invalid character!\n" +
                                      "Please enter a number greater than zero");

                    Log.Error(ex, "You have entered an invalid character!\n" +
                                  "Please enter a number greater than zero");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Unexpected exception");
                    Log.Error(ex, "Unexpected exception");
                }
            }
        }public void DecreaseQuantity(int decreaseQuantity)
        {
            while (true)
            {
                try
                {                    

                    if (decreaseQuantity > 1 && Quantity - decreaseQuantity > -1)
                    {
                        Quantity -= decreaseQuantity;
                        Log.Information($"Decreased quantity of {Name} by {decreaseQuantity}. New quantity: {Quantity}");
                        break;
                    }
                    else
                        Console.WriteLine("You have entered a zero quantity or less, or the remaining goods are not enough for the transaction!\n" +
                                          "Please enter a number greater than zero");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You have entered an invalid character!\n" +
                                      "Please enter a number greater than zero");

                    Log.Error(ex, "You have entered an invalid character!\n" +
                                  "Please enter a number greater than zero");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Unexpected exception");
                    Log.Error(ex, "Unexpected exception");
                }
            }
        }

    }
}
