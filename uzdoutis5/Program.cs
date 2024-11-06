using FailoSkaitimasCore.Contrackts;
using FailoSkaitimasCore.Repo;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        string failoKelias = "vartotojai.txt";

        
        IFailoSkaitymas failoSkaitymas = new FailoSkaitymas();
        IDoumenuServisas duomenuServisas = new DuomenuServisas();

       
        var duomenys = failoSkaitymas.skaitytiDoumenis(failoKelias);

        double vidutinisAmzius = duomenuServisas.ApskaiciuotiVidutiniAmziu(duomenys);

        
        Console.WriteLine($"Vidutinis amžius: {vidutinisAmzius:F2} metų");
    }
}
