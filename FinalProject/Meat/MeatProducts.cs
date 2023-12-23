using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinalProject.Meat
{

    public class Sausage(
        string name,
        int quantity,
        int cost,
        Sort sort,
        int article,        
        int weight,
        List<MeatComposition> meatComposition,
        MeatProcessingType processingType)
                :AbsMeatProduct(
                        name,
                        quantity,
                        cost,
                        sort,
                        article,                       
                        weight,
                        meatComposition,
                        processingType)
    {


        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Sausage? DeSerialize(string json) => JsonSerializer.Deserialize<Sausage>(json);
    }
    internal class Sausages(
        string name,
        int quantity,
        int cost,
        Sort sort,
        int article,
        int daysToExpiration,
        int weight,
        List<MeatComposition> meatComposition,
        MeatProcessingType processingType)
                :AbsMeatProduct(
                        name,
                        quantity,
                        cost,
                        sort,
                        article,                        
                        weight,
                        meatComposition,
                        processingType)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Sausages? DeSerialize(string json) => JsonSerializer.Deserialize<Sausages>(json);
    }

    internal class Ham(
        string name,
        int quantity,
        int cost,
        int article,
        int daysToExpiration,
        int weight,
        MeatProcessingType processingType)
                :AbsMeatProduct(
                        name,
                        quantity,
                        cost,
                        Sort.HigherGrade,
                        article,                        
                        weight,
                        GetPorkMeatComposition(),
                        processingType)
    {
        private static List<MeatComposition> GetPorkMeatComposition()
        {
            var porkMeat = new List<MeatComposition>()
                {
                    new() {Type = MeatType.Pork, Percentage = 100}
                };
            return porkMeat;
        }

        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Sausage? DeSerialize(string json) => JsonSerializer.Deserialize<Sausage>(json);
    }
}


