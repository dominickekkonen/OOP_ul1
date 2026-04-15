namespace OOP_ul1
{
    public enum Õppevorm
    {
        Päevane,
        Kaugõpe,
        Ekstern,
        Akadeemilinepuhkus
    }

    public class Õpilane : Isik, ITööline
    {
        public int Klass { get; set; }
        public string Kool { get; set; }
        public double KeskHinne { get; set; }
        public int Puudumised { get; set; } = 0;
        public bool SotsToend { get; set; }
        public Õppevorm Staatus { get; set; }
        public Töötüüp VäljamakseTüüp { get; set; } = Töötüüp.Toetus;
        public Õpilane() : base() { }

        public Õpilane(string nimi, int klass, Õppevorm staatus) : base(nimi)
        {
            Klass = klass;
            Staatus = staatus;
        }

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}. Toetus: {ArvutaPalk()}€");
        }

        public double ArvutaPalk()
        {
            double põhitoetus = 0;
            double eritoetus = 0;
            if (Puudumised <= 100 && KeskHinne >= 3.9)
            {
                põhitoetus = 60;
            }
            if (SotsToend)
            {
                eritoetus = 120;
            }

            return põhitoetus + eritoetus;
        }
    }
}