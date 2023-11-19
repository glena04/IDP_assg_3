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

    // Parameterized constructor for initialization
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
        // Instansierat 3 grundämnen med deras data
        Grundämne syre = new Grundämne("Syre", 8, "Icke-metal", 54.36, 90.188);
        Grundämne järn = new Grundämne("Järn", 26, "metal", 1811, 3134);
        Grundämne guld = new Grundämne("Guld", 79, "metal", 1337.33, 3243);

        // Uttryck av Information om Grundämne
        Console.WriteLine("Information om Syre:");
        syre.Print();

        Console.WriteLine("\nInformation om Järn:");
        järn.Print();

        Console.WriteLine("\nInformation om Guld:");
        guld.Print();

        // Slut linjen
        Console.WriteLine("------------------------------------------------------------------------");

        // Skapa en array av 6 grundämnen
        Grundämne[] grundamnenArray = new Grundämne[6];

        // Tilldela värden till de första 3 elementen i arrayen
        grundamnenArray[0] = syre;
        grundamnenArray[1] = järn;
        grundamnenArray[2] = guld;

        // Direkt-tilldela de tre övriga indexen i arrayen
        grundamnenArray[3] = new Grundämne("väte", 1, "ickemetall", 13.99, 20.271);
        grundamnenArray[4] = new Grundämne("brom", 35, "ickemetall", 265.8, 332.0);
        grundamnenArray[5] = new Grundämne("kvicksilver", 80, "metal", 234.3210, 629.88);

        // Skriv ut grundämnena i arrayen
        foreach (var grundamne in grundamnenArray)
        {
            grundamne?.Print();
        }

        // Slut linjen
        Console.WriteLine("------------------------------------------------------------------------");

        // Skriv ut endast namnen på metaller
        Console.WriteLine("Metaller:");
        foreach (var grundämne in grundamnenArray)
        {
            if (grundämne?.Typ == "metal")
            {
                Console.WriteLine(grundämne.Namn);
            }
        }

        // Slut linjen
        Console.WriteLine("------------------------------------------------------------------------");


        // Skriv ut grundämnena med smältpunkt under 273.16 K och kokpunkt över 273.16 K
        Console.WriteLine("Grundämnen med smältpunkt under 273.16 K och kokpunkt över 273.16 K:");
        foreach (var grundamne in grundamnenArray)
        {
            if (grundamne?.Smältpunkt < 273.16 && grundamne?.Kokpunkt > 273.16)
            {
                grundamne?.Print();
            }
        }
    }
}