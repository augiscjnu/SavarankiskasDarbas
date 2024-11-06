using FailoSkaitimasCore.Contrackts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailoSkaitimasCore.Repo
{
    public class DuomenuServisas : IDoumenuServisas
    {
        public double ApskaiciuotiVidutiniAmziu(List<string> duomenys)
        {
            double suma = 0;
            int kiekis = 0;

            foreach (var eilute in duomenys)
            {
                
                var dalys = eilute.Split(',');

                if (dalys.Length == 2 && int.TryParse(dalys[1], out int amzius))
                {
                    suma += amzius;
                    kiekis++;
                }
                else
                {
                    Console.WriteLine($"Netinkamas duomenų formatas: {eilute}");
                }
            }

            return kiekis > 0 ? suma / kiekis : 0;
        }
    }
}
