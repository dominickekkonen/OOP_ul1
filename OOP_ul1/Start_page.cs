namespace OOP_ul1
{
    public class Start_page
    {
        public static void Main(string[] args)
        {
            List<ITööline> palgaasjad = new List<ITööline>();

            // --- Manually created teachers ---
            Õpetaja Mari = new Õpetaja();
            Mari.Nimi = "Mari";
            Mari.Sünniaasta = 1998;
            Mari.Aine = "Sotsiaalained";
            Mari.TunnidNädalas = 28;
            Mari.Tunnitasu = 50;

            Õpetaja Juri = new Õpetaja
            {
                Nimi = "Juri",
                Sünniaasta = 1980,
                Aine = "Programmeerimise alused",
                TunnidNädalas = 21,
                Tunnitasu = 40
            };
            Õpilane Dmitri = new Õpilane();
            Dmitri.Nimi = "Dmitri";
            Dmitri.Sünniaasta = 2008;
            Dmitri.Puudumised = 7;
            Dmitri.KeskHinne = 4.67;
            Dmitri.Klass = 10;
            Õpilane Kati = new Õpilane
            {
                Nimi = "Kati",
                Sünniaasta = 2009,
                Puudumised = 120,
                Klass = 9,
                KeskHinne = 2,
                SotsToend = false
            };
            palgaasjad.Add(Mari);
            palgaasjad.Add(Juri);
            palgaasjad.Add(Dmitri);
            palgaasjad.Add(Kati);
            Random rnd = new Random();
            string[] nimed = { "Mati", "Kati", "Juri" };

            for (int i = 0; i < nimed.Length; i++)
            {
                Õpilane õpilane = new Õpilane
                {
                    Nimi = nimed[rnd.Next(nimed.Length)],
                    Klass = rnd.Next(1, 13),
                    Kool = "TTHK",
                    KeskHinne = Math.Round(rnd.NextDouble() * 5, 2),
                    Puudumised = rnd.Next(0, 350),
                    SotsToend = rnd.Next(0, 2) == 1,
                    Staatus = (Õppevorm)rnd.Next(0, 4)
                };
                palgaasjad.Add(õpilane);
            }

            // FIX: foreach is now OUTSIDE the for loop – prints after all are added
            Console.WriteLine("\n--- PALGALEHT ---");
            foreach (ITööline isik in palgaasjad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString().ToLower();
                string nimi = ((Isik)isik).Nimi;
                Console.WriteLine($"{nimi}le {tüüp} summa: {isik.ArvutaPalk()}€");
            }
        }
    }
}