using System;

public class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Įveskite studento vardą: ");
        string vardas = Console.ReadLine();

        
        Console.Write("Įveskite studento pažymį (nuo 1 iki 10): ");
        int pazymys;
        while (!int.TryParse(Console.ReadLine(), out pazymys) || pazymys < 1 || pazymys > 10)
        {
            Console.Write("Įveskite teisingą pažymį (nuo 1 iki 10): ");
        }

       
        Studentas studentas = new Studentas { Vardas = vardas, Pazymys = pazymys };

       
        string ivertinimas = studentas.NustatytiIvertinima();
        Console.WriteLine(ivertinimas);
    }
}
