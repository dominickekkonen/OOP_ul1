namespace OOP_ul1
{
    public abstract class Isik
    {
        public string Nimi { get; set; }

        // Abstraktne meetod – sisu puudub, alamklassid PEAVAD selle ise looma
        public abstract void Kirjelda();

        public void Tervita()
        {
            if (string.IsNullOrEmpty(Nimi) || sünniaasta == 0)
            {
                Console.WriteLine("Ei tea vaal oma nimeega sünniaastad");
            }
            else
            {
                Console.WriteLine($"Tere! Mina olen {Nimi} ma olen {Vanus} aastad vana ja olen sündinud {Sünniaasta} aastal.");
            }
        }
    }
}
