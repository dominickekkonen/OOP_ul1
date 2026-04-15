using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_ul1
{
    public enum Töötüüp
    {
        Palk,
        Toetus
    }
    public interface ITööline
    {
        public Töötüüp VäljamakseTüüp { get; set; } // Töö tüübi omadus
        double ArvutaPalk(); // Ainult meetodi allkiri
    }
    // Õpetaja pärib Isik klassist JA rakendab ITööline liidest
}
