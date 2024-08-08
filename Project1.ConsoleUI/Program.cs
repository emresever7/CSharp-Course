using Project1.Business;
using Project1.DataAccess;
using Project1.Entities;

namespace Project1.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var product in productManager.GetAllAsync().Result)
            {
                Console.WriteLine(product.ProductName);
            }

            //productManager.Add(new Product { ProductName = "Masa", CategoryId=1, QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });

            //Console.WriteLine(productManager.GetById(1).ProductName);

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //try
            //{
            //    productManager.Add(new Entities.Product { ProductId = 10, ProductName = "Masa", QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });

            //}
            //catch (DuplicateProductException exception)
            //{
            //    Console.WriteLine(exception.Message);

            //}


            //PersonnelManager personnelManager = new PersonnelManager(new EFPersonnelDal());
            //foreach (var personnel in personnelManager.GetAll())
            //{
            //    Console.WriteLine("{0} / {1} / {2}", personnel.Id, personnel.Name, personnel.Surname);
            //}

        }
    }
}
