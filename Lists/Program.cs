

string[] cities = new string[] { "Ankara", "İzmir", "İstanbul" };

Console.WriteLine(cities.Length);

cities = new string[4];
cities[3] = "Bursa";

foreach (string city in cities)
{
    Console.WriteLine(city);
}

List<string> sehirler = new List<string>() { "Ankara", "İzmir", "İstanbul" };

Console.WriteLine(sehirler.Count);
sehirler.Add("Bursa");

foreach (string sehir in sehirler)
{
    Console.WriteLine(sehir);
}

sehirler.Add("Kastamonu");
sehirler.Add("Kocaeli");

Console.WriteLine("Yeni Liste");

foreach (string sehir in sehirler)
{
    Console.WriteLine(sehir);
}