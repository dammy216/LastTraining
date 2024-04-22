namespace LastTraining
{
    internal class Kuri : Food
    {
        public const int productPrice = 200;
        public Kuri(string name, Size size) : base(name, productPrice, size, (int)size)
        {
        }
    }
}
