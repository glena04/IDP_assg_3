// Grundamne.cs

using System;

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