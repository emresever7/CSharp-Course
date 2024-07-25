namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add();
        }
    }

    class PersonManager
    {
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Güncellendi");
        }
    }

    class CustomerManager:PersonManager
    {
        public void GetBestCustomer()
        {

        }
    }

    class EmployeeManager:PersonManager
    {
        public void GetBestEmployee()
        {

        }
    }
}
