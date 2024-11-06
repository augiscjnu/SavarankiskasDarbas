using System;



public class Knyga
{
    public string Pavadinimas { get; set; }
    public int PuslapiuSkaicius { get; set; }

   
    public Knyga(string pavadinimas, int puslapiuSkaicius)
    {
        Pavadinimas = pavadinimas;
        PuslapiuSkaicius = puslapiuSkaicius;
    }

    
    public string KlasifikuotiKnyga()
    {
        if (PuslapiuSkaicius < 100)
        {
            return $"{Pavadinimas} yra Trumpo ilgio knyga.";
        }

        else if (PuslapiuSkaicius >= 100 && PuslapiuSkaicius <= 300)
        {
            return $"{Pavadinimas} yra Vidutinio ilgio knyga.";
        }
        else
        {
            return $"{Pavadinimas} yra Ilga knyga.";
        }
    }
}
