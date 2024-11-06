using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pasirinkite darbuotojo tipą (PilnasEtatas arba PusėEtato): ");
        string tipoPasirinkimas = Console.ReadLine();

        Console.Write("Įveskite darbuotojo vardą: ");
        string vardas = Console.ReadLine();

        Console.Write("Įveskite darbuotojo atlyginimą: ");
        decimal atlyginimas;
        while (!decimal.TryParse(Console.ReadLine(), out atlyginimas))
        {
            Console.Write("Įveskite galiojantį atlyginimą: ");
        }

      
        Darbuotojas darbuotojas = null;

        if (tipoPasirinkimas.Equals("PilnasEtatas", StringComparison.OrdinalIgnoreCase))
        {
            darbuotojas = new PilnasEtatas(vardas, atlyginimas);
        }
        else if (tipoPasirinkimas.Equals("PusėEtato", StringComparison.OrdinalIgnoreCase))
        {
            darbuotojas = new PusėEtato(vardas, atlyginimas);
        }
        else
        {
            Console.WriteLine("Neteisingas darbuotojo tipas.");
            return;
        }

      
        if (darbuotojas is PilnasEtatas pilnasEtatas)
        {
            Console.WriteLine($"{pilnasEtatas.Vardas} metinis atlyginimas: {pilnasEtatas.GautiMetinįAtlyginimą()}");
        }
        else if (darbuotojas is PusėEtato puseEtato)
        {
            Console.WriteLine($"{puseEtato.Vardas} valandinis atlyginimas: {puseEtato.GautiValandinįAtlyginimą():F2}");
        }
    }
}
