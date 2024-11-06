public class PusėEtato : Darbuotojas
{
    
    public PusėEtato(string vardas, decimal atlyginimas)
        : base(vardas, atlyginimas)
    {
    }

   
    public decimal GautiValandinįAtlyginimą()
    {
        return Atlyginimas / 160;
    }
}
