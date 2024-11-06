using System;

namespace TransportoPriemonesSistema
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Pasirinkite transporto priemonės tipą:");
            Console.WriteLine("1. Automobilis");
            Console.WriteLine("2. Dviratis");

            int pasirinkimas = 0;
            while (true)
            {
                Console.Write("Įveskite pasirinkimą (1 arba 2): ");
                if (int.TryParse(Console.ReadLine(), out pasirinkimas) && (pasirinkimas == 1 || pasirinkimas == 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Netinkamas pasirinkimas. Bandykite dar kartą.");
                }
            }

            
            Console.Write("Įveskite transporto priemonės greitį (km/h): ");
            int greitis;
            while (!int.TryParse(Console.ReadLine(), out greitis) || greitis <= 0)
            {
                Console.Write("Įveskite teisingą greitį (teigiamas skaičius): ");
            }

            
            Console.Write("Įveskite kelionės atstumą (km): ");
            int atstumas;
            while (!int.TryParse(Console.ReadLine(), out atstumas) || atstumas <= 0)
            {
                Console.Write("Įveskite teisingą atstumą (teigiamas skaičius): ");
            }

           
            TransportoPriemone transportoPriemone;

            if (pasirinkimas == 1)
            {
                transportoPriemone = new Automobilis(greitis);
            }
            else
            {
                transportoPriemone = new Dviratis(greitis);
            }

          
            double kelionesLaikas = transportoPriemone.ApskaiciuotiKelionesLaika(atstumas);
            Console.WriteLine($"Kelionės laikas: {kelionesLaikas:F2} val.");
        }
    }
}
