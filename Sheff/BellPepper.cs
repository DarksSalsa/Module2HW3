namespace Sheff
{
    public class BellPepper : Natural
    {
        public BellPepper(string name)
            : base(name)
        {
        }

        public override void Origin()
        {
            base.Origin();
            Console.WriteLine("It was grown at a farm!");
        }
    }
}
