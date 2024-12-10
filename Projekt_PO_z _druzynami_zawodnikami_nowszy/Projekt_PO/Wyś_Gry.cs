using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public class Wyś_Gry : Wyś_Druzyny
    {
        public void WyswietlGry(List<Gry> List)
        {
            Console.Clear();
            foreach (Gry gra in List)
            {
                System.Console.WriteLine(gra.Nazwa);
            }
        }
    }
}
