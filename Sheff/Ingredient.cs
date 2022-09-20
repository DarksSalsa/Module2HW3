namespace Sheff
{
    public abstract class Ingredient : EdibleProduct, ISaladIngredient
    {
        private readonly int _calories = Random.Shared.Next(1, 500);

        public Ingredient(string name)
            : base(name)
        {
        }

        public int Calories
        {
            get { return _calories; }
        }

        public void CanBeAddedIntoSalad()
        {
            System.Console.WriteLine("I am a potential part of a future salad!");
        }
    }
}
