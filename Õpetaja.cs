namespace OOP_ul1
{
    public class Õpetaja : Isik
    {
        public string Aine { get; set; }

        // override kirjutab abstraktse meetodi üle
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
    }
}
