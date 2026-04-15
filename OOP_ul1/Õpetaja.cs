namespace OOP_ul1
{
    public class Õpetaja : Isik, ITööline
    {
        public double Tunnitasu { get; set; }
        public int TunnidNädalas { get; set; }
        public string Aine { get; set; }
        public Töötüüp VäljamakseTüüp { get; set; } = Töötüüp.Palk;
        public Õpetaja() : base() { }
        public Õpetaja(string nimi, string aine, int tunnidNädalas, double tunnitasu) : base(nimi)
        {
            Aine = aine;
            TunnidNädalas = tunnidNädalas;
            Tunnitasu = tunnitasu;
        }
        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}. Kuupalk: {ArvutaPalk()}€");
        }
        public double ArvutaPalk()
        {
            return Tunnitasu * TunnidNädalas * 4;
        }
    }
}