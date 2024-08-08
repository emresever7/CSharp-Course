using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataAccess
{
    public class ProductDal : IProductDal
    {
        List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName="Dell Laptop", QuantityPerUnit="32GB RAM", UnitPrice=10000, UnitsInStock=2},
                new Product{ProductId = 2, ProductName="Acer Laptop", QuantityPerUnit="32GB RAM", UnitPrice=10000, UnitsInStock=1},
                new Product{ProductId = 3, ProductName="HP Laptop", QuantityPerUnit="32GB RAM", UnitPrice=10000, UnitsInStock=0},
                new Product{ProductId = 4, ProductName="Mac Laptop", QuantityPerUnit="32GB RAM", UnitPrice=10000, UnitsInStock=7},
                new Product{ProductId = 5, ProductName="Asus Laptop", QuantityPerUnit="32GB RAM", UnitPrice=10000, UnitsInStock=12}
            };
        }

        public void Add(Product product)
        {
            throw new Exception("Veritabanına bağlanamadı. xxxx şifresi doğru değil.");
            Console.WriteLine("ADO.NET ile eklendi.");
        }

        public Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
