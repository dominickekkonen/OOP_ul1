namespace OOP_ul1
{
    public class Start_page
    {
        public static void Main(string[] args)
        {
            Isik inimene1 = new Isik();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta = 1998;
            inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...
            //Loome uus õpetaja
            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Mari";
            õpetaja1.Sünniaasta = 2000;
            õpetaja1.Aine = "Inglise keel";
            õpetaja1.Tervita();
            õpetaja1.Õpeta();
            //Loome uus õpilane
            Õpilane õpilane1 = new Õpilane();
            õpilane1.Kool = "KutseHariduskeskus";
            õpilane1.Klass = 11;
            õpilane1.Tervita();
            õpilane1.Õpi();
        }
    }
}