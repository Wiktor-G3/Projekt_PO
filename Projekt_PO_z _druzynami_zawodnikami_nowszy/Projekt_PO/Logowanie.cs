using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{

    public class Logowanie : Wyb_Gre
    {
        // Logowanie użytkownika
        public void Zaloguj()
        {
            Console.Clear();
            Console.WriteLine("Podaj nazwę użytkownika: ");
            string nazwaUzytkownika = Console.ReadLine();
            Console.Write("Podaj hasło: ");
            string haslo = Console.ReadLine();

            string filePath = $"{nazwaUzytkownika}.txt";
            if (File.Exists(filePath))
            {
                string[] dane = File.ReadAllLines(filePath);
                if (dane.Length == 2 && dane[0] == nazwaUzytkownika && dane[1] == haslo)
                {
                    Console.WriteLine("Zalogowano pomyślnie!");
                    WybierzGre(); // Wywołanie metody WybierzGre
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa nazwa użytkownika lub hasło.");
                }
            }
            else
            {
                Console.WriteLine("Użytkownik o podanej nazwie nie istnieje.");
            }
        }
    }
}
