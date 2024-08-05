using System.Net.Http.Headers;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();

            Console.WriteLine(matematik.Bol(20, 0));

        }
    }

    public class Matematik()
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public decimal Bol(int sayi1, int sayi2)
        {
            try
            {
                return sayi1 / sayi2;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Catch çalıştı. Bir Hata oluştu");
                throw new DivideByZeroException("Payda sıfır olamaz.");
            }
            catch(DllNotFoundException)
            {
                Console.WriteLine("Dll not found");
                throw new DivideByZeroException();
            }
            catch(Exception exception)
            {
                Console.WriteLine("Catch çalıştı. Bir Hata oluştu");
                Console.WriteLine(exception.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally çalıştı");
            }
            
        }
    }
}
