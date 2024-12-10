using System;
using System.Collections.Generic;
using System.IO;
using Projekt_PO;

public class Program : Rejestracja
{
    //Obsługa gita
    //git add .
    //git commit -m ""
    //git push (wysyłanie)
    //git pull (pobieranie)
    // Punkt wejścia
    public static void Main()
    {
        
        // Tworzenie instancji klasy Program
        Program program = new Program();
        program.G_Program(); // Wywołanie niestatycznej metody ez()
    }
    public void G_Program()
    {

        Console.WriteLine("Witaj w aplikacji bukmacherskiej wybierz co chcesz zrobić: \n" +
                          "1. Zaloguj na istniejące konto. \n" +
                          "2. Stwórz nowego użytkownika.\n" +
                          "3. Wyjście");
        string opcja = Console.ReadLine();
        switch (opcja)
        {
            case "1":
                Zaloguj();
                break;
            case "2":
                Zarejestruj();
                break;
            case "3":
                Console.WriteLine("Zamykam aplikację...");
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór.");
                break;
        }
    }












    /*
    public static void WyswietlGry(List<Gry> List)
    {
        foreach (Gry gra in List)
        {
            System.Console.WriteLine(gra.Nazwa);
        }
    }
    */
    /*
    static void Zaloguj(List<Gry> L_Gry)
    {
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
                WybierzGre(L_Gry);
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
    */
    /*
    static void Zarejestruj()
    {
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
    */
    /*
    static void WybierzGre(List<Gry> L_Gry)
    {       
        Console.WriteLine("Wybierz grę, którą chcesz obserwować:");
        WyswietlGry(L_Gry);
        Console.WriteLine("5. Wyloguj");
        string wybor = Console.ReadLine();
        string wybranaGra = null;
        
        switch (wybor)
        {
            case "1":
                wybranaGra = "League_of_Legends";
                break;
            case "2":
                wybranaGra = "Counter_Strike";
                break;
            case "3":
                wybranaGra = "World_of_Warcraft";
                break;
            case "4":
                wybranaGra = "EA_FC_25";
                break;
            case "5":
                Console.WriteLine("Wylogowano. Powrót do menu głównego.");
                return;
            default:
                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                WybierzGre(L_Gry); // Rekurencja do ponownego wyboru
                return;
        }
        
        WyswietlDruzyny(wybranaGra);
    }
    */

    /*
    static void WyswietlDruzyny(string gra)
    {
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
    */

    /*
    static void WyswietlUzytkownikowZDruzyny(string gra, string druzyna)
    {
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
    */
}


