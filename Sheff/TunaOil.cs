namespace Sheff
{
    public class TunaOil : Tuna, IOil
    {
        public TunaOil(string name)
            : base(name)
        {
        }

        public void MixingAbility()
        {
            Console.WriteLine("This would mix with other oil.");
        }
    }
}
