namespace Sheff
{
    public class CaloriesComparer : IComparer<Ingredient>
    {
        public int Compare(Ingredient? ing1, Ingredient? ing2)
        {
            if (ing1 == null || ing2 == null)
            {
                throw new ArgumentException("One of the ingredients is not correct");
            }

            return ing1.Calories - ing2.Calories;
        }
    }
}
