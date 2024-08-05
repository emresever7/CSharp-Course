namespace AsyncDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId}");

            //Process1();
            //System.Threading.Thread.Sleep(5000);
            //Process2();

            //Task task1 = new Task(Process1);
            //task1.Start();

            //Task task1 = Task.Factory.StartNew(Process1);

            //Task task1 = Task.Run(Process1);

            //Task task1 = Task.Run(() =>
            //{
            //    Process1();
            //    Process2();
            //});

            Task task1 = Task.Run(Process1);

            task1.Wait();
            
            Process2();
            Console.ReadKey();

        }

        static void Process1()
        {
            Console.WriteLine("1. işlem başladı.");
            Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Process2()
        {
            Console.WriteLine("2. işlem başladı.");
            Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        }
    }

}
