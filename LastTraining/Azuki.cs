namespace LastTraining
{
    internal class Azuki : Food, IAnko
    {
        public const int productPrice = 130;
        public Azuki(string name, Size size, string anko) : base(name, productPrice, size, (int)size)
        {
            _anko = anko;
        }
        private string _anko;
        public string Anko { get { return _anko; } }
    }
}
