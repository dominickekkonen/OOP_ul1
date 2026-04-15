namespace OOP_ul1
{
    public abstract class Isik
    {
        public string Nimi { get; set; }
        public int Sünniaasta { get; set; }
        public int Vanus => DateTime.Now.Year - Sünniaasta;
        public Isik() { }
        public Isik(string nimi)
        {
            Nimi = nimi;
        }
        public abstract void Kirjelda();

        public void Tervita()
        {
            if (string.IsNullOrEmpty(Nimi) || Sünniaasta == 0)
            {
                Console.WriteLine("Ei tea veel oma nime ega sünniaastaid.");
            }
            else
            {
                Console.WriteLine($"Tere! Mina olen {Nimi}, ma olen {Vanus} aastat vana ja olen sündinud {Sünniaasta} aastal.");
            }
        }
    }
}