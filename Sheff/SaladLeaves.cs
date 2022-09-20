namespace Sheff
{
    public class SaladLeaves : Natural, IMainIngredient
    {
        public SaladLeaves(string name)
            : base(name)
        {
        }

        public void MainIngredient()
        {
            Console.WriteLine($"This {Name} is a main ingredient!");
        }

        public override void Origin()
        {
            base.Origin();
            Console.WriteLine("It was grown using hydrophonic method!");
        }
    }
}
