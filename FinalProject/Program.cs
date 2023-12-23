using FinalProject.Dairy;
using FinalProject.Meat;

namespace FinalProject
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var sausage = new Sausage(name: "Chorizo",
                                      quantity: 200,
                                      cost: 300,
                                      sort: Sort.HigherGrade,
                                      article: 17546,
                                      weight: 500,
                                      meatComposition: [new()
                                      {
                                          Type = MeatType.Pork,
                                          Percentage = 30
                                      },
                                          new()
                                          {
                                              Type = MeatType.Beef,
                                              Percentage = 30
                                          }],
                                          processingType: MeatProcessingType.Dried);
            string str = sausage.Serialize();
            Console.WriteLine(str);

            var sausageDeserialased = Sausage.DeSerialize(str);

            var milk = new Milk(name: "Korivka",
                                fatness: 2.5,
                                quantity: 100,
                                cost: 47,
                                article: 45784,
                                volume: 870,
                                870);

            string str2 = milk.Serialize();
            Console.WriteLine(str2);

            var milkDeserialased = Milk.DeSerialize(str2);

            var iceCream = new IceCream(name: "Gran-Pri",
                                fatness: 2.5,
                                quantity: 100,
                                cost: 47,
                                article: 94524,                                
                                870);

            string str3 = iceCream.Serialize();
            Console.WriteLine(str2);

            var iceCreamDeserialased = Sausage.DeSerialize(str2);            

            var list = new List<IProduct>()
            {
                sausage,
                milk,
                iceCream
            };

            var sortedList = list.OrderBy(x => x.Article).ToList();

            Console.WriteLine();

            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Article); 
            }
        }
    }
}
