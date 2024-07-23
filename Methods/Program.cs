
static void Main()
{
    Matematik matematik = new Matematik();
    int sonuc = matematik.Topla(2,3);
}


class Matematik
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;

    }
    

}