/*Create class Cat. The cat should have a property "fullness level" and method "eat something". Create enum Food (fish, mouse, ...). Each type of food should change the level of satiety differently.*/

namespace SoftServeHomeWorks
{
    internal class ADDITIONAL_TASKS
    {
        public enum Food
        {
            Fish = 1,
            Mouse,
            StolenMeat,
            Candy = -2
        }
        private class Cat
        {
            public int FullnessLevel { get; private set; } = 0;

            public void EatSomething(Food food) =>
                FullnessLevel += (int) food;
        }
        public static void Main(string[] args)
        {
            var food = Food.Mouse;
            var cat = new Cat();
            cat.EatSomething(food);
            Console.WriteLine(cat.FullnessLevel);
        }
    }
}
