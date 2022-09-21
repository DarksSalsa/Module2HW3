namespace Sheff
{
    public class Natural : Ingredient
    {
        public Natural(string name)
            : base(name)
        {
        }

        public virtual void Origin()
        {
            System.Console.WriteLine("This was made of living organisms.");
        }
    }
}
