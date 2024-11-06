using System;

public class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Įveskite knygos pavadinimą: ");
        string pavadinimas = Console.ReadLine();

        
        Console.Write("Įveskite knygos puslapių skaičių: ");
        int puslapiuSkaicius;
        while (!int.TryParse(Console.ReadLine(), out puslapiuSkaicius) || puslapiuSkaicius < 0)
        {
            Console.Write("Įveskite teisingą puslapių skaičių (teigiamas sveikasis skaičius): ");
        }

       
        Knyga knyga = new Knyga(pavadinimas, puslapiuSkaicius);

       
        string klasifikacija = knyga.KlasifikuotiKnyga();
        Console.WriteLine(klasifikacija);
    }
}
