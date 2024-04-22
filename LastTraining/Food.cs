namespace LastTraining
{
    public class Food
    {
        public string Name;
        public int ProductPrice;
        public Size ProductSize;
        public int SizePrice;
        public int TotalPrice;

        public Food(string name, int productPrice, Size size, int sizePrice)
        {
            Name = name;
            this.ProductPrice = productPrice;
            ProductSize = size;
            this.SizePrice = sizePrice;
            this.TotalPrice = productPrice + sizePrice;
        }
    }
}
