namespace Sheff
{
    public class Salt : Artificial
    {
        private readonly string _matterState = "Solid";
        private readonly Type _type;

        public Salt(string name, Type typeOfSalt)
           : base(name)
        {
            _type = typeOfSalt;
        }

        public enum Type
        {
            SeaSalt,
            NaCl,
            KCl,
        }

        public Type TypeOfSalt
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
    }
}
