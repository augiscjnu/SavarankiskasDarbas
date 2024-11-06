namespace TransportoPriemonesSistema
{
    public class Automobilis : TransportoPriemone
    {
        public Automobilis(int greitis) : base(greitis)
        {
        }

       
        public override double ApskaiciuotiKelionesLaika(int atstumas)
        {
            return (double)atstumas / Greitis;
        }
    }
}
