// See https://aka.ms/new-console-template for more information

// IF ELSE
//int num1 = 1;
//int num2 = 2;
//string result;

//if (num1 > num2)
//{
//    Console.WriteLine(num1 + " büyük");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine(num2 + " büyük");
//}

//result = (num1 > num2) ? "büyük" : "küçük";

//Console.WriteLine(result);

//Console.WriteLine("Hello, World!");


//string[] krediler = new string[7];


// ARRAYS
//int[] sayilar = new int[3];

//sayilar[0] = 5;
//sayilar[1] = 7;
//sayilar[2] = 2;

//Console.WriteLine("En büyük: " + sayilar[1]);
//Console.WriteLine("En küçük: " + sayilar[2]);
//Console.WriteLine("Ortanca: " + sayilar[0]);



int num1, num2;

int toplam1 = 0;
int toplam2 = 0;

Console.WriteLine("Birinci sayıyı giriniz: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz: ");
num2 = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i < num1; i++)
{
    if (num1 % i == 0)
    {
        toplam1 += i;
    }
}

for (int a = 1; a < num2; a++)
{
    if (num2 % a == 0)
    {
        toplam2 += a;
    }
}

if (toplam1 == num2 && toplam2 == num1)
{
    Console.WriteLine(num1 + " ve " + num2 + " arkadaş sayıdır.");
}

else
{
    Console.WriteLine(num1 + " ve " + num2 + " arkadaş sayı değildir.");
}

