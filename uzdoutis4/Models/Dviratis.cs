namespace TransportoPriemonesSistema
{
    public class Dviratis : TransportoPriemone
    {
        public Dviratis(int greitis) : base(greitis)
        {
        }

        
        public override double ApskaiciuotiKelionesLaika(int atstumas)
        {
            int maksimalusGreitis = 20;
            int galutinisGreitis = Math.Min(Greitis, maksimalusGreitis);
            return (double)atstumas / galutinisGreitis;
        }
    }
}
