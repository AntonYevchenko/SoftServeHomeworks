using System.Text.Json;

namespace FinalProject.Dairy
{
    internal class Butter(
        string name,
        double fatness,
        int quantity,
        int cost,
        int article,
        int? weight)
                :AbsDairyProducts(
                        name,
                        fatness,
                        quantity,
                        cost,
                        article,
                        weight,
                        null)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Butter? DeSerialize(string json) => JsonSerializer.Deserialize<Butter>(json);
    }
    internal class Cheese(
        string name,
        double fatness,
        int quantity,
        int cost,
        int article,
        int? weight)
                :AbsDairyProducts(
                        name,
                        fatness,
                        quantity,
                        cost,
                        article,
                        weight,
                        null)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Cheese? DeSerialize(string json) => JsonSerializer.Deserialize<Cheese>(json);
    }
    internal class IceCream(
        string name,
        double fatness,
        int quantity,
        int cost,
        int article,
        int? weight)
                :AbsDairyProducts(name,
                        fatness,
                        quantity,
                        cost,
                        article,
                        weight,
                        null)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static IceCream? DeSerialize(string json) => JsonSerializer.Deserialize<IceCream>(json);
    }
    internal class Cream(
        string name,
        double fatness,
        int quantity,
        int cost,
        int article,
        int? weight,
        int? volume = null)
                :AbsDairyProducts(name,
                        fatness,
                        quantity,
                        cost,
                        article,
                        weight,
                        volume)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Cream? DeSerialize(string json) => JsonSerializer.Deserialize<Cream>(json);
    }
}
