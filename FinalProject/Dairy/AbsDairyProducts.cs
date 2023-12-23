using System.Text.Json.Serialization;
using System.Text.Json;
using Serilog;
using FinalProject.Meat;

namespace FinalProject.Dairy
{
    internal abstract class AbsDairyProducts:IProduct
    {
        public int Quantity { get; private set; }
        public double Fatness { get; }
        public int Cost { get; }
        public int Article { get; }
        public string Name { get; }
        public int? Weight { get; }
        public int? Volume { get; }
        public DateTime ManufacturedDate { get; } = DateTime.Now;

        static AbsDairyProducts()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt")
                .CreateLogger();
        }

        protected AbsDairyProducts(
            string name,
            double fatness,
            int quantity,
            int cost,
            int article,
            int? weight,
            int? volume)
        {
            Name = name;
            Fatness = fatness;
            Quantity = quantity;
            Cost = cost;
            Article = article;
            Weight = weight;
            Volume = volume;

            Log.Information($"Created {nameof(AbsDairyProducts)}: {Name}, Article: {Article}");
        }

        public override string ToString()
        {
            if (Volume is null)
            {
                return $"Name: {Name}\n" +
                       $"Fatness: {Fatness}\n" +
                       $"Quantity: {Quantity}\n" +
                       $"Cost: {Cost}\n" +
                       $"Article: {Article}\n" +
                       $"Weight: {Weight}";
            }
            else if (Weight is null)
            {
                return $"Name: {Name}\n" +
                       $"Fatness: {Fatness}\n" +
                       $"Quantity: {Quantity}\n" +
                       $"Cost: {Cost}\n" +
                       $"Article: {Article}\n" +
                       $"Volume: {Volume}";
            }

            return $"Name: {Name}\n" +
                   $"Fatness: {Fatness}\n" +
                   $"Quantity: {Quantity}\n" +
                   $"Cost: {Cost}\n" +
                   $"Article: {Article}\n" +
                   $"Weight: {Weight}";
        }

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
        }

        protected static readonly JsonSerializerOptions writeOptions = new()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
}
