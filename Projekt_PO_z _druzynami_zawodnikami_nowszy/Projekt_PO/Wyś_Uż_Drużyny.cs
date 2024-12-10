using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public class Wyś_Uż_Drużyny
    {
        public void WyswietlUzytkownikowZDruzyny(string gra, string druzyna)
        {
            Console.Clear();
            string uzytkownicyFilePath = $"{gra}_{druzyna}_uzytkownicy.txt";
            if (File.Exists(uzytkownicyFilePath))
            {
                Console.WriteLine($"Lista użytkowników w drużynie {druzyna} dla gry {gra.Replace('_', ' ')}:");
                string[] uzytkownicy = File.ReadAllLines(uzytkownicyFilePath);

                foreach (string uzytkownik in uzytkownicy)
                {
                    Console.WriteLine($"- {uzytkownik}");
                }
            }
            else
            {
                Console.WriteLine($"Plik z użytkownikami dla drużyny {druzyna} w grze {gra.Replace('_', ' ')} nie istnieje.");
            }
        }
    }
}
