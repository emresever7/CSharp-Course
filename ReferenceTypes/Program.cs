namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            Product product = new Product();

            product.UnitPrice = 500;
            Console.WriteLine(product.UnitPrice);
        }
    }

    class Product
    {
        decimal _unitPrice;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { 
            get { return _unitPrice + _unitPrice * 18/100; } 
            set { _unitPrice = value; } 
        }
    }
}
