namespace LastTraining
{
    internal class Custard : Food
    {
        public const int productPrice = 150;
        public Custard(string name, Size size) : base(name, productPrice, size, (int)size)
        {
        }
    }
}
