using System;

public class Studentas
{
    public string Vardas { get; set; }
    public int Pazymys { get; set; }

   
    public string NustatytiIvertinima()
    {
        if (Pazymys < 4)
        {
            return $"{Vardas} įvertinimas: Neišlaikė";
        }
        else if (Pazymys >= 4 && Pazymys <= 6)
        {
            return $"{Vardas} įvertinimas: Patenkinamas";
        }
        else if (Pazymys >= 7 && Pazymys <= 8)
        {
            return $"{Vardas} įvertinimas: Geras";
        }
        else if (Pazymys >= 9 && Pazymys <= 10)
        {
            return $"{Vardas} įvertinimas: Labai geras";
        }
        else
        {
            return "Įvestas neteisingas pažymys. Pažymys turi būti tarp 1 ir 10.";
        }
    }
}
