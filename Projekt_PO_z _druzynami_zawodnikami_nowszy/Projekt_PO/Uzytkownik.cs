using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO { 
public class Uzytkownik
{
    public string Nazwa_uzytkownika { get; set; }
    public string Haslo { get; set; }

    public Uzytkownik(string nazwaUzytkownika, string haslo)
    {
        Nazwa_uzytkownika = nazwaUzytkownika;
        Haslo = haslo;
    }
    }
}
