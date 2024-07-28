using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product() {ProductName="Laptop", UnitPrice= 2500, UnitsInStock=100 };

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);

    }

    

}

