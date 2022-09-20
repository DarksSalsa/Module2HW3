namespace Sheff
{
    public class Tuna : Natural, IMainIngredient
    {
        public Tuna(string name)
            : base(name)
        {
        }

        public void MainIngredient()
        {
            Console.WriteLine($"This {Name} is a main ingredient!");
        }

        public sealed override void Origin()
        {
            base.Origin();
            Console.WriteLine("It was fished out of a sea!");
        }

        public void SmellsLike()
        {
            Console.WriteLine("It smells like tuna!");
        }
    }
}
