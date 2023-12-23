using FinalProject.Meat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProject.Dairy
{
    internal class Milk(
        string name,
        double fatness,
        int quantity,
        int cost,
        int article,
        int? volume,
        int? weight = null)
                :AbsDairyProducts(
                        name,
                        fatness,
                        quantity,
                        cost,
                        article,
                        weight,
                        volume)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Milk? DeSerialize(string json) => JsonSerializer.Deserialize<Milk>(json);
    }
    internal class YogurtLiquid(
        string name,
        double fatness,
        int quantity,
        int cost,
        int article,
        int? volume,
        int? weight = null)
                :AbsDairyProducts(
                        name,
                        fatness,
                        quantity,
                        cost,
                        article,
                        weight,
                        volume)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static YogurtLiquid? DeSerialize(string json) => JsonSerializer.Deserialize<YogurtLiquid>(json);
    }
    internal class Kefir(
        string name,
        double fatness,
        int quantity,
        int cost,
        int article,
        int? volume,
        int? weight = null)
                :AbsDairyProducts(
                        name,
                        fatness,
                        quantity,
                        cost,
                        article,
                        weight,
                        volume)
    {
        public string Serialize() => JsonSerializer.Serialize(this, writeOptions);

        public static Kefir? DeSerialize(string json) => JsonSerializer.Deserialize<Kefir>(json);
    }



}
