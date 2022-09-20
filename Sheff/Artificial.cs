namespace Sheff
{
    public abstract class Artificial : Ingredient
    {
        private readonly string? _matterState;

        public Artificial(string name)
            : base(name)
        {
        }

        public abstract string GetState();
    }
}
