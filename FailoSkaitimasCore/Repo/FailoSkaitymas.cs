using FailoSkaitimasCore.Contrackts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailoSkaitimasCore.Repo
{
    public class FailoSkaitymas : IFailoSkaitymas
    {
        public List<string> skaitytiDoumenis(string failoKelias)
        {
            List<string> doumenys = new List<string>();

            try 
            {
                doumenys = new List<string>(File.ReadAllLines(failoKelias));
            
           
            
            }

            catch(Exception ex)
            {

                Console.WriteLine($"klaida skaitant faila: {ex.Message}");
            }



            return doumenys;
        }




    }
}
