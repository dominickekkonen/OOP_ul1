namespace OOP_ul1
{
    public class Õpilane : Isik
    {
        public int Klass { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis.");
        }
    }
}
