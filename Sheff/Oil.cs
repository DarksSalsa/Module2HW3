namespace Sheff
{
    public class Oil : Artificial, IOil, IMainIngredient
    {
        private readonly string _matterState = "Liquid";

        private readonly Type _type;

        public Oil(string name, Type typeOfOil)
           : base(name)
        {
            _type = typeOfOil;
        }

        public enum Type
        {
            SeasameOil,
            CoconutOil,
            OliveOil,
        }

        public Type TypeOfOil
        {
            get
            {
                return _type;
            }
        }

        public override string GetState()
        {
            return _matterState;
        }

        public void MainIngredient()
        {
            Console.WriteLine($"This {Name} is {TypeOfOil}, and it is a main ingredient!");
        }

        public void MixingAbility()
        {
            Console.WriteLine("This would not mix with water or other oil.");
        }
    }
}
