using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public class Wyś_Druzyny: Wyś_Uż_Drużyny
    {
        public void WyswietlDruzyny(string gra)
        {
            Console.Clear();
            string druzynyFilePath = $"{gra}_druzyny.txt";
            if (File.Exists(druzynyFilePath))
            {
                Console.WriteLine($"Lista dostępnych drużyn dla gry {gra.Replace('_', ' ')}:");
                string[] druzyny = File.ReadAllLines(druzynyFilePath);

                for (int i = 0; i < druzyny.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {druzyny[i]}");
                }

                Console.Write("Wybierz drużynę (wpisz numer): ");
                if (int.TryParse(Console.ReadLine(), out int wybor) && wybor > 0 && wybor <= druzyny.Length)
                {
                    string wybranaDruzyna = druzyny[wybor - 1];
                    Console.WriteLine($"Wybrałeś drużynę: {wybranaDruzyna}");
                    WyswietlUzytkownikowZDruzyny(gra, wybranaDruzyna);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór.");
                }
            }
            else
            {
                Console.WriteLine($"Plik z drużynami dla gry {gra.Replace('_', ' ')} nie istnieje.");
            }
        }
    }
}
