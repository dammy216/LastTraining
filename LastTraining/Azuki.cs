namespace LastTraining
{
    internal class Azuki : Food
    {
        public const int productPrice = 130;
        public Azuki(string name, Size size) : base(name, productPrice, size, (int)size)
        {
        }

    }
}
