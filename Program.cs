// Grundamne.cs

using System;
namespace IDP_ASSG_3;

public class Grundämne
{
    public string Namn { get; set; }
    public int Z { get; set; }
    public string Typ { get; set; }
    public double Smältpunkt { get; set; } // Kelvin
    public double Kokpunkt { get; set; } // Kelvin

    public Grundämne(string namn, int z, string typ, double smältpunkt, double kokpunkt)
    {
        Namn = namn;
        Z = z;
        Typ = typ;
        Smältpunkt = smältpunkt;
        Kokpunkt = kokpunkt;
    }

    public void Print()
    {
        Console.WriteLine($"Namn: {Namn}");
        Console.WriteLine($"Z: {Z}");
        Console.WriteLine($"Typ: {Typ}");
        Console.WriteLine($"Smältpunkt: {Smältpunkt} K");
        Console.WriteLine($"Kokpunkt: {Kokpunkt} K");
    }
}

class Program
{
    static void Main()
    {
        Grundämne syre = new Grundämne("Syre", 8, "Icke-metal", 54.36, 90.188);
        Grundämne järn = new Grundämne("Järn", 26, "Metal", 1811, 3134);
        Grundämne guld = new Grundämne("Guld", 79, "Metal", 1337.33, 3243);

       
    }
}