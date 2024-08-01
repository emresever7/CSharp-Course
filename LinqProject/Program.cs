namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1, ProductName="Acer Laptop", ProductDescription="24 GB Ram", UnitPrice=60000, UnitsInStock=5},
                new Product{ProductId=2,CategoryId=1, ProductName="Asus Laptop", ProductDescription="32 GB Ram", UnitPrice=30000, UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1, ProductName="HP Laptop", ProductDescription="64 GB Ram", UnitPrice=280000, UnitsInStock=35},
                new Product{ProductId=4,CategoryId=2, ProductName="Samsung Galaxy S25", ProductDescription="12 GB Ram", UnitPrice=50000, UnitsInStock=13},
                new Product{ProductId=5,CategoryId=2, ProductName="iPhone 16 Pro Max", ProductDescription="8 GB Ram", UnitPrice=60000, UnitsInStock=9},
            };

            //Test(products);

            //var result = products.Any(p => p.ProductName == "Acer Laptop");
            //Console.WriteLine(result);

            //Lambda Expression
            //var result = products.Find(p => p.ProductId == 2);
            //Console.WriteLine(result.ProductName);

            //var result = products.FindAll(p => p.ProductName.Contains("top")).OrderByDescending(p=>p.UnitPrice).ThenByDescending(p=>p.ProductName);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //var result = from p in products
            //             where p.UnitPrice>40000
            //             orderby p.UnitPrice, p.ProductName ascending
            //             select new ProductDto { ProductId = p.ProductId, ProductName=p.ProductName, UnitPrice=p.UnitPrice } ;

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>20000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice, };
            foreach(var productDto in result)
            {
                Console.WriteLine("{0} ---- {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("-----------------Algoritmik-----------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 30000 && product.UnitsInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("-----------------Linq-----------------");
            var result = products.Where(p => p.UnitPrice > 30000 && p.UnitsInStock > 5);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 30000 && product.UnitsInStock > 0)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products) 
        {
            return products.Where(p => p.UnitPrice > 30000 && p.UnitsInStock > 5).ToList();
        }
    }

    
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
