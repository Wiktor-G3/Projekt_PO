using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public class Rejestracja: Logowanie
    {
        public void Zarejestruj()
        {
            Console.Clear();
            Console.Write("Podaj nazwę użytkownika: ");
            string nazwaUzytkownika = Console.ReadLine();

            string filePath = $"{nazwaUzytkownika}.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("Użytkownik o tej nazwie już istnieje.");
                return;
            }

            Console.Write("Podaj hasło: ");
            string haslo = Console.ReadLine();

            // Tworzenie pliku z danymi użytkownika
            File.WriteAllLines(filePath, new[] { nazwaUzytkownika, haslo });
            Console.WriteLine("Rejestracja zakończona pomyślnie!");
        }
    }
}
