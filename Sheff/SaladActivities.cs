namespace Sheff
{
    public static class SaladActivities
    {
        public static void PrepareSalad(ISaladIngredient[] ing)
        {
            int mainIngredientsCounter = 0;

            foreach (var i in ing)
            {
                if (i is IMainIngredient)
                {
                    mainIngredientsCounter++;
                }
            }

            if (mainIngredientsCounter < 2)
            {
                Console.WriteLine("You cant prepare a salad without at least two main ingredients with only this:");
                foreach (var j in ing)
                {
                    Console.WriteLine(((Ingredient)j).Name);
                }

                return;
            }

            Console.WriteLine("Your salad is ready. It is made of: ");
            foreach (var j in ing)
            {
                Console.WriteLine(((Ingredient)j).Name);
            }
        }

        public static int CountCalories(Ingredient[] ing)
        {
            Array.Sort(ing, new CaloriesComparer());
            int accumulator = 0;
            Console.WriteLine("This is the table of ingredients added and calories they have in ascending order");
            for (int i = 0; i < ing.Length; i++)
            {
                Console.WriteLine(ing[i].Calories);
                accumulator += ing[i].Calories;
            }

            return accumulator;
        }

        public static void SearchForOil(this Ingredient[] oil)
        {
            foreach (var i in oil)
            {
                if (i is IOil)
                {
                    if (i is TunaOil)
                    {
                        Console.WriteLine($"{i.Name} is a special oil");
                        continue;
                    }

                    Console.WriteLine($"{i.Name} is oil");
                }
            }
        }
    }
}
