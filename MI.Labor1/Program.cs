using MI.Labor1.Models;

List<Bottle> palackok = new List<Bottle>();

Console.Write("Hany palackot szeretne, felvenni?");
int darab = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < darab; i++)
{
    //Megadjuk a palack nevet,anyagat,kapacitas,mennyiseg
    Console.Write("Palack neve: ");
    string name = Console.ReadLine();

    Console.Write("Palack anyaga: ");
    string material = Console.ReadLine();

    Console.Write("Palack kapacitasa: ");
    double capacity = Convert.ToDouble(Console.ReadLine());

    Console.Write("Palack mennyiseg: ");
    double currentVolume = Convert.ToDouble(Console.ReadLine());

    Bottle ujpalack = new Bottle(name, material, capacity, currentVolume);
    palackok.Add(ujpalack);
}

Console.WriteLine();
Console.WriteLine("Felvett palackok:");

foreach (Bottle palack in palackok)
{
    palack.DisplayInfo();
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Palackok berakása a teherautóba:");

Truck truck1 = new Truck(10.0);
foreach(Bottle palack in palackok)
{
    truck1.AddBottle(palack);
}
