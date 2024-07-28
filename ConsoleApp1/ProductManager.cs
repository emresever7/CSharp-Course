using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi: " + product.ProductName);
        }
    }
}
