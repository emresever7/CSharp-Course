using System.Net.Http.Headers;

namespace AsyncDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread başladı. {Thread.CurrentThread.ManagedThreadId}");

            Task task1 = Task.Run(Process1);
            Task task2 = Task.Run(Process2);

            Task<int> task3 = Task.Run(Calculate);
            Console.WriteLine($"İşlem sonucunda dönen sayı {task3.Result}");

            Task<List<Product>> task = Task.Run(GetAll);

            foreach (var product in task.Result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("Console bitti");
            Console.ReadKey();
        }

        static void Process1()
        {
            Console.WriteLine($"Process 1 Threaad başladı. {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Process2()
        {
            Console.WriteLine($"Process 2 Threaad başladı. {Thread.CurrentThread.ManagedThreadId}");
        }

        static int Calculate()
        {
            return 10;
        }

        static List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{ProductId =1, ProductName="Laptop 1"},
                new Product{ProductId=2, ProductName ="Laptop 2"}
            };
        }

        class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
        }
    }
}
